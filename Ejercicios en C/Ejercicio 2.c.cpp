#include<stdio.h>
#include<stdlib.h>

int main(){
	
	int numero,suma, resta, multi, divi;
	
	
	
	printf("Ingrese el numero a utilizar en las ecuaciones, recuerde utilizar numeros positivos\n");
	scanf("%d", &numero);
	
	suma = numero + 10;
	resta = numero - 1;
	multi = numero * 3;
	divi = numero / 1;
	
	printf("Resultado suma: %d\n",suma);
	printf("Resultado resta: %d\n",resta);
	printf("Resultado multiplicacion: %d\n",multi);
	printf("Resultado divicion: %d\n",divi);
	
	
	return 0;
}
