// $ANTLR 2.7.2: "src/Boo.Antlr/boo.g" -> "BooLexer.cs"$

namespace Boo.Antlr
{
	// Generate header specific to lexer CSharp file
	using System;
	using Stream                          = System.IO.Stream;
	using TextReader                      = System.IO.TextReader;
	using Hashtable                       = System.Collections.Hashtable;
	using Comparer                        = System.Collections.Comparer;
	
	using TokenStreamException            = antlr.TokenStreamException;
	using TokenStreamIOException          = antlr.TokenStreamIOException;
	using TokenStreamRecognitionException = antlr.TokenStreamRecognitionException;
	using CharStreamException             = antlr.CharStreamException;
	using CharStreamIOException           = antlr.CharStreamIOException;
	using ANTLRException                  = antlr.ANTLRException;
	using CharScanner                     = antlr.CharScanner;
	using InputBuffer                     = antlr.InputBuffer;
	using ByteBuffer                      = antlr.ByteBuffer;
	using CharBuffer                      = antlr.CharBuffer;
	using Token                           = antlr.Token;
	using CommonToken                     = antlr.CommonToken;
	using SemanticException               = antlr.SemanticException;
	using RecognitionException            = antlr.RecognitionException;
	using NoViableAltForCharException     = antlr.NoViableAltForCharException;
	using MismatchedCharException         = antlr.MismatchedCharException;
	using TokenStream                     = antlr.TokenStream;
	using LexerSharedInputState           = antlr.LexerSharedInputState;
	using BitSet                          = antlr.collections.impl.BitSet;
	
using Boo.Antlr.Util;

	public 	class BooLexer : antlr.CharScanner	, TokenStream
	 {
		public const int EOF = 1;
		public const int NULL_TREE_LOOKAHEAD = 3;
		public const int TIMESPAN = 4;
		public const int ESEPARATOR = 5;
		public const int INDENT = 6;
		public const int DEDENT = 7;
		public const int COMPILATION_UNIT = 8;
		public const int PARAMETERS = 9;
		public const int PARAMETER = 10;
		public const int ELIST = 11;
		public const int DLIST = 12;
		public const int TYPE = 13;
		public const int CALL = 14;
		public const int STMT = 15;
		public const int BLOCK = 16;
		public const int FIELD = 17;
		public const int MODIFIERS = 18;
		public const int MODULE = 19;
		public const int LITERAL = 20;
		public const int LIST_LITERAL = 21;
		public const int UNPACKING = 22;
		public const int AND = 23;
		public const int AS = 24;
		public const int BREAK = 25;
		public const int CONTINUE = 26;
		public const int CLASS = 27;
		public const int CONSTRUCTOR = 28;
		public const int DEF = 29;
		public const int ELSE = 30;
		public const int ENSURE = 31;
		public const int ENUM = 32;
		public const int EXCEPT = 33;
		public const int FAILURE = 34;
		public const int FINAL = 35;
		public const int FROM = 36;
		public const int FOR = 37;
		public const int FALSE = 38;
		public const int GET = 39;
		public const int GIVEN = 40;
		public const int IMPORT = 41;
		public const int INTERFACE = 42;
		public const int INTERNAL = 43;
		public const int IS = 44;
		public const int IF = 45;
		public const int IN = 46;
		public const int KINDOF = 47;
		public const int NOT = 48;
		public const int NULL = 49;
		public const int OR = 50;
		public const int OTHERWISE = 51;
		public const int OVERRIDE = 52;
		public const int PASS = 53;
		public const int NAMESPACE = 54;
		public const int PROPERTY = 55;
		public const int PUBLIC = 56;
		public const int PROTECTED = 57;
		public const int PRIVATE = 58;
		public const int RAISE = 59;
		public const int RETURN = 60;
		public const int RETRY = 61;
		public const int SET = 62;
		public const int SELF = 63;
		public const int SUPER = 64;
		public const int STATIC = 65;
		public const int SUCCESS = 66;
		public const int TRY = 67;
		public const int TRANSIENT = 68;
		public const int TRUE = 69;
		public const int UNLESS = 70;
		public const int UNTIL = 71;
		public const int VOID = 72;
		public const int WHEN = 73;
		public const int WHILE = 74;
		public const int YIELD = 75;
		public const int EOS = 76;
		public const int TRIPLE_QUOTED_STRING = 77;
		public const int ID = 78;
		public const int ASSIGN = 79;
		public const int LBRACK = 80;
		public const int COMMA = 81;
		public const int RBRACK = 82;
		public const int LPAREN = 83;
		public const int RPAREN = 84;
		public const int COLON = 85;
		public const int QMARK = 86;
		public const int SUM_OPERATOR = 87;
		public const int MULT_OPERATOR = 88;
		public const int INCREMENT = 89;
		public const int DECREMENT = 90;
		public const int CMP_OPERATOR = 91;
		public const int DOT = 92;
		public const int INT = 93;
		public const int DOUBLE_QUOTED_STRING = 94;
		public const int SINGLE_QUOTED_STRING = 95;
		public const int LBRACE = 96;
		public const int RBRACE = 97;
		public const int RE_LITERAL = 98;
		public const int SL_COMMENT = 99;
		public const int WS = 100;
		public const int ESCAPED_EXPRESSION = 101;
		public const int DQS_ESC = 102;
		public const int SQS_ESC = 103;
		public const int SESC = 104;
		public const int RE_CHAR = 105;
		public const int RE_ESC = 106;
		public const int ID_LETTER = 107;
		public const int DIGIT = 108;
		
		
	protected int _skipWhitespaceRegion = 0;
	
	// token separador de expressões
	antlr.Token _eseparator = new antlr.CommonToken(ESEPARATOR, "ESEPARATOR");
	
	// índice atual na expressão de formatação de strings ver ESCAPED_EXPRESSION
	int _eindex = 0;
	
	// lexer para expressões dentro de formatação de strings
	BooExpressionLexer _el;
	
	TokenStreamRecorder _erecorder;
	
	antlr.TokenStreamSelector _selector;
	
	internal void Initialize(antlr.TokenStreamSelector selector, int tabSize, string tokenObjectClass)
	{
		_selector = selector;
		_el = new BooExpressionLexer(getInputState());
		_el.setTabSize(tabSize);
		_el.setTokenObjectClass(tokenObjectClass);
		
		_erecorder = new TokenStreamRecorder(selector);
		
	}
	
	bool SkipWhitespace
	{
		get
		{
			return _skipWhitespaceRegion > 0;
		}
	}

	internal void EnterSkipWhitespaceRegion()
	{
		++_skipWhitespaceRegion;
	}	

	internal void LeaveSkipWhitespaceRegion()
	{
		--_skipWhitespaceRegion;
	}
		public BooLexer(Stream ins) : this(new ByteBuffer(ins))
		{
		}
		
		public BooLexer(TextReader r) : this(new CharBuffer(r))
		{
		}
		
		public BooLexer(InputBuffer ib)		 : this(new LexerSharedInputState(ib))
		{
		}
		
		public BooLexer(LexerSharedInputState state) : base(state)
		{
			initialize();
		}
		private void initialize()
		{
			caseSensitiveLiterals = true;
			setCaseSensitive(true);
			literals = new Hashtable(null, Comparer.Default);
			literals.Add("otherwise", 51);
			literals.Add("retry", 61);
			literals.Add("internal", 43);
			literals.Add("failure", 34);
			literals.Add("class", 27);
			literals.Add("private", 58);
			literals.Add("def", 29);
			literals.Add("if", 45);
			literals.Add("pass", 53);
			literals.Add("ensure", 31);
			literals.Add("override", 52);
			literals.Add("unless", 70);
			literals.Add("self", 63);
			literals.Add("when", 73);
			literals.Add("success", 66);
			literals.Add("in", 46);
			literals.Add("enum", 32);
			literals.Add("continue", 26);
			literals.Add("from", 36);
			literals.Add("given", 40);
			literals.Add("import", 41);
			literals.Add("while", 74);
			literals.Add("as", 24);
			literals.Add("not", 48);
			literals.Add("false", 38);
			literals.Add("namespace", 54);
			literals.Add("super", 64);
			literals.Add("protected", 57);
			literals.Add("null", 49);
			literals.Add("or", 50);
			literals.Add("constructor", 28);
			literals.Add("true", 69);
			literals.Add("void", 72);
			literals.Add("interface", 42);
			literals.Add("kindof", 47);
			literals.Add("raise", 59);
			literals.Add("break", 25);
			literals.Add("final", 35);
			literals.Add("for", 37);
			literals.Add("try", 67);
			literals.Add("except", 33);
			literals.Add("yield", 75);
			literals.Add("else", 30);
			literals.Add("return", 60);
			literals.Add("public", 56);
			literals.Add("static", 65);
			literals.Add("transient", 68);
			literals.Add("is", 44);
			literals.Add("and", 23);
			literals.Add("property", 55);
			literals.Add("until", 71);
			literals.Add("set", 62);
			literals.Add("get", 39);
		}
		
		public new Token nextToken()			//throws TokenStreamException
		{
			Token theRetToken = null;
tryAgain:
			for (;;)
			{
				Token _token = null;
				int _ttype = Token.INVALID_TYPE;
				resetText();
				try     // for char stream error handling
				{
					try     // for lexical error handling
					{
						switch ( LA(1) )
						{
						case 'A':  case 'B':  case 'C':  case 'D':
						case 'E':  case 'F':  case 'G':  case 'H':
						case 'I':  case 'J':  case 'K':  case 'L':
						case 'M':  case 'N':  case 'O':  case 'P':
						case 'Q':  case 'R':  case 'S':  case 'T':
						case 'U':  case 'V':  case 'W':  case 'X':
						case 'Y':  case 'Z':  case '_':  case 'a':
						case 'b':  case 'c':  case 'd':  case 'e':
						case 'f':  case 'g':  case 'h':  case 'i':
						case 'j':  case 'k':  case 'l':  case 'm':
						case 'n':  case 'o':  case 'p':  case 'q':
						case 'r':  case 's':  case 't':  case 'u':
						case 'v':  case 'w':  case 'x':  case 'y':
						case 'z':
						{
							mID(true);
							theRetToken = returnToken_;
							break;
						}
						case '0':  case '1':  case '2':  case '3':
						case '4':  case '5':  case '6':  case '7':
						case '8':  case '9':
						{
							mINT(true);
							theRetToken = returnToken_;
							break;
						}
						case '.':
						{
							mDOT(true);
							theRetToken = returnToken_;
							break;
						}
						case ':':
						{
							mCOLON(true);
							theRetToken = returnToken_;
							break;
						}
						case '(':
						{
							mLPAREN(true);
							theRetToken = returnToken_;
							break;
						}
						case ')':
						{
							mRPAREN(true);
							theRetToken = returnToken_;
							break;
						}
						case '[':
						{
							mLBRACK(true);
							theRetToken = returnToken_;
							break;
						}
						case ']':
						{
							mRBRACK(true);
							theRetToken = returnToken_;
							break;
						}
						case '{':
						{
							mLBRACE(true);
							theRetToken = returnToken_;
							break;
						}
						case '}':
						{
							mRBRACE(true);
							theRetToken = returnToken_;
							break;
						}
						case '?':
						{
							mQMARK(true);
							theRetToken = returnToken_;
							break;
						}
						case '%':  case '*':  case '/':
						{
							mMULT_OPERATOR(true);
							theRetToken = returnToken_;
							break;
						}
						case '!':  case '<':  case '>':
						{
							mCMP_OPERATOR(true);
							theRetToken = returnToken_;
							break;
						}
						case '=':
						{
							mASSIGN(true);
							theRetToken = returnToken_;
							break;
						}
						case ',':
						{
							mCOMMA(true);
							theRetToken = returnToken_;
							break;
						}
						case '"':
						{
							mDOUBLE_QUOTED_STRING(true);
							theRetToken = returnToken_;
							break;
						}
						case '\'':
						{
							mSINGLE_QUOTED_STRING(true);
							theRetToken = returnToken_;
							break;
						}
						case '#':
						{
							mSL_COMMENT(true);
							theRetToken = returnToken_;
							break;
						}
						case '\t':  case '\n':  case '\u000c':  case '\r':
						case ' ':
						{
							mWS(true);
							theRetToken = returnToken_;
							break;
						}
						case ';':
						{
							mEOS(true);
							theRetToken = returnToken_;
							break;
						}
						default:
							if ((LA(1)=='+') && (LA(2)=='+'))
							{
								mINCREMENT(true);
								theRetToken = returnToken_;
							}
							else if ((LA(1)=='-') && (LA(2)=='-')) {
								mDECREMENT(true);
								theRetToken = returnToken_;
							}
							else if ((LA(1)=='+'||LA(1)=='-') && (true)) {
								mSUM_OPERATOR(true);
								theRetToken = returnToken_;
							}
						else
						{
							if (LA(1)==EOF_CHAR) { uponEOF(); returnToken_ = makeToken(Token.EOF_TYPE); }
				else {throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());}
						}
						break; }
						if ( null==returnToken_ ) goto tryAgain; // found SKIP token
						_ttype = returnToken_.Type;
						returnToken_.Type = _ttype;
						return returnToken_;
					}
					catch (RecognitionException e) {
							throw new TokenStreamRecognitionException(e);
					}
				}
				catch (CharStreamException cse) {
					if ( cse is CharStreamIOException ) {
						throw new TokenStreamIOException(((CharStreamIOException)cse).io);
					}
					else {
						throw new TokenStreamException(cse.Message);
					}
				}
			}
		}
		
	public void mID(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = ID;
		
		mID_LETTER(false);
		{    // ( ... )*
			for (;;)
			{
				switch ( LA(1) )
				{
				case 'A':  case 'B':  case 'C':  case 'D':
				case 'E':  case 'F':  case 'G':  case 'H':
				case 'I':  case 'J':  case 'K':  case 'L':
				case 'M':  case 'N':  case 'O':  case 'P':
				case 'Q':  case 'R':  case 'S':  case 'T':
				case 'U':  case 'V':  case 'W':  case 'X':
				case 'Y':  case 'Z':  case '_':  case 'a':
				case 'b':  case 'c':  case 'd':  case 'e':
				case 'f':  case 'g':  case 'h':  case 'i':
				case 'j':  case 'k':  case 'l':  case 'm':
				case 'n':  case 'o':  case 'p':  case 'q':
				case 'r':  case 's':  case 't':  case 'u':
				case 'v':  case 'w':  case 'x':  case 'y':
				case 'z':
				{
					mID_LETTER(false);
					break;
				}
				case '0':  case '1':  case '2':  case '3':
				case '4':  case '5':  case '6':  case '7':
				case '8':  case '9':
				{
					mDIGIT(false);
					break;
				}
				default:
				{
					goto _loop267_breakloop;
				}
				 }
			}
_loop267_breakloop:			;
		}    // ( ... )*
		_ttype = testLiteralsTable(_ttype);
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mID_LETTER(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = ID_LETTER;
		
		{
			switch ( LA(1) )
			{
			case '_':
			{
				match('_');
				break;
			}
			case 'a':  case 'b':  case 'c':  case 'd':
			case 'e':  case 'f':  case 'g':  case 'h':
			case 'i':  case 'j':  case 'k':  case 'l':
			case 'm':  case 'n':  case 'o':  case 'p':
			case 'q':  case 'r':  case 's':  case 't':
			case 'u':  case 'v':  case 'w':  case 'x':
			case 'y':  case 'z':
			{
				matchRange('a','z');
				break;
			}
			case 'A':  case 'B':  case 'C':  case 'D':
			case 'E':  case 'F':  case 'G':  case 'H':
			case 'I':  case 'J':  case 'K':  case 'L':
			case 'M':  case 'N':  case 'O':  case 'P':
			case 'Q':  case 'R':  case 'S':  case 'T':
			case 'U':  case 'V':  case 'W':  case 'X':
			case 'Y':  case 'Z':
			{
				matchRange('A','Z');
				break;
			}
			default:
			{
				throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());
			}
			 }
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mDIGIT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = DIGIT;
		
		matchRange('0','9');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mINT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = INT;
		
		{ // ( ... )+
		int _cnt270=0;
		for (;;)
		{
			if (((LA(1) >= '0' && LA(1) <= '9')))
			{
				mDIGIT(false);
			}
			else
			{
				if (_cnt270 >= 1) { goto _loop270_breakloop; } else { throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());; }
			}
			
			_cnt270++;
		}
_loop270_breakloop:		;
		}    // ( ... )+
		{
			if ((LA(1)=='d'||LA(1)=='h'||LA(1)=='m'||LA(1)=='s'))
			{
				{
					switch ( LA(1) )
					{
					case 's':
					{
						match('s');
						break;
					}
					case 'h':
					{
						match('h');
						break;
					}
					case 'd':
					{
						match('d');
						break;
					}
					default:
						if ((LA(1)=='m') && (LA(2)=='s'))
						{
							match("ms");
						}
						else if ((LA(1)=='m') && (true)) {
							match('m');
						}
					else
					{
						throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());
					}
					break; }
				}
				if (0==inputState.guessing)
				{
					_ttype = TIMESPAN;
				}
			}
			else {
			}
			
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mDOT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = DOT;
		
		match('.');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mCOLON(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = COLON;
		
		match(':');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mLPAREN(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = LPAREN;
		
		match('(');
		if (0==inputState.guessing)
		{
			EnterSkipWhitespaceRegion();
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mRPAREN(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = RPAREN;
		
		match(')');
		if (0==inputState.guessing)
		{
			LeaveSkipWhitespaceRegion();
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mLBRACK(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = LBRACK;
		
		match('[');
		if (0==inputState.guessing)
		{
			EnterSkipWhitespaceRegion();
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mRBRACK(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = RBRACK;
		
		match(']');
		if (0==inputState.guessing)
		{
			LeaveSkipWhitespaceRegion();
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mLBRACE(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = LBRACE;
		
		match('{');
		if (0==inputState.guessing)
		{
			EnterSkipWhitespaceRegion();
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mRBRACE(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = RBRACE;
		
		match('}');
		if (0==inputState.guessing)
		{
			LeaveSkipWhitespaceRegion();
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mQMARK(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = QMARK;
		
		match('?');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mINCREMENT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = INCREMENT;
		
		match("++");
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mDECREMENT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = DECREMENT;
		
		match("--");
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mSUM_OPERATOR(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = SUM_OPERATOR;
		
		{
			switch ( LA(1) )
			{
			case '+':
			{
				match('+');
				break;
			}
			case '-':
			{
				match('-');
				break;
			}
			default:
			{
				throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());
			}
			 }
		}
		{
			if ((LA(1)=='='))
			{
				match('=');
				if (0==inputState.guessing)
				{
					_ttype = ASSIGN;
				}
			}
			else {
			}
			
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mMULT_OPERATOR(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = MULT_OPERATOR;
		
		switch ( LA(1) )
		{
		case '%':
		{
			match('%');
			break;
		}
		case '*':
		{
			match('*');
			{
				if ((LA(1)=='='))
				{
					match('=');
					if (0==inputState.guessing)
					{
						_ttype = ASSIGN;
					}
				}
				else {
				}
				
			}
			break;
		}
		default:
			bool synPredMatched290 = false;
			if (((LA(1)=='/') && (tokenSet_0_.member(LA(2))) && (tokenSet_1_.member(LA(3)))))
			{
				int _m290 = mark();
				synPredMatched290 = true;
				inputState.guessing++;
				try {
					{
						mRE_LITERAL(false);
					}
				}
				catch (RecognitionException)
				{
					synPredMatched290 = false;
				}
				rewind(_m290);
				inputState.guessing--;
			}
			if ( synPredMatched290 )
			{
				mRE_LITERAL(false);
				if (0==inputState.guessing)
				{
					_ttype = RE_LITERAL;
				}
			}
			else if ((LA(1)=='/') && (true) && (true)) {
				match('/');
				{
					switch ( LA(1) )
					{
					case '/':
					{
						{
							match('/');
							{    // ( ... )*
								for (;;)
								{
									if ((tokenSet_2_.member(LA(1))))
									{
										{
											match(tokenSet_2_);
										}
									}
									else
									{
										goto _loop295_breakloop;
									}
									
								}
_loop295_breakloop:								;
							}    // ( ... )*
							if (0==inputState.guessing)
							{
								_ttype = Token.SKIP;
							}
						}
						break;
					}
					case '=':
					{
						{
							match('=');
							if (0==inputState.guessing)
							{
								_ttype = ASSIGN;
							}
						}
						break;
					}
					default:
						{
						}
					break; }
				}
			}
		else
		{
			throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());
		}
		break; }
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mRE_LITERAL(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = RE_LITERAL;
		
		match('/');
		{ // ( ... )+
		int _cnt338=0;
		for (;;)
		{
			if ((tokenSet_0_.member(LA(1))))
			{
				mRE_CHAR(false);
			}
			else
			{
				if (_cnt338 >= 1) { goto _loop338_breakloop; } else { throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());; }
			}
			
			_cnt338++;
		}
_loop338_breakloop:		;
		}    // ( ... )+
		match('/');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mCMP_OPERATOR(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = CMP_OPERATOR;
		
		if ((LA(1)=='<') && (LA(2)=='='))
		{
			match("<=");
		}
		else if ((LA(1)=='>') && (LA(2)=='=')) {
			match(">=");
		}
		else if ((LA(1)=='!') && (LA(2)=='~')) {
			match("!~");
		}
		else if ((LA(1)=='!') && (LA(2)=='=')) {
			match("!=");
		}
		else if ((LA(1)=='<') && (true)) {
			match('<');
		}
		else if ((LA(1)=='>') && (true)) {
			match('>');
		}
		else
		{
			throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());
		}
		
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mASSIGN(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = ASSIGN;
		
		match('=');
		{
			if ((LA(1)=='='||LA(1)=='~'))
			{
				{
					switch ( LA(1) )
					{
					case '=':
					{
						match('=');
						break;
					}
					case '~':
					{
						match('~');
						break;
					}
					default:
					{
						throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());
					}
					 }
				}
				if (0==inputState.guessing)
				{
					_ttype = CMP_OPERATOR;
				}
			}
			else {
			}
			
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mCOMMA(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = COMMA;
		
		match(',');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mTRIPLE_QUOTED_STRING(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = TRIPLE_QUOTED_STRING;
		
		int _saveIndex = 0;
		_saveIndex = text.Length;
		match("\"\"");
		text.Length = _saveIndex;
		{    // ( ... )*
			for (;;)
			{
				// nongreedy exit test
				if ((LA(1)=='"') && (LA(2)=='"') && (LA(3)=='"')) goto _loop305_breakloop;
				if ((tokenSet_3_.member(LA(1))) && ((LA(2) >= '\u0003' && LA(2) <= '\uffff')) && ((LA(3) >= '\u0003' && LA(3) <= '\uffff')))
				{
					{
						match(tokenSet_3_);
					}
				}
				else if ((LA(1)=='\n')) {
					match('\n');
					if (0==inputState.guessing)
					{
						newline();
					}
				}
				else
				{
					goto _loop305_breakloop;
				}
				
			}
_loop305_breakloop:			;
		}    // ( ... )*
		_saveIndex = text.Length;
		match("\"\"\"");
		text.Length = _saveIndex;
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mDOUBLE_QUOTED_STRING(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = DOUBLE_QUOTED_STRING;
		
		if (0==inputState.guessing)
		{
			_eindex = 0;
		}
		int _saveIndex = 0;
		_saveIndex = text.Length;
		match('"');
		text.Length = _saveIndex;
		{
			if (((LA(1)=='"') && (LA(2)=='"') && ((LA(3) >= '\u0003' && LA(3) <= '\uffff')))&&(LA(1)=='"' && LA(2)=='"'))
			{
				mTRIPLE_QUOTED_STRING(false);
				if (0==inputState.guessing)
				{
					_ttype = TRIPLE_QUOTED_STRING;
				}
			}
			else if ((tokenSet_2_.member(LA(1))) && (true) && (true)) {
				{
					{    // ( ... )*
						for (;;)
						{
							bool synPredMatched311 = false;
							if (((LA(1)=='$') && (LA(2)=='{') && (tokenSet_2_.member(LA(3)))))
							{
								int _m311 = mark();
								synPredMatched311 = true;
								inputState.guessing++;
								try {
									{
										match("${");
									}
								}
								catch (RecognitionException)
								{
									synPredMatched311 = false;
								}
								rewind(_m311);
								inputState.guessing--;
							}
							if ( synPredMatched311 )
							{
								mESCAPED_EXPRESSION(false);
							}
							else if ((tokenSet_4_.member(LA(1))) && (tokenSet_2_.member(LA(2))) && (true)) {
								{
									match(tokenSet_4_);
								}
							}
							else if ((LA(1)=='\\')) {
								mDQS_ESC(false);
							}
							else
							{
								goto _loop313_breakloop;
							}
							
						}
_loop313_breakloop:						;
					}    // ( ... )*
					_saveIndex = text.Length;
					match('"');
					text.Length = _saveIndex;
					if (0==inputState.guessing)
					{
						
										if (_erecorder.Count > 0)
										{
											_selector.push(_erecorder);
										}
									
					}
				}
			}
			else
			{
				throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());
			}
			
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mDQS_ESC(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = DQS_ESC;
		
		int _saveIndex = 0;
		_saveIndex = text.Length;
		match('\\');
		text.Length = _saveIndex;
		{
			switch ( LA(1) )
			{
			case '\\':  case 'n':  case 'r':  case 't':
			{
				mSESC(false);
				break;
			}
			case '"':
			{
				match('"');
				break;
			}
			case '$':
			{
				match('$');
				break;
			}
			default:
			{
				throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());
			}
			 }
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mESCAPED_EXPRESSION(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = ESCAPED_EXPRESSION;
		
		match("${");
		if (0==inputState.guessing)
		{
						
					_erecorder.Enqueue(_eseparator);
					if (_erecorder.RecordUntil(_el, RBRACE) > 0)
					{
						text.Length = _begin; text.Append("{" + _eindex+ "}");
						++_eindex;
					}
				
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mSINGLE_QUOTED_STRING(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = SINGLE_QUOTED_STRING;
		
		int _saveIndex = 0;
		_saveIndex = text.Length;
		match('\'');
		text.Length = _saveIndex;
		{    // ( ... )*
			for (;;)
			{
				if ((LA(1)=='\\'))
				{
					mSQS_ESC(false);
				}
				else if ((tokenSet_5_.member(LA(1)))) {
					{
						match(tokenSet_5_);
					}
				}
				else
				{
					goto _loop317_breakloop;
				}
				
			}
_loop317_breakloop:			;
		}    // ( ... )*
		_saveIndex = text.Length;
		match('\'');
		text.Length = _saveIndex;
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mSQS_ESC(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = SQS_ESC;
		
		int _saveIndex = 0;
		_saveIndex = text.Length;
		match('\\');
		text.Length = _saveIndex;
		{
			switch ( LA(1) )
			{
			case '\\':  case 'n':  case 'r':  case 't':
			{
				mSESC(false);
				break;
			}
			case '\'':
			{
				match('\'');
				break;
			}
			default:
			{
				throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());
			}
			 }
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mSL_COMMENT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = SL_COMMENT;
		
		match("#");
		{    // ( ... )*
			for (;;)
			{
				if ((tokenSet_2_.member(LA(1))))
				{
					{
						match(tokenSet_2_);
					}
				}
				else
				{
					goto _loop321_breakloop;
				}
				
			}
_loop321_breakloop:			;
		}    // ( ... )*
		if (0==inputState.guessing)
		{
			_ttype = Token.SKIP;
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mWS(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = WS;
		
		{ // ( ... )+
		int _cnt324=0;
		for (;;)
		{
			switch ( LA(1) )
			{
			case ' ':
			{
				match(' ');
				break;
			}
			case '\t':
			{
				match('\t');
				break;
			}
			case '\u000c':
			{
				match('\f');
				break;
			}
			case '\r':
			{
				match('\r');
				break;
			}
			case '\n':
			{
				match('\n');
				if (0==inputState.guessing)
				{
					newline();
				}
				break;
			}
			default:
			{
				if (_cnt324 >= 1) { goto _loop324_breakloop; } else { throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());; }
			}
			break; }
			_cnt324++;
		}
_loop324_breakloop:		;
		}    // ( ... )+
		if (0==inputState.guessing)
		{
			
					if (SkipWhitespace)
					{
						_ttype = Token.SKIP;
					}
				
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mEOS(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = EOS;
		
		match(';');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mSESC(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = SESC;
		
		switch ( LA(1) )
		{
		case 'r':
		{
			{
				match('r');
				if (0==inputState.guessing)
				{
					text.Length = _begin; text.Append("\r");
				}
			}
			break;
		}
		case 'n':
		{
			{
				match('n');
				if (0==inputState.guessing)
				{
					text.Length = _begin; text.Append("\n");
				}
			}
			break;
		}
		case 't':
		{
			{
				match('t');
				if (0==inputState.guessing)
				{
					text.Length = _begin; text.Append("\t");
				}
			}
			break;
		}
		case '\\':
		{
			{
				match('\\');
			}
			break;
		}
		default:
		{
			throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());
		}
		 }
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mRE_CHAR(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = RE_CHAR;
		
		if ((LA(1)=='\\'))
		{
			mRE_ESC(false);
		}
		else if ((tokenSet_6_.member(LA(1)))) {
			{
				match(tokenSet_6_);
			}
		}
		else
		{
			throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());
		}
		
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mRE_ESC(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; Token _token=null; int _begin=text.Length;
		_ttype = RE_ESC;
		
		match('\\');
		{
			switch ( LA(1) )
			{
			case '\\':
			{
				match('\\');
				break;
			}
			case '/':
			{
				match('/');
				break;
			}
			case 'r':
			{
				match('r');
				break;
			}
			case 'n':
			{
				match('n');
				break;
			}
			case 't':
			{
				match('t');
				break;
			}
			case '(':
			{
				match('(');
				break;
			}
			case ')':
			{
				match(')');
				break;
			}
			case '.':
			{
				match('.');
				break;
			}
			case '*':
			{
				match('*');
				break;
			}
			case '?':
			{
				match('?');
				break;
			}
			case '[':
			{
				match('[');
				break;
			}
			case ']':
			{
				match(']');
				break;
			}
			default:
			{
				throw new NoViableAltForCharException((char)LA(1), getFilename(), getLine(), getColumn());
			}
			 }
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	
	private static long[] mk_tokenSet_0_()
	{
		long[] data = new long[2048];
		data[0]=-140741783332360L;
		for (int i = 1; i<=1023; i++) { data[i]=-1L; }
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_0_ = new BitSet(mk_tokenSet_0_());
	private static long[] mk_tokenSet_1_()
	{
		long[] data = new long[2048];
		data[0]=-4294977032L;
		for (int i = 1; i<=1023; i++) { data[i]=-1L; }
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_1_ = new BitSet(mk_tokenSet_1_());
	private static long[] mk_tokenSet_2_()
	{
		long[] data = new long[2048];
		data[0]=-9224L;
		for (int i = 1; i<=1023; i++) { data[i]=-1L; }
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_2_ = new BitSet(mk_tokenSet_2_());
	private static long[] mk_tokenSet_3_()
	{
		long[] data = new long[2048];
		data[0]=-1032L;
		for (int i = 1; i<=1023; i++) { data[i]=-1L; }
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_3_ = new BitSet(mk_tokenSet_3_());
	private static long[] mk_tokenSet_4_()
	{
		long[] data = new long[2048];
		data[0]=-17179878408L;
		data[1]=-268435457L;
		for (int i = 2; i<=1023; i++) { data[i]=-1L; }
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_4_ = new BitSet(mk_tokenSet_4_());
	private static long[] mk_tokenSet_5_()
	{
		long[] data = new long[2048];
		data[0]=-549755823112L;
		data[1]=-268435457L;
		for (int i = 2; i<=1023; i++) { data[i]=-1L; }
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_5_ = new BitSet(mk_tokenSet_5_());
	private static long[] mk_tokenSet_6_()
	{
		long[] data = new long[2048];
		data[0]=-140741783332360L;
		data[1]=-268435457L;
		for (int i = 2; i<=1023; i++) { data[i]=-1L; }
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_6_ = new BitSet(mk_tokenSet_6_());
	
}
}
