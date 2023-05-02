using Raylib_cs;
using System;

// window
int heightY = 1000;
int widthX = 1200;

int gameScreen = 0;

//Audio


//game related
string SelectedChoice = "";


//bool choiceA = true;
//bool choiceB = false;

void draw()
{
    if (gameScreen == 0)
    {
        startScreen();
    }

    else if (gameScreen == 11)
    {
        choice1A();
    }

    else if (gameScreen == 12)
    {
        choice1B();
    }

}


void circleL()
{
    // code of choice 1 location

    Raylib.DrawCircle(300, heightY - 200, 75, Color.WHITE);
}

void circleR()
{
    // code of choice 2 location

    Raylib.DrawCircle(widthX - 300, heightY - 200, 75, Color.WHITE);
}

void character()
{
    // codes of the character

    Raylib.DrawCircle(widthX / 2, heightY - 200, 30, Color.WHITE);
}

void startScreen()
{
    // codes of Start screen

    float textX = Raylib.GetScreenWidth() / 2 - Raylib.MeasureText("Seems like you've rest well, young travaler", 25) / 2;
    float textL = Raylib.GetScreenWidth() / 4 - Raylib.MeasureText("where am I? Who are you", 25) / 2;


    Raylib.DrawText("Seems like you've rest well, young travaler", (int)textX, heightY / 3, 25, Color.WHITE);

    Raylib.DrawText("where am I? Who are you", (int)textL, heightY - 310, 25, Color.WHITE );
}

void choice1A()
{
    // codes of choice 1:a

    float textX = Raylib.GetScreenWidth() / 2 - Raylib.MeasureText("It seems you have taken on a dangerous quest, are you sure to follow through?", 25) / 2;

    Raylib.DrawText("It seems you have taken on a dangerous quest, are you sure to follow through?", (int)textX, heightY / 3, 25, Color.WHITE);
}

void choice1B()
{
    // codes of choice 1:b

    float textX = Raylib.GetScreenWidth() / 2 - Raylib.MeasureText("Well then go, you fucking monkey!", 25) / 2;

    Raylib.DrawText("Well then go, you fucking monkey!", (int)textX, heightY / 3, 25, Color.WHITE);
}

void characterL()
{
    // code of left character

    Raylib.DrawCircle(300, heightY - 200, 45, Color.BLACK);
}

void characterR()
{
    // code of right character

    Raylib.DrawCircle(widthX - 300, heightY - 200, 45, Color.BLACK);
}


Raylib.InitWindow(widthX, heightY, "storyGame");


while (!Raylib.WindowShouldClose())
{

    if (Raylib.IsKeyPressed(KeyboardKey.KEY_A))
    {
        SelectedChoice = "a";
    }

    if (Raylib.IsKeyPressed(KeyboardKey.KEY_D))
    {
        SelectedChoice = "d";
    }

    if (gameScreen == 0 && SelectedChoice == "a" && Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
    {
        gameScreen = 11;

        choice1A();
    }

    if (gameScreen == 0 && SelectedChoice == "d" && Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
    {
        gameScreen = 12;

        choice1B();
    }





    Raylib.BeginDrawing();

    if (gameScreen == 0)
    {

        Raylib.ClearBackground(Color.BLACK);

    }

    else if (gameScreen == 11)
    {
        Raylib.ClearBackground(Color.BLACK);

    }

    if (gameScreen == 12)
    {
        Raylib.ClearBackground(Color.BLACK);

    }

    draw();

    circleL();
    circleR();

    if (SelectedChoice == "a")
    {
        characterL();
    }
    else if (SelectedChoice == "d")
    {
        characterR();
    }
    else
    {
        character();
    }




    Raylib.EndDrawing();
}

