using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public string ElPath
    {
        get { return _path; }
        private set => SetPath(value);
    }

    public string ElSize
    {
        get { return _size; }
        private set => SetSize(value);
    }

    //Constructor
    public Photo(string elPath, int elSize)
    {
        this.SetPath(elPath);
        this.SetSize(elSize);
    }

    public void SetPhoto(string elPath)
    {
        if (EmptyString(elPath) || !ValidFormatPhoto(elPath))
        {
            throw new InvalidOperationException("Password no valida");
        }
        else
        {
            this._password = password.GetHashCode().ToString();

        }
    }

    public bool ValidLenghtPassword(string password)
    {
        return password.Length >= MIN_LENGTH_FOR_VALID_PASSWORD;
    }


    private bool ValidPathSpecialFormat(string str)
    {
        return Regex.IsMatch(str, str.Length-3) ".jpg");


    }

    private bool EmptyString(string value)
    {
        return value.Length.Equals(0);
    }

    private bool Equals(Password pass)
    {
        return this.LaPassword.Equals(pass.LaPassword);
    }

    public bool CheckPassword(Password password)
    {

        if (!this.Equals(password))
        {
            throw new InvalidOperationException("Password incorrecta");
        }
        else
        {
            return true;

        }
    }

