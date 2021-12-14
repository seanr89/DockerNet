# NetDockerConsole

First baseline application used to test out a sample docker file and simple build and run processes

## Commands and Comments

Build an image

-   First command `docker build -t netconsole .`

Test the image

-   Run the command `docker run -it --rm netconsole`

Create the container

-   Run the command `docker create --name console-counter netconsole`

Start the container

-   Run command `docker start core-counter`

Stop the container

-   Run command `docker stop core-counter`
