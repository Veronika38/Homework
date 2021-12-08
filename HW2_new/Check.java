/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication2;

import java.util.Arrays;

/**
 * Class Check with demonstration of OOP-model
 *
 * @author VERON
 */
public class Check {

    public static void main(String[] args) {
        
        //Создадим массив песен
        Song aSong[] = {new Song("abc", "as")};
        
        //Создадим два массива одинаковых проигрывающих устройств, но с разными наборами песен
        SoundCarrier arrayOfSoundCarriers[] = {new SD(), new Record(), new FlashDrive(), new Record()};
        
        SoundCarrier arrayOfSoundCarriers1[] = {new SD(aSong), new Record(), new FlashDrive(), new Record()};
               
        //Создадим объекты родительского abstract-класса SoundReproducingDevice для разных наследников
        SoundReproducingDevice aVinylTurntable = new VinylTurntable(arrayOfSoundCarriers);
        SoundReproducingDevice aSDPlayer = new SDPlayer(arrayOfSoundCarriers);
        SoundReproducingDevice aMP3Player = new MP3Player(arrayOfSoundCarriers);
        
        //Так как класс - abstract, то abstract-метод plays(), определенный в наследниках также будет вызываться
        System.out.println(aVinylTurntable.plays());
        System.out.println(aSDPlayer.plays());
        System.out.println(aMP3Player.plays());
        
        //Проверка equals & hashCode
        System.out.println(aVinylTurntable.equals(aSDPlayer));
        System.out.println(aVinylTurntable.hashCode());
        System.out.println(aSDPlayer.hashCode());
        System.out.println(Arrays.equals(arrayOfSoundCarriers, arrayOfSoundCarriers1));
        
        SoundCarrier checkEqual[] = arrayOfSoundCarriers.clone();
        System.out.println(Arrays.equals(arrayOfSoundCarriers, checkEqual));
    }

}
