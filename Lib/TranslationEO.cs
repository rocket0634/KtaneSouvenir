using System.Collections.Generic;

namespace Souvenir
{
    public class Translation_eo : Translation
    {
        public override string FormatModuleName(string moduleName, bool addSolveCount, int numSolved, bool addThe) =>
            addSolveCount ? string.Format("la {0} solvita {1}", moduleName, ordinal(numSolved, adv: true)) : addThe ? "La\u00a0" + moduleName : moduleName;
        public override string Ordinal(int number) => ordinal(number, adv: false);
        private string ordinal(int num, bool adv = false) => (num < 0 ? $"({num})" : num switch
        {
            1 => "unu",
            2 => "du",
            3 => "tri",
            4 => "kvar",
            5 => "kvin",
            6 => "ses",
            7 => "sep",
            8 => "ok",
            9 => "naŭ",
            _ => num.ToString()
        }) + (adv ? "e" : "a");

        #region Translatable strings
        public override Dictionary<Question, TranslationInfo> Translations => new Dictionary<Question, TranslationInfo>
        {
            // 1000 Words
            // What was the {1} word shown in {0}?
            [Question._1000WordsWords] = new TranslationInfo
            {
                QuestionText = "Kio estis la {1} vorto afiŝita en {0}?",
                ModuleName = "1000 vortoj",
            },

            // 100 Levels of Defusal
            // What was the {1} displayed letter in {0}?
            [Question._100LevelsOfDefusalLetters] = new TranslationInfo
            {
                QuestionText = "What was the {1} displayed letter in {0}?",
            },

            // 1D Chess
            // What was {1} in {0}?
            [Question._1DChessMoves] = new TranslationInfo
            {
                QuestionText = "What was {1} in {0}?",
            },

            // 3D Maze
            // What were the markings in {0}?
            [Question._3DMazeMarkings] = new TranslationInfo
            {
                QuestionText = "What were the markings in {0}?",
            },
            // What was the cardinal direction in {0}?
            [Question._3DMazeBearing] = new TranslationInfo
            {
                QuestionText = "Kio estis la kompasa direkto en {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["North"] = "nordo",
                    ["South"] = "sudo",
                    ["West"] = "oriento",
                    ["East"] = "okcidento",
                },
            },

            // 3D Tap Code
            // What was the received word in {0}?
            [Question._3DTapCodeWord] = new TranslationInfo
            {
                QuestionText = "What was the received word in {0}?",
            },

            // 3D Tunnels
            // What was the {1} goal node in {0}?
            [Question._3DTunnelsTargetNode] = new TranslationInfo
            {
                QuestionText = "What was the {1} goal node in {0}?",
            },

            // 3 LEDs
            // What was the initial state of the LEDs in {0} (in reading order)?
            [Question._3LEDsInitialState] = new TranslationInfo
            {
                QuestionText = "What was the initial state of the LEDs in {0} (in reading order)?",
            },

            // 7
            // What was the {1} channel’s initial value in {0}?
            [Question._7InitialValues] = new TranslationInfo
            {
                QuestionText = "What was the {1} channel’s initial value in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                },
            },
            // What LED color was shown in stage {1} of {0}?
            [Question._7LedColors] = new TranslationInfo
            {
                QuestionText = "What LED color was shown in stage {1} of {0}?",
            },

            // 9-Ball
            // What was the number of ball {1} in {0}?
            [Question._9BallLetters] = new TranslationInfo
            {
                QuestionText = "What was the number of ball {1} in {0}?",
            },
            // What was the letter of ball {1} in {0}?
            [Question._9BallNumbers] = new TranslationInfo
            {
                QuestionText = "What was the letter of ball {1} in {0}?",
            },

            // Accumulation
            // What was the background color on the {1} stage in {0}?
            [Question.AccumulationBackgroundColor] = new TranslationInfo
            {
                QuestionText = "What was the background color on the {1} stage in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Blue"] = "Blue",
                    ["Brown"] = "Brown",
                    ["Green"] = "Green",
                    ["Grey"] = "Grey",
                    ["Lime"] = "Lime",
                    ["Orange"] = "Orange",
                    ["Pink"] = "Pink",
                    ["Red"] = "Red",
                    ["White"] = "White",
                    ["Yellow"] = "Yellow",
                },
            },
            // What was the border color in {0}?
            [Question.AccumulationBorderColor] = new TranslationInfo
            {
                QuestionText = "What was the border color in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Blue"] = "Blue",
                    ["Brown"] = "Brown",
                    ["Green"] = "Green",
                    ["Grey"] = "Grey",
                    ["Lime"] = "Lime",
                    ["Orange"] = "Orange",
                    ["Pink"] = "Pink",
                    ["Red"] = "Red",
                    ["White"] = "White",
                    ["Yellow"] = "Yellow",
                },
            },

            // Adventure Game
            // Which item was the {1} correct item you used in {0}?
            [Question.AdventureGameCorrectItem] = new TranslationInfo
            {
                QuestionText = "Which item was the {1} correct item you used in {0}?",
            },
            // What enemy were you fighting in {0}?
            [Question.AdventureGameEnemy] = new TranslationInfo
            {
                QuestionText = "What enemy were you fighting in {0}?",
            },

            // Affine Cycle
            // What was the {1} in {0}?
            [Question.AffineCycleWord] = new TranslationInfo
            {
                QuestionText = "What was the {1} in {0}?",
            },

            // Alfa-Bravo
            // Which letter was pressed in {0}?
            [Question.AlfaBravoPressedLetter] = new TranslationInfo
            {
                QuestionText = "Which letter was pressed in {0}?",
            },
            // Which letter was to the left of the pressed one in {0}?
            [Question.AlfaBravoLeftPressedLetter] = new TranslationInfo
            {
                QuestionText = "Which letter was to the left of the pressed one in {0}?",
            },
            // Which letter was to the right of the pressed one in {0}?
            [Question.AlfaBravoRightPressedLetter] = new TranslationInfo
            {
                QuestionText = "Which letter was to the right of the pressed one in {0}?",
            },
            // What was the last digit on the small display in {0}?
            [Question.AlfaBravoDigit] = new TranslationInfo
            {
                QuestionText = "What was the last digit on the small display in {0}?",
            },

            // Algebra
            // What was the first equation in {0}?
            [Question.AlgebraEquation1] = new TranslationInfo
            {
                QuestionText = "What was the first equation in {0}?",
            },
            // What was the second equation in {0}?
            [Question.AlgebraEquation2] = new TranslationInfo
            {
                QuestionText = "What was the second equation in {0}?",
            },

            // Algorithmia
            // Which position was the {1} position in {0}?
            [Question.AlgorithmiaPositions] = new TranslationInfo
            {
                QuestionText = "Which position was the {1} position in {0}?",
            },
            // What was the color of the colored bulb in {0}?
            [Question.AlgorithmiaColor] = new TranslationInfo
            {
                QuestionText = "What was the color of the colored bulb in {0}?",
            },
            // Which number was present in the seed in {0}?
            [Question.AlgorithmiaSeed] = new TranslationInfo
            {
                QuestionText = "Which number was present in the seed in {0}?",
            },

            // Alphabetical Ruling
            // What was the letter displayed in the {1} stage of {0}?
            [Question.AlphabeticalRulingLetter] = new TranslationInfo
            {
                QuestionText = "What was the letter displayed in the {1} stage of {0}?",
            },
            // What was the number displayed in the {1} stage of {0}?
            [Question.AlphabeticalRulingNumber] = new TranslationInfo
            {
                QuestionText = "What was the number displayed in the {1} stage of {0}?",
            },

            // Alphabet Tiles
            // What was the {1} letter shown during the cycle in {0}?
            [Question.AlphabetTilesCycle] = new TranslationInfo
            {
                QuestionText = "What was the {1} letter shown during the cycle in {0}?",
            },
            // What was the missing letter in {0}?
            [Question.AlphabetTilesMissingLetter] = new TranslationInfo
            {
                QuestionText = "What was the missing letter in {0}?",
            },

            // Alpha-Bits
            // What character was displayed on the {1} screen on the {2} in {0}?
            [Question.AlphaBitsDisplayedCharacters] = new TranslationInfo
            {
                QuestionText = "What character was displayed on the {1} screen on the {2} in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["left"] = "left",
                },
            },

            // Arithmelogic
            // What was the symbol on the submit button in {0}?
            [Question.ArithmelogicSubmit] = new TranslationInfo
            {
                QuestionText = "What was the symbol on the submit button in {0}?",
            },
            // Which number was selectable, but not the solution, in the {1} screen on {0}?
            [Question.ArithmelogicNumbers] = new TranslationInfo
            {
                QuestionText = "Which number was selectable, but not the solution, in the {1} screen on {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["left"] = "left",
                    ["middle"] = "middle",
                    ["right"] = "right",
                },
            },

            // ASCII Maze
            // What was the {1} character displayed on {0}?
            [Question.ASCIIMazeCharacters] = new TranslationInfo
            {
                QuestionText = "What was the {1} character displayed on {0}?",
            },

            // A Square
            // Which of these was an index color in {0}?
            [Question.ASquareIndexColors] = new TranslationInfo
            {
                QuestionText = "Which of these was an index color in {0}?",
            },
            // Which color was submitted {1} in {0}?
            [Question.ASquareCorrectColors] = new TranslationInfo
            {
                QuestionText = "Which color was submitted {1} in {0}?",
            },

            // Bamboozled Again
            // What color was the {1} correct button in {0}?
            [Question.BamboozledAgainButtonColor] = new TranslationInfo
            {
                QuestionText = "What color was the {1} correct button in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Lime"] = "Lime",
                    ["Green"] = "Green",
                    ["Jade"] = "Jade",
                    ["Cyan"] = "Cyan",
                    ["Azure"] = "Azure",
                    ["Blue"] = "Blue",
                    ["Violet"] = "Violet",
                    ["Magenta"] = "Magenta",
                    ["Rose"] = "Rose",
                    ["White"] = "White",
                    ["Grey"] = "Grey",
                    ["Black"] = "Black",
                },
            },
            // What was the text on the {1} correct button in {0}?
            [Question.BamboozledAgainButtonText] = new TranslationInfo
            {
                QuestionText = "What was the text on the {1} correct button in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["THE LETTER"] = "THE LETTER",
                    ["ONE LETTER"] = "ONE LETTER",
                    ["THE COLOUR"] = "THE COLOUR",
                    ["ONE COLOUR"] = "ONE COLOUR",
                    ["THE PHRASE"] = "THE PHRASE",
                    ["ONE PHRASE"] = "ONE PHRASE",
                    ["ALPHA"] = "ALPHA",
                    ["BRAVO"] = "BRAVO",
                    ["CHARLIE"] = "CHARLIE",
                    ["DELTA"] = "DELTA",
                    ["ECHO"] = "ECHO",
                    ["GOLF"] = "GOLF",
                    ["KILO"] = "KILO",
                    ["QUEBEC"] = "QUEBEC",
                    ["TANGO"] = "TANGO",
                    ["WHISKEY"] = "WHISKEY",
                    ["VICTOR"] = "VICTOR",
                    ["YANKEE"] = "YANKEE",
                    ["ECHO ECHO"] = "ECHO ECHO",
                    ["E THEN E"] = "E THEN E",
                    ["ALPHA PAPA"] = "ALPHA PAPA",
                    ["PAPA ALPHA"] = "PAPA ALPHA",
                    ["PAPHA ALPA"] = "PAPHA ALPA",
                    ["T GOLF"] = "T GOLF",
                    ["TANGOLF"] = "TANGOLF",
                    ["WHISKEE"] = "WHISKEE",
                    ["WHISKY"] = "WHISKY",
                    ["CHARLIE C"] = "CHARLIE C",
                    ["C CHARLIE"] = "C CHARLIE",
                    ["YANGO"] = "YANGO",
                    ["DELTA NEXT"] = "DELTA NEXT",
                    ["CUEBEQ"] = "CUEBEQ",
                    ["MILO"] = "MILO",
                    ["KI LO"] = "KI LO",
                    ["HI-LO"] = "HI-LO",
                    ["VVICTOR"] = "VVICTOR",
                    ["VICTORR"] = "VICTORR",
                    ["LIME BRAVO"] = "LIME BRAVO",
                    ["BLUE BRAVO"] = "BLUE BRAVO",
                    ["G IN JADE"] = "G IN JADE",
                    ["G IN ROSE"] = "G IN ROSE",
                    ["BLUE IN RED"] = "BLUE IN RED",
                    ["YES BUT NO"] = "YES BUT NO",
                    ["COLOUR"] = "COLOUR",
                    ["MESSAGE"] = "MESSAGE",
                    ["CIPHER"] = "CIPHER",
                    ["BUTTON"] = "BUTTON",
                    ["TWO BUTTONS"] = "TWO BUTTONS",
                    ["SIX BUTTONS"] = "SIX BUTTONS",
                    ["I GIVE UP"] = "I GIVE UP",
                    ["ONE ELEVEN"] = "ONE ELEVEN",
                    ["ONE ONE ONE"] = "ONE ONE ONE",
                    ["THREE ONES"] = "THREE ONES",
                    ["WHAT?"] = "WHAT?",
                    ["THIS?"] = "THIS?",
                    ["THAT?"] = "THAT?",
                    ["BLUE!"] = "BLUE!",
                    ["ECHO!"] = "ECHO!",
                    ["BLANK"] = "BLANK",
                    ["BLANK?!"] = "BLANK?!",
                    ["NOTHING"] = "NOTHING",
                    ["YELLOW TEXT"] = "YELLOW TEXT",
                    ["BLACK TEXT?"] = "BLACK TEXT?",
                    ["QUOTE V"] = "QUOTE V",
                    ["END QUOTE"] = "END QUOTE",
                    ["\"QUOTE K\""] = "\"QUOTE K\"",
                    ["IN RED"] = "IN RED",
                    ["ORANGE"] = "ORANGE",
                    ["IN YELLOW"] = "IN YELLOW",
                    ["LIME"] = "LIME",
                    ["IN GREEN"] = "IN GREEN",
                    ["JADE"] = "JADE",
                    ["IN CYAN"] = "IN CYAN",
                    ["AZURE"] = "AZURE",
                    ["IN BLUE"] = "IN BLUE",
                    ["VIOLET"] = "VIOLET",
                    ["IN MAGENTA"] = "IN MAGENTA",
                    ["ROSE"] = "ROSE",
                },
            },
            // What was the {1} decrypted text on the display in {0}?
            [Question.BamboozledAgainDisplayTexts1] = new TranslationInfo
            {
                QuestionText = "What was the {1} decrypted text on the display in {0}?",
            },
            // What was the {1} decrypted text on the display in {0}?
            [Question.BamboozledAgainDisplayTexts2] = new TranslationInfo
            {
                QuestionText = "What was the {1} decrypted text on the display in {0}?",
            },
            // What color was the {1} text on the display in {0}?
            [Question.BamboozledAgainDisplayColor] = new TranslationInfo
            {
                QuestionText = "What color was the {1} text on the display in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Lime"] = "Lime",
                    ["Green"] = "Green",
                    ["Jade"] = "Jade",
                    ["Cyan"] = "Cyan",
                    ["Azure"] = "Azure",
                    ["Blue"] = "Blue",
                    ["Violet"] = "Violet",
                    ["Magenta"] = "Magenta",
                    ["Rose"] = "Rose",
                    ["White"] = "White",
                    ["Grey"] = "Grey",
                },
            },

            // Bamboozling Button
            // What color was the button in the {1} stage of {0}?
            [Question.BamboozlingButtonColor] = new TranslationInfo
            {
                QuestionText = "What color was the button in the {1} stage of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Lime"] = "Lime",
                    ["Green"] = "Green",
                    ["Jade"] = "Jade",
                    ["Cyan"] = "Cyan",
                    ["Azure"] = "Azure",
                    ["Blue"] = "Blue",
                    ["Violet"] = "Violet",
                    ["Magenta"] = "Magenta",
                    ["Rose"] = "Rose",
                    ["White"] = "White",
                    ["Grey"] = "Grey",
                    ["Black"] = "Black",
                },
            },
            // What was the {2} label on the button in the {1} stage of {0}?
            [Question.BamboozlingButtonLabel] = new TranslationInfo
            {
                QuestionText = "What was the {2} label on the button in the {1} stage of {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["top"] = "top",
                },
            },
            // What was the {2} display in the {1} stage of {0}?
            [Question.BamboozlingButtonDisplay] = new TranslationInfo
            {
                QuestionText = "What was the {2} display in the {1} stage of {0}?",
            },
            // What was the color of the {2} display in the {1} stage of {0}?
            [Question.BamboozlingButtonDisplayColor] = new TranslationInfo
            {
                QuestionText = "What was the color of the {2} display in the {1} stage of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Lime"] = "Lime",
                    ["Green"] = "Green",
                    ["Jade"] = "Jade",
                    ["Cyan"] = "Cyan",
                    ["Azure"] = "Azure",
                    ["Blue"] = "Blue",
                    ["Violet"] = "Violet",
                    ["Magenta"] = "Magenta",
                    ["Rose"] = "Rose",
                    ["White"] = "White",
                    ["Grey"] = "Grey",
                },
            },

            // Bakery
            // Which menu item was present in {0}?
            [Question.BakeryItems] = new TranslationInfo
            {
                QuestionText = "Which menu item was present in {0}?",
            },

            // Barcode Cipher
            // What was the screen number in {0}?
            [Question.BarcodeCipherScreenNumber] = new TranslationInfo
            {
                QuestionText = "What was the screen number in {0}?",
            },
            // What was the edgework represented by the {1} barcode in {0}?
            [Question.BarcodeCipherBarcodeEdgework] = new TranslationInfo
            {
                QuestionText = "What was the edgework represented by the {1} barcode in {0}?",
            },
            // What was the answer for the {1} barcode in {0}?
            [Question.BarcodeCipherBarcodeAnswers] = new TranslationInfo
            {
                QuestionText = "What was the answer for the {1} barcode in {0}?",
            },

            // Bartending
            // Which ingredient was in the {1} position on {0}?
            [Question.BartendingIngredients] = new TranslationInfo
            {
                QuestionText = "Which ingredient was in the {1} position on {0}?",
            },

            // Big Circle
            // What color was {1} in the solution to {0}?
            [Question.BigCircleColors] = new TranslationInfo
            {
                QuestionText = "What color was {1} in the solution to {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Magenta"] = "Magenta",
                    ["White"] = "White",
                    ["Black"] = "Black",
                },
            },

            // Binary LEDs
            // At which numeric value did you cut the correct wire in {0}?
            [Question.BinaryLEDsValue] = new TranslationInfo
            {
                QuestionText = "At which numeric value did you cut the correct wire in {0}?",
            },

            // Binary Shift
            // What was the {1} initial number in {0}?
            [Question.BinaryShiftInitialNumber] = new TranslationInfo
            {
                QuestionText = "What was the {1} initial number in {0}?",
            },
            // What number was selected at stage {1} in {0}?
            [Question.BinaryShiftSelectedNumberPossition] = new TranslationInfo
            {
                QuestionText = "What number was selected at stage {1} in {0}?",
            },
            // What number was not selected at stage {1} in {0}?
            [Question.BinaryShiftNotSelectedNumberPossition] = new TranslationInfo
            {
                QuestionText = "What number was not selected at stage {1} in {0}?",
            },

            // Binary
            // What word was displayed in {0}?
            [Question.BinaryWord] = new TranslationInfo
            {
                QuestionText = "What word was displayed in {0}?",
            },

            // Bitmaps
            // How many pixels were {1} in the {2} quadrant in {0}?
            [Question.Bitmaps] = new TranslationInfo
            {
                QuestionText = "How many pixels were {1} in the {2} quadrant in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["white"] = "white",
                    ["top left"] = "top left",
                    ["top right"] = "top right",
                    ["bottom left"] = "bottom left",
                    ["bottom right"] = "bottom right",
                    ["black"] = "black",
                },
            },

            // Black Cipher
            // What was the answer in {0}?
            [Question.BlackCipherAnswer] = new TranslationInfo
            {
                QuestionText = "What was the answer in {0}?",
            },

            // Blind Maze
            // What color was the {1} button in {0}?
            [Question.BlindMazeColors] = new TranslationInfo
            {
                QuestionText = "What color was the {1} button in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Gray"] = "Gray",
                    ["Yellow"] = "Yellow",
                },
                FormatArgs = new Dictionary<string, string>
                {
                    ["north"] = "north",
                    ["east"] = "east",
                    ["west"] = "west",
                    ["south"] = "south",
                },
            },
            // Which maze did you solve {0} on?
            [Question.BlindMazeMaze] = new TranslationInfo
            {
                QuestionText = "Which maze did you solve {0} on?",
            },

            // Blockbusters
            // What was the last letter pressed on {0}?
            [Question.BlockbustersLastLetter] = new TranslationInfo
            {
                QuestionText = "What was the last letter pressed on {0}?",
            },

            // Blue Arrows
            // What were the letters on the screen in {0}?
            [Question.BlueArrowsInitialLetters] = new TranslationInfo
            {
                QuestionText = "What were the letters on the screen in {0}?",
            },

            // The Blue Button
            // What was D in {0}?
            [Question.BlueButtonD] = new TranslationInfo
            {
                QuestionText = "What was D in {0}?",
            },
            // What was {1} in {0}?
            [Question.BlueButtonEFGH] = new TranslationInfo
            {
                QuestionText = "What was {1} in {0}?",
            },
            // What was M in {0}?
            [Question.BlueButtonM] = new TranslationInfo
            {
                QuestionText = "What was M in {0}?",
            },
            // What was N in {0}?
            [Question.BlueButtonN] = new TranslationInfo
            {
                QuestionText = "What was N in {0}?",
            },
            // What was P in {0}?
            [Question.BlueButtonP] = new TranslationInfo
            {
                QuestionText = "What was P in {0}?",
            },
            // What was Q in {0}?
            [Question.BlueButtonQ] = new TranslationInfo
            {
                QuestionText = "What was Q in {0}?",
            },
            // What was X in {0}?
            [Question.BlueButtonX] = new TranslationInfo
            {
                QuestionText = "What was X in {0}?",
            },

            // Blue Cipher
            // What was the answer in {0}?
            [Question.BlueCipherAnswer] = new TranslationInfo
            {
                QuestionText = "What was the answer in {0}?",
            },

            // Bob Barks
            // What was the {1} indicator label in {0}?
            [Question.BobBarksIndicators] = new TranslationInfo
            {
                QuestionText = "What was the {1} indicator label in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["top left"] = "top left",
                    ["top right"] = "top right",
                    ["bottom left"] = "bottom left",
                    ["bottom right"] = "bottom right",
                },
            },
            // Which button flashed {1} in sequence in {0}?
            [Question.BobBarksPositions] = new TranslationInfo
            {
                QuestionText = "Which button flashed {1} in sequence in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["top left"] = "top left",
                    ["top right"] = "top right",
                    ["bottom left"] = "bottom left",
                    ["bottom right"] = "bottom right",
                },
            },

            // Boggle
            // What letter was initially visible on {0}?
            [Question.BoggleLetters] = new TranslationInfo
            {
                QuestionText = "What letter was initially visible on {0}?",
            },

            // Boxing
            // Which {1} appeared on {0}?
            [Question.BoxingNames] = new TranslationInfo
            {
                QuestionText = "Which {1} appeared on {0}?",
            },
            // What was the {1} of the contestant with strength rating {2} on {0}?
            [Question.BoxingContestantByStrength] = new TranslationInfo
            {
                QuestionText = "What was the {1} of the contestant with strength rating {2} on {0}?",
            },
            // What was {1}’s strength rating on {0}?
            [Question.BoxingStrengthByContestant] = new TranslationInfo
            {
                QuestionText = "What was {1}’s strength rating on {0}?",
            },

            // Braille
            // What was the solution word in {0}?
            [Question.BrailleWord] = new TranslationInfo
            {
                QuestionText = "What was the solution word in {0}?",
            },

            // Breakfast Egg
            // Which color appeared on the egg in {0}?
            [Question.BreakfastEggColor] = new TranslationInfo
            {
                QuestionText = "Which color appeared on the egg in {0}?",
            },

            // Broken Buttons
            // What was the {1} correct button you pressed in {0}?
            [Question.BrokenButtons] = new TranslationInfo
            {
                QuestionText = "What was the {1} correct button you pressed in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["bomb"] = "bomb",
                    ["blast"] = "blast",
                    ["boom"] = "boom",
                    ["burst"] = "burst",
                    ["wire"] = "wire",
                    ["button"] = "button",
                    ["module"] = "module",
                    ["light"] = "light",
                    ["led"] = "led",
                    ["switch"] = "switch",
                    ["RJ-45"] = "RJ-45",
                    ["DVI-D"] = "DVI-D",
                    ["RCA"] = "RCA",
                    ["PS/2"] = "PS/2",
                    ["serial"] = "serial",
                    ["port"] = "port",
                    ["row"] = "row",
                    ["column"] = "column",
                    ["one"] = "one",
                    ["two"] = "two",
                    ["three"] = "three",
                    ["four"] = "four",
                    ["five"] = "five",
                    ["six"] = "six",
                    ["seven"] = "seven",
                    ["eight"] = "eight",
                    ["size"] = "size",
                    ["this"] = "this",
                    ["that"] = "that",
                    ["other"] = "other",
                    ["submit"] = "submit",
                    ["abort"] = "abort",
                    ["drop"] = "drop",
                    ["thing"] = "thing",
                    ["blank"] = "blank",
                    ["broken"] = "broken",
                    ["too"] = "too",
                    ["to"] = "to",
                    ["yes"] = "yes",
                    ["see"] = "see",
                    ["sea"] = "sea",
                    ["c"] = "c",
                    ["wait"] = "wait",
                    ["word"] = "word",
                    ["bob"] = "bob",
                    ["no"] = "no",
                    ["not"] = "not",
                    ["first"] = "first",
                    ["hold"] = "hold",
                    ["late"] = "late",
                    ["fail"] = "fail",
                },
            },

            // Brown Cipher
            // What was the answer in {0}?
            [Question.BrownCipherAnswer] = new TranslationInfo
            {
                QuestionText = "What was the answer in {0}?",
            },

            // Brush Strokes
            // What was the color of the middle contact point in {0}?
            [Question.BrushStrokesMiddleColor] = new TranslationInfo
            {
                QuestionText = "What was the color of the middle contact point in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Lime"] = "Lime",
                    ["Green"] = "Green",
                    ["Cyan"] = "Cyan",
                    ["Sky"] = "Sky",
                    ["Blue"] = "Blue",
                    ["Purple"] = "Purple",
                    ["Magenta"] = "Magenta",
                    ["Brown"] = "Brown",
                    ["White"] = "White",
                    ["Gray"] = "Gray",
                    ["Black"] = "Black",
                    ["Pink"] = "Pink",
                },
            },

            // The Bulb
            // What were the correct button presses in {0}?
            [Question.BulbButtonPresses] = new TranslationInfo
            {
                QuestionText = "What were the correct button presses in {0}?",
            },

            // Burglar Alarm
            // What was the {1} displayed digit in {0}?
            [Question.BurglarAlarmDigits] = new TranslationInfo
            {
                QuestionText = "What was the {1} displayed digit in {0}?",
            },

            // The Button
            // What color did the light glow in {0}?
            [Question.ButtonLightColor] = new TranslationInfo
            {
                QuestionText = "What color did the light glow in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["blue"] = "blue",
                    ["yellow"] = "yellow",
                    ["white"] = "white",
                },
            },

            // Button Sequence
            // How many of the buttons in {0} were {1}?
            [Question.ButtonSequencesColorOccurrences] = new TranslationInfo
            {
                QuestionText = "How many of the buttons in {0} were {1}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["blue"] = "blue",
                    ["yellow"] = "yellow",
                    ["white"] = "white",
                },
            },

            // Caesar Cycle
            // What was the {1} in {0}?
            [Question.CaesarCycleWord] = new TranslationInfo
            {
                QuestionText = "What was the {1} in {0}?",
            },

            // Calendar
            // What was the LED color in {0}?
            [Question.CalendarLedColor] = new TranslationInfo
            {
                QuestionText = "What was the LED color in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Green"] = "Green",
                    ["Yellow"] = "Yellow",
                    ["Red"] = "Red",
                    ["Blue"] = "Blue",
                },
            },

            // Cartinese
            // What color was the {1} button in {0}?
            [Question.CartineseButtonColors] = new TranslationInfo
            {
                QuestionText = "What color was the {1} button in {0}?",
            },
            // What lyric was played by the {1} button in {0}?
            [Question.CartineseLyrics] = new TranslationInfo
            {
                QuestionText = "What lyric was played by the {1} button in {0}?",
            },

            // Challenge & Contact
            // What was the {1} submitted answer in {0}?
            [Question.ChallengeAndContactAnswers] = new TranslationInfo
            {
                QuestionText = "What was the {1} submitted answer in {0}?",
            },

            // Cheap Checkout
            // What was the {1}paid amount in {0}?
            [Question.CheapCheckoutPaid] = new TranslationInfo
            {
                QuestionText = "What was the {1}paid amount in {0}?",
            },

            // Cheep Checkout
            // Which bird {1} present in {0}?
            [Question.CheepCheckoutBirds] = new TranslationInfo
            {
                QuestionText = "Which bird {1} present in {0}?",
            },

            // Chess
            // What was the {1} coordinate in {0}?
            [Question.ChessCoordinate] = new TranslationInfo
            {
                QuestionText = "What was the {1} coordinate in {0}?",
            },

            // Chinese Counting
            // What color was the {1} LED in {0}?
            [Question.ChineseCountingLED] = new TranslationInfo
            {
                QuestionText = "What color was the {1} LED in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["White"] = "White",
                    ["Red"] = "Red",
                    ["Green"] = "Green",
                    ["Orange"] = "Orange",
                },
                FormatArgs = new Dictionary<string, string>
                {
                    ["left"] = "left",
                    ["right"] = "right",
                },
            },

            // Chord Qualities
            // Which note was part of the given chord in {0}?
            [Question.ChordQualitiesNotes] = new TranslationInfo
            {
                QuestionText = "Which note was part of the given chord in {0}?",
            },
            // What was the given chord quality in {0}?
            [Question.ChordQualitiesQuality] = new TranslationInfo
            {
                QuestionText = "What was the given chord quality in {0}?",
            },

            // The Code
            // What was the displayed number in {0}?
            [Question.CodeDisplayNumber] = new TranslationInfo
            {
                QuestionText = "What was the displayed number in {0}?",
            },

            // Codenames
            // Which of these words was submitted in {0}?
            [Question.CodenamesAnswers] = new TranslationInfo
            {
                QuestionText = "Which of these words was submitted in {0}?",
            },

            // Coffeebucks
            // What was the last served coffee in {0}?
            [Question.CoffeebucksCoffee] = new TranslationInfo
            {
                QuestionText = "What was the last served coffee in {0}?",
            },

            // Coinage
            // Which coin was flipped in {0}?
            [Question.CoinageFlip] = new TranslationInfo
            {
                QuestionText = "Which coin was flipped in {0}?",
            },

            // Color Braille
            // What mangling was applied in {0}?
            [Question.ColorBrailleMangling] = new TranslationInfo
            {
                QuestionText = "What mangling was applied in {0}?",
            },
            // What was the {1} word in {0}?
            [Question.ColorBrailleWords] = new TranslationInfo
            {
                QuestionText = "What was the {1} word in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                },
            },

            // Color Decoding
            // What was the {1}-stage indicator pattern in {0}?
            [Question.ColorDecodingIndicatorPattern] = new TranslationInfo
            {
                QuestionText = "What was the {1}-stage indicator pattern in {0}?",
            },
            // Which color {1} in the {2}-stage indicator pattern in {0}?
            [Question.ColorDecodingIndicatorColors] = new TranslationInfo
            {
                QuestionText = "Which color {1} in the {2}-stage indicator pattern in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Green"] = "Green",
                    ["Purple"] = "Purple",
                    ["Red"] = "Red",
                    ["Blue"] = "Blue",
                    ["Yellow"] = "Yellow",
                },
                FormatArgs = new Dictionary<string, string>
                {
                    ["appeared"] = "appeared",
                    ["did not appear"] = "did not appear",
                },
            },

            // Colored Keys
            // What was the displayed word in {0}?
            [Question.ColoredKeysDisplayWord] = new TranslationInfo
            {
                QuestionText = "What was the displayed word in {0}?",
            },
            // What was the displayed word’s color in {0}?
            [Question.ColoredKeysDisplayWordColor] = new TranslationInfo
            {
                QuestionText = "What was the displayed word’s color in {0}?",
            },
            // What was the color of the {1} key in {0}?
            [Question.ColoredKeysKeyColor] = new TranslationInfo
            {
                QuestionText = "What was the color of the {1} key in {0}?",
            },
            // What letter was on the {1} key in {0}?
            [Question.ColoredKeysKeyLetter] = new TranslationInfo
            {
                QuestionText = "What letter was on the {1} key in {0}?",
            },

            // Colored Squares
            // What was the first color group in {0}?
            [Question.ColoredSquaresFirstGroup] = new TranslationInfo
            {
                QuestionText = "What was the first color group in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["White"] = "White",
                    ["Red"] = "Red",
                    ["Blue"] = "Blue",
                    ["Green"] = "Green",
                    ["Yellow"] = "Yellow",
                    ["Magenta"] = "Magenta",
                },
            },

            // Colored Switches
            // What was the initial position of the switches in {0}?
            [Question.ColoredSwitchesInitialPosition] = new TranslationInfo
            {
                QuestionText = "What was the initial position of the switches in {0}?",
            },
            // What was the position of the switches when the LEDs came on in {0}?
            [Question.ColoredSwitchesWhenLEDsCameOn] = new TranslationInfo
            {
                QuestionText = "What was the position of the switches when the LEDs came on in {0}?",
            },

            // Color Morse
            // What was the color of the {1} LED in {0}?
            [Question.ColorMorseColor] = new TranslationInfo
            {
                QuestionText = "What was the color of the {1} LED in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Blue"] = "Blue",
                    ["Green"] = "Green",
                    ["Orange"] = "Orange",
                    ["Purple"] = "Purple",
                    ["Red"] = "Red",
                    ["Yellow"] = "Yellow",
                    ["White"] = "White",
                },
            },
            // What character was flashed by the {1} LED in {0}?
            [Question.ColorMorseCharacter] = new TranslationInfo
            {
                QuestionText = "What character was flashed by the {1} LED in {0}?",
            },

            // Colors Maximization
            // What was the submitted score in {0}?
            [Question.ColorsMaximizationSubmittedScore] = new TranslationInfo
            {
                QuestionText = "What was the submitted score in {0}?",
            },
            // What color {1} submitted as part of the solution in {0}?
            [Question.ColorsMaximizationSubmittedColor] = new TranslationInfo
            {
                QuestionText = "What color {1} submitted as part of the solution in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Blue"] = "Blue",
                    ["Green"] = "Green",
                    ["Magenta"] = "Magenta",
                    ["Red"] = "Red",
                    ["White"] = "White",
                    ["Yellow"] = "Yellow",
                },
            },
            // How many buttons were {1} in {0}?
            [Question.ColorsMaximizationColorCount] = new TranslationInfo
            {
                QuestionText = "How many buttons were {1} in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                },
            },

            // Colour Flash
            // What was the color of the last word in the sequence in {0}?
            [Question.ColourFlashLastColor] = new TranslationInfo
            {
                QuestionText = "What was the color of the last word in the sequence in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Magenta"] = "Magenta",
                    ["White"] = "White",
                },
            },

            // Coordinates
            // What was the solution you selected first in {0}?
            [Question.CoordinatesFirstSolution] = new TranslationInfo
            {
                QuestionText = "What was the solution you selected first in {0}?",
            },
            // What was the grid size in {0}?
            [Question.CoordinatesSize] = new TranslationInfo
            {
                QuestionText = "What was the grid size in {0}?",
            },

            // Corners
            // What was the color of the {1} corner in {0}?
            [Question.CornersColors] = new TranslationInfo
            {
                QuestionText = "What was the color of the {1} corner in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["yellow"] = "yellow",
                },
            },
            // How many corners in {0} were {1}?
            [Question.CornersColorCount] = new TranslationInfo
            {
                QuestionText = "How many corners in {0} were {1}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["yellow"] = "yellow",
                },
            },

            // Cosmic
            // What was the number initially shown in {0}?
            [Question.CosmicNumber] = new TranslationInfo
            {
                QuestionText = "What was the number initially shown in {0}?",
            },

            // Creation
            // What were the weather conditions on the {1} day in {0}?
            [Question.CreationWeather] = new TranslationInfo
            {
                QuestionText = "What were the weather conditions on the {1} day in {0}?",
            },

            // Critters
            // What was the alteration color used in {0}?
            [Question.CrittersAlterationColor] = new TranslationInfo
            {
                QuestionText = "What was the alteration color used in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Yellow"] = "Yellow",
                    ["Pink"] = "Pink",
                    ["Blue"] = "Blue",
                    ["White"] = "White",
                },
            },

            // Cryptic Cycle
            // What was the {1} in {0}?
            [Question.CrypticCycleWord] = new TranslationInfo
            {
                QuestionText = "What was the {1} in {0}?",
            },

            // Cryptic Keypad
            // What was the label of the {1} key in {0}?
            [Question.CrypticKeypadLabels] = new TranslationInfo
            {
                QuestionText = "What was the label of the {1} key in {0}?",
            },
            // Which cardinal direction was the {1} key rotated to in {0}?
            [Question.CrypticKeypadRotations] = new TranslationInfo
            {
                QuestionText = "Which cardinal direction was the {1} key rotated to in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["North"] = "North",
                    ["East"] = "East",
                    ["South"] = "South",
                    ["West"] = "West",
                },
            },

            // The Cube
            // What was the {1} cube rotation in {0}?
            [Question.CubeRotations] = new TranslationInfo
            {
                QuestionText = "What was the {1} cube rotation in {0}?",
            },

            // The Cyan Button
            // Where was the button at the {1} stage in {0}?
            [Question.CyanButtonPositions] = new TranslationInfo
            {
                QuestionText = "Where was the button at the {1} stage in {0}?",
            },

            // DACH Maze
            // Which region did you depart from in {0}?
            [Question.DACHMazeOrigin] = new TranslationInfo
            {
                QuestionText = "Which region did you depart from in {0}?",
            },

            // Deaf Alley
            // What was the shape generated in {0}?
            [Question.DeafAlleyShape] = new TranslationInfo
            {
                QuestionText = "What was the shape generated in {0}?",
            },

            // The Deck of Many Things
            // What deck did the first card of {0} belong to?
            [Question.DeckOfManyThingsFirstCard] = new TranslationInfo
            {
                QuestionText = "What deck did the first card of {0} belong to?",
            },

            // Decolored Squares
            // What was the starting {1} defining color in {0}?
            [Question.DecoloredSquaresStartingPos] = new TranslationInfo
            {
                QuestionText = "What was the starting {1} defining color in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["White"] = "White",
                    ["Red"] = "Red",
                    ["Blue"] = "Blue",
                    ["Green"] = "Green",
                    ["Yellow"] = "Yellow",
                    ["Magenta"] = "Magenta",
                },
                FormatArgs = new Dictionary<string, string>
                {
                    ["column"] = "column",
                    ["row"] = "row",
                },
            },

            // Devilish Eggs
            // What was the {1} egg’s {2} rotation in {0}?
            [Question.DevilishEggsRotations] = new TranslationInfo
            {
                QuestionText = "What was the {1} egg’s {2} rotation in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["top"] = "top",
                    ["bottom"] = "bottom",
                },
            },
            // What was the {1} digit in the string of numbers on {0}?
            [Question.DevilishEggsNumbers] = new TranslationInfo
            {
                QuestionText = "What was the {1} digit in the string of numbers on {0}?",
            },
            // What was the {1} letter in the string of letters on {0}?
            [Question.DevilishEggsLetters] = new TranslationInfo
            {
                QuestionText = "What was the {1} letter in the string of letters on {0}?",
            },

            // Digisibility
            // What was the number on the {1} button in {0}?
            [Question.DigisibilityDisplayedNumber] = new TranslationInfo
            {
                QuestionText = "What was the number on the {1} button in {0}?",
            },

            // Discolored Squares
            // What was {1}’s remembered position in {0}?
            [Question.DiscoloredSquaresRememberedPositions] = new TranslationInfo
            {
                QuestionText = "What was {1}’s remembered position in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["Blue"] = "Blue",
                    ["Red"] = "Red",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Magenta"] = "Magenta",
                },
            },

            // Divisible Numbers
            // What were the correct button presses in {0}?
            [Question.DivisibleNumbersAnswers] = new TranslationInfo
            {
                QuestionText = "What were the correct button presses in {0}?",
            },
            // What was the {1} stage’s number in {0}?
            [Question.DivisibleNumbersNumbers] = new TranslationInfo
            {
                QuestionText = "What was the {1} stage’s number in {0}?",
            },

            // Double Color
            // What was the screen color on the {1} stage of {0}?
            [Question.DoubleColorColors] = new TranslationInfo
            {
                QuestionText = "What was the screen color on the {1} stage of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Red"] = "Red",
                    ["Pink"] = "Pink",
                    ["Yellow"] = "Yellow",
                },
            },

            // Double Digits
            // What was the digit on the {1} display in {0}?
            [Question.DoubleDigitsDisplays] = new TranslationInfo
            {
                QuestionText = "What was the digit on the {1} display in {0}?",
            },

            // Double-Oh
            // Which button was the submit button in {0}?
            [Question.DoubleOhSubmitButton] = new TranslationInfo
            {
                QuestionText = "Which button was the submit button in {0}?",
            },

            // Dr. Doctor
            // Which of these symptoms was listed on {0}?
            [Question.DrDoctorSymptoms] = new TranslationInfo
            {
                QuestionText = "Which of these symptoms was listed on {0}?",
            },
            // Which of these diseases was listed on {0}, but not the one treated?
            [Question.DrDoctorDiseases] = new TranslationInfo
            {
                QuestionText = "Which of these diseases was listed on {0}, but not the one treated?",
            },

            // Dreamcipher
            // What was the decrypted word in {0}?
            [Question.DreamcipherWord] = new TranslationInfo
            {
                QuestionText = "What was the decrypted word in {0}?",
            },

            // Dumb Waiters
            // Which player {1} present in {0}?
            [Question.DumbWaitersPlayerAvailable] = new TranslationInfo
            {
                QuestionText = "Which player {1} present in {0}?",
            },

            // eeB gnillepS
            // What word was asked to be spelled in {0}?
            [Question.eeBgnillepSWord] = new TranslationInfo
            {
                QuestionText = "What word was asked to be spelled in {0}?",
            },

            // Eight
            // What was the last digit on the small display in {0}?
            [Question.EightLastSmallDisplayDigit] = new TranslationInfo
            {
                QuestionText = "What was the last digit on the small display in {0}?",
            },
            // What was the position of the last broken digit in {0}?
            [Question.EightLastBrokenDigitPosition] = new TranslationInfo
            {
                QuestionText = "What was the position of the last broken digit in {0}?",
            },
            // What were the last resulting digits in {0}?
            [Question.EightLastResultingDigits] = new TranslationInfo
            {
                QuestionText = "What were the last resulting digits in {0}?",
            },
            // What was the last displayed number in {0}?
            [Question.EightLastDisplayedNumber] = new TranslationInfo
            {
                QuestionText = "What was the last displayed number in {0}?",
            },

            // Elder Futhark
            // What was the {1} rune shown on {0}?
            [Question.ElderFutharkRunes] = new TranslationInfo
            {
                QuestionText = "What was the {1} rune shown on {0}?",
            },

            // Encrypted Equations
            // Which shape was the {1} operand in {0}?
            [Question.EncryptedEquationsShapes] = new TranslationInfo
            {
                QuestionText = "Which shape was the {1} operand in {0}?",
            },

            // Encrypted Hangman
            // What method of encryption was used by {0}?
            [Question.EncryptedHangmanEncryptionMethod] = new TranslationInfo
            {
                QuestionText = "What method of encryption was used by {0}?",
            },
            // What module name was encrypted by {0}?
            [Question.EncryptedHangmanModule] = new TranslationInfo
            {
                QuestionText = "What module name was encrypted by {0}?",
            },

            // Encrypted Maze
            // Which symbol on {0} was spinning {1}?
            [Question.EncryptedMazeSymbols] = new TranslationInfo
            {
                QuestionText = "Which symbol on {0} was spinning {1}?",
            },

            // Encrypted Morse
            // What was the {1} on {0}?
            [Question.EncryptedMorseCallResponse] = new TranslationInfo
            {
                QuestionText = "What was the {1} on {0}?",
            },

            // Encryption Bingo
            // What was the first encoding used in {0}?
            [Question.EncryptionBingoEncoding] = new TranslationInfo
            {
                QuestionText = "What was the first encoding used in {0}?",
            },

            // Entry Number Four
            // What was the first number shown in {0}?
            [Question.EntryNumberFourNumber1] = new TranslationInfo
            {
                QuestionText = "What was the first number shown in {0}?",
            },
            // What was the second number shown in {0}?
            [Question.EntryNumberFourNumber2] = new TranslationInfo
            {
                QuestionText = "What was the second number shown in {0}?",
            },
            // What was the third number shown in {0}?
            [Question.EntryNumberFourNumber3] = new TranslationInfo
            {
                QuestionText = "What was the third number shown in {0}?",
            },
            // What was the expected fourth entry in {0}?
            [Question.EntryNumberFourExpected] = new TranslationInfo
            {
                QuestionText = "What was the expected fourth entry in {0}?",
            },
            // What was the constant coefficient in {0}?
            [Question.EntryNumberFourCoeff] = new TranslationInfo
            {
                QuestionText = "What was the constant coefficient in {0}?",
            },

            // Entry Number One
            // What was the {1} number shown in {0}?
            [Question.EntryNumberOneNumbers] = new TranslationInfo
            {
                QuestionText = "What was the {1} number shown in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["second"] = "second",
                    ["third"] = "third",
                    ["fourth"] = "fourth",
                },
            },
            // What was the expected first entry in {0}?
            [Question.EntryNumberOneExpected] = new TranslationInfo
            {
                QuestionText = "What was the expected first entry in {0}?",
            },
            // What was the constant coefficient in {0}?
            [Question.EntryNumberOneCoeff] = new TranslationInfo
            {
                QuestionText = "What was the constant coefficient in {0}?",
            },

            // Equations X
            // What was the displayed symbol in {0}?
            [Question.EquationsXSymbols] = new TranslationInfo
            {
                QuestionText = "What was the displayed symbol in {0}?",
            },

            // Etterna
            // What was the beat for the {1} arrow from the bottom in {0}?
            [Question.EtternaNumber] = new TranslationInfo
            {
                QuestionText = "What was the beat for the {1} arrow from the bottom in {0}?",
            },

            // Exoplanets
            // What was the starting target planet in {0}?
            [Question.ExoplanetsStartingTargetPlanet] = new TranslationInfo
            {
                QuestionText = "What was the starting target planet in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["outer"] = "outer",
                    ["middle"] = "middle",
                    ["inner"] = "inner",
                    ["none"] = "none",
                },
            },
            // What was the starting target digit in {0}?
            [Question.ExoplanetsStartingTargetDigit] = new TranslationInfo
            {
                QuestionText = "What was the starting target digit in {0}?",
            },
            // What was the final target planet in {0}?
            [Question.ExoplanetsTargetPlanet] = new TranslationInfo
            {
                QuestionText = "What was the final target planet in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["outer"] = "outer",
                    ["middle"] = "middle",
                    ["inner"] = "inner",
                    ["none"] = "none",
                },
            },
            // What was the final target digit in {0}?
            [Question.ExoplanetsTargetDigit] = new TranslationInfo
            {
                QuestionText = "What was the final target digit in {0}?",
            },

            // Factoring Maze
            // What was one of the prime numbers chosen in {0}?
            [Question.FactoringMazeChosenPrimes] = new TranslationInfo
            {
                QuestionText = "What was one of the prime numbers chosen in {0}?",
            },

            // Factory Maze
            // What room did you start in in {0}?
            [Question.FactoryMazeStartRoom] = new TranslationInfo
            {
                QuestionText = "What room did you start in in {0}?",
            },

            // Fast Math
            // What was the last pair of letters in {0}?
            [Question.FastMathLastLetters] = new TranslationInfo
            {
                QuestionText = "What was the last pair of letters in {0}?",
            },

            // Faulty RGB Maze
            // What was the exit coordinate in {0}?
            [Question.FaultyRGBMazeExit] = new TranslationInfo
            {
                QuestionText = "What was the exit coordinate in {0}?",
            },
            // Where was the {1} key in {0}?
            [Question.FaultyRGBMazeKeys] = new TranslationInfo
            {
                QuestionText = "Where was the {1} key in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                },
            },
            // Which maze number was the {1} maze in {0}?
            [Question.FaultyRGBMazeNumber] = new TranslationInfo
            {
                QuestionText = "Which maze number was the {1} maze in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                },
            },

            // Flags
            // What was the displayed number in {0}?
            [Question.FlagsDisplayedNumber] = new TranslationInfo
            {
                QuestionText = "What was the displayed number in {0}?",
            },
            // What was the main country flag in {0}?
            [Question.FlagsMainCountry] = new TranslationInfo
            {
                QuestionText = "What was the main country flag in {0}?",
            },
            // Which of these country flags was shown, but not the main country flag, in {0}?
            [Question.FlagsCountries] = new TranslationInfo
            {
                QuestionText = "Which of these country flags was shown, but not the main country flag, in {0}?",
            },

            // Flashing Arrows
            // What number was displayed on {0}?
            [Question.FlashingArrowsDisplayedValue] = new TranslationInfo
            {
                QuestionText = "What number was displayed on {0}?",
            },
            // What color flashed {1} black on the relevant arrow in {0}?
            [Question.FlashingArrowsReferredArrow] = new TranslationInfo
            {
                QuestionText = "What color flashed {1} black on the relevant arrow in {0}?",
            },

            // Flashing Lights
            // How many times did the {1} LED flash {2} on {0}?
            [Question.FlashingLightsLEDFrequency] = new TranslationInfo
            {
                QuestionText = "How many times did the {1} LED flash {2} on {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["top"] = "top",
                    ["blue"] = "blue",
                    ["green"] = "green",
                    ["red"] = "red",
                    ["purple"] = "purple",
                    ["orange"] = "orange",
                    ["bottom"] = "bottom",
                },
            },

            // Flyswatting
            // Which fly was present, but not in the solution in {0}?
            [Question.FlyswattingUnpressed] = new TranslationInfo
            {
                QuestionText = "Which fly was present, but not in the solution in {0}?",
            },

            // Forget Any Color
            // What were the cylinders during stage {1} in {0}?
            [Question.ForgetAnyColorCylinder] = new TranslationInfo
            {
                QuestionText = "What were the cylinders during stage {1} in {0}?",
            },
            // What figure was used during stage {1} in {0}?
            [Question.ForgetAnyColorSequence] = new TranslationInfo
            {
                QuestionText = "What figure was used during stage {1} in {0}?",
            },

            // Forget Me
            // What number was in the {1} position of the initial puzzle in {0}?
            [Question.ForgetMeInitialState] = new TranslationInfo
            {
                QuestionText = "What number was in the {1} position of the initial puzzle in {0}?",
            },

            // Forget’s Ultimate Showdown
            // What was the {1} digit of the answer in {0}?
            [Question.ForgetsUltimateShowdownAnswer] = new TranslationInfo
            {
                QuestionText = "What was the {1} digit of the answer in {0}?",
            },
            // What was the {1} digit of the initial number in {0}?
            [Question.ForgetsUltimateShowdownInitial] = new TranslationInfo
            {
                QuestionText = "What was the {1} digit of the initial number in {0}?",
            },
            // What was the {1} digit of the bottom number in {0}?
            [Question.ForgetsUltimateShowdownBottom] = new TranslationInfo
            {
                QuestionText = "What was the {1} digit of the bottom number in {0}?",
            },
            // What was the {1} method used in {0}?
            [Question.ForgetsUltimateShowdownMethod] = new TranslationInfo
            {
                QuestionText = "What was the {1} method used in {0}?",
            },

            // Forget the Colors
            // What number was on the gear during stage {1} in {0}?
            [Question.ForgetTheColorsGearNumber] = new TranslationInfo
            {
                QuestionText = "What number was on the gear during stage {1} in {0}?",
            },
            // What number was on the large display during stage {1} in {0}?
            [Question.ForgetTheColorsLargeDisplay] = new TranslationInfo
            {
                QuestionText = "What number was on the large display during stage {1} in {0}?",
            },
            // What was the last decimal in the sine number received during stage {1} in {0}?
            [Question.ForgetTheColorsSineNumber] = new TranslationInfo
            {
                QuestionText = "What was the last decimal in the sine number received during stage {1} in {0}?",
            },
            // What color was the gear during stage {1} in {0}?
            [Question.ForgetTheColorsGearColor] = new TranslationInfo
            {
                QuestionText = "What color was the gear during stage {1} in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Cyan"] = "Cyan",
                    ["Blue"] = "Blue",
                    ["Purple"] = "Purple",
                    ["Pink"] = "Pink",
                    ["Maroon"] = "Maroon",
                    ["White"] = "White",
                    ["Gray"] = "Gray",
                },
            },
            // Which edgework-based rule was applied to the sum of nixies and gear during stage {1} in {0}?
            [Question.ForgetTheColorsRuleColor] = new TranslationInfo
            {
                QuestionText = "Which edgework-based rule was applied to the sum of nixies and gear during stage {1} in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Cyan"] = "Cyan",
                    ["Blue"] = "Blue",
                    ["Purple"] = "Purple",
                    ["Pink"] = "Pink",
                    ["Maroon"] = "Maroon",
                    ["White"] = "White",
                    ["Gray"] = "Gray",
                },
            },

            // Free Parking
            // What was the player token in {0}?
            [Question.FreeParkingToken] = new TranslationInfo
            {
                QuestionText = "What was the player token in {0}?",
            },

            // Functions
            // What was the last digit of your first query’s result in {0}?
            [Question.FunctionsLastDigit] = new TranslationInfo
            {
                QuestionText = "What was the last digit of your first query’s result in {0}?",
            },
            // What number was to the left of the displayed letter in {0}?
            [Question.FunctionsLeftNumber] = new TranslationInfo
            {
                QuestionText = "What number was to the left of the displayed letter in {0}?",
            },
            // What letter was displayed in {0}?
            [Question.FunctionsLetter] = new TranslationInfo
            {
                QuestionText = "What letter was displayed in {0}?",
            },
            // What number was to the right of the displayed letter in {0}?
            [Question.FunctionsRightNumber] = new TranslationInfo
            {
                QuestionText = "What number was to the right of the displayed letter in {0}?",
            },

            // Game of Life Cruel
            // Which of these was a color combination that occurred in {0}?
            [Question.GameOfLifeCruelColors] = new TranslationInfo
            {
                QuestionText = "Which of these was a color combination that occurred in {0}?",
            },

            // The Gamepad
            // What were the numbers on {0}?
            [Question.GamepadNumbers] = new TranslationInfo
            {
                QuestionText = "What were the numbers on {0}?",
            },

            // The Glitched Button
            // What was the cycling bit sequence in {0}?
            [Question.GlitchedButtonSequence] = new TranslationInfo
            {
                QuestionText = "What was the cycling bit sequence in {0}?",
            },

            // The Gray Button
            // What was the {1} coordinate on the display in {0}?
            [Question.GrayButtonCoordinates] = new TranslationInfo
            {
                QuestionText = "What was the {1} coordinate on the display in {0}?",
            },

            // Gray Cipher
            // What was the answer in {0}?
            [Question.GrayCipherAnswer] = new TranslationInfo
            {
                QuestionText = "What was the answer in {0}?",
            },

            // The Great Void
            // What was the {1} color in {0}?
            [Question.GreatVoidColor] = new TranslationInfo
            {
                QuestionText = "What was the {1} color in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Magenta"] = "Magenta",
                    ["Yellow"] = "Yellow",
                    ["Cyan"] = "Cyan",
                    ["White"] = "White",
                },
            },
            // What was the {1} digit in {0}?
            [Question.GreatVoidDigit] = new TranslationInfo
            {
                QuestionText = "What was the {1} digit in {0}?",
            },

            // Green Arrows
            // What was the last number on the display on {0}?
            [Question.GreenArrowsLastScreen] = new TranslationInfo
            {
                QuestionText = "What was the last number on the display on {0}?",
            },

            // The Green Button
            // What was the word submitted in {0}?
            [Question.GreenButtonWord] = new TranslationInfo
            {
                QuestionText = "What was the word submitted in {0}?",
            },

            // Green Cipher
            // What was the answer in {0}?
            [Question.GreenCipherAnswer] = new TranslationInfo
            {
                QuestionText = "What was the answer in {0}?",
            },

            // Gridlock
            // What was the starting location in {0}?
            [Question.GridLockStartingLocation] = new TranslationInfo
            {
                QuestionText = "What was the starting location in {0}?",
            },
            // What was the ending location in {0}?
            [Question.GridLockEndingLocation] = new TranslationInfo
            {
                QuestionText = "What was the ending location in {0}?",
            },
            // What was the starting color in {0}?
            [Question.GridLockStartingColor] = new TranslationInfo
            {
                QuestionText = "What was the starting color in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Green"] = "Green",
                    ["Yellow"] = "Yellow",
                    ["Red"] = "Red",
                    ["Blue"] = "Blue",
                },
            },

            // Grocery Store
            // What was the first item shown in {0}?
            [Question.GroceryStoreFirstItem] = new TranslationInfo
            {
                QuestionText = "What was the first item shown in {0}?",
            },

            // Gryphons
            // What was the gryphon’s name in {0}?
            [Question.GryphonsName] = new TranslationInfo
            {
                QuestionText = "What was the gryphon’s name in {0}?",
            },
            // What was the gryphon’s age in {0}?
            [Question.GryphonsAge] = new TranslationInfo
            {
                QuestionText = "What was the gryphon’s age in {0}?",
            },

            // Guess Who?
            // Who was the person recalled in {0}?
            [Question.GuessWhoPerson] = new TranslationInfo
            {
                QuestionText = "Who was the person recalled in {0}?",
            },

            // Hereditary Base Notation
            // What was the given number in {0}?
            [Question.HereditaryBaseNotationInitialNumber] = new TranslationInfo
            {
                QuestionText = "What was the given number in {0}?",
            },

            // The Hexabutton
            // What label was printed on {0}?
            [Question.HexabuttonLabel] = new TranslationInfo
            {
                QuestionText = "What label was printed on {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Jump"] = "Jump",
                    ["Boom"] = "Boom",
                    ["Claim"] = "Claim",
                    ["Button"] = "Button",
                    ["Hold"] = "Hold",
                    ["Blue"] = "Blue",
                },
            },

            // Hexamaze
            // What was the color of the pawn in {0}?
            [Question.HexamazePawnColor] = new TranslationInfo
            {
                QuestionText = "What was the color of the pawn in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Cyan"] = "Cyan",
                    ["Blue"] = "Blue",
                    ["Pink"] = "Pink",
                },
            },

            // hexOS
            // What were the deciphered letters in {0}?
            [Question.HexOSCipher] = new TranslationInfo
            {
                QuestionText = "What were the deciphered letters in {0}?",
            },
            // What was the deciphered phrase in {0}?
            [Question.HexOSOctCipher] = new TranslationInfo
            {
                QuestionText = "What was the deciphered phrase in {0}?",
            },
            // What was the {1} 3-digit number cycled by the screen in {0}?
            [Question.HexOSScreen] = new TranslationInfo
            {
                QuestionText = "What was the {1} 3-digit number cycled by the screen in {0}?",
            },
            // What were the rhythm values in {0}?
            [Question.HexOSSum] = new TranslationInfo
            {
                QuestionText = "What were the rhythm values in {0}?",
            },

            // Hidden Colors
            // What was the color of the main LED in {0}?
            [Question.HiddenColorsLED] = new TranslationInfo
            {
                QuestionText = "What was the color of the main LED in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Blue"] = "Blue",
                    ["Green"] = "Green",
                    ["Yellow"] = "Yellow",
                    ["Orange"] = "Orange",
                    ["Purple"] = "Purple",
                    ["Magenta"] = "Magenta",
                    ["White"] = "White",
                },
            },

            // Hill Cycle
            // What was the {1} in {0}?
            [Question.HillCycleWord] = new TranslationInfo
            {
                QuestionText = "What was the {1} in {0}?",
            },

            // Hogwarts
            // Which House was {1} solved for in {0}?
            [Question.HogwartsHouse] = new TranslationInfo
            {
                QuestionText = "Which House was {1} solved for in {0}?",
            },
            // Which module was solved for {1} in {0}?
            [Question.HogwartsModule] = new TranslationInfo
            {
                QuestionText = "Which module was solved for {1} in {0}?",
            },

            // Hold Ups
            // What was the name of the {1} shadow shown in {0}?
            [Question.HoldUpsShadows] = new TranslationInfo
            {
                QuestionText = "What was the name of the {1} shadow shown in {0}?",
            },

            // Horrible Memory
            // In what position was the button pressed on the {1} stage of {0}?
            [Question.HorribleMemoryPositions] = new TranslationInfo
            {
                QuestionText = "In what position was the button pressed on the {1} stage of {0}?",
            },
            // What was the label of the button pressed on the {1} stage of {0}?
            [Question.HorribleMemoryLabels] = new TranslationInfo
            {
                QuestionText = "What was the label of the button pressed on the {1} stage of {0}?",
            },
            // What color was the button pressed on the {1} stage of {0}?
            [Question.HorribleMemoryColors] = new TranslationInfo
            {
                QuestionText = "What color was the button pressed on the {1} stage of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["blue"] = "blue",
                    ["green"] = "green",
                    ["red"] = "red",
                    ["orange"] = "orange",
                    ["purple"] = "purple",
                    ["pink"] = "pink",
                },
            },

            // Homophones
            // What was the {1} displayed phrase in {0}?
            [Question.HomophonesDisplayedPhrases] = new TranslationInfo
            {
                QuestionText = "What was the {1} displayed phrase in {0}?",
            },

            // Human Resources
            // Which was a descriptor shown in {1} in {0}?
            [Question.HumanResourcesDescriptors] = new TranslationInfo
            {
                QuestionText = "Which was a descriptor shown in {1} in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                },
            },
            // Who was {1} in {0}?
            [Question.HumanResourcesHiredFired] = new TranslationInfo
            {
                QuestionText = "Who was {1} in {0}?",
            },

            // Hunting
            // Which of the first three stages of {0} had the {1} symbol {2}?
            [Question.HuntingColumnsRows] = new TranslationInfo
            {
                QuestionText = "Which of the first three stages of {0} had the {1} symbol {2}?",
                Answers = new Dictionary<string, string>
                {
                    ["none"] = "none",
                    ["first"] = "first",
                    ["second"] = "second",
                    ["first two"] = "first two",
                    ["third"] = "third",
                    ["first & third"] = "first & third",
                    ["second & third"] = "second & third",
                    ["all three"] = "all three",
                },
                FormatArgs = new Dictionary<string, string>
                {
                    ["column"] = "column",
                    ["row"] = "row",
                },
            },

            // The Hypercube
            // What was the {1} rotation in {0}?
            [Question.HypercubeRotations] = new TranslationInfo
            {
                QuestionText = "What was the {1} rotation in {0}?",
            },

            // The Hyperlink
            // What was the {1} character of the hyperlink in {0}?
            [Question.HyperlinkCharacters] = new TranslationInfo
            {
                QuestionText = "What was the {1} character of the hyperlink in {0}?",
            },
            // Which module was referenced on {0}?
            [Question.HyperlinkAnswer] = new TranslationInfo
            {
                QuestionText = "Which module was referenced on {0}?",
            },

            // Ice Cream
            // Which one of these flavours {1} to the {2} customer in {0}?
            [Question.IceCreamFlavour] = new TranslationInfo
            {
                QuestionText = "Which one of these flavours {1} to the {2} customer in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["was on offer, but not sold,"] = "was on offer, but not sold,",
                    ["was not on offer"] = "was not on offer",
                },
            },
            // Who was the {1} customer in {0}?
            [Question.IceCreamCustomer] = new TranslationInfo
            {
                QuestionText = "Who was the {1} customer in {0}?",
            },

            // Identification Crisis
            // What was the {1} shape used in {0}?
            [Question.IdentificationCrisisShape] = new TranslationInfo
            {
                QuestionText = "What was the {1} shape used in {0}?",
            },
            // What was the {1} identification module used in {0}?
            [Question.IdentificationCrisisDataset] = new TranslationInfo
            {
                QuestionText = "What was the {1} identification module used in {0}?",
            },

            // Identity Parade
            // Which hair color {1} listed in {0}?
            [Question.IdentityParadeHairColors] = new TranslationInfo
            {
                QuestionText = "Which hair color {1} listed in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Black"] = "Black",
                    ["Blonde"] = "Blonde",
                    ["Brown"] = "Brown",
                    ["Grey"] = "Grey",
                    ["Red"] = "Red",
                    ["White"] = "White",
                },
            },
            // Which build {1} listed in {0}?
            [Question.IdentityParadeBuilds] = new TranslationInfo
            {
                QuestionText = "Which build {1} listed in {0}?",
            },
            // Which attire {1} listed in {0}?
            [Question.IdentityParadeAttires] = new TranslationInfo
            {
                QuestionText = "Which attire {1} listed in {0}?",
            },

            // Indigo Cipher
            // What was the answer in {0}?
            [Question.IndigoCipherAnswer] = new TranslationInfo
            {
                QuestionText = "What was the answer in {0}?",
            },

            // Infinite Loop
            // What was the selected word in {0}?
            [Question.InfiniteLoopSelectedWord] = new TranslationInfo
            {
                QuestionText = "What was the selected word in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["anchor"] = "anchor",
                    ["axions"] = "axions",
                    ["brutal"] = "brutal",
                    ["bunker"] = "bunker",
                    ["ceased"] = "ceased",
                    ["cypher"] = "cypher",
                    ["demote"] = "demote",
                    ["devoid"] = "devoid",
                    ["ejects"] = "ejects",
                    ["expend"] = "expend",
                    ["fixate"] = "fixate",
                    ["fondly"] = "fondly",
                    ["geyser"] = "geyser",
                    ["guitar"] = "guitar",
                    ["hexing"] = "hexing",
                    ["hybrid"] = "hybrid",
                    ["incite"] = "incite",
                    ["inject"] = "inject",
                    ["jacked"] = "jacked",
                    ["jigsaw"] = "jigsaw",
                    ["kayaks"] = "kayaks",
                    ["komodo"] = "komodo",
                    ["lazuli"] = "lazuli",
                    ["logjam"] = "logjam",
                    ["maimed"] = "maimed",
                    ["musket"] = "musket",
                    ["nebula"] = "nebula",
                    ["nuking"] = "nuking",
                    ["overdo"] = "overdo",
                    ["oblong"] = "oblong",
                    ["photon"] = "photon",
                    ["probed"] = "probed",
                    ["quartz"] = "quartz",
                    ["quebec"] = "quebec",
                    ["refute"] = "refute",
                    ["regime"] = "regime",
                    ["sierra"] = "sierra",
                    ["swerve"] = "swerve",
                    ["tenacy"] = "tenacy",
                    ["thymes"] = "thymes",
                    ["ultima"] = "ultima",
                    ["utopia"] = "utopia",
                    ["valved"] = "valved",
                    ["viable"] = "viable",
                    ["wither"] = "wither",
                    ["wrench"] = "wrench",
                    ["xenons"] = "xenons",
                    ["xylose"] = "xylose",
                    ["yanked"] = "yanked",
                    ["yellow"] = "yellow",
                    ["zigged"] = "zigged",
                    ["zodiac"] = "zodiac",
                },
            },

            // Ingredients
            // Which ingredient was used in {0}?
            [Question.IngredientsIngredients] = new TranslationInfo
            {
                QuestionText = "Which ingredient was used in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Veal"] = "Veal",
                    ["Beef"] = "Beef",
                    ["Quail"] = "Quail",
                    ["FiletMignon"] = "FiletMignon",
                    ["Crab"] = "Crab",
                    ["Scallop"] = "Scallop",
                    ["Lobster"] = "Lobster",
                    ["Sole"] = "Sole",
                    ["Eel"] = "Eel",
                    ["SeaBass"] = "SeaBass",
                    ["Mussel"] = "Mussel",
                    ["Cod"] = "Cod",
                    ["Pumpkin"] = "Pumpkin",
                    ["Zucchini"] = "Zucchini",
                    ["Onion"] = "Onion",
                    ["Tomato"] = "Tomato",
                    ["Eggplant"] = "Eggplant",
                    ["Carrot"] = "Carrot",
                    ["Garlic"] = "Garlic",
                    ["Celery"] = "Celery",
                    ["Morel"] = "Morel",
                    ["Porcini"] = "Porcini",
                    ["Chanterelle"] = "Chanterelle",
                    ["Portobello"] = "Portobello",
                    ["BlackTruffle"] = "BlackTruffle",
                    ["KingOysterMushroom"] = "KingOysterMushroom",
                    ["BlackTrumpet"] = "BlackTrumpet",
                    ["MillerMushroom"] = "MillerMushroom",
                    ["Cloves"] = "Cloves",
                    ["Rosemary"] = "Rosemary",
                    ["Thyme"] = "Thyme",
                    ["BayLeaf"] = "BayLeaf",
                    ["Basil"] = "Basil",
                    ["Dill"] = "Dill",
                    ["Parsley"] = "Parsley",
                    ["Saffron"] = "Saffron",
                    ["Apricot"] = "Apricot",
                    ["Gooseberry"] = "Gooseberry",
                    ["Lemon"] = "Lemon",
                    ["Orange"] = "Orange",
                    ["Raspberry"] = "Raspberry",
                    ["Pear"] = "Pear",
                    ["Blackberry"] = "Blackberry",
                    ["Apple"] = "Apple",
                    ["Cheese"] = "Cheese",
                    ["Chocolate"] = "Chocolate",
                    ["Caviar"] = "Caviar",
                    ["Butter"] = "Butter",
                    ["OliveOil"] = "OliveOil",
                    ["Cornichon"] = "Cornichon",
                    ["Rice"] = "Rice",
                    ["Honey"] = "Honey",
                    ["SourCherry"] = "SourCherry",
                    ["Strawberry"] = "Strawberry",
                    ["BloodOrange"] = "BloodOrange",
                    ["Banana"] = "Banana",
                    ["Grapes"] = "Grapes",
                    ["Melon"] = "Melon",
                    ["Watermelon"] = "Watermelon",
                },
            },
            // Which ingredient was listed but not used in {0}?
            [Question.IngredientsNonIngredients] = new TranslationInfo
            {
                QuestionText = "Which ingredient was listed but not used in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Veal"] = "Veal",
                    ["Beef"] = "Beef",
                    ["Quail"] = "Quail",
                    ["FiletMignon"] = "FiletMignon",
                    ["Crab"] = "Crab",
                    ["Scallop"] = "Scallop",
                    ["Lobster"] = "Lobster",
                    ["Sole"] = "Sole",
                    ["Eel"] = "Eel",
                    ["SeaBass"] = "SeaBass",
                    ["Mussel"] = "Mussel",
                    ["Cod"] = "Cod",
                    ["Pumpkin"] = "Pumpkin",
                    ["Zucchini"] = "Zucchini",
                    ["Onion"] = "Onion",
                    ["Tomato"] = "Tomato",
                    ["Eggplant"] = "Eggplant",
                    ["Carrot"] = "Carrot",
                    ["Garlic"] = "Garlic",
                    ["Celery"] = "Celery",
                    ["Morel"] = "Morel",
                    ["Porcini"] = "Porcini",
                    ["Chanterelle"] = "Chanterelle",
                    ["Portobello"] = "Portobello",
                    ["BlackTruffle"] = "BlackTruffle",
                    ["KingOysterMushroom"] = "KingOysterMushroom",
                    ["BlackTrumpet"] = "BlackTrumpet",
                    ["MillerMushroom"] = "MillerMushroom",
                    ["Cloves"] = "Cloves",
                    ["Rosemary"] = "Rosemary",
                    ["Thyme"] = "Thyme",
                    ["BayLeaf"] = "BayLeaf",
                    ["Basil"] = "Basil",
                    ["Dill"] = "Dill",
                    ["Parsley"] = "Parsley",
                    ["Saffron"] = "Saffron",
                    ["Apricot"] = "Apricot",
                    ["Gooseberry"] = "Gooseberry",
                    ["Lemon"] = "Lemon",
                    ["Orange"] = "Orange",
                    ["Raspberry"] = "Raspberry",
                    ["Pear"] = "Pear",
                    ["Blackberry"] = "Blackberry",
                    ["Apple"] = "Apple",
                    ["Cheese"] = "Cheese",
                    ["Chocolate"] = "Chocolate",
                    ["Caviar"] = "Caviar",
                    ["Butter"] = "Butter",
                    ["OliveOil"] = "OliveOil",
                    ["Cornichon"] = "Cornichon",
                    ["Rice"] = "Rice",
                    ["Honey"] = "Honey",
                    ["SourCherry"] = "SourCherry",
                    ["Strawberry"] = "Strawberry",
                    ["BloodOrange"] = "BloodOrange",
                    ["Banana"] = "Banana",
                    ["Grapes"] = "Grapes",
                    ["Melon"] = "Melon",
                    ["Watermelon"] = "Watermelon",
                },
            },

            // Inner Connections
            // What color was the LED in {0}?
            [Question.InnerConnectionsLED] = new TranslationInfo
            {
                QuestionText = "What color was the LED in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Black"] = "Black",
                    ["Blue"] = "Blue",
                    ["Red"] = "Red",
                    ["White"] = "White",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                },
            },
            // What was the digit flashed in Morse in {0}?
            [Question.InnerConnectionsMorse] = new TranslationInfo
            {
                QuestionText = "What was the digit flashed in Morse in {0}?",
            },

            // Interpunct
            // What was the symbol displayed in stage {1} of {0}?
            [Question.InterpunctDisplay] = new TranslationInfo
            {
                QuestionText = "What was the symbol displayed in stage {1} of {0}?",
            },

            // IPA
            // What symbol was the correct answer in {0}?
            [Question.IpaSymbol] = new TranslationInfo
            {
                QuestionText = "What symbol was the correct answer in {0}?",
            },

            // The iPhone
            // What was the {1} PIN digit in {0}?
            [Question.iPhoneDigits] = new TranslationInfo
            {
                QuestionText = "What was the {1} PIN digit in {0}?",
            },

            // The Jewel Vault
            // What number was wheel {1} in {0}?
            [Question.JewelVaultWheels] = new TranslationInfo
            {
                QuestionText = "What number was wheel {1} in {0}?",
            },

            // Jumble Cycle
            // What was the {1} in {0}?
            [Question.JumbleCycleWord] = new TranslationInfo
            {
                QuestionText = "What was the {1} in {0}?",
            },

            // The Kanye Encounter
            // What was a food item displayed in {0}?
            [Question.KanyeEncounterFoods] = new TranslationInfo
            {
                QuestionText = "What was a food item displayed in {0}?",
            },

            // Keypad Magnified
            // What was the position of the LED in {0}?
            [Question.KeypadMagnifiedLED] = new TranslationInfo
            {
                QuestionText = "What was the position of the LED in {0}?",
            },

            // Kudosudoku
            // Which square was {1} in {0}?
            [Question.KudosudokuPrefilled] = new TranslationInfo
            {
                QuestionText = "Which square was {1} in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["pre-filled"] = "pre-filled",
                    ["not pre-filled"] = "not pre-filled",
                },
            },

            // Ladders
            // Which color was present on the second ladder in {0}?
            [Question.LaddersStage2Colors] = new TranslationInfo
            {
                QuestionText = "Which color was present on the second ladder in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Cyan"] = "Cyan",
                    ["Purple"] = "Purple",
                    ["Gray"] = "Gray",
                },
            },
            // What color was missing on the third ladder in {0}?
            [Question.LaddersStage3Missing] = new TranslationInfo
            {
                QuestionText = "What color was missing on the third ladder in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Cyan"] = "Cyan",
                    ["Purple"] = "Purple",
                    ["Gray"] = "Gray",
                },
            },

            // Lasers
            // What was the number on the {1} hatch on {0}?
            [Question.LasersHatches] = new TranslationInfo
            {
                QuestionText = "What was the number on the {1} hatch on {0}?",
            },

            // LED Encryption
            // What was the correct letter you pressed in the {1} stage of {0}?
            [Question.LEDEncryptionPressedLetters] = new TranslationInfo
            {
                QuestionText = "What was the correct letter you pressed in the {1} stage of {0}?",
            },

            // LED Math
            // What color was {1} in {0}?
            [Question.LEDMathLights] = new TranslationInfo
            {
                QuestionText = "What color was {1} in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Blue"] = "Blue",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                },
            },

            // LEDs
            // What was the initial color of the changed LED in {0}?
            [Question.LEDsOriginalColor] = new TranslationInfo
            {
                QuestionText = "What was the initial color of the changed LED in {0}?",
            },

            // LEGOs
            // What were the dimensions of the {1} piece in {0}?
            [Question.LEGOsPieceDimensions] = new TranslationInfo
            {
                QuestionText = "What were the dimensions of the {1} piece in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["cyan"] = "cyan",
                    ["magenta"] = "magenta",
                    ["yellow"] = "yellow",
                },
            },

            // Letter Math
            // What was the letter on the {1} display in {0}?
            [Question.LetterMathDisplay] = new TranslationInfo
            {
                QuestionText = "What was the letter on the {1} display in {0}?",
            },

            // Linq
            // What was the {1} function in {0}?
            [Question.LinqFunction] = new TranslationInfo
            {
                QuestionText = "What was the {1} function in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["First"] = "First",
                    ["Last"] = "Last",
                    ["Min"] = "Min",
                    ["Max"] = "Max",
                    ["Distinct"] = "Distinct",
                    ["Skip"] = "Skip",
                    ["SkipLast"] = "SkipLast",
                    ["Take"] = "Take",
                    ["TakeLast"] = "TakeLast",
                    ["ElementAt"] = "ElementAt",
                    ["Except"] = "Except",
                    ["Intersect"] = "Intersect",
                    ["Concat"] = "Concat",
                    ["Append"] = "Append",
                    ["Prepend"] = "Prepend",
                },
            },

            // Lion’s Share
            // Which year was displayed on {0}?
            [Question.LionsShareYear] = new TranslationInfo
            {
                QuestionText = "Which year was displayed on {0}?",
            },
            // Which lion was present but removed in {0}?
            [Question.LionsShareRemovedLions] = new TranslationInfo
            {
                QuestionText = "Which lion was present but removed in {0}?",
            },

            // Listening
            // What was the correct code you entered in {0}?
            [Question.ListeningCode] = new TranslationInfo
            {
                QuestionText = "What was the correct code you entered in {0}?",
            },

            // Logical Buttons
            // What was the color of the {1} button in the {2} stage of {0}?
            [Question.LogicalButtonsColor] = new TranslationInfo
            {
                QuestionText = "What was the color of the {1} button in the {2} stage of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Blue"] = "Blue",
                    ["Green"] = "Green",
                    ["Yellow"] = "Yellow",
                    ["Purple"] = "Purple",
                    ["White"] = "White",
                    ["Orange"] = "Orange",
                    ["Cyan"] = "Cyan",
                    ["Grey"] = "Grey",
                },
                FormatArgs = new Dictionary<string, string>
                {
                    ["top"] = "top",
                    ["bottom-left"] = "bottom-left",
                },
            },
            // What was the label on the {1} button in the {2} stage of {0}?
            [Question.LogicalButtonsLabel] = new TranslationInfo
            {
                QuestionText = "What was the label on the {1} button in the {2} stage of {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["top"] = "top",
                    ["bottom-left"] = "bottom-left",
                },
            },
            // What was the final operator in the {1} stage of {0}?
            [Question.LogicalButtonsOperator] = new TranslationInfo
            {
                QuestionText = "What was the final operator in the {1} stage of {0}?",
            },

            // Logic Gates
            // What was {1} in {0}?
            [Question.LogicGatesGates] = new TranslationInfo
            {
                QuestionText = "What was {1} in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["gate A"] = "gate A",
                    ["gate B"] = "gate B",
                    ["gate C"] = "gate C",
                    ["gate D"] = "gate D",
                    ["gate E"] = "gate E",
                    ["gate F"] = "gate F",
                    ["gate G"] = "gate G",
                    ["the duplicated gate"] = "the duplicated gate",
                },
            },

            // Lombax Cubes
            // What was the {1} letter on the button in {0}?
            [Question.LombaxCubesLetters] = new TranslationInfo
            {
                QuestionText = "What was the {1} letter on the button in {0}?",
            },

            // The London Underground
            // Where did the {1} journey on {0} {2}?
            [Question.LondonUndergroundStations] = new TranslationInfo
            {
                QuestionText = "Where did the {1} journey on {0} {2}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["depart from"] = "depart from",
                },
            },

            // Mahjong
            // Which tile was part of the {1} matched pair in {0}?
            [Question.MahjongMatches] = new TranslationInfo
            {
                QuestionText = "Which tile was part of the {1} matched pair in {0}?",
            },
            // Which tile was shown in the bottom-left of {0}?
            [Question.MahjongCountingTile] = new TranslationInfo
            {
                QuestionText = "Which tile was shown in the bottom-left of {0}?",
            },

            // Mafia
            // Who was a player, but not the Godfather, in {0}?
            [Question.MafiaPlayers] = new TranslationInfo
            {
                QuestionText = "Who was a player, but not the Godfather, in {0}?",
            },

            // M&Ms
            // What color was the text on the {1} button in {0}?
            [Question.MandMsColors] = new TranslationInfo
            {
                QuestionText = "What color was the text on the {1} button in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["orange"] = "orange",
                    ["blue"] = "blue",
                    ["yellow"] = "yellow",
                    ["brown"] = "brown",
                },
            },
            // What was the text on the {1} button in {0}?
            [Question.MandMsLabels] = new TranslationInfo
            {
                QuestionText = "What was the text on the {1} button in {0}?",
            },

            // M&Ns
            // What color was the text on the {1} button in {0}?
            [Question.MandNsColors] = new TranslationInfo
            {
                QuestionText = "What color was the text on the {1} button in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["orange"] = "orange",
                    ["blue"] = "blue",
                    ["yellow"] = "yellow",
                    ["brown"] = "brown",
                },
            },
            // What was the text on the correct button in {0}?
            [Question.MandNsLabel] = new TranslationInfo
            {
                QuestionText = "What was the text on the correct button in {0}?",
            },

            // Maritime Flags
            // What bearing was signalled in {0}?
            [Question.MaritimeFlagsBearing] = new TranslationInfo
            {
                QuestionText = "What bearing was signalled in {0}?",
            },
            // Which callsign was signalled in {0}?
            [Question.MaritimeFlagsCallsign] = new TranslationInfo
            {
                QuestionText = "Which callsign was signalled in {0}?",
            },

            // Mashematics
            // What was the answer in {0}?
            [Question.MashematicsAnswer] = new TranslationInfo
            {
                QuestionText = "What was the answer in {0}?",
            },
            // What was the {1} number in the equation on {0}?
            [Question.MashematicsCalculation] = new TranslationInfo
            {
                QuestionText = "What was the {1} number in the equation on {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["�ordinal"] = "�ordinal",
                },
            },

            // The Matrix
            // Which word was part of the latest access code in {0}?
            [Question.MatrixAccessCode] = new TranslationInfo
            {
                QuestionText = "Which word was part of the latest access code in {0}?",
            },
            // What was the glitched word in {0}?
            [Question.MatrixGlitchWord] = new TranslationInfo
            {
                QuestionText = "What was the glitched word in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["headjack"] = "headjack",
                    ["phone"] = "phone",
                    ["dystopia"] = "dystopia",
                    ["control"] = "control",
                    ["paradise"] = "paradise",
                    ["utopia"] = "utopia",
                    ["version"] = "version",
                    ["nebuchadnezzar"] = "nebuchadnezzar",
                    ["zion"] = "zion",
                    ["fight"] = "fight",
                    ["utopia"] = "utopia",
                    ["mind"] = "mind",
                    ["squiddy"] = "squiddy",
                    ["guns"] = "guns",
                    ["trace"] = "trace",
                    ["spoon"] = "spoon",
                    ["machine"] = "machine",
                    ["red"] = "red",
                    ["white"] = "white",
                    ["paradise"] = "paradise",
                    ["metacortex"] = "metacortex",
                    ["flint"] = "flint",
                    ["nova"] = "nova",
                    ["white"] = "white",
                    ["rabbit"] = "rabbit",
                    ["follow"] = "follow",
                    ["matrix"] = "matrix",
                    ["free"] = "free",
                    ["neural"] = "neural",
                    ["mind"] = "mind",
                    ["fight"] = "fight",
                    ["free"] = "free",
                    ["nova"] = "nova",
                    ["blue"] = "blue",
                    ["fields"] = "fields",
                    ["choice"] = "choice",
                    ["battery"] = "battery",
                    ["program"] = "program",
                    ["flint"] = "flint",
                    ["headjack"] = "headjack",
                    ["kungfu"] = "kungfu",
                    ["choi"] = "choi",
                    ["red"] = "red",
                    ["blue"] = "blue",
                    ["pill"] = "pill",
                    ["jump"] = "jump",
                    ["program"] = "program",
                    ["agent"] = "agent",
                    ["sentient"] = "sentient",
                    ["squiddy"] = "squiddy",
                    ["dystopia"] = "dystopia",
                    ["rabbit"] = "rabbit",
                    ["jump"] = "jump",
                    ["code"] = "code",
                    ["mirror"] = "mirror",
                    ["cookie"] = "cookie",
                    ["human"] = "human",
                    ["pill"] = "pill",
                    ["follow"] = "follow",
                    ["version"] = "version",
                    ["sentinel"] = "sentinel",
                    ["machine"] = "machine",
                    ["prison"] = "prison",
                    ["human"] = "human",
                    ["fields"] = "fields",
                    ["battery"] = "battery",
                    ["code"] = "code",
                    ["training"] = "training",
                    ["guns"] = "guns",
                    ["hel"] = "hel",
                    ["elevator"] = "elevator",
                    ["sentinel"] = "sentinel",
                    ["choi"] = "choi",
                    ["matrix"] = "matrix",
                    ["nebuchadnezzar"] = "nebuchadnezzar",
                    ["control"] = "control",
                    ["metacortex"] = "metacortex",
                    ["sentient"] = "sentient",
                    ["unplug"] = "unplug",
                    ["hardwire"] = "hardwire",
                    ["trainman"] = "trainman",
                    ["spoon"] = "spoon",
                    ["cookie"] = "cookie",
                    ["elevator"] = "elevator",
                    ["hardwire"] = "hardwire",
                    ["choice"] = "choice",
                    ["trace"] = "trace",
                    ["mirror"] = "mirror",
                    ["unplug"] = "unplug",
                    ["interface"] = "interface",
                    ["prison"] = "prison",
                    ["kungfu"] = "kungfu",
                    ["interface"] = "interface",
                    ["neural"] = "neural",
                    ["trainman"] = "trainman",
                    ["hel"] = "hel",
                    ["agent"] = "agent",
                    ["training"] = "training",
                    ["zion"] = "zion",
                    ["phone"] = "phone",
                },
            },

            // Maze
            // In which {1} was the starting position in {0}, counting from the {2}?
            [Question.MazeStartingPosition] = new TranslationInfo
            {
                QuestionText = "In which {1} was the starting position in {0}, counting from the {2}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["column"] = "column",
                    ["left"] = "left",
                    ["row"] = "row",
                    ["top"] = "top",
                },
            },

            // Maze³
            // What was the color of the starting face in {0}?
            [Question.Maze3StartingFace] = new TranslationInfo
            {
                QuestionText = "What was the color of the starting face in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Blue"] = "Blue",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Magenta"] = "Magenta",
                    ["Orange"] = "Orange",
                },
            },

            // Maze Identification
            // What was the seed of the maze in {0}?
            [Question.MazeIdentificationSeed] = new TranslationInfo
            {
                QuestionText = "What was the seed of the maze in {0}?",
            },
            // What was the function of button {1} in {0}?
            [Question.MazeIdentificationNum] = new TranslationInfo
            {
                QuestionText = "What was the function of button {1} in {0}?",
            },
            // Which button {1} in {0}?
            [Question.MazeIdentificationFunc] = new TranslationInfo
            {
                QuestionText = "Which button {1} in {0}?",
            },

            // Mazematics
            // Which was the {1} value in {0}?
            [Question.MazematicsValue] = new TranslationInfo
            {
                QuestionText = "Which was the {1} value in {0}?",
            },

            // Maze Scrambler
            // What was the starting position on {0}?
            [Question.MazeScramblerStart] = new TranslationInfo
            {
                QuestionText = "What was the starting position on {0}?",
            },
            // What was the goal on {0}?
            [Question.MazeScramblerGoal] = new TranslationInfo
            {
                QuestionText = "What was the goal on {0}?",
            },
            // Which of these positions was a maze marking on {0}?
            [Question.MazeScramblerIndicators] = new TranslationInfo
            {
                QuestionText = "Which of these positions was a maze marking on {0}?",
            },

            // Mazeseeker
            // How many walls surrounded this cell in {0}?
            [Question.MazeseekerCell] = new TranslationInfo
            {
                QuestionText = "How many walls surrounded this cell in {0}?",
            },
            // Where was the start in {0}?
            [Question.MazeseekerStart] = new TranslationInfo
            {
                QuestionText = "Where was the start in {0}?",
            },
            // Where was the goal in {0}?
            [Question.MazeseekerGoal] = new TranslationInfo
            {
                QuestionText = "Where was the goal in {0}?",
            },

            // Mega Man 2
            // Who was the master shown in {0}?
            [Question.MegaMan2SelectedMaster] = new TranslationInfo
            {
                QuestionText = "Who was the master shown in {0}?",
            },
            // Whose weapon was shown in {0}?
            [Question.MegaMan2SelectedWeapon] = new TranslationInfo
            {
                QuestionText = "Whose weapon was shown in {0}?",
            },

            // Melody Sequencer
            // Which part was in slot #{1} at the start of {0}?
            [Question.MelodySequencerSlots] = new TranslationInfo
            {
                QuestionText = "Which part was in slot #{1} at the start of {0}?",
            },
            // Which slot contained part #{1} at the start of {0}?
            [Question.MelodySequencerParts] = new TranslationInfo
            {
                QuestionText = "Which slot contained part #{1} at the start of {0}?",
            },

            // Memorable Buttons
            // What was the {1} correct symbol pressed in {0}?
            [Question.MemorableButtonsSymbols] = new TranslationInfo
            {
                QuestionText = "What was the {1} correct symbol pressed in {0}?",
            },

            // Memory
            // What was the displayed number in the {1} stage of {0}?
            [Question.MemoryDisplay] = new TranslationInfo
            {
                QuestionText = "What was the displayed number in the {1} stage of {0}?",
            },
            // In what position was the button that you pressed in the {1} stage of {0}?
            [Question.MemoryPosition] = new TranslationInfo
            {
                QuestionText = "In what position was the button that you pressed in the {1} stage of {0}?",
            },
            // What was the label of the button that you pressed in the {1} stage of {0}?
            [Question.MemoryLabel] = new TranslationInfo
            {
                QuestionText = "What was the label of the button that you pressed in the {1} stage of {0}?",
            },

            // Metamorse
            // What was the extracted letter in {0}?
            [Question.MetamorseExtractedLetter] = new TranslationInfo
            {
                QuestionText = "What was the extracted letter in {0}?",
            },

            // Microcontroller
            // Which pin lit up {1} in {0}?
            [Question.MicrocontrollerPinOrder] = new TranslationInfo
            {
                QuestionText = "Which pin lit up {1} in {0}?",
            },

            // Minesweeper
            // What was the color of the starting cell in {0}?
            [Question.MinesweeperStartingColor] = new TranslationInfo
            {
                QuestionText = "What was the color of the starting cell in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["orange"] = "orange",
                    ["yellow"] = "yellow",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["purple"] = "purple",
                    ["black"] = "black",
                },
            },

            // Mirror
            // What was the second word written by the original ghost in {0}?
            [Question.MirrorWord] = new TranslationInfo
            {
                QuestionText = "What was the second word written by the original ghost in {0}?",
            },

            // Mister Softee
            // Where was the SpongeBob Bar on {0}?
            [Question.MisterSofteeSpongebobPosition] = new TranslationInfo
            {
                QuestionText = "Where was the SpongeBob Bar on {0}?",
            },
            // Which treat was present on {0}?
            [Question.MisterSofteeTreatsPresent] = new TranslationInfo
            {
                QuestionText = "Which treat was present on {0}?",
            },

            // Modern Cipher
            // What was the decrypted word of the {1} stage in {0}?
            [Question.ModernCipherWord] = new TranslationInfo
            {
                QuestionText = "What was the decrypted word of the {1} stage in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Absent"] = "Absent",
                    ["Abstract"] = "Abstract",
                    ["Abysmal"] = "Abysmal",
                    ["Accident"] = "Accident",
                    ["Activate"] = "Activate",
                    ["Adjacent"] = "Adjacent",
                    ["Afraid"] = "Afraid",
                    ["Agenda"] = "Agenda",
                    ["Agony"] = "Agony",
                    ["Alchemy"] = "Alchemy",
                    ["Alcohol"] = "Alcohol",
                    ["Alive"] = "Alive",
                    ["Allergic"] = "Allergic",
                    ["Allergy"] = "Allergy",
                    ["Alpha"] = "Alpha",
                    ["Alphabet"] = "Alphabet",
                    ["Already"] = "Already",
                    ["Amethyst"] = "Amethyst",
                    ["Amnesty"] = "Amnesty",
                    ["Amperage"] = "Amperage",
                    ["Ancient"] = "Ancient",
                    ["Animals"] = "Animals",
                    ["Animate"] = "Animate",
                    ["Anthrax"] = "Anthrax",
                    ["Anxious"] = "Anxious",
                    ["Aquarium"] = "Aquarium",
                    ["Aquarius"] = "Aquarius",
                    ["Arcade"] = "Arcade",
                    ["Arrange"] = "Arrange",
                    ["Arrow"] = "Arrow",
                    ["Artefact"] = "Artefact",
                    ["Asterisk"] = "Asterisk",
                    ["Atrophy"] = "Atrophy",
                    ["Audio"] = "Audio",
                    ["Author"] = "Author",
                    ["Avoid"] = "Avoid",
                    ["Awesome"] = "Awesome",
                    ["Balance"] = "Balance",
                    ["Banana"] = "Banana",
                    ["Bandit"] = "Bandit",
                    ["Bankrupt"] = "Bankrupt",
                    ["Basket"] = "Basket",
                    ["Battle"] = "Battle",
                    ["Bazaar"] = "Bazaar",
                    ["Beard"] = "Beard",
                    ["Beauty"] = "Beauty",
                    ["Beaver"] = "Beaver",
                    ["Becoming"] = "Becoming",
                    ["Beetle"] = "Beetle",
                    ["Beseech"] = "Beseech",
                    ["Between"] = "Between",
                    ["Bicycle"] = "Bicycle",
                    ["Bigger"] = "Bigger",
                    ["Biggest"] = "Biggest",
                    ["Biology"] = "Biology",
                    ["Birthday"] = "Birthday",
                    ["Bistro"] = "Bistro",
                    ["Bites"] = "Bites",
                    ["Blight"] = "Blight",
                    ["Blockade"] = "Blockade",
                    ["Blubber"] = "Blubber",
                    ["Bomb"] = "Bomb",
                    ["Bonobo"] = "Bonobo",
                    ["Books"] = "Books",
                    ["Bottle"] = "Bottle",
                    ["Brazil"] = "Brazil",
                    ["Brief"] = "Brief",
                    ["Broccoli"] = "Broccoli",
                    ["Broken"] = "Broken",
                    ["Brother"] = "Brother",
                    ["Bubble"] = "Bubble",
                    ["Budget"] = "Budget",
                    ["Bulkhead"] = "Bulkhead",
                    ["Bumper"] = "Bumper",
                    ["Bunny"] = "Bunny",
                    ["Button"] = "Button",
                    ["Bytes"] = "Bytes",
                    ["Cables"] = "Cables",
                    ["Caliber"] = "Caliber",
                    ["Campaign"] = "Campaign",
                    ["Canada"] = "Canada",
                    ["Canister"] = "Canister",
                    ["Caption"] = "Caption",
                    ["Caution"] = "Caution",
                    ["Cavity"] = "Cavity",
                    ["Chalk"] = "Chalk",
                    ["Chamber"] = "Chamber",
                    ["Chamfer"] = "Chamfer",
                    ["Champion"] = "Champion",
                    ["Changes"] = "Changes",
                    ["Chicken"] = "Chicken",
                    ["Children"] = "Children",
                    ["Chlorine"] = "Chlorine",
                    ["Chord"] = "Chord",
                    ["Chronic"] = "Chronic",
                    ["Church"] = "Church",
                    ["Cinnamon"] = "Cinnamon",
                    ["Civic"] = "Civic",
                    ["Cleric"] = "Cleric",
                    ["Clock"] = "Clock",
                    ["Cocoon"] = "Cocoon",
                    ["Combat"] = "Combat",
                    ["Combine"] = "Combine",
                    ["Comedy"] = "Comedy",
                    ["Comics"] = "Comics",
                    ["Comma"] = "Comma",
                    ["Command"] = "Command",
                    ["Comment"] = "Comment",
                    ["Compost"] = "Compost",
                    ["Computer"] = "Computer",
                    ["Condom"] = "Condom",
                    ["Conflict"] = "Conflict",
                    ["Consider"] = "Consider",
                    ["Contour"] = "Contour",
                    ["Control"] = "Control",
                    ["Corrupt"] = "Corrupt",
                    ["Costume"] = "Costume",
                    ["Criminal"] = "Criminal",
                    ["Crunch"] = "Crunch",
                    ["Cryptic"] = "Cryptic",
                    ["Cuboid"] = "Cuboid",
                    ["Cypher"] = "Cypher",
                    ["Daddy"] = "Daddy",
                    ["Dancer"] = "Dancer",
                    ["Dancing"] = "Dancing",
                    ["Daughter"] = "Daughter",
                    ["Dead"] = "Dead",
                    ["Decapod"] = "Decapod",
                    ["Decay"] = "Decay",
                    ["Decoy"] = "Decoy",
                    ["Defeat"] = "Defeat",
                    ["Defuser"] = "Defuser",
                    ["Degree"] = "Degree",
                    ["Delay"] = "Delay",
                    ["Demigod"] = "Demigod",
                    ["Dentist"] = "Dentist",
                    ["Desert"] = "Desert",
                    ["Design"] = "Design",
                    ["Desire"] = "Desire",
                    ["Dessert"] = "Dessert",
                    ["Detail"] = "Detail",
                    ["Develop"] = "Develop",
                    ["Device"] = "Device",
                    ["Diamond"] = "Diamond",
                    ["Dictate"] = "Dictate",
                    ["Diffuse"] = "Diffuse",
                    ["Dilemma"] = "Dilemma",
                    ["Dingy"] = "Dingy",
                    ["Dinosaur"] = "Dinosaur",
                    ["Disease"] = "Disease",
                    ["Disgust"] = "Disgust",
                    ["Document"] = "Document",
                    ["Doubled"] = "Doubled",
                    ["Doubt"] = "Doubt",
                    ["Downbeat"] = "Downbeat",
                    ["Dragon"] = "Dragon",
                    ["Drawer"] = "Drawer",
                    ["Dream"] = "Dream",
                    ["Drink"] = "Drink",
                    ["Drunken"] = "Drunken",
                    ["Dungeon"] = "Dungeon",
                    ["Dynasty"] = "Dynasty",
                    ["Dyslexia"] = "Dyslexia",
                    ["Eclipse"] = "Eclipse",
                    ["Eldritch"] = "Eldritch",
                    ["Email"] = "Email",
                    ["Emulator"] = "Emulator",
                    ["Encrypt"] = "Encrypt",
                    ["England"] = "England",
                    ["Enlist"] = "Enlist",
                    ["Enough"] = "Enough",
                    ["Ensure"] = "Ensure",
                    ["Equality"] = "Equality",
                    ["Equation"] = "Equation",
                    ["Eruption"] = "Eruption",
                    ["Eternity"] = "Eternity",
                    ["Euphoria"] = "Euphoria",
                    ["Exact"] = "Exact",
                    ["Exclaim"] = "Exclaim",
                    ["Exhaust"] = "Exhaust",
                    ["Expert"] = "Expert",
                    ["Expertly"] = "Expertly",
                    ["Explain"] = "Explain",
                    ["Explodes"] = "Explodes",
                    ["Fabric"] = "Fabric",
                    ["Factory"] = "Factory",
                    ["Faded"] = "Faded",
                    ["Faint"] = "Faint",
                    ["Fair"] = "Fair",
                    ["False"] = "False",
                    ["Falter"] = "Falter",
                    ["Famous"] = "Famous",
                    ["Fantasy"] = "Fantasy",
                    ["Farm"] = "Farm",
                    ["Father"] = "Father",
                    ["Faucet"] = "Faucet",
                    ["Faulty"] = "Faulty",
                    ["Fearsome"] = "Fearsome",
                    ["Feast"] = "Feast",
                    ["February"] = "February",
                    ["Feint"] = "Feint",
                    ["Festival"] = "Festival",
                    ["Fiction"] = "Fiction",
                    ["Fighter"] = "Fighter",
                    ["Figure"] = "Figure",
                    ["Finish"] = "Finish",
                    ["Fireman"] = "Fireman",
                    ["Firework"] = "Firework",
                    ["First"] = "First",
                    ["Fixture"] = "Fixture",
                    ["Flagrant"] = "Flagrant",
                    ["Flagship"] = "Flagship",
                    ["Flamingo"] = "Flamingo",
                    ["Flesh"] = "Flesh",
                    ["Flipper"] = "Flipper",
                    ["Fluorine"] = "Fluorine",
                    ["Flush"] = "Flush",
                    ["Foreign"] = "Foreign",
                    ["Forensic"] = "Forensic",
                    ["Fractal"] = "Fractal",
                    ["Fragrant"] = "Fragrant",
                    ["France"] = "France",
                    ["Frantic"] = "Frantic",
                    ["Freak"] = "Freak",
                    ["Friction"] = "Friction",
                    ["Friday"] = "Friday",
                    ["Friendly"] = "Friendly",
                    ["Frighten"] = "Frighten",
                    ["Furor"] = "Furor",
                    ["Fused"] = "Fused",
                    ["Garage"] = "Garage",
                    ["Genes"] = "Genes",
                    ["Genetic"] = "Genetic",
                    ["Genius"] = "Genius",
                    ["Gentle"] = "Gentle",
                    ["Glacier"] = "Glacier",
                    ["Glitch"] = "Glitch",
                    ["Goat"] = "Goat",
                    ["Golden"] = "Golden",
                    ["Granular"] = "Granular",
                    ["Graphics"] = "Graphics",
                    ["Graphite"] = "Graphite",
                    ["Grateful"] = "Grateful",
                    ["Gridlock"] = "Gridlock",
                    ["Ground"] = "Ground",
                    ["Guitar"] = "Guitar",
                    ["Gumption"] = "Gumption",
                    ["Halogen"] = "Halogen",
                    ["Harmony"] = "Harmony",
                    ["Hawk"] = "Hawk",
                    ["Headache"] = "Headache",
                    ["Heard"] = "Heard",
                    ["Hedgehog"] = "Hedgehog",
                    ["Heinous"] = "Heinous",
                    ["Herd"] = "Herd",
                    ["Heretic"] = "Heretic",
                    ["Hexagon"] = "Hexagon",
                    ["Hiccup"] = "Hiccup",
                    ["Highway"] = "Highway",
                    ["Holiday"] = "Holiday",
                    ["Home"] = "Home",
                    ["Homesick"] = "Homesick",
                    ["Honest"] = "Honest",
                    ["Horror"] = "Horror",
                    ["Horse"] = "Horse",
                    ["House"] = "House",
                    ["Huge"] = "Huge",
                    ["Humanity"] = "Humanity",
                    ["Hungry"] = "Hungry",
                    ["Hydrogen"] = "Hydrogen",
                    ["Hysteria"] = "Hysteria",
                    ["Imagine"] = "Imagine",
                    ["Industry"] = "Industry",
                    ["Infamous"] = "Infamous",
                    ["Inside"] = "Inside",
                    ["Integral"] = "Integral",
                    ["Interest"] = "Interest",
                    ["Ironclad"] = "Ironclad",
                    ["Issue"] = "Issue",
                    ["Italic"] = "Italic",
                    ["Italy"] = "Italy",
                    ["Itch"] = "Itch",
                    ["Jaundice"] = "Jaundice",
                    ["Jeans"] = "Jeans",
                    ["Jeopardy"] = "Jeopardy",
                    ["Joyful"] = "Joyful",
                    ["Joystick"] = "Joystick",
                    ["Juice"] = "Juice",
                    ["Juncture"] = "Juncture",
                    ["Jungle"] = "Jungle",
                    ["Junkyard"] = "Junkyard",
                    ["Justice"] = "Justice",
                    ["Keep"] = "Keep",
                    ["Keyboard"] = "Keyboard",
                    ["Kilobyte"] = "Kilobyte",
                    ["Kilogram"] = "Kilogram",
                    ["Kingdom"] = "Kingdom",
                    ["Kitchen"] = "Kitchen",
                    ["Kitten"] = "Kitten",
                    ["Knife"] = "Knife",
                    ["Krypton"] = "Krypton",
                    ["Ladylike"] = "Ladylike",
                    ["Language"] = "Language",
                    ["Large"] = "Large",
                    ["Laughter"] = "Laughter",
                    ["Launch"] = "Launch",
                    ["Leaders"] = "Leaders",
                    ["Learn"] = "Learn",
                    ["Leave"] = "Leave",
                    ["Leopard"] = "Leopard",
                    ["Level"] = "Level",
                    ["Liberal"] = "Liberal",
                    ["Liberty"] = "Liberty",
                    ["Lifeboat"] = "Lifeboat",
                    ["Ligament"] = "Ligament",
                    ["Light"] = "Light",
                    ["Liquid"] = "Liquid",
                    ["Listen"] = "Listen",
                    ["Little"] = "Little",
                    ["Lobster"] = "Lobster",
                    ["Logical"] = "Logical",
                    ["Love"] = "Love",
                    ["Lucky"] = "Lucky",
                    ["Lulled"] = "Lulled",
                    ["Lunatic"] = "Lunatic",
                    ["Lurks"] = "Lurks",
                    ["Machine"] = "Machine",
                    ["Madam"] = "Madam",
                    ["Magnetic"] = "Magnetic",
                    ["Manager"] = "Manager",
                    ["Manual"] = "Manual",
                    ["Marina"] = "Marina",
                    ["Marine"] = "Marine",
                    ["Martian"] = "Martian",
                    ["Master"] = "Master",
                    ["Matrix"] = "Matrix",
                    ["Measure"] = "Measure",
                    ["Meaty"] = "Meaty",
                    ["Meddle"] = "Meddle",
                    ["Medical"] = "Medical",
                    ["Mental"] = "Mental",
                    ["Menu"] = "Menu",
                    ["Meow"] = "Meow",
                    ["Merchant"] = "Merchant",
                    ["Message"] = "Message",
                    ["Messes"] = "Messes",
                    ["Metal"] = "Metal",
                    ["Method"] = "Method",
                    ["Mettle"] = "Mettle",
                    ["Militant"] = "Militant",
                    ["Minim"] = "Minim",
                    ["Minimum"] = "Minimum",
                    ["Miracle"] = "Miracle",
                    ["Mirror"] = "Mirror",
                    ["Misjudge"] = "Misjudge",
                    ["Misplace"] = "Misplace",
                    ["Misses"] = "Misses",
                    ["Mistake"] = "Mistake",
                    ["Mixture"] = "Mixture",
                    ["Mnemonic"] = "Mnemonic",
                    ["Mobile"] = "Mobile",
                    ["Modern"] = "Modern",
                    ["Modest"] = "Modest",
                    ["Module"] = "Module",
                    ["Moist"] = "Moist",
                    ["Money"] = "Money",
                    ["Morning"] = "Morning",
                    ["Most"] = "Most",
                    ["Mother"] = "Mother",
                    ["Movies"] = "Movies",
                    ["Multiple"] = "Multiple",
                    ["Munch"] = "Munch",
                    ["Musical"] = "Musical",
                    ["Mustache"] = "Mustache",
                    ["Mystery"] = "Mystery",
                    ["Mystic"] = "Mystic",
                    ["Mystique"] = "Mystique",
                    ["Mythic"] = "Mythic",
                    ["Narcotic"] = "Narcotic",
                    ["Nasty"] = "Nasty",
                    ["Nature"] = "Nature",
                    ["Navigate"] = "Navigate",
                    ["Network"] = "Network",
                    ["Neutral"] = "Neutral",
                    ["Nobelium"] = "Nobelium",
                    ["Nobody"] = "Nobody",
                    ["Noise"] = "Noise",
                    ["Notice"] = "Notice",
                    ["Noun"] = "Noun",
                    ["Nuclear"] = "Nuclear",
                    ["Numeral"] = "Numeral",
                    ["Nutrient"] = "Nutrient",
                    ["Nymph"] = "Nymph",
                    ["Obelisk"] = "Obelisk",
                    ["Obstacle"] = "Obstacle",
                    ["Obvious"] = "Obvious",
                    ["Octopus"] = "Octopus",
                    ["Offset"] = "Offset",
                    ["Omega"] = "Omega",
                    ["Opaque"] = "Opaque",
                    ["Opinion"] = "Opinion",
                    ["Orange"] = "Orange",
                    ["Organic"] = "Organic",
                    ["Ouch"] = "Ouch",
                    ["Outbreak"] = "Outbreak",
                    ["Outdo"] = "Outdo",
                    ["Overcast"] = "Overcast",
                    ["Overlaps"] = "Overlaps",
                    ["Package"] = "Package",
                    ["Padlock"] = "Padlock",
                    ["Pancake"] = "Pancake",
                    ["Panda"] = "Panda",
                    ["Panic"] = "Panic",
                    ["Paper"] = "Paper",
                    ["Papers"] = "Papers",
                    ["Parent"] = "Parent",
                    ["Park"] = "Park",
                    ["Particle"] = "Particle",
                    ["Passive"] = "Passive",
                    ["Patented"] = "Patented",
                    ["Pathetic"] = "Pathetic",
                    ["Patient"] = "Patient",
                    ["Peace"] = "Peace",
                    ["Peasant"] = "Peasant",
                    ["Penalty"] = "Penalty",
                    ["Pencil"] = "Pencil",
                    ["Penguin"] = "Penguin",
                    ["Perfect"] = "Perfect",
                    ["Person"] = "Person",
                    ["Persuade"] = "Persuade",
                    ["Perusing"] = "Perusing",
                    ["Phone"] = "Phone",
                    ["Physical"] = "Physical",
                    ["Piano"] = "Piano",
                    ["Picture"] = "Picture",
                    ["Piglet"] = "Piglet",
                    ["Pilfer"] = "Pilfer",
                    ["Pillage"] = "Pillage",
                    ["Pinch"] = "Pinch",
                    ["Pirate"] = "Pirate",
                    ["Pitcher"] = "Pitcher",
                    ["Pizza"] = "Pizza",
                    ["Plane"] = "Plane",
                    ["Planet"] = "Planet",
                    ["Platonic"] = "Platonic",
                    ["Player"] = "Player",
                    ["Please"] = "Please",
                    ["Plucky"] = "Plucky",
                    ["Plunder"] = "Plunder",
                    ["Plurals"] = "Plurals",
                    ["Pocket"] = "Pocket",
                    ["Police"] = "Police",
                    ["Portrait"] = "Portrait",
                    ["Potato"] = "Potato",
                    ["Potently"] = "Potently",
                    ["Pounce"] = "Pounce",
                    ["Poverty"] = "Poverty",
                    ["Practice"] = "Practice",
                    ["Predict"] = "Predict",
                    ["Prefect"] = "Prefect",
                    ["Premium"] = "Premium",
                    ["Present"] = "Present",
                    ["Prince"] = "Prince",
                    ["Printer"] = "Printer",
                    ["Prison"] = "Prison",
                    ["Profit"] = "Profit",
                    ["Promise"] = "Promise",
                    ["Prophet"] = "Prophet",
                    ["Protein"] = "Protein",
                    ["Province"] = "Province",
                    ["Psalm"] = "Psalm",
                    ["Psychic"] = "Psychic",
                    ["Puddle"] = "Puddle",
                    ["Punchbag"] = "Punchbag",
                    ["Pungent"] = "Pungent",
                    ["Punish"] = "Punish",
                    ["Purchase"] = "Purchase",
                    ["Quagmire"] = "Quagmire",
                    ["Qualify"] = "Qualify",
                    ["Quantify"] = "Quantify",
                    ["Quantize"] = "Quantize",
                    ["Quarter"] = "Quarter",
                    ["Querying"] = "Querying",
                    ["Queue"] = "Queue",
                    ["Quiche"] = "Quiche",
                    ["Quick"] = "Quick",
                    ["Rabbit"] = "Rabbit",
                    ["Racoon"] = "Racoon",
                    ["Radar"] = "Radar",
                    ["Radical"] = "Radical",
                    ["Rainbow"] = "Rainbow",
                    ["Random"] = "Random",
                    ["Rattle"] = "Rattle",
                    ["Ravenous"] = "Ravenous",
                    ["Reason"] = "Reason",
                    ["Rebuke"] = "Rebuke",
                    ["Refine"] = "Refine",
                    ["Regular"] = "Regular",
                    ["Reindeer"] = "Reindeer",
                    ["Request"] = "Request",
                    ["Resort"] = "Resort",
                    ["Respect"] = "Respect",
                    ["Retire"] = "Retire",
                    ["Revolt"] = "Revolt",
                    ["Reward"] = "Reward",
                    ["Rhapsody"] = "Rhapsody",
                    ["Rhenium"] = "Rhenium",
                    ["Rhodium"] = "Rhodium",
                    ["Rhomboid"] = "Rhomboid",
                    ["Rhyme"] = "Rhyme",
                    ["Rhythm"] = "Rhythm",
                    ["Ridicule"] = "Ridicule",
                    ["Roadwork"] = "Roadwork",
                    ["Roar"] = "Roar",
                    ["Roast"] = "Roast",
                    ["Room"] = "Room",
                    ["Rooster"] = "Rooster",
                    ["Roster"] = "Roster",
                    ["Rotor"] = "Rotor",
                    ["Rotunda"] = "Rotunda",
                    ["Royal"] = "Royal",
                    ["Ruler"] = "Ruler",
                    ["Rural"] = "Rural",
                    ["Sailor"] = "Sailor",
                    ["Sainted"] = "Sainted",
                    ["Sales"] = "Sales",
                    ["Sally"] = "Sally",
                    ["Satisfy"] = "Satisfy",
                    ["Saunter"] = "Saunter",
                    ["Scale"] = "Scale",
                    ["Scandal"] = "Scandal",
                    ["Schedule"] = "Schedule",
                    ["School"] = "School",
                    ["Science"] = "Science",
                    ["Scratch"] = "Scratch",
                    ["Screen"] = "Screen",
                    ["Sensible"] = "Sensible",
                    ["Separate"] = "Separate",
                    ["Serious"] = "Serious",
                    ["Several"] = "Several",
                    ["Shampoo"] = "Shampoo",
                    ["Shares"] = "Shares",
                    ["Shelter"] = "Shelter",
                    ["Shift"] = "Shift",
                    ["Ship"] = "Ship",
                    ["Shirt"] = "Shirt",
                    ["Shiver"] = "Shiver",
                    ["Shorten"] = "Shorten",
                    ["Showcase"] = "Showcase",
                    ["Shuffle"] = "Shuffle",
                    ["Silent"] = "Silent",
                    ["Similar"] = "Similar",
                    ["Sister"] = "Sister",
                    ["Sixth"] = "Sixth",
                    ["Sixty"] = "Sixty",
                    ["Skater"] = "Skater",
                    ["Skyward"] = "Skyward",
                    ["Slander"] = "Slander",
                    ["Slayer"] = "Slayer",
                    ["Sleek"] = "Sleek",
                    ["Slipper"] = "Slipper",
                    ["Smart"] = "Smart",
                    ["Smeared"] = "Smeared",
                    ["Soccer"] = "Soccer",
                    ["Society"] = "Society",
                    ["Source"] = "Source",
                    ["Spain"] = "Spain",
                    ["Spare"] = "Spare",
                    ["Spark"] = "Spark",
                    ["Spatula"] = "Spatula",
                    ["Speaker"] = "Speaker",
                    ["Special"] = "Special",
                    ["Spectate"] = "Spectate",
                    ["Spectrum"] = "Spectrum",
                    ["Spicy"] = "Spicy",
                    ["Spinach"] = "Spinach",
                    ["Spiral"] = "Spiral",
                    ["Splendid"] = "Splendid",
                    ["Splinter"] = "Splinter",
                    ["Sprayed"] = "Sprayed",
                    ["Spread"] = "Spread",
                    ["Spring"] = "Spring",
                    ["Squadron"] = "Squadron",
                    ["Squander"] = "Squander",
                    ["Squash"] = "Squash",
                    ["Squib"] = "Squib",
                    ["Squid"] = "Squid",
                    ["Squish"] = "Squish",
                    ["Stake"] = "Stake",
                    ["Stalking"] = "Stalking",
                    ["Steak"] = "Steak",
                    ["Steam"] = "Steam",
                    ["Sticker"] = "Sticker",
                    ["Stinky"] = "Stinky",
                    ["Stocking"] = "Stocking",
                    ["Stone"] = "Stone",
                    ["Store"] = "Store",
                    ["Stormy"] = "Stormy",
                    ["Strange"] = "Strange",
                    ["Strike"] = "Strike",
                    ["Stutter"] = "Stutter",
                    ["Subway"] = "Subway",
                    ["Suffer"] = "Suffer",
                    ["Supreme"] = "Supreme",
                    ["Surf"] = "Surf",
                    ["Surplus"] = "Surplus",
                    ["Survey"] = "Survey",
                    ["Switch"] = "Switch",
                    ["Symbol"] = "Symbol",
                    ["System"] = "System",
                    ["Systemic"] = "Systemic",
                    ["Table"] = "Table",
                    ["Tadpole"] = "Tadpole",
                    ["Talking"] = "Talking",
                    ["Tangle"] = "Tangle",
                    ["Tank"] = "Tank",
                    ["Tapeworm"] = "Tapeworm",
                    ["Target"] = "Target",
                    ["Tarot"] = "Tarot",
                    ["Teach"] = "Teach",
                    ["Teamwork"] = "Teamwork",
                    ["Terminal"] = "Terminal",
                    ["Terminus"] = "Terminus",
                    ["Terror"] = "Terror",
                    ["Testify"] = "Testify",
                    ["Their"] = "Their",
                    ["There"] = "There",
                    ["Thick"] = "Thick",
                    ["Thief"] = "Thief",
                    ["Think"] = "Think",
                    ["Throat"] = "Throat",
                    ["Through"] = "Through",
                    ["Thunder"] = "Thunder",
                    ["Thyme"] = "Thyme",
                    ["Ticket"] = "Ticket",
                    ["Time"] = "Time",
                    ["Toaster"] = "Toaster",
                    ["Tomato"] = "Tomato",
                    ["Tone"] = "Tone",
                    ["Torque"] = "Torque",
                    ["Tortoise"] = "Tortoise",
                    ["Touchy"] = "Touchy",
                    ["Toupe"] = "Toupe",
                    ["Tower"] = "Tower",
                    ["Transfix"] = "Transfix",
                    ["Transit"] = "Transit",
                    ["Trash"] = "Trash",
                    ["Trauma"] = "Trauma",
                    ["Treason"] = "Treason",
                    ["Treasure"] = "Treasure",
                    ["Trick"] = "Trick",
                    ["Tripod"] = "Tripod",
                    ["Trouble"] = "Trouble",
                    ["Truck"] = "Truck",
                    ["Trumpet"] = "Trumpet",
                    ["Turtle"] = "Turtle",
                    ["Twinkle"] = "Twinkle",
                    ["Ugly"] = "Ugly",
                    ["Ultra"] = "Ultra",
                    ["Umbrella"] = "Umbrella",
                    ["Underway"] = "Underway",
                    ["Unique"] = "Unique",
                    ["Unknown"] = "Unknown",
                    ["Unsteady"] = "Unsteady",
                    ["Untoward"] = "Untoward",
                    ["Unwashed"] = "Unwashed",
                    ["Upgrade"] = "Upgrade",
                    ["Urban"] = "Urban",
                    ["Used"] = "Used",
                    ["Useless"] = "Useless",
                    ["Utopia"] = "Utopia",
                    ["Vacuum"] = "Vacuum",
                    ["Vampire"] = "Vampire",
                    ["Vanish"] = "Vanish",
                    ["Vanquish"] = "Vanquish",
                    ["Various"] = "Various",
                    ["Vast"] = "Vast",
                    ["Velocity"] = "Velocity",
                    ["Vendor"] = "Vendor",
                    ["Verb"] = "Verb",
                    ["Verbatim"] = "Verbatim",
                    ["Verdict"] = "Verdict",
                    ["Vexation"] = "Vexation",
                    ["Vicious"] = "Vicious",
                    ["Victim"] = "Victim",
                    ["Victory"] = "Victory",
                    ["Video"] = "Video",
                    ["View"] = "View",
                    ["Viking"] = "Viking",
                    ["Village"] = "Village",
                    ["Violent"] = "Violent",
                    ["Violin"] = "Violin",
                    ["Virulent"] = "Virulent",
                    ["Visceral"] = "Visceral",
                    ["Vision"] = "Vision",
                    ["Volatile"] = "Volatile",
                    ["Voltage"] = "Voltage",
                    ["Vortex"] = "Vortex",
                    ["Vulgar"] = "Vulgar",
                    ["Warden"] = "Warden",
                    ["Warlock"] = "Warlock",
                    ["Warning"] = "Warning",
                    ["Wealth"] = "Wealth",
                    ["Weapon"] = "Weapon",
                    ["Wedding"] = "Wedding",
                    ["Weight"] = "Weight",
                    ["Whack"] = "Whack",
                    ["Wharf"] = "Wharf",
                    ["What"] = "What",
                    ["When"] = "When",
                    ["Whisk"] = "Whisk",
                    ["Whistle"] = "Whistle",
                    ["Wicked"] = "Wicked",
                    ["Window"] = "Window",
                    ["Winter"] = "Winter",
                    ["Witness"] = "Witness",
                    ["Wizard"] = "Wizard",
                    ["Wrench"] = "Wrench",
                    ["Wretch"] = "Wretch",
                    ["Wrinkle"] = "Wrinkle",
                    ["Writer"] = "Writer",
                    ["Xanthous"] = "Xanthous",
                    ["Yacht"] = "Yacht",
                    ["Yarn"] = "Yarn",
                    ["Yawn"] = "Yawn",
                    ["Yeah"] = "Yeah",
                    ["Yearlong"] = "Yearlong",
                    ["Yearn"] = "Yearn",
                    ["Yeoman"] = "Yeoman",
                    ["Yodel"] = "Yodel",
                    ["Yoga"] = "Yoga",
                    ["Yonder"] = "Yonder",
                    ["Youngest"] = "Youngest",
                    ["Yourself"] = "Yourself",
                    ["Zealot"] = "Zealot",
                    ["Zebra"] = "Zebra",
                    ["Zenith"] = "Zenith",
                    ["Zither"] = "Zither",
                    ["Zodiac"] = "Zodiac",
                    ["Zombie"] = "Zombie",
                },
            },

            // Module Listening
            // Which module did the sound played by the {1} button belong to in {0}?
            [Question.ModuleListeningSounds] = new TranslationInfo
            {
                QuestionText = "Which module did the sound played by the {1} button belong to in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["yellow"] = "yellow",
                },
            },

            // Module Maze
            // Which of the following was the starting icon for {0}?
            [Question.ModuleMazeStartingIcon] = new TranslationInfo
            {
                QuestionText = "Which of the following was the starting icon for {0}?",
            },

            // Monsplode, Fight!
            // Which creature was displayed in {0}?
            [Question.MonsplodeFightCreature] = new TranslationInfo
            {
                QuestionText = "Which creature was displayed in {0}?",
            },
            // Which one of these moves {1} selectable in {0}?
            [Question.MonsplodeFightMove] = new TranslationInfo
            {
                QuestionText = "Which one of these moves {1} selectable in {0}?",
            },

            // Monsplode Trading Cards
            // What was the {1} before the last action in {0}?
            [Question.MonsplodeTradingCardsCards] = new TranslationInfo
            {
                QuestionText = "What was the {1} before the last action in {0}?",
            },
            // What was the print version of the {1} before the last action in {0}?
            [Question.MonsplodeTradingCardsPrintVersions] = new TranslationInfo
            {
                QuestionText = "What was the print version of the {1} before the last action in {0}?",
            },

            // The Moon
            // What was the {1} set in clockwise order in {0}?
            [Question.MoonLitUnlit] = new TranslationInfo
            {
                QuestionText = "What was the {1} set in clockwise order in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["south"] = "south",
                    ["south-west"] = "south-west",
                    ["west"] = "west",
                    ["north-west"] = "north-west",
                    ["north"] = "north",
                    ["north-east"] = "north-east",
                    ["east"] = "east",
                    ["south-east"] = "south-east",
                },
            },

            // More Code
            // What was the flashing word in {0}?
            [Question.MoreCodeWord] = new TranslationInfo
            {
                QuestionText = "What was the flashing word in {0}?",
            },

            // Morse-A-Maze
            // What was the starting location in {0}?
            [Question.MorseAMazeStartingCoordinate] = new TranslationInfo
            {
                QuestionText = "What was the starting location in {0}?",
            },
            // What was the ending location in {0}?
            [Question.MorseAMazeEndingCoordinate] = new TranslationInfo
            {
                QuestionText = "What was the ending location in {0}?",
            },
            // What was the word shown as Morse code in {0}?
            [Question.MorseAMazeMorseCodeWord] = new TranslationInfo
            {
                QuestionText = "What was the word shown as Morse code in {0}?",
            },

            // Morse Buttons
            // What was the character flashed by the {1} button in {0}?
            [Question.MorseButtonsButtonLabel] = new TranslationInfo
            {
                QuestionText = "What was the character flashed by the {1} button in {0}?",
            },
            // What was the color flashed by the {1} button in {0}?
            [Question.MorseButtonsButtonColor] = new TranslationInfo
            {
                QuestionText = "What was the color flashed by the {1} button in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["blue"] = "blue",
                    ["green"] = "green",
                    ["yellow"] = "yellow",
                    ["orange"] = "orange",
                    ["purple"] = "purple",
                },
            },

            // Morsematics
            // What was the {1} received letter in {0}?
            [Question.MorsematicsReceivedLetters] = new TranslationInfo
            {
                QuestionText = "What was the {1} received letter in {0}?",
            },

            // Morse War
            // What were the LEDs in the {1} row in {0} (1 = on, 0 = off)?
            [Question.MorseWarLeds] = new TranslationInfo
            {
                QuestionText = "What were the LEDs in the {1} row in {0} (1 = on, 0 = off)?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["bottom"] = "bottom",
                    ["middle"] = "middle",
                    ["top"] = "top",
                },
            },
            // What code was transmitted in {0}?
            [Question.MorseWarCode] = new TranslationInfo
            {
                QuestionText = "What code was transmitted in {0}?",
            },

            // Mouse in the Maze
            // What color was the torus in {0}?
            [Question.MouseInTheMazeTorus] = new TranslationInfo
            {
                QuestionText = "What color was the torus in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["white"] = "white",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["yellow"] = "yellow",
                },
            },
            // Which color sphere was the goal in {0}?
            [Question.MouseInTheMazeSphere] = new TranslationInfo
            {
                QuestionText = "Which color sphere was the goal in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["white"] = "white",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["yellow"] = "yellow",
                },
            },

            // M-Seq
            // What was the {1} obtained digit in {0}?
            [Question.MSeqObtained] = new TranslationInfo
            {
                QuestionText = "What was the {1} obtained digit in {0}?",
            },
            // What was the final number from the iteration process in {0}?
            [Question.MSeqSubmitted] = new TranslationInfo
            {
                QuestionText = "What was the final number from the iteration process in {0}?",
            },

            // Multicolored Switches
            // What color was the {1} LED on the {2} row when the tiny LED was {3} in {0}?
            [Question.MulticoloredSwitchesLedColor] = new TranslationInfo
            {
                QuestionText = "What color was the {1} LED on the {2} row when the tiny LED was {3} in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["black"] = "black",
                    ["red"] = "red",
                    ["green"] = "green",
                    ["yellow"] = "yellow",
                    ["blue"] = "blue",
                    ["magenta"] = "magenta",
                    ["cyan"] = "cyan",
                    ["white"] = "white",
                },
                FormatArgs = new Dictionary<string, string>
                {
                    ["top"] = "top",
                    ["lit"] = "lit",
                    ["unlit"] = "unlit",
                },
            },

            // Murder
            // Where was the body found in {0}?
            [Question.MurderBodyFound] = new TranslationInfo
            {
                QuestionText = "Where was the body found in {0}?",
            },
            // Which of these was {1} in {0}?
            [Question.MurderSuspect] = new TranslationInfo
            {
                QuestionText = "Which of these was {1} in {0}?",
            },
            // Which of these was {1} in {0}?
            [Question.MurderWeapon] = new TranslationInfo
            {
                QuestionText = "Which of these was {1} in {0}?",
            },

            // Mystery Module
            // Which module was the first requested to be solved by {0}?
            [Question.MysteryModuleFirstKey] = new TranslationInfo
            {
                QuestionText = "Which module was the first requested to be solved by {0}?",
            },
            // Which module was hidden by {0}?
            [Question.MysteryModuleHiddenModule] = new TranslationInfo
            {
                QuestionText = "Which module was hidden by {0}?",
            },

            // Mystic Square
            // Where was the skull in {0}?
            [Question.MysticSquareSkull] = new TranslationInfo
            {
                QuestionText = "Where was the skull in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["top left"] = "top left",
                    ["top middle"] = "top middle",
                    ["top right"] = "top right",
                    ["middle left"] = "middle left",
                    ["center"] = "center",
                    ["middle right"] = "middle right",
                    ["bottom left"] = "bottom left",
                    ["bottom middle"] = "bottom middle",
                    ["bottom right"] = "bottom right",
                },
            },

            // The Necronomicon
            // What was the chapter number of the {1} page in {0}?
            [Question.NecronomiconChapters] = new TranslationInfo
            {
                QuestionText = "What was the chapter number of the {1} page in {0}?",
            },

            // Negativity
            // In base 10, what was the value submitted in {0}?
            [Question.NegativitySubmittedValue] = new TranslationInfo
            {
                QuestionText = "In base 10, what was the value submitted in {0}?",
            },
            // Excluding 0s, what was the submitted balanced ternary in {0}?
            [Question.NegativitySubmittedTernary] = new TranslationInfo
            {
                QuestionText = "Excluding 0s, what was the submitted balanced ternary in {0}?",
            },

            // Neutralization
            // What was the acid’s color in {0}?
            [Question.NeutralizationColor] = new TranslationInfo
            {
                QuestionText = "What was the acid’s color in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Red"] = "Red",
                    ["Blue"] = "Blue",
                },
            },
            // What was the acid’s volume in {0}?
            [Question.NeutralizationVolume] = new TranslationInfo
            {
                QuestionText = "What was the acid’s volume in {0}?",
            },

            // N&Ms
            // What was the label of the correct button in {0}?
            [Question.NandMsAnswer] = new TranslationInfo
            {
                QuestionText = "What was the label of the correct button in {0}?",
            },

            // Name Codes
            // What was the {1} index in {0}?
            [Question.NameCodesIndices] = new TranslationInfo
            {
                QuestionText = "What was the {1} index in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["left"] = "left",
                    ["right"] = "right",
                },
            },

            // Navinums
            // What was the initial middle digit in {0}?
            [Question.NavinumsMiddleDigit] = new TranslationInfo
            {
                QuestionText = "What was the initial middle digit in {0}?",
            },
            // What was the {1} directional button pressed in {0}?
            [Question.NavinumsDirectionalButtons] = new TranslationInfo
            {
                QuestionText = "What was the {1} directional button pressed in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["up"] = "up",
                    ["left"] = "left",
                    ["right"] = "right",
                    ["down"] = "down",
                },
            },

            // The Navy Button
            // Which Greek letter appeared on {0} (case-sensitive)?
            [Question.NavyButtonGreekLetters] = new TranslationInfo
            {
                QuestionText = "Which Greek letter appeared on {0} (case-sensitive)?",
            },
            // What was the {1} of the given in {0} (0-indexed)?
            [Question.NavyButtonGiven] = new TranslationInfo
            {
                QuestionText = "What was the {1} of the given in {0} (0-indexed)?",
            },

            // Not Connection Check
            // What symbol flashed on the {1} button in {0}?
            [Question.NotConnectionCheckFlashes] = new TranslationInfo
            {
                QuestionText = "What symbol flashed on the {1} button in {0}?",
            },
            // What was the value of the {1} button in {0}?
            [Question.NotConnectionCheckValues] = new TranslationInfo
            {
                QuestionText = "What was the value of the {1} button in {0}?",
            },

            // Not Coordinates
            // Which coordinate was part of the square in {0}?
            [Question.NotCoordinatesSquareCoords] = new TranslationInfo
            {
                QuestionText = "Which coordinate was part of the square in {0}?",
            },
            // What was the function of the {1} button on an {2} digit in {0}?
            [Question.NotCoordinatesButtonFuncs] = new TranslationInfo
            {
                QuestionText = "What was the function of the {1} button on an {2} digit in {0}?",
            },

            // Not Keypad
            // What color flashed {1} in the final sequence in {0}?
            [Question.NotKeypadColor] = new TranslationInfo
            {
                QuestionText = "What color flashed {1} in the final sequence in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["orange"] = "orange",
                    ["yellow"] = "yellow",
                    ["green"] = "green",
                    ["cyan"] = "cyan",
                    ["blue"] = "blue",
                    ["purple"] = "purple",
                    ["magenta"] = "magenta",
                    ["pink"] = "pink",
                    ["brown"] = "brown",
                    ["grey"] = "grey",
                    ["white"] = "white",
                },
            },
            // Which symbol was on the button that flashed {1} in the final sequence in {0}?
            [Question.NotKeypadSymbol] = new TranslationInfo
            {
                QuestionText = "Which symbol was on the button that flashed {1} in the final sequence in {0}?",
            },

            // Not Maze
            // What was the starting distance in {0}?
            [Question.NotMazeStartingDistance] = new TranslationInfo
            {
                QuestionText = "What was the starting distance in {0}?",
            },

            // Not Morse Code
            // What was the {1} correct word you submitted in {0}?
            [Question.NotMorseCodeWord] = new TranslationInfo
            {
                QuestionText = "What was the {1} correct word you submitted in {0}?",
            },

            // Not Morsematics
            // What was the transmitted word on {0}?
            [Question.NotMorsematicsWord] = new TranslationInfo
            {
                QuestionText = "What was the transmitted word on {0}?",
            },

            // Not Murder
            // What room was {1} in during {2} on {0}?
            [Question.NotMurderRoom] = new TranslationInfo
            {
                QuestionText = "What room was {1} in during {2} on {0}?",
            },
            // What weapon did {1} possess during {2} on {0}?
            [Question.NotMurderWeapon] = new TranslationInfo
            {
                QuestionText = "What weapon did {1} possess during {2} on {0}?",
            },

            // Not Number Pad
            // Which of these numbers {1} at the {2} stage of {0}?
            [Question.NotNumberPadFlashes] = new TranslationInfo
            {
                QuestionText = "Which of these numbers {1} at the {2} stage of {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["flashed"] = "flashed",
                    ["did not flash"] = "did not flash",
                },
            },

            // Not Piano Keys
            // What was the first displayed symbol on {0}?
            [Question.NotPianoKeysFirstSymbol] = new TranslationInfo
            {
                QuestionText = "What was the first displayed symbol on {0}?",
            },
            // What was the second displayed symbol on {0}?
            [Question.NotPianoKeysSecondSymbol] = new TranslationInfo
            {
                QuestionText = "What was the second displayed symbol on {0}?",
            },
            // What was the third displayed symbol on {0}?
            [Question.NotPianoKeysThirdSymbol] = new TranslationInfo
            {
                QuestionText = "What was the third displayed symbol on {0}?",
            },

            // Not Simaze
            // Which maze was used in {0}?
            [Question.NotSimazeMaze] = new TranslationInfo
            {
                QuestionText = "Which maze was used in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["orange"] = "orange",
                    ["yellow"] = "yellow",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["purple"] = "purple",
                },
            },
            // What was the starting position in {0}?
            [Question.NotSimazeStart] = new TranslationInfo
            {
                QuestionText = "What was the starting position in {0}?",
            },
            // What was the goal position in {0}?
            [Question.NotSimazeGoal] = new TranslationInfo
            {
                QuestionText = "What was the goal position in {0}?",
            },

            // Not Text Field
            // Which letter was pressed in the first stage of {0}?
            [Question.NotTextFieldInitialPresses] = new TranslationInfo
            {
                QuestionText = "Which letter was pressed in the first stage of {0}?",
            },
            // Which letter appeared 9 times at the start of {0}?
            [Question.NotTextFieldBackgroundLetter] = new TranslationInfo
            {
                QuestionText = "Which letter appeared 9 times at the start of {0}?",
            },

            // Not The Bulb
            // What word flashed on {0}?
            [Question.NotTheBulbWord] = new TranslationInfo
            {
                QuestionText = "What word flashed on {0}?",
            },
            // What color was the bulb on {0}?
            [Question.NotTheBulbColor] = new TranslationInfo
            {
                QuestionText = "What color was the bulb on {0}?",
            },
            // What was the material of the screw cap on {0}?
            [Question.NotTheBulbScrewCap] = new TranslationInfo
            {
                QuestionText = "What was the material of the screw cap on {0}?",
            },

            // Not the Button
            // What colors did the light glow in {0}?
            [Question.NotTheButtonLightColor] = new TranslationInfo
            {
                QuestionText = "What colors did the light glow in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["white"] = "white",
                    ["red"] = "red",
                    ["yellow"] = "yellow",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["white/red"] = "white/red",
                    ["white/yellow"] = "white/yellow",
                    ["white/green"] = "white/green",
                    ["white/blue"] = "white/blue",
                    ["red/yellow"] = "red/yellow",
                    ["red/green"] = "red/green",
                    ["red/blue"] = "red/blue",
                    ["yellow/green"] = "yellow/green",
                    ["yellow/blue"] = "yellow/blue",
                    ["green/blue"] = "green/blue",
                },
            },

            // Not the Screw
            // What was the initial position in {0}?
            [Question.NotTheScrewInitialPosition] = new TranslationInfo
            {
                QuestionText = "What was the initial position in {0}?",
            },

            // Not Who’s on First
            // In which position was the button you pressed in the {1} stage on {0}?
            [Question.NotWhosOnFirstPressedPosition] = new TranslationInfo
            {
                QuestionText = "In which position was the button you pressed in the {1} stage on {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["top left"] = "top left",
                    ["top right"] = "top right",
                    ["middle left"] = "middle left",
                    ["middle right"] = "middle right",
                    ["bottom left"] = "bottom left",
                    ["bottom right"] = "bottom right",
                },
            },
            // What was the label on the button you pressed in the {1} stage on {0}?
            [Question.NotWhosOnFirstPressedLabel] = new TranslationInfo
            {
                QuestionText = "What was the label on the button you pressed in the {1} stage on {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["BLANK"] = "BLANK",
                    ["DONE"] = "DONE",
                    ["FIRST"] = "FIRST",
                    ["HOLD"] = "HOLD",
                    ["LEFT"] = "LEFT",
                    ["LIKE"] = "LIKE",
                    ["MIDDLE"] = "MIDDLE",
                    ["NEXT"] = "NEXT",
                    ["NO"] = "NO",
                    ["NOTHING"] = "NOTHING",
                    ["OKAY"] = "OKAY",
                    ["PRESS"] = "PRESS",
                    ["READY"] = "READY",
                    ["RIGHT"] = "RIGHT",
                    ["SURE"] = "SURE",
                    ["U"] = "U",
                    ["UH HUH"] = "UH HUH",
                    ["UH UH"] = "UH UH",
                    ["UHHH"] = "UHHH",
                    ["UR"] = "UR",
                    ["WAIT"] = "WAIT",
                    ["WHAT"] = "WHAT",
                    ["WHAT?"] = "WHAT?",
                    ["YES"] = "YES",
                    ["YOU"] = "YOU",
                    ["YOU ARE"] = "YOU ARE",
                    ["YOU'RE"] = "YOU'RE",
                    ["YOUR"] = "YOUR",
                },
            },
            // In which position was the reference button in the {1} stage on {0}?
            [Question.NotWhosOnFirstReferencePosition] = new TranslationInfo
            {
                QuestionText = "In which position was the reference button in the {1} stage on {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["top left"] = "top left",
                    ["top right"] = "top right",
                    ["middle left"] = "middle left",
                    ["middle right"] = "middle right",
                    ["bottom left"] = "bottom left",
                    ["bottom right"] = "bottom right",
                },
            },
            // What was the label on the reference button in the {1} stage on {0}?
            [Question.NotWhosOnFirstReferenceLabel] = new TranslationInfo
            {
                QuestionText = "What was the label on the reference button in the {1} stage on {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["BLANK"] = "BLANK",
                    ["DONE"] = "DONE",
                    ["FIRST"] = "FIRST",
                    ["HOLD"] = "HOLD",
                    ["LEFT"] = "LEFT",
                    ["LIKE"] = "LIKE",
                    ["MIDDLE"] = "MIDDLE",
                    ["NEXT"] = "NEXT",
                    ["NO"] = "NO",
                    ["NOTHING"] = "NOTHING",
                    ["OKAY"] = "OKAY",
                    ["PRESS"] = "PRESS",
                    ["READY"] = "READY",
                    ["RIGHT"] = "RIGHT",
                    ["SURE"] = "SURE",
                    ["U"] = "U",
                    ["UH HUH"] = "UH HUH",
                    ["UH UH"] = "UH UH",
                    ["UHHH"] = "UHHH",
                    ["UR"] = "UR",
                    ["WAIT"] = "WAIT",
                    ["WHAT"] = "WHAT",
                    ["WHAT?"] = "WHAT?",
                    ["YES"] = "YES",
                    ["YOU"] = "YOU",
                    ["YOU ARE"] = "YOU ARE",
                    ["YOU'RE"] = "YOU'RE",
                    ["YOUR"] = "YOUR",
                },
            },
            // What was the calculated number in the second stage on {0}?
            [Question.NotWhosOnFirstSum] = new TranslationInfo
            {
                QuestionText = "What was the calculated number in the second stage on {0}?",
            },

            // Not Word Search
            // Which of these consonants was missing in {0}?
            [Question.NotWordSearchMissing] = new TranslationInfo
            {
                QuestionText = "Which of these consonants was missing in {0}?",
            },
            // What was the first correctly pressed letter in {0}?
            [Question.NotWordSearchFirstPress] = new TranslationInfo
            {
                QuestionText = "What was the first correctly pressed letter in {0}?",
            },

            // Not X01
            // Which sector value {1} present on {0}?
            [Question.NotX01SectorValues] = new TranslationInfo
            {
                QuestionText = "Which sector value {1} present on {0}?",
            },

            // Not X-Ray
            // What table were we in in {0} (numbered 1–8 in reading order in the manual)?
            [Question.NotXRayTable] = new TranslationInfo
            {
                QuestionText = "What table were we in in {0} (numbered 1–8 in reading order in the manual)?",
            },
            // What direction was button {1} in {0}?
            [Question.NotXRayDirections] = new TranslationInfo
            {
                QuestionText = "What direction was button {1} in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Up"] = "Up",
                    ["Right"] = "Right",
                    ["Down"] = "Down",
                    ["Left"] = "Left",
                },
            },
            // Which button went {1} in {0}?
            [Question.NotXRayButtons] = new TranslationInfo
            {
                QuestionText = "Which button went {1} in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["up"] = "up",
                    ["right"] = "right",
                    ["down"] = "down",
                    ["left"] = "left",
                },
            },
            // What was the scanner color in {0}?
            [Question.NotXRayScannerColor] = new TranslationInfo
            {
                QuestionText = "What was the scanner color in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Yellow"] = "Yellow",
                    ["Blue"] = "Blue",
                    ["White"] = "White",
                },
            },

            // Numbered Buttons
            // Which number was correctly pressed on {0}?
            [Question.NumberedButtonsButtons] = new TranslationInfo
            {
                QuestionText = "Which number was correctly pressed on {0}?",
            },

            // Numbers
            // What two-digit number was given in {0}?
            [Question.NumbersTwoDigit] = new TranslationInfo
            {
                QuestionText = "What two-digit number was given in {0}?",
            },

            // Numpath
            // What was the color of the number on {0}?
            [Question.NumpathColor] = new TranslationInfo
            {
                QuestionText = "What was the color of the number on {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Purple"] = "Purple",
                },
            },
            // What was the number displayed on {0}?
            [Question.NumpathDigit] = new TranslationInfo
            {
                QuestionText = "What was the number displayed on {0}?",
            },

            // Object Shows
            // Which of these was a contestant on {0} but not the final winner?
            [Question.ObjectShowsContestants] = new TranslationInfo
            {
                QuestionText = "Which of these was a contestant on {0} but not the final winner?",
            },

            // The Octadecayotton
            // What was the starting sphere in {0}?
            [Question.OctadecayottonSphere] = new TranslationInfo
            {
                QuestionText = "What was the starting sphere in {0}?",
            },
            // What was one of the subrotations in the {1} rotation in {0}?
            [Question.OctadecayottonRotations] = new TranslationInfo
            {
                QuestionText = "What was one of the subrotations in the {1} rotation in {0}?",
            },

            // Odd One Out
            // What was the button you pressed in the {1} stage of {0}?
            [Question.OddOneOutButton] = new TranslationInfo
            {
                QuestionText = "What was the button you pressed in the {1} stage of {0}?",
            },

            // Only Connect
            // Which Egyptian hieroglyph was in the {1} in {0}?
            [Question.OnlyConnectHieroglyphs] = new TranslationInfo
            {
                QuestionText = "Which Egyptian hieroglyph was in the {1} in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["top left"] = "top left",
                    ["top middle"] = "top middle",
                    ["top right"] = "top right",
                    ["bottom left"] = "bottom left",
                    ["bottom middle"] = "bottom middle",
                    ["bottom right"] = "bottom right",
                },
            },

            // Orange Arrows
            // What was the {1} arrow on the display of the {2} stage of {0}?
            [Question.OrangeArrowsSequences] = new TranslationInfo
            {
                QuestionText = "What was the {1} arrow on the display of the {2} stage of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Up"] = "Up",
                    ["Right"] = "Right",
                    ["Down"] = "Down",
                    ["Left"] = "Left",
                },
            },

            // Orange Cipher
            // What was the answer in {0}?
            [Question.OrangeCipherAnswer] = new TranslationInfo
            {
                QuestionText = "What was the answer in {0}?",
            },

            // Ordered Keys
            // What color was the {2} key in the {1} stage of {0}?
            [Question.OrderedKeysColors] = new TranslationInfo
            {
                QuestionText = "What color was the {2} key in the {1} stage of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Blue"] = "Blue",
                    ["Green"] = "Green",
                    ["Yellow"] = "Yellow",
                    ["Cyan"] = "Cyan",
                    ["Magenta"] = "Magenta",
                },
            },
            // What was the label on the {2} key in the {1} stage of {0}?
            [Question.OrderedKeysLabels] = new TranslationInfo
            {
                QuestionText = "What was the label on the {2} key in the {1} stage of {0}?",
            },
            // What color was the label of the {2} key in the {1} stage of {0}?
            [Question.OrderedKeysLabelColors] = new TranslationInfo
            {
                QuestionText = "What color was the label of the {2} key in the {1} stage of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Blue"] = "Blue",
                    ["Green"] = "Green",
                    ["Yellow"] = "Yellow",
                    ["Cyan"] = "Cyan",
                    ["Magenta"] = "Magenta",
                },
            },

            // Order Picking
            // What was the order ID in the {1} order of {0}?
            [Question.OrderPickingOrder] = new TranslationInfo
            {
                QuestionText = "What was the order ID in the {1} order of {0}?",
            },
            // What was the product ID in the {1} order of {0}?
            [Question.OrderPickingProduct] = new TranslationInfo
            {
                QuestionText = "What was the product ID in the {1} order of {0}?",
            },
            // What was the pallet in the {1} order of {0}?
            [Question.OrderPickingPallet] = new TranslationInfo
            {
                QuestionText = "What was the pallet in the {1} order of {0}?",
            },

            // Orientation Cube
            // What was the observer’s intial position in {0}?
            [Question.OrientationCubeInitialObserverPosition] = new TranslationInfo
            {
                QuestionText = "What was the observer’s intial position in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["front"] = "front",
                    ["left"] = "left",
                    ["back"] = "back",
                    ["right"] = "right",
                },
            },

            // Palindromes
            // What was {1}’s {2} digit from the right in {0}?
            [Question.PalindromesNumbers] = new TranslationInfo
            {
                QuestionText = "What was {1}’s {2} digit from the right in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["X"] = "X",
                    ["Y"] = "Y",
                    ["the screen"] = "the screen",
                },
            },

            // Partial Derivatives
            // What was the LED color in the {1} stage of {0}?
            [Question.PartialDerivativesLedColors] = new TranslationInfo
            {
                QuestionText = "What was the LED color in the {1} stage of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["blue"] = "blue",
                    ["green"] = "green",
                    ["orange"] = "orange",
                    ["purple"] = "purple",
                    ["red"] = "red",
                    ["yellow"] = "yellow",
                },
            },
            // What was the {1} term in {0}?
            [Question.PartialDerivativesTerms] = new TranslationInfo
            {
                QuestionText = "What was the {1} term in {0}?",
            },

            // Passport Control
            // What was the passport expiration year of the {1} inspected passenger in {0}?
            [Question.PassportControlPassenger] = new TranslationInfo
            {
                QuestionText = "What was the passport expiration year of the {1} inspected passenger in {0}?",
            },

            // Password Destroyer
            // What was the raw value when you solved {0}?
            [Question.PasswordDestroyerRawValue] = new TranslationInfo
            {
                QuestionText = "What was the raw value when you solved {0}?",
            },
            // What was the increase factor when you solved {0}?
            [Question.PasswordDestroyerIncreaseFactor] = new TranslationInfo
            {
                QuestionText = "What was the increase factor when you solved {0}?",
            },
            // What was the TFA₁ value when you solved {0}?
            [Question.PasswordDestroyerTF1] = new TranslationInfo
            {
                QuestionText = "What was the TFA₁ value when you solved {0}?",
            },
            // What was the TFA₂ value when you solved {0}?
            [Question.PasswordDestroyerTF2] = new TranslationInfo
            {
                QuestionText = "What was the TFA₂ value when you solved {0}?",
            },
            // What was the 2FAST™ value when you solved {0}?
            [Question.PasswordDestroyerTwoFactorV2] = new TranslationInfo
            {
                QuestionText = "What was the 2FAST™ value when you solved {0}?",
            },
            // What was the percentage of solved modules used in the final calculation when you solved {0}?
            [Question.PasswordDestroyerSolvePercentage] = new TranslationInfo
            {
                QuestionText = "What was the percentage of solved modules used in the final calculation when you solved {0}?",
            },

            // Pattern Cube
            // Which symbol was highlighted in {0}?
            [Question.PatternCubeHighlightedSymbol] = new TranslationInfo
            {
                QuestionText = "Which symbol was highlighted in {0}?",
            },

            // Perspective Pegs
            // What was the {1} color in the initial sequence in {0}?
            [Question.PerspectivePegsColorSequence] = new TranslationInfo
            {
                QuestionText = "What was the {1} color in the initial sequence in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["yellow"] = "yellow",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["purple"] = "purple",
                },
            },

            // Phosphorescence
            // What was the offset in {0}?
            [Question.PhosphorescenceOffset] = new TranslationInfo
            {
                QuestionText = "What was the offset in {0}?",
            },
            // What was the {1} button press in {0}?
            [Question.PhosphorescenceButtonPresses] = new TranslationInfo
            {
                QuestionText = "What was the {1} button press in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Azure"] = "Azure",
                    ["Blue"] = "Blue",
                    ["Crimson"] = "Crimson",
                    ["Diamond"] = "Diamond",
                    ["Emerald"] = "Emerald",
                    ["Fuchsia"] = "Fuchsia",
                    ["Green"] = "Green",
                    ["Ice"] = "Ice",
                    ["Jade"] = "Jade",
                    ["Kiwi"] = "Kiwi",
                    ["Lime"] = "Lime",
                    ["Magenta"] = "Magenta",
                    ["Navy"] = "Navy",
                    ["Orange"] = "Orange",
                    ["Purple"] = "Purple",
                    ["Quartz"] = "Quartz",
                    ["Red"] = "Red",
                    ["Salmon"] = "Salmon",
                    ["Tan"] = "Tan",
                    ["Ube"] = "Ube",
                    ["Vibe"] = "Vibe",
                    ["White"] = "White",
                    ["Xotic"] = "Xotic",
                    ["Yellow"] = "Yellow",
                    ["Zen"] = "Zen",
                },
            },

            // Pie
            // What was the {1} digit of the displayed number in {0}?
            [Question.PieDigits] = new TranslationInfo
            {
                QuestionText = "What was the {1} digit of the displayed number in {0}?",
            },

            // Pigpen Cycle
            // What was the {1} in {0}?
            [Question.PigpenCycleWord] = new TranslationInfo
            {
                QuestionText = "What was the {1} in {0}?",
            },

            // The Pink Button
            // What was the {1} word in {0}?
            [Question.PinkButtonWords] = new TranslationInfo
            {
                QuestionText = "What was the {1} word in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["BLK"] = "BLK",
                    ["RED"] = "RED",
                    ["GRN"] = "GRN",
                    ["YLW"] = "YLW",
                    ["BLU"] = "BLU",
                    ["MGT"] = "MGT",
                    ["CYN"] = "CYN",
                    ["WHT"] = "WHT",
                },
            },
            // What was the {1} color in {0}?
            [Question.PinkButtonColors] = new TranslationInfo
            {
                QuestionText = "What was the {1} color in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["black"] = "black",
                    ["red"] = "red",
                    ["green"] = "green",
                    ["yellow"] = "yellow",
                    ["blue"] = "blue",
                    ["magenta"] = "magenta",
                    ["cyan"] = "cyan",
                    ["white"] = "white",
                },
            },

            // Pixel Cipher
            // What was the keyword in {0}?
            [Question.PixelCipherKeyword] = new TranslationInfo
            {
                QuestionText = "What was the keyword in {0}?",
            },

            // Placeholder Talk
            // What was the first half of the first phrase in {0}?
            [Question.PlaceholderTalkFirstPhrase] = new TranslationInfo
            {
                QuestionText = "What was the first half of the first phrase in {0}?",
            },
            // What was the last half of the first phrase in {0}?
            [Question.PlaceholderTalkOrdinal] = new TranslationInfo
            {
                QuestionText = "What was the last half of the first phrase in {0}?",
            },
            // What was the second phrase’s calculated value in {0}?
            [Question.PlaceholderTalkSecondPhrase] = new TranslationInfo
            {
                QuestionText = "What was the second phrase’s calculated value in {0}?",
            },

            // Placement Roulette
            // What was the character listed on the information display in {0}?
            [Question.PlacementRouletteChar] = new TranslationInfo
            {
                QuestionText = "What was the character listed on the information display in {0}?",
            },
            // What was the drift type listed on the information display in {0}?
            [Question.PlacementRouletteDrift] = new TranslationInfo
            {
                QuestionText = "What was the drift type listed on the information display in {0}?",
            },
            // What was the track listed on the information display in {0}?
            [Question.PlacementRouletteTrack] = new TranslationInfo
            {
                QuestionText = "What was the track listed on the information display in {0}?",
            },
            // What was the track type of the track listed on the information display in {0}?
            [Question.PlacementRouletteTrackType] = new TranslationInfo
            {
                QuestionText = "What was the track type of the track listed on the information display in {0}?",
            },
            // What was the vehicle listed on the information display in {0}?
            [Question.PlacementRouletteVehicle] = new TranslationInfo
            {
                QuestionText = "What was the vehicle listed on the information display in {0}?",
            },
            // What was the vehicle type of the vehicle listed on the information display in {0}?
            [Question.PlacementRouletteVehicleType] = new TranslationInfo
            {
                QuestionText = "What was the vehicle type of the vehicle listed on the information display in {0}?",
            },

            // Planets
            // What was the planet shown in {0}?
            [Question.PlanetsPlanet] = new TranslationInfo
            {
                QuestionText = "What was the planet shown in {0}?",
            },
            // What was the color of the {1} strip (from the top) in {0}?
            [Question.PlanetsStrips] = new TranslationInfo
            {
                QuestionText = "What was the color of the {1} strip (from the top) in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Aqua"] = "Aqua",
                    ["Blue"] = "Blue",
                    ["Green"] = "Green",
                    ["Lime"] = "Lime",
                    ["Orange"] = "Orange",
                    ["Red"] = "Red",
                    ["Yellow"] = "Yellow",
                    ["White"] = "White",
                    ["Off"] = "Off",
                },
            },

            // Playfair Cycle
            // What was the {1} in {0}?
            [Question.PlayfairCycleWord] = new TranslationInfo
            {
                QuestionText = "What was the {1} in {0}?",
            },

            // Poetry
            // What was the {1} correct answer you pressed in {0}?
            [Question.PoetryAnswers] = new TranslationInfo
            {
                QuestionText = "What was the {1} correct answer you pressed in {0}?",
            },

            // Polyhedral Maze
            // What was the starting position in {0}?
            [Question.PolyhedralMazeStartPosition] = new TranslationInfo
            {
                QuestionText = "What was the starting position in {0}?",
            },

            // Prime Encryption
            // What was the number shown in {0}?
            [Question.PrimeEncryptionDisplayedValue] = new TranslationInfo
            {
                QuestionText = "What was the number shown in {0}?",
            },

            // Probing
            // What was the missing frequency in the {1} wire in {0}?
            [Question.ProbingFrequencies] = new TranslationInfo
            {
                QuestionText = "What was the missing frequency in the {1} wire in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red-white"] = "red-white",
                    ["yellow-black"] = "yellow-black",
                    ["green"] = "green",
                    ["gray"] = "gray",
                    ["yellow-red"] = "yellow-red",
                    ["red-blue"] = "red-blue",
                },
            },

            // Purple Arrows
            // What was the target word on {0}?
            [Question.PurpleArrowsFinish] = new TranslationInfo
            {
                QuestionText = "What was the target word on {0}?",
            },

            // The Purple Button
            // What was the {1} number in the cyclic sequence on {0}?
            [Question.PurpleButtonNumbers] = new TranslationInfo
            {
                QuestionText = "What was the {1} number in the cyclic sequence on {0}?",
            },

            // Puzzle Identification
            // What was the {1} puzzle number in {0}?
            [Question.PuzzleIdentificationNum] = new TranslationInfo
            {
                QuestionText = "What was the {1} puzzle number in {0}?",
            },
            // What game was the {1} puzzle in {0} from?
            [Question.PuzzleIdentificationGame] = new TranslationInfo
            {
                QuestionText = "What game was the {1} puzzle in {0} from?",
            },
            // What was the {1} puzzle in {0}?
            [Question.PuzzleIdentificationName] = new TranslationInfo
            {
                QuestionText = "What was the {1} puzzle in {0}?",
            },

            // Quaver
            // What was the {1} sequence’s answer in {0}?
            [Question.QuaverArrows] = new TranslationInfo
            {
                QuestionText = "What was the {1} sequence’s answer in {0}?",
            },

            // Quintuples
            // What was the {1} digit in the {2} slot in {0}?
            [Question.QuintuplesNumbers] = new TranslationInfo
            {
                QuestionText = "What was the {1} digit in the {2} slot in {0}?",
            },
            // What color was the {1} digit in the {2} slot in {0}?
            [Question.QuintuplesColors] = new TranslationInfo
            {
                QuestionText = "What color was the {1} digit in the {2} slot in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["blue"] = "blue",
                    ["orange"] = "orange",
                    ["green"] = "green",
                    ["pink"] = "pink",
                },
            },
            // How many numbers were {1} in {0}?
            [Question.QuintuplesColorCounts] = new TranslationInfo
            {
                QuestionText = "How many numbers were {1} in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["blue"] = "blue",
                    ["orange"] = "orange",
                    ["green"] = "green",
                    ["pink"] = "pink",
                },
            },

            // Railway Cargo Loading
            // What was the {1} coupled car in {0}?
            [Question.RailwayCargoLoadingCars] = new TranslationInfo
            {
                QuestionText = "What was the {1} coupled car in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["second"] = "second",
                    ["third"] = "third",
                    ["4th"] = "4th",
                    ["5th"] = "5th",
                    ["6th"] = "6th",
                    ["7th"] = "7th",
                    ["8th"] = "8th",
                    ["9th"] = "9th",
                    ["10th"] = "10th",
                    ["11th"] = "11th",
                    ["12th"] = "12th",
                    ["13th"] = "13th",
                    ["14th"] = "14th",
                },
            },
            // Which freight table rule {1} in {0}?
            [Question.RailwayCargoLoadingFreightTableRules] = new TranslationInfo
            {
                QuestionText = "Which freight table rule {1} in {0}?",
            },

            // Rainbow Arrows
            // What was the displayed number in {0}?
            [Question.RainbowArrowsNumber] = new TranslationInfo
            {
                QuestionText = "What was the displayed number in {0}?",
            },

            // Recolored Switches
            // What was the color of the {1} LED in {0}?
            [Question.RecoloredSwitchesLedColors] = new TranslationInfo
            {
                QuestionText = "What was the color of the {1} LED in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["cyan"] = "cyan",
                    ["orange"] = "orange",
                    ["purple"] = "purple",
                    ["white"] = "white",
                },
            },

            // Red Arrows
            // What was the starting number in {0}?
            [Question.RedArrowsStartNumber] = new TranslationInfo
            {
                QuestionText = "What was the starting number in {0}?",
            },

            // Red Cipher
            // What was the answer in {0}?
            [Question.RedCipherAnswer] = new TranslationInfo
            {
                QuestionText = "What was the answer in {0}?",
            },

            // Red Herring
            // What was the first color flashed by {0}?
            [Question.RedHerringFirstFlash] = new TranslationInfo
            {
                QuestionText = "What was the first color flashed by {0}?",
            },

            // Reformed Role Reversal
            // Which condition was the solving condition in {0}?
            [Question.ReformedRoleReversalCondition] = new TranslationInfo
            {
                QuestionText = "Which condition was the solving condition in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["second"] = "second",
                    ["third"] = "third",
                    ["4th"] = "4th",
                    ["5th"] = "5th",
                    ["6th"] = "6th",
                    ["7th"] = "7th",
                    ["8th"] = "8th",
                },
            },
            // What color was the {1} wire in {0}?
            [Question.ReformedRoleReversalWire] = new TranslationInfo
            {
                QuestionText = "What color was the {1} wire in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Navy"] = "Navy",
                    ["Lapis"] = "Lapis",
                    ["Blue"] = "Blue",
                    ["Sky"] = "Sky",
                    ["Teal"] = "Teal",
                    ["Plum"] = "Plum",
                    ["Violet"] = "Violet",
                    ["Purple"] = "Purple",
                    ["Magenta"] = "Magenta",
                    ["Lavender"] = "Lavender",
                },
            },

            // Regular Crazy Talk
            // What was the displayed digit that corresponded to the solution phrase in {0}?
            [Question.RegularCrazyTalkDigit] = new TranslationInfo
            {
                QuestionText = "What was the displayed digit that corresponded to the solution phrase in {0}?",
            },
            // What was the embellishment of the solution phrase in {0}?
            [Question.RegularCrazyTalkModifier] = new TranslationInfo
            {
                QuestionText = "What was the embellishment of the solution phrase in {0}?",
            },

            // Retirement
            // Which one of these houses was on offer, but not chosen by Bob in {0}?
            [Question.RetirementHouses] = new TranslationInfo
            {
                QuestionText = "Which one of these houses was on offer, but not chosen by Bob in {0}?",
            },

            // Reverse Morse
            // What was the {1} character in the {2} message of {0}?
            [Question.ReverseMorseCharacters] = new TranslationInfo
            {
                QuestionText = "What was the {1} character in the {2} message of {0}?",
            },

            // Reverse Polish Notation
            // What character was used in the {1} round of {0}?
            [Question.ReversePolishNotationCharacter] = new TranslationInfo
            {
                QuestionText = "What character was used in the {1} round of {0}?",
            },

            // RGB Maze
            // What was the exit coordinate in {0}?
            [Question.RGBMazeExit] = new TranslationInfo
            {
                QuestionText = "What was the exit coordinate in {0}?",
            },
            // Where was the {1} key in {0}?
            [Question.RGBMazeKeys] = new TranslationInfo
            {
                QuestionText = "Where was the {1} key in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                },
            },
            // Which maze number was the {1} maze in {0}?
            [Question.RGBMazeNumber] = new TranslationInfo
            {
                QuestionText = "Which maze number was the {1} maze in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                },
            },

            // Rhythms
            // What was the color in {0}?
            [Question.RhythmsColor] = new TranslationInfo
            {
                QuestionText = "What was the color in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Blue"] = "Blue",
                    ["Red"] = "Red",
                    ["Green"] = "Green",
                    ["Yellow"] = "Yellow",
                },
            },

            // The Rule
            // What was the rule number in {0}?
            [Question.RuleNumber] = new TranslationInfo
            {
                QuestionText = "What was the rule number in {0}?",
            },

            // Roger
            // What four-digit number was given in {0}?
            [Question.RogerSeed] = new TranslationInfo
            {
                QuestionText = "What four-digit number was given in {0}?",
            },

            // Role Reversal
            // What was the number to the correct condition in {0}?
            [Question.RoleReversalNumber] = new TranslationInfo
            {
                QuestionText = "What was the number to the correct condition in {0}?",
            },
            // How many {1} wires were there in {0}?
            [Question.RoleReversalWires] = new TranslationInfo
            {
                QuestionText = "How many {1} wires were there in {0}?",
            },

            // Rule of Three
            // What was the {1} coordinate of the {2} vertex in {0}?
            [Question.RuleOfThreeCoordinates] = new TranslationInfo
            {
                QuestionText = "What was the {1} coordinate of the {2} vertex in {0}?",
            },
            // What was the position of the {1} sphere on the {2} axis in the {3} cycle in {0}?
            [Question.RuleOfThreeCycles] = new TranslationInfo
            {
                QuestionText = "What was the position of the {1} sphere on the {2} axis in the {3} cycle in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["yellow"] = "yellow",
                    ["Z"] = "Z",
                },
            },

            // The Samsung
            // Where was {1} in {0}?
            [Question.SamsungAppPositions] = new TranslationInfo
            {
                QuestionText = "Where was {1} in {0}?",
            },

            // Scavenger Hunt
            // Which tile was correctly submitted in the first stage of {0}?
            [Question.ScavengerHuntKeySquare] = new TranslationInfo
            {
                QuestionText = "Which tile was correctly submitted in the first stage of {0}?",
            },
            // Which of these tiles was {1} in the first stage of {0}?
            [Question.ScavengerHuntColoredTiles] = new TranslationInfo
            {
                QuestionText = "Which of these tiles was {1} in the first stage of {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                },
            },

            // Schlag den Bomb
            // What was the contestant’s name in {0}?
            [Question.SchlagDenBombContestantName] = new TranslationInfo
            {
                QuestionText = "What was the contestant’s name in {0}?",
            },
            // What was the contestant’s score in {0}?
            [Question.SchlagDenBombContestantScore] = new TranslationInfo
            {
                QuestionText = "What was the contestant’s score in {0}?",
            },
            // What was the bomb’s score in {0}?
            [Question.SchlagDenBombBombScore] = new TranslationInfo
            {
                QuestionText = "What was the bomb’s score in {0}?",
            },

            // Sea Shells
            // What were the first and second words in the {1} phrase in {0}?
            [Question.SeaShells1] = new TranslationInfo
            {
                QuestionText = "What were the first and second words in the {1} phrase in {0}?",
            },
            // What were the third and fourth words in the {1} phrase in {0}?
            [Question.SeaShells2] = new TranslationInfo
            {
                QuestionText = "What were the third and fourth words in the {1} phrase in {0}?",
            },
            // What was the end of the {1} phrase in {0}?
            [Question.SeaShells3] = new TranslationInfo
            {
                QuestionText = "What was the end of the {1} phrase in {0}?",
            },

            // Semamorse
            // What was the {1} letter involved in the starting value in {0}?
            [Question.SemamorseLetters] = new TranslationInfo
            {
                QuestionText = "What was the {1} letter involved in the starting value in {0}?",
            },
            // What was the color of the display involved in the starting value in {0}?
            [Question.SemamorseColor] = new TranslationInfo
            {
                QuestionText = "What was the color of the display involved in the starting value in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["cyan"] = "cyan",
                    ["indigo"] = "indigo",
                    ["pink"] = "pink",
                },
            },

            // The Sequencyclopedia
            // What sequence was used in {0}?
            [Question.SequencyclopediaSequence] = new TranslationInfo
            {
                QuestionText = "What sequence was used in {0}?",
            },

            // Shapes And Bombs
            // What was the initial letter in {0}?
            [Question.ShapesAndBombsInitialLetter] = new TranslationInfo
            {
                QuestionText = "What was the initial letter in {0}?",
            },

            // Shape Shift
            // What was the initial shape in {0}?
            [Question.ShapeShiftInitialShape] = new TranslationInfo
            {
                QuestionText = "What was the initial shape in {0}?",
            },

            // Shell Game
            // What was the final position of the initial cup in {0}?
            [Question.ShellGameInitialCupFinalPosition] = new TranslationInfo
            {
                QuestionText = "What was the final position of the initial cup in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Left"] = "Left",
                    ["Middle"] = "Middle",
                    ["Right"] = "Right",
                },
            },

            // Shifted Maze
            // What color was the {1} marker in {0}?
            [Question.ShiftedMazeColors] = new TranslationInfo
            {
                QuestionText = "What color was the {1} marker in {0}?",
            },

            // Shifting Maze
            // What was the seed in {0}?
            [Question.ShiftingMazeSeed] = new TranslationInfo
            {
                QuestionText = "What was the seed in {0}?",
            },

            // Shogi Identification
            // What was the displayed piece in {0}?
            [Question.ShogiIdentificationPiece] = new TranslationInfo
            {
                QuestionText = "What was the displayed piece in {0}?",
            },

            // Silly Slots
            // What was the {1} slot in the {2} stage in {0}?
            [Question.SillySlots] = new TranslationInfo
            {
                QuestionText = "What was the {1} slot in the {2} stage in {0}?",
            },

            // Simon Samples
            // What were the call samples {1} of {0}?
            [Question.SimonSamplesSamples] = new TranslationInfo
            {
                QuestionText = "What were the call samples {1} of {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["played in the first stage"] = "played in the first stage",
                    ["added in the second stage"] = "added in the second stage",
                    ["added in the third stage"] = "added in the third stage",
                },
            },

            // Simon Says
            // What color flashed {1} in the final sequence in {0}?
            [Question.SimonSaysFlash] = new TranslationInfo
            {
                QuestionText = "What color flashed {1} in the final sequence in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["yellow"] = "yellow",
                    ["green"] = "green",
                    ["blue"] = "blue",
                },
            },

            // Simon Scrambles
            // What color flashed {1} in {0}?
            [Question.SimonScramblesColors] = new TranslationInfo
            {
                QuestionText = "What color flashed {1} in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Yellow"] = "Yellow",
                },
            },

            // Simon Screams
            // Which color flashed {1} in the final sequence in {0}?
            [Question.SimonScreamsFlashing] = new TranslationInfo
            {
                QuestionText = "Which color flashed {1} in the final sequence in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Purple"] = "Purple",
                },
            },
            // In which stage(s) of {0} was “{1}” the applicable rule?
            [Question.SimonScreamsRule] = new TranslationInfo
            {
                QuestionText = "In which stage(s) of {0} was “{1}” the applicable rule?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["three adjacent colors flashing in clockwise order"] = "three adjacent colors flashing in clockwise order",
                    ["a color flashing, then an adjacent color, then the first again"] = "a color flashing, then an adjacent color, then the first again",
                    ["at most one color flashing out of red, yellow, and blue"] = "at most one color flashing out of red, yellow, and blue",
                    ["two colors opposite each other that didn’t flash"] = "two colors opposite each other that didn’t flash",
                    ["two (but not three) adjacent colors flashing in clockwise order"] = "two (but not three) adjacent colors flashing in clockwise order",
                },
            },

            // Simon Selects
            // Which color flashed {1} in the {2} stage of {0}?
            [Question.SimonSelectsOrder] = new TranslationInfo
            {
                QuestionText = "Which color flashed {1} in the {2} stage of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Purple"] = "Purple",
                    ["Magenta"] = "Magenta",
                    ["Cyan"] = "Cyan",
                },
            },

            // Simon Sends
            // What was the {1} received letter in {0}?
            [Question.SimonSendsReceivedLetters] = new TranslationInfo
            {
                QuestionText = "What was the {1} received letter in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                },
            },

            // Simon Simons
            // What was the {1} flash in the final sequence in {0}?
            [Question.SimonSimonsFlashingColors] = new TranslationInfo
            {
                QuestionText = "What was the {1} flash in the final sequence in {0}?",
            },

            // Simon Sings
            // Which key’s color flashed {1} in the {2} stage of {0}?
            [Question.SimonSingsFlashing] = new TranslationInfo
            {
                QuestionText = "Which key’s color flashed {1} in the {2} stage of {0}?",
            },

            // Simon Shouts
            // Which letter flashed on the {1} button in {0}?
            [Question.SimonShoutsFlashingLetter] = new TranslationInfo
            {
                QuestionText = "Which letter flashed on the {1} button in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["top"] = "top",
                    ["left"] = "left",
                    ["right"] = "right",
                    ["bottom"] = "bottom",
                },
            },

            // Simon Shrieks
            // How many spaces clockwise from the arrow was the {1} flash in the final sequence in {0}?
            [Question.SimonShrieksFlashingButton] = new TranslationInfo
            {
                QuestionText = "How many spaces clockwise from the arrow was the {1} flash in the final sequence in {0}?",
            },

            // Simon Sounds
            // Which sample button sounded {1} in the final sequence in {0}?
            [Question.SimonSoundsFlashingColors] = new TranslationInfo
            {
                QuestionText = "Which sample button sounded {1} in the final sequence in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["blue"] = "blue",
                    ["yellow"] = "yellow",
                    ["green"] = "green",
                },
            },

            // Simon Speaks
            // Which bubble flashed first in {0}?
            [Question.SimonSpeaksPositions] = new TranslationInfo
            {
                QuestionText = "Which bubble flashed first in {0}?",
            },
            // Which bubble flashed second in {0}?
            [Question.SimonSpeaksShapes] = new TranslationInfo
            {
                QuestionText = "Which bubble flashed second in {0}?",
            },
            // Which language was the bubble that flashed third in {0} in?
            [Question.SimonSpeaksLanguages] = new TranslationInfo
            {
                QuestionText = "Which language was the bubble that flashed third in {0} in?",
            },
            // Which word was in the bubble that flashed fourth in {0}?
            [Question.SimonSpeaksWords] = new TranslationInfo
            {
                QuestionText = "Which word was in the bubble that flashed fourth in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["black"] = "black",
                    ["sort"] = "sort",
                    ["zwart"] = "zwart",
                    ["nigra"] = "nigra",
                    ["musta"] = "musta",
                    ["noir"] = "noir",
                    ["schwarz"] = "schwarz",
                    ["fekete"] = "fekete",
                    ["nero"] = "nero",
                    ["blue"] = "blue",
                    ["blå"] = "blå",
                    ["blauw"] = "blauw",
                    ["blua"] = "blua",
                    ["sininen"] = "sininen",
                    ["bleu"] = "bleu",
                    ["blau"] = "blau",
                    ["kék"] = "kék",
                    ["blu"] = "blu",
                    ["green"] = "green",
                    ["grøn"] = "grøn",
                    ["groen"] = "groen",
                    ["verda"] = "verda",
                    ["vihreä"] = "vihreä",
                    ["vert"] = "vert",
                    ["grün"] = "grün",
                    ["zöld"] = "zöld",
                    ["verde"] = "verde",
                    ["cyan"] = "cyan",
                    ["turkis"] = "turkis",
                    ["turkoois"] = "turkoois",
                    ["turkisa"] = "turkisa",
                    ["turkoosi"] = "turkoosi",
                    ["turquoise"] = "turquoise",
                    ["türkis"] = "türkis",
                    ["türkiz"] = "türkiz",
                    ["turchese"] = "turchese",
                    ["red"] = "red",
                    ["rød"] = "rød",
                    ["rood"] = "rood",
                    ["ruĝa"] = "ruĝa",
                    ["punainen"] = "punainen",
                    ["rouge"] = "rouge",
                    ["rot"] = "rot",
                    ["piros"] = "piros",
                    ["rosso"] = "rosso",
                    ["purple"] = "purple",
                    ["lilla"] = "lilla",
                    ["purper"] = "purper",
                    ["purpura"] = "purpura",
                    ["purppura"] = "purppura",
                    ["pourpre"] = "pourpre",
                    ["lila"] = "lila",
                    ["bíbor"] = "bíbor",
                    ["porpora"] = "porpora",
                    ["yellow"] = "yellow",
                    ["gul"] = "gul",
                    ["geel"] = "geel",
                    ["flava"] = "flava",
                    ["keltainen"] = "keltainen",
                    ["jaune"] = "jaune",
                    ["gelb"] = "gelb",
                    ["sárga"] = "sárga",
                    ["giallo"] = "giallo",
                    ["white"] = "white",
                    ["hvid"] = "hvid",
                    ["wit"] = "wit",
                    ["blanka"] = "blanka",
                    ["valkoinen"] = "valkoinen",
                    ["blanc"] = "blanc",
                    ["weiß"] = "weiß",
                    ["fehér"] = "fehér",
                    ["bianco"] = "bianco",
                    ["gray"] = "gray",
                    ["grå"] = "grå",
                    ["grijs"] = "grijs",
                    ["griza"] = "griza",
                    ["harmaa"] = "harmaa",
                    ["gris"] = "gris",
                    ["grau"] = "grau",
                    ["szürke"] = "szürke",
                    ["grigio"] = "grigio",
                },
            },
            // What color was the bubble that flashed fifth in {0}?
            [Question.SimonSpeaksColors] = new TranslationInfo
            {
                QuestionText = "What color was the bubble that flashed fifth in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["black"] = "black",
                    ["blue"] = "blue",
                    ["green"] = "green",
                    ["cyan"] = "cyan",
                    ["red"] = "red",
                    ["purple"] = "purple",
                    ["yellow"] = "yellow",
                    ["white"] = "white",
                    ["gray"] = "gray",
                },
            },

            // Simon’s Star
            // Which color flashed {1} in sequence in {0}?
            [Question.SimonsStarColors] = new TranslationInfo
            {
                QuestionText = "Which color flashed {1} in sequence in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["yellow"] = "yellow",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["purple"] = "purple",
                },
            },

            // Simon Stages
            // Which color flashed {1} in the {2} stage in {0}?
            [Question.SimonStagesFlashes] = new TranslationInfo
            {
                QuestionText = "Which color flashed {1} in the {2} stage in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["blue"] = "blue",
                    ["yellow"] = "yellow",
                    ["orange"] = "orange",
                    ["magenta"] = "magenta",
                    ["green"] = "green",
                    ["pink"] = "pink",
                    ["lime"] = "lime",
                    ["cyan"] = "cyan",
                    ["white"] = "white",
                },
            },
            // What color was the indicator in the {1} stage in {0}?
            [Question.SimonStagesIndicator] = new TranslationInfo
            {
                QuestionText = "What color was the indicator in the {1} stage in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["blue"] = "blue",
                    ["yellow"] = "yellow",
                    ["orange"] = "orange",
                    ["magenta"] = "magenta",
                    ["green"] = "green",
                    ["pink"] = "pink",
                    ["lime"] = "lime",
                    ["cyan"] = "cyan",
                    ["white"] = "white",
                },
            },

            // Simon States
            // Which {1} in the {2} stage in {0}?
            [Question.SimonStatesDisplay] = new TranslationInfo
            {
                QuestionText = "Which {1} in the {2} stage in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Red, Yellow"] = "Red, Yellow",
                    ["Red, Green"] = "Red, Green",
                    ["Red, Blue"] = "Red, Blue",
                    ["Yellow, Green"] = "Yellow, Green",
                    ["Yellow, Blue"] = "Yellow, Blue",
                    ["Green, Blue"] = "Green, Blue",
                    ["all 4"] = "all 4",
                    ["none"] = "none",
                },
                FormatArgs = new Dictionary<string, string>
                {
                    ["color(s) flashed"] = "color(s) flashed",
                    ["color(s) didn’t flash"] = "color(s) didn’t flash",
                },
            },

            // Simon Stops
            // Which color flashed {1} in the output sequence in {0}?
            [Question.SimonStopsColors] = new TranslationInfo
            {
                QuestionText = "Which color flashed {1} in the output sequence in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Violet"] = "Violet",
                },
            },

            // Simon Stores
            // Which color {1} {2} in the final sequence of {0}?
            [Question.SimonStoresColors] = new TranslationInfo
            {
                QuestionText = "Which color {1} {2} in the final sequence of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Cyan"] = "Cyan",
                    ["Magenta"] = "Magenta",
                    ["Yellow"] = "Yellow",
                },
                FormatArgs = new Dictionary<string, string>
                {
                    ["flashed"] = "flashed",
                    ["was among the colors flashed"] = "was among the colors flashed",
                },
            },

            // Simon Supports
            // What was the {1} topic in {0}?
            [Question.SimonSupportsTopics] = new TranslationInfo
            {
                QuestionText = "What was the {1} topic in {0}?",
            },

            // Skewed Slots
            // What were the original numbers in {0}?
            [Question.SkewedSlotsOriginalNumbers] = new TranslationInfo
            {
                QuestionText = "What were the original numbers in {0}?",
            },

            // Skyrim
            // Which race was selectable, but not the solution, in {0}?
            [Question.SkyrimRace] = new TranslationInfo
            {
                QuestionText = "Which race was selectable, but not the solution, in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Nord"] = "Nord",
                    ["Khajiit"] = "Khajiit",
                    ["Breton"] = "Breton",
                    ["Argonian"] = "Argonian",
                    ["Dunmer"] = "Dunmer",
                    ["Altmer"] = "Altmer",
                    ["Redguard"] = "Redguard",
                    ["Orc"] = "Orc",
                    ["Imperial"] = "Imperial",
                },
            },
            // Which weapon was selectable, but not the solution, in {0}?
            [Question.SkyrimWeapon] = new TranslationInfo
            {
                QuestionText = "Which weapon was selectable, but not the solution, in {0}?",
            },
            // Which enemy was selectable, but not the solution, in {0}?
            [Question.SkyrimEnemy] = new TranslationInfo
            {
                QuestionText = "Which enemy was selectable, but not the solution, in {0}?",
            },
            // Which city was selectable, but not the solution, in {0}?
            [Question.SkyrimCity] = new TranslationInfo
            {
                QuestionText = "Which city was selectable, but not the solution, in {0}?",
            },
            // Which dragon shout was selectable, but not the solution, in {0}?
            [Question.SkyrimDragonShout] = new TranslationInfo
            {
                QuestionText = "Which dragon shout was selectable, but not the solution, in {0}?",
            },

            // Small Circle
            // How much did the sequence shift by in {0}?
            [Question.SmallCircleShift] = new TranslationInfo
            {
                QuestionText = "How much did the sequence shift by in {0}?",
            },
            // Which wedge made the different noise in the beginning of {0}?
            [Question.SmallCircleWedge] = new TranslationInfo
            {
                QuestionText = "Which wedge made the different noise in the beginning of {0}?",
            },
            // Which color was {1} in the solution to {0}?
            [Question.SmallCircleSolution] = new TranslationInfo
            {
                QuestionText = "Which color was {1} in the solution to {0}?",
            },

            // Snooker
            // How many red balls were there at the start of {0}?
            [Question.SnookerReds] = new TranslationInfo
            {
                QuestionText = "How many red balls were there at the start of {0}?",
            },

            // Sorting
            // What positions were the last swap used to solve {0}?
            [Question.SortingLastSwap] = new TranslationInfo
            {
                QuestionText = "What positions were the last swap used to solve {0}?",
            },

            // Souvenir
            // What was the first module asked about in the other Souvenir on this bomb?
            [Question.SouvenirFirstQuestion] = new TranslationInfo
            {
                QuestionText = "What was the first module asked about in the other Souvenir on this bomb?",
            },

            // Space Traders
            // What was the maximum tax amount per vessel in {0}?
            [Question.SpaceTradersMaxTax] = new TranslationInfo
            {
                QuestionText = "What was the maximum tax amount per vessel in {0}?",
            },

            // Sonic The Hedgehog
            // What was the {1} picture on {0}?
            [Question.SonicTheHedgehogPictures] = new TranslationInfo
            {
                QuestionText = "What was the {1} picture on {0}?",
            },
            // Which sound was played by the {1} screen on {0}?
            [Question.SonicTheHedgehogSounds] = new TranslationInfo
            {
                QuestionText = "Which sound was played by the {1} screen on {0}?",
            },

            // The Sphere
            // What was the {1} flashed color in {0}?
            [Question.SphereColors] = new TranslationInfo
            {
                QuestionText = "What was the {1} flashed color in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["blue"] = "blue",
                    ["green"] = "green",
                    ["orange"] = "orange",
                    ["pink"] = "pink",
                    ["purple"] = "purple",
                    ["grey"] = "grey",
                    ["white"] = "white",
                },
            },

            // Spelling Bee
            // What word was asked to be spelled in {0}?
            [Question.SpellingBeeWord] = new TranslationInfo
            {
                QuestionText = "What word was asked to be spelled in {0}?",
            },

            // Splitting The Loot
            // What bag was initially colored in {0}?
            [Question.SplittingTheLootColoredBag] = new TranslationInfo
            {
                QuestionText = "What bag was initially colored in {0}?",
            },

            // Spot the Difference
            // What was the color of the faulty sphere in {0}?
            [Question.SpotTheDifferenceFaultyBall] = new TranslationInfo
            {
                QuestionText = "What was the color of the faulty sphere in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Blue"] = "Blue",
                    ["Green"] = "Green",
                    ["Orange"] = "Orange",
                    ["Red"] = "Red",
                },
            },

            // Stacked Sequences
            // Which of these is the length of a sequence in {0}?
            [Question.StackedSequences] = new TranslationInfo
            {
                QuestionText = "Which of these is the length of a sequence in {0}?",
            },

            // Stars
            // What was the digit in the center of {0}?
            [Question.StarsCenter] = new TranslationInfo
            {
                QuestionText = "What was the digit in the center of {0}?",
            },

            // State of Aggregation
            // What was the element shown in {0}?
            [Question.StateOfAggregationElement] = new TranslationInfo
            {
                QuestionText = "What was the element shown in {0}?",
            },

            // Stellar
            // What was the {1} letter in {0}?
            [Question.StellarLetters] = new TranslationInfo
            {
                QuestionText = "What was the {1} letter in {0}?",
            },

            // Stupid Slots
            // What was the value of the {1} arrow in {0}?
            [Question.StupidSlotsValues] = new TranslationInfo
            {
                QuestionText = "What was the value of the {1} arrow in {0}?",
            },

            // Subscribe to Pewdiepie
            // How many subscribers does {1} have in {0}?
            [Question.SubscribeToPewdiepieSubCount] = new TranslationInfo
            {
                QuestionText = "How many subscribers does {1} have in {0}?",
            },

            // Sugar Skulls
            // What skull was shown on the {1} square in {0}?
            [Question.SugarSkullsSkull] = new TranslationInfo
            {
                QuestionText = "What skull was shown on the {1} square in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["top"] = "top",
                    ["bottom-left"] = "bottom-left",
                    ["bottom-right"] = "bottom-right",
                },
            },
            // Which skull {1} present in {0}?
            [Question.SugarSkullsAvailability] = new TranslationInfo
            {
                QuestionText = "Which skull {1} present in {0}?",
            },

            // Superparsing
            // What was the displayed word in {0}?
            [Question.SuperparsingDisplayed] = new TranslationInfo
            {
                QuestionText = "What was the displayed word in {0}?",
            },

            // The Switch
            // What color was the {1} LED on the {2} flip of {0}?
            [Question.SwitchInitialColor] = new TranslationInfo
            {
                QuestionText = "What color was the {1} LED on the {2} flip of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["orange"] = "orange",
                    ["yellow"] = "yellow",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["purple"] = "purple",
                },
                FormatArgs = new Dictionary<string, string>
                {
                    ["top"] = "top",
                    ["bottom"] = "bottom",
                },
            },

            // Switches
            // What was the initial position of the switches in {0}?
            [Question.SwitchesInitialPosition] = new TranslationInfo
            {
                QuestionText = "What was the initial position of the switches in {0}?",
            },

            // Switching Maze
            // What was the seed in {0}?
            [Question.SwitchingMazeSeed] = new TranslationInfo
            {
                QuestionText = "What was the seed in {0}?",
            },
            // What was the starting maze color in {0}?
            [Question.SwitchingMazeColor] = new TranslationInfo
            {
                QuestionText = "What was the starting maze color in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Blue"] = "Blue",
                    ["Cyan"] = "Cyan",
                    ["Magenta"] = "Magenta",
                    ["Orange"] = "Orange",
                    ["Red"] = "Red",
                    ["White"] = "White",
                },
            },

            // Symbol Cycle
            // How many symbols were cycling on the {1} screen in {0}?
            [Question.SymbolCycleSymbolCounts] = new TranslationInfo
            {
                QuestionText = "How many symbols were cycling on the {1} screen in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["left"] = "left",
                    ["right"] = "right",
                },
            },

            // Symbolic Coordinates
            // What was the {1} symbol in the {2} stage of {0}?
            [Question.SymbolicCoordinateSymbols] = new TranslationInfo
            {
                QuestionText = "What was the {1} symbol in the {2} stage of {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["left"] = "left",
                    ["middle"] = "middle",
                },
            },

            // Symbolic Tasha
            // Which button flashed {1} in the final sequence of {0}?
            [Question.SymbolicTashaFlashes] = new TranslationInfo
            {
                QuestionText = "Which button flashed {1} in the final sequence of {0}?",
            },
            // Which symbol was on the {1} button in {0}?
            [Question.SymbolicTashaSymbols] = new TranslationInfo
            {
                QuestionText = "Which symbol was on the {1} button in {0}?",
            },

            // SYNC-125 [3]
            // What was displayed on the screen in stage {1} of {0}?
            [Question.Sync125_3Word] = new TranslationInfo
            {
                QuestionText = "What was displayed on the screen in stage {1} of {0}?",
            },

            // Synonyms
            // Which number was displayed on {0}?
            [Question.SynonymsNumber] = new TranslationInfo
            {
                QuestionText = "Which number was displayed on {0}?",
            },

            // Sysadmin
            // What error code did you fix in {0}?
            [Question.SysadminFixedErrorCodes] = new TranslationInfo
            {
                QuestionText = "What error code did you fix in {0}?",
            },

            // Tap Code
            // What was the received word in {0}?
            [Question.TapCodeReceivedWord] = new TranslationInfo
            {
                QuestionText = "What was the received word in {0}?",
            },

            // Tasha Squeals
            // What was the {1} flashed color in {0}?
            [Question.TashaSquealsColors] = new TranslationInfo
            {
                QuestionText = "What was the {1} flashed color in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Pink"] = "Pink",
                    ["Green"] = "Green",
                    ["Yellow"] = "Yellow",
                    ["Blue"] = "Blue",
                },
            },

            // Ten-Button Color Code
            // What was the initial color of the {1} button in the {2} stage of {0}?
            [Question.TenButtonColorCodeInitialColors] = new TranslationInfo
            {
                QuestionText = "What was the initial color of the {1} button in the {2} stage of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["yellow"] = "yellow",
                },
            },

            // Tenpins
            // What was the {1} split in {0}?
            [Question.TenpinsSplits] = new TranslationInfo
            {
                QuestionText = "What was the {1} split in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                },
            },

            // Text Field
            // What was the displayed letter in {0}?
            [Question.TextFieldDisplay] = new TranslationInfo
            {
                QuestionText = "What was the displayed letter in {0}?",
            },

            // Thinking Wires
            // What was the position from top to bottom of the first wire needing to be cut in {0}?
            [Question.ThinkingWiresFirstWire] = new TranslationInfo
            {
                QuestionText = "What was the position from top to bottom of the first wire needing to be cut in {0}?",
            },
            // What color did the second valid wire to cut have to have in {0}?
            [Question.ThinkingWiresSecondWire] = new TranslationInfo
            {
                QuestionText = "What color did the second valid wire to cut have to have in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Cyan"] = "Cyan",
                    ["Magenta"] = "Magenta",
                    ["Yellow"] = "Yellow",
                    ["White"] = "White",
                    ["Black"] = "Black",
                    ["Any"] = "Any",
                },
            },
            // What was the display number in {0}?
            [Question.ThinkingWiresDisplayNumber] = new TranslationInfo
            {
                QuestionText = "What was the display number in {0}?",
            },

            // Third Base
            // What was the display word in the {1} stage on {0}?
            [Question.ThirdBaseDisplay] = new TranslationInfo
            {
                QuestionText = "What was the display word in the {1} stage on {0}?",
            },

            // Tic Tac Toe
            // What was on the {1} button at the start of {0}?
            [Question.TicTacToeInitialState] = new TranslationInfo
            {
                QuestionText = "What was on the {1} button at the start of {0}?",
            },

            // Timezone
            // What was the {1} city in {0}?
            [Question.TimezoneCities] = new TranslationInfo
            {
                QuestionText = "What was the {1} city in {0}?",
            },

            // Topsy Turvy
            // What was the word initially shown in {0}?
            [Question.TopsyTurvyWord] = new TranslationInfo
            {
                QuestionText = "What was the word initially shown in {0}?",
            },

            // Touch Transmission
            // What was the transmitted word in {0}?
            [Question.TouchTransmissionWord] = new TranslationInfo
            {
                QuestionText = "What was the transmitted word in {0}?",
            },
            // In what order was the Braille read in {0}?
            [Question.TouchTransmissionOrder] = new TranslationInfo
            {
                QuestionText = "In what order was the Braille read in {0}?",
            },

            // Trajectory
            // Which function did the {1} button perform in {0}?
            [Question.TrajectoryButtonFunctions] = new TranslationInfo
            {
                QuestionText = "Which function did the {1} button perform in {0}?",
            },

            // Transmitted Morse
            // What was the {1} received message in {0}?
            [Question.TransmittedMorseMessage] = new TranslationInfo
            {
                QuestionText = "What was the {1} received message in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["BOMBS"] = "BOMBS",
                    ["SHORT"] = "SHORT",
                    ["UNDERSTOOD"] = "UNDERSTOOD",
                    ["W1RES"] = "W1RES",
                    ["SOS"] = "SOS",
                    ["MANUAL"] = "MANUAL",
                    ["STRIKED"] = "STRIKED",
                    ["WEREDEAD"] = "WEREDEAD",
                    ["GOTASOUV"] = "GOTASOUV",
                    ["EXPLOSION"] = "EXPLOSION",
                    ["EXPERT"] = "EXPERT",
                    ["RIP"] = "RIP",
                    ["LISTEN"] = "LISTEN",
                    ["DETONATE"] = "DETONATE",
                    ["ROGER"] = "ROGER",
                    ["WELOSTBRO"] = "WELOSTBRO",
                    ["AMIDEAF"] = "AMIDEAF",
                    ["KEYPAD"] = "KEYPAD",
                    ["DEFUSER"] = "DEFUSER",
                    ["NUCLEARWEAPONS"] = "NUCLEARWEAPONS",
                    ["KAPPA"] = "KAPPA",
                    ["DELTA"] = "DELTA",
                    ["PI3"] = "PI3",
                    ["SMOKE"] = "SMOKE",
                    ["SENDHELP"] = "SENDHELP",
                    ["LOST"] = "LOST",
                    ["SWAN"] = "SWAN",
                    ["NOMNOM"] = "NOMNOM",
                    ["BLUE"] = "BLUE",
                    ["BOOM"] = "BOOM",
                    ["CANCEL"] = "CANCEL",
                    ["DEFUSED"] = "DEFUSED",
                    ["BROKEN"] = "BROKEN",
                    ["MEMORY"] = "MEMORY",
                    ["R6S8T"] = "R6S8T",
                    ["TRANSMISSION"] = "TRANSMISSION",
                    ["UMWHAT"] = "UMWHAT",
                    ["GREEN"] = "GREEN",
                    ["EQUATIONSX"] = "EQUATIONSX",
                    ["RED"] = "RED",
                    ["ENERGY"] = "ENERGY",
                    ["JESTER"] = "JESTER",
                    ["CONTACT"] = "CONTACT",
                    ["LONG"] = "LONG",
                },
            },

            // Turtle Robot
            // What was the {1} line you commented out in {0}?
            [Question.TurtleRobotCodeLines] = new TranslationInfo
            {
                QuestionText = "What was the {1} line you commented out in {0}?",
            },

            // Two Bits
            // What was the {1} correct query response from {0}?
            [Question.TwoBitsResponse] = new TranslationInfo
            {
                QuestionText = "What was the {1} correct query response from {0}?",
            },

            // Ultimate Cipher
            // What was the answer in {0}?
            [Question.UltimateCipherAnswer] = new TranslationInfo
            {
                QuestionText = "What was the answer in {0}?",
            },

            // Ultimate Cycle
            // What was the {1} in {0}?
            [Question.UltimateCycleWord] = new TranslationInfo
            {
                QuestionText = "What was the {1} in {0}?",
            },

            // The Ultracube
            // What was the {1} rotation in {0}?
            [Question.UltracubeRotations] = new TranslationInfo
            {
                QuestionText = "What was the {1} rotation in {0}?",
            },

            // UltraStores
            // What was the {1} rotation in the {2} stage of {0}?
            [Question.UltraStoresSingleRotation] = new TranslationInfo
            {
                QuestionText = "What was the {1} rotation in the {2} stage of {0}?",
            },
            // What was the {1} rotation in the {2} stage of {0}?
            [Question.UltraStoresMultiRotation] = new TranslationInfo
            {
                QuestionText = "What was the {1} rotation in the {2} stage of {0}?",
            },

            // Uncolored Squares
            // What was the {1} color in reading order used in the first stage of {0}?
            [Question.UncoloredSquaresFirstStage] = new TranslationInfo
            {
                QuestionText = "What was the {1} color in reading order used in the first stage of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["White"] = "White",
                    ["Red"] = "Red",
                    ["Blue"] = "Blue",
                    ["Green"] = "Green",
                    ["Yellow"] = "Yellow",
                    ["Magenta"] = "Magenta",
                },
            },

            // Uncolored Switches
            // What was the initial state of the switches in {0}?
            [Question.UncoloredSwitchesInitialState] = new TranslationInfo
            {
                QuestionText = "What was the initial state of the switches in {0}?",
            },
            // What color was the {1} LED in reading order in {0}?
            [Question.UncoloredSwitchesLedColors] = new TranslationInfo
            {
                QuestionText = "What color was the {1} LED in reading order in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["turquoise"] = "turquoise",
                    ["orange"] = "orange",
                    ["purple"] = "purple",
                    ["white"] = "white",
                    ["black"] = "black",
                },
            },

            // Unfair Cipher
            // What was the {1} received instruction in {0}?
            [Question.UnfairCipherInstructions] = new TranslationInfo
            {
                QuestionText = "What was the {1} received instruction in {0}?",
            },

            // Unfair’s Revenge
            // What was the {1} decrypted instruction in {0}?
            [Question.UnfairsRevengeInstructions] = new TranslationInfo
            {
                QuestionText = "What was the {1} decrypted instruction in {0}?",
            },

            // Unicode
            // What was the {1} submitted code in {0}?
            [Question.UnicodeSortedAnswer] = new TranslationInfo
            {
                QuestionText = "What was the {1} submitted code in {0}?",
            },

            // Unown Cipher
            // What was the {1} submitted letter in {0}?
            [Question.UnownCipherAnswers] = new TranslationInfo
            {
                QuestionText = "What was the {1} submitted letter in {0}?",
            },

            // USA Maze
            // Which state did you depart from in {0}?
            [Question.USAMazeOrigin] = new TranslationInfo
            {
                QuestionText = "Which state did you depart from in {0}?",
            },

            // V
            // Which word {1} shown in {0}?
            [Question.VWords] = new TranslationInfo
            {
                QuestionText = "Which word {1} shown in {0}?",
            },

            // Varicolored Squares
            // What was the initially pressed color on {0}?
            [Question.VaricoloredSquaresInitialColor] = new TranslationInfo
            {
                QuestionText = "What was the initially pressed color on {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["White"] = "White",
                    ["Red"] = "Red",
                    ["Blue"] = "Blue",
                    ["Green"] = "Green",
                    ["Yellow"] = "Yellow",
                    ["Magenta"] = "Magenta",
                },
            },

            // Vcrcs
            // What was the word in {0}?
            [Question.VcrcsWord] = new TranslationInfo
            {
                QuestionText = "What was the word in {0}?",
            },

            // Vectors
            // What was the color of the {1} vector in {0}?
            [Question.VectorsColors] = new TranslationInfo
            {
                QuestionText = "What was the color of the {1} vector in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Yellow"] = "Yellow",
                    ["Green"] = "Green",
                    ["Blue"] = "Blue",
                    ["Purple"] = "Purple",
                },
                FormatArgs = new Dictionary<string, string>
                {
                    ["first"] = "first",
                    ["second"] = "second",
                    ["third"] = "third",
                    ["only"] = "only",
                },
            },

            // Vexillology
            // What was the {1} flagpole color on {0}?
            [Question.VexillologyColors] = new TranslationInfo
            {
                QuestionText = "What was the {1} flagpole color on {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Green"] = "Green",
                    ["Yellow"] = "Yellow",
                    ["Blue"] = "Blue",
                    ["Aqua"] = "Aqua",
                    ["White"] = "White",
                    ["Black"] = "Black",
                },
            },

            // Violet Cipher
            // What was the answer in {0}?
            [Question.VioletCipherAnswer] = new TranslationInfo
            {
                QuestionText = "What was the answer in {0}?",
            },

            // Visual Impairment
            // What was the desired color in the {1} stage on {0}?
            [Question.VisualImpairmentColors] = new TranslationInfo
            {
                QuestionText = "What was the desired color in the {1} stage on {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Blue"] = "Blue",
                    ["Green"] = "Green",
                    ["Red"] = "Red",
                    ["White"] = "White",
                },
            },

            // Wavetapping
            // What was the color on the {1} stage in {0}?
            [Question.WavetappingColors] = new TranslationInfo
            {
                QuestionText = "What was the color on the {1} stage in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Red"] = "Red",
                    ["Orange"] = "Orange",
                    ["Orange-Yellow"] = "Orange-Yellow",
                    ["Chartreuse"] = "Chartreuse",
                    ["Lime"] = "Lime",
                    ["Green"] = "Green",
                    ["Seafoam Green"] = "Seafoam Green",
                    ["Cyan-Green"] = "Cyan-Green",
                    ["Turquoise"] = "Turquoise",
                    ["Dark Blue"] = "Dark Blue",
                    ["Indigo"] = "Indigo",
                    ["Purple"] = "Purple",
                    ["Purple-Magenta"] = "Purple-Magenta",
                    ["Magenta"] = "Magenta",
                    ["Pink"] = "Pink",
                    ["Gray"] = "Gray",
                },
            },
            // What was the correct pattern on the {1} stage in {0}?
            [Question.WavetappingPatterns] = new TranslationInfo
            {
                QuestionText = "What was the correct pattern on the {1} stage in {0}?",
            },

            // What’s on Second
            // What was the display text in the {1} stage of {0}?
            [Question.WhatsOnSecondDisplayText] = new TranslationInfo
            {
                QuestionText = "What was the display text in the {1} stage of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["got it"] = "got it",
                    ["says"] = "says",
                    ["display"] = "display",
                    ["leed"] = "leed",
                    ["their"] = "their",
                    ["blank"] = "blank",
                    ["right"] = "right",
                    ["reed"] = "reed",
                    ["hold"] = "hold",
                    ["they are"] = "they are",
                    ["louder"] = "louder",
                    ["lead"] = "lead",
                    ["repeat"] = "repeat",
                    ["ready"] = "ready",
                    ["none"] = "none",
                    ["led"] = "led",
                    ["ur"] = "ur",
                    ["you’re"] = "you’re",
                    ["no"] = "no",
                    ["you"] = "you",
                    ["nothing"] = "nothing",
                    ["middle"] = "middle",
                    ["done"] = "done",
                    ["empty"] = "empty",
                    ["your"] = "your",
                    ["hold on"] = "hold on",
                    ["like"] = "like",
                    ["read"] = "read",
                    ["wait"] = "wait",
                    ["left"] = "left",
                    ["press"] = "press",
                    ["what?"] = "what?",
                    ["uh uh"] = "uh uh",
                    ["they’re"] = "they’re",
                    ["uhhh"] = "uhhh",
                    ["c"] = "c",
                    ["error"] = "error",
                    ["you are"] = "you are",
                    ["next"] = "next",
                    ["yes"] = "yes",
                    ["u"] = "u",
                    ["sure"] = "sure",
                    ["okay"] = "okay",
                    ["what"] = "what",
                    ["cee"] = "cee",
                    ["first"] = "first",
                    ["see"] = "see",
                    ["uh huh"] = "uh huh",
                    ["there"] = "there",
                    ["red"] = "red",
                },
            },
            // What was the display text color in the {1} stage of {0}?
            [Question.WhatsOnSecondDisplayColor] = new TranslationInfo
            {
                QuestionText = "What was the display text color in the {1} stage of {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Blue"] = "Blue",
                    ["Cyan"] = "Cyan",
                    ["Green"] = "Green",
                    ["Magenta"] = "Magenta",
                    ["Red"] = "Red",
                    ["Yellow"] = "Yellow",
                },
            },

            // White Cipher
            // What was the answer in {0}?
            [Question.WhiteCipherAnswer] = new TranslationInfo
            {
                QuestionText = "What was the answer in {0}?",
            },

            // Who’s on First
            // What was the display in the {1} stage on {0}?
            [Question.WhosOnFirstDisplay] = new TranslationInfo
            {
                QuestionText = "What was the display in the {1} stage on {0}?",
                Answers = new Dictionary<string, string>
                {
                    [""] = "",
                    ["BLANK"] = "BLANK",
                    ["C"] = "C",
                    ["CEE"] = "CEE",
                    ["DISPLAY"] = "DISPLAY",
                    ["FIRST"] = "FIRST",
                    ["HOLD ON"] = "HOLD ON",
                    ["LEAD"] = "LEAD",
                    ["LED"] = "LED",
                    ["LEED"] = "LEED",
                    ["NO"] = "NO",
                    ["NOTHING"] = "NOTHING",
                    ["OK"] = "OK",
                    ["OKAY"] = "OKAY",
                    ["READ"] = "READ",
                    ["RED"] = "RED",
                    ["REED"] = "REED",
                    ["SAY"] = "SAY",
                    ["SAYS"] = "SAYS",
                    ["SEE"] = "SEE",
                    ["THEIR"] = "THEIR",
                    ["THERE"] = "THERE",
                    ["THEY ARE"] = "THEY ARE",
                    ["THEY’RE"] = "THEY’RE",
                    ["U"] = "U",
                    ["UR"] = "UR",
                    ["YES"] = "YES",
                    ["YOU"] = "YOU",
                    ["YOU ARE"] = "YOU ARE",
                    ["YOU’RE"] = "YOU’RE",
                    ["YOUR"] = "YOUR",
                },
            },

            // The Wire
            // What was the color of the {1} dial in {0}?
            [Question.WireDialColors] = new TranslationInfo
            {
                QuestionText = "What was the color of the {1} dial in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["blue"] = "blue",
                    ["green"] = "green",
                    ["grey"] = "grey",
                    ["orange"] = "orange",
                    ["purple"] = "purple",
                    ["red"] = "red",
                },
                FormatArgs = new Dictionary<string, string>
                {
                    ["top"] = "top",
                    ["bottom-left"] = "bottom-left",
                    ["bottom-right"] = "bottom-right",
                },
            },
            // What was the displayed number in {0}?
            [Question.WireDisplayedNumber] = new TranslationInfo
            {
                QuestionText = "What was the displayed number in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["top"] = "top",
                    ["bottom-left"] = "bottom-left",
                    ["bottom-right"] = "bottom-right",
                },
            },

            // Wire Ordering
            // What color was the {1} display from the left in {0}?
            [Question.WireOrderingDisplayColor] = new TranslationInfo
            {
                QuestionText = "What color was the {1} display from the left in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["orange"] = "orange",
                    ["yellow"] = "yellow",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["purple"] = "purple",
                    ["white"] = "white",
                    ["black"] = "black",
                },
            },
            // What number was on the {1} display from the left in {0}?
            [Question.WireOrderingDisplayNumber] = new TranslationInfo
            {
                QuestionText = "What number was on the {1} display from the left in {0}?",
            },
            // What color was the {1} wire from the left in {0}?
            [Question.WireOrderingWireColor] = new TranslationInfo
            {
                QuestionText = "What color was the {1} wire from the left in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["orange"] = "orange",
                    ["yellow"] = "yellow",
                    ["green"] = "green",
                    ["blue"] = "blue",
                    ["purple"] = "purple",
                    ["white"] = "white",
                    ["black"] = "black",
                },
            },

            // Wire Sequence
            // How many {1} wires were there in {0}?
            [Question.WireSequenceColorCount] = new TranslationInfo
            {
                QuestionText = "How many {1} wires were there in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["blue"] = "blue",
                    ["black"] = "black",
                },
            },

            // Wolf, Goat, and Cabbage
            // Which of these was {1} on {0}?
            [Question.WolfGoatAndCabbageAnimals] = new TranslationInfo
            {
                QuestionText = "Which of these was {1} on {0}?",
            },
            // What was the boat size in {0}?
            [Question.WolfGoatAndCabbageBoatSize] = new TranslationInfo
            {
                QuestionText = "What was the boat size in {0}?",
            },

            // Working Title
            // What was the label shown in {0}?
            [Question.WorkingTitleLabel] = new TranslationInfo
            {
                QuestionText = "What was the label shown in {0}?",
            },

            // XmORse Code
            // What was the {1} displayed letter (in reading order) in {0}?
            [Question.XmORseCodeDisplayedLetters] = new TranslationInfo
            {
                QuestionText = "What was the {1} displayed letter (in reading order) in {0}?",
            },
            // What word did you decrypt in {0}?
            [Question.XmORseCodeWord] = new TranslationInfo
            {
                QuestionText = "What word did you decrypt in {0}?",
            },

            // The Xenocryst
            // What was the color of the {1} flash in {0}?
            [Question.Xenocryst] = new TranslationInfo
            {
                QuestionText = "What was the color of the {1} flash in {0}?",
            },

            // Yahtzee
            // What was the initial roll on {0}?
            [Question.YahtzeeInitialRoll] = new TranslationInfo
            {
                QuestionText = "What was the initial roll on {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["Yahtzee"] = "Yahtzee",
                    ["large straight"] = "large straight",
                    ["small straight"] = "small straight",
                    ["four of a kind"] = "four of a kind",
                    ["full house"] = "full house",
                    ["three of a kind"] = "three of a kind",
                    ["two pairs"] = "two pairs",
                    ["pair"] = "pair",
                },
            },

            // Yellow Arrows
            // What was the starting row letter in {0}?
            [Question.YellowArrowsStartingRow] = new TranslationInfo
            {
                QuestionText = "What was the starting row letter in {0}?",
            },

            // The Yellow Button
            // What was the {1} color in {0}?
            [Question.YellowButtonColors] = new TranslationInfo
            {
                QuestionText = "What was the {1} color in {0}?",
            },

            // Yellow Cipher
            // What was the answer in {0}?
            [Question.YellowCipherAnswer] = new TranslationInfo
            {
                QuestionText = "What was the answer in {0}?",
            },

            // Zero, Zero
            // What color was the {1} star in {0}?
            [Question.ZeroZeroStarColors] = new TranslationInfo
            {
                QuestionText = "What color was the {1} star in {0}?",
                Answers = new Dictionary<string, string>
                {
                    ["black"] = "black",
                    ["blue"] = "blue",
                    ["green"] = "green",
                    ["cyan"] = "cyan",
                    ["red"] = "red",
                    ["magenta"] = "magenta",
                    ["yellow"] = "yellow",
                    ["white"] = "white",
                },
            },
            // How many points were on the {1} star in {0}?
            [Question.ZeroZeroStarPoints] = new TranslationInfo
            {
                QuestionText = "How many points were on the {1} star in {0}?",
            },
            // Where was the {1} square in {0}?
            [Question.ZeroZeroSquares] = new TranslationInfo
            {
                QuestionText = "Where was the {1} square in {0}?",
                FormatArgs = new Dictionary<string, string>
                {
                    ["red"] = "red",
                    ["green"] = "green",
                    ["blue"] = "blue",
                },
            },

            // Zoni
            // What was the {1} decrypted word in {0}?
            [Question.ZoniWords] = new TranslationInfo
            {
                QuestionText = "What was the {1} decrypted word in {0}?",
            },

        };
        #endregion
    }
}