//#include <iostream>
//#include <fstream>
//#include <string>
//#include <vector>
//
//using namespace std;
//
//int main() {
//
//	/*********************************
//	 * how to read a PPM file
//	 ********************************/
//
//
//	// open the file for reading
//	ifstream dataIn;
//	dataIn.open("dont_panic.ppm");
//
//	// read the P3 - we ignore it after this
//	string ppmHeader;
//	dataIn >> ppmHeader;
//
//	int width, height;
//	dataIn >> width >> height;
//
//	// read the 255 - we ignore it
//	string junk;
//	dataIn >> junk;
//
//	// vectors for the pixel colors.
//	vector<int> red;
//	vector<int> green;
//	vector<int> blue;
//
//	int r, g, b;
//	for (int row = 0; row < height; row++) {
//		for (int col = 0; col < width; col++) {
//			dataIn >> r >> g >> b;
//			red.push_back(r);
//			green.push_back(g);
//			blue.push_back(b);
//		}
//	}
//
//	dataIn.close();
//
//	// ------------ End Reading -------------
//
//	//-----------------------------------------------  
//	//-----------------------------------------------                                      
//
//	/*********************************
//	 * how to write a PPM file
//	 ********************************/
//
	//ofstream dataOut;
//	dataOut.open("copy.//pm");
//
//	dataOut << "P3" << endl;
//	dataOut << width << " " << height << endl;
//	dataOut << 255 << endl;
//
//	for (int row = 0; row < height; row++) {
//		for (int col = 0; col < width; col++) {
//			dataOut 
//				<< red[row * width + col] << " "
//				<< green[row * width + col] << " "
//				<< blue[row * width + col]
//				<< endl;
//		}
//	}
//
//	dataOut.close();
//
//	// ------------ End Reading -------------
//
//}
