using System;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    public static class ERPPictureExtensions
    {
        public static void Trim(this ERPPicture erpPicture)
        {
            erpPicture.TrimPublicStringProperties();
        }

        public static ERPPicture FromFile(this ERPPicture erpPicture, String imageFilePath)
        {
            if (string.IsNullOrEmpty(imageFilePath) || !File.Exists(imageFilePath))
            {
                throw new FileNotFoundException("The specified file does not exist.", imageFilePath);
            }

            var fileInfo = new FileInfo(imageFilePath);
            erpPicture.Name = fileInfo.Name;

            erpPicture.Details.ImageSize = (UInt64)fileInfo.Length;
            erpPicture.Details.ImageCreated = fileInfo.CreationTime;
            erpPicture.Details.ImageChanged = fileInfo.LastWriteTime;

            erpPicture.Url = new Uri(imageFilePath).AbsoluteUri;

            erpPicture.Details.ImageType = GetMimeTypeFromExtension(fileInfo.Extension);

            return erpPicture;
        }

        public static ERPPicture FromFile(String imageFilePath)
        {
            return FromFile(new ERPPicture(), imageFilePath);
        }

        private static string GetMimeTypeFromExtension(String extension)
        {
            switch (extension.ToLower())
            {
                case ".bmp":
                    return "image/bmp";

                case ".gif":
                    return "image/gif";

                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";

                case ".png":
                    return "image/png";

                case ".tiff":
                case ".tif":
                    return "image/tiff";

                default:
                    return "application/octet-stream";
            }
        }

        public static ERPProductPicture FromERPPicture(this ERPPicture erpPicture)
        {
            return new ERPProductPicture
            {
                UID = erpPicture.UID,
                ClientUID = erpPicture.ClientUID,
                Changed = erpPicture.Changed,

                Name = erpPicture.Name,
                Description = erpPicture.Description,
                IsActive = erpPicture.IsActive,
                Url = erpPicture.Url,

                Details = erpPicture.Details,
                License = erpPicture.License,

                Useage = ERPProductPictureUsage.Preview | ERPProductPictureUsage.Print | ERPProductPictureUsage.Online
            };
        }
    }
}
