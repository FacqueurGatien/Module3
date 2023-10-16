package com.fgnumerique.example.tafgatienlol;

import android.media.Image;
import android.util.DisplayMetrics;

public class Item {
    private String nom;
    private String prenom;
    private Image image;
    public Item(String _nom,String _prenom,Image _image){
        nom=_nom;
        prenom=_prenom;
        image=_image;
    }
    public Item(String _nom,String _prenom){
        nom=_nom;
        prenom=_prenom;
        image= null;
    }
    public String GetNom(){
        return nom;
    }
    public String GetPrenom(){
        return prenom;
    }
    public Image GetImage(){
        return image;
    }
}
