using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Main2 : MonoBehaviour {

   

    // 式入力テキスト
    public Text Formula;
	// 結果表示テキスト
	public Text Answer;
	// 各数字ボタン
	public Button[] bNumber;
	// 足すボタン
	public Button bAdd;
	// 引くボタン
	public Button bSubtraction;
	// 掛けるボタン
	public Button bMultiplied;
	// 割るボタン
	public Button bDivide;
	// 計算ボタン
	public Button bEqual;
	// クリアボタン
	public Button bClear;
	// 消費税計算表示ボタン
	public Button TaxButton;
	public Button NoTaxButton;

		
	// Use this for initialization
	void Start () {
        Screen.SetResolution(400, 710, false, 60);
        //　初期化
        Formula.text = "";
		Answer.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// 数字ボタン押下
	public void InputNumber(Text number){
		// 押下したボタンの数字を式欄に追記する
		Formula.text += number.text;
	}


	// 割るボタン押下
	public void InputDivide(Text divideButton){
		
		// // 数字が未入力か、すでに÷があればスルー
		// if(Formula.text == "" || Formula.text.Contains("÷")){
		// 	return;
		// }
		
		// // ÷を式欄に追記する
		// Formula.text += divideButton.text;

		// if(Answer.text == ""){
		// 	return;
		// } else
		// {
		// 	Formula.text = "";
		// 	Formula.text += Answer.text;
		// 	Formula.text += divideButton.text;
		// }

		if(Formula.text.Contains("+") || Formula.text.Contains("-") || Formula.text.Contains("×") || Formula.text.Contains("÷")){

			string[] inputString = Formula.text.Split('-', '+', '×', '÷');
			decimal leftNumber = decimal.Parse(inputString[0]);
			decimal rightNumber = decimal.Parse(inputString[1]);

			decimal calculation = 0;
			if(Formula.text.Contains("+"))
	 		{// 和
	 			decimal l = leftNumber;
				decimal r = rightNumber;
				calculation = Math.Floor(l + r);
				Console.WriteLine(l + r);	
	 		}
     		else if(Formula.text.Contains("-"))
	 		{// 差
				decimal l = leftNumber;
				decimal r = rightNumber;
				calculation = Math.Floor(l - r);
				Console.WriteLine(l - r);
	 		}
	 		else if(Formula.text.Contains("×"))
	 		{// 積
	 			decimal l = leftNumber;
				decimal r = rightNumber;
				calculation = Math.Floor(l * r);
				Console.WriteLine(l * r);	
  	 		}
	 		else if(Formula.text.Contains("÷"))
	 		{// 商
	 		decimal l = leftNumber;
			decimal r = rightNumber;
			calculation = Math.Floor(l / r);
			Console.WriteLine(l / r);
			} 
			Formula.text = calculation.ToString();
			Formula.text += divideButton.text;	
		}
	 		else if(Answer.text == ""){
			// +を式欄に追記する
			Formula.text += divideButton.text;
		} else
		{
			Formula.text = "";
			Formula.text += Answer.text;
			Formula.text += divideButton.text;
		}
	}

	// 掛けるボタン押下
	public void InputMultiplied(Text multipliedButton){
		// // 数字が未入力か、すでに×があればスルー
		// if(Formula.text == "" || Formula.text.Contains("×")){
		// 	return;
		// }
		
		// // ×を式欄に追記する
		// Formula.text += multipliedButton.text;

		// if(Answer.text == ""){
		// 	return;
		// } else
		// {
		// 	Formula.text = "";
		// 	Formula.text += Answer.text;
		// 	Formula.text += multipliedButton.text;
		// }

		if(Formula.text.Contains("+") || Formula.text.Contains("-") || Formula.text.Contains("×") || Formula.text.Contains("÷")){

			string[] inputString = Formula.text.Split('-', '+', '×', '÷');
			decimal leftNumber = decimal.Parse(inputString[0]);
			decimal rightNumber = decimal.Parse(inputString[1]);

			decimal calculation = 0;
			if(Formula.text.Contains("+"))
	 		{// 和
	 			decimal l = leftNumber;
				decimal r = rightNumber;
				calculation = Math.Floor(l + r);
				Console.WriteLine(l + r);	
	 		}
     		else if(Formula.text.Contains("-"))
	 		{// 差
				decimal l = leftNumber;
				decimal r = rightNumber;
				calculation = Math.Floor(l - r);
				Console.WriteLine(l - r);
	 		}
	 		else if(Formula.text.Contains("×"))
	 		{// 積
	 			decimal l = leftNumber;
				decimal r = rightNumber;
				calculation = Math.Floor(l * r);
				Console.WriteLine(l * r);	
  	 		}
	 		else if(Formula.text.Contains("÷"))
	 		{// 商
	 		decimal l = leftNumber;
			decimal r = rightNumber;
			calculation = Math.Floor(l / r);
			Console.WriteLine(l / r);
			} 
			Formula.text = calculation.ToString();
			Formula.text += multipliedButton.text;	
		}
	 		else if(Answer.text == ""){
			// +を式欄に追記する
			Formula.text += multipliedButton.text;
		} else
		{
			Formula.text = "";
			Formula.text += Answer.text;
			Formula.text += multipliedButton.text;
		}
	}

	// 足すボタン押下
	public void InputAdd(Text addButton){
		// // 数字が未入力か、すでに+があればスルー
		// if(Formula.text == "" || Formula.text.Contains("+")){
		// 	return;
		// }

		// if(Answer.text == Calculation){
		// 	// 初期化
		// 	Formula.text = "";
		// 	Answer.text = "";
		// 	// +を式欄に追記する
		// 	Formula.text += Answer.text;	
		// }
		

		// +がないか、すでに+があれば★
		if(Formula.text.Contains("+") || Formula.text.Contains("-") || Formula.text.Contains("×") || Formula.text.Contains("÷")){

			string[] inputString = Formula.text.Split('-', '+', '×', '÷');
			decimal leftNumber = decimal.Parse(inputString[0]);
			decimal rightNumber = decimal.Parse(inputString[1]);

			decimal calculation = 0;
			if(Formula.text.Contains("+"))
	 		{// 和
	 			decimal l = leftNumber;
				decimal r = rightNumber;
				calculation = Math.Floor(l + r);
				Console.WriteLine(l + r);	
	 		}
     		else if(Formula.text.Contains("-"))
	 		{// 差
				decimal l = leftNumber;
				decimal r = rightNumber;
				calculation = Math.Floor(l - r);
				Console.WriteLine(l - r);
	 		}
	 		else if(Formula.text.Contains("×"))
	 		{// 積
	 			decimal l = leftNumber;
				decimal r = rightNumber;
				calculation = Math.Floor(l * r);
				Console.WriteLine(l * r);	
  	 		}
	 		else if(Formula.text.Contains("÷"))
	 		{// 商
	 		decimal l = leftNumber;
			decimal r = rightNumber;
			calculation = Math.Floor(l / r);
			Console.WriteLine(l / r);
			} 
			Formula.text = calculation.ToString();
			Formula.text += addButton.text;	
		}
	 		else if(Answer.text == ""){
			// +を式欄に追記する
			Formula.text += addButton.text;
		} else
		{
			Formula.text = "";
			Formula.text += Answer.text;
			Formula.text += addButton.text;
		}
		
	}
	
	// 引くボタン押下
	public void InputSubtraction(Text subtractionButton){
		// // 数字が未入力か、すでに-があればスルー
		// if(Formula.text == "" || Formula.text.Contains("-")){
		// 	return;
		// }
		// -を式欄に追記する
		// Formula.text += subtractionButton.text;

		// if(Answer.text == ""){
		// 	return;
		// } else
		// {
		// 	Formula.text = "";
		// 	Formula.text += Answer.text;
		// 	Formula.text += subtractionButton.text;
		// }

		// +がないか、すでに+があれば★
		if(Formula.text.Contains("+") || Formula.text.Contains("-") || Formula.text.Contains("×") || Formula.text.Contains("÷")){

			string[] inputString = Formula.text.Split('-', '+', '×', '÷');
			decimal leftNumber = decimal.Parse(inputString[0]);
			decimal rightNumber = decimal.Parse(inputString[1]);

			decimal calculation = 0;
			if(Formula.text.Contains("+"))
	 		{// 和
	 			decimal l = leftNumber;
				decimal r = rightNumber;
				calculation = Math.Floor(l + r);
				Console.WriteLine(l + r);	
	 		}
     		else if(Formula.text.Contains("-"))
	 		{// 差
				decimal l = leftNumber;
				decimal r = rightNumber;
				calculation = Math.Floor(l - r);
				Console.WriteLine(l - r);
	 		}
	 		else if(Formula.text.Contains("×"))
	 		{// 積
	 			decimal l = leftNumber;
				decimal r = rightNumber;
				calculation = Math.Floor(l * r);
				Console.WriteLine(l * r);	
  	 		}
	 		else if(Formula.text.Contains("÷"))
	 		{// 商
	 		decimal l = leftNumber;
			decimal r = rightNumber;
			calculation = Math.Floor(l / r);
			Console.WriteLine(l / r);
			} 
			Formula.text = calculation.ToString();
			Formula.text += subtractionButton.text;	
		}
	 		else if(Answer.text == ""){
			// +を式欄に追記する
			Formula.text += subtractionButton.text;
		} else
		{
			Formula.text = "";
			Formula.text += Answer.text;
			Formula.text += subtractionButton.text;
		}
	}

	
	// 計算ボタン押下
	public void InputEqual(Text epual){

		// // +がないか、文字列の最後が+ならスルー★
		// if(!Formula.text.Contains("+")){
		// 	return;
		// }

		// // -がないか、文字列の最後が-ならスルー★
		// if(!Formula.text.Contains("-")){
		// 	return;
		// }
		
		// // ×がないか、文字列の最後が×ならスルー★
		// if(!Formula.text.Contains("×")){
		// 	return;
		// }
		
		// // ÷がないか、文字列の最後が÷ならスルー★
		// if(!Formula.text.Contains("÷")){
		// 	return;
		// }

		// 入力した式を割る数と割られる数に分ける
		// 数字が未入力か、すでに税込があればスルー
		// if(Formula.text == "" || Formula.text.Contains("税込")){
		// 	return;
		// }

		// // 税込を式欄に追記する
		// Formula.text += taxButton.text;


		string[] inputString = Formula.text.Split('-', '+', '×', '÷');
		decimal leftNumber = decimal.Parse(inputString[0]);
		decimal rightNumber = decimal.Parse(inputString[1]);

		// float leftNumber = float.Parse(inputString[0]);
		// float rightNumber = float.Parse(inputString[1]);
		

		// 割られる数がゼロならスルー
		if(rightNumber == 0){
			return;
		}

		decimal calculation = 0; 
		// float Calculation = 0;
	
     if(Formula.text.Contains("+"))
	 {// 和
	 		decimal l = leftNumber;
			decimal r = rightNumber;
			calculation = Math.Floor(l + r);
			Console.WriteLine(l + r); 
		// Calculation = leftNumber + rightNumber;	
	 }
     else if(Formula.text.Contains("-"))
	 {// 差
			decimal l = leftNumber;
			decimal r = rightNumber;
			calculation = Math.Floor(l - r);
			Console.WriteLine(l - r);
	 }
	 else if(Formula.text.Contains("×"))
	 {// 積
	 		decimal l = leftNumber;
			decimal r = rightNumber;
			calculation = Math.Floor(l * r);
			Console.WriteLine(l * r);	
  	 } 
		// 計算結果を表示
		Answer.text = calculation.ToString();
		// Answer.text = Calculation.ToString();
	
		
	if(Formula.text.Contains("÷"))
	 {	
		decimal remainder = 0;

		if(Formula.text.Contains("÷"))
	 {// 商
	 		decimal l = leftNumber;
			decimal r = rightNumber;
			calculation = Math.Floor(l / r);
			Console.WriteLine(l / r);
		// Calculation = leftNumber / rightNumber;
		// 余り
			decimal m = leftNumber;
			decimal h = rightNumber;
			remainder = Math.Floor(h % m);
			Console.WriteLine(h % m);
		// remainder = leftNumber % rightNumber;
	 }	

		Answer.text = calculation.ToString() + "…" + remainder.ToString(); 
	 }

	}

	public void TaxButtonDown(Text taxButton){

		// // 数字が未入力か、すでに税込があればスルー
		// if(Formula.text == "" || Formula.text.Contains("税込")){
		// 	return;
		// }
		
		// // 税込を式欄に追記する
		// Formula.text += taxButton.text;
		// Formula.text += "＝" ;

		if(Answer.text == ""){
			Formula.text += taxButton.text;
		} else
		{
			Formula.text = "";
			Formula.text = Answer.text;
			Formula.text += taxButton.text;
		}



		string[] inputString = Formula.text.Split(new String[]{"税込"} ,StringSplitOptions.None);
		decimal leftNumber = decimal.Parse(inputString[0]);

		// float Taxcalculation = 0;
		
		decimal taxcalculation = 0;
		if(Formula.text.Contains("税込")){
			decimal d = leftNumber;
			decimal tax = 1.10m;
			taxcalculation = Math.Floor(d * tax);
			Console.WriteLine(d * tax);
			// Taxcalculation = leftNumber * 1.08f;
			// Debug.Log("Taxcalculation");
		}
		Answer.text = taxcalculation.ToString();
		Debug.Log("Answer");


	}

	public void NoTaxButtonDown(Text notaxButton){

		// // 数字が未入力か、すでに税込があればスルー
		// if(Formula.text == "" || Formula.text.Contains("税抜")){
		// 	return;
		// }
		
		// // 税込を式欄に追記する
		// Formula.text += taxButton.text;

		if(Answer.text == ""){
			Formula.text += notaxButton.text;
		} else
		{
			Formula.text = "";
			Formula.text += Answer.text;
			Formula.text += notaxButton.text;
		}

		string[] inputString = Formula.text.Split(new String[]{"税抜"} ,StringSplitOptions.None);
		int leftNumber = int.Parse(inputString[0]);

		// float Taxcalculation = 0;
		decimal taxcalculation = 0;

		if(Formula.text.Contains("税抜")){
			decimal d = leftNumber;
			decimal tax = 1.10m;
			taxcalculation = Math.Floor(d / tax);
			Console.WriteLine(d / tax);
			// Taxcalculation = Math.Floor(leftNumber / 1.08f);
			// Debug.Log("Taxcalculation");
		}

		Answer.text = taxcalculation.ToString();
		Debug.Log("Answer");
	}

	// public void InputTaxtCalculation(Text tax){

	// 	// 入力した式を割る数と割られる数に分ける
	// 	string[] inputString = Answer.text.Split("税込");
	// 	int leftNumber = int.Parse(inputString[0]);

	// 	float Calculation = 0;

	// 	if(Answer.text.Contains("税込")){
	// 		// 税込
	// 		Calculation = leftNumber *1.08f;
  	// 	}
	// 	else if(Answer.text.Contains("税抜")){
	// 		// 税込
	// 		Calculation = leftNumber /1.08f;
  	// 	}

	// 	// 計算結果を表示
	// 	Answer.text = Calculation.ToString();  

	// }

	// クリアボタン押下
	public void InputClear(Text epual){                                                             
		// 初期化
		Formula.text = "";
		Answer.text = "";
	}

}
