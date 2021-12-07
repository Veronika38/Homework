//import javax.json.stream.*;

import com.google.gson.*;

import java.io.*;
import java.util.*;
import java.util.stream.Collectors;

/**
 * Class Task2
 * Задание №2:
 * Вывести в файл распределение общего количества продаж по датам
 * From JSON To JSON
 */

public class Task2 {

    public static void main(String[] args) {
        Gson gson = new Gson();
        //Реализация задания
        try {

            //Считывание Sales.json с группировкой продаж по датам
            Map<Date, Integer> dateOfSales = Arrays.stream(gson.fromJson(new FileReader("src/main/java/Sales.json"), Sale[].class))
                    .collect(Collectors.groupingBy(Sale::getDateOfSale, Collectors.summingInt(Sale::getNumberOfSold)));
            //Сортировка по дате
            dateOfSales = dateOfSales.entrySet().stream().sorted(Map.Entry.comparingByKey()).collect(Collectors.toMap(Map.Entry::getKey, Map.Entry::getValue, (key, value) -> key, LinkedHashMap::new));

            //Сборка output2.json
            Task1.writeToJson(dateOfSales, "output2.json");

        } catch (FileNotFoundException e) {
            e.printStackTrace();
            System.out.println("Файл не найден");
        }

    }
}
