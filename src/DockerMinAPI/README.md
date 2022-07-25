# Sample Docker Commands

build: `docker build -t dockerminapi .`

run: `docker run dockerminapi`
or `docker run -d -p 8080:80 --name myapp dockerminapi`

## Env Settings and Parameters
example: `docker run -e CustomSetting="{yourClientId}" dockerminapi`
run: `docker run -e CustomSetting="mysupersettings" dockerminapi`

## Useful links
1. (link)[https://medium.com/@agustinafassina_92108/docker-net-core-and-environment-variables-b2a5e4a4c062]
2. (link)[https://developer.okta.com/blog/2019/09/18/build-a-simple-dotnet-core-app-in-docker]