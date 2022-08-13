
## Build
run `docker build -t filecreator .`

## Run
standard docker run does not allow for host file volume allocation

## Compose Work
Compose is required for using host volumes!
run `docker compose up -d`