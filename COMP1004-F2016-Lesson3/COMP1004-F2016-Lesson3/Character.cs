using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP1004_F2016_Lesson3
{
    public class Character
    {
        /**
         * PRIVATE INSTANCE VARIABLES 
         */
        private string _strength;

        /**
         * PUBLIC PROPERTIES 
         */
        public string Strength
        {
            get
            {
                return this._strength;
            }

            set
            {
                this._strength = value;
            }
        }
    }
}