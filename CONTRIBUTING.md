# Contributing to GDrive for LabVIEW

Contributions to GDrive for LabVIEW are welcome from all!

GDrive for LabVIEW is managed via [git](https://git-scm.com), with the canonical upstream
repository hosted on [GitHub](http://developercertificate.org/).

GDrive for LabVIEW follows a pull-request model for development.  If you wish to
contribute, you will need to create a GitHub account, fork this project, push a
branch with your changes to your project, and then submit a pull request.

See [GitHub's official documentation](https://help.github.com/articles/using-pull-requests/) for more details.

# Getting Started

Download the LabVIEW project above. In order to use this code, you will need to download your own client_secret.json file using [this wizard](https://console.developers.google.com/flows/enableapi?apiid=drive&pli=1). Follow the following steps to get the JSON file:
1.  Open the wizard and press continue (make sure that the drop down selector says “create a project”)
2.  On the next page, click “go to credentials” 
3.  You should now see a page titled “Add Credentials to your project”
a.  Which API are you using? : Google Drive API
b.  Where will you be calling the API from?: Other UI
c.  What data will you be using?: User Data
d.  Then, click “What credentials do I need?”
4.  Create an OAuth 2.0 client ID
5.  Register your email address
6.  Product Name: GDrive for LabVIEW
7.  Download the client ID.
8.  Put this file in a place that you can easily access and rename this file: client_secret.json
9.  Use this file path in the initialize VI to authenticate your access. 
10. Note that the first time you run this VI, you will be prompted in a web browser to give permission for the GDrive to access your Google Drive account. Click allow and move forward in your development process.


# Testing

- The first time you run the Initialize VI, a web browser should come up on your screen and ask for permission for GDrive for LabVIEW to access your Google Drive. Accept this statement, close the web browser, and the code should execute as expected. 
- Make sure that the code you download can upload a file from your local machine to your Google Drive
- Make sure that you can download a file from your Google Drive to your local machine.

# Developer Certificate of Origin (DCO)

   Developer's Certificate of Origin 1.1

   By making a contribution to this project, I certify that:

   (a) The contribution was created in whole or in part by me and I
       have the right to submit it under the open source license
       indicated in the file; or

   (b) The contribution is based upon previous work that, to the best
       of my knowledge, is covered under an appropriate open source
       license and I have the right under that license to submit that
       work with modifications, whether created in whole or in part
       by me, under the same open source license (unless I am
       permitted to submit under a different license), as indicated
       in the file; or

   (c) The contribution was provided directly to me by some other
       person who certified (a), (b) or (c) and I have not modified
       it.

   (d) I understand and agree that this project and the contribution
       are public and that a record of the contribution (including all
       personal information I submit with it, including my sign-off) is
       maintained indefinitely and may be redistributed consistent with
       this project or the open source license(s) involved.

(taken from [developercertificate.org](http://developercertificate.org/))

See [LICENSE](https://github.com/ni/GDriveforLabVIEW/master/License)
for details about how GDrive for LabVIEW is licensed.
