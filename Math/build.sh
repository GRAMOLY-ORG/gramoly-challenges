if [ ! -f appsettings.json ];
then
	echo appsettings.json file not found
	echo you can check appsettings.json.sample for an example
	exit
fi

cp appsettings.json "src/iCTF Website"
cp appsettings.json "src/iCTF Discord Bot"
cp appsettings.json "src/iCTF Shared Resources" # useless

cd src
dotnet publish -c release
