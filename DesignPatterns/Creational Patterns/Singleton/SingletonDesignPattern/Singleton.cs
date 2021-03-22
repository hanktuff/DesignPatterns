﻿namespace SingletonDesignPattern {
    public class Singleton {

        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance() {

            if (_instance == null) {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
