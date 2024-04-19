using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGroup
{
    private int population;
    private int sample_size;
    private int max_possible_proportion = 50;
    private int red_index = 0;
    private int orange_index = 1;
    private int yellow_index = 2;
    private int green_index = 3;
    private int blue_index = 4;
    private int brown_index = 5;
    private float [] true_proportions = {.16f, .16f, .17f, .17f, .17f, .17f};
    
    public ItemGroup(int number_of_item)
    {
        population = number_of_item;
        float proportion_left = 1f;
        for (int i = 0; i < true_proportions.Length; i++)
        {
            
            float rand = Random.Range(-9, 10) / 100f;
            int random_index = Random.Range(0, 6);
            if (true_proportions[random_index] > rand)
            {
                true_proportions[i] += rand;
                true_proportions[random_index] -= rand;
            }
        }
        
        for (int i = 0; i < true_proportions.Length; i++)
        {
            float cleaned = Mathf.Round((true_proportions[i] * 100f));
            true_proportions[i] = cleaned/100f;
        }

    }

    public float[] listOfProportions()
    {
        return true_proportions;
    }

    public int[] getSample(int sample_size)
    {
        int[] samples = new int[6];
        for (int i = 0; sample_size > i; i++)
        {
            int color_index = -1;
            int color = Random.Range(0, 100);
            for (int j = 0; true_proportions.Length > j; j++)
            {
                float percentage = 0f;
                for (int k = 0; k < j; k++)
                {
                    percentage += true_proportions[k];
                }

                if (percentage > color)
                {
                    color_index = j;
                    break;
                }
            }

            if (color_index != 1 && !(color_index < true_proportions.Length-1))
            {
                samples[color_index] = samples[color_index] + 1;
            }
            else
            {
                Debug.Log("Invalid Index");
            }
        }

        return samples;
    }

    public float checkProportionSum()
    {
        return true_proportions[0] + true_proportions[1] + true_proportions[2] + true_proportions[3] +
               true_proportions[4] + true_proportions[5];
    }
}
