package javaapplication2;
/**
 * First homework
 * Program's output are numbers from 1 to 100,
 * if one from it mod 3==0 --> OUTPUT="Fizz",
 * if it mod 5==0 --> OUTPUT="Buzz",
 * if it mod 3==0 AND it mod 5==0 --> OUTPUT="FizzBuzz"
 * @author VERONIKA
 */
public class JavaApplication2 {

    public static void main(String[] args) {
        //Tracking from 1 to 100
        for(int i=1; i<101; i++) {
            if (i%15==0){
                System.out.println("FizzBuzz"); //Condition for mod 5 and 3, we can put together as 15
                continue; //Use continue to stop other comparisons
            }
            if (i%3==0){
                System.out.println("Fizz"); //Condition for mod 3
                continue; 
            }
            if (i%5==0){
                System.out.println("Buzz"); //Condition for mod 5
                continue;
            }
            System.out.println(i); //If other comparisons didn't work out println number itself
        }
    } 
}
