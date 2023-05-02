using Raylib_cs;
using System;

//----//
int heightY = 1000;
int widthX = 1200;



string SelectedChoice = "";


//----Audio----//


//----game related----//


int gameScreen = 0;


void draw()
{
    if (gameScreen == 0)
    {
        start();
    }

    else if (gameScreen == 01)
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

    else if (gameScreen == 21)
    {
        choice2A();
    }

}

void circleL()
{
    // code of choice 1 location

    Raylib.DrawCircle(300, heightY - 200, 75, Color.WHITE);
}

void circleR()
{
    // code of choice 2 location//
    Raylib.DrawCircle(widthX - 300, heightY - 200, 75, Color.WHITE);
}

void character()
{
    // codes of the character

    Raylib.DrawCircle(widthX / 2, heightY - 200, 30, Color.WHITE);
}

void start()
{
    // codes for continue start screen

    float textX = Raylib.GetScreenWidth() / 2 - Raylib.MeasureText("Do you wish to continue on your quest?", 25) / 2;
    float textLeft = Raylib.GetScreenWidth() / 4 - Raylib.MeasureText("Continue", 25) / 2;
    float textRight = (Raylib.GetScreenWidth() / 4) * 3 - Raylib.MeasureText("Exit", 25) / 2;


    Raylib.DrawText("Do you wish to continue on your quest?", (int)textX, heightY / 3, 25, Color.WHITE);
    Raylib.DrawText("Continue", (int)textLeft, heightY - 310, 25, Color.WHITE);
    Raylib.DrawText("Exit", (int)textRight, heightY - 310, 25, Color.WHITE);

}



void startScreen()
{
    // codes of Start screen

    float textX = Raylib.GetScreenWidth() / 2 - Raylib.MeasureText("Seems like you've rest well, young travaler", 25) / 2;
    float textLeft = Raylib.GetScreenWidth() / 4 - Raylib.MeasureText("where am I? Who are you", 25) / 2;
    float textRight = (Raylib.GetScreenWidth() / 4) * 3 - Raylib.MeasureText("Fuck you bitch", 25) / 2;


    Raylib.DrawText("Seems like you've rest well, young travaler", (int)textX, heightY / 3, 25, Color.WHITE);

    Raylib.DrawText("where am I? Who are you", (int)textLeft, heightY - 310, 25, Color.WHITE);

    Raylib.DrawText("Fuck you bitch", (int)textRight, heightY - 310, 25, Color.WHITE);
}

void choice1A()
{
    // codes for choice 1:a

    float textX = Raylib.GetScreenWidth() / 2 - Raylib.MeasureText("Do not fret, I will not hurt you", 25) / 2;

    Raylib.DrawText("Do not fret, I will not hurt you", (int)textX, heightY / 3, 25, Color.WHITE);
}

void choice1B()
{
    // codes for choice 1:b

    float textX = Raylib.GetScreenWidth() / 2 - Raylib.MeasureText("Well then go, you fucking monkey!", 25) / 2;

    Raylib.DrawText("Well then go, you fucking monkey!", (int)textX, heightY / 3, 25, Color.WHITE);
}

void choice2A()
{
    // codes for choice 2:a

    float textX = Raylib.GetScreenWidth() / 2 - Raylib.MeasureText("You must have taken a great fall, I found you in a cave.", 25) / 2;

    float textX2 = Raylib.GetScreenWidth() / 2 - Raylib.MeasureText("Your clothes were drenched in what seemed to be Orc blood.", 25) / 2;

    float textX3 = Raylib.GetScreenWidth() / 2 - Raylib.MeasureText("Sit down and drink this", 25) / 2;

    Raylib.DrawText("You must have taken a great fall, I found you in a cave.", (int)textX, heightY / 3, 25, Color.WHITE);

    Raylib.DrawText("Your clothes were drenched in what seemed to be Orc blood.", (int)textX2, heightY / 3 + 25, 25, Color.WHITE);

    Raylib.DrawText("Sit down and drink this", (int)textX3, heightY / 3 + 50, 25, Color.WHITE);


    //Your clothes were drenched in what seemed to be Orc blood. Sit down and drink this
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



//----Game Logic---//



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
        gameScreen = 01;

        startScreen();
    }
    else if (gameScreen == 0 && SelectedChoice == "d" && Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
    {
        Raylib.WindowShouldClose();
    }

    else if (gameScreen == 01 && SelectedChoice == "a" && Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
    {
        gameScreen = 11;

        choice1A();
    }

    else if (gameScreen == 01 && SelectedChoice == "d" && Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
    {
        gameScreen = 12;

        choice1B();
    }

    if (gameScreen == 11 && SelectedChoice == "a" && Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
    {
        gameScreen = 21;

        choice2A();
    }





    Raylib.BeginDrawing();

    if (gameScreen == 0)
    {

        Raylib.ClearBackground(Color.BLACK);

    }

    else if (gameScreen == 01)
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

    if (gameScreen == 21)
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

    //----RESTART----//

    if (Raylib.IsKeyPressed(KeyboardKey.KEY_R))
    {
        gameScreen = 0;
    }

    Raylib.EndDrawing();
}

