//import javax.json.stream.*;

import com.google.gson.*;

import java.io.*;
import java.util.*;
import java.util.stream.Collectors;

/**
 * Class Task1
 * Задание №1:
 * Для каждого товара вывести в файл общее количество проданных товаров этого типа
 * From JSON To JSON
 */

public class Task1 {

    //Метод для записи данных в JSON
    public static void writeToJson(Object obj, String file) {
        try (Writer writer = new FileWriter(file)) {
            Gson gsonBuild = new GsonBuilder().setPrettyPrinting().create();
            gsonBuild.toJson(obj, writer);
        } catch (IOException e) {
            System.out.println("Ошибка FileWriter");
        }
    }

    public static void main(String[] args) {
        Gson gson = new Gson();
        //Реализация задания
        try {
            List<SoldProduct> soldProducts = new ArrayList<>();
            //Считывание Products.json
            Arrays.stream(gson.fromJson(new FileReader("src/main/java/Products.json"), Product[].class))
                    .sorted(new Comparator<Product>() {
                        @Override
                        public int compare(Product o1, Product o2) {
                            return o1.getProductID() > o2.getProductID() ? 1 : -1;
                        }
                    })
                    .forEach(x -> soldProducts.add(new SoldProduct(x.getProductID(), x.getProductName(), 0)));

            //Считывание Sales.json с группировкой продаж
            Map<Integer, Integer> salesOfProducts = Arrays.stream(gson.fromJson(new FileReader("src/main/java/Sales.json"), Sale[].class))
                    .sorted(new Comparator<Sale>() {
                        @Override
                        public int compare(Sale o1, Sale o2) {
                            return o1.getProductID() > o2.getProductID() ? 1 : -1;
                        }
                    })
                    .collect(Collectors.groupingBy(Sale::getProductID, Collectors.summingInt(Sale::getNumberOfSold)));

            //Объединение продаж с товарами
            Iterator<SoldProduct> it = soldProducts.iterator();
            while (it.hasNext()) {
                for (var entry : salesOfProducts.entrySet()) {
                    it.next().setNumberOfSold(entry.getValue());
                }
            }
            //Сборка output1.json
            writeToJson(soldProducts, "output1.json");

        } catch (FileNotFoundException e) {
            System.out.println("Файл не найден");
        }

    }
}
