using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarHeroClone
{
    class Global
    {
        //****************************************************//
        //               VARIABLE DICTIONARY                  //
        //                                                    //
        // gnotex - starting x coordinate for green note      //
        // gnotey - starting y coordinate for green note      //
        // rnotex - starting x coordinate for red note        //
        // rnotey - starting y coordinate for red note        //
        // ynotex - starting x coordinate for yellow note     //
        // ynotey - starting y coordinate for yellow note     //
        // bnotex - starting x coordinate for blue note       //
        // bnotey - starting y coordinate for blue note       //
        // onotex - starting x coordinate for orange note     //
        // onotey - starting y coordinate for orange note     //
        // gnotew - starting width of green note              //
        // gnoteh - sarting height of green note              //
        // rnotew - starting width of red note                //
        // rnoteh - sarting height of red note                //
        // ynotew - starting width of yellow note             //
        // ynoteh - sarting height of yellow note             //
        // bnotew - starting width of blue note               //
        // bnoteh - sarting height of blue note               //
        // onotew - starting width of orange note             //
        // onoteh - sarting height of orange note             //
        // keyY - y coordinate for all pads                   //
        // gkeyX - x coordinate for green pad                 //
        // rkeyX - x coordinate for red pad                   //
        // ykeyX - x coordinate for yellow pad                //
        // bkeyX - x coordinate for blue pad                  //
        // okeyX - x coordinate for orange pad                //
        // countX - x coordinate for countdown images         //
        // countY - y coordinate for countdown image          //
        //                                                    //
        //****************************************************//


            // sets beginning x & y coordinates of notes
            public static int gnotex = 347;
            public static int gnotey = 145;
            public static int rnotex = 367;
            public static int rnotey = 145;
            public static int ynotex = 395;
            public static int ynotey = 145;
            public static int bnotex = 415;
            public static int bnotey = 145;
            public static int onotex = 443;
            public static int onotey = 145;

            // sets starting widths & heights of notes
            public static int gnotew = 20;
            public static int gnoteh = 15;
            public static int rnotew = 20;
            public static int rnoteh = 15;
            public static int ynotew = 20;
            public static int ynoteh = 15;
            public static int bnotew = 20;
            public static int bnoteh = 15;
            public static int onotew = 20;
            public static int onoteh = 15;

            // sets each key pad's starting y coordinate
            public static int keyY = 460;

            // sets each key pad's starting x coordinate
            public static int gkeyX = 213;
            public static int rkeyX = 290;
            public static int ykeyX = 365;
            public static int bkeyX = 445;
            public static int okeyX = 520;

            // x & y coordinates for countdown images
            public static int countX = 370;
            public static int countY = 235;
    }
}
