#!/usr/bin/env bash
set -o errexit

: ${1?"Version missing - usage: $0 x.y.z"}

git pull origin master

#update Configuration.cs
sed  -i '.bak' "s/public const string Version = \".*\";/public const string Version = \"$1\";/g" src/mParticle.Sdk/Client/Configuration.cs

#update csproj
sed  -i '.bak' "s/\<Version\>.*\</\<Version\>$1\</g" src/mParticle.Sdk/mParticle.Sdk.csproj

#commit the version bump, tag, and push to private and public
git add src/mParticle.Sdk/Client/Configuration.cs
git add src/mParticle.Sdk/mParticle.Sdk.csproj
git commit -m "Update version to $1"
git tag "v$1"
git push origin "v$1"
git push origin HEAD:master