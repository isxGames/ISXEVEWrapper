function atexit()
{
 	echo "Script -- Ended"
	return
}

function main(... Args)
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
  
	; 'Args' is an array ... arrays are static.  Copying to an index just in case we have a desire at some point to add/remove elements.
	if ${Args.Size} > 0
	{
		dotnet ${Args[1]} "${LavishScript.HomeDirectory}/.NET Programs/${Args[1]}.exe"
	}
	else
	{
		echo "ERROR: You must specify an argument!"
	}
	
	return
}
