# GDrive for LabVIEW
##Access your Google Drive files from LabVIEW

This toolkit allows users to directly upload/download files to/from their Google drive. Authentication was completed by the OAuth method documented here.  This toolkit was created as a wrapper for the Google Drive .NET API that can be found online. Developers must obtain their own Client Secret JSON, found here. The Initialize VI requires this file to function, so a user must give a path to their Client Secret JSON for proper toolkit functionality. For more information on how to fill out this form, look to the bottom of this document under “How to fill out the wizard.”

## Initialize VI
> This VI will use OAuth to authenticate a user for their Google Drive Account the first time that this VI is called in LabVIEW. After that, this VI does not execute, but it is required for all functionalities of the drive, as it contains the authentication within the Drive Service Reference. 
> Input: Path to Secret Client JSON
> Output: Google Drive Service Reference

## DownloadFile VI
> Given a specific file reference, this VI will download the file to a specified local path
> Input: Desired file path, Google Drive Service Reference, and file reference. 
> Output: File is downloaded to the specified path

## ListFiles VI
> Outputs an array that contains references to the files on a user's Google Drive. These references can be used in other VIS to access file properties and metadata
> Input: Google Drive Serivce Reference
> Output: Array of Google drive File References

## UploadFile VI
> Summary: Uploads a file to Google Drive
> Input: File Path, Google Drive Service Reference, Desired File Name on Drive
> Output: File specified by the path is uploaded to the Google Drive authenticated by the Google Drive Service Reference.

## NamedFilesOnDrive VI
> Lists the files on the Google Drive
> Input: Google Drive Service Reference
> Output: Array of file names, corresponding to the files on the user's Google Drive

## FindFile VI
> Finds a reference to a specific file on a user's Google Drive
> Input: Array of file references, file name
> Output: File Reference

#Examples
There are two examples attached that demonstrate the work flow. 
> Upload example: Demonstrates the steps required to take a file from your local machine and upload it to the user’s google drive.

> Download example: Demonstrates the steps required to take a file from the user’s google drive and download it to your local machine. 

"#labview-gdrive" 
