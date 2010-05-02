using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    class User
    {
        private string _name;

        private string _photo_large;
        private string _photo_thumbnail;

        private bool _isTeacher;
        private DateTime _birthday = new DateTime(1987, 01, 01);
        private string _disipline;

        private string _contacts_cellphone;
        private string _contacts_phone;
        private string _contacts_links;

        private string[] _photos_large;
        private string[] _photos_thumbnails;

        private string[] _videos_large;
        private string[] _videos_thumbnails;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
            }
        }

        public string photo_large
        {
            get
            {
                return _photo_large;
            }
            set
            {
                this._photo_large = value;
            }
        }

        public DateTime birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                this._birthday = value;
            }
        }

        public string contacts_cellphone
        {
            get
            {
                return _contacts_cellphone;
            }
            set
            {
                this._contacts_cellphone = value;
            }
        }

        public string contacts_phone
        {
            get
            {
                return _contacts_phone;
            }
            set
            {
                this._contacts_phone = value;
            }
        }

        public string contacts_links
        {
            get
            {
                return _contacts_links;
            }
            set
            {
                this._contacts_links = value;
            }
        }
    }
}
