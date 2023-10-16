package com.fgnumerique.example.tafgatienlol;

import android.content.Context;
import android.graphics.drawable.Drawable;
import android.util.DisplayMetrics;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.List;

public class ItemAdapter extends BaseAdapter {
    private Context context;
    private LayoutInflater inflater;
    private List<Item> item;

    public ItemAdapter(Context _context,List<Item> _item){
        this.context=_context;
        this.item=_item;
        this.inflater=LayoutInflater.from(context);
    }

    @Override
    public int getCount() {
        return item.size();
    }

    @Override
    public Object getItem(int _i) {
        return item.get(_i);
    }

    @Override
    public long getItemId(int _i) {
        return _i;
    }

    @Override
    public View getView(int _i, View view, ViewGroup viewGroup) {
        view = inflater.inflate(R.layout.activity_item_list,null);

        TextView nom = view.findViewById(R.id.NomValeur);
        nom.setText(item.get(_i).GetNom());

        TextView prenom = view.findViewById(R.id.PrenomValeur);
        prenom.setText(item.get(_i).GetPrenom());

        ImageView image = view.findViewById(R.id.Image);
        image.setImageDrawable(view.getResources().getDrawableForDensity(R.drawable.furby, DisplayMetrics.DENSITY_XHIGH));

        return view;
    }
}


