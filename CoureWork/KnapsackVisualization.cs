using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurssss;

public class KnapsackVisualization
{
    private readonly int ItemWidth = 105;
    private readonly int ItemHeight = 50;

    public void DrawItem(Graphics g, int x, int y, Item item)
    {
       
        Pen pen = new(Color.Black);
        Brush brush = new SolidBrush(Color.Gray);

       
        // Рисуем фон и рамку для предмета
        g.FillRectangle(brush, x, y, ItemWidth, ItemHeight);
        g.DrawRectangle(pen, x, y, ItemWidth, ItemHeight);

        // Рисуем название предмета
        float nameTextX = x + 5;
        float nameTextY = y + 5;
        g.DrawString(item.Name, SystemFonts.DefaultFont, Brushes.Black, nameTextX, nameTextY);

        // Рисуем вес и цену
        float detailsTextX = x + 5;
        float detailsTextY = y + 30; // Опустим немного ниже
        string details = $"Вес: {item.Weight}, Цена: {item.Value}";
        g.DrawString(details, SystemFonts.DefaultFont, Brushes.Black, detailsTextX, detailsTextY);
        
    }

    public void DrawKnapsack(Graphics g, KnapsackState state)
    {
        
        int startUnX = 15;
        int startUnY = 15;
        int spacingX = 120; // Увеличим отступы, чтобы не было наложения
        int spacingY = 80;  // Увеличим отступы, чтобы не было наложения

        int unItemsPerRow = 3; // Количество предметов в ряду
        int itemCount = 0;

        foreach (var item in state.UnSelectedItems)
        {
            int currentX = startUnX + (itemCount % unItemsPerRow) * spacingX;
            int currentY = startUnY + (itemCount / unItemsPerRow) * spacingY;
            itemCount++;
            DrawItem(g, currentX, currentY, item);
        }

        int startSelX = 515;
        int startSelY = 15;

        int selItemsPerRow = 3;
        int selItemCount = 0;

        foreach (var item in state.SelectedItems)
        {
            int currentX = startSelX + (selItemCount % selItemsPerRow) * spacingX;
            int currentY = startSelY + (selItemCount / selItemsPerRow) * spacingY;
            selItemCount++;
            DrawItem(g, currentX, currentY, item);
        }
    }
}