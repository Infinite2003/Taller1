#include<stdio.h>
# define N 3
# define M 3



void inicializar_Matriz(int m[N][M]){

    int i,j;
    
    for(i = 0; i < N ; i++)
      for(j = 0; j < M; j++)
         m[i][j] = 0;

}

void imprimirMatriz (int p[N][M]){
	
	int i,j;
	
	for(i=0;i<M;i++){
		
		for(j=0;j<N;j++){
			printf(" %d ", p[i][j]);
			
		}
		
		printf("\n");
	}
	
}

int main(){
	
	int g[N][M];
	
	printf("Bienvenido al juego de GATO\n");
	printf("Los X se representan con 1 y las O se representan con 2\n");
	printf("Los espacios sin utilizar se representan con 0\n");
	
	inicializar_Matriz(g);
	
	g[0][0] = 1;
	g[0][2] = 1;
	g[1][1] = 1;
	g[2][0] = 1;
	g[1][0] = 2;
	g[0][1] = 2;
	g[2][2] = 2;  
	
	imprimirMatriz(g);
}
