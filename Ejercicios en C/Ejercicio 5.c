#include<stdio.h>
#include<stdlib.h>


int main(){
	
	srand(time(NULL));
	
	int	pos, n;
	
	printf("Bienvenido al simulador de bloques de tetris. Existen 7 bloques diferentes, representados del numero 1 al numero 7\n");
	
	printf("Ingrese la cantidad de bloques en secuencia que se van a generar\n");
	scanf("%d", &n);
	
	int p[n];
	
	for(pos=0; pos<n; pos++){
		
		p[pos] = rand()% 7+1;
		
		if(p[pos] == p[pos]-1){
			
			p[pos] = rand()% 7+1;
		}
		
		else if(p[1] == p[0]){
			
			p[1] = rand()% 7+1;
		}
	}
	
	for(pos=0; pos<n; pos++){
	printf("Bloque[%d]%d\n",pos, p[pos]);
	}
	
	return 0;
}
