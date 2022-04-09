namespace Ex2
    {
        public class Apple : Celular
        {
            public Apple()
         {
            Descricao = "APPLE";
            Bateria = new BateriaApple();
            Camera = new CameraApple();
            Gps = new GpsApple();
            Visor = new VisorApple();
        }

    }
}

