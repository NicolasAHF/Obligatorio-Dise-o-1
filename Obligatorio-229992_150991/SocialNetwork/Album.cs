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

        public int Id { get; set; }

        public string Name
        {
            get { return _name; }
            set => SetName(value);
        }

        public List<Photo> PhotoList
        {
            get { return _PhotoList; }
            set => SetPhotos(value);
        }

        public Album()
        {
            this._PhotoList = new List<Photo>();
        }
        public Album(string elNombre)
        {
            this.Name = elNombre;
            this._PhotoList = new List<Photo>();
        }

        public void SetPhotos(List<Photo> photos)
        {
            this._PhotoList = photos;
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
            
            ValidePhotoMaxCantLoad();
           if (!ValidExistPhoto(photo))
            {
                this.PhotoList.Add(photo);
            }


        }
        private bool ValidName(string elNombre)
        {
            return elNombre.Length >= MIN_LENGTH_FOR_VALID_NAME;
        }

        private bool ValidExistPhoto(Photo laPhoto)
        {
            if (PhotoList.Contains(laPhoto))
            {
                throw new InvalidOperationException("La foto ya existe");
            }
            return false;
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

        public override bool Equals(object obj)
        {
            Album albumObj = obj as Album;

            if (albumObj == null || this.GetType() != albumObj.GetType())
            {
                return false;
            }

            return Id == albumObj.Id ? true : false;
        }
    }
}

