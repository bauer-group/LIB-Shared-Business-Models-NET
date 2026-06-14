using System;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    /// <summary>
    /// Extension helpers for <see cref="ERPPicture"/>.
    /// </summary>
    public static class ERPPictureExtensions
    {
        /// <summary>Trims whitespace from every public string property of the picture, in place.</summary>
        public static void Trim(this ERPPicture erpPicture)
        {
            erpPicture.TrimPublicStringProperties();
        }

        /// <summary>Populates an <see cref="ERPPicture"/> from a file on disk: name, size/timestamps, file URI and MIME type derived from the extension.</summary>
        /// <param name="imageFilePath">Path to the source image file.</param>
        /// <returns>The same <paramref name="erpPicture"/> instance, now populated from the file.</returns>
        /// <exception cref="FileNotFoundException">Thrown when <paramref name="imageFilePath"/> is empty or the file does not exist.</exception>
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

        /// <summary>Creates a fresh <see cref="ERPPicture"/> and populates it from a file on disk.</summary>
        /// <param name="imageFilePath">Path to the source image file.</param>
        /// <returns>A new <see cref="ERPPicture"/> populated from the file.</returns>
        public static ERPPicture FromFile(String imageFilePath)
        {
            return FromFile(new ERPPicture(), imageFilePath);
        }

        /// <summary>Maps a file extension to its image MIME type, defaulting to <c>application/octet-stream</c> for unknown extensions.</summary>
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

        /// <summary>Projects an <see cref="ERPPicture"/> onto an <see cref="ERPProductPicture"/>, enabling preview, print and online usage.</summary>
        /// <returns>A new <see cref="ERPProductPicture"/> populated from the picture.</returns>
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
