namespace Ex2
    {
        public class Apple : Celular
        {
            public Apple()
         {
            Bateria = new BateriaApple();
            Camera = new CameraApple();
            Gps = new GpsApple();
            Visor = new VisorApple();
        }

    }
}

