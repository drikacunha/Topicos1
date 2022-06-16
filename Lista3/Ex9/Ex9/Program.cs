namespace Ex9
{
	class Program
{
		static void Main(String[] args)
		{

			DietInfo dietInfo = new DietInfo();

			dietInfo.enviarMensagem("Nicole", "1", "50");
			dietInfo.setDietInfo("Sandra", "2", "60");
			dietInfo.setDietInfo("Lucas", "4", "80");
			dietInfo.mostrarInfo();

			System.out.println("Retirando a 3º linha");
			dietInfo.desfazerEscrita();
			dietInfo.mostrarInfo();

			System.out.println("Retirando a 2º linha");
			dietInfo.desfazerEscrita();
			dietInfo.mostrarInfo();

			System.out.println("Retirando a 1º linha");
			dietInfo.desfazerEscrita();
			dietInfo.mostrarInfo();

		}
	}

}