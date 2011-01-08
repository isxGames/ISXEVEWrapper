function atexit()
{
 	echo "WrapTest Script -- Ended"
	return
}

function main()
{
	if !${ISXEVE(exists)}
	{
		echo "- ISXEVE must be loaded to use this script."
		return
	}
	do
	{
		waitframe
	}
	while !${ISXEVE.IsReady}
  
	dotnet wraptest "${LavishScript.HomeDirectory}/.NET Programs/ISXEVEWrapperTest.exe"
	
	return
}
