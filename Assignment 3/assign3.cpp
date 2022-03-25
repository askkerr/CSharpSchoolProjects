#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <sstream>
// Austin Kerr
// Assignment 3
// This program takes PPM images and modifies them 1 of 6 choices to make a new PPM file

using namespace std;

void outputWelcomeBanner();
string getInputFilename();
string getOutputFilename(const string inputPPMfilename);
void getOperation(int& imageOperation);
void readPPMfile(const string inputPPMfilename, int& width,
	int& height, vector<int>& red, vector<int>& green, vector<int>& blue);
void writeCopyPPM(const string outputPPMfilename, int& width,
	int& height, vector<int>& red, vector<int>& green, vector<int>& blue);
void writeGrayPPM(const string outputPPMfilename, const int width, const int height,
	const vector<int>& red, const vector<int>& green, const vector<int>& blue);
void writeFlipHorizontalPPM(const string outputPPMfilename, const int width, const int height,
	const vector<int>& red, const vector<int>& green, const vector<int>& blue);
void writeFlipVerticalPPM(const string outputPPMfilename, const int width, const int height,
	const vector<int>& red, const vector<int>& green, const vector<int>& blue);
void writeRotate90PPM(const string outputPPMfilename, const int width, const int height,
	const vector<int>& red, const vector<int>& green, const vector<int>& blue);
void writeShrinkPPM(const string outputPPMfilename, const int width, const int height,
	const vector<int>& red, const vector<int>& green, const vector<int>& blue);


int main() {
	outputWelcomeBanner();
	
	const string inputPPMfilename = getInputFilename();
	const string outputPPMfilename = getOutputFilename(inputPPMfilename);
	
	int imageOperation;
	getOperation(imageOperation);

	vector<int> red;
	vector<int> green;
	vector<int> blue;
	int width, height;
	readPPMfile(inputPPMfilename, width, height, red, green, blue);

	switch (imageOperation) {
	case 1:
		writeGrayPPM(outputPPMfilename, width, height, red, green, blue);
		break;
	case 2:
		writeFlipHorizontalPPM(outputPPMfilename, width, height, red, green, blue);
		break;
	case 3:
		writeFlipVerticalPPM(outputPPMfilename, width, height, red, green, blue);
		break;
	case 4:
		writeRotate90PPM(outputPPMfilename, width, height, red, green, blue);
		break;
	case 5:
		writeShrinkPPM(outputPPMfilename, width, height, red, green, blue);
		break;
	case 6:
		writeCopyPPM(outputPPMfilename, width, height, red, green, blue);
		break;
	}
	cout << "File saved!" << endl;
}

void outputWelcomeBanner() {
	cout << "Welcome to Austin Kerr's PPM Code." << endl;
}

string getInputFilename() {
	string inputPPMfilename;
	cout << "Enter in your full PPM input file name:" << endl;
	getline(cin, inputPPMfilename);
	cout << "You entered: " << inputPPMfilename << endl;
	return(inputPPMfilename);
}

string getOutputFilename(const string inputPPMfilename) {
	string outputPPMfilename;
	cout << "Enter in a ppm file name for your output file: " << endl;
	getline(cin, outputPPMfilename);
	while (inputPPMfilename == outputPPMfilename) {
		cout << "Input name and output name cannot be the same. Enter a new name: " << endl;
		getline(cin, outputPPMfilename);
	}
	cout << "You entered: " << outputPPMfilename << endl;
	return(outputPPMfilename);
}

void getOperation(int& imageOperation) {
	cout << "Operations:\n   1. To gray scale\n   2. flip horizontal\n   3. flip vertical\n   " <<
		"4. rotate clockwise\n   5. half size\n   6. make copy\nEnter choice:" << endl;
	cin >> imageOperation;
	if (imageOperation == 1 || imageOperation == 2 || imageOperation == 3 || imageOperation == 4 || imageOperation == 5 || imageOperation == 6){
	}else{
		cout << "The choice you entered was invalid. Enter a new choice: " << endl;
		cin >> imageOperation;
	}
}

void readPPMfile(const string inputPPMfilename, int& width,
	int& height, vector<int>& red, vector<int>& green, vector<int>& blue) {

	ifstream dataIn;
	dataIn.open(inputPPMfilename);
	string ppmHeader;
	dataIn >> ppmHeader;
	dataIn >> width >> height;
	string junk;
	dataIn >> junk;
	int r, g, b;
	for (int row = 0; row < height; row++) {
		for (int col = 0; col < width; col++) {
			dataIn >> r >> g >> b;
			red.push_back(r);
			green.push_back(g);
			blue.push_back(b);
		}
	}
	dataIn.close();
}

void writeCopyPPM(const string outputPPMfilename, int& width,
	int& height, vector<int>& red, vector<int>& green, vector<int>& blue) {
	
	ofstream dataOut;
	dataOut.open(outputPPMfilename);

	dataOut << "P3" << endl;
	dataOut << width << " " << height << endl;
	dataOut << 255 << endl;

	for (int row = 0; row < height; row++) {
		for (int col = 0; col < width; col++) {
			dataOut 
				<< red[row * width + col] << " "
				<< green[row * width + col] << " "
				<< blue[row * width + col]
				<< endl;
		}
	}
	dataOut.close();
}

void writeGrayPPM(const string outputPPMfilename, const int width, const int height,
	const vector<int>& red, const vector<int>& green, const vector<int>& blue) {

	ofstream dataOut;
	dataOut.open(outputPPMfilename);

	dataOut << "P3" << endl;
	dataOut << width << " " << height << endl;
	dataOut << 255 << endl;

	int greyValue;

	for (int row = 0; row < height; row++) {
		for (int col = 0; col < width; col++) {
			greyValue = 0.21 * red[row * width + col] + 0.72 * green[row * width + col] + 0.07 * blue[row * width + col];
			dataOut
				<< greyValue << " "
				<< greyValue << " " 
				<< greyValue << " " 
				<< endl;
		}
	}
	dataOut.close();
}

void writeFlipHorizontalPPM(const string outputPPMfilename, const int width, const int height,
	const vector<int>& red, const vector<int>& green, const vector<int>& blue) {

	ofstream dataOut;
	dataOut.open(outputPPMfilename);

	dataOut << "P3" << endl;
	dataOut << width << " " << height << endl;
	dataOut << 255 << endl;



	for (int row = height - 1; row >= 0; row--){
		for (int col = 0; col < width; col++) {
			dataOut 
				<< red[row * width + col] << " "
				<< green[row * width + col] << " "
				<< blue[row * width + col]
				<< endl;
		}
	}
	dataOut.close();
}

void writeFlipVerticalPPM(const string outputPPMfilename, const int width, const int height,
	const vector<int>& red, const vector<int>& green, const vector<int>& blue) {
	ofstream dataOut;
	dataOut.open(outputPPMfilename);

	dataOut << "P3" << endl;
	dataOut << width << " " << height << endl;
	dataOut << 255 << endl;



	for (int row = 0; row < height; row++){
		for (int col = width - 1; col >= 0; col--){
			dataOut
				<< red[row * width + col] << " "
				<< green[row * width + col] << " "
				<< blue[row * width + col]
				<< endl;
		}
	}
	dataOut.close();
}

void writeRotate90PPM(const string outputPPMfilename, const int width, const int height,
	const vector<int>& red, const vector<int>& green, const vector<int>& blue) {
	ofstream dataOut;
	dataOut.open(outputPPMfilename);

	dataOut << "P3" << endl;
	dataOut << width << " " << height << endl;
	dataOut << 255 << endl;

	for (int col = 0; col < width; col++) {
		for (int row = height - 1; row >= 0; row--){
			dataOut
				<< red[row * width + col] << " "
				<< green[row * width + col] << " "
				<< blue[row * width + col]
				<< endl;
		}
	}
	dataOut.close();
}

void writeShrinkPPM(const string outputPPMfilename, const int width, const int height,
	const vector<int>& red, const vector<int>& green, const vector<int>& blue) {

	ofstream dataOut;
	dataOut.open(outputPPMfilename);

	dataOut << "P3" << endl;
	dataOut << width << " " << height << endl;
	dataOut << 255 << endl;

	for (int row = 0; row < height; row+= 2){
		for (int col = 0; col < width; col+= 2){
			dataOut
				<< red[row * width + col] << " "
				<< green[row * width + col] << " "
				<< blue[row * width + col]
				<< endl;
		}
	}
	dataOut.close();
}