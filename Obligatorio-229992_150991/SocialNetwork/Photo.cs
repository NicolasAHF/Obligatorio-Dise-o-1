using System;


namespace SocialNetwork
{
    public class Photo
    {
        private string _path;
        private int _size;
        const int MAX_SIZE_FOR_VALID_PHOTO = 5;

        public string ElPath
        {
            get { return _path; }
            private set => SetPath(value);
        }

        public int ElSize
        {
            get { return _size; }
            private set => SetSize(value);
        }

        //Constructor
        // public Photo(string path, int size)
        public Photo(string path, int size)
        {
           this.SetPath(path);
           this.SetSize(size);

        }

        public void SetPath(string elPath)
        {
            if (EmptyString(elPath) || !ValidPathSpecialExtension(elPath))
            {
                throw new InvalidOperationException("El Path no es valido");
            }
            else
            {
                this.ElPath = elPath;

            }
        }

        public void SetSize(int elSize)
        {
            if (elSize > MAX_SIZE_FOR_VALID_PHOTO)
            {
                throw new InvalidOperationException("El tamaño de la imagen es excesivo");
            }
            else
            {
                this.ElSize = elSize;

            }
        }

        private bool ValidPathSpecialExtension(string path)
        {
            string extension = System.IO.Path.GetExtension(path);
            if (extension == null || (extension != ".jpg" && extension != ".jpeg" && extension != ".png"))
            {
                throw new InvalidOperationException("Extension no valida");
            }
            else
            {
                return true;
            }
        }
        private bool EmptyString(string value)
        {
            return value.Length.Equals(0);
        }

        private bool Equals(Photo pic)
        {
            return this.ElPath.Equals(pic.ElPath);
        }
    }
}
