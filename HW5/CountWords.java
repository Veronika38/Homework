package javaapplication5;

import java.io.File;
import java.util.Scanner;
import java.io.FileNotFoundException;

/**
 * Class that returns number of words in file
 *
 * @author VERON
 */
public class CountWords {

    /**
     * Method that counts words in line
     *
     * @param line String-line from file
     * @return int-number of words in line
     */
    public static int Count(String line) {
        String[] lineArray = line.split("[\\s\\.\\,\\!\\?\\;\\:\\—\\n]+"); //These split leaves only words in array
        return lineArray.length;
    }

    /**
     * Main class
     *
     * @param args
     * @throws IllegalArgumentException for case when there is no args
     */
    public static void main(String[] args) throws IllegalArgumentException {
        /**
         * No args condition. Handling of IllegalArgumnetsException
         */
        if (args.length == 0) {
            throw new IllegalArgumentException("Ошибка в вводе файла"); //check args for exception
        }

        /**
         * No such file condition. Handling of FileNotFoundException
         */
        try {
            File file = new File(args[0]);
            Scanner in = new Scanner(file,"Windows-1251");
            
            int sum = 0; //counter of words
            while (in.hasNextLine()) {
                sum += Count(in.nextLine());
            }
            System.out.printf("Ответ: %d слов%n", sum);
        } catch (FileNotFoundException e) {
            System.out.println("Ошибка: файл не найден");
        }

    }
}
