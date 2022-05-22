namespace Ex2
{
	public static void main(String[] args) {
		
		List<Integer> lista = Arrays.asList(1,9,40,3,2,0);
		
		Numeros	numeros = new Numeros(lista);
		numeros.estrategia = new BubbleSort();
		numeros.sort();
		
		numeros.estrategia = new InsertionSort();
		numeros.sort();
		
		numeros.estrategia = new QuickSort();
		numeros.sort();
		
		numeros.estrategia = new ShellSort();
		numeros.sort();
	}
}