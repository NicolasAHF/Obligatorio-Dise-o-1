using System;
using System.Collections;
using System.Collections.Generic;

namespace SocialNetwork
{
    public class Album
    {
        private string _name;
        const int MIN_LENGTH_FOR_VALID_NAME = 5;
        const int MAX_CANT_FOR_VALID_LOAD_PHOTO = 10;
        private List<Photo> _PhotoList = new List<Photo>();

        public string Name
        {
            get { return _name; }
            private set => SetName(value);
        }

        public List<Photo> PhotoList
        {
            get { return _PhotoList; }
        }

        public Album(string elNombre)
        {
            this.Name = elNombre;
        }

        public void SetName(string elNombre)
        {
            if (EmptyString(elNombre) || !ValidName(elNombre))
            {
                throw new InvalidOperationException("Nombre no valido");
            }
            else
            {
                this._name = elNombre;
            }
        }

        public void addPhoto(Photo photo)
        {
            ValidExistPhoto(photo);
            ValidePhotoMaxCantLoad();

            this.PhotoList.Add(photo);

        }
        private bool ValidName(string elNombre)
        {
            return elNombre.Length >= MIN_LENGTH_FOR_VALID_NAME;
        }

        private void ValidExistPhoto(Photo laPhoto)
        {
            if (PhotoList.Contains(laPhoto))
            {
                throw new InvalidOperationException("La foto ya existe");
            }
        }

    private void ValidePhotoMaxCantLoad()
    {
        if (PhotoList.Count >= MAX_CANT_FOR_VALID_LOAD_PHOTO)
        {
            throw new InvalidOperationException("No se puede agregar mas fotos al album");
        }
    }

        private bool EmptyString(string value)
        {
            return value.Length.Equals(0);
        }
    }
}

