# Remove old code
Get-ChildItem -Exclude docs,Override,.gitignore | Remove-Item -Recurse -Force

# Generate new code
autorest --verbose --input-file=$PSScriptRoot/swagger.yaml --csharp --output-folder=$PSScriptRoot/.. --namespace=Kong
