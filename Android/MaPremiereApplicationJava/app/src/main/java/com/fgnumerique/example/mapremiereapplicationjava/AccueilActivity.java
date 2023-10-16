package com.fgnumerique.example.mapremiereapplicationjava;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

public class AccueilActivity extends AppCompatActivity {

    TextView compt;
    String compteurSave="compteursave";
    int compteur;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_accueil);
        compt=(TextView) findViewById(R.id.compteur);
        if(savedInstanceState!=null){
            compteur = savedInstanceState.getInt(compteurSave);
        }
        else{
            compteur=Integer.parseInt(compt.getText().toString());
        }
        update();

    }
    @Override
    protected void onStart() {
        super.onStart();
    }
    @Override
    protected void onSaveInstanceState(@NonNull Bundle outState) {
        super.onSaveInstanceState(outState);
        outState.putInt(compteurSave,compteur);
    }
    public void update(){
        compt.setText(Integer.valueOf(compteur).toString());
    }
    public void incrementation(View v){
        compteur++;
        update();
    }
    public void decrementation(View v){
        compteur--;
        update();
    }
    public void quitter(View v){
        this.finish();
    }
}