#include<stdio.h>

int main(){

	int entero;
	float decimal= 0.0;
	char caracter = 'A';
	
	printf("Ingrese una letra\n");
	scanf("%c",&caracter);
	
	printf("Ingrese un dato entero\n");
	scanf("%d",&entero);

	printf("Ingrese un dato decimal\n");
	scanf("%f", &decimal);
	
	
	
	printf("Numero entero: %d\n",entero);
	printf("Numero decimal: %f\n", decimal);
	printf("Caracteres: %c\n",caracter);
	
	return 0;
}
