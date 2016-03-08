using System;
using UnityEngine;
using System.Collections;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine.UI;

public class WordChecker : MonoBehaviour
{
    private readonly string[] easyWords = new string[] { "abend", "acm", "ada", "aop", "api", "aspi", "bcpl", "bean", "bind", "bom", "bool", "bug", "c", "c++", "c#", "cc", "char", "clr", "code", "cpan", "cpl", "csat", "css", "cvs", "d", "dde", "die", "diff", "dml", "do", "dom", "dump", "else", "eof", "eq", "esac", "eval", "exec", "f#", "flag", "for", "gcc", "ge", "gigo", "goto", "gpl", "gt", "gtk", "hal", "hash", "heap", "hdml", "hiew", "html", "ide", "int", "ipc", "java", "jcl", "jdbc", "jdk", "jil", "jit", "jni", "jre", "json", "jsp", "jsr", "jvm", "kit", "lisp", "llvm", "logo", "loop", "lt", "lua", "lut", "map", "math", "msdn", "msvc", "nan", "ne", ".net", "nbsp", "nda", "null", "odbc", "oop", "pdl", "perl", "php", "pick", "pipe", "pod", "pop", "push", "qi", "qt", "rad", "rcs", "rdf", "reia", "rem", "repl", "rpg", "ruby", "rust", "sdk", "seed", "sgml", "smil", "soap", "soft", "spl", "sql", "tcl", "tk", "true", "vb", "vhdl", "vim", "wml", "xml", "xna", "xoxo", "xsl", "xslt" };
    private readonly string[] mediumWords = new string[] { "activex", "alert", "algol", "applet", "array", "ascii", "babel", "backend", "block", "boolean", "bracket", "branch", "brooks", "c sharp", "class", "class", "clojure", "closure", "cobol", "cocoa", "comment", "compile", "compute", "concat", "curry", "cygwin", "datalog", "debug", "declare", "dhtml", "django", "eclipse", "element", "else if", "elsif", "endian", "epoch", "error", "escape", "event", "exists", "false", "foreach", "forth", "fortran", "glitch", "haskell", "hwclock", "if else", "inline", "integer", "invalid", "isapi", "java ee", "java me", "javac", "javafx", "javax", "jhtml", "jscript", "karel", "kludge", " kluge", "label", "lexicon", "linker", "library", "matlab", "mbean", "method", "module", "mumps", "mutex", "newline", "node.js", "ocaml", "octave", "operand", "p-code", "package", "parse", "pascal", "pointer", "private", "process", "program", "prolog", "public", "python", "racket", "random", "regex", "remark", "routine", "sandbox", "scala", "scanf", "scratch", "section", "servlet", "shebang", "socket", "source", "stack", "stdin", "tcl/tk", "thread", "thunk", "token", "tuple", "value", " void", "webgl", "while", "xhtml" };
    private readonly string[] hardWords = new string[] { "absolute address", "absolute coding", "access violation", "action statement", "actionscript", " advanced scsi programming interface", "aggregation", "agile development methods", "agile manifesto", "algorithm", "ambient occlusion", "argument", "arithmetic operator", "array of pointers", "assembler", "assembly", "associative operation", "autohotkey", "automata-based programming", "automated unit testing", "back-face culling", "background thread", "backpropagation neural network ", "base address", "batch file", "batch job", "beanshell", "binary search", "bit shift", "bitwise operators", "bug tracking", "bugfairy", "build computer", "bytecode", "camel book", "camelcase", "captured variable", "chaos model", "character code", "character encoding", "character set", "chaos model", "circuit satisfiability problem", "classpath", "cocoa touch", "code refactoring", "codepage", "coffeescript", "command language", "common business oriented language", "common gateway interface", "compilation", "compiler", "complementarity", "computer science", "commutative operation", "concatenation", "concurrency", "conditional expression", "conditional statement", "constructor chaining", "content migration", "control flow", "crapplet", "css compressor", "css editor", "curly bracket", "darkbasic", "dataflow programming", "data-flow analysis", "data flow diagram", "data source", "data type", "dead code", "debugger", "debugging", "declaration", "declarative programming", "decompiler", "deductive database", "dense matrix", "dereference operator", "dependent variable", "developer", "direct address", "discrete optimization", "dissembler", "dragon book", "dribbleware", "dylan programming language", "dynamic dump", "ecmascript", "eight queens problem", "ellipsis", "embedded java", "encapsulation", "endless loop", "errorlevel", "escape character", "escape sequence", "event handler", "event listener", "event-driven programming", "exception", "exception handling", "exponential backoff", "expression", "f programming language", "fifth generation language", "first generation language", "first-class object", "flat file", "floating-point", "forth generation language", "framework", "front end", "function", "functional programming", "game of life", "gang of four", "garbage collection", "gaussian pyramid", "general-purpose language", "generation language", "genetic programming", "glue code", "go language", "gw basic", "hard code", "hello world", "heuristic evaluation ", "hex editor", "high-level language", "html element", "html form element ", "html head", "hungarian notation", "hypertext markup language", "if statement", "immutable object", "imperative programming", "implicit parallelism", "indirection operator", "inherent error", "inheritance", "input/output statement", "instance", "instantiation", "instructions", "integrated development environment", "intellij idea", "intermediate language", "interpreted", "interpreter", "iteration", "java champion", "java native language", "java reserved words", "javabean", "javascript", "javascriptcore", "jbuilder", "lambda calculus", "language", "language processor", "lexical analysis", "live script", " literal", "local optimum", "logic programming", "logical operation", "lookup table", "loony bin", "loophole", "loosely typed language", "low-level language", "machine language", "magic quotes", "markup language", "memoization", "mercurial", "meta-character", "metaclass", "metalanguage", "method overloading", "middleware", "monte carlo method", "multi-pass compiler", "native compiler", "native language", "natural language", "nested function", "nested loop join", "nil pointer", "nodelist", "noncontiguous data structure", "non-disclosure agreement", "nonexecutable statement", "no-operation instructions", "null character", "null pointer", "object code", "object file", "object module", "object-oriented programming", "objective-c", "obfuscated code", "one-pass compiler", "open database connectivity", "opengl polygon", "operator", "operator associatively", "operator precedence", "or operator", "overflow error", "overload", "parenthesis", "pascal case", "pastebin", "persistent memory", "personaljava", "phrase tag", "pickling", "picojava", "pixel shader", "polymorphism", "procedural language", "procedure", "program generator", "program listing", "programmable", "programmer", "programming", "programming in logic", "programming language", "programming tools", "pseudocode", "pseudolanguage", "pseudo-operation", "purebasic", "python pickling", "quick-and-dirty", "r programming language", "race condition", "random seed", "real number", "recursion", "recursive", "regular expression", "relational algebra", "religion of chi", "repeat counter", "reserved character", "reserved word", "resource description framework", "return address", "return statement", "reverse engineering", "revision control", "rom basic", "routing algorithm", "run time", "s-expression", "safe font", "schema matching", "scheme programming language", "second generation language", "security descriptor definition language", "segfault", "separator", "server side", "server side scripting", "shell scripts", "short-circuit operator", "signedness", "simulated annealing", "single step", "smalltalk", "software development phases", "software development process", "software engineering", "software library", "software life cycle", "source code", "source computer", "source data", "spaghetti code", "sparse matrix", "sparsity", "special purpose language", "spooling", "stack pointer", "standard attribute", "statement", "strong typed language", "stubroutine", "stylesheet", "subprogram", "subroutine", "subscript", "substring", "subversion", "superclass", "switch statement", "syntactic sugar", "syntax error", "system development", "systems engineer", "systems programming language", "tail recursion", "ternary operator", "third-generation language", "transcompiler", "true basic", "turbo pascal", "turing completeness", "unary operator", "undefined", "undefined variable", "underflow", "unit test", "variable", "visual basic", "visual studio", "whole number", "workspace", "xor operator" };

    public GameObject expectedTextObject;
    public CountDownScript countDownScript;

    private Text expectedText;
    private Text currentText;
    private StringBuilder stringBuilder;
    private string text;
    private TouchScreenKeyboard keyboard;
    public static int counter;
    private string[] words;

    void Start()
    {
        this.expectedText = this.expectedTextObject.GetComponent<Text>();
        this.words = easyWords;
        this.expectedText.text = words[UnityEngine.Random.Range(0, words.Length)].ToLower();
        this.currentText = this.GetComponent<Text>();
        stringBuilder = new StringBuilder();
        keyboard = TouchScreenKeyboard.Open(text, TouchScreenKeyboardType.Default, false);
        text = keyboard.text;
        counter = 0;                                                          
    }

    void OnGUI()
    {
        PaintText();
        Event keyBoardEvent = Event.current;
        AddPressedLetterToInput(keyBoardEvent);
        CheckiIfWordsMatch();
        text = keyboard.text;
        currentText.text = text.ToLower();
    }

    private void CheckiIfWordsMatch()
    {
        if (expectedText.text == currentText.text)
        {
            this.expectedText.text = words[UnityEngine.Random.Range(0, words.Length)].ToLower();
            keyboard.text = string.Empty;
            counter++;
            if (counter == 5)
            {
                words = mediumWords;
            }
            else if (counter == 10)
            {
                words = hardWords;
            }
        }
    }

    void Update()
    {
        if (countDownScript.GetTimer() > 0)
        {                                     
            if (Input.touchCount > 0)
            {
                keyboard = TouchScreenKeyboard.Open(text, TouchScreenKeyboardType.ASCIICapable, false);
            }
        }       
    }

    private void AddPressedLetterToInput(Event keyBoardEvent)
    {
        if (countDownScript.GetTimer() > 0)
        {
            if (keyBoardEvent.isKey)
            {
                if (keyBoardEvent.character >= 'a' && keyBoardEvent.character <= 'z')
                {
                    stringBuilder.Append(Event.current.character);
                }
                else if (keyBoardEvent.character >= 'A' && keyBoardEvent.character <= 'Z')
                {
                    stringBuilder.Append(Event.current.character - 35);
                }
                this.currentText.text = stringBuilder.ToString();
            }
        }      
    }

    public void PaintText()
    {
        if (expectedText.text.StartsWith(currentText.text))
        {
            currentText.color = Color.green;
        }
        else
        {
            currentText.color = Color.red;
        }
    }



}
