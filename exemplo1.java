import java.util.Scanner;
public class exemplo1 {
    public static void main(String[] args) {
        Scanner leia = new Scanner(System.in);
        float soma, sub, multi, div, n1, n2;
        System.out.println("Informe o primeiro número: ");
        n1 = leia.nextFloat();
        System.out.println("Informe o segundo número: ");
        n2 = leia.nextFloat();
        soma = n1+n2;
        sub = n1-n2;
        multi = n1*n2;
        div = n1/n2;
        System.out.println("A soma é: "+soma+". A subtração é: "+sub+". A multiplicação é: "+multi+". A divisão é: "+div);
    }
}