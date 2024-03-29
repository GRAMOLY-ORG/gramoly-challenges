﻿using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using iCTF_Shared_Resources;
using iCTF_Shared_Resources.Models;
using iCTF_Shared_Resources.Managers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace iCTF_Discord_Bot.Logic
{
    public static class UtilLogic
    {
        #region About
        public static async Task AboutSlashAsync(SocketSlashCommand command)
        {
            var embed = GetAboutEmbed();
            await command.RespondAsync(embed: embed);
        }

        public static async Task AboutCommandAsync(SocketCommandContext context)
        {
            var embed = GetAboutEmbed();
            await context.Channel.SendMessageAsync(embed: embed);
        }

        private static Embed GetAboutEmbed()
        {
            var eb = new CustomEmbedBuilder();
            eb.WithThumbnailUrl("https://cdn.discordapp.com/avatars/817476388508139530/a009d0593032358ab5c46d36b8075db9.webp?size=256");
            eb.WithTitle("About");
            eb.AddField("Purpose", "This bot is used for daily challenges for the GRAMOLY Server");
            eb.AddField("Discord", "Join the GRAMOLY's Discord Server:\n<https://gramoly.org/discord>");
            return eb.Build();
        }
        #endregion

        #region Help
        public static async Task HelpSlashAsync(SocketSlashCommand command, CommandService commandService)
        {
            string category = command.Data.Options?.FirstOrDefault(x => x.Name == "category")?.Value as string;
            Embed embed;
            if (!string.IsNullOrEmpty(category)) embed = GetCategoryHelpEmbed(commandService, category);
            else embed = GetHelpEmbed(commandService);
            if (embed != null) await command.RespondAsync(embed: embed);
            else await command.RespondAsync("That's not a valid category name.");
        }

        public static async Task HelpCommandAsync(SocketCommandContext context, CommandService commandService, string category = null)
        {
            Embed embed;
            if (!string.IsNullOrEmpty(category)) embed = GetCategoryHelpEmbed(commandService, category);
            else embed = GetHelpEmbed(commandService);
            if (embed != null) await context.Channel.SendMessageAsync(embed: embed);
            else await context.Channel.SendMessageAsync("That's not a valid category name.");
        }

        private static Embed GetHelpEmbed(CommandService commandService)
        {
            var eb = new CustomEmbedBuilder();
            eb.WithTitle("Available Commands");

            var mainCommandsNames = new string[] { "answer", "stats" };
            var mainCommands = commandService.Commands.Where(x => mainCommandsNames.Contains(x.Name));

            eb.Description += "\n**Main Commands**";

            foreach (var command in mainCommands)
            {
                eb.Description += $"\n`p!{command.Name}";
                foreach (var parameter in command.Parameters)
                {
                    if (parameter.IsOptional)
                        eb.Description += $" [{parameter.Name}]";
                    else
                        eb.Description += $" <{parameter.Name}>";
                }
                eb.Description += "`";
                var requirePermission = command.Preconditions.OfType<RequireUserPermissionAttribute>().FirstOrDefault();
                if (requirePermission != null)
                {
                    eb.Description += " :star:";
                }
                eb.Description += $"\n➜ {command.Summary}";
                var requireContext = command.Preconditions.OfType<RequireContextAttribute>().FirstOrDefault();
                if (requireContext != null)
                {
                    switch (requireContext.Contexts)
                    {
                        case ContextType.DM:
                            eb.Description += " (DMs only)";
                            break;
                        case ContextType.Guild:
                            eb.Description += " (Guild only)";
                            break;
                    }
                }
            }

            eb.Description += "\n\n**Other Commands**";

            foreach (var module in commandService.Modules)
            {
                eb.Description += $"\n`p!help {module.Name}`";
            }

            eb.WithFooter("Starred commands require the user to have certain permissions");

            return eb.Build();
        }

        private static Embed GetCategoryHelpEmbed(CommandService commandService, string category)
        {
            var module = commandService.Modules.FirstOrDefault(x => x.Name.ToLower() == category.ToLower());
            if (module == null) return null;

            var eb = new CustomEmbedBuilder();
            eb.WithTitle("Available Commands");

            foreach (var command in module.Commands)
            {
                eb.Description += $"\n`p!{command.Name}";
                foreach (var parameter in command.Parameters)
                {
                    if (parameter.IsOptional)
                        eb.Description += $" [{parameter.Name}]";
                    else
                        eb.Description += $" <{parameter.Name}>";
                }
                eb.Description += "`";
                var requirePermission = command.Preconditions.OfType<RequireUserPermissionAttribute>().FirstOrDefault();
                if (requirePermission != null)
                {
                    eb.Description += " :star:";
                }
                eb.Description += $"\n➜ {command.Summary}";
                var requireContext = command.Preconditions.OfType<RequireContextAttribute>().FirstOrDefault();
                if (requireContext != null)
                {
                    switch (requireContext.Contexts)
                    {
                        case ContextType.DM:
                            eb.Description += " (DMs only)";
                            break;
                        case ContextType.Guild:
                            eb.Description += " (Guild only)";
                            break;
                    }
                }
            }

            eb.WithFooter("Starred commands require the user to have certain permissions");

            return eb.Build();
        }
        #endregion
    }
}
