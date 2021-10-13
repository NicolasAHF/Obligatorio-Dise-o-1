using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class Photo
    {
        private string _path;
        private long _size;
        const long MAX_SIZE_FOR_VALID_PHOTO = 5000;//Byte

        public string ElPath
        {
            get { return _path; }
            private set => SetPath(value);
        }

        public long ElSize
        {
            get { return _size; }
            private set => SetSize(value);
        }


        public Photo(string path, long size)
        {
            this.ElPath = path;
            this.ElSize = size;
        }

        public void SetPath(string elPath)
        {
            NullorEmptyString(elPath);
            ValidPathSpecialExtension(elPath);

            this._path = elPath;
        }

        public void SetSize(long elSize)
        {
            if (elSize < 0 || elSize > MAX_SIZE_FOR_VALID_PHOTO)
            {
                throw new InvalidOperationException("El tamaño de la foto excede el valor permitido " +MAX_SIZE_FOR_VALID_PHOTO+" Byte");
            }
            else
            {
              this._size = elSize;
            }
        }

        private void ValidPathSpecialExtension(string path)
        {
            string extension = Path.GetExtension(path);
            extension = extension.ToLower();
            if (extension == null || (extension != ".jpg" && extension != ".jpeg" && extension != ".png"))
            {
                throw new InvalidOperationException("Extension no valida");
            }
        }

        private void NullorEmptyString(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("el Paht no puede ser nullo o vacio");
            }
        }

        private bool Equals(Photo pic)
        {
            return this.ElPath.Equals(pic.ElPath);
        }
    }
}
