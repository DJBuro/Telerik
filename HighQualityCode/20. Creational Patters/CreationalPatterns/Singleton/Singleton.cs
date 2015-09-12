﻿using System;
using System.Collections.Generic;

namespace SingletonDesignPattern
{
    class Singleton
    {
        private static Singleton instance;

        protected Singleton()
        {

        }

        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}
