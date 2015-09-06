# qwinapt
**Automatically exported from http://code.google.com/p/qwinapt**

##Quick Windows Apt tools

####Why QWinApt?
I like ubuntu's Install/Uninstall tools very much. Hope to find a same tool under windows, but there is none. So, I decided to write an application by myself.

It will be simple, and will enhance step by step.

For some personal reason, I use C# and .NET 2.0.

* Ubuntu Like GUI
* Easy Use
* Most of Green and Free softwares
* Free

##Tools
####QWinAptClient
Like Ubuntu's install tool. It load Data from DB file. You can use it to download applications, or delete applications that you have already downloaded. Because Windows's installation is totally different from Linux's. So it will only download a file that you can install it as you like.

####QWinAptConfigTool
You can use this tool to config your own DB file. Actually I will use it to maintain the main DB file on this server. I'm also glad to receive users config file that made by this tool, then I could easily merge it with the main DB file.

####QWinAptParser
I use it(these) to create DB file from other page.
You can download source code in source trunk.

##Usage
####Download files
Download files from this page, includes QWinApt-x.x.x.zip(Main Client Application), wget.zip(if you don't have one), zh-CN.zip(if you are Chinese user).

####Install it
It is totally green, just extract to your disk. If you also downloaded zh-CN.zip, put the folder zh-CN in the same directory with WinApt.Client.exe. If you downloaded wget.zip, put wget.exe in system %PATH% so the application can find it.

####Need to Know
If you run it at first time, it will:

1. Popup to request a simple config, which let you choose the base directory that need to save the downloaded files.
2. Download DB file from **Project Home**, so make sure your network works fine.
3. You can update DB file by clicking update button in main form.
4. When you finish downloading a file, click it with right mouse button, then you can explore it or install it. Please see the following pictures.

##Screenshots:
###Main Form
![Image of winapttool](http://lh5.google.com/hzgnpu/Ruqp5gck-iI/AAAAAAAAAI0/3BJu7DOYDfM/winapttool.jpg)

###Download a File
![Image of winaptdownload](http://lh5.google.com/hzgnpu/Ruqp5gck-jI/AAAAAAAAAI8/W3o346RPiXA/winaptdownload.jpg)

###Explore & Install
![Image of winaptdemo](http://lh3.google.com/hzgnpu/RvISEjq6AbI/AAAAAAAAAKQ/LodwQaMt4Xc/winaptdemo.jpg)

##Author's Blog
[tinylee's blog](http://tinylee.blogspot.com/)
