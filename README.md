# dockeraspnetcoreapp
Attribution: Building Microservices with ASP.NET Core by Kevin Hoffman(O'Reilly). Copyright 2017 Kevin Hoffman, 978-1-491-96173-5
Clone this repository :
git clone https://github.com/ankushbanerjee/dockeraspnetcoreapp.git

Now, build and run the Docker image
  Step1. Open a command prompt and navigate to your project folder.
  Step2. Use the following commands to build and run your Docker image:
           docker build -t aspnetapp .
           docker run -d -p 8080:80 --name myapp aspnetapp

On Your docker desktop you should see something like this:

<img width="1030" alt="Screen Shot 2022-01-04 at 8 07 54 AM" src="https://user-images.githubusercontent.com/43915732/148071488-5a82a846-ae9f-4b9c-991a-3198d92e7adb.png">

