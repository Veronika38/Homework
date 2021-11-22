package javaapplication5;

import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Deque;
import java.util.Iterator;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

/**
 * Class that returns changed directory
 *
 * @author VERON
 */
public class ChangePath {

    /**
     * Main class
     *
     * @param args file-path
     */
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);
        System.out.print("Введите путь: ");
        /**
         * Split the file-path into folders and points
         */
        List<String> arrayOfFolders = Arrays.stream(in.nextLine().split("\\/")).collect(Collectors.toCollection(ArrayList::new));

        /**
         * Final answer will be in deque, then called deq 
         * First element must be put into deq anyway and deleted from list
         */
        Deque<String> makeNewPath = new ArrayDeque<>();
        makeNewPath.add(arrayOfFolders.get(0));
        arrayOfFolders.remove(0);

        /**
         * Way to get answer
         */
        for (String folder : arrayOfFolders) {
            if (folder.equals(".")) {
                continue; //one point doesn't matter
            }
            if (folder.equals("..") && !makeNewPath.isEmpty()) {
                makeNewPath.removeLast(); //two points will delete one folder if deq isn't empty
                continue;
            }
            makeNewPath.addLast(folder); //else add element to deq
        }

        /**
         * Print answer
         */
        for (Iterator it = makeNewPath.iterator(); it.hasNext();) {
            System.out.printf("%s/", it.next());
        }
        System.out.print("\b\n"); //delete last slash-element

    }
}
