package com.fgnumerique.example.tafgatienlol;

import androidx.appcompat.app.AppCompatActivity;


import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    Button addbuton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        addbuton = findViewById(R.id.AddButton);
        addbuton.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                Toast.makeText(MainActivity.this, R.string.mssgTest, Toast.LENGTH_SHORT).show();
            }
        });

        List<Item> items = new ArrayList<>();
        items.add(new Item("toto","totu"));
        items.add(new Item("tata","totu"));
        items.add(new Item("titi","totu"));
        items.add(new Item("tete","totu"));
        items.add(new Item("tutu","totu"));

        ListView lv = findViewById(R.id.ListViewItem);
        lv.setAdapter(new ItemAdapter(this,items));
    }
}