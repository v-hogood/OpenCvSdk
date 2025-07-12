using System;
using AVFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace OpenCvSdk
{
	[Static]
	partial interface Constants
	{
		// extern double opencv2VersionNumber;
		[Field ("opencv2VersionNumber", "opencv2")]
		double Opencv2VersionNumber { get; }

		// extern const unsigned char[] opencv2VersionString;
		[Field ("opencv2VersionString", "opencv2")]
		IntPtr Opencv2VersionString { get; }
	}

	// @interface Mat : NSObject
	[BaseType (typeof(NSObject))]
	interface Mat : INativeObject
	{
		// -(instancetype _Nonnull)initWithRows:(int)rows cols:(int)cols type:(int)type;
		[Export ("initWithRows:cols:type:")]
		NativeHandle Constructor (int rows, int cols, int type);

		// -(instancetype _Nonnull)initWithRows:(int)rows cols:(int)cols type:(int)type data:(NSData * _Nonnull)data;
		[Export ("initWithRows:cols:type:data:")]
		NativeHandle Constructor (int rows, int cols, int type, NSData data);

		// -(instancetype _Nonnull)initWithRows:(int)rows cols:(int)cols type:(int)type data:(NSData * _Nonnull)data step:(long)step;
		[Export ("initWithRows:cols:type:data:step:")]
		NativeHandle Constructor (int rows, int cols, int type, NSData data, nint step);

		// -(instancetype _Nonnull)initWithSize:(Size2i * _Nonnull)size type:(int)type;
		[Export ("initWithSize:type:")]
		NativeHandle Constructor (Size2i size, int type);

		// -(instancetype _Nonnull)initWithSizes:(NSArray<NSNumber *> * _Nonnull)sizes type:(int)type;
		[Export ("initWithSizes:type:")]
		NativeHandle Constructor (NSNumber[] sizes, int type);

		// -(instancetype _Nonnull)initWithRows:(int)rows cols:(int)cols type:(int)type scalar:(Scalar * _Nonnull)scalar;
		[Export ("initWithRows:cols:type:scalar:")]
		NativeHandle Constructor (int rows, int cols, int type, Scalar scalar);

		// -(instancetype _Nonnull)initWithSize:(Size2i * _Nonnull)size type:(int)type scalar:(Scalar * _Nonnull)scalar;
		[Export ("initWithSize:type:scalar:")]
		NativeHandle Constructor (Size2i size, int type, Scalar scalar);

		// -(instancetype _Nonnull)initWithSizes:(NSArray<NSNumber *> * _Nonnull)sizes type:(int)type scalar:(Scalar * _Nonnull)scalar;
		[Export ("initWithSizes:type:scalar:")]
		NativeHandle Constructor (NSNumber[] sizes, int type, Scalar scalar);

		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat rowRange:(Range * _Nonnull)rowRange colRange:(Range * _Nonnull)colRange;
		[Export ("initWithMat:rowRange:colRange:")]
		NativeHandle Constructor (Mat mat, Range rowRange, Range colRange);

		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat rowRange:(Range * _Nonnull)rowRange;
		[Export ("initWithMat:rowRange:")]
		NativeHandle Constructor (Mat mat, Range rowRange);

		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat ranges:(NSArray<Range *> * _Nonnull)ranges;
		[Export ("initWithMat:ranges:")]
		NativeHandle Constructor (Mat mat, Range[] ranges);

		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat rect:(Rect2i * _Nonnull)roi;
		[Export ("initWithMat:rect:")]
		NativeHandle Constructor (Mat mat, Rect2i roi);

		// -(Mat * _Nonnull)adjustRoiTop:(int)dtop bottom:(int)dbottom left:(int)dleft right:(int)dright __attribute__((swift_name("adjustRoi(top:bottom:left:right:)")));
		[Export ("adjustRoiTop:bottom:left:right:")]
		Mat AdjustRoiTop (int dtop, int dbottom, int dleft, int dright);

		// -(void)assignTo:(Mat * _Nonnull)mat type:(int)type;
		[Export ("assignTo:type:")]
		void AssignTo (Mat mat, int type);

		// -(void)assignTo:(Mat * _Nonnull)mat;
		[Export ("assignTo:")]
		void AssignTo (Mat mat);

		// -(BOOL)isSameMat:(Mat * _Nonnull)mat;
		[Export ("isSameMat:")]
		bool IsSameMat (Mat mat);

		// -(int)channels;
		[Export ("channels")]
		int Channels { get; }

		// -(int)checkVector:(int)elemChannels depth:(int)depth requireContinuous:(BOOL)requireContinuous __attribute__((swift_name("checkVector(elemChannels:depth:requireContinuous:)")));
		[Export ("checkVector:depth:requireContinuous:")]
		int CheckVector (int elemChannels, int depth, bool requireContinuous);

		// -(int)checkVector:(int)elemChannels depth:(int)depth __attribute__((swift_name("checkVector(elemChannels:depth:)")));
		[Export ("checkVector:depth:")]
		int CheckVector (int elemChannels, int depth);

		// -(int)checkVector:(int)elemChannels __attribute__((swift_name("checkVector(elemChannels:)")));
		[Export ("checkVector:")]
		int CheckVector (int elemChannels);

		// -(Mat * _Nonnull)clone;
		[Export ("clone")]
		Mat Clone ();

		// -(Mat * _Nonnull)col:(int)x;
		[Export ("col:")]
		Mat Col (int x);

		// -(Mat * _Nonnull)colRange:(int)start end:(int)end __attribute__((swift_name("colRange(start:end:)")));
		[Export ("colRange:end:")]
		Mat ColRange (int start, int end);

		// -(Mat * _Nonnull)colRange:(Range * _Nonnull)range;
		[Export ("colRange:")]
		Mat ColRange (Range range);

		// -(int)dims;
		[Export ("dims")]
		int Dims { get; }

		// -(int)cols;
		[Export ("cols")]
		int Cols { get; }

		// -(void)convertTo:(Mat * _Nonnull)mat rtype:(int)rtype alpha:(double)alpha beta:(double)beta;
		[Export ("convertTo:rtype:alpha:beta:")]
		void ConvertTo (Mat mat, int rtype, double alpha, double beta);

		// -(void)convertTo:(Mat * _Nonnull)mat rtype:(int)rtype alpha:(double)alpha;
		[Export ("convertTo:rtype:alpha:")]
		void ConvertTo (Mat mat, int rtype, double alpha);

		// -(void)convertTo:(Mat * _Nonnull)mat rtype:(int)rtype;
		[Export ("convertTo:rtype:")]
		void ConvertTo (Mat mat, int rtype);

		// -(void)copyTo:(Mat * _Nonnull)mat;
		[Export ("copyTo:")]
		void CopyTo (Mat mat);

		// -(void)copyTo:(Mat * _Nonnull)mat mask:(Mat * _Nonnull)mask;
		[Export ("copyTo:mask:")]
		void CopyTo (Mat mat, Mat mask);

		// -(void)create:(int)rows cols:(int)cols type:(int)type __attribute__((swift_name("create(rows:cols:type:)")));
		[Export ("create:cols:type:")]
		void Create (int rows, int cols, int type);

		// -(void)create:(Size2i * _Nonnull)size type:(int)type __attribute__((swift_name("create(size:type:)")));
		[Export ("create:type:")]
		void Create (Size2i size, int type);

		// -(void)createEx:(NSArray<NSNumber *> * _Nonnull)sizes type:(int)type __attribute__((swift_name("create(sizes:type:)")));
		[Export ("createEx:type:")]
		void CreateEx (NSNumber[] sizes, int type);

		// -(void)copySize:(Mat * _Nonnull)mat;
		[Export ("copySize:")]
		void CopySize (Mat mat);

		// -(Mat * _Nonnull)cross:(Mat * _Nonnull)mat;
		[Export ("cross:")]
		Mat Cross (Mat mat);

		// -(unsigned char * _Nonnull)dataPtr __attribute__((swift_name("dataPointer()")));
		[Export ("dataPtr")]
		unsafe NativeHandle DataPtr { get; }

		// -(int)depth;
		[Export ("depth")]
		int Depth { get; }

		// -(Mat * _Nonnull)diag:(int)diagonal;
		[Export ("diag:")]
		Mat Diag (int diagonal);

		// -(Mat * _Nonnull)diag;
		[Export ("diag")]
		Mat Diag ();

		// +(Mat * _Nonnull)diag:(Mat * _Nonnull)diagonal;
		[Static]
		[Export ("diag:")]
		Mat Diag (Mat diagonal);

		// -(double)dot:(Mat * _Nonnull)mat;
		[Export ("dot:")]
		double Dot (Mat mat);

		// -(long)elemSize;
		[Export ("elemSize")]
		nint ElemSize { get; }

		// -(long)elemSize1;
		[Export ("elemSize1")]
		nint ElemSize1 { get; }

		// -(BOOL)empty;
		[Export ("empty")]
		bool Empty { get; }

		// +(Mat * _Nonnull)eye:(int)rows cols:(int)cols type:(int)type __attribute__((swift_name("eye(rows:cols:type:)")));
		[Static]
		[Export ("eye:cols:type:")]
		Mat Eye (int rows, int cols, int type);

		// +(Mat * _Nonnull)eye:(Size2i * _Nonnull)size type:(int)type __attribute__((swift_name("eye(size:type:)")));
		[Static]
		[Export ("eye:type:")]
		Mat Eye (Size2i size, int type);

		// -(Mat * _Nonnull)inv:(int)method;
		[Export ("inv:")]
		Mat Inv (int method);

		// -(Mat * _Nonnull)inv;
		[Export ("inv")]
		Mat Inv ();

		// -(BOOL)isContinuous;
		[Export ("isContinuous")]
		bool IsContinuous { get; }

		// -(BOOL)isSubmatrix;
		[Export ("isSubmatrix")]
		bool IsSubmatrix { get; }

		// -(void)locateROI:(Size2i * _Nonnull)wholeSize ofs:(Point2i * _Nonnull)offset __attribute__((swift_name("locateROI(wholeSize:offset:)")));
		[Export ("locateROI:ofs:")]
		void LocateROI (Size2i wholeSize, Point2i offset);

		// -(Mat * _Nonnull)mul:(Mat * _Nonnull)mat scale:(double)scale;
		[Export ("mul:scale:")]
		Mat Mul (Mat mat, double scale);

		// -(Mat * _Nonnull)mul:(Mat * _Nonnull)mat;
		[Export ("mul:")]
		Mat Mul (Mat mat);

		// -(Mat * _Nonnull)matMul:(Mat * _Nonnull)mat;
		[Export ("matMul:")]
		Mat MatMul (Mat mat);

		// +(Mat * _Nonnull)ones:(int)rows cols:(int)cols type:(int)type __attribute__((swift_name("ones(rows:cols:type:)")));
		[Static]
		[Export ("ones:cols:type:")]
		Mat Ones (int rows, int cols, int type);

		// +(Mat * _Nonnull)ones:(Size2i * _Nonnull)size type:(int)type __attribute__((swift_name("ones(size:type:)")));
		[Static]
		[Export ("ones:type:")]
		Mat Ones (Size2i size, int type);

		// +(Mat * _Nonnull)onesEx:(NSArray<NSNumber *> * _Nonnull)sizes type:(int)type __attribute__((swift_name("ones(sizes:type:)")));
		[Static]
		[Export ("onesEx:type:")]
		Mat OnesEx (NSNumber[] sizes, int type);

		// -(void)push_back:(Mat * _Nonnull)mat;
		[Export ("push_back:")]
		void Push_back (Mat mat);

		// -(Mat * _Nonnull)reshape:(int)channels rows:(int)rows __attribute__((swift_name("reshape(channels:rows:)")));
		[Export ("reshape:rows:")]
		Mat Reshape (int channels, int rows);

		// -(Mat * _Nonnull)reshape:(int)channels __attribute__((swift_name("reshape(channels:)")));
		[Export ("reshape:")]
		Mat Reshape (int channels);

		// -(Mat * _Nonnull)reshape:(int)channels newshape:(NSArray<NSNumber *> * _Nonnull)newshape __attribute__((swift_name("reshape(channels:newshape:)")));
		[Export ("reshape:newshape:")]
		Mat Reshape (int channels, NSNumber[] newshape);

		// -(Mat * _Nonnull)row:(int)y;
		[Export ("row:")]
		Mat Row (int y);

		// -(Mat * _Nonnull)rowRange:(int)start end:(int)end __attribute__((swift_name("rowRange(start:end:)")));
		[Export ("rowRange:end:")]
		Mat RowRange (int start, int end);

		// -(Mat * _Nonnull)rowRange:(Range * _Nonnull)range;
		[Export ("rowRange:")]
		Mat RowRange (Range range);

		// -(int)rows;
		[Export ("rows")]
		int Rows { get; }

		// -(Mat * _Nonnull)setToScalar:(Scalar * _Nonnull)scalar __attribute__((swift_name("setTo(scalar:)")));
		[Export ("setToScalar:")]
		Mat SetToScalar (Scalar scalar);

		// -(Mat * _Nonnull)setToScalar:(Scalar * _Nonnull)scalar mask:(Mat * _Nonnull)mask __attribute__((swift_name("setTo(scalar:mask:)")));
		[Export ("setToScalar:mask:")]
		Mat SetToScalar (Scalar scalar, Mat mask);

		// -(Mat * _Nonnull)setToValue:(Mat * _Nonnull)value mask:(Mat * _Nonnull)mask __attribute__((swift_name("setTo(value:mask:)")));
		[Export ("setToValue:mask:")]
		Mat SetToValue (Mat value, Mat mask);

		// -(Mat * _Nonnull)setToValue:(Mat * _Nonnull)value __attribute__((swift_name("setTo(value:)")));
		[Export ("setToValue:")]
		Mat SetToValue (Mat value);

		// -(Size2i * _Nonnull)size;
		[Export ("size")]
		Size2i Size ();

		// -(int)size:(int)dim;
		[Export ("size:")]
		int Size (int dim);

		// -(long)step1:(int)dim;
		[Export ("step1:")]
		nint Step1 (int dim);

		// -(long)step1;
		[Export ("step1")]
		nint Step1 ();

		// -(Mat * _Nonnull)submat:(int)rowStart rowEnd:(int)rowEnd colStart:(int)colStart colEnd:(int)colEnd __attribute__((swift_name("submat(rowStart:rowEnd:colStart:colEnd:)")));
		[Export ("submat:rowEnd:colStart:colEnd:")]
		Mat Submat (int rowStart, int rowEnd, int colStart, int colEnd);

		// -(Mat * _Nonnull)submat:(Range * _Nonnull)rowRange colRange:(Range * _Nonnull)colRange __attribute__((swift_name("submat(rowRange:colRange:)")));
		[Export ("submat:colRange:")]
		Mat Submat (Range rowRange, Range colRange);

		// -(Mat * _Nonnull)submat:(NSArray<Range *> * _Nonnull)ranges __attribute__((swift_name("submat(ranges:)")));
		[Export ("submat:")]
		Mat Submat (Range[] ranges);

		// -(Mat * _Nonnull)submatRoi:(Rect2i * _Nonnull)roi __attribute__((swift_name("submat(roi:)")));
		[Export ("submatRoi:")]
		Mat SubmatRoi (Rect2i roi);

		// -(Mat * _Nonnull)t;
		[Export ("t")]
		Mat T { get; }

		// -(long)total;
		[Export ("total")]
		nint Total { get; }

		// -(int)type;
		[Export ("type")]
		int Type { get; }

		// +(Mat * _Nonnull)zeros:(int)rows cols:(int)cols type:(int)type;
		[Static]
		[Export ("zeros:cols:type:")]
		Mat Zeros (int rows, int cols, int type);

		// +(Mat * _Nonnull)zeros:(Size2i * _Nonnull)size type:(int)type;
		[Static]
		[Export ("zeros:type:")]
		Mat Zeros (Size2i size, int type);

		// +(Mat * _Nonnull)zerosEx:(NSArray<NSNumber *> * _Nonnull)sizes type:(int)type __attribute__((swift_name("zeros(sizes:type:)")));
		[Static]
		[Export ("zerosEx:type:")]
		Mat ZerosEx (NSNumber[] sizes, int type);

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }

		// -(NSString * _Nonnull)dump;
		[Export ("dump")]
		string Dump ();

		// -(int)height;
		[Export ("height")]
		int Height { get; }

		// -(int)width;
		[Export ("width")]
		int Width { get; }

		// -(int)put:(int)row col:(int)col data:(NSArray<NSNumber *> * _Nonnull)data __attribute__((swift_private));
		[Export ("put:col:data:")]
		int Put (int row, int col, NSNumber[] data);

		// -(int)put:(NSArray<NSNumber *> * _Nonnull)indices data:(NSArray<NSNumber *> * _Nonnull)data __attribute__((swift_private));
		[Export ("put:data:")]
		int Put (NSNumber[] indices, NSNumber[] data);

		// -(int)get:(int)row col:(int)col data:(NSMutableArray<NSNumber *> * _Nonnull)data __attribute__((swift_private));
		[Export ("get:col:data:")]
		int Get (int row, int col, NSMutableArray<NSNumber> data);

		// -(int)get:(NSArray<NSNumber *> * _Nonnull)indices data:(NSMutableArray<NSNumber *> * _Nonnull)data __attribute__((swift_private));
		[Export ("get:data:")]
		int Get (NSNumber[] indices, NSMutableArray<NSNumber> data);

		// -(NSArray<NSNumber *> * _Nonnull)get:(int)row col:(int)col __attribute__((swift_private));
		[Export ("get:col:")]
		NSNumber[] Get (int row, int col);

		// -(NSArray<NSNumber *> * _Nonnull)get:(NSArray<NSNumber *> * _Nonnull)indices __attribute__((swift_private));
		[Export ("get:")]
		NSNumber[] Get (NSNumber[] indices);

		// -(int)get:(NSArray<NSNumber *> * _Nonnull)indices count:(int)count byteBuffer:(char * _Nonnull)buffer __attribute__((swift_private));
		[Export ("get:count:byteBuffer:")]
		unsafe int Get (NSNumber[] indices, int count, sbyte* buffer);

		// -(int)get:(NSArray<NSNumber *> * _Nonnull)indices count:(int)count doubleBuffer:(double * _Nonnull)buffer __attribute__((swift_private));
		[Export ("get:count:doubleBuffer:")]
		unsafe int Get (NSNumber[] indices, int count, double* buffer);

		// -(int)get:(NSArray<NSNumber *> * _Nonnull)indices count:(int)count floatBuffer:(float * _Nonnull)buffer __attribute__((swift_private));
		[Export ("get:count:floatBuffer:")]
		unsafe int Get (NSNumber[] indices, int count, float* buffer);

		// -(int)get:(NSArray<NSNumber *> * _Nonnull)indices count:(int)count intBuffer:(int * _Nonnull)buffer __attribute__((swift_private));
		[Export ("get:count:intBuffer:")]
		unsafe int Get (NSNumber[] indices, int count, int* buffer);

		// -(int)get:(NSArray<NSNumber *> * _Nonnull)indices count:(int)count shortBuffer:(short * _Nonnull)buffer __attribute__((swift_private));
		[Export ("get:count:shortBuffer:")]
		unsafe int Get (NSNumber[] indices, int count, short* buffer);

		// -(int)put:(NSArray<NSNumber *> * _Nonnull)indices count:(int)count byteBuffer:(const char * _Nonnull)buffer __attribute__((swift_private));
		[Export ("put:count:byteBuffer:")]
		unsafe int Put (NSNumber[] indices, int count, sbyte* buffer);

		// -(int)put:(NSArray<NSNumber *> * _Nonnull)indices count:(int)count doubleBuffer:(const double * _Nonnull)buffer __attribute__((swift_private));
		[Export ("put:count:doubleBuffer:")]
		unsafe int Put (NSNumber[] indices, int count, double* buffer);

		// -(int)put:(NSArray<NSNumber *> * _Nonnull)indices count:(int)count floatBuffer:(const float * _Nonnull)buffer __attribute__((swift_private));
		[Export ("put:count:floatBuffer:")]
		unsafe int Put (NSNumber[] indices, int count, float* buffer);

		// -(int)put:(NSArray<NSNumber *> * _Nonnull)indices count:(int)count intBuffer:(const int * _Nonnull)buffer __attribute__((swift_private));
		[Export ("put:count:intBuffer:")]
		unsafe int Put (NSNumber[] indices, int count, int* buffer);

		// -(int)put:(NSArray<NSNumber *> * _Nonnull)indices count:(int)count shortBuffer:(const short * _Nonnull)buffer __attribute__((swift_private));
		[Export ("put:count:shortBuffer:")]
		unsafe int Put (NSNumber[] indices, int count, short* buffer);

		// -(CGImageRef _Nonnull)toCGImage __attribute__((cf_returns_retained));
		[Export ("toCGImage")]
		CGImage ToCGImage ();

		// -(instancetype _Nonnull)initWithCGImage:(CGImageRef _Nonnull)image;
		[Export ("initWithCGImage:")]
		NativeHandle Constructor (CGImage image);

		// -(instancetype _Nonnull)initWithCGImage:(CGImageRef _Nonnull)image alphaExist:(BOOL)alphaExist;
		[Export ("initWithCGImage:alphaExist:")]
		NativeHandle Constructor (CGImage image, bool alphaExist);

		// -(UIImage * _Nonnull)toUIImage;
		[Export ("toUIImage")]
		UIImage ToUIImage ();

		// -(instancetype _Nonnull)initWithUIImage:(UIImage * _Nonnull)image;
		[Export ("initWithUIImage:")]
		NativeHandle Constructor (UIImage image);

		// -(instancetype _Nonnull)initWithUIImage:(UIImage * _Nonnull)image alphaExist:(BOOL)alphaExist;
		[Export ("initWithUIImage:alphaExist:")]
		NativeHandle Constructor (UIImage image, bool alphaExist);

		// -(id _Nonnull)debugQuickLookObject;
		[Export ("debugQuickLookObject")]
		NSObject DebugQuickLookObject { get; }
	}

	// @interface MatOfRect2d : Mat
	[BaseType (typeof(Mat))]
	interface MatOfRect2d
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<Rect2d *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (Rect2d[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<Rect2d *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (Rect2d[] array);

		// -(NSArray<Rect2d *> * _Nonnull)toArray;
		[Export ("toArray")]
		Rect2d[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface MatOfFloat4 : Mat
	[BaseType (typeof(Mat))]
	interface MatOfFloat4
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<NSNumber *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (NSNumber[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<NSNumber *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (NSNumber[] array);

		// -(NSArray<NSNumber *> * _Nonnull)toArray;
		[Export ("toArray")]
		NSNumber[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface MatOfPoint2i : Mat
	[BaseType (typeof(Mat))]
	interface MatOfPoint2i
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<Point2i *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (Point2i[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<Point2i *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (Point2i[] array);

		// -(NSArray<Point2i *> * _Nonnull)toArray;
		[Export ("toArray")]
		Point2i[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface Double3 : NSObject
	[BaseType (typeof(NSObject))]
	interface Double3
	{
		// @property double v0;
		[Export ("v0")]
		double V0 { get; set; }

		// @property double v1;
		[Export ("v1")]
		double V1 { get; set; }

		// @property double v2;
		[Export ("v2")]
		double V2 { get; set; }

		// -(instancetype _Nonnull)initWithV0:(double)v0 v1:(double)v1 v2:(double)v2;
		[Export ("initWithV0:v1:v2:")]
		NativeHandle Constructor (double v0, double v1, double v2);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(NSArray<NSNumber *> * _Nonnull)get;
		[Export ("get")]
		NSNumber[] Get ();

		// -(BOOL)isEqual:(id _Nullable)other;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);
	}

	// @interface MatOfByte : Mat
	[BaseType (typeof(Mat))]
	interface MatOfByte
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<NSNumber *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (NSNumber[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<NSNumber *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (NSNumber[] array);

		// -(NSArray<NSNumber *> * _Nonnull)toArray;
		[Export ("toArray")]
		NSNumber[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface Range : NSObject
	[BaseType (typeof(NSObject))]
	interface Range
	{
		// @property int start;
		[Export ("start")]
		int Start { get; set; }

		// @property int end;
		[Export ("end")]
		int End { get; set; }

		// -(instancetype _Nonnull)initWithStart:(int)start end:(int)end;
		[Export ("initWithStart:end:")]
		NativeHandle Constructor (int start, int end);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(int)size;
		[Export ("size")]
		int Size { get; }

		// -(BOOL)empty;
		[Export ("empty")]
		bool Empty { get; }

		// +(Range * _Nonnull)all;
		[Static]
		[Export ("all")]
		Range All { get; }

		// -(Range * _Nonnull)intersection:(Range * _Nonnull)r1;
		[Export ("intersection:")]
		Range Intersection (Range r1);

		// -(Range * _Nonnull)shift:(int)delta;
		[Export ("shift:")]
		Range Shift (int delta);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(Range * _Nonnull)clone;
		[Export ("clone")]
		Range Clone ();

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface Size2f : NSObject
	[BaseType (typeof(NSObject))]
	interface Size2f
	{
		// @property float width;
		[Export ("width")]
		float Width { get; set; }

		// @property float height;
		[Export ("height")]
		float Height { get; set; }

		// -(instancetype _Nonnull)initWithWidth:(float)width height:(float)height;
		[Export ("initWithWidth:height:")]
		NativeHandle Constructor (float width, float height);

		// -(instancetype _Nonnull)initWithPoint:(Point2f * _Nonnull)point;
		[Export ("initWithPoint:")]
		NativeHandle Constructor (Point2f point);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// +(instancetype _Nonnull)width:(float)width height:(float)height;
		[Static]
		[Export ("width:height:")]
		Size2f WidthHeight (float width, float height);

		// -(double)area;
		[Export ("area")]
		double Area { get; }

		// -(BOOL)empty;
		[Export ("empty")]
		bool Empty { get; }

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(Size2f * _Nonnull)clone;
		[Export ("clone")]
		Size2f Clone ();

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface CvType : NSObject
	[BaseType (typeof(NSObject))]
	partial interface CvType
	{
		// +(int)makeType:(int)depth channels:(int)channels;
		[Static]
		[Export ("makeType:channels:")]
		int MakeType (int depth, int channels);

		// +(int)channels:(int)type;
		[Static]
		[Export ("channels:")]
		int Channels (int type);

		// +(int)depth:(int)type;
		[Static]
		[Export ("depth:")]
		int Depth (int type);

		// +(int)rawTypeSize:(int)type;
		[Static]
		[Export ("rawTypeSize:")]
		int RawTypeSize (int type);

		// +(BOOL)isInteger:(int)type;
		[Static]
		[Export ("isInteger:")]
		bool IsInteger (int type);

		// +(int)ELEM_SIZE:(int)type __attribute__((swift_name("elemSize(_:)")));
		[Static]
		[Export ("ELEM_SIZE:")]
		int ELEM_SIZE (int type);

		// +(NSString * _Nonnull)typeToString:(int)type;
		[Static]
		[Export ("typeToString:")]
		string TypeToString (int type);
	}

	// @interface Point2i : NSObject
	[BaseType (typeof(NSObject))]
	interface Point2i : INativeObject
	{
		// @property int x;
		[Export ("x")]
		int X { get; set; }

		// @property int y;
		[Export ("y")]
		int Y { get; set; }

		// -(instancetype _Nonnull)initWithX:(int)x y:(int)y;
		[Export ("initWithX:y:")]
		NativeHandle Constructor (int x, int y);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(double)dot:(Point2i * _Nonnull)point;
		[Export ("dot:")]
		double Dot (Point2i point);

		// -(BOOL)inside:(Rect2i * _Nonnull)rect;
		[Export ("inside:")]
		bool Inside (Rect2i rect);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(Point2i * _Nonnull)clone;
		[Export ("clone")]
		Point2i Clone ();

		// -(BOOL)isEqual:(id _Nullable)other;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface Point2f : NSObject
	[BaseType (typeof(NSObject))]
	interface Point2f : INativeObject
	{
		// @property float x;
		[Export ("x")]
		float X { get; set; }

		// @property float y;
		[Export ("y")]
		float Y { get; set; }

		// -(instancetype _Nonnull)initWithX:(float)x y:(float)y;
		[Export ("initWithX:y:")]
		NativeHandle Constructor (float x, float y);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(double)dot:(Point2f * _Nonnull)point;
		[Export ("dot:")]
		double Dot (Point2f point);

		// -(BOOL)inside:(Rect2f * _Nonnull)rect;
		[Export ("inside:")]
		bool Inside (Rect2f rect);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(Point2f * _Nonnull)clone;
		[Export ("clone")]
		Point2f Clone ();

		// -(BOOL)isEqual:(id _Nullable)other;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface Point2d : NSObject
	[BaseType (typeof(NSObject))]
	interface Point2d
	{
		// @property double x;
		[Export ("x")]
		double X { get; set; }

		// @property double y;
		[Export ("y")]
		double Y { get; set; }

		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y;
		[Export ("initWithX:y:")]
		NativeHandle Constructor (double x, double y);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(double)dot:(Point2d * _Nonnull)point;
		[Export ("dot:")]
		double Dot (Point2d point);

		// -(BOOL)inside:(Rect2d * _Nonnull)rect;
		[Export ("inside:")]
		bool Inside (Rect2d rect);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(Point2d * _Nonnull)clone;
		[Export ("clone")]
		Point2d Clone ();

		// -(BOOL)isEqual:(id _Nullable)other;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface Point3i : NSObject
	[BaseType (typeof(NSObject))]
	interface Point3i
	{
		// @property int x;
		[Export ("x")]
		int X { get; set; }

		// @property int y;
		[Export ("y")]
		int Y { get; set; }

		// @property int z;
		[Export ("z")]
		int Z { get; set; }

		// -(instancetype _Nonnull)initWithX:(int)x y:(int)y z:(int)z;
		[Export ("initWithX:y:z:")]
		NativeHandle Constructor (int x, int y, int z);

		// -(instancetype _Nonnull)initWithPoint:(Point2i * _Nonnull)point;
		[Export ("initWithPoint:")]
		NativeHandle Constructor (Point2i point);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(double)dot:(Point3i * _Nonnull)point;
		[Export ("dot:")]
		double Dot (Point3i point);

		// -(Point3i * _Nonnull)cross:(Point3i * _Nonnull)point;
		[Export ("cross:")]
		Point3i Cross (Point3i point);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(Point3i * _Nonnull)clone;
		[Export ("clone")]
		Point3i Clone ();

		// -(BOOL)isEqual:(id _Nullable)other;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface Point3f : NSObject
	[BaseType (typeof(NSObject))]
	interface Point3f : INativeObject
	{
		// @property float x;
		[Export ("x")]
		float X { get; set; }

		// @property float y;
		[Export ("y")]
		float Y { get; set; }

		// @property float z;
		[Export ("z")]
		float Z { get; set; }

		// -(instancetype _Nonnull)initWithX:(float)x y:(float)y z:(float)z;
		[Export ("initWithX:y:z:")]
		NativeHandle Constructor (float x, float y, float z);

		// -(instancetype _Nonnull)initWithPoint:(Point2f * _Nonnull)point;
		[Export ("initWithPoint:")]
		NativeHandle Constructor (Point2f point);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(double)dot:(Point3f * _Nonnull)point;
		[Export ("dot:")]
		double Dot (Point3f point);

		// -(Point3f * _Nonnull)cross:(Point3f * _Nonnull)point;
		[Export ("cross:")]
		Point3f Cross (Point3f point);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(Point3f * _Nonnull)clone;
		[Export ("clone")]
		Point3f Clone ();

		// -(BOOL)isEqual:(id _Nullable)other;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface Point3d : NSObject
	[BaseType (typeof(NSObject))]
	interface Point3d
	{
		// @property double x;
		[Export ("x")]
		double X { get; set; }

		// @property double y;
		[Export ("y")]
		double Y { get; set; }

		// @property double z;
		[Export ("z")]
		double Z { get; set; }

		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y z:(double)z;
		[Export ("initWithX:y:z:")]
		NativeHandle Constructor (double x, double y, double z);

		// -(instancetype _Nonnull)initWithPoint:(Point2d * _Nonnull)point;
		[Export ("initWithPoint:")]
		NativeHandle Constructor (Point2d point);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(double)dot:(Point3d * _Nonnull)point;
		[Export ("dot:")]
		double Dot (Point3d point);

		// -(Point3d * _Nonnull)cross:(Point3d * _Nonnull)point;
		[Export ("cross:")]
		Point3d Cross (Point3d point);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(Point3d * _Nonnull)clone;
		[Export ("clone")]
		Point3d Clone ();

		// -(BOOL)isEqual:(id _Nullable)other;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface Rect2i : NSObject
	[BaseType (typeof(NSObject))]
	interface Rect2i : INativeObject
	{
		// @property int x;
		[Export ("x")]
		int X { get; set; }

		// @property int y;
		[Export ("y")]
		int Y { get; set; }

		// @property int width;
		[Export ("width")]
		int Width { get; set; }

		// @property int height;
		[Export ("height")]
		int Height { get; set; }

		// -(instancetype _Nonnull)initWithX:(int)x y:(int)y width:(int)width height:(int)height;
		[Export ("initWithX:y:width:height:")]
		NativeHandle Constructor (int x, int y, int width, int height);

		// -(instancetype _Nonnull)initWithPoint:(Point2i * _Nonnull)point1 point:(Point2i * _Nonnull)point2;
		[Export ("initWithPoint:point:")]
		NativeHandle Constructor (Point2i point1, Point2i point2);

		// -(instancetype _Nonnull)initWithPoint:(Point2i * _Nonnull)point size:(Size2i * _Nonnull)size;
		[Export ("initWithPoint:size:")]
		NativeHandle Constructor (Point2i point, Size2i size);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(Point2i * _Nonnull)tl;
		[Export ("tl")]
		Point2i Tl { get; }

		// -(Point2i * _Nonnull)br;
		[Export ("br")]
		Point2i Br { get; }

		// -(Size2i * _Nonnull)size;
		[Export ("size")]
		Size2i Size { get; }

		// -(double)area;
		[Export ("area")]
		double Area { get; }

		// -(BOOL)empty;
		[Export ("empty")]
		bool Empty { get; }

		// -(BOOL)contains:(Point2i * _Nonnull)point;
		[Export ("contains:")]
		bool Contains (Point2i point);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(Rect2i * _Nonnull)clone;
		[Export ("clone")]
		Rect2i Clone ();

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface Rect2d : NSObject
	[BaseType (typeof(NSObject))]
	interface Rect2d
	{
		// @property double x;
		[Export ("x")]
		double X { get; set; }

		// @property double y;
		[Export ("y")]
		double Y { get; set; }

		// @property double width;
		[Export ("width")]
		double Width { get; set; }

		// @property double height;
		[Export ("height")]
		double Height { get; set; }

		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y width:(double)width height:(double)height;
		[Export ("initWithX:y:width:height:")]
		NativeHandle Constructor (double x, double y, double width, double height);

		// -(instancetype _Nonnull)initWithPoint:(Point2d * _Nonnull)point1 point:(Point2d * _Nonnull)point2;
		[Export ("initWithPoint:point:")]
		NativeHandle Constructor (Point2d point1, Point2d point2);

		// -(instancetype _Nonnull)initWithPoint:(Point2d * _Nonnull)point size:(Size2d * _Nonnull)size;
		[Export ("initWithPoint:size:")]
		NativeHandle Constructor (Point2d point, Size2d size);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(Point2d * _Nonnull)tl;
		[Export ("tl")]
		Point2d Tl { get; }

		// -(Point2d * _Nonnull)br;
		[Export ("br")]
		Point2d Br { get; }

		// -(Size2d * _Nonnull)size;
		[Export ("size")]
		Size2d Size { get; }

		// -(double)area;
		[Export ("area")]
		double Area { get; }

		// -(BOOL)empty;
		[Export ("empty")]
		bool Empty { get; }

		// -(BOOL)contains:(Point2d * _Nonnull)point;
		[Export ("contains:")]
		bool Contains (Point2d point);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(Rect2d * _Nonnull)clone;
		[Export ("clone")]
		Rect2d Clone ();

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface KeyPoint : NSObject
	[BaseType (typeof(NSObject))]
	interface KeyPoint : INativeObject
	{
		// @property Point2f * _Nonnull pt;
		[Export ("pt", ArgumentSemantic.Assign)]
		Point2f Pt { get; set; }

		// @property float size;
		[Export ("size")]
		float Size { get; set; }

		// @property float angle;
		[Export ("angle")]
		float Angle { get; set; }

		// @property float response;
		[Export ("response")]
		float Response { get; set; }

		// @property int octave;
		[Export ("octave")]
		int Octave { get; set; }

		// @property int classId;
		[Export ("classId")]
		int ClassId { get; set; }

		// -(instancetype _Nonnull)initWithX:(float)x y:(float)y size:(float)size angle:(float)angle response:(float)response octave:(int)octave classId:(int)classId;
		[Export ("initWithX:y:size:angle:response:octave:classId:")]
		NativeHandle Constructor (float x, float y, float size, float angle, float response, int octave, int classId);

		// -(instancetype _Nonnull)initWithX:(float)x y:(float)y size:(float)size angle:(float)angle response:(float)response octave:(int)octave;
		[Export ("initWithX:y:size:angle:response:octave:")]
		NativeHandle Constructor (float x, float y, float size, float angle, float response, int octave);

		// -(instancetype _Nonnull)initWithX:(float)x y:(float)y size:(float)size angle:(float)angle response:(float)response;
		[Export ("initWithX:y:size:angle:response:")]
		NativeHandle Constructor (float x, float y, float size, float angle, float response);

		// -(instancetype _Nonnull)initWithX:(float)x y:(float)y size:(float)size angle:(float)angle;
		[Export ("initWithX:y:size:angle:")]
		NativeHandle Constructor (float x, float y, float size, float angle);

		// -(instancetype _Nonnull)initWithX:(float)x y:(float)y size:(float)size;
		[Export ("initWithX:y:size:")]
		NativeHandle Constructor (float x, float y, float size);

		// -(KeyPoint * _Nonnull)clone;
		[Export ("clone")]
		KeyPoint Clone ();

		// -(BOOL)isEqual:(id _Nullable)other;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface DMatch : NSObject
	[BaseType (typeof(NSObject))]
	interface DMatch : INativeObject
	{
		// @property int queryIdx;
		[Export ("queryIdx")]
		int QueryIdx { get; set; }

		// @property int trainIdx;
		[Export ("trainIdx")]
		int TrainIdx { get; set; }

		// @property int imgIdx;
		[Export ("imgIdx")]
		int ImgIdx { get; set; }

		// @property float distance;
		[Export ("distance")]
		float Distance { get; set; }

		// -(instancetype _Nonnull)initWithQueryIdx:(int)queryIdx trainIdx:(int)trainIdx distance:(float)distance;
		[Export ("initWithQueryIdx:trainIdx:distance:")]
		NativeHandle Constructor (int queryIdx, int trainIdx, float distance);

		// -(instancetype _Nonnull)initWithQueryIdx:(int)queryIdx trainIdx:(int)trainIdx imgIdx:(int)imgIdx distance:(float)distance;
		[Export ("initWithQueryIdx:trainIdx:imgIdx:distance:")]
		NativeHandle Constructor (int queryIdx, int trainIdx, int imgIdx, float distance);

		// -(BOOL)lessThan:(DMatch * _Nonnull)it;
		[Export ("lessThan:")]
		bool LessThan (DMatch it);

		// -(DMatch * _Nonnull)clone;
		[Export ("clone")]
		DMatch Clone ();

		// -(BOOL)isEqual:(id _Nullable)other;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface RotatedRect : NSObject
	[BaseType (typeof(NSObject))]
	interface RotatedRect : INativeObject
	{
		// @property Point2f * _Nonnull center;
		[Export ("center", ArgumentSemantic.Assign)]
		Point2f Center { get; set; }

		// @property Size2f * _Nonnull size;
		[Export ("size", ArgumentSemantic.Assign)]
		Size2f Size { get; set; }

		// @property double angle;
		[Export ("angle")]
		double Angle { get; set; }

		// -(instancetype _Nonnull)initWithCenter:(Point2f * _Nonnull)center size:(Size2f * _Nonnull)size angle:(double)angle;
		[Export ("initWithCenter:size:angle:")]
		NativeHandle Constructor (Point2f center, Size2f size, double angle);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(NSArray<Point2f *> * _Nonnull)points;
		[Export ("points")]
		Point2f[] Points { get; }

		// -(Rect2f * _Nonnull)boundingRect;
		[Export ("boundingRect")]
		Rect2f BoundingRect { get; }

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(RotatedRect * _Nonnull)clone;
		[Export ("clone")]
		RotatedRect Clone ();

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface Converters : NSObject
	[BaseType (typeof(NSObject))]
	interface Converters
	{
		// +(Mat * _Nonnull)vector_Point_to_Mat:(NSArray<Point2i *> * _Nonnull)pts __attribute__((swift_name("vector_Point_to_Mat(_:)")));
		[Static]
		[Export ("vector_Point_to_Mat:")]
		Mat Vector_Point_to_Mat (Point2i[] pts);

		// +(NSArray<Point2i *> * _Nonnull)Mat_to_vector_Point:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_Point(_:)")));
		[Static]
		[Export ("Mat_to_vector_Point:")]
		Point2i[] Mat_to_vector_Point (Mat mat);

		// +(Mat * _Nonnull)vector_Point2f_to_Mat:(NSArray<Point2f *> * _Nonnull)pts __attribute__((swift_name("vector_Point2f_to_Mat(_:)")));
		[Static]
		[Export ("vector_Point2f_to_Mat:")]
		Mat Vector_Point2f_to_Mat (Point2f[] pts);

		// +(NSArray<Point2f *> * _Nonnull)Mat_to_vector_Point2f:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_Point2f(_:)")));
		[Static]
		[Export ("Mat_to_vector_Point2f:")]
		Point2f[] Mat_to_vector_Point2f (Mat mat);

		// +(Mat * _Nonnull)vector_Point2d_to_Mat:(NSArray<Point2d *> * _Nonnull)pts __attribute__((swift_name("vector_Point2d_to_Mat(_:)")));
		[Static]
		[Export ("vector_Point2d_to_Mat:")]
		Mat Vector_Point2d_to_Mat (Point2d[] pts);

		// +(NSArray<Point2d *> * _Nonnull)Mat_to_vector_Point2d:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_Point2d(_:)")));
		[Static]
		[Export ("Mat_to_vector_Point2d:")]
		Point2d[] Mat_to_vector_Point2d (Mat mat);

		// +(Mat * _Nonnull)vector_Point3i_to_Mat:(NSArray<Point3i *> * _Nonnull)pts __attribute__((swift_name("vector_Point3i_to_Mat(_:)")));
		[Static]
		[Export ("vector_Point3i_to_Mat:")]
		Mat Vector_Point3i_to_Mat (Point3i[] pts);

		// +(NSArray<Point3i *> * _Nonnull)Mat_to_vector_Point3i:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_Point3i(_:)")));
		[Static]
		[Export ("Mat_to_vector_Point3i:")]
		Point3i[] Mat_to_vector_Point3i (Mat mat);

		// +(Mat * _Nonnull)vector_Point3f_to_Mat:(NSArray<Point3f *> * _Nonnull)pts __attribute__((swift_name("vector_Point3f_to_Mat(_:)")));
		[Static]
		[Export ("vector_Point3f_to_Mat:")]
		Mat Vector_Point3f_to_Mat (Point3f[] pts);

		// +(NSArray<Point3f *> * _Nonnull)Mat_to_vector_Point3f:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_Point3f(_:)")));
		[Static]
		[Export ("Mat_to_vector_Point3f:")]
		Point3f[] Mat_to_vector_Point3f (Mat mat);

		// +(Mat * _Nonnull)vector_Point3d_to_Mat:(NSArray<Point3d *> * _Nonnull)pts __attribute__((swift_name("vector_Point3d_to_Mat(_:)")));
		[Static]
		[Export ("vector_Point3d_to_Mat:")]
		Mat Vector_Point3d_to_Mat (Point3d[] pts);

		// +(NSArray<Point3d *> * _Nonnull)Mat_to_vector_Point3d:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_Point3d(_:)")));
		[Static]
		[Export ("Mat_to_vector_Point3d:")]
		Point3d[] Mat_to_vector_Point3d (Mat mat);

		// +(Mat * _Nonnull)vector_float_to_Mat:(NSArray<NSNumber *> * _Nonnull)fs __attribute__((swift_name("vector_float_to_Mat(_:)")));
		[Static]
		[Export ("vector_float_to_Mat:")]
		Mat Vector_float_to_Mat (NSNumber[] fs);

		// +(NSArray<NSNumber *> * _Nonnull)Mat_to_vector_float:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_float(_:)")));
		[Static]
		[Export ("Mat_to_vector_float:")]
		NSNumber[] Mat_to_vector_float (Mat mat);

		// +(Mat * _Nonnull)vector_uchar_to_Mat:(NSArray<NSNumber *> * _Nonnull)us __attribute__((swift_name("vector_uchar_to_Mat(_:)")));
		[Static]
		[Export ("vector_uchar_to_Mat:")]
		Mat Vector_uchar_to_Mat (NSNumber[] us);

		// +(NSArray<NSNumber *> * _Nonnull)Mat_to_vector_uchar:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_uchar(_:)")));
		[Static]
		[Export ("Mat_to_vector_uchar:")]
		NSNumber[] Mat_to_vector_uchar (Mat mat);

		// +(Mat * _Nonnull)vector_char_to_Mat:(NSArray<NSNumber *> * _Nonnull)cs __attribute__((swift_name("vector_char_to_Mat(_:)")));
		[Static]
		[Export ("vector_char_to_Mat:")]
		Mat Vector_char_to_Mat (NSNumber[] cs);

		// +(NSArray<NSNumber *> * _Nonnull)Mat_to_vector_char:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_char(_:)")));
		[Static]
		[Export ("Mat_to_vector_char:")]
		NSNumber[] Mat_to_vector_char (Mat mat);

		// +(Mat * _Nonnull)vector_int_to_Mat:(NSArray<NSNumber *> * _Nonnull)is __attribute__((swift_name("vector_int_to_Mat(_:)")));
		[Static]
		[Export ("vector_int_to_Mat:")]
		Mat Vector_int_to_Mat (NSNumber[] @is);

		// +(NSArray<NSNumber *> * _Nonnull)Mat_to_vector_int:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_int(_:)")));
		[Static]
		[Export ("Mat_to_vector_int:")]
		NSNumber[] Mat_to_vector_int (Mat mat);

		// +(Mat * _Nonnull)vector_Rect_to_Mat:(NSArray<Rect2i *> * _Nonnull)rs __attribute__((swift_name("vector_Rect_to_Mat(_:)")));
		[Static]
		[Export ("vector_Rect_to_Mat:")]
		Mat Vector_Rect_to_Mat (Rect2i[] rs);

		// +(NSArray<Rect2i *> * _Nonnull)Mat_to_vector_Rect:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_Rect(_:)")));
		[Static]
		[Export ("Mat_to_vector_Rect:")]
		Rect2i[] Mat_to_vector_Rect (Mat mat);

		// +(Mat * _Nonnull)vector_Rect2d_to_Mat:(NSArray<Rect2d *> * _Nonnull)rs __attribute__((swift_name("vector_Rect2d_to_Mat(_:)")));
		[Static]
		[Export ("vector_Rect2d_to_Mat:")]
		Mat Vector_Rect2d_to_Mat (Rect2d[] rs);

		// +(NSArray<Rect2d *> * _Nonnull)Mat_to_vector_Rect2d:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_Rect2d(_:)")));
		[Static]
		[Export ("Mat_to_vector_Rect2d:")]
		Rect2d[] Mat_to_vector_Rect2d (Mat mat);

		// +(Mat * _Nonnull)vector_KeyPoint_to_Mat:(NSArray<KeyPoint *> * _Nonnull)kps __attribute__((swift_name("vector_KeyPoint_to_Mat(_:)")));
		[Static]
		[Export ("vector_KeyPoint_to_Mat:")]
		Mat Vector_KeyPoint_to_Mat (KeyPoint[] kps);

		// +(NSArray<KeyPoint *> * _Nonnull)Mat_to_vector_KeyPoint:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_KeyPoint(_:)")));
		[Static]
		[Export ("Mat_to_vector_KeyPoint:")]
		KeyPoint[] Mat_to_vector_KeyPoint (Mat mat);

		// +(Mat * _Nonnull)vector_double_to_Mat:(NSArray<NSNumber *> * _Nonnull)ds __attribute__((swift_name("vector_double_to_Mat(_:)")));
		[Static]
		[Export ("vector_double_to_Mat:")]
		Mat Vector_double_to_Mat (NSNumber[] ds);

		// +(NSArray<NSNumber *> * _Nonnull)Mat_to_vector_double:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_double(_:)")));
		[Static]
		[Export ("Mat_to_vector_double:")]
		NSNumber[] Mat_to_vector_double (Mat mat);

		// +(Mat * _Nonnull)vector_DMatch_to_Mat:(NSArray<DMatch *> * _Nonnull)matches __attribute__((swift_name("vector_DMatch_to_Mat(_:)")));
		[Static]
		[Export ("vector_DMatch_to_Mat:")]
		Mat Vector_DMatch_to_Mat (DMatch[] matches);

		// +(NSArray<DMatch *> * _Nonnull)Mat_to_vector_DMatch:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_DMatch(_:)")));
		[Static]
		[Export ("Mat_to_vector_DMatch:")]
		DMatch[] Mat_to_vector_DMatch (Mat mat);

		// +(Mat * _Nonnull)vector_RotatedRect_to_Mat:(NSArray<RotatedRect *> * _Nonnull)rs __attribute__((swift_name("vector_RotatedRect_to_Mat(_:)")));
		[Static]
		[Export ("vector_RotatedRect_to_Mat:")]
		Mat Vector_RotatedRect_to_Mat (RotatedRect[] rs);

		// +(NSArray<RotatedRect *> * _Nonnull)Mat_to_vector_RotatedRect:(Mat * _Nonnull)mat __attribute__((swift_name("Mat_to_vector_RotatedRect(_:)")));
		[Static]
		[Export ("Mat_to_vector_RotatedRect:")]
		RotatedRect[] Mat_to_vector_RotatedRect (Mat mat);
	}

	// @interface ByteVector : NSObject
	[BaseType (typeof(NSObject))]
	interface ByteVector
	{
		// -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)data;
		[Export ("initWithData:")]
		NativeHandle Constructor (NSData data);

		// -(instancetype _Nonnull)initWithVector:(ByteVector * _Nonnull)src;
		[Export ("initWithVector:")]
		NativeHandle Constructor (ByteVector src);

		// -(instancetype _Nonnull)initWithNativeArray:(char * _Nonnull)array elements:(NSInteger)elements;
		[Export ("initWithNativeArray:elements:")]
		unsafe NativeHandle Constructor (sbyte* array, nint elements);

		// @property (readonly) NSInteger length;
		[Export ("length")]
		nint Length { get; }

		// @property (readonly) char * _Nonnull nativeArray;
		[Export ("nativeArray")]
		unsafe NativeHandle NativeArray { get; }

		// @property (readonly) NSData * _Nonnull data;
		[Export ("data")]
		NSData Data { get; }

		// -(char)get:(NSInteger)index;
		[Export ("get:")]
		sbyte Get (nint index);
	}

	// @interface Rect2f : NSObject
	[BaseType (typeof(NSObject))]
	interface Rect2f
	{
		// @property float x;
		[Export ("x")]
		float X { get; set; }

		// @property float y;
		[Export ("y")]
		float Y { get; set; }

		// @property float width;
		[Export ("width")]
		float Width { get; set; }

		// @property float height;
		[Export ("height")]
		float Height { get; set; }

		// -(instancetype _Nonnull)initWithX:(float)x y:(float)y width:(float)width height:(float)height;
		[Export ("initWithX:y:width:height:")]
		NativeHandle Constructor (float x, float y, float width, float height);

		// -(instancetype _Nonnull)initWithPoint:(Point2f * _Nonnull)point1 point:(Point2f * _Nonnull)point2;
		[Export ("initWithPoint:point:")]
		NativeHandle Constructor (Point2f point1, Point2f point2);

		// -(instancetype _Nonnull)initWithPoint:(Point2f * _Nonnull)point size:(Size2f * _Nonnull)size;
		[Export ("initWithPoint:size:")]
		NativeHandle Constructor (Point2f point, Size2f size);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(Point2f * _Nonnull)tl;
		[Export ("tl")]
		Point2f Tl { get; }

		// -(Point2f * _Nonnull)br;
		[Export ("br")]
		Point2f Br { get; }

		// -(Size2f * _Nonnull)size;
		[Export ("size")]
		Size2f Size { get; }

		// -(double)area;
		[Export ("area")]
		double Area { get; }

		// -(BOOL)empty;
		[Export ("empty")]
		bool Empty { get; }

		// -(BOOL)contains:(Point2f * _Nonnull)point;
		[Export ("contains:")]
		bool Contains (Point2f point);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(Rect2f * _Nonnull)clone;
		[Export ("clone")]
		Rect2f Clone ();

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface Float6 : NSObject
	[BaseType (typeof(NSObject))]
	interface Float6 : INativeObject
	{
		// @property float v0;
		[Export ("v0")]
		float V0 { get; set; }

		// @property float v1;
		[Export ("v1")]
		float V1 { get; set; }

		// @property float v2;
		[Export ("v2")]
		float V2 { get; set; }

		// @property float v3;
		[Export ("v3")]
		float V3 { get; set; }

		// @property float v4;
		[Export ("v4")]
		float V4 { get; set; }

		// @property float v5;
		[Export ("v5")]
		float V5 { get; set; }

		// -(instancetype _Nonnull)initWithV0:(float)v0 v1:(float)v1 v2:(float)v2 v3:(float)v3 v4:(float)v4 v5:(float)v5;
		[Export ("initWithV0:v1:v2:v3:v4:v5:")]
		NativeHandle Constructor (float v0, float v1, float v2, float v3, float v4, float v5);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(NSArray<NSNumber *> * _Nonnull)get;
		[Export ("get")]
		NSNumber[] Get ();

		// -(BOOL)isEqual:(id _Nullable)other;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);
	}

	// @interface MatOfKeyPoint : Mat
	[BaseType (typeof(Mat))]
	interface MatOfKeyPoint
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<KeyPoint *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (KeyPoint[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<KeyPoint *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (KeyPoint[] array);

		// -(NSArray<KeyPoint *> * _Nonnull)toArray;
		[Export ("toArray")]
		KeyPoint[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface MatOfRect2i : Mat
	[BaseType (typeof(Mat))]
	interface MatOfRect2i
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<Rect2i *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (Rect2i[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<Rect2i *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (Rect2i[] array);

		// -(NSArray<Rect2i *> * _Nonnull)toArray;
		[Export ("toArray")]
		Rect2i[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface FloatVector : NSObject
	[BaseType (typeof(NSObject))]
	interface FloatVector
	{
		// -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)data;
		[Export ("initWithData:")]
		NativeHandle Constructor (NSData data);

		// -(instancetype _Nonnull)initWithVector:(FloatVector * _Nonnull)src;
		[Export ("initWithVector:")]
		NativeHandle Constructor (FloatVector src);

		// -(instancetype _Nonnull)initWithNativeArray:(float * _Nonnull)array elements:(NSInteger)elements;
		[Export ("initWithNativeArray:elements:")]
		unsafe NativeHandle Constructor (float* array, nint elements);

		// @property (readonly) NSInteger length;
		[Export ("length")]
		nint Length { get; }

		// @property (readonly) float * _Nonnull nativeArray;
		[Export ("nativeArray")]
		unsafe NativeHandle NativeArray { get; }

		// @property (readonly) NSData * _Nonnull data;
		[Export ("data")]
		NSData Data { get; }

		// -(float)get:(NSInteger)index;
		[Export ("get:")]
		float Get (nint index);
	}

	// @interface TermCriteria : NSObject
	[BaseType (typeof(NSObject))]
	interface TermCriteria
	{
		// @property (readonly, class) int COUNT;
		[Static]
		[Export ("COUNT")]
		int COUNT { get; }

		// @property (readonly, class) int EPS;
		[Static]
		[Export ("EPS")]
		int EPS { get; }

		// @property (readonly, class) int MAX_ITER;
		[Static]
		[Export ("MAX_ITER")]
		int MAX_ITER { get; }

		// @property int type;
		[Export ("type")]
		int Type { get; set; }

		// @property int maxCount;
		[Export ("maxCount")]
		int MaxCount { get; set; }

		// @property double epsilon;
		[Export ("epsilon")]
		double Epsilon { get; set; }

		// -(instancetype _Nonnull)initWithType:(int)type maxCount:(int)maxCount epsilon:(double)epsilon;
		[Export ("initWithType:maxCount:epsilon:")]
		NativeHandle Constructor (int type, int maxCount, double epsilon);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(TermCriteria * _Nonnull)clone;
		[Export ("clone")]
		TermCriteria Clone ();

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface Int4 : NSObject
	[BaseType (typeof(NSObject))]
	interface Int4 : INativeObject
	{
		// @property int v0;
		[Export ("v0")]
		int V0 { get; set; }

		// @property int v1;
		[Export ("v1")]
		int V1 { get; set; }

		// @property int v2;
		[Export ("v2")]
		int V2 { get; set; }

		// @property int v3;
		[Export ("v3")]
		int V3 { get; set; }

		// -(instancetype _Nonnull)initWithV0:(int)v0 v1:(int)v1 v2:(int)v2 v3:(int)v3;
		[Export ("initWithV0:v1:v2:v3:")]
		NativeHandle Constructor (int v0, int v1, int v2, int v3);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(NSArray<NSNumber *> * _Nonnull)get;
		[Export ("get")]
		NSNumber[] Get ();

		// -(BOOL)isEqual:(id _Nullable)other;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);
	}

	// @interface MatOfDMatch : Mat
	[BaseType (typeof(Mat))]
	interface MatOfDMatch
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<DMatch *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (DMatch[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<DMatch *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (DMatch[] array);

		// -(NSArray<DMatch *> * _Nonnull)toArray;
		[Export ("toArray")]
		DMatch[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface Scalar : NSObject
	[BaseType (typeof(NSObject))]
	interface Scalar
	{
		// @property (readonly) NSArray<NSNumber *> * _Nonnull val;
		[Export ("val")]
		NSNumber[] Val { get; }

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(instancetype _Nonnull)initWithV0:(double)v0 v1:(double)v1 v2:(double)v2 v3:(double)v3 __attribute__((swift_name("init(_:_:_:_:)")));
		[Export ("initWithV0:v1:v2:v3:")]
		NativeHandle Constructor (double v0, double v1, double v2, double v3);

		// -(instancetype _Nonnull)initWithV0:(double)v0 v1:(double)v1 v2:(double)v2 __attribute__((swift_name("init(_:_:_:)")));
		[Export ("initWithV0:v1:v2:")]
		NativeHandle Constructor (double v0, double v1, double v2);

		// -(instancetype _Nonnull)initWithV0:(double)v0 v1:(double)v1 __attribute__((swift_name("init(_:_:)")));
		[Export ("initWithV0:v1:")]
		NativeHandle Constructor (double v0, double v1);

		// -(instancetype _Nonnull)initWithV0:(double)v0 __attribute__((swift_name("init(_:)")));
		[Export ("initWithV0:")]
		NativeHandle Constructor (double v0);

		// +(Scalar * _Nonnull)all:(double)v;
		[Static]
		[Export ("all:")]
		Scalar All (double v);

		// -(Scalar * _Nonnull)mul:(Scalar * _Nonnull)it scale:(double)scale;
		[Export ("mul:scale:")]
		Scalar Mul (Scalar it, double scale);

		// -(Scalar * _Nonnull)mul:(Scalar * _Nonnull)it;
		[Export ("mul:")]
		Scalar Mul (Scalar it);

		// -(Scalar * _Nonnull)conj;
		[Export ("conj")]
		Scalar Conj { get; }

		// -(BOOL)isReal;
		[Export ("isReal")]
		bool IsReal { get; }

		// -(Scalar * _Nonnull)clone;
		[Export ("clone")]
		Scalar Clone ();

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface MatOfDouble : Mat
	[BaseType (typeof(Mat))]
	interface MatOfDouble
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<NSNumber *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (NSNumber[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<NSNumber *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (NSNumber[] array);

		// -(NSArray<NSNumber *> * _Nonnull)toArray;
		[Export ("toArray")]
		NSNumber[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface IntVector : NSObject
	[BaseType (typeof(NSObject))]
	interface IntVector : INativeObject
	{
		// -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)data;
		[Export ("initWithData:")]
		NativeHandle Constructor (NSData data);

		// -(instancetype _Nonnull)initWithVector:(IntVector * _Nonnull)src;
		[Export ("initWithVector:")]
		NativeHandle Constructor (IntVector src);

		// -(instancetype _Nonnull)initWithNativeArray:(int * _Nonnull)array elements:(NSInteger)elements;
		[Export ("initWithNativeArray:elements:")]
		unsafe NativeHandle Constructor (int* array, nint elements);

		// @property (readonly) NSInteger length;
		[Export ("length")]
		nint Length { get; }

		// @property (readonly) int * _Nonnull nativeArray;
		[Export ("nativeArray")]
		unsafe NativeHandle NativeArray { get; }

		// @property (readonly) NSData * _Nonnull data;
		[Export ("data")]
		NSData Data { get; }

		// -(int)get:(NSInteger)index;
		[Export ("get:")]
		int Get (nint index);
	}

	// @interface MatOfFloat6 : Mat
	[BaseType (typeof(Mat))]
	interface MatOfFloat6
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<NSNumber *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (NSNumber[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<NSNumber *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (NSNumber[] array);

		// -(NSArray<NSNumber *> * _Nonnull)toArray;
		[Export ("toArray")]
		NSNumber[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface DoubleVector : NSObject
	[BaseType (typeof(NSObject))]
	interface DoubleVector
	{
		// -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)data;
		[Export ("initWithData:")]
		NativeHandle Constructor (NSData data);

		// -(instancetype _Nonnull)initWithVector:(DoubleVector * _Nonnull)src;
		[Export ("initWithVector:")]
		NativeHandle Constructor (DoubleVector src);

		// -(instancetype _Nonnull)initWithNativeArray:(double * _Nonnull)array elements:(int)elements;
		[Export ("initWithNativeArray:elements:")]
		unsafe NativeHandle Constructor (double* array, int elements);

		// @property (readonly) size_t length;
		[Export ("length")]
		nuint Length { get; }

		// @property (readonly) double * _Nonnull nativeArray;
		[Export ("nativeArray")]
		unsafe NativeHandle NativeArray { get; }

		// @property (readonly) NSData * _Nonnull data;
		[Export ("data")]
		NSData Data { get; }

		// -(double)get:(NSInteger)index;
		[Export ("get:")]
		double Get (nint index);
	}

	// @interface Size2d : NSObject
	[BaseType (typeof(NSObject))]
	interface Size2d
	{
		// @property double width;
		[Export ("width")]
		double Width { get; set; }

		// @property double height;
		[Export ("height")]
		double Height { get; set; }

		// -(instancetype _Nonnull)initWithWidth:(double)width height:(double)height;
		[Export ("initWithWidth:height:")]
		NativeHandle Constructor (double width, double height);

		// -(instancetype _Nonnull)initWithPoint:(Point2d * _Nonnull)point;
		[Export ("initWithPoint:")]
		NativeHandle Constructor (Point2d point);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// +(instancetype _Nonnull)width:(double)width height:(double)height;
		[Static]
		[Export ("width:height:")]
		Size2d WidthHeight (double width, double height);

		// -(double)area;
		[Export ("area")]
		double Area { get; }

		// -(BOOL)empty;
		[Export ("empty")]
		bool Empty { get; }

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(Size2d * _Nonnull)clone;
		[Export ("clone")]
		Size2d Clone ();

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface MinMaxLocResult : NSObject
	[BaseType (typeof(NSObject))]
	interface MinMaxLocResult
	{
		// @property double minVal;
		[Export ("minVal")]
		double MinVal { get; set; }

		// @property double maxVal;
		[Export ("maxVal")]
		double MaxVal { get; set; }

		// @property Point2i * _Nonnull minLoc;
		[Export ("minLoc", ArgumentSemantic.Assign)]
		Point2i MinLoc { get; set; }

		// @property Point2i * _Nonnull maxLoc;
		[Export ("maxLoc", ArgumentSemantic.Assign)]
		Point2i MaxLoc { get; set; }

		// -(instancetype _Nonnull)initWithMinval:(double)minVal maxVal:(double)maxVal minLoc:(Point2i * _Nonnull)minLoc maxLoc:(Point2i * _Nonnull)maxLoc;
		[Export ("initWithMinval:maxVal:minLoc:maxLoc:")]
		NativeHandle Constructor (double minVal, double maxVal, Point2i minLoc, Point2i maxLoc);
	}

	// @interface MatOfInt4 : Mat
	[BaseType (typeof(Mat))]
	interface MatOfInt4
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<NSNumber *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (NSNumber[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<NSNumber *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (NSNumber[] array);

		// -(NSArray<NSNumber *> * _Nonnull)toArray;
		[Export ("toArray")]
		NSNumber[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface MatOfPoint3 : Mat
	[BaseType (typeof(Mat))]
	interface MatOfPoint3
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<Point3i *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (Point3i[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<Point3i *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (Point3i[] array);

		// -(NSArray<Point3i *> * _Nonnull)toArray;
		[Export ("toArray")]
		Point3i[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface MatOfRotatedRect : Mat
	[BaseType (typeof(Mat))]
	interface MatOfRotatedRect
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<RotatedRect *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (RotatedRect[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<RotatedRect *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (RotatedRect[] array);

		// -(NSArray<RotatedRect *> * _Nonnull)toArray;
		[Export ("toArray")]
		RotatedRect[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface Size2i : NSObject
	[BaseType (typeof(NSObject))]
	interface Size2i
	{
		// @property int width;
		[Export ("width")]
		int Width { get; set; }

		// @property int height;
		[Export ("height")]
		int Height { get; set; }

		// -(instancetype _Nonnull)initWithWidth:(int)width height:(int)height;
		[Export ("initWithWidth:height:")]
		NativeHandle Constructor (int width, int height);

		// -(instancetype _Nonnull)initWithPoint:(Point2i * _Nonnull)point;
		[Export ("initWithPoint:")]
		NativeHandle Constructor (Point2i point);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// +(instancetype _Nonnull)width:(int)width height:(int)height;
		[Static]
		[Export ("width:height:")]
		Size2i WidthHeight (int width, int height);

		// -(double)area;
		[Export ("area")]
		double Area { get; }

		// -(BOOL)empty;
		[Export ("empty")]
		bool Empty { get; }

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(Size2i * _Nonnull)clone;
		[Export ("clone")]
		Size2i Clone ();

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// -(NSUInteger)hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface Float4 : NSObject
	[BaseType (typeof(NSObject))]
	interface Float4 : INativeObject
	{
		// @property float v0;
		[Export ("v0")]
		float V0 { get; set; }

		// @property float v1;
		[Export ("v1")]
		float V1 { get; set; }

		// @property float v2;
		[Export ("v2")]
		float V2 { get; set; }

		// @property float v3;
		[Export ("v3")]
		float V3 { get; set; }

		// -(instancetype _Nonnull)initWithV0:(float)v0 v1:(float)v1 v2:(float)v2 v3:(float)v3;
		[Export ("initWithV0:v1:v2:v3:")]
		NativeHandle Constructor (float v0, float v1, float v2, float v3);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(NSArray<NSNumber *> * _Nonnull)get;
		[Export ("get")]
		NSNumber[] Get ();

		// -(BOOL)isEqual:(id _Nullable)other;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);
	}

	// @interface MatOfFloat : Mat
	[BaseType (typeof(Mat))]
	interface MatOfFloat
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<NSNumber *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (NSNumber[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<NSNumber *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (NSNumber[] array);

		// -(NSArray<NSNumber *> * _Nonnull)toArray;
		[Export ("toArray")]
		NSNumber[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface MatOfPoint2f : Mat
	[BaseType (typeof(Mat))]
	interface MatOfPoint2f
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<Point2f *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (Point2f[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<Point2f *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (Point2f[] array);

		// -(NSArray<Point2f *> * _Nonnull)toArray;
		[Export ("toArray")]
		Point2f[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface Double2 : NSObject
	[BaseType (typeof(NSObject))]
	interface Double2
	{
		// @property double v0;
		[Export ("v0")]
		double V0 { get; set; }

		// @property double v1;
		[Export ("v1")]
		double V1 { get; set; }

		// -(instancetype _Nonnull)initWithV0:(double)v0 v1:(double)v1;
		[Export ("initWithV0:v1:")]
		NativeHandle Constructor (double v0, double v1);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals __attribute__((swift_name("set(vals:)")));
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(NSArray<NSNumber *> * _Nonnull)get;
		[Export ("get")]
		NSNumber[] Get ();

		// -(BOOL)isEqual:(id _Nullable)other;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);
	}

	// @interface MatOfInt : Mat
	[BaseType (typeof(Mat))]
	interface MatOfInt
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<NSNumber *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (NSNumber[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<NSNumber *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (NSNumber[] array);

		// -(NSArray<NSNumber *> * _Nonnull)toArray;
		[Export ("toArray")]
		NSNumber[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface MatOfPoint3f : Mat
	[BaseType (typeof(Mat))]
	interface MatOfPoint3f
	{
		// -(instancetype _Nonnull)initWithMat:(Mat * _Nonnull)mat;
		[Export ("initWithMat:")]
		NativeHandle Constructor (Mat mat);

		// -(instancetype _Nonnull)initWithArray:(NSArray<Point3f *> * _Nonnull)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (Point3f[] array);

		// -(void)alloc:(int)elemNumber;
		[Export ("alloc:")]
		void Alloc (int elemNumber);

		// -(void)fromArray:(NSArray<Point3f *> * _Nonnull)array;
		[Export ("fromArray:")]
		void FromArray (Point3f[] array);

		// -(NSArray<Point3f *> * _Nonnull)toArray;
		[Export ("toArray")]
		Point3f[] ToArray ();

		// -(int)length;
		[Export ("length")]
		int Length { get; }
	}

	// @interface Core : NSObject
	[BaseType (typeof(NSObject))]
	interface Core
	{
		// @property (readonly, class) int SVD_MODIFY_A __attribute__((swift_name("SVD_MODIFY_A")));
		[Static]
		[Export ("SVD_MODIFY_A")]
		int SVD_MODIFY_A { get; }

		// @property (readonly, class) int SVD_NO_UV __attribute__((swift_name("SVD_NO_UV")));
		[Static]
		[Export ("SVD_NO_UV")]
		int SVD_NO_UV { get; }

		// @property (readonly, class) int SVD_FULL_UV __attribute__((swift_name("SVD_FULL_UV")));
		[Static]
		[Export ("SVD_FULL_UV")]
		int SVD_FULL_UV { get; }

		// @property (readonly, class) int FILLED __attribute__((swift_name("FILLED")));
		[Static]
		[Export ("FILLED")]
		int FILLED { get; }

		// @property (readonly, class) int REDUCE_SUM __attribute__((swift_name("REDUCE_SUM")));
		[Static]
		[Export ("REDUCE_SUM")]
		int REDUCE_SUM { get; }

		// @property (readonly, class) int REDUCE_AVG __attribute__((swift_name("REDUCE_AVG")));
		[Static]
		[Export ("REDUCE_AVG")]
		int REDUCE_AVG { get; }

		// @property (readonly, class) int REDUCE_MAX __attribute__((swift_name("REDUCE_MAX")));
		[Static]
		[Export ("REDUCE_MAX")]
		int REDUCE_MAX { get; }

		// @property (readonly, class) int REDUCE_MIN __attribute__((swift_name("REDUCE_MIN")));
		[Static]
		[Export ("REDUCE_MIN")]
		int REDUCE_MIN { get; }

		// @property (readonly, class) int RNG_UNIFORM __attribute__((swift_name("RNG_UNIFORM")));
		[Static]
		[Export ("RNG_UNIFORM")]
		int RNG_UNIFORM { get; }

		// @property (readonly, class) int RNG_NORMAL __attribute__((swift_name("RNG_NORMAL")));
		[Static]
		[Export ("RNG_NORMAL")]
		int RNG_NORMAL { get; }

		// +(float)cubeRoot:(float)val __attribute__((swift_name("cubeRoot(val:)")));
		[Static]
		[Export ("cubeRoot:")]
		float CubeRoot (float val);

		// +(float)fastAtan2:(float)y x:(float)x __attribute__((swift_name("fastAtan2(y:x:)")));
		[Static]
		[Export ("fastAtan2:x:")]
		float FastAtan2 (float y, float x);

		// +(BOOL)useIPP __attribute__((swift_name("useIPP()")));
		// +(void)setUseIPP:(BOOL)flag __attribute__((swift_name("setUseIPP(flag:)")));
		[Static]
		[Export ("useIPP")]
		bool UseIPP { get; set; }

		// +(NSString * _Nonnull)getIppVersion __attribute__((swift_name("getIppVersion()")));
		[Static]
		[Export ("getIppVersion")]
		string GetIppVersion ();

		// +(BOOL)useIPP_NotExact __attribute__((swift_name("useIPP_NotExact()")));
		[Static]
		[Export ("useIPP_NotExact")]
		bool UseIPP_NotExact ();

		// +(void)setUseIPP_NotExact:(BOOL)flag __attribute__((swift_name("setUseIPP_NotExact(flag:)")));
		[Static]
		[Export ("setUseIPP_NotExact:")]
		void SetUseIPP_NotExact (bool flag);

		// +(int)borderInterpolate:(int)p len:(int)len borderType:(BorderTypes)borderType __attribute__((swift_name("borderInterpolate(p:len:borderType:)")));
		[Static]
		[Export ("borderInterpolate:len:borderType:")]
		int BorderInterpolate (int p, int len, BorderTypes borderType);

		// +(void)copyMakeBorder:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst top:(int)top bottom:(int)bottom left:(int)left right:(int)right borderType:(BorderTypes)borderType value:(Scalar * _Nonnull)value __attribute__((swift_name("copyMakeBorder(src:dst:top:bottom:left:right:borderType:value:)")));
		[Static]
		[Export ("copyMakeBorder:dst:top:bottom:left:right:borderType:value:")]
		void CopyMakeBorder (Mat src, Mat dst, int top, int bottom, int left, int right, BorderTypes borderType, Scalar value);

		// +(void)copyMakeBorder:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst top:(int)top bottom:(int)bottom left:(int)left right:(int)right borderType:(BorderTypes)borderType __attribute__((swift_name("copyMakeBorder(src:dst:top:bottom:left:right:borderType:)")));
		[Static]
		[Export ("copyMakeBorder:dst:top:bottom:left:right:borderType:")]
		void CopyMakeBorder (Mat src, Mat dst, int top, int bottom, int left, int right, BorderTypes borderType);

		// +(void)add:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask dtype:(int)dtype __attribute__((swift_name("add(src1:src2:dst:mask:dtype:)")));
		[Static]
		[Export ("add:src2:dst:mask:dtype:")]
		void Add (Mat src1, Mat src2, Mat dst, Mat mask, int dtype);

		// +(void)add:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask __attribute__((swift_name("add(src1:src2:dst:mask:)")));
		[Static]
		[Export ("add:src2:dst:mask:")]
		void Add (Mat src1, Mat src2, Mat dst, Mat mask);

		// +(void)add:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst __attribute__((swift_name("add(src1:src2:dst:)")));
		[Static]
		[Export ("add:src2:dst:")]
		void Add (Mat src1, Mat src2, Mat dst);

		// +(void)subtract:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask dtype:(int)dtype __attribute__((swift_name("subtract(src1:src2:dst:mask:dtype:)")));
		[Static]
		[Export ("subtract:src2:dst:mask:dtype:")]
		void Subtract (Mat src1, Mat src2, Mat dst, Mat mask, int dtype);

		// +(void)subtract:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask __attribute__((swift_name("subtract(src1:src2:dst:mask:)")));
		[Static]
		[Export ("subtract:src2:dst:mask:")]
		void Subtract (Mat src1, Mat src2, Mat dst, Mat mask);

		// +(void)subtract:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst __attribute__((swift_name("subtract(src1:src2:dst:)")));
		[Static]
		[Export ("subtract:src2:dst:")]
		void Subtract (Mat src1, Mat src2, Mat dst);

		// +(void)multiply:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst scale:(double)scale dtype:(int)dtype __attribute__((swift_name("multiply(src1:src2:dst:scale:dtype:)")));
		[Static]
		[Export ("multiply:src2:dst:scale:dtype:")]
		void Multiply (Mat src1, Mat src2, Mat dst, double scale, int dtype);

		// +(void)multiply:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst scale:(double)scale __attribute__((swift_name("multiply(src1:src2:dst:scale:)")));
		[Static]
		[Export ("multiply:src2:dst:scale:")]
		void Multiply (Mat src1, Mat src2, Mat dst, double scale);

		// +(void)multiply:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst __attribute__((swift_name("multiply(src1:src2:dst:)")));
		[Static]
		[Export ("multiply:src2:dst:")]
		void Multiply (Mat src1, Mat src2, Mat dst);

		// +(void)divide:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst scale:(double)scale dtype:(int)dtype __attribute__((swift_name("divide(src1:src2:dst:scale:dtype:)")));
		[Static]
		[Export ("divide:src2:dst:scale:dtype:")]
		void Divide (Mat src1, Mat src2, Mat dst, double scale, int dtype);

		// +(void)divide:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst scale:(double)scale __attribute__((swift_name("divide(src1:src2:dst:scale:)")));
		[Static]
		[Export ("divide:src2:dst:scale:")]
		void Divide (Mat src1, Mat src2, Mat dst, double scale);

		// +(void)divide:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst __attribute__((swift_name("divide(src1:src2:dst:)")));
		[Static]
		[Export ("divide:src2:dst:")]
		void Divide (Mat src1, Mat src2, Mat dst);

		// +(void)divide:(double)scale src:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst dtype:(int)dtype __attribute__((swift_name("divide(scale:src:dst:dtype:)")));
		[Static]
		[Export ("divide:src:dst:dtype:")]
		void Divide (double scale, Mat src, Mat dst, int dtype);

		// +(void)divide:(double)scale src:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("divide(scale:src:dst:)")));
		[Static]
		[Export ("divide:src:dst:")]
		void Divide (double scale, Mat src, Mat dst);

		// +(void)scaleAdd:(Mat * _Nonnull)src1 alpha:(double)alpha src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst __attribute__((swift_name("scaleAdd(src1:alpha:src2:dst:)")));
		[Static]
		[Export ("scaleAdd:alpha:src2:dst:")]
		void ScaleAdd (Mat src1, double alpha, Mat src2, Mat dst);

		// +(void)addWeighted:(Mat * _Nonnull)src1 alpha:(double)alpha src2:(Mat * _Nonnull)src2 beta:(double)beta gamma:(double)gamma dst:(Mat * _Nonnull)dst dtype:(int)dtype __attribute__((swift_name("addWeighted(src1:alpha:src2:beta:gamma:dst:dtype:)")));
		[Static]
		[Export ("addWeighted:alpha:src2:beta:gamma:dst:dtype:")]
		void AddWeighted (Mat src1, double alpha, Mat src2, double beta, double gamma, Mat dst, int dtype);

		// +(void)addWeighted:(Mat * _Nonnull)src1 alpha:(double)alpha src2:(Mat * _Nonnull)src2 beta:(double)beta gamma:(double)gamma dst:(Mat * _Nonnull)dst __attribute__((swift_name("addWeighted(src1:alpha:src2:beta:gamma:dst:)")));
		[Static]
		[Export ("addWeighted:alpha:src2:beta:gamma:dst:")]
		void AddWeighted (Mat src1, double alpha, Mat src2, double beta, double gamma, Mat dst);

		// +(void)convertScaleAbs:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst alpha:(double)alpha beta:(double)beta __attribute__((swift_name("convertScaleAbs(src:dst:alpha:beta:)")));
		[Static]
		[Export ("convertScaleAbs:dst:alpha:beta:")]
		void ConvertScaleAbs (Mat src, Mat dst, double alpha, double beta);

		// +(void)convertScaleAbs:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst alpha:(double)alpha __attribute__((swift_name("convertScaleAbs(src:dst:alpha:)")));
		[Static]
		[Export ("convertScaleAbs:dst:alpha:")]
		void ConvertScaleAbs (Mat src, Mat dst, double alpha);

		// +(void)convertScaleAbs:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("convertScaleAbs(src:dst:)")));
		[Static]
		[Export ("convertScaleAbs:dst:")]
		void ConvertScaleAbs (Mat src, Mat dst);

		// +(void)convertFp16:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("convertFp16(src:dst:)"))) __attribute__((deprecated("")));
		[Static]
		[Export ("convertFp16:dst:")]
		void ConvertFp16 (Mat src, Mat dst);

		// +(void)LUT:(Mat * _Nonnull)src lut:(Mat * _Nonnull)lut dst:(Mat * _Nonnull)dst __attribute__((swift_name("LUT(src:lut:dst:)")));
		[Static]
		[Export ("LUT:lut:dst:")]
		void LUT (Mat src, Mat lut, Mat dst);

		// +(Scalar * _Nonnull)sumElems:(Mat * _Nonnull)src __attribute__((swift_name("sum(src:)")));
		[Static]
		[Export ("sumElems:")]
		Scalar SumElems (Mat src);

		// +(BOOL)hasNonZero:(Mat * _Nonnull)src __attribute__((swift_name("hasNonZero(src:)")));
		[Static]
		[Export ("hasNonZero:")]
		bool HasNonZero (Mat src);

		// +(int)countNonZero:(Mat * _Nonnull)src __attribute__((swift_name("countNonZero(src:)")));
		[Static]
		[Export ("countNonZero:")]
		int CountNonZero (Mat src);

		// +(void)findNonZero:(Mat * _Nonnull)src idx:(Mat * _Nonnull)idx __attribute__((swift_name("findNonZero(src:idx:)")));
		[Static]
		[Export ("findNonZero:idx:")]
		void FindNonZero (Mat src, Mat idx);

		// +(Scalar * _Nonnull)mean:(Mat * _Nonnull)src mask:(Mat * _Nonnull)mask __attribute__((swift_name("mean(src:mask:)")));
		[Static]
		[Export ("mean:mask:")]
		Scalar Mean (Mat src, Mat mask);

		// +(Scalar * _Nonnull)mean:(Mat * _Nonnull)src __attribute__((swift_name("mean(src:)")));
		[Static]
		[Export ("mean:")]
		Scalar Mean (Mat src);

		// +(void)meanStdDev:(Mat * _Nonnull)src mean:(DoubleVector * _Nonnull)mean stddev:(DoubleVector * _Nonnull)stddev mask:(Mat * _Nonnull)mask __attribute__((swift_name("meanStdDev(src:mean:stddev:mask:)")));
		[Static]
		[Export ("meanStdDev:mean:stddev:mask:")]
		void MeanStdDev (Mat src, DoubleVector mean, DoubleVector stddev, Mat mask);

		// +(void)meanStdDev:(Mat * _Nonnull)src mean:(DoubleVector * _Nonnull)mean stddev:(DoubleVector * _Nonnull)stddev __attribute__((swift_name("meanStdDev(src:mean:stddev:)")));
		[Static]
		[Export ("meanStdDev:mean:stddev:")]
		void MeanStdDev (Mat src, DoubleVector mean, DoubleVector stddev);

		// +(double)norm:(Mat * _Nonnull)src1 normType:(NormTypes)normType mask:(Mat * _Nonnull)mask __attribute__((swift_name("norm(src1:normType:mask:)")));
		[Static]
		[Export ("norm:normType:mask:")]
		double Norm (Mat src1, NormTypes normType, Mat mask);

		// +(double)norm:(Mat * _Nonnull)src1 normType:(NormTypes)normType __attribute__((swift_name("norm(src1:normType:)")));
		[Static]
		[Export ("norm:normType:")]
		double Norm (Mat src1, NormTypes normType);

		// +(double)norm:(Mat * _Nonnull)src1 __attribute__((swift_name("norm(src1:)")));
		[Static]
		[Export ("norm:")]
		double Norm (Mat src1);

		// +(double)norm:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 normType:(NormTypes)normType mask:(Mat * _Nonnull)mask __attribute__((swift_name("norm(src1:src2:normType:mask:)")));
		[Static]
		[Export ("norm:src2:normType:mask:")]
		double Norm (Mat src1, Mat src2, NormTypes normType, Mat mask);

		// +(double)norm:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 normType:(NormTypes)normType __attribute__((swift_name("norm(src1:src2:normType:)")));
		[Static]
		[Export ("norm:src2:normType:")]
		double Norm (Mat src1, Mat src2, NormTypes normType);

		// +(double)norm:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 __attribute__((swift_name("norm(src1:src2:)")));
		[Static]
		[Export ("norm:src2:")]
		double Norm (Mat src1, Mat src2);

		// +(double)PSNR:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 R:(double)R __attribute__((swift_name("PSNR(src1:src2:R:)")));
		[Static]
		[Export ("PSNR:src2:R:")]
		double PSNR (Mat src1, Mat src2, double R);

		// +(double)PSNR:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 __attribute__((swift_name("PSNR(src1:src2:)")));
		[Static]
		[Export ("PSNR:src2:")]
		double PSNR (Mat src1, Mat src2);

		// +(void)batchDistance:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dist:(Mat * _Nonnull)dist dtype:(int)dtype nidx:(Mat * _Nonnull)nidx normType:(NormTypes)normType K:(int)K mask:(Mat * _Nonnull)mask update:(int)update crosscheck:(BOOL)crosscheck __attribute__((swift_name("batchDistance(src1:src2:dist:dtype:nidx:normType:K:mask:update:crosscheck:)")));
		[Static]
		[Export ("batchDistance:src2:dist:dtype:nidx:normType:K:mask:update:crosscheck:")]
		void BatchDistance (Mat src1, Mat src2, Mat dist, int dtype, Mat nidx, NormTypes normType, int K, Mat mask, int update, bool crosscheck);

		// +(void)batchDistance:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dist:(Mat * _Nonnull)dist dtype:(int)dtype nidx:(Mat * _Nonnull)nidx normType:(NormTypes)normType K:(int)K mask:(Mat * _Nonnull)mask update:(int)update __attribute__((swift_name("batchDistance(src1:src2:dist:dtype:nidx:normType:K:mask:update:)")));
		[Static]
		[Export ("batchDistance:src2:dist:dtype:nidx:normType:K:mask:update:")]
		void BatchDistance (Mat src1, Mat src2, Mat dist, int dtype, Mat nidx, NormTypes normType, int K, Mat mask, int update);

		// +(void)batchDistance:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dist:(Mat * _Nonnull)dist dtype:(int)dtype nidx:(Mat * _Nonnull)nidx normType:(NormTypes)normType K:(int)K mask:(Mat * _Nonnull)mask __attribute__((swift_name("batchDistance(src1:src2:dist:dtype:nidx:normType:K:mask:)")));
		[Static]
		[Export ("batchDistance:src2:dist:dtype:nidx:normType:K:mask:")]
		void BatchDistance (Mat src1, Mat src2, Mat dist, int dtype, Mat nidx, NormTypes normType, int K, Mat mask);

		// +(void)batchDistance:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dist:(Mat * _Nonnull)dist dtype:(int)dtype nidx:(Mat * _Nonnull)nidx normType:(NormTypes)normType K:(int)K __attribute__((swift_name("batchDistance(src1:src2:dist:dtype:nidx:normType:K:)")));
		[Static]
		[Export ("batchDistance:src2:dist:dtype:nidx:normType:K:")]
		void BatchDistance (Mat src1, Mat src2, Mat dist, int dtype, Mat nidx, NormTypes normType, int K);

		// +(void)batchDistance:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dist:(Mat * _Nonnull)dist dtype:(int)dtype nidx:(Mat * _Nonnull)nidx normType:(NormTypes)normType __attribute__((swift_name("batchDistance(src1:src2:dist:dtype:nidx:normType:)")));
		[Static]
		[Export ("batchDistance:src2:dist:dtype:nidx:normType:")]
		void BatchDistance (Mat src1, Mat src2, Mat dist, int dtype, Mat nidx, NormTypes normType);

		// +(void)batchDistance:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dist:(Mat * _Nonnull)dist dtype:(int)dtype nidx:(Mat * _Nonnull)nidx __attribute__((swift_name("batchDistance(src1:src2:dist:dtype:nidx:)")));
		[Static]
		[Export ("batchDistance:src2:dist:dtype:nidx:")]
		void BatchDistance (Mat src1, Mat src2, Mat dist, int dtype, Mat nidx);

		// +(void)normalize:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst alpha:(double)alpha beta:(double)beta norm_type:(NormTypes)norm_type dtype:(int)dtype mask:(Mat * _Nonnull)mask __attribute__((swift_name("normalize(src:dst:alpha:beta:norm_type:dtype:mask:)")));
		[Static]
		[Export ("normalize:dst:alpha:beta:norm_type:dtype:mask:")]
		void Normalize (Mat src, Mat dst, double alpha, double beta, NormTypes norm_type, int dtype, Mat mask);

		// +(void)normalize:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst alpha:(double)alpha beta:(double)beta norm_type:(NormTypes)norm_type dtype:(int)dtype __attribute__((swift_name("normalize(src:dst:alpha:beta:norm_type:dtype:)")));
		[Static]
		[Export ("normalize:dst:alpha:beta:norm_type:dtype:")]
		void Normalize (Mat src, Mat dst, double alpha, double beta, NormTypes norm_type, int dtype);

		// +(void)normalize:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst alpha:(double)alpha beta:(double)beta norm_type:(NormTypes)norm_type __attribute__((swift_name("normalize(src:dst:alpha:beta:norm_type:)")));
		[Static]
		[Export ("normalize:dst:alpha:beta:norm_type:")]
		void Normalize (Mat src, Mat dst, double alpha, double beta, NormTypes norm_type);

		// +(void)normalize:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst alpha:(double)alpha beta:(double)beta __attribute__((swift_name("normalize(src:dst:alpha:beta:)")));
		[Static]
		[Export ("normalize:dst:alpha:beta:")]
		void Normalize (Mat src, Mat dst, double alpha, double beta);

		// +(void)normalize:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst alpha:(double)alpha __attribute__((swift_name("normalize(src:dst:alpha:)")));
		[Static]
		[Export ("normalize:dst:alpha:")]
		void Normalize (Mat src, Mat dst, double alpha);

		// +(void)normalize:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("normalize(src:dst:)")));
		[Static]
		[Export ("normalize:dst:")]
		void Normalize (Mat src, Mat dst);

		// +(void)reduceArgMin:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst axis:(int)axis lastIndex:(BOOL)lastIndex __attribute__((swift_name("reduceArgMin(src:dst:axis:lastIndex:)")));
		[Static]
		[Export ("reduceArgMin:dst:axis:lastIndex:")]
		void ReduceArgMin (Mat src, Mat dst, int axis, bool lastIndex);

		// +(void)reduceArgMin:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst axis:(int)axis __attribute__((swift_name("reduceArgMin(src:dst:axis:)")));
		[Static]
		[Export ("reduceArgMin:dst:axis:")]
		void ReduceArgMin (Mat src, Mat dst, int axis);

		// +(void)reduceArgMax:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst axis:(int)axis lastIndex:(BOOL)lastIndex __attribute__((swift_name("reduceArgMax(src:dst:axis:lastIndex:)")));
		[Static]
		[Export ("reduceArgMax:dst:axis:lastIndex:")]
		void ReduceArgMax (Mat src, Mat dst, int axis, bool lastIndex);

		// +(void)reduceArgMax:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst axis:(int)axis __attribute__((swift_name("reduceArgMax(src:dst:axis:)")));
		[Static]
		[Export ("reduceArgMax:dst:axis:")]
		void ReduceArgMax (Mat src, Mat dst, int axis);

		// +(void)reduce:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst dim:(int)dim rtype:(int)rtype dtype:(int)dtype __attribute__((swift_name("reduce(src:dst:dim:rtype:dtype:)")));
		[Static]
		[Export ("reduce:dst:dim:rtype:dtype:")]
		void Reduce (Mat src, Mat dst, int dim, int rtype, int dtype);

		// +(void)reduce:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst dim:(int)dim rtype:(int)rtype __attribute__((swift_name("reduce(src:dst:dim:rtype:)")));
		[Static]
		[Export ("reduce:dst:dim:rtype:")]
		void Reduce (Mat src, Mat dst, int dim, int rtype);

		// +(void)merge:(NSArray<Mat *> * _Nonnull)mv dst:(Mat * _Nonnull)dst __attribute__((swift_name("merge(mv:dst:)")));
		[Static]
		[Export ("merge:dst:")]
		void Merge (Mat[] mv, Mat dst);

		// +(void)split:(Mat * _Nonnull)m mv:(NSMutableArray<Mat *> * _Nonnull)mv __attribute__((swift_name("split(m:mv:)")));
		[Static]
		[Export ("split:mv:")]
		void Split (Mat m, NSMutableArray<Mat> mv);

		// +(void)mixChannels:(NSArray<Mat *> * _Nonnull)src dst:(NSArray<Mat *> * _Nonnull)dst fromTo:(IntVector * _Nonnull)fromTo __attribute__((swift_name("mixChannels(src:dst:fromTo:)")));
		[Static]
		[Export ("mixChannels:dst:fromTo:")]
		void MixChannels (Mat[] src, Mat[] dst, IntVector fromTo);

		// +(void)extractChannel:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst coi:(int)coi __attribute__((swift_name("extractChannel(src:dst:coi:)")));
		[Static]
		[Export ("extractChannel:dst:coi:")]
		void ExtractChannel (Mat src, Mat dst, int coi);

		// +(void)insertChannel:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst coi:(int)coi __attribute__((swift_name("insertChannel(src:dst:coi:)")));
		[Static]
		[Export ("insertChannel:dst:coi:")]
		void InsertChannel (Mat src, Mat dst, int coi);

		// +(void)flip:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst flipCode:(int)flipCode __attribute__((swift_name("flip(src:dst:flipCode:)")));
		[Static]
		[Export ("flip:dst:flipCode:")]
		void Flip (Mat src, Mat dst, int flipCode);

		// +(void)flipND:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst axis:(int)axis __attribute__((swift_name("flipND(src:dst:axis:)")));
		[Static]
		[Export ("flipND:dst:axis:")]
		void FlipND (Mat src, Mat dst, int axis);

		// +(void)broadcast:(Mat * _Nonnull)src shape:(Mat * _Nonnull)shape dst:(Mat * _Nonnull)dst __attribute__((swift_name("broadcast(src:shape:dst:)")));
		[Static]
		[Export ("broadcast:shape:dst:")]
		void Broadcast (Mat src, Mat shape, Mat dst);

		// +(void)rotate:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst rotateCode:(RotateFlags)rotateCode __attribute__((swift_name("rotate(src:dst:rotateCode:)")));
		[Static]
		[Export ("rotate:dst:rotateCode:")]
		void Rotate (Mat src, Mat dst, RotateFlags rotateCode);

		// +(void)repeat:(Mat * _Nonnull)src ny:(int)ny nx:(int)nx dst:(Mat * _Nonnull)dst __attribute__((swift_name("repeat(src:ny:nx:dst:)")));
		[Static]
		[Export ("repeat:ny:nx:dst:")]
		void Repeat (Mat src, int ny, int nx, Mat dst);

		// +(void)hconcat:(NSArray<Mat *> * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("hconcat(src:dst:)")));
		[Static]
		[Export ("hconcat:dst:")]
		void Hconcat (Mat[] src, Mat dst);

		// +(void)vconcat:(NSArray<Mat *> * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("vconcat(src:dst:)")));
		[Static]
		[Export ("vconcat:dst:")]
		void Vconcat (Mat[] src, Mat dst);

		// +(void)bitwise_and:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask __attribute__((swift_name("bitwise_and(src1:src2:dst:mask:)")));
		[Static]
		[Export ("bitwise_and:src2:dst:mask:")]
		void Bitwise_and (Mat src1, Mat src2, Mat dst, Mat mask);

		// +(void)bitwise_and:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst __attribute__((swift_name("bitwise_and(src1:src2:dst:)")));
		[Static]
		[Export ("bitwise_and:src2:dst:")]
		void Bitwise_and (Mat src1, Mat src2, Mat dst);

		// +(void)bitwise_or:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask __attribute__((swift_name("bitwise_or(src1:src2:dst:mask:)")));
		[Static]
		[Export ("bitwise_or:src2:dst:mask:")]
		void Bitwise_or (Mat src1, Mat src2, Mat dst, Mat mask);

		// +(void)bitwise_or:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst __attribute__((swift_name("bitwise_or(src1:src2:dst:)")));
		[Static]
		[Export ("bitwise_or:src2:dst:")]
		void Bitwise_or (Mat src1, Mat src2, Mat dst);

		// +(void)bitwise_xor:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask __attribute__((swift_name("bitwise_xor(src1:src2:dst:mask:)")));
		[Static]
		[Export ("bitwise_xor:src2:dst:mask:")]
		void Bitwise_xor (Mat src1, Mat src2, Mat dst, Mat mask);

		// +(void)bitwise_xor:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst __attribute__((swift_name("bitwise_xor(src1:src2:dst:)")));
		[Static]
		[Export ("bitwise_xor:src2:dst:")]
		void Bitwise_xor (Mat src1, Mat src2, Mat dst);

		// +(void)bitwise_not:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask __attribute__((swift_name("bitwise_not(src:dst:mask:)")));
		[Static]
		[Export ("bitwise_not:dst:mask:")]
		void Bitwise_not (Mat src, Mat dst, Mat mask);

		// +(void)bitwise_not:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("bitwise_not(src:dst:)")));
		[Static]
		[Export ("bitwise_not:dst:")]
		void Bitwise_not (Mat src, Mat dst);

		// +(void)absdiff:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst __attribute__((swift_name("absdiff(src1:src2:dst:)")));
		[Static]
		[Export ("absdiff:src2:dst:")]
		void Absdiff (Mat src1, Mat src2, Mat dst);

		// +(void)copyTo:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask __attribute__((swift_name("copyTo(src:dst:mask:)")));
		[Static]
		[Export ("copyTo:dst:mask:")]
		void CopyTo (Mat src, Mat dst, Mat mask);

		// +(void)inRange:(Mat * _Nonnull)src lowerb:(Scalar * _Nonnull)lowerb upperb:(Scalar * _Nonnull)upperb dst:(Mat * _Nonnull)dst __attribute__((swift_name("inRange(src:lowerb:upperb:dst:)")));
		[Static]
		[Export ("inRange:lowerb:upperb:dst:")]
		void InRange (Mat src, Scalar lowerb, Scalar upperb, Mat dst);

		// +(void)compare:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst cmpop:(CmpTypes)cmpop __attribute__((swift_name("compare(src1:src2:dst:cmpop:)")));
		[Static]
		[Export ("compare:src2:dst:cmpop:")]
		void Compare (Mat src1, Mat src2, Mat dst, CmpTypes cmpop);

		// +(void)min:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst __attribute__((swift_name("min(src1:src2:dst:)")));
		[Static]
		[Export ("min:src2:dst:")]
		void Min (Mat src1, Mat src2, Mat dst);

		// +(void)max:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst __attribute__((swift_name("max(src1:src2:dst:)")));
		[Static]
		[Export ("max:src2:dst:")]
		void Max (Mat src1, Mat src2, Mat dst);

		// +(void)sqrt:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("sqrt(src:dst:)")));
		[Static]
		[Export ("sqrt:dst:")]
		void Sqrt (Mat src, Mat dst);

		// +(void)pow:(Mat * _Nonnull)src power:(double)power dst:(Mat * _Nonnull)dst __attribute__((swift_name("pow(src:power:dst:)")));
		[Static]
		[Export ("pow:power:dst:")]
		void Pow (Mat src, double power, Mat dst);

		// +(void)exp:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("exp(src:dst:)")));
		[Static]
		[Export ("exp:dst:")]
		void Exp (Mat src, Mat dst);

		// +(void)log:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("log(src:dst:)")));
		[Static]
		[Export ("log:dst:")]
		void Log (Mat src, Mat dst);

		// +(void)polarToCart:(Mat * _Nonnull)magnitude angle:(Mat * _Nonnull)angle x:(Mat * _Nonnull)x y:(Mat * _Nonnull)y angleInDegrees:(BOOL)angleInDegrees __attribute__((swift_name("polarToCart(magnitude:angle:x:y:angleInDegrees:)")));
		[Static]
		[Export ("polarToCart:angle:x:y:angleInDegrees:")]
		void PolarToCart (Mat magnitude, Mat angle, Mat x, Mat y, bool angleInDegrees);

		// +(void)polarToCart:(Mat * _Nonnull)magnitude angle:(Mat * _Nonnull)angle x:(Mat * _Nonnull)x y:(Mat * _Nonnull)y __attribute__((swift_name("polarToCart(magnitude:angle:x:y:)")));
		[Static]
		[Export ("polarToCart:angle:x:y:")]
		void PolarToCart (Mat magnitude, Mat angle, Mat x, Mat y);

		// +(void)cartToPolar:(Mat * _Nonnull)x y:(Mat * _Nonnull)y magnitude:(Mat * _Nonnull)magnitude angle:(Mat * _Nonnull)angle angleInDegrees:(BOOL)angleInDegrees __attribute__((swift_name("cartToPolar(x:y:magnitude:angle:angleInDegrees:)")));
		[Static]
		[Export ("cartToPolar:y:magnitude:angle:angleInDegrees:")]
		void CartToPolar (Mat x, Mat y, Mat magnitude, Mat angle, bool angleInDegrees);

		// +(void)cartToPolar:(Mat * _Nonnull)x y:(Mat * _Nonnull)y magnitude:(Mat * _Nonnull)magnitude angle:(Mat * _Nonnull)angle __attribute__((swift_name("cartToPolar(x:y:magnitude:angle:)")));
		[Static]
		[Export ("cartToPolar:y:magnitude:angle:")]
		void CartToPolar (Mat x, Mat y, Mat magnitude, Mat angle);

		// +(void)phase:(Mat * _Nonnull)x y:(Mat * _Nonnull)y angle:(Mat * _Nonnull)angle angleInDegrees:(BOOL)angleInDegrees __attribute__((swift_name("phase(x:y:angle:angleInDegrees:)")));
		[Static]
		[Export ("phase:y:angle:angleInDegrees:")]
		void Phase (Mat x, Mat y, Mat angle, bool angleInDegrees);

		// +(void)phase:(Mat * _Nonnull)x y:(Mat * _Nonnull)y angle:(Mat * _Nonnull)angle __attribute__((swift_name("phase(x:y:angle:)")));
		[Static]
		[Export ("phase:y:angle:")]
		void Phase (Mat x, Mat y, Mat angle);

		// +(void)magnitude:(Mat * _Nonnull)x y:(Mat * _Nonnull)y magnitude:(Mat * _Nonnull)magnitude __attribute__((swift_name("magnitude(x:y:magnitude:)")));
		[Static]
		[Export ("magnitude:y:magnitude:")]
		void Magnitude (Mat x, Mat y, Mat magnitude);

		// +(BOOL)checkRange:(Mat * _Nonnull)a quiet:(BOOL)quiet minVal:(double)minVal maxVal:(double)maxVal __attribute__((swift_name("checkRange(a:quiet:minVal:maxVal:)")));
		[Static]
		[Export ("checkRange:quiet:minVal:maxVal:")]
		bool CheckRange (Mat a, bool quiet, double minVal, double maxVal);

		// +(BOOL)checkRange:(Mat * _Nonnull)a quiet:(BOOL)quiet minVal:(double)minVal __attribute__((swift_name("checkRange(a:quiet:minVal:)")));
		[Static]
		[Export ("checkRange:quiet:minVal:")]
		bool CheckRange (Mat a, bool quiet, double minVal);

		// +(BOOL)checkRange:(Mat * _Nonnull)a quiet:(BOOL)quiet __attribute__((swift_name("checkRange(a:quiet:)")));
		[Static]
		[Export ("checkRange:quiet:")]
		bool CheckRange (Mat a, bool quiet);

		// +(BOOL)checkRange:(Mat * _Nonnull)a __attribute__((swift_name("checkRange(a:)")));
		[Static]
		[Export ("checkRange:")]
		bool CheckRange (Mat a);

		// +(void)patchNaNs:(Mat * _Nonnull)a val:(double)val __attribute__((swift_name("patchNaNs(a:val:)")));
		[Static]
		[Export ("patchNaNs:val:")]
		void PatchNaNs (Mat a, double val);

		// +(void)patchNaNs:(Mat * _Nonnull)a __attribute__((swift_name("patchNaNs(a:)")));
		[Static]
		[Export ("patchNaNs:")]
		void PatchNaNs (Mat a);

		// +(void)gemm:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 alpha:(double)alpha src3:(Mat * _Nonnull)src3 beta:(double)beta dst:(Mat * _Nonnull)dst flags:(int)flags __attribute__((swift_name("gemm(src1:src2:alpha:src3:beta:dst:flags:)")));
		[Static]
		[Export ("gemm:src2:alpha:src3:beta:dst:flags:")]
		void Gemm (Mat src1, Mat src2, double alpha, Mat src3, double beta, Mat dst, int flags);

		// +(void)gemm:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 alpha:(double)alpha src3:(Mat * _Nonnull)src3 beta:(double)beta dst:(Mat * _Nonnull)dst __attribute__((swift_name("gemm(src1:src2:alpha:src3:beta:dst:)")));
		[Static]
		[Export ("gemm:src2:alpha:src3:beta:dst:")]
		void Gemm (Mat src1, Mat src2, double alpha, Mat src3, double beta, Mat dst);

		// +(void)mulTransposed:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst aTa:(BOOL)aTa delta:(Mat * _Nonnull)delta scale:(double)scale dtype:(int)dtype __attribute__((swift_name("mulTransposed(src:dst:aTa:delta:scale:dtype:)")));
		[Static]
		[Export ("mulTransposed:dst:aTa:delta:scale:dtype:")]
		void MulTransposed (Mat src, Mat dst, bool aTa, Mat delta, double scale, int dtype);

		// +(void)mulTransposed:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst aTa:(BOOL)aTa delta:(Mat * _Nonnull)delta scale:(double)scale __attribute__((swift_name("mulTransposed(src:dst:aTa:delta:scale:)")));
		[Static]
		[Export ("mulTransposed:dst:aTa:delta:scale:")]
		void MulTransposed (Mat src, Mat dst, bool aTa, Mat delta, double scale);

		// +(void)mulTransposed:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst aTa:(BOOL)aTa delta:(Mat * _Nonnull)delta __attribute__((swift_name("mulTransposed(src:dst:aTa:delta:)")));
		[Static]
		[Export ("mulTransposed:dst:aTa:delta:")]
		void MulTransposed (Mat src, Mat dst, bool aTa, Mat delta);

		// +(void)mulTransposed:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst aTa:(BOOL)aTa __attribute__((swift_name("mulTransposed(src:dst:aTa:)")));
		[Static]
		[Export ("mulTransposed:dst:aTa:")]
		void MulTransposed (Mat src, Mat dst, bool aTa);

		// +(void)transpose:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("transpose(src:dst:)")));
		[Static]
		[Export ("transpose:dst:")]
		void Transpose (Mat src, Mat dst);

		// +(void)transposeND:(Mat * _Nonnull)src order:(IntVector * _Nonnull)order dst:(Mat * _Nonnull)dst __attribute__((swift_name("transposeND(src:order:dst:)")));
		[Static]
		[Export ("transposeND:order:dst:")]
		void TransposeND (Mat src, IntVector order, Mat dst);

		// +(void)transform:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst m:(Mat * _Nonnull)m __attribute__((swift_name("transform(src:dst:m:)")));
		[Static]
		[Export ("transform:dst:m:")]
		void Transform (Mat src, Mat dst, Mat m);

		// +(void)perspectiveTransform:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst m:(Mat * _Nonnull)m __attribute__((swift_name("perspectiveTransform(src:dst:m:)")));
		[Static]
		[Export ("perspectiveTransform:dst:m:")]
		void PerspectiveTransform (Mat src, Mat dst, Mat m);

		// +(void)completeSymm:(Mat * _Nonnull)m lowerToUpper:(BOOL)lowerToUpper __attribute__((swift_name("completeSymm(m:lowerToUpper:)")));
		[Static]
		[Export ("completeSymm:lowerToUpper:")]
		void CompleteSymm (Mat m, bool lowerToUpper);

		// +(void)completeSymm:(Mat * _Nonnull)m __attribute__((swift_name("completeSymm(m:)")));
		[Static]
		[Export ("completeSymm:")]
		void CompleteSymm (Mat m);

		// +(void)setIdentity:(Mat * _Nonnull)mtx s:(Scalar * _Nonnull)s __attribute__((swift_name("setIdentity(mtx:s:)")));
		[Static]
		[Export ("setIdentity:s:")]
		void SetIdentity (Mat mtx, Scalar s);

		// +(void)setIdentity:(Mat * _Nonnull)mtx __attribute__((swift_name("setIdentity(mtx:)")));
		[Static]
		[Export ("setIdentity:")]
		void SetIdentity (Mat mtx);

		// +(double)determinant:(Mat * _Nonnull)mtx __attribute__((swift_name("determinant(mtx:)")));
		[Static]
		[Export ("determinant:")]
		double Determinant (Mat mtx);

		// +(Scalar * _Nonnull)trace:(Mat * _Nonnull)mtx __attribute__((swift_name("trace(mtx:)")));
		[Static]
		[Export ("trace:")]
		Scalar Trace (Mat mtx);

		// +(double)invert:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst flags:(int)flags __attribute__((swift_name("invert(src:dst:flags:)")));
		[Static]
		[Export ("invert:dst:flags:")]
		double Invert (Mat src, Mat dst, int flags);

		// +(double)invert:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("invert(src:dst:)")));
		[Static]
		[Export ("invert:dst:")]
		double Invert (Mat src, Mat dst);

		// +(BOOL)solve:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst flags:(int)flags __attribute__((swift_name("solve(src1:src2:dst:flags:)")));
		[Static]
		[Export ("solve:src2:dst:flags:")]
		bool Solve (Mat src1, Mat src2, Mat dst, int flags);

		// +(BOOL)solve:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst __attribute__((swift_name("solve(src1:src2:dst:)")));
		[Static]
		[Export ("solve:src2:dst:")]
		bool Solve (Mat src1, Mat src2, Mat dst);

		// +(void)sort:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst flags:(int)flags __attribute__((swift_name("sort(src:dst:flags:)")));
		[Static]
		[Export ("sort:dst:flags:")]
		void Sort (Mat src, Mat dst, int flags);

		// +(void)sortIdx:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst flags:(int)flags __attribute__((swift_name("sortIdx(src:dst:flags:)")));
		[Static]
		[Export ("sortIdx:dst:flags:")]
		void SortIdx (Mat src, Mat dst, int flags);

		// +(int)solveCubic:(Mat * _Nonnull)coeffs roots:(Mat * _Nonnull)roots __attribute__((swift_name("solveCubic(coeffs:roots:)")));
		[Static]
		[Export ("solveCubic:roots:")]
		int SolveCubic (Mat coeffs, Mat roots);

		// +(double)solvePoly:(Mat * _Nonnull)coeffs roots:(Mat * _Nonnull)roots maxIters:(int)maxIters __attribute__((swift_name("solvePoly(coeffs:roots:maxIters:)")));
		[Static]
		[Export ("solvePoly:roots:maxIters:")]
		double SolvePoly (Mat coeffs, Mat roots, int maxIters);

		// +(double)solvePoly:(Mat * _Nonnull)coeffs roots:(Mat * _Nonnull)roots __attribute__((swift_name("solvePoly(coeffs:roots:)")));
		[Static]
		[Export ("solvePoly:roots:")]
		double SolvePoly (Mat coeffs, Mat roots);

		// +(BOOL)eigen:(Mat * _Nonnull)src eigenvalues:(Mat * _Nonnull)eigenvalues eigenvectors:(Mat * _Nonnull)eigenvectors __attribute__((swift_name("eigen(src:eigenvalues:eigenvectors:)")));
		[Static]
		[Export ("eigen:eigenvalues:eigenvectors:")]
		bool Eigen (Mat src, Mat eigenvalues, Mat eigenvectors);

		// +(BOOL)eigen:(Mat * _Nonnull)src eigenvalues:(Mat * _Nonnull)eigenvalues __attribute__((swift_name("eigen(src:eigenvalues:)")));
		[Static]
		[Export ("eigen:eigenvalues:")]
		bool Eigen (Mat src, Mat eigenvalues);

		// +(void)eigenNonSymmetric:(Mat * _Nonnull)src eigenvalues:(Mat * _Nonnull)eigenvalues eigenvectors:(Mat * _Nonnull)eigenvectors __attribute__((swift_name("eigenNonSymmetric(src:eigenvalues:eigenvectors:)")));
		[Static]
		[Export ("eigenNonSymmetric:eigenvalues:eigenvectors:")]
		void EigenNonSymmetric (Mat src, Mat eigenvalues, Mat eigenvectors);

		// +(void)calcCovarMatrix:(Mat * _Nonnull)samples covar:(Mat * _Nonnull)covar mean:(Mat * _Nonnull)mean flags:(int)flags ctype:(int)ctype __attribute__((swift_name("calcCovarMatrix(samples:covar:mean:flags:ctype:)")));
		[Static]
		[Export ("calcCovarMatrix:covar:mean:flags:ctype:")]
		void CalcCovarMatrix (Mat samples, Mat covar, Mat mean, int flags, int ctype);

		// +(void)calcCovarMatrix:(Mat * _Nonnull)samples covar:(Mat * _Nonnull)covar mean:(Mat * _Nonnull)mean flags:(int)flags __attribute__((swift_name("calcCovarMatrix(samples:covar:mean:flags:)")));
		[Static]
		[Export ("calcCovarMatrix:covar:mean:flags:")]
		void CalcCovarMatrix (Mat samples, Mat covar, Mat mean, int flags);

		// +(void)PCACompute:(Mat * _Nonnull)data mean:(Mat * _Nonnull)mean eigenvectors:(Mat * _Nonnull)eigenvectors maxComponents:(int)maxComponents __attribute__((swift_name("PCACompute(data:mean:eigenvectors:maxComponents:)")));
		[Static]
		[Export ("PCACompute:mean:eigenvectors:maxComponents:")]
		void PCACompute (Mat data, Mat mean, Mat eigenvectors, int maxComponents);

		// +(void)PCACompute:(Mat * _Nonnull)data mean:(Mat * _Nonnull)mean eigenvectors:(Mat * _Nonnull)eigenvectors __attribute__((swift_name("PCACompute(data:mean:eigenvectors:)")));
		[Static]
		[Export ("PCACompute:mean:eigenvectors:")]
		void PCACompute (Mat data, Mat mean, Mat eigenvectors);

		// +(void)PCACompute2:(Mat * _Nonnull)data mean:(Mat * _Nonnull)mean eigenvectors:(Mat * _Nonnull)eigenvectors eigenvalues:(Mat * _Nonnull)eigenvalues maxComponents:(int)maxComponents __attribute__((swift_name("PCACompute(data:mean:eigenvectors:eigenvalues:maxComponents:)")));
		[Static]
		[Export ("PCACompute2:mean:eigenvectors:eigenvalues:maxComponents:")]
		void PCACompute2 (Mat data, Mat mean, Mat eigenvectors, Mat eigenvalues, int maxComponents);

		// +(void)PCACompute2:(Mat * _Nonnull)data mean:(Mat * _Nonnull)mean eigenvectors:(Mat * _Nonnull)eigenvectors eigenvalues:(Mat * _Nonnull)eigenvalues __attribute__((swift_name("PCACompute(data:mean:eigenvectors:eigenvalues:)")));
		[Static]
		[Export ("PCACompute2:mean:eigenvectors:eigenvalues:")]
		void PCACompute2 (Mat data, Mat mean, Mat eigenvectors, Mat eigenvalues);

		// +(void)PCACompute:(Mat * _Nonnull)data mean:(Mat * _Nonnull)mean eigenvectors:(Mat * _Nonnull)eigenvectors retainedVariance:(double)retainedVariance __attribute__((swift_name("PCACompute(data:mean:eigenvectors:retainedVariance:)")));
		[Static]
		[Export ("PCACompute:mean:eigenvectors:retainedVariance:")]
		void PCACompute (Mat data, Mat mean, Mat eigenvectors, double retainedVariance);

		// +(void)PCACompute2:(Mat * _Nonnull)data mean:(Mat * _Nonnull)mean eigenvectors:(Mat * _Nonnull)eigenvectors eigenvalues:(Mat * _Nonnull)eigenvalues retainedVariance:(double)retainedVariance __attribute__((swift_name("PCACompute(data:mean:eigenvectors:eigenvalues:retainedVariance:)")));
		[Static]
		[Export ("PCACompute2:mean:eigenvectors:eigenvalues:retainedVariance:")]
		void PCACompute2 (Mat data, Mat mean, Mat eigenvectors, Mat eigenvalues, double retainedVariance);

		// +(void)PCAProject:(Mat * _Nonnull)data mean:(Mat * _Nonnull)mean eigenvectors:(Mat * _Nonnull)eigenvectors result:(Mat * _Nonnull)result __attribute__((swift_name("PCAProject(data:mean:eigenvectors:result:)")));
		[Static]
		[Export ("PCAProject:mean:eigenvectors:result:")]
		void PCAProject (Mat data, Mat mean, Mat eigenvectors, Mat result);

		// +(void)PCABackProject:(Mat * _Nonnull)data mean:(Mat * _Nonnull)mean eigenvectors:(Mat * _Nonnull)eigenvectors result:(Mat * _Nonnull)result __attribute__((swift_name("PCABackProject(data:mean:eigenvectors:result:)")));
		[Static]
		[Export ("PCABackProject:mean:eigenvectors:result:")]
		void PCABackProject (Mat data, Mat mean, Mat eigenvectors, Mat result);

		// +(void)SVDecomp:(Mat * _Nonnull)src w:(Mat * _Nonnull)w u:(Mat * _Nonnull)u vt:(Mat * _Nonnull)vt flags:(int)flags __attribute__((swift_name("SVDecomp(src:w:u:vt:flags:)")));
		[Static]
		[Export ("SVDecomp:w:u:vt:flags:")]
		void SVDecomp (Mat src, Mat w, Mat u, Mat vt, int flags);

		// +(void)SVDecomp:(Mat * _Nonnull)src w:(Mat * _Nonnull)w u:(Mat * _Nonnull)u vt:(Mat * _Nonnull)vt __attribute__((swift_name("SVDecomp(src:w:u:vt:)")));
		[Static]
		[Export ("SVDecomp:w:u:vt:")]
		void SVDecomp (Mat src, Mat w, Mat u, Mat vt);

		// +(void)SVBackSubst:(Mat * _Nonnull)w u:(Mat * _Nonnull)u vt:(Mat * _Nonnull)vt rhs:(Mat * _Nonnull)rhs dst:(Mat * _Nonnull)dst __attribute__((swift_name("SVBackSubst(w:u:vt:rhs:dst:)")));
		[Static]
		[Export ("SVBackSubst:u:vt:rhs:dst:")]
		void SVBackSubst (Mat w, Mat u, Mat vt, Mat rhs, Mat dst);

		// +(double)Mahalanobis:(Mat * _Nonnull)v1 v2:(Mat * _Nonnull)v2 icovar:(Mat * _Nonnull)icovar __attribute__((swift_name("Mahalanobis(v1:v2:icovar:)")));
		[Static]
		[Export ("Mahalanobis:v2:icovar:")]
		double Mahalanobis (Mat v1, Mat v2, Mat icovar);

		// +(void)dft:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst flags:(int)flags nonzeroRows:(int)nonzeroRows __attribute__((swift_name("dft(src:dst:flags:nonzeroRows:)")));
		[Static]
		[Export ("dft:dst:flags:nonzeroRows:")]
		void Dft (Mat src, Mat dst, int flags, int nonzeroRows);

		// +(void)dft:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst flags:(int)flags __attribute__((swift_name("dft(src:dst:flags:)")));
		[Static]
		[Export ("dft:dst:flags:")]
		void Dft (Mat src, Mat dst, int flags);

		// +(void)dft:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("dft(src:dst:)")));
		[Static]
		[Export ("dft:dst:")]
		void Dft (Mat src, Mat dst);

		// +(void)idft:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst flags:(int)flags nonzeroRows:(int)nonzeroRows __attribute__((swift_name("idft(src:dst:flags:nonzeroRows:)")));
		[Static]
		[Export ("idft:dst:flags:nonzeroRows:")]
		void Idft (Mat src, Mat dst, int flags, int nonzeroRows);

		// +(void)idft:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst flags:(int)flags __attribute__((swift_name("idft(src:dst:flags:)")));
		[Static]
		[Export ("idft:dst:flags:")]
		void Idft (Mat src, Mat dst, int flags);

		// +(void)idft:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("idft(src:dst:)")));
		[Static]
		[Export ("idft:dst:")]
		void Idft (Mat src, Mat dst);

		// +(void)dct:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst flags:(int)flags __attribute__((swift_name("dct(src:dst:flags:)")));
		[Static]
		[Export ("dct:dst:flags:")]
		void Dct (Mat src, Mat dst, int flags);

		// +(void)dct:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("dct(src:dst:)")));
		[Static]
		[Export ("dct:dst:")]
		void Dct (Mat src, Mat dst);

		// +(void)idct:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst flags:(int)flags __attribute__((swift_name("idct(src:dst:flags:)")));
		[Static]
		[Export ("idct:dst:flags:")]
		void Idct (Mat src, Mat dst, int flags);

		// +(void)idct:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("idct(src:dst:)")));
		[Static]
		[Export ("idct:dst:")]
		void Idct (Mat src, Mat dst);

		// +(void)mulSpectrums:(Mat * _Nonnull)a b:(Mat * _Nonnull)b c:(Mat * _Nonnull)c flags:(int)flags conjB:(BOOL)conjB __attribute__((swift_name("mulSpectrums(a:b:c:flags:conjB:)")));
		[Static]
		[Export ("mulSpectrums:b:c:flags:conjB:")]
		void MulSpectrums (Mat a, Mat b, Mat c, int flags, bool conjB);

		// +(void)mulSpectrums:(Mat * _Nonnull)a b:(Mat * _Nonnull)b c:(Mat * _Nonnull)c flags:(int)flags __attribute__((swift_name("mulSpectrums(a:b:c:flags:)")));
		[Static]
		[Export ("mulSpectrums:b:c:flags:")]
		void MulSpectrums (Mat a, Mat b, Mat c, int flags);

		// +(int)getOptimalDFTSize:(int)vecsize __attribute__((swift_name("getOptimalDFTSize(vecsize:)")));
		[Static]
		[Export ("getOptimalDFTSize:")]
		int GetOptimalDFTSize (int vecsize);

		// +(void)setRNGSeed:(int)seed __attribute__((swift_name("setRNGSeed(seed:)")));
		[Static]
		[Export ("setRNGSeed:")]
		void SetRNGSeed (int seed);

		// +(void)randu:(Mat * _Nonnull)dst low:(double)low high:(double)high __attribute__((swift_name("randu(dst:low:high:)")));
		[Static]
		[Export ("randu:low:high:")]
		void Randu (Mat dst, double low, double high);

		// +(void)randn:(Mat * _Nonnull)dst mean:(double)mean stddev:(double)stddev __attribute__((swift_name("randn(dst:mean:stddev:)")));
		[Static]
		[Export ("randn:mean:stddev:")]
		void Randn (Mat dst, double mean, double stddev);

		// +(void)randShuffle:(Mat * _Nonnull)dst iterFactor:(double)iterFactor __attribute__((swift_name("randShuffle(dst:iterFactor:)")));
		[Static]
		[Export ("randShuffle:iterFactor:")]
		void RandShuffle (Mat dst, double iterFactor);

		// +(void)randShuffle:(Mat * _Nonnull)dst __attribute__((swift_name("randShuffle(dst:)")));
		[Static]
		[Export ("randShuffle:")]
		void RandShuffle (Mat dst);

		// +(double)kmeans:(Mat * _Nonnull)data K:(int)K bestLabels:(Mat * _Nonnull)bestLabels criteria:(TermCriteria * _Nonnull)criteria attempts:(int)attempts flags:(int)flags centers:(Mat * _Nonnull)centers __attribute__((swift_name("kmeans(data:K:bestLabels:criteria:attempts:flags:centers:)")));
		[Static]
		[Export ("kmeans:K:bestLabels:criteria:attempts:flags:centers:")]
		double Kmeans (Mat data, int K, Mat bestLabels, TermCriteria criteria, int attempts, int flags, Mat centers);

		// +(double)kmeans:(Mat * _Nonnull)data K:(int)K bestLabels:(Mat * _Nonnull)bestLabels criteria:(TermCriteria * _Nonnull)criteria attempts:(int)attempts flags:(int)flags __attribute__((swift_name("kmeans(data:K:bestLabels:criteria:attempts:flags:)")));
		[Static]
		[Export ("kmeans:K:bestLabels:criteria:attempts:flags:")]
		double Kmeans (Mat data, int K, Mat bestLabels, TermCriteria criteria, int attempts, int flags);

		// +(void)setNumThreads:(int)nthreads __attribute__((swift_name("setNumThreads(nthreads:)")));
		[Static]
		[Export ("setNumThreads:")]
		void SetNumThreads (int nthreads);

		// +(int)getNumThreads __attribute__((swift_name("getNumThreads()")));
		[Static]
		[Export ("getNumThreads")]
		int GetNumThreads ();

		// +(int)getThreadNum __attribute__((swift_name("getThreadNum()"))) __attribute__((deprecated("")));
		[Static]
		[Export ("getThreadNum")]
		int GetThreadNum ();

		// +(NSString * _Nonnull)getBuildInformation __attribute__((swift_name("getBuildInformation()")));
		[Static]
		[Export ("getBuildInformation")]
		string GetBuildInformation ();

		// +(NSString * _Nonnull)getVersionString __attribute__((swift_name("getVersionString()")));
		[Static]
		[Export ("getVersionString")]
		string GetVersionString ();

		// +(int)getVersionMajor __attribute__((swift_name("getVersionMajor()")));
		[Static]
		[Export ("getVersionMajor")]
		int GetVersionMajor ();

		// +(int)getVersionMinor __attribute__((swift_name("getVersionMinor()")));
		[Static]
		[Export ("getVersionMinor")]
		int GetVersionMinor ();

		// +(int)getVersionRevision __attribute__((swift_name("getVersionRevision()")));
		[Static]
		[Export ("getVersionRevision")]
		int GetVersionRevision ();

		// +(long)getTickCount __attribute__((swift_name("getTickCount()")));
		[Static]
		[Export ("getTickCount")]
		nint GetTickCount ();

		// +(double)getTickFrequency __attribute__((swift_name("getTickFrequency()")));
		[Static]
		[Export ("getTickFrequency")]
		double GetTickFrequency ();

		// +(long)getCPUTickCount __attribute__((swift_name("getCPUTickCount()")));
		[Static]
		[Export ("getCPUTickCount")]
		nint GetCPUTickCount ();

		// +(NSString * _Nonnull)getHardwareFeatureName:(int)feature __attribute__((swift_name("getHardwareFeatureName(feature:)")));
		[Static]
		[Export ("getHardwareFeatureName:")]
		string GetHardwareFeatureName (int feature);

		// +(NSString * _Nonnull)getCPUFeaturesLine __attribute__((swift_name("getCPUFeaturesLine()")));
		[Static]
		[Export ("getCPUFeaturesLine")]
		string GetCPUFeaturesLine ();

		// +(int)getNumberOfCPUs __attribute__((swift_name("getNumberOfCPUs()")));
		[Static]
		[Export ("getNumberOfCPUs")]
		int GetNumberOfCPUs ();

		// +(AlgorithmHint)getDefaultAlgorithmHint __attribute__((swift_name("getDefaultAlgorithmHint()")));
		[Static]
		[Export ("getDefaultAlgorithmHint")]
		AlgorithmHint GetDefaultAlgorithmHint ();

		// +(NSString * _Nonnull)findFile:(NSString * _Nonnull)relative_path required:(BOOL)required silentMode:(BOOL)silentMode __attribute__((swift_name("findFile(relative_path:required:silentMode:)")));
		[Static]
		[Export ("findFile:required:silentMode:")]
		string FindFile (string relative_path, bool required, bool silentMode);

		// +(NSString * _Nonnull)findFile:(NSString * _Nonnull)relative_path required:(BOOL)required __attribute__((swift_name("findFile(relative_path:required:)")));
		[Static]
		[Export ("findFile:required:")]
		string FindFile (string relative_path, bool required);

		// +(NSString * _Nonnull)findFile:(NSString * _Nonnull)relative_path __attribute__((swift_name("findFile(relative_path:)")));
		[Static]
		[Export ("findFile:")]
		string FindFile (string relative_path);

		// +(NSString * _Nonnull)findFileOrKeep:(NSString * _Nonnull)relative_path silentMode:(BOOL)silentMode __attribute__((swift_name("findFileOrKeep(relative_path:silentMode:)")));
		[Static]
		[Export ("findFileOrKeep:silentMode:")]
		string FindFileOrKeep (string relative_path, bool silentMode);

		// +(NSString * _Nonnull)findFileOrKeep:(NSString * _Nonnull)relative_path __attribute__((swift_name("findFileOrKeep(relative_path:)")));
		[Static]
		[Export ("findFileOrKeep:")]
		string FindFileOrKeep (string relative_path);

		// +(void)addSamplesDataSearchPath:(NSString * _Nonnull)path __attribute__((swift_name("addSamplesDataSearchPath(path:)")));
		[Static]
		[Export ("addSamplesDataSearchPath:")]
		void AddSamplesDataSearchPath (string path);

		// +(void)addSamplesDataSearchSubDirectory:(NSString * _Nonnull)subdir __attribute__((swift_name("addSamplesDataSearchSubDirectory(subdir:)")));
		[Static]
		[Export ("addSamplesDataSearchSubDirectory:")]
		void AddSamplesDataSearchSubDirectory (string subdir);

		// +(void)add:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask dtype:(int)dtype __attribute__((swift_name("add(src1:srcScalar:dst:mask:dtype:)")));
		[Static]
		[Export ("add:srcScalar:dst:mask:dtype:")]
		void Add (Mat src1, Scalar srcScalar, Mat dst, Mat mask, int dtype);

		// +(void)add:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask __attribute__((swift_name("add(src1:srcScalar:dst:mask:)")));
		[Static]
		[Export ("add:srcScalar:dst:mask:")]
		void Add (Mat src1, Scalar srcScalar, Mat dst, Mat mask);

		// +(void)add:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst __attribute__((swift_name("add(src1:srcScalar:dst:)")));
		[Static]
		[Export ("add:srcScalar:dst:")]
		void Add (Mat src1, Scalar srcScalar, Mat dst);

		// +(void)subtract:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask dtype:(int)dtype __attribute__((swift_name("subtract(src1:srcScalar:dst:mask:dtype:)")));
		[Static]
		[Export ("subtract:srcScalar:dst:mask:dtype:")]
		void Subtract (Mat src1, Scalar srcScalar, Mat dst, Mat mask, int dtype);

		// +(void)subtract:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask __attribute__((swift_name("subtract(src1:srcScalar:dst:mask:)")));
		[Static]
		[Export ("subtract:srcScalar:dst:mask:")]
		void Subtract (Mat src1, Scalar srcScalar, Mat dst, Mat mask);

		// +(void)subtract:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst __attribute__((swift_name("subtract(src1:srcScalar:dst:)")));
		[Static]
		[Export ("subtract:srcScalar:dst:")]
		void Subtract (Mat src1, Scalar srcScalar, Mat dst);

		// +(void)multiply:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst scale:(double)scale dtype:(int)dtype __attribute__((swift_name("multiply(src1:srcScalar:dst:scale:dtype:)")));
		[Static]
		[Export ("multiply:srcScalar:dst:scale:dtype:")]
		void Multiply (Mat src1, Scalar srcScalar, Mat dst, double scale, int dtype);

		// +(void)multiply:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst scale:(double)scale __attribute__((swift_name("multiply(src1:srcScalar:dst:scale:)")));
		[Static]
		[Export ("multiply:srcScalar:dst:scale:")]
		void Multiply (Mat src1, Scalar srcScalar, Mat dst, double scale);

		// +(void)multiply:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst __attribute__((swift_name("multiply(src1:srcScalar:dst:)")));
		[Static]
		[Export ("multiply:srcScalar:dst:")]
		void Multiply (Mat src1, Scalar srcScalar, Mat dst);

		// +(void)divide:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst scale:(double)scale dtype:(int)dtype __attribute__((swift_name("divide(src1:srcScalar:dst:scale:dtype:)")));
		[Static]
		[Export ("divide:srcScalar:dst:scale:dtype:")]
		void Divide (Mat src1, Scalar srcScalar, Mat dst, double scale, int dtype);

		// +(void)divide:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst scale:(double)scale __attribute__((swift_name("divide(src1:srcScalar:dst:scale:)")));
		[Static]
		[Export ("divide:srcScalar:dst:scale:")]
		void Divide (Mat src1, Scalar srcScalar, Mat dst, double scale);

		// +(void)divide:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst __attribute__((swift_name("divide(src1:srcScalar:dst:)")));
		[Static]
		[Export ("divide:srcScalar:dst:")]
		void Divide (Mat src1, Scalar srcScalar, Mat dst);

		// +(void)absdiff:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst __attribute__((swift_name("absdiff(src1:srcScalar:dst:)")));
		[Static]
		[Export ("absdiff:srcScalar:dst:")]
		void Absdiff (Mat src1, Scalar srcScalar, Mat dst);

		// +(void)compare:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst cmpop:(CmpTypes)cmpop __attribute__((swift_name("compare(src1:srcScalar:dst:cmpop:)")));
		[Static]
		[Export ("compare:srcScalar:dst:cmpop:")]
		void Compare (Mat src1, Scalar srcScalar, Mat dst, CmpTypes cmpop);

		// +(void)min:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst __attribute__((swift_name("min(src1:srcScalar:dst:)")));
		[Static]
		[Export ("min:srcScalar:dst:")]
		void Min (Mat src1, Scalar srcScalar, Mat dst);

		// +(void)max:(Mat * _Nonnull)src1 srcScalar:(Scalar * _Nonnull)srcScalar dst:(Mat * _Nonnull)dst __attribute__((swift_name("max(src1:srcScalar:dst:)")));
		[Static]
		[Export ("max:srcScalar:dst:")]
		void Max (Mat src1, Scalar srcScalar, Mat dst);

		// +(MinMaxLocResult * _Nonnull)minMaxLoc:(Mat * _Nonnull)src mask:(Mat * _Nullable)mask;
		[Static]
		[Export ("minMaxLoc:mask:")]
		MinMaxLocResult MinMaxLoc (Mat src, [NullAllowed] Mat mask);

		// +(MinMaxLocResult * _Nonnull)minMaxLoc:(Mat * _Nonnull)src;
		[Static]
		[Export ("minMaxLoc:")]
		MinMaxLocResult MinMaxLoc (Mat src);
	}

	// @interface Algorithm : NSObject
	[BaseType (typeof(NSObject))]
	interface Algorithm
	{
		// -(void)clear __attribute__((swift_name("clear()")));
		[Export ("clear")]
		void Clear ();

		// -(BOOL)empty __attribute__((swift_name("empty()")));
		[Export ("empty")]
		bool Empty { get; }

		// -(void)save:(NSString * _Nonnull)filename __attribute__((swift_name("save(filename:)")));
		[Export ("save:")]
		void Save (string filename);

		// -(NSString * _Nonnull)getDefaultName __attribute__((swift_name("getDefaultName()")));
		[Export ("getDefaultName")]
		string DefaultName { get; }
	}

	// @interface TickMeter : NSObject
	[BaseType (typeof(NSObject))]
	interface TickMeter
	{
		// -(void)start __attribute__((swift_name("start()")));
		[Export ("start")]
		void Start ();

		// -(void)stop __attribute__((swift_name("stop()")));
		[Export ("stop")]
		void Stop ();

		// -(long)getTimeTicks __attribute__((swift_name("getTimeTicks()")));
		[Export ("getTimeTicks")]
		nint TimeTicks { get; }

		// -(double)getTimeMicro __attribute__((swift_name("getTimeMicro()")));
		[Export ("getTimeMicro")]
		double TimeMicro { get; }

		// -(double)getTimeMilli __attribute__((swift_name("getTimeMilli()")));
		[Export ("getTimeMilli")]
		double TimeMilli { get; }

		// -(double)getTimeSec __attribute__((swift_name("getTimeSec()")));
		[Export ("getTimeSec")]
		double TimeSec { get; }

		// -(long)getLastTimeTicks __attribute__((swift_name("getLastTimeTicks()")));
		[Export ("getLastTimeTicks")]
		nint LastTimeTicks { get; }

		// -(double)getLastTimeMicro __attribute__((swift_name("getLastTimeMicro()")));
		[Export ("getLastTimeMicro")]
		double LastTimeMicro { get; }

		// -(double)getLastTimeMilli __attribute__((swift_name("getLastTimeMilli()")));
		[Export ("getLastTimeMilli")]
		double LastTimeMilli { get; }

		// -(double)getLastTimeSec __attribute__((swift_name("getLastTimeSec()")));
		[Export ("getLastTimeSec")]
		double LastTimeSec { get; }

		// -(long)getCounter __attribute__((swift_name("getCounter()")));
		[Export ("getCounter")]
		nint Counter { get; }

		// -(double)getFPS __attribute__((swift_name("getFPS()")));
		[Export ("getFPS")]
		double FPS { get; }

		// -(double)getAvgTimeSec __attribute__((swift_name("getAvgTimeSec()")));
		[Export ("getAvgTimeSec")]
		double AvgTimeSec { get; }

		// -(double)getAvgTimeMilli __attribute__((swift_name("getAvgTimeMilli()")));
		[Export ("getAvgTimeMilli")]
		double AvgTimeMilli { get; }

		// -(void)reset __attribute__((swift_name("reset()")));
		[Export ("reset")]
		void Reset ();
	}

	// @interface Moments : NSObject
	[BaseType (typeof(NSObject))]
	interface Moments
	{
		// @property double m00;
		[Export ("m00")]
		double M00 { get; set; }

		// @property double m10;
		[Export ("m10")]
		double M10 { get; set; }

		// @property double m01;
		[Export ("m01")]
		double M01 { get; set; }

		// @property double m20;
		[Export ("m20")]
		double M20 { get; set; }

		// @property double m11;
		[Export ("m11")]
		double M11 { get; set; }

		// @property double m02;
		[Export ("m02")]
		double M02 { get; set; }

		// @property double m30;
		[Export ("m30")]
		double M30 { get; set; }

		// @property double m21;
		[Export ("m21")]
		double M21 { get; set; }

		// @property double m12;
		[Export ("m12")]
		double M12 { get; set; }

		// @property double m03;
		[Export ("m03")]
		double M03 { get; set; }

		// @property double mu20;
		[Export ("mu20")]
		double Mu20 { get; set; }

		// @property double mu11;
		[Export ("mu11")]
		double Mu11 { get; set; }

		// @property double mu02;
		[Export ("mu02")]
		double Mu02 { get; set; }

		// @property double mu30;
		[Export ("mu30")]
		double Mu30 { get; set; }

		// @property double mu21;
		[Export ("mu21")]
		double Mu21 { get; set; }

		// @property double mu12;
		[Export ("mu12")]
		double Mu12 { get; set; }

		// @property double mu03;
		[Export ("mu03")]
		double Mu03 { get; set; }

		// @property double nu20;
		[Export ("nu20")]
		double Nu20 { get; set; }

		// @property double nu11;
		[Export ("nu11")]
		double Nu11 { get; set; }

		// @property double nu02;
		[Export ("nu02")]
		double Nu02 { get; set; }

		// @property double nu30;
		[Export ("nu30")]
		double Nu30 { get; set; }

		// @property double nu21;
		[Export ("nu21")]
		double Nu21 { get; set; }

		// @property double nu12;
		[Export ("nu12")]
		double Nu12 { get; set; }

		// @property double nu03;
		[Export ("nu03")]
		double Nu03 { get; set; }

		// -(instancetype _Nonnull)initWithM00:(double)m00 m10:(double)m10 m01:(double)m01 m20:(double)m20 m11:(double)m11 m02:(double)m02 m30:(double)m30 m21:(double)m21 m12:(double)m12 m03:(double)m03;
		[Export ("initWithM00:m10:m01:m20:m11:m02:m30:m21:m12:m03:")]
		NativeHandle Constructor (double m00, double m10, double m01, double m20, double m11, double m02, double m30, double m21, double m12, double m03);

		// -(instancetype _Nonnull)initWithVals:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("initWithVals:")]
		NativeHandle Constructor (NSNumber[] vals);

		// -(void)set:(NSArray<NSNumber *> * _Nonnull)vals;
		[Export ("set:")]
		void Set (NSNumber[] vals);

		// -(void)completeState;
		[Export ("completeState")]
		void CompleteState ();

		// -(NSString * _Nonnull)description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface Imgproc : NSObject
	[BaseType (typeof(NSObject))]
	interface Imgproc
	{
		// @property (readonly, class) int CV_GAUSSIAN_5x5 __attribute__((swift_name("CV_GAUSSIAN_5x5")));
		[Static]
		[Export ("CV_GAUSSIAN_5x5")]
		int CV_GAUSSIAN_5x5 { get; }

		// @property (readonly, class) int CV_SCHARR __attribute__((swift_name("CV_SCHARR")));
		[Static]
		[Export ("CV_SCHARR")]
		int CV_SCHARR { get; }

		// @property (readonly, class) int CV_MAX_SOBEL_KSIZE __attribute__((swift_name("CV_MAX_SOBEL_KSIZE")));
		[Static]
		[Export ("CV_MAX_SOBEL_KSIZE")]
		int CV_MAX_SOBEL_KSIZE { get; }

		// @property (readonly, class) int CV_RGBA2mRGBA __attribute__((swift_name("CV_RGBA2mRGBA")));
		[Static]
		[Export ("CV_RGBA2mRGBA")]
		int CV_RGBA2mRGBA { get; }

		// @property (readonly, class) int CV_mRGBA2RGBA __attribute__((swift_name("CV_mRGBA2RGBA")));
		[Static]
		[Export ("CV_mRGBA2RGBA")]
		int CV_mRGBA2RGBA { get; }

		// @property (readonly, class) int CV_WARP_FILL_OUTLIERS __attribute__((swift_name("CV_WARP_FILL_OUTLIERS")));
		[Static]
		[Export ("CV_WARP_FILL_OUTLIERS")]
		int CV_WARP_FILL_OUTLIERS { get; }

		// @property (readonly, class) int CV_WARP_INVERSE_MAP __attribute__((swift_name("CV_WARP_INVERSE_MAP")));
		[Static]
		[Export ("CV_WARP_INVERSE_MAP")]
		int CV_WARP_INVERSE_MAP { get; }

		// @property (readonly, class) int CV_WARP_RELATIVE_MAP __attribute__((swift_name("CV_WARP_RELATIVE_MAP")));
		[Static]
		[Export ("CV_WARP_RELATIVE_MAP")]
		int CV_WARP_RELATIVE_MAP { get; }

		// @property (readonly, class) int CV_CHAIN_CODE __attribute__((swift_name("CV_CHAIN_CODE")));
		[Static]
		[Export ("CV_CHAIN_CODE")]
		int CV_CHAIN_CODE { get; }

		// @property (readonly, class) int CV_LINK_RUNS __attribute__((swift_name("CV_LINK_RUNS")));
		[Static]
		[Export ("CV_LINK_RUNS")]
		int CV_LINK_RUNS { get; }

		// @property (readonly, class) int CV_POLY_APPROX_DP __attribute__((swift_name("CV_POLY_APPROX_DP")));
		[Static]
		[Export ("CV_POLY_APPROX_DP")]
		int CV_POLY_APPROX_DP { get; }

		// @property (readonly, class) int CV_CLOCKWISE __attribute__((swift_name("CV_CLOCKWISE")));
		[Static]
		[Export ("CV_CLOCKWISE")]
		int CV_CLOCKWISE { get; }

		// @property (readonly, class) int CV_COUNTER_CLOCKWISE __attribute__((swift_name("CV_COUNTER_CLOCKWISE")));
		[Static]
		[Export ("CV_COUNTER_CLOCKWISE")]
		int CV_COUNTER_CLOCKWISE { get; }

		// @property (readonly, class) int CV_CANNY_L2_GRADIENT __attribute__((swift_name("CV_CANNY_L2_GRADIENT")));
		[Static]
		[Export ("CV_CANNY_L2_GRADIENT")]
		int CV_CANNY_L2_GRADIENT { get; }

		// +(LineSegmentDetector * _Nonnull)createLineSegmentDetector:(int)refine scale:(double)scale sigma_scale:(double)sigma_scale quant:(double)quant ang_th:(double)ang_th log_eps:(double)log_eps density_th:(double)density_th n_bins:(int)n_bins __attribute__((swift_name("createLineSegmentDetector(refine:scale:sigma_scale:quant:ang_th:log_eps:density_th:n_bins:)")));
		[Static]
		[Export ("createLineSegmentDetector:scale:sigma_scale:quant:ang_th:log_eps:density_th:n_bins:")]
		LineSegmentDetector CreateLineSegmentDetector (int refine, double scale, double sigma_scale, double quant, double ang_th, double log_eps, double density_th, int n_bins);

		// +(LineSegmentDetector * _Nonnull)createLineSegmentDetector:(int)refine scale:(double)scale sigma_scale:(double)sigma_scale quant:(double)quant ang_th:(double)ang_th log_eps:(double)log_eps density_th:(double)density_th __attribute__((swift_name("createLineSegmentDetector(refine:scale:sigma_scale:quant:ang_th:log_eps:density_th:)")));
		[Static]
		[Export ("createLineSegmentDetector:scale:sigma_scale:quant:ang_th:log_eps:density_th:")]
		LineSegmentDetector CreateLineSegmentDetector (int refine, double scale, double sigma_scale, double quant, double ang_th, double log_eps, double density_th);

		// +(LineSegmentDetector * _Nonnull)createLineSegmentDetector:(int)refine scale:(double)scale sigma_scale:(double)sigma_scale quant:(double)quant ang_th:(double)ang_th log_eps:(double)log_eps __attribute__((swift_name("createLineSegmentDetector(refine:scale:sigma_scale:quant:ang_th:log_eps:)")));
		[Static]
		[Export ("createLineSegmentDetector:scale:sigma_scale:quant:ang_th:log_eps:")]
		LineSegmentDetector CreateLineSegmentDetector (int refine, double scale, double sigma_scale, double quant, double ang_th, double log_eps);

		// +(LineSegmentDetector * _Nonnull)createLineSegmentDetector:(int)refine scale:(double)scale sigma_scale:(double)sigma_scale quant:(double)quant ang_th:(double)ang_th __attribute__((swift_name("createLineSegmentDetector(refine:scale:sigma_scale:quant:ang_th:)")));
		[Static]
		[Export ("createLineSegmentDetector:scale:sigma_scale:quant:ang_th:")]
		LineSegmentDetector CreateLineSegmentDetector (int refine, double scale, double sigma_scale, double quant, double ang_th);

		// +(LineSegmentDetector * _Nonnull)createLineSegmentDetector:(int)refine scale:(double)scale sigma_scale:(double)sigma_scale quant:(double)quant __attribute__((swift_name("createLineSegmentDetector(refine:scale:sigma_scale:quant:)")));
		[Static]
		[Export ("createLineSegmentDetector:scale:sigma_scale:quant:")]
		LineSegmentDetector CreateLineSegmentDetector (int refine, double scale, double sigma_scale, double quant);

		// +(LineSegmentDetector * _Nonnull)createLineSegmentDetector:(int)refine scale:(double)scale sigma_scale:(double)sigma_scale __attribute__((swift_name("createLineSegmentDetector(refine:scale:sigma_scale:)")));
		[Static]
		[Export ("createLineSegmentDetector:scale:sigma_scale:")]
		LineSegmentDetector CreateLineSegmentDetector (int refine, double scale, double sigma_scale);

		// +(LineSegmentDetector * _Nonnull)createLineSegmentDetector:(int)refine scale:(double)scale __attribute__((swift_name("createLineSegmentDetector(refine:scale:)")));
		[Static]
		[Export ("createLineSegmentDetector:scale:")]
		LineSegmentDetector CreateLineSegmentDetector (int refine, double scale);

		// +(LineSegmentDetector * _Nonnull)createLineSegmentDetector:(int)refine __attribute__((swift_name("createLineSegmentDetector(refine:)")));
		[Static]
		[Export ("createLineSegmentDetector:")]
		LineSegmentDetector CreateLineSegmentDetector (int refine);

		// +(LineSegmentDetector * _Nonnull)createLineSegmentDetector __attribute__((swift_name("createLineSegmentDetector()")));
		[Static]
		[Export ("createLineSegmentDetector")]
		LineSegmentDetector CreateLineSegmentDetector ();

		// +(Mat * _Nonnull)getGaussianKernel:(int)ksize sigma:(double)sigma ktype:(int)ktype __attribute__((swift_name("getGaussianKernel(ksize:sigma:ktype:)")));
		[Static]
		[Export ("getGaussianKernel:sigma:ktype:")]
		Mat GetGaussianKernel (int ksize, double sigma, int ktype);

		// +(Mat * _Nonnull)getGaussianKernel:(int)ksize sigma:(double)sigma __attribute__((swift_name("getGaussianKernel(ksize:sigma:)")));
		[Static]
		[Export ("getGaussianKernel:sigma:")]
		Mat GetGaussianKernel (int ksize, double sigma);

		// +(void)getDerivKernels:(Mat * _Nonnull)kx ky:(Mat * _Nonnull)ky dx:(int)dx dy:(int)dy ksize:(int)ksize normalize:(BOOL)normalize ktype:(int)ktype __attribute__((swift_name("getDerivKernels(kx:ky:dx:dy:ksize:normalize:ktype:)")));
		[Static]
		[Export ("getDerivKernels:ky:dx:dy:ksize:normalize:ktype:")]
		void GetDerivKernels (Mat kx, Mat ky, int dx, int dy, int ksize, bool normalize, int ktype);

		// +(void)getDerivKernels:(Mat * _Nonnull)kx ky:(Mat * _Nonnull)ky dx:(int)dx dy:(int)dy ksize:(int)ksize normalize:(BOOL)normalize __attribute__((swift_name("getDerivKernels(kx:ky:dx:dy:ksize:normalize:)")));
		[Static]
		[Export ("getDerivKernels:ky:dx:dy:ksize:normalize:")]
		void GetDerivKernels (Mat kx, Mat ky, int dx, int dy, int ksize, bool normalize);

		// +(void)getDerivKernels:(Mat * _Nonnull)kx ky:(Mat * _Nonnull)ky dx:(int)dx dy:(int)dy ksize:(int)ksize __attribute__((swift_name("getDerivKernels(kx:ky:dx:dy:ksize:)")));
		[Static]
		[Export ("getDerivKernels:ky:dx:dy:ksize:")]
		void GetDerivKernels (Mat kx, Mat ky, int dx, int dy, int ksize);

		// +(Mat * _Nonnull)getGaborKernel:(Size2i * _Nonnull)ksize sigma:(double)sigma theta:(double)theta lambd:(double)lambd gamma:(double)gamma psi:(double)psi ktype:(int)ktype __attribute__((swift_name("getGaborKernel(ksize:sigma:theta:lambd:gamma:psi:ktype:)")));
		[Static]
		[Export ("getGaborKernel:sigma:theta:lambd:gamma:psi:ktype:")]
		Mat GetGaborKernel (Size2i ksize, double sigma, double theta, double lambd, double gamma, double psi, int ktype);

		// +(Mat * _Nonnull)getGaborKernel:(Size2i * _Nonnull)ksize sigma:(double)sigma theta:(double)theta lambd:(double)lambd gamma:(double)gamma psi:(double)psi __attribute__((swift_name("getGaborKernel(ksize:sigma:theta:lambd:gamma:psi:)")));
		[Static]
		[Export ("getGaborKernel:sigma:theta:lambd:gamma:psi:")]
		Mat GetGaborKernel (Size2i ksize, double sigma, double theta, double lambd, double gamma, double psi);

		// +(Mat * _Nonnull)getGaborKernel:(Size2i * _Nonnull)ksize sigma:(double)sigma theta:(double)theta lambd:(double)lambd gamma:(double)gamma __attribute__((swift_name("getGaborKernel(ksize:sigma:theta:lambd:gamma:)")));
		[Static]
		[Export ("getGaborKernel:sigma:theta:lambd:gamma:")]
		Mat GetGaborKernel (Size2i ksize, double sigma, double theta, double lambd, double gamma);

		// +(Mat * _Nonnull)getStructuringElement:(MorphShapes)shape ksize:(Size2i * _Nonnull)ksize anchor:(Point2i * _Nonnull)anchor __attribute__((swift_name("getStructuringElement(shape:ksize:anchor:)")));
		[Static]
		[Export ("getStructuringElement:ksize:anchor:")]
		Mat GetStructuringElement (MorphShapes shape, Size2i ksize, Point2i anchor);

		// +(Mat * _Nonnull)getStructuringElement:(MorphShapes)shape ksize:(Size2i * _Nonnull)ksize __attribute__((swift_name("getStructuringElement(shape:ksize:)")));
		[Static]
		[Export ("getStructuringElement:ksize:")]
		Mat GetStructuringElement (MorphShapes shape, Size2i ksize);

		// +(void)medianBlur:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ksize:(int)ksize __attribute__((swift_name("medianBlur(src:dst:ksize:)")));
		[Static]
		[Export ("medianBlur:dst:ksize:")]
		void MedianBlur (Mat src, Mat dst, int ksize);

		// +(void)GaussianBlur:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ksize:(Size2i * _Nonnull)ksize sigmaX:(double)sigmaX sigmaY:(double)sigmaY borderType:(BorderTypes)borderType hint:(AlgorithmHint)hint __attribute__((swift_name("GaussianBlur(src:dst:ksize:sigmaX:sigmaY:borderType:hint:)")));
		[Static]
		[Export ("GaussianBlur:dst:ksize:sigmaX:sigmaY:borderType:hint:")]
		void GaussianBlur (Mat src, Mat dst, Size2i ksize, double sigmaX, double sigmaY, BorderTypes borderType, AlgorithmHint hint);

		// +(void)GaussianBlur:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ksize:(Size2i * _Nonnull)ksize sigmaX:(double)sigmaX sigmaY:(double)sigmaY borderType:(BorderTypes)borderType __attribute__((swift_name("GaussianBlur(src:dst:ksize:sigmaX:sigmaY:borderType:)")));
		[Static]
		[Export ("GaussianBlur:dst:ksize:sigmaX:sigmaY:borderType:")]
		void GaussianBlur (Mat src, Mat dst, Size2i ksize, double sigmaX, double sigmaY, BorderTypes borderType);

		// +(void)GaussianBlur:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ksize:(Size2i * _Nonnull)ksize sigmaX:(double)sigmaX sigmaY:(double)sigmaY __attribute__((swift_name("GaussianBlur(src:dst:ksize:sigmaX:sigmaY:)")));
		[Static]
		[Export ("GaussianBlur:dst:ksize:sigmaX:sigmaY:")]
		void GaussianBlur (Mat src, Mat dst, Size2i ksize, double sigmaX, double sigmaY);

		// +(void)GaussianBlur:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ksize:(Size2i * _Nonnull)ksize sigmaX:(double)sigmaX __attribute__((swift_name("GaussianBlur(src:dst:ksize:sigmaX:)")));
		[Static]
		[Export ("GaussianBlur:dst:ksize:sigmaX:")]
		void GaussianBlur (Mat src, Mat dst, Size2i ksize, double sigmaX);

		// +(void)bilateralFilter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst d:(int)d sigmaColor:(double)sigmaColor sigmaSpace:(double)sigmaSpace borderType:(BorderTypes)borderType __attribute__((swift_name("bilateralFilter(src:dst:d:sigmaColor:sigmaSpace:borderType:)")));
		[Static]
		[Export ("bilateralFilter:dst:d:sigmaColor:sigmaSpace:borderType:")]
		void BilateralFilter (Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace, BorderTypes borderType);

		// +(void)bilateralFilter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst d:(int)d sigmaColor:(double)sigmaColor sigmaSpace:(double)sigmaSpace __attribute__((swift_name("bilateralFilter(src:dst:d:sigmaColor:sigmaSpace:)")));
		[Static]
		[Export ("bilateralFilter:dst:d:sigmaColor:sigmaSpace:")]
		void BilateralFilter (Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace);

		// +(void)boxFilter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth ksize:(Size2i * _Nonnull)ksize anchor:(Point2i * _Nonnull)anchor normalize:(BOOL)normalize borderType:(BorderTypes)borderType __attribute__((swift_name("boxFilter(src:dst:ddepth:ksize:anchor:normalize:borderType:)")));
		[Static]
		[Export ("boxFilter:dst:ddepth:ksize:anchor:normalize:borderType:")]
		void BoxFilter (Mat src, Mat dst, int ddepth, Size2i ksize, Point2i anchor, bool normalize, BorderTypes borderType);

		// +(void)boxFilter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth ksize:(Size2i * _Nonnull)ksize anchor:(Point2i * _Nonnull)anchor normalize:(BOOL)normalize __attribute__((swift_name("boxFilter(src:dst:ddepth:ksize:anchor:normalize:)")));
		[Static]
		[Export ("boxFilter:dst:ddepth:ksize:anchor:normalize:")]
		void BoxFilter (Mat src, Mat dst, int ddepth, Size2i ksize, Point2i anchor, bool normalize);

		// +(void)boxFilter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth ksize:(Size2i * _Nonnull)ksize anchor:(Point2i * _Nonnull)anchor __attribute__((swift_name("boxFilter(src:dst:ddepth:ksize:anchor:)")));
		[Static]
		[Export ("boxFilter:dst:ddepth:ksize:anchor:")]
		void BoxFilter (Mat src, Mat dst, int ddepth, Size2i ksize, Point2i anchor);

		// +(void)boxFilter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth ksize:(Size2i * _Nonnull)ksize __attribute__((swift_name("boxFilter(src:dst:ddepth:ksize:)")));
		[Static]
		[Export ("boxFilter:dst:ddepth:ksize:")]
		void BoxFilter (Mat src, Mat dst, int ddepth, Size2i ksize);

		// +(void)sqrBoxFilter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth ksize:(Size2i * _Nonnull)ksize anchor:(Point2i * _Nonnull)anchor normalize:(BOOL)normalize borderType:(BorderTypes)borderType __attribute__((swift_name("sqrBoxFilter(src:dst:ddepth:ksize:anchor:normalize:borderType:)")));
		[Static]
		[Export ("sqrBoxFilter:dst:ddepth:ksize:anchor:normalize:borderType:")]
		void SqrBoxFilter (Mat src, Mat dst, int ddepth, Size2i ksize, Point2i anchor, bool normalize, BorderTypes borderType);

		// +(void)sqrBoxFilter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth ksize:(Size2i * _Nonnull)ksize anchor:(Point2i * _Nonnull)anchor normalize:(BOOL)normalize __attribute__((swift_name("sqrBoxFilter(src:dst:ddepth:ksize:anchor:normalize:)")));
		[Static]
		[Export ("sqrBoxFilter:dst:ddepth:ksize:anchor:normalize:")]
		void SqrBoxFilter (Mat src, Mat dst, int ddepth, Size2i ksize, Point2i anchor, bool normalize);

		// +(void)sqrBoxFilter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth ksize:(Size2i * _Nonnull)ksize anchor:(Point2i * _Nonnull)anchor __attribute__((swift_name("sqrBoxFilter(src:dst:ddepth:ksize:anchor:)")));
		[Static]
		[Export ("sqrBoxFilter:dst:ddepth:ksize:anchor:")]
		void SqrBoxFilter (Mat src, Mat dst, int ddepth, Size2i ksize, Point2i anchor);

		// +(void)sqrBoxFilter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth ksize:(Size2i * _Nonnull)ksize __attribute__((swift_name("sqrBoxFilter(src:dst:ddepth:ksize:)")));
		[Static]
		[Export ("sqrBoxFilter:dst:ddepth:ksize:")]
		void SqrBoxFilter (Mat src, Mat dst, int ddepth, Size2i ksize);

		// +(void)blur:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ksize:(Size2i * _Nonnull)ksize anchor:(Point2i * _Nonnull)anchor borderType:(BorderTypes)borderType __attribute__((swift_name("blur(src:dst:ksize:anchor:borderType:)")));
		[Static]
		[Export ("blur:dst:ksize:anchor:borderType:")]
		void Blur (Mat src, Mat dst, Size2i ksize, Point2i anchor, BorderTypes borderType);

		// +(void)blur:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ksize:(Size2i * _Nonnull)ksize anchor:(Point2i * _Nonnull)anchor __attribute__((swift_name("blur(src:dst:ksize:anchor:)")));
		[Static]
		[Export ("blur:dst:ksize:anchor:")]
		void Blur (Mat src, Mat dst, Size2i ksize, Point2i anchor);

		// +(void)blur:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ksize:(Size2i * _Nonnull)ksize __attribute__((swift_name("blur(src:dst:ksize:)")));
		[Static]
		[Export ("blur:dst:ksize:")]
		void Blur (Mat src, Mat dst, Size2i ksize);

		// +(void)stackBlur:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ksize:(Size2i * _Nonnull)ksize __attribute__((swift_name("stackBlur(src:dst:ksize:)")));
		[Static]
		[Export ("stackBlur:dst:ksize:")]
		void StackBlur (Mat src, Mat dst, Size2i ksize);

		// +(void)filter2D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor delta:(double)delta borderType:(BorderTypes)borderType __attribute__((swift_name("filter2D(src:dst:ddepth:kernel:anchor:delta:borderType:)")));
		[Static]
		[Export ("filter2D:dst:ddepth:kernel:anchor:delta:borderType:")]
		void Filter2D (Mat src, Mat dst, int ddepth, Mat kernel, Point2i anchor, double delta, BorderTypes borderType);

		// +(void)filter2D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor delta:(double)delta __attribute__((swift_name("filter2D(src:dst:ddepth:kernel:anchor:delta:)")));
		[Static]
		[Export ("filter2D:dst:ddepth:kernel:anchor:delta:")]
		void Filter2D (Mat src, Mat dst, int ddepth, Mat kernel, Point2i anchor, double delta);

		// +(void)filter2D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor __attribute__((swift_name("filter2D(src:dst:ddepth:kernel:anchor:)")));
		[Static]
		[Export ("filter2D:dst:ddepth:kernel:anchor:")]
		void Filter2D (Mat src, Mat dst, int ddepth, Mat kernel, Point2i anchor);

		// +(void)filter2D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth kernel:(Mat * _Nonnull)kernel __attribute__((swift_name("filter2D(src:dst:ddepth:kernel:)")));
		[Static]
		[Export ("filter2D:dst:ddepth:kernel:")]
		void Filter2D (Mat src, Mat dst, int ddepth, Mat kernel);

		// +(void)sepFilter2D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth kernelX:(Mat * _Nonnull)kernelX kernelY:(Mat * _Nonnull)kernelY anchor:(Point2i * _Nonnull)anchor delta:(double)delta borderType:(BorderTypes)borderType __attribute__((swift_name("sepFilter2D(src:dst:ddepth:kernelX:kernelY:anchor:delta:borderType:)")));
		[Static]
		[Export ("sepFilter2D:dst:ddepth:kernelX:kernelY:anchor:delta:borderType:")]
		void SepFilter2D (Mat src, Mat dst, int ddepth, Mat kernelX, Mat kernelY, Point2i anchor, double delta, BorderTypes borderType);

		// +(void)sepFilter2D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth kernelX:(Mat * _Nonnull)kernelX kernelY:(Mat * _Nonnull)kernelY anchor:(Point2i * _Nonnull)anchor delta:(double)delta __attribute__((swift_name("sepFilter2D(src:dst:ddepth:kernelX:kernelY:anchor:delta:)")));
		[Static]
		[Export ("sepFilter2D:dst:ddepth:kernelX:kernelY:anchor:delta:")]
		void SepFilter2D (Mat src, Mat dst, int ddepth, Mat kernelX, Mat kernelY, Point2i anchor, double delta);

		// +(void)sepFilter2D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth kernelX:(Mat * _Nonnull)kernelX kernelY:(Mat * _Nonnull)kernelY anchor:(Point2i * _Nonnull)anchor __attribute__((swift_name("sepFilter2D(src:dst:ddepth:kernelX:kernelY:anchor:)")));
		[Static]
		[Export ("sepFilter2D:dst:ddepth:kernelX:kernelY:anchor:")]
		void SepFilter2D (Mat src, Mat dst, int ddepth, Mat kernelX, Mat kernelY, Point2i anchor);

		// +(void)sepFilter2D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth kernelX:(Mat * _Nonnull)kernelX kernelY:(Mat * _Nonnull)kernelY __attribute__((swift_name("sepFilter2D(src:dst:ddepth:kernelX:kernelY:)")));
		[Static]
		[Export ("sepFilter2D:dst:ddepth:kernelX:kernelY:")]
		void SepFilter2D (Mat src, Mat dst, int ddepth, Mat kernelX, Mat kernelY);

		// +(void)Sobel:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth dx:(int)dx dy:(int)dy ksize:(int)ksize scale:(double)scale delta:(double)delta borderType:(BorderTypes)borderType __attribute__((swift_name("Sobel(src:dst:ddepth:dx:dy:ksize:scale:delta:borderType:)")));
		[Static]
		[Export ("Sobel:dst:ddepth:dx:dy:ksize:scale:delta:borderType:")]
		void Sobel (Mat src, Mat dst, int ddepth, int dx, int dy, int ksize, double scale, double delta, BorderTypes borderType);

		// +(void)Sobel:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth dx:(int)dx dy:(int)dy ksize:(int)ksize scale:(double)scale delta:(double)delta __attribute__((swift_name("Sobel(src:dst:ddepth:dx:dy:ksize:scale:delta:)")));
		[Static]
		[Export ("Sobel:dst:ddepth:dx:dy:ksize:scale:delta:")]
		void Sobel (Mat src, Mat dst, int ddepth, int dx, int dy, int ksize, double scale, double delta);

		// +(void)Sobel:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth dx:(int)dx dy:(int)dy ksize:(int)ksize scale:(double)scale __attribute__((swift_name("Sobel(src:dst:ddepth:dx:dy:ksize:scale:)")));
		[Static]
		[Export ("Sobel:dst:ddepth:dx:dy:ksize:scale:")]
		void Sobel (Mat src, Mat dst, int ddepth, int dx, int dy, int ksize, double scale);

		// +(void)Sobel:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth dx:(int)dx dy:(int)dy ksize:(int)ksize __attribute__((swift_name("Sobel(src:dst:ddepth:dx:dy:ksize:)")));
		[Static]
		[Export ("Sobel:dst:ddepth:dx:dy:ksize:")]
		void Sobel (Mat src, Mat dst, int ddepth, int dx, int dy, int ksize);

		// +(void)Sobel:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth dx:(int)dx dy:(int)dy __attribute__((swift_name("Sobel(src:dst:ddepth:dx:dy:)")));
		[Static]
		[Export ("Sobel:dst:ddepth:dx:dy:")]
		void Sobel (Mat src, Mat dst, int ddepth, int dx, int dy);

		// +(void)spatialGradient:(Mat * _Nonnull)src dx:(Mat * _Nonnull)dx dy:(Mat * _Nonnull)dy ksize:(int)ksize borderType:(BorderTypes)borderType __attribute__((swift_name("spatialGradient(src:dx:dy:ksize:borderType:)")));
		[Static]
		[Export ("spatialGradient:dx:dy:ksize:borderType:")]
		void SpatialGradient (Mat src, Mat dx, Mat dy, int ksize, BorderTypes borderType);

		// +(void)spatialGradient:(Mat * _Nonnull)src dx:(Mat * _Nonnull)dx dy:(Mat * _Nonnull)dy ksize:(int)ksize __attribute__((swift_name("spatialGradient(src:dx:dy:ksize:)")));
		[Static]
		[Export ("spatialGradient:dx:dy:ksize:")]
		void SpatialGradient (Mat src, Mat dx, Mat dy, int ksize);

		// +(void)spatialGradient:(Mat * _Nonnull)src dx:(Mat * _Nonnull)dx dy:(Mat * _Nonnull)dy __attribute__((swift_name("spatialGradient(src:dx:dy:)")));
		[Static]
		[Export ("spatialGradient:dx:dy:")]
		void SpatialGradient (Mat src, Mat dx, Mat dy);

		// +(void)Scharr:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth dx:(int)dx dy:(int)dy scale:(double)scale delta:(double)delta borderType:(BorderTypes)borderType __attribute__((swift_name("Scharr(src:dst:ddepth:dx:dy:scale:delta:borderType:)")));
		[Static]
		[Export ("Scharr:dst:ddepth:dx:dy:scale:delta:borderType:")]
		void Scharr (Mat src, Mat dst, int ddepth, int dx, int dy, double scale, double delta, BorderTypes borderType);

		// +(void)Scharr:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth dx:(int)dx dy:(int)dy scale:(double)scale delta:(double)delta __attribute__((swift_name("Scharr(src:dst:ddepth:dx:dy:scale:delta:)")));
		[Static]
		[Export ("Scharr:dst:ddepth:dx:dy:scale:delta:")]
		void Scharr (Mat src, Mat dst, int ddepth, int dx, int dy, double scale, double delta);

		// +(void)Scharr:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth dx:(int)dx dy:(int)dy scale:(double)scale __attribute__((swift_name("Scharr(src:dst:ddepth:dx:dy:scale:)")));
		[Static]
		[Export ("Scharr:dst:ddepth:dx:dy:scale:")]
		void Scharr (Mat src, Mat dst, int ddepth, int dx, int dy, double scale);

		// +(void)Scharr:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth dx:(int)dx dy:(int)dy __attribute__((swift_name("Scharr(src:dst:ddepth:dx:dy:)")));
		[Static]
		[Export ("Scharr:dst:ddepth:dx:dy:")]
		void Scharr (Mat src, Mat dst, int ddepth, int dx, int dy);

		// +(void)Laplacian:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth ksize:(int)ksize scale:(double)scale delta:(double)delta borderType:(BorderTypes)borderType __attribute__((swift_name("Laplacian(src:dst:ddepth:ksize:scale:delta:borderType:)")));
		[Static]
		[Export ("Laplacian:dst:ddepth:ksize:scale:delta:borderType:")]
		void Laplacian (Mat src, Mat dst, int ddepth, int ksize, double scale, double delta, BorderTypes borderType);

		// +(void)Laplacian:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth ksize:(int)ksize scale:(double)scale delta:(double)delta __attribute__((swift_name("Laplacian(src:dst:ddepth:ksize:scale:delta:)")));
		[Static]
		[Export ("Laplacian:dst:ddepth:ksize:scale:delta:")]
		void Laplacian (Mat src, Mat dst, int ddepth, int ksize, double scale, double delta);

		// +(void)Laplacian:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth ksize:(int)ksize scale:(double)scale __attribute__((swift_name("Laplacian(src:dst:ddepth:ksize:scale:)")));
		[Static]
		[Export ("Laplacian:dst:ddepth:ksize:scale:")]
		void Laplacian (Mat src, Mat dst, int ddepth, int ksize, double scale);

		// +(void)Laplacian:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth ksize:(int)ksize __attribute__((swift_name("Laplacian(src:dst:ddepth:ksize:)")));
		[Static]
		[Export ("Laplacian:dst:ddepth:ksize:")]
		void Laplacian (Mat src, Mat dst, int ddepth, int ksize);

		// +(void)Laplacian:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ddepth:(int)ddepth __attribute__((swift_name("Laplacian(src:dst:ddepth:)")));
		[Static]
		[Export ("Laplacian:dst:ddepth:")]
		void Laplacian (Mat src, Mat dst, int ddepth);

		// +(void)Canny:(Mat * _Nonnull)image edges:(Mat * _Nonnull)edges threshold1:(double)threshold1 threshold2:(double)threshold2 apertureSize:(int)apertureSize L2gradient:(BOOL)L2gradient __attribute__((swift_name("Canny(image:edges:threshold1:threshold2:apertureSize:L2gradient:)")));
		[Static]
		[Export ("Canny:edges:threshold1:threshold2:apertureSize:L2gradient:")]
		void Canny (Mat image, Mat edges, double threshold1, double threshold2, int apertureSize, bool L2gradient);

		// +(void)Canny:(Mat * _Nonnull)image edges:(Mat * _Nonnull)edges threshold1:(double)threshold1 threshold2:(double)threshold2 apertureSize:(int)apertureSize __attribute__((swift_name("Canny(image:edges:threshold1:threshold2:apertureSize:)")));
		[Static]
		[Export ("Canny:edges:threshold1:threshold2:apertureSize:")]
		void Canny (Mat image, Mat edges, double threshold1, double threshold2, int apertureSize);

		// +(void)Canny:(Mat * _Nonnull)image edges:(Mat * _Nonnull)edges threshold1:(double)threshold1 threshold2:(double)threshold2 __attribute__((swift_name("Canny(image:edges:threshold1:threshold2:)")));
		[Static]
		[Export ("Canny:edges:threshold1:threshold2:")]
		void Canny (Mat image, Mat edges, double threshold1, double threshold2);

		// +(void)Canny:(Mat * _Nonnull)dx dy:(Mat * _Nonnull)dy edges:(Mat * _Nonnull)edges threshold1:(double)threshold1 threshold2:(double)threshold2 L2gradient:(BOOL)L2gradient __attribute__((swift_name("Canny(dx:dy:edges:threshold1:threshold2:L2gradient:)")));
		[Static]
		[Export ("Canny:dy:edges:threshold1:threshold2:L2gradient:")]
		void Canny (Mat dx, Mat dy, Mat edges, double threshold1, double threshold2, bool L2gradient);

		// +(void)Canny:(Mat * _Nonnull)dx dy:(Mat * _Nonnull)dy edges:(Mat * _Nonnull)edges threshold1:(double)threshold1 threshold2:(double)threshold2 __attribute__((swift_name("Canny(dx:dy:edges:threshold1:threshold2:)")));
		[Static]
		[Export ("Canny:dy:edges:threshold1:threshold2:")]
		void Canny (Mat dx, Mat dy, Mat edges, double threshold1, double threshold2);

		// +(void)cornerMinEigenVal:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst blockSize:(int)blockSize ksize:(int)ksize borderType:(BorderTypes)borderType __attribute__((swift_name("cornerMinEigenVal(src:dst:blockSize:ksize:borderType:)")));
		[Static]
		[Export ("cornerMinEigenVal:dst:blockSize:ksize:borderType:")]
		void CornerMinEigenVal (Mat src, Mat dst, int blockSize, int ksize, BorderTypes borderType);

		// +(void)cornerMinEigenVal:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst blockSize:(int)blockSize ksize:(int)ksize __attribute__((swift_name("cornerMinEigenVal(src:dst:blockSize:ksize:)")));
		[Static]
		[Export ("cornerMinEigenVal:dst:blockSize:ksize:")]
		void CornerMinEigenVal (Mat src, Mat dst, int blockSize, int ksize);

		// +(void)cornerMinEigenVal:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst blockSize:(int)blockSize __attribute__((swift_name("cornerMinEigenVal(src:dst:blockSize:)")));
		[Static]
		[Export ("cornerMinEigenVal:dst:blockSize:")]
		void CornerMinEigenVal (Mat src, Mat dst, int blockSize);

		// +(void)cornerHarris:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst blockSize:(int)blockSize ksize:(int)ksize k:(double)k borderType:(BorderTypes)borderType __attribute__((swift_name("cornerHarris(src:dst:blockSize:ksize:k:borderType:)")));
		[Static]
		[Export ("cornerHarris:dst:blockSize:ksize:k:borderType:")]
		void CornerHarris (Mat src, Mat dst, int blockSize, int ksize, double k, BorderTypes borderType);

		// +(void)cornerHarris:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst blockSize:(int)blockSize ksize:(int)ksize k:(double)k __attribute__((swift_name("cornerHarris(src:dst:blockSize:ksize:k:)")));
		[Static]
		[Export ("cornerHarris:dst:blockSize:ksize:k:")]
		void CornerHarris (Mat src, Mat dst, int blockSize, int ksize, double k);

		// +(void)cornerEigenValsAndVecs:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst blockSize:(int)blockSize ksize:(int)ksize borderType:(BorderTypes)borderType __attribute__((swift_name("cornerEigenValsAndVecs(src:dst:blockSize:ksize:borderType:)")));
		[Static]
		[Export ("cornerEigenValsAndVecs:dst:blockSize:ksize:borderType:")]
		void CornerEigenValsAndVecs (Mat src, Mat dst, int blockSize, int ksize, BorderTypes borderType);

		// +(void)cornerEigenValsAndVecs:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst blockSize:(int)blockSize ksize:(int)ksize __attribute__((swift_name("cornerEigenValsAndVecs(src:dst:blockSize:ksize:)")));
		[Static]
		[Export ("cornerEigenValsAndVecs:dst:blockSize:ksize:")]
		void CornerEigenValsAndVecs (Mat src, Mat dst, int blockSize, int ksize);

		// +(void)preCornerDetect:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ksize:(int)ksize borderType:(BorderTypes)borderType __attribute__((swift_name("preCornerDetect(src:dst:ksize:borderType:)")));
		[Static]
		[Export ("preCornerDetect:dst:ksize:borderType:")]
		void PreCornerDetect (Mat src, Mat dst, int ksize, BorderTypes borderType);

		// +(void)preCornerDetect:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst ksize:(int)ksize __attribute__((swift_name("preCornerDetect(src:dst:ksize:)")));
		[Static]
		[Export ("preCornerDetect:dst:ksize:")]
		void PreCornerDetect (Mat src, Mat dst, int ksize);

		// +(void)cornerSubPix:(Mat * _Nonnull)image corners:(Mat * _Nonnull)corners winSize:(Size2i * _Nonnull)winSize zeroZone:(Size2i * _Nonnull)zeroZone criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("cornerSubPix(image:corners:winSize:zeroZone:criteria:)")));
		[Static]
		[Export ("cornerSubPix:corners:winSize:zeroZone:criteria:")]
		void CornerSubPix (Mat image, Mat corners, Size2i winSize, Size2i zeroZone, TermCriteria criteria);

		// +(void)goodFeaturesToTrack:(Mat * _Nonnull)image corners:(NSMutableArray<Point2i *> * _Nonnull)corners maxCorners:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance mask:(Mat * _Nonnull)mask blockSize:(int)blockSize useHarrisDetector:(BOOL)useHarrisDetector k:(double)k __attribute__((swift_name("goodFeaturesToTrack(image:corners:maxCorners:qualityLevel:minDistance:mask:blockSize:useHarrisDetector:k:)")));
		[Static]
		[Export ("goodFeaturesToTrack:corners:maxCorners:qualityLevel:minDistance:mask:blockSize:useHarrisDetector:k:")]
		void GoodFeaturesToTrack (Mat image, NSMutableArray<Point2i> corners, int maxCorners, double qualityLevel, double minDistance, Mat mask, int blockSize, bool useHarrisDetector, double k);

		// +(void)goodFeaturesToTrack:(Mat * _Nonnull)image corners:(NSMutableArray<Point2i *> * _Nonnull)corners maxCorners:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance mask:(Mat * _Nonnull)mask blockSize:(int)blockSize useHarrisDetector:(BOOL)useHarrisDetector __attribute__((swift_name("goodFeaturesToTrack(image:corners:maxCorners:qualityLevel:minDistance:mask:blockSize:useHarrisDetector:)")));
		[Static]
		[Export ("goodFeaturesToTrack:corners:maxCorners:qualityLevel:minDistance:mask:blockSize:useHarrisDetector:")]
		void GoodFeaturesToTrack (Mat image, NSMutableArray<Point2i> corners, int maxCorners, double qualityLevel, double minDistance, Mat mask, int blockSize, bool useHarrisDetector);

		// +(void)goodFeaturesToTrack:(Mat * _Nonnull)image corners:(NSMutableArray<Point2i *> * _Nonnull)corners maxCorners:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance mask:(Mat * _Nonnull)mask blockSize:(int)blockSize __attribute__((swift_name("goodFeaturesToTrack(image:corners:maxCorners:qualityLevel:minDistance:mask:blockSize:)")));
		[Static]
		[Export ("goodFeaturesToTrack:corners:maxCorners:qualityLevel:minDistance:mask:blockSize:")]
		void GoodFeaturesToTrack (Mat image, NSMutableArray<Point2i> corners, int maxCorners, double qualityLevel, double minDistance, Mat mask, int blockSize);

		// +(void)goodFeaturesToTrack:(Mat * _Nonnull)image corners:(NSMutableArray<Point2i *> * _Nonnull)corners maxCorners:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance mask:(Mat * _Nonnull)mask __attribute__((swift_name("goodFeaturesToTrack(image:corners:maxCorners:qualityLevel:minDistance:mask:)")));
		[Static]
		[Export ("goodFeaturesToTrack:corners:maxCorners:qualityLevel:minDistance:mask:")]
		void GoodFeaturesToTrack (Mat image, NSMutableArray<Point2i> corners, int maxCorners, double qualityLevel, double minDistance, Mat mask);

		// +(void)goodFeaturesToTrack:(Mat * _Nonnull)image corners:(NSMutableArray<Point2i *> * _Nonnull)corners maxCorners:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance __attribute__((swift_name("goodFeaturesToTrack(image:corners:maxCorners:qualityLevel:minDistance:)")));
		[Static]
		[Export ("goodFeaturesToTrack:corners:maxCorners:qualityLevel:minDistance:")]
		void GoodFeaturesToTrack (Mat image, NSMutableArray<Point2i> corners, int maxCorners, double qualityLevel, double minDistance);

		// +(void)goodFeaturesToTrack:(Mat * _Nonnull)image corners:(NSMutableArray<Point2i *> * _Nonnull)corners maxCorners:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance mask:(Mat * _Nonnull)mask blockSize:(int)blockSize gradientSize:(int)gradientSize useHarrisDetector:(BOOL)useHarrisDetector k:(double)k __attribute__((swift_name("goodFeaturesToTrack(image:corners:maxCorners:qualityLevel:minDistance:mask:blockSize:gradientSize:useHarrisDetector:k:)")));
		[Static]
		[Export ("goodFeaturesToTrack:corners:maxCorners:qualityLevel:minDistance:mask:blockSize:gradientSize:useHarrisDetector:k:")]
		void GoodFeaturesToTrack (Mat image, NSMutableArray<Point2i> corners, int maxCorners, double qualityLevel, double minDistance, Mat mask, int blockSize, int gradientSize, bool useHarrisDetector, double k);

		// +(void)goodFeaturesToTrack:(Mat * _Nonnull)image corners:(NSMutableArray<Point2i *> * _Nonnull)corners maxCorners:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance mask:(Mat * _Nonnull)mask blockSize:(int)blockSize gradientSize:(int)gradientSize useHarrisDetector:(BOOL)useHarrisDetector __attribute__((swift_name("goodFeaturesToTrack(image:corners:maxCorners:qualityLevel:minDistance:mask:blockSize:gradientSize:useHarrisDetector:)")));
		[Static]
		[Export ("goodFeaturesToTrack:corners:maxCorners:qualityLevel:minDistance:mask:blockSize:gradientSize:useHarrisDetector:")]
		void GoodFeaturesToTrack (Mat image, NSMutableArray<Point2i> corners, int maxCorners, double qualityLevel, double minDistance, Mat mask, int blockSize, int gradientSize, bool useHarrisDetector);

		// +(void)goodFeaturesToTrack:(Mat * _Nonnull)image corners:(NSMutableArray<Point2i *> * _Nonnull)corners maxCorners:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance mask:(Mat * _Nonnull)mask blockSize:(int)blockSize gradientSize:(int)gradientSize __attribute__((swift_name("goodFeaturesToTrack(image:corners:maxCorners:qualityLevel:minDistance:mask:blockSize:gradientSize:)")));
		[Static]
		[Export ("goodFeaturesToTrack:corners:maxCorners:qualityLevel:minDistance:mask:blockSize:gradientSize:")]
		void GoodFeaturesToTrack (Mat image, NSMutableArray<Point2i> corners, int maxCorners, double qualityLevel, double minDistance, Mat mask, int blockSize, int gradientSize);

		// +(void)goodFeaturesToTrackWithQuality:(Mat * _Nonnull)image corners:(Mat * _Nonnull)corners maxCorners:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance mask:(Mat * _Nonnull)mask cornersQuality:(Mat * _Nonnull)cornersQuality blockSize:(int)blockSize gradientSize:(int)gradientSize useHarrisDetector:(BOOL)useHarrisDetector k:(double)k __attribute__((swift_name("goodFeaturesToTrack(image:corners:maxCorners:qualityLevel:minDistance:mask:cornersQuality:blockSize:gradientSize:useHarrisDetector:k:)")));
		[Static]
		[Export ("goodFeaturesToTrackWithQuality:corners:maxCorners:qualityLevel:minDistance:mask:cornersQuality:blockSize:gradientSize:useHarrisDetector:k:")]
		void GoodFeaturesToTrackWithQuality (Mat image, Mat corners, int maxCorners, double qualityLevel, double minDistance, Mat mask, Mat cornersQuality, int blockSize, int gradientSize, bool useHarrisDetector, double k);

		// +(void)goodFeaturesToTrackWithQuality:(Mat * _Nonnull)image corners:(Mat * _Nonnull)corners maxCorners:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance mask:(Mat * _Nonnull)mask cornersQuality:(Mat * _Nonnull)cornersQuality blockSize:(int)blockSize gradientSize:(int)gradientSize useHarrisDetector:(BOOL)useHarrisDetector __attribute__((swift_name("goodFeaturesToTrack(image:corners:maxCorners:qualityLevel:minDistance:mask:cornersQuality:blockSize:gradientSize:useHarrisDetector:)")));
		[Static]
		[Export ("goodFeaturesToTrackWithQuality:corners:maxCorners:qualityLevel:minDistance:mask:cornersQuality:blockSize:gradientSize:useHarrisDetector:")]
		void GoodFeaturesToTrackWithQuality (Mat image, Mat corners, int maxCorners, double qualityLevel, double minDistance, Mat mask, Mat cornersQuality, int blockSize, int gradientSize, bool useHarrisDetector);

		// +(void)goodFeaturesToTrackWithQuality:(Mat * _Nonnull)image corners:(Mat * _Nonnull)corners maxCorners:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance mask:(Mat * _Nonnull)mask cornersQuality:(Mat * _Nonnull)cornersQuality blockSize:(int)blockSize gradientSize:(int)gradientSize __attribute__((swift_name("goodFeaturesToTrack(image:corners:maxCorners:qualityLevel:minDistance:mask:cornersQuality:blockSize:gradientSize:)")));
		[Static]
		[Export ("goodFeaturesToTrackWithQuality:corners:maxCorners:qualityLevel:minDistance:mask:cornersQuality:blockSize:gradientSize:")]
		void GoodFeaturesToTrackWithQuality (Mat image, Mat corners, int maxCorners, double qualityLevel, double minDistance, Mat mask, Mat cornersQuality, int blockSize, int gradientSize);

		// +(void)goodFeaturesToTrackWithQuality:(Mat * _Nonnull)image corners:(Mat * _Nonnull)corners maxCorners:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance mask:(Mat * _Nonnull)mask cornersQuality:(Mat * _Nonnull)cornersQuality blockSize:(int)blockSize __attribute__((swift_name("goodFeaturesToTrack(image:corners:maxCorners:qualityLevel:minDistance:mask:cornersQuality:blockSize:)")));
		[Static]
		[Export ("goodFeaturesToTrackWithQuality:corners:maxCorners:qualityLevel:minDistance:mask:cornersQuality:blockSize:")]
		void GoodFeaturesToTrackWithQuality (Mat image, Mat corners, int maxCorners, double qualityLevel, double minDistance, Mat mask, Mat cornersQuality, int blockSize);

		// +(void)goodFeaturesToTrackWithQuality:(Mat * _Nonnull)image corners:(Mat * _Nonnull)corners maxCorners:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance mask:(Mat * _Nonnull)mask cornersQuality:(Mat * _Nonnull)cornersQuality __attribute__((swift_name("goodFeaturesToTrack(image:corners:maxCorners:qualityLevel:minDistance:mask:cornersQuality:)")));
		[Static]
		[Export ("goodFeaturesToTrackWithQuality:corners:maxCorners:qualityLevel:minDistance:mask:cornersQuality:")]
		void GoodFeaturesToTrackWithQuality (Mat image, Mat corners, int maxCorners, double qualityLevel, double minDistance, Mat mask, Mat cornersQuality);

		// +(void)HoughLines:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold srn:(double)srn stn:(double)stn min_theta:(double)min_theta max_theta:(double)max_theta use_edgeval:(BOOL)use_edgeval __attribute__((swift_name("HoughLines(image:lines:rho:theta:threshold:srn:stn:min_theta:max_theta:use_edgeval:)")));
		[Static]
		[Export ("HoughLines:lines:rho:theta:threshold:srn:stn:min_theta:max_theta:use_edgeval:")]
		void HoughLines (Mat image, Mat lines, double rho, double theta, int threshold, double srn, double stn, double min_theta, double max_theta, bool use_edgeval);

		// +(void)HoughLines:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold srn:(double)srn stn:(double)stn min_theta:(double)min_theta max_theta:(double)max_theta __attribute__((swift_name("HoughLines(image:lines:rho:theta:threshold:srn:stn:min_theta:max_theta:)")));
		[Static]
		[Export ("HoughLines:lines:rho:theta:threshold:srn:stn:min_theta:max_theta:")]
		void HoughLines (Mat image, Mat lines, double rho, double theta, int threshold, double srn, double stn, double min_theta, double max_theta);

		// +(void)HoughLines:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold srn:(double)srn stn:(double)stn min_theta:(double)min_theta __attribute__((swift_name("HoughLines(image:lines:rho:theta:threshold:srn:stn:min_theta:)")));
		[Static]
		[Export ("HoughLines:lines:rho:theta:threshold:srn:stn:min_theta:")]
		void HoughLines (Mat image, Mat lines, double rho, double theta, int threshold, double srn, double stn, double min_theta);

		// +(void)HoughLines:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold srn:(double)srn stn:(double)stn __attribute__((swift_name("HoughLines(image:lines:rho:theta:threshold:srn:stn:)")));
		[Static]
		[Export ("HoughLines:lines:rho:theta:threshold:srn:stn:")]
		void HoughLines (Mat image, Mat lines, double rho, double theta, int threshold, double srn, double stn);

		// +(void)HoughLines:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold srn:(double)srn __attribute__((swift_name("HoughLines(image:lines:rho:theta:threshold:srn:)")));
		[Static]
		[Export ("HoughLines:lines:rho:theta:threshold:srn:")]
		void HoughLines (Mat image, Mat lines, double rho, double theta, int threshold, double srn);

		// +(void)HoughLines:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold __attribute__((swift_name("HoughLines(image:lines:rho:theta:threshold:)")));
		[Static]
		[Export ("HoughLines:lines:rho:theta:threshold:")]
		void HoughLines (Mat image, Mat lines, double rho, double theta, int threshold);

		// +(void)HoughLinesP:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold minLineLength:(double)minLineLength maxLineGap:(double)maxLineGap __attribute__((swift_name("HoughLinesP(image:lines:rho:theta:threshold:minLineLength:maxLineGap:)")));
		[Static]
		[Export ("HoughLinesP:lines:rho:theta:threshold:minLineLength:maxLineGap:")]
		void HoughLinesP (Mat image, Mat lines, double rho, double theta, int threshold, double minLineLength, double maxLineGap);

		// +(void)HoughLinesP:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold minLineLength:(double)minLineLength __attribute__((swift_name("HoughLinesP(image:lines:rho:theta:threshold:minLineLength:)")));
		[Static]
		[Export ("HoughLinesP:lines:rho:theta:threshold:minLineLength:")]
		void HoughLinesP (Mat image, Mat lines, double rho, double theta, int threshold, double minLineLength);

		// +(void)HoughLinesP:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold __attribute__((swift_name("HoughLinesP(image:lines:rho:theta:threshold:)")));
		[Static]
		[Export ("HoughLinesP:lines:rho:theta:threshold:")]
		void HoughLinesP (Mat image, Mat lines, double rho, double theta, int threshold);

		// +(void)HoughLinesPointSet:(Mat * _Nonnull)point lines:(Mat * _Nonnull)lines lines_max:(int)lines_max threshold:(int)threshold min_rho:(double)min_rho max_rho:(double)max_rho rho_step:(double)rho_step min_theta:(double)min_theta max_theta:(double)max_theta theta_step:(double)theta_step __attribute__((swift_name("HoughLinesPointSet(point:lines:lines_max:threshold:min_rho:max_rho:rho_step:min_theta:max_theta:theta_step:)")));
		[Static]
		[Export ("HoughLinesPointSet:lines:lines_max:threshold:min_rho:max_rho:rho_step:min_theta:max_theta:theta_step:")]
		void HoughLinesPointSet (Mat point, Mat lines, int lines_max, int threshold, double min_rho, double max_rho, double rho_step, double min_theta, double max_theta, double theta_step);

		// +(void)HoughCircles:(Mat * _Nonnull)image circles:(Mat * _Nonnull)circles method:(HoughModes)method dp:(double)dp minDist:(double)minDist param1:(double)param1 param2:(double)param2 minRadius:(int)minRadius maxRadius:(int)maxRadius __attribute__((swift_name("HoughCircles(image:circles:method:dp:minDist:param1:param2:minRadius:maxRadius:)")));
		[Static]
		[Export ("HoughCircles:circles:method:dp:minDist:param1:param2:minRadius:maxRadius:")]
		void HoughCircles (Mat image, Mat circles, HoughModes method, double dp, double minDist, double param1, double param2, int minRadius, int maxRadius);

		// +(void)HoughCircles:(Mat * _Nonnull)image circles:(Mat * _Nonnull)circles method:(HoughModes)method dp:(double)dp minDist:(double)minDist param1:(double)param1 param2:(double)param2 minRadius:(int)minRadius __attribute__((swift_name("HoughCircles(image:circles:method:dp:minDist:param1:param2:minRadius:)")));
		[Static]
		[Export ("HoughCircles:circles:method:dp:minDist:param1:param2:minRadius:")]
		void HoughCircles (Mat image, Mat circles, HoughModes method, double dp, double minDist, double param1, double param2, int minRadius);

		// +(void)HoughCircles:(Mat * _Nonnull)image circles:(Mat * _Nonnull)circles method:(HoughModes)method dp:(double)dp minDist:(double)minDist param1:(double)param1 param2:(double)param2 __attribute__((swift_name("HoughCircles(image:circles:method:dp:minDist:param1:param2:)")));
		[Static]
		[Export ("HoughCircles:circles:method:dp:minDist:param1:param2:")]
		void HoughCircles (Mat image, Mat circles, HoughModes method, double dp, double minDist, double param1, double param2);

		// +(void)HoughCircles:(Mat * _Nonnull)image circles:(Mat * _Nonnull)circles method:(HoughModes)method dp:(double)dp minDist:(double)minDist param1:(double)param1 __attribute__((swift_name("HoughCircles(image:circles:method:dp:minDist:param1:)")));
		[Static]
		[Export ("HoughCircles:circles:method:dp:minDist:param1:")]
		void HoughCircles (Mat image, Mat circles, HoughModes method, double dp, double minDist, double param1);

		// +(void)HoughCircles:(Mat * _Nonnull)image circles:(Mat * _Nonnull)circles method:(HoughModes)method dp:(double)dp minDist:(double)minDist __attribute__((swift_name("HoughCircles(image:circles:method:dp:minDist:)")));
		[Static]
		[Export ("HoughCircles:circles:method:dp:minDist:")]
		void HoughCircles (Mat image, Mat circles, HoughModes method, double dp, double minDist);

		// +(void)erode:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor iterations:(int)iterations borderType:(BorderTypes)borderType borderValue:(Scalar * _Nonnull)borderValue __attribute__((swift_name("erode(src:dst:kernel:anchor:iterations:borderType:borderValue:)")));
		[Static]
		[Export ("erode:dst:kernel:anchor:iterations:borderType:borderValue:")]
		void Erode (Mat src, Mat dst, Mat kernel, Point2i anchor, int iterations, BorderTypes borderType, Scalar borderValue);

		// +(void)erode:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor iterations:(int)iterations borderType:(BorderTypes)borderType __attribute__((swift_name("erode(src:dst:kernel:anchor:iterations:borderType:)")));
		[Static]
		[Export ("erode:dst:kernel:anchor:iterations:borderType:")]
		void Erode (Mat src, Mat dst, Mat kernel, Point2i anchor, int iterations, BorderTypes borderType);

		// +(void)erode:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor iterations:(int)iterations __attribute__((swift_name("erode(src:dst:kernel:anchor:iterations:)")));
		[Static]
		[Export ("erode:dst:kernel:anchor:iterations:")]
		void Erode (Mat src, Mat dst, Mat kernel, Point2i anchor, int iterations);

		// +(void)erode:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor __attribute__((swift_name("erode(src:dst:kernel:anchor:)")));
		[Static]
		[Export ("erode:dst:kernel:anchor:")]
		void Erode (Mat src, Mat dst, Mat kernel, Point2i anchor);

		// +(void)erode:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst kernel:(Mat * _Nonnull)kernel __attribute__((swift_name("erode(src:dst:kernel:)")));
		[Static]
		[Export ("erode:dst:kernel:")]
		void Erode (Mat src, Mat dst, Mat kernel);

		// +(void)dilate:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor iterations:(int)iterations borderType:(BorderTypes)borderType borderValue:(Scalar * _Nonnull)borderValue __attribute__((swift_name("dilate(src:dst:kernel:anchor:iterations:borderType:borderValue:)")));
		[Static]
		[Export ("dilate:dst:kernel:anchor:iterations:borderType:borderValue:")]
		void Dilate (Mat src, Mat dst, Mat kernel, Point2i anchor, int iterations, BorderTypes borderType, Scalar borderValue);

		// +(void)dilate:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor iterations:(int)iterations borderType:(BorderTypes)borderType __attribute__((swift_name("dilate(src:dst:kernel:anchor:iterations:borderType:)")));
		[Static]
		[Export ("dilate:dst:kernel:anchor:iterations:borderType:")]
		void Dilate (Mat src, Mat dst, Mat kernel, Point2i anchor, int iterations, BorderTypes borderType);

		// +(void)dilate:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor iterations:(int)iterations __attribute__((swift_name("dilate(src:dst:kernel:anchor:iterations:)")));
		[Static]
		[Export ("dilate:dst:kernel:anchor:iterations:")]
		void Dilate (Mat src, Mat dst, Mat kernel, Point2i anchor, int iterations);

		// +(void)dilate:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor __attribute__((swift_name("dilate(src:dst:kernel:anchor:)")));
		[Static]
		[Export ("dilate:dst:kernel:anchor:")]
		void Dilate (Mat src, Mat dst, Mat kernel, Point2i anchor);

		// +(void)dilate:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst kernel:(Mat * _Nonnull)kernel __attribute__((swift_name("dilate(src:dst:kernel:)")));
		[Static]
		[Export ("dilate:dst:kernel:")]
		void Dilate (Mat src, Mat dst, Mat kernel);

		// +(void)morphologyEx:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst op:(MorphTypes)op kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor iterations:(int)iterations borderType:(BorderTypes)borderType borderValue:(Scalar * _Nonnull)borderValue __attribute__((swift_name("morphologyEx(src:dst:op:kernel:anchor:iterations:borderType:borderValue:)")));
		[Static]
		[Export ("morphologyEx:dst:op:kernel:anchor:iterations:borderType:borderValue:")]
		void MorphologyEx (Mat src, Mat dst, MorphTypes op, Mat kernel, Point2i anchor, int iterations, BorderTypes borderType, Scalar borderValue);

		// +(void)morphologyEx:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst op:(MorphTypes)op kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor iterations:(int)iterations borderType:(BorderTypes)borderType __attribute__((swift_name("morphologyEx(src:dst:op:kernel:anchor:iterations:borderType:)")));
		[Static]
		[Export ("morphologyEx:dst:op:kernel:anchor:iterations:borderType:")]
		void MorphologyEx (Mat src, Mat dst, MorphTypes op, Mat kernel, Point2i anchor, int iterations, BorderTypes borderType);

		// +(void)morphologyEx:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst op:(MorphTypes)op kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor iterations:(int)iterations __attribute__((swift_name("morphologyEx(src:dst:op:kernel:anchor:iterations:)")));
		[Static]
		[Export ("morphologyEx:dst:op:kernel:anchor:iterations:")]
		void MorphologyEx (Mat src, Mat dst, MorphTypes op, Mat kernel, Point2i anchor, int iterations);

		// +(void)morphologyEx:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst op:(MorphTypes)op kernel:(Mat * _Nonnull)kernel anchor:(Point2i * _Nonnull)anchor __attribute__((swift_name("morphologyEx(src:dst:op:kernel:anchor:)")));
		[Static]
		[Export ("morphologyEx:dst:op:kernel:anchor:")]
		void MorphologyEx (Mat src, Mat dst, MorphTypes op, Mat kernel, Point2i anchor);

		// +(void)morphologyEx:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst op:(MorphTypes)op kernel:(Mat * _Nonnull)kernel __attribute__((swift_name("morphologyEx(src:dst:op:kernel:)")));
		[Static]
		[Export ("morphologyEx:dst:op:kernel:")]
		void MorphologyEx (Mat src, Mat dst, MorphTypes op, Mat kernel);

		// +(void)resize:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst dsize:(Size2i * _Nonnull)dsize fx:(double)fx fy:(double)fy interpolation:(int)interpolation __attribute__((swift_name("resize(src:dst:dsize:fx:fy:interpolation:)")));
		[Static]
		[Export ("resize:dst:dsize:fx:fy:interpolation:")]
		void Resize (Mat src, Mat dst, Size2i dsize, double fx, double fy, int interpolation);

		// +(void)resize:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst dsize:(Size2i * _Nonnull)dsize fx:(double)fx fy:(double)fy __attribute__((swift_name("resize(src:dst:dsize:fx:fy:)")));
		[Static]
		[Export ("resize:dst:dsize:fx:fy:")]
		void Resize (Mat src, Mat dst, Size2i dsize, double fx, double fy);

		// +(void)resize:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst dsize:(Size2i * _Nonnull)dsize fx:(double)fx __attribute__((swift_name("resize(src:dst:dsize:fx:)")));
		[Static]
		[Export ("resize:dst:dsize:fx:")]
		void Resize (Mat src, Mat dst, Size2i dsize, double fx);

		// +(void)resize:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst dsize:(Size2i * _Nonnull)dsize __attribute__((swift_name("resize(src:dst:dsize:)")));
		[Static]
		[Export ("resize:dst:dsize:")]
		void Resize (Mat src, Mat dst, Size2i dsize);

		// +(void)warpAffine:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst M:(Mat * _Nonnull)M dsize:(Size2i * _Nonnull)dsize flags:(int)flags borderMode:(BorderTypes)borderMode borderValue:(Scalar * _Nonnull)borderValue __attribute__((swift_name("warpAffine(src:dst:M:dsize:flags:borderMode:borderValue:)")));
		[Static]
		[Export ("warpAffine:dst:M:dsize:flags:borderMode:borderValue:")]
		void WarpAffine (Mat src, Mat dst, Mat M, Size2i dsize, int flags, BorderTypes borderMode, Scalar borderValue);

		// +(void)warpAffine:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst M:(Mat * _Nonnull)M dsize:(Size2i * _Nonnull)dsize flags:(int)flags borderMode:(BorderTypes)borderMode __attribute__((swift_name("warpAffine(src:dst:M:dsize:flags:borderMode:)")));
		[Static]
		[Export ("warpAffine:dst:M:dsize:flags:borderMode:")]
		void WarpAffine (Mat src, Mat dst, Mat M, Size2i dsize, int flags, BorderTypes borderMode);

		// +(void)warpAffine:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst M:(Mat * _Nonnull)M dsize:(Size2i * _Nonnull)dsize flags:(int)flags __attribute__((swift_name("warpAffine(src:dst:M:dsize:flags:)")));
		[Static]
		[Export ("warpAffine:dst:M:dsize:flags:")]
		void WarpAffine (Mat src, Mat dst, Mat M, Size2i dsize, int flags);

		// +(void)warpAffine:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst M:(Mat * _Nonnull)M dsize:(Size2i * _Nonnull)dsize __attribute__((swift_name("warpAffine(src:dst:M:dsize:)")));
		[Static]
		[Export ("warpAffine:dst:M:dsize:")]
		void WarpAffine (Mat src, Mat dst, Mat M, Size2i dsize);

		// +(void)warpPerspective:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst M:(Mat * _Nonnull)M dsize:(Size2i * _Nonnull)dsize flags:(int)flags borderMode:(BorderTypes)borderMode borderValue:(Scalar * _Nonnull)borderValue __attribute__((swift_name("warpPerspective(src:dst:M:dsize:flags:borderMode:borderValue:)")));
		[Static]
		[Export ("warpPerspective:dst:M:dsize:flags:borderMode:borderValue:")]
		void WarpPerspective (Mat src, Mat dst, Mat M, Size2i dsize, int flags, BorderTypes borderMode, Scalar borderValue);

		// +(void)warpPerspective:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst M:(Mat * _Nonnull)M dsize:(Size2i * _Nonnull)dsize flags:(int)flags borderMode:(BorderTypes)borderMode __attribute__((swift_name("warpPerspective(src:dst:M:dsize:flags:borderMode:)")));
		[Static]
		[Export ("warpPerspective:dst:M:dsize:flags:borderMode:")]
		void WarpPerspective (Mat src, Mat dst, Mat M, Size2i dsize, int flags, BorderTypes borderMode);

		// +(void)warpPerspective:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst M:(Mat * _Nonnull)M dsize:(Size2i * _Nonnull)dsize flags:(int)flags __attribute__((swift_name("warpPerspective(src:dst:M:dsize:flags:)")));
		[Static]
		[Export ("warpPerspective:dst:M:dsize:flags:")]
		void WarpPerspective (Mat src, Mat dst, Mat M, Size2i dsize, int flags);

		// +(void)warpPerspective:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst M:(Mat * _Nonnull)M dsize:(Size2i * _Nonnull)dsize __attribute__((swift_name("warpPerspective(src:dst:M:dsize:)")));
		[Static]
		[Export ("warpPerspective:dst:M:dsize:")]
		void WarpPerspective (Mat src, Mat dst, Mat M, Size2i dsize);

		// +(void)remap:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst map1:(Mat * _Nonnull)map1 map2:(Mat * _Nonnull)map2 interpolation:(int)interpolation borderMode:(BorderTypes)borderMode borderValue:(Scalar * _Nonnull)borderValue __attribute__((swift_name("remap(src:dst:map1:map2:interpolation:borderMode:borderValue:)")));
		[Static]
		[Export ("remap:dst:map1:map2:interpolation:borderMode:borderValue:")]
		void Remap (Mat src, Mat dst, Mat map1, Mat map2, int interpolation, BorderTypes borderMode, Scalar borderValue);

		// +(void)remap:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst map1:(Mat * _Nonnull)map1 map2:(Mat * _Nonnull)map2 interpolation:(int)interpolation borderMode:(BorderTypes)borderMode __attribute__((swift_name("remap(src:dst:map1:map2:interpolation:borderMode:)")));
		[Static]
		[Export ("remap:dst:map1:map2:interpolation:borderMode:")]
		void Remap (Mat src, Mat dst, Mat map1, Mat map2, int interpolation, BorderTypes borderMode);

		// +(void)remap:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst map1:(Mat * _Nonnull)map1 map2:(Mat * _Nonnull)map2 interpolation:(int)interpolation __attribute__((swift_name("remap(src:dst:map1:map2:interpolation:)")));
		[Static]
		[Export ("remap:dst:map1:map2:interpolation:")]
		void Remap (Mat src, Mat dst, Mat map1, Mat map2, int interpolation);

		// +(void)convertMaps:(Mat * _Nonnull)map1 map2:(Mat * _Nonnull)map2 dstmap1:(Mat * _Nonnull)dstmap1 dstmap2:(Mat * _Nonnull)dstmap2 dstmap1type:(int)dstmap1type nninterpolation:(BOOL)nninterpolation __attribute__((swift_name("convertMaps(map1:map2:dstmap1:dstmap2:dstmap1type:nninterpolation:)")));
		[Static]
		[Export ("convertMaps:map2:dstmap1:dstmap2:dstmap1type:nninterpolation:")]
		void ConvertMaps (Mat map1, Mat map2, Mat dstmap1, Mat dstmap2, int dstmap1type, bool nninterpolation);

		// +(void)convertMaps:(Mat * _Nonnull)map1 map2:(Mat * _Nonnull)map2 dstmap1:(Mat * _Nonnull)dstmap1 dstmap2:(Mat * _Nonnull)dstmap2 dstmap1type:(int)dstmap1type __attribute__((swift_name("convertMaps(map1:map2:dstmap1:dstmap2:dstmap1type:)")));
		[Static]
		[Export ("convertMaps:map2:dstmap1:dstmap2:dstmap1type:")]
		void ConvertMaps (Mat map1, Mat map2, Mat dstmap1, Mat dstmap2, int dstmap1type);

		// +(Mat * _Nonnull)getRotationMatrix2D:(Point2f * _Nonnull)center angle:(double)angle scale:(double)scale __attribute__((swift_name("getRotationMatrix2D(center:angle:scale:)")));
		[Static]
		[Export ("getRotationMatrix2D:angle:scale:")]
		Mat GetRotationMatrix2D (Point2f center, double angle, double scale);

		// +(void)invertAffineTransform:(Mat * _Nonnull)M iM:(Mat * _Nonnull)iM __attribute__((swift_name("invertAffineTransform(M:iM:)")));
		[Static]
		[Export ("invertAffineTransform:iM:")]
		void InvertAffineTransform (Mat M, Mat iM);

		// +(Mat * _Nonnull)getPerspectiveTransform:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst solveMethod:(int)solveMethod __attribute__((swift_name("getPerspectiveTransform(src:dst:solveMethod:)")));
		[Static]
		[Export ("getPerspectiveTransform:dst:solveMethod:")]
		Mat GetPerspectiveTransform (Mat src, Mat dst, int solveMethod);

		// +(Mat * _Nonnull)getPerspectiveTransform:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("getPerspectiveTransform(src:dst:)")));
		[Static]
		[Export ("getPerspectiveTransform:dst:")]
		Mat GetPerspectiveTransform (Mat src, Mat dst);

		// +(Mat * _Nonnull)getAffineTransform:(NSArray<Point2f *> * _Nonnull)src dst:(NSArray<Point2f *> * _Nonnull)dst __attribute__((swift_name("getAffineTransform(src:dst:)")));
		[Static]
		[Export ("getAffineTransform:dst:")]
		Mat GetAffineTransform (Point2f[] src, Point2f[] dst);

		// +(void)getRectSubPix:(Mat * _Nonnull)image patchSize:(Size2i * _Nonnull)patchSize center:(Point2f * _Nonnull)center patch:(Mat * _Nonnull)patch patchType:(int)patchType __attribute__((swift_name("getRectSubPix(image:patchSize:center:patch:patchType:)")));
		[Static]
		[Export ("getRectSubPix:patchSize:center:patch:patchType:")]
		void GetRectSubPix (Mat image, Size2i patchSize, Point2f center, Mat patch, int patchType);

		// +(void)getRectSubPix:(Mat * _Nonnull)image patchSize:(Size2i * _Nonnull)patchSize center:(Point2f * _Nonnull)center patch:(Mat * _Nonnull)patch __attribute__((swift_name("getRectSubPix(image:patchSize:center:patch:)")));
		[Static]
		[Export ("getRectSubPix:patchSize:center:patch:")]
		void GetRectSubPix (Mat image, Size2i patchSize, Point2f center, Mat patch);

		// +(void)logPolar:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst center:(Point2f * _Nonnull)center M:(double)M flags:(int)flags __attribute__((swift_name("logPolar(src:dst:center:M:flags:)"))) __attribute__((deprecated("")));
		[Static]
		[Export ("logPolar:dst:center:M:flags:")]
		void LogPolar (Mat src, Mat dst, Point2f center, double M, int flags);

		// +(void)linearPolar:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst center:(Point2f * _Nonnull)center maxRadius:(double)maxRadius flags:(int)flags __attribute__((swift_name("linearPolar(src:dst:center:maxRadius:flags:)"))) __attribute__((deprecated("")));
		[Static]
		[Export ("linearPolar:dst:center:maxRadius:flags:")]
		void LinearPolar (Mat src, Mat dst, Point2f center, double maxRadius, int flags);

		// +(void)warpPolar:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst dsize:(Size2i * _Nonnull)dsize center:(Point2f * _Nonnull)center maxRadius:(double)maxRadius flags:(int)flags __attribute__((swift_name("warpPolar(src:dst:dsize:center:maxRadius:flags:)")));
		[Static]
		[Export ("warpPolar:dst:dsize:center:maxRadius:flags:")]
		void WarpPolar (Mat src, Mat dst, Size2i dsize, Point2f center, double maxRadius, int flags);

		// +(void)integral3:(Mat * _Nonnull)src sum:(Mat * _Nonnull)sum sqsum:(Mat * _Nonnull)sqsum tilted:(Mat * _Nonnull)tilted sdepth:(int)sdepth sqdepth:(int)sqdepth __attribute__((swift_name("integral(src:sum:sqsum:tilted:sdepth:sqdepth:)")));
		[Static]
		[Export ("integral3:sum:sqsum:tilted:sdepth:sqdepth:")]
		void Integral3 (Mat src, Mat sum, Mat sqsum, Mat tilted, int sdepth, int sqdepth);

		// +(void)integral3:(Mat * _Nonnull)src sum:(Mat * _Nonnull)sum sqsum:(Mat * _Nonnull)sqsum tilted:(Mat * _Nonnull)tilted sdepth:(int)sdepth __attribute__((swift_name("integral(src:sum:sqsum:tilted:sdepth:)")));
		[Static]
		[Export ("integral3:sum:sqsum:tilted:sdepth:")]
		void Integral3 (Mat src, Mat sum, Mat sqsum, Mat tilted, int sdepth);

		// +(void)integral3:(Mat * _Nonnull)src sum:(Mat * _Nonnull)sum sqsum:(Mat * _Nonnull)sqsum tilted:(Mat * _Nonnull)tilted __attribute__((swift_name("integral(src:sum:sqsum:tilted:)")));
		[Static]
		[Export ("integral3:sum:sqsum:tilted:")]
		void Integral3 (Mat src, Mat sum, Mat sqsum, Mat tilted);

		// +(void)integral:(Mat * _Nonnull)src sum:(Mat * _Nonnull)sum sdepth:(int)sdepth __attribute__((swift_name("integral(src:sum:sdepth:)")));
		[Static]
		[Export ("integral:sum:sdepth:")]
		void Integral (Mat src, Mat sum, int sdepth);

		// +(void)integral:(Mat * _Nonnull)src sum:(Mat * _Nonnull)sum __attribute__((swift_name("integral(src:sum:)")));
		[Static]
		[Export ("integral:sum:")]
		void Integral (Mat src, Mat sum);

		// +(void)integral2:(Mat * _Nonnull)src sum:(Mat * _Nonnull)sum sqsum:(Mat * _Nonnull)sqsum sdepth:(int)sdepth sqdepth:(int)sqdepth __attribute__((swift_name("integral(src:sum:sqsum:sdepth:sqdepth:)")));
		[Static]
		[Export ("integral2:sum:sqsum:sdepth:sqdepth:")]
		void Integral2 (Mat src, Mat sum, Mat sqsum, int sdepth, int sqdepth);

		// +(void)integral2:(Mat * _Nonnull)src sum:(Mat * _Nonnull)sum sqsum:(Mat * _Nonnull)sqsum sdepth:(int)sdepth __attribute__((swift_name("integral(src:sum:sqsum:sdepth:)")));
		[Static]
		[Export ("integral2:sum:sqsum:sdepth:")]
		void Integral2 (Mat src, Mat sum, Mat sqsum, int sdepth);

		// +(void)integral2:(Mat * _Nonnull)src sum:(Mat * _Nonnull)sum sqsum:(Mat * _Nonnull)sqsum __attribute__((swift_name("integral(src:sum:sqsum:)")));
		[Static]
		[Export ("integral2:sum:sqsum:")]
		void Integral2 (Mat src, Mat sum, Mat sqsum);

		// +(void)accumulate:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask __attribute__((swift_name("accumulate(src:dst:mask:)")));
		[Static]
		[Export ("accumulate:dst:mask:")]
		void Accumulate (Mat src, Mat dst, Mat mask);

		// +(void)accumulate:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("accumulate(src:dst:)")));
		[Static]
		[Export ("accumulate:dst:")]
		void Accumulate (Mat src, Mat dst);

		// +(void)accumulateSquare:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask __attribute__((swift_name("accumulateSquare(src:dst:mask:)")));
		[Static]
		[Export ("accumulateSquare:dst:mask:")]
		void AccumulateSquare (Mat src, Mat dst, Mat mask);

		// +(void)accumulateSquare:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("accumulateSquare(src:dst:)")));
		[Static]
		[Export ("accumulateSquare:dst:")]
		void AccumulateSquare (Mat src, Mat dst);

		// +(void)accumulateProduct:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask __attribute__((swift_name("accumulateProduct(src1:src2:dst:mask:)")));
		[Static]
		[Export ("accumulateProduct:src2:dst:mask:")]
		void AccumulateProduct (Mat src1, Mat src2, Mat dst, Mat mask);

		// +(void)accumulateProduct:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst __attribute__((swift_name("accumulateProduct(src1:src2:dst:)")));
		[Static]
		[Export ("accumulateProduct:src2:dst:")]
		void AccumulateProduct (Mat src1, Mat src2, Mat dst);

		// +(void)accumulateWeighted:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst alpha:(double)alpha mask:(Mat * _Nonnull)mask __attribute__((swift_name("accumulateWeighted(src:dst:alpha:mask:)")));
		[Static]
		[Export ("accumulateWeighted:dst:alpha:mask:")]
		void AccumulateWeighted (Mat src, Mat dst, double alpha, Mat mask);

		// +(void)accumulateWeighted:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst alpha:(double)alpha __attribute__((swift_name("accumulateWeighted(src:dst:alpha:)")));
		[Static]
		[Export ("accumulateWeighted:dst:alpha:")]
		void AccumulateWeighted (Mat src, Mat dst, double alpha);

		// +(Point2d * _Nonnull)phaseCorrelate:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 window:(Mat * _Nonnull)window response:(double * _Nonnull)response __attribute__((swift_name("phaseCorrelate(src1:src2:window:response:)")));
		[Static]
		[Export ("phaseCorrelate:src2:window:response:")]
		unsafe Point2d PhaseCorrelate (Mat src1, Mat src2, Mat window, double* response);

		// +(Point2d * _Nonnull)phaseCorrelate:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 window:(Mat * _Nonnull)window __attribute__((swift_name("phaseCorrelate(src1:src2:window:)")));
		[Static]
		[Export ("phaseCorrelate:src2:window:")]
		Point2d PhaseCorrelate (Mat src1, Mat src2, Mat window);

		// +(Point2d * _Nonnull)phaseCorrelate:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 __attribute__((swift_name("phaseCorrelate(src1:src2:)")));
		[Static]
		[Export ("phaseCorrelate:src2:")]
		Point2d PhaseCorrelate (Mat src1, Mat src2);

		// +(void)createHanningWindow:(Mat * _Nonnull)dst winSize:(Size2i * _Nonnull)winSize type:(int)type __attribute__((swift_name("createHanningWindow(dst:winSize:type:)")));
		[Static]
		[Export ("createHanningWindow:winSize:type:")]
		void CreateHanningWindow (Mat dst, Size2i winSize, int type);

		// +(void)divSpectrums:(Mat * _Nonnull)a b:(Mat * _Nonnull)b c:(Mat * _Nonnull)c flags:(int)flags conjB:(BOOL)conjB __attribute__((swift_name("divSpectrums(a:b:c:flags:conjB:)")));
		[Static]
		[Export ("divSpectrums:b:c:flags:conjB:")]
		void DivSpectrums (Mat a, Mat b, Mat c, int flags, bool conjB);

		// +(void)divSpectrums:(Mat * _Nonnull)a b:(Mat * _Nonnull)b c:(Mat * _Nonnull)c flags:(int)flags __attribute__((swift_name("divSpectrums(a:b:c:flags:)")));
		[Static]
		[Export ("divSpectrums:b:c:flags:")]
		void DivSpectrums (Mat a, Mat b, Mat c, int flags);

		// +(double)threshold:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst thresh:(double)thresh maxval:(double)maxval type:(ThresholdTypes)type __attribute__((swift_name("threshold(src:dst:thresh:maxval:type:)")));
		[Static]
		[Export ("threshold:dst:thresh:maxval:type:")]
		double Threshold (Mat src, Mat dst, double thresh, double maxval, ThresholdTypes type);

		// +(double)thresholdWithMask:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask thresh:(double)thresh maxval:(double)maxval type:(int)type __attribute__((swift_name("thresholdWithMask(src:dst:mask:thresh:maxval:type:)")));
		[Static]
		[Export ("thresholdWithMask:dst:mask:thresh:maxval:type:")]
		double ThresholdWithMask (Mat src, Mat dst, Mat mask, double thresh, double maxval, int type);

		// +(void)adaptiveThreshold:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst maxValue:(double)maxValue adaptiveMethod:(AdaptiveThresholdTypes)adaptiveMethod thresholdType:(ThresholdTypes)thresholdType blockSize:(int)blockSize C:(double)C __attribute__((swift_name("adaptiveThreshold(src:dst:maxValue:adaptiveMethod:thresholdType:blockSize:C:)")));
		[Static]
		[Export ("adaptiveThreshold:dst:maxValue:adaptiveMethod:thresholdType:blockSize:C:")]
		void AdaptiveThreshold (Mat src, Mat dst, double maxValue, AdaptiveThresholdTypes adaptiveMethod, ThresholdTypes thresholdType, int blockSize, double C);

		// +(void)pyrDown:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst dstsize:(Size2i * _Nonnull)dstsize borderType:(BorderTypes)borderType __attribute__((swift_name("pyrDown(src:dst:dstsize:borderType:)")));
		[Static]
		[Export ("pyrDown:dst:dstsize:borderType:")]
		void PyrDown (Mat src, Mat dst, Size2i dstsize, BorderTypes borderType);

		// +(void)pyrDown:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst dstsize:(Size2i * _Nonnull)dstsize __attribute__((swift_name("pyrDown(src:dst:dstsize:)")));
		[Static]
		[Export ("pyrDown:dst:dstsize:")]
		void PyrDown (Mat src, Mat dst, Size2i dstsize);

		// +(void)pyrDown:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("pyrDown(src:dst:)")));
		[Static]
		[Export ("pyrDown:dst:")]
		void PyrDown (Mat src, Mat dst);

		// +(void)pyrUp:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst dstsize:(Size2i * _Nonnull)dstsize borderType:(BorderTypes)borderType __attribute__((swift_name("pyrUp(src:dst:dstsize:borderType:)")));
		[Static]
		[Export ("pyrUp:dst:dstsize:borderType:")]
		void PyrUp (Mat src, Mat dst, Size2i dstsize, BorderTypes borderType);

		// +(void)pyrUp:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst dstsize:(Size2i * _Nonnull)dstsize __attribute__((swift_name("pyrUp(src:dst:dstsize:)")));
		[Static]
		[Export ("pyrUp:dst:dstsize:")]
		void PyrUp (Mat src, Mat dst, Size2i dstsize);

		// +(void)pyrUp:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("pyrUp(src:dst:)")));
		[Static]
		[Export ("pyrUp:dst:")]
		void PyrUp (Mat src, Mat dst);

		// +(void)calcHist:(NSArray<Mat *> * _Nonnull)images channels:(IntVector * _Nonnull)channels mask:(Mat * _Nonnull)mask hist:(Mat * _Nonnull)hist histSize:(IntVector * _Nonnull)histSize ranges:(FloatVector * _Nonnull)ranges accumulate:(BOOL)accumulate __attribute__((swift_name("calcHist(images:channels:mask:hist:histSize:ranges:accumulate:)")));
		[Static]
		[Export ("calcHist:channels:mask:hist:histSize:ranges:accumulate:")]
		void CalcHist (Mat[] images, IntVector channels, Mat mask, Mat hist, IntVector histSize, FloatVector ranges, bool accumulate);

		// +(void)calcHist:(NSArray<Mat *> * _Nonnull)images channels:(IntVector * _Nonnull)channels mask:(Mat * _Nonnull)mask hist:(Mat * _Nonnull)hist histSize:(IntVector * _Nonnull)histSize ranges:(FloatVector * _Nonnull)ranges __attribute__((swift_name("calcHist(images:channels:mask:hist:histSize:ranges:)")));
		[Static]
		[Export ("calcHist:channels:mask:hist:histSize:ranges:")]
		void CalcHist (Mat[] images, IntVector channels, Mat mask, Mat hist, IntVector histSize, FloatVector ranges);

		// +(void)calcBackProject:(NSArray<Mat *> * _Nonnull)images channels:(IntVector * _Nonnull)channels hist:(Mat * _Nonnull)hist dst:(Mat * _Nonnull)dst ranges:(FloatVector * _Nonnull)ranges scale:(double)scale __attribute__((swift_name("calcBackProject(images:channels:hist:dst:ranges:scale:)")));
		[Static]
		[Export ("calcBackProject:channels:hist:dst:ranges:scale:")]
		void CalcBackProject (Mat[] images, IntVector channels, Mat hist, Mat dst, FloatVector ranges, double scale);

		// +(double)compareHist:(Mat * _Nonnull)H1 H2:(Mat * _Nonnull)H2 method:(HistCompMethods)method __attribute__((swift_name("compareHist(H1:H2:method:)")));
		[Static]
		[Export ("compareHist:H2:method:")]
		double CompareHist (Mat H1, Mat H2, HistCompMethods method);

		// +(void)equalizeHist:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("equalizeHist(src:dst:)")));
		[Static]
		[Export ("equalizeHist:dst:")]
		void EqualizeHist (Mat src, Mat dst);

		// +(CLAHE * _Nonnull)createCLAHE:(double)clipLimit tileGridSize:(Size2i * _Nonnull)tileGridSize __attribute__((swift_name("createCLAHE(clipLimit:tileGridSize:)")));
		[Static]
		[Export ("createCLAHE:tileGridSize:")]
		CLAHE CreateCLAHE (double clipLimit, Size2i tileGridSize);

		// +(CLAHE * _Nonnull)createCLAHE:(double)clipLimit __attribute__((swift_name("createCLAHE(clipLimit:)")));
		[Static]
		[Export ("createCLAHE:")]
		CLAHE CreateCLAHE (double clipLimit);

		// +(CLAHE * _Nonnull)createCLAHE __attribute__((swift_name("createCLAHE()")));
		[Static]
		[Export ("createCLAHE")]
		CLAHE CreateCLAHE ();

		// +(float)EMD:(Mat * _Nonnull)signature1 signature2:(Mat * _Nonnull)signature2 distType:(DistanceTypes)distType cost:(Mat * _Nonnull)cost flow:(Mat * _Nonnull)flow __attribute__((swift_name("wrapperEMD(signature1:signature2:distType:cost:flow:)")));
		[Static]
		[Export ("EMD:signature2:distType:cost:flow:")]
		float EMD (Mat signature1, Mat signature2, DistanceTypes distType, Mat cost, Mat flow);

		// +(float)EMD:(Mat * _Nonnull)signature1 signature2:(Mat * _Nonnull)signature2 distType:(DistanceTypes)distType cost:(Mat * _Nonnull)cost __attribute__((swift_name("wrapperEMD(signature1:signature2:distType:cost:)")));
		[Static]
		[Export ("EMD:signature2:distType:cost:")]
		float EMD (Mat signature1, Mat signature2, DistanceTypes distType, Mat cost);

		// +(float)EMD:(Mat * _Nonnull)signature1 signature2:(Mat * _Nonnull)signature2 distType:(DistanceTypes)distType __attribute__((swift_name("wrapperEMD(signature1:signature2:distType:)")));
		[Static]
		[Export ("EMD:signature2:distType:")]
		float EMD (Mat signature1, Mat signature2, DistanceTypes distType);

		// +(void)watershed:(Mat * _Nonnull)image markers:(Mat * _Nonnull)markers __attribute__((swift_name("watershed(image:markers:)")));
		[Static]
		[Export ("watershed:markers:")]
		void Watershed (Mat image, Mat markers);

		// +(void)pyrMeanShiftFiltering:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst sp:(double)sp sr:(double)sr maxLevel:(int)maxLevel termcrit:(TermCriteria * _Nonnull)termcrit __attribute__((swift_name("pyrMeanShiftFiltering(src:dst:sp:sr:maxLevel:termcrit:)")));
		[Static]
		[Export ("pyrMeanShiftFiltering:dst:sp:sr:maxLevel:termcrit:")]
		void PyrMeanShiftFiltering (Mat src, Mat dst, double sp, double sr, int maxLevel, TermCriteria termcrit);

		// +(void)pyrMeanShiftFiltering:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst sp:(double)sp sr:(double)sr maxLevel:(int)maxLevel __attribute__((swift_name("pyrMeanShiftFiltering(src:dst:sp:sr:maxLevel:)")));
		[Static]
		[Export ("pyrMeanShiftFiltering:dst:sp:sr:maxLevel:")]
		void PyrMeanShiftFiltering (Mat src, Mat dst, double sp, double sr, int maxLevel);

		// +(void)pyrMeanShiftFiltering:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst sp:(double)sp sr:(double)sr __attribute__((swift_name("pyrMeanShiftFiltering(src:dst:sp:sr:)")));
		[Static]
		[Export ("pyrMeanShiftFiltering:dst:sp:sr:")]
		void PyrMeanShiftFiltering (Mat src, Mat dst, double sp, double sr);

		// +(void)grabCut:(Mat * _Nonnull)img mask:(Mat * _Nonnull)mask rect:(Rect2i * _Nonnull)rect bgdModel:(Mat * _Nonnull)bgdModel fgdModel:(Mat * _Nonnull)fgdModel iterCount:(int)iterCount mode:(int)mode __attribute__((swift_name("grabCut(img:mask:rect:bgdModel:fgdModel:iterCount:mode:)")));
		[Static]
		[Export ("grabCut:mask:rect:bgdModel:fgdModel:iterCount:mode:")]
		void GrabCut (Mat img, Mat mask, Rect2i rect, Mat bgdModel, Mat fgdModel, int iterCount, int mode);

		// +(void)grabCut:(Mat * _Nonnull)img mask:(Mat * _Nonnull)mask rect:(Rect2i * _Nonnull)rect bgdModel:(Mat * _Nonnull)bgdModel fgdModel:(Mat * _Nonnull)fgdModel iterCount:(int)iterCount __attribute__((swift_name("grabCut(img:mask:rect:bgdModel:fgdModel:iterCount:)")));
		[Static]
		[Export ("grabCut:mask:rect:bgdModel:fgdModel:iterCount:")]
		void GrabCut (Mat img, Mat mask, Rect2i rect, Mat bgdModel, Mat fgdModel, int iterCount);

		// +(void)distanceTransformWithLabels:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst labels:(Mat * _Nonnull)labels distanceType:(DistanceTypes)distanceType maskSize:(DistanceTransformMasks)maskSize labelType:(DistanceTransformLabelTypes)labelType __attribute__((swift_name("distanceTransform(src:dst:labels:distanceType:maskSize:labelType:)")));
		[Static]
		[Export ("distanceTransformWithLabels:dst:labels:distanceType:maskSize:labelType:")]
		void DistanceTransformWithLabels (Mat src, Mat dst, Mat labels, DistanceTypes distanceType, DistanceTransformMasks maskSize, DistanceTransformLabelTypes labelType);

		// +(void)distanceTransformWithLabels:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst labels:(Mat * _Nonnull)labels distanceType:(DistanceTypes)distanceType maskSize:(DistanceTransformMasks)maskSize __attribute__((swift_name("distanceTransform(src:dst:labels:distanceType:maskSize:)")));
		[Static]
		[Export ("distanceTransformWithLabels:dst:labels:distanceType:maskSize:")]
		void DistanceTransformWithLabels (Mat src, Mat dst, Mat labels, DistanceTypes distanceType, DistanceTransformMasks maskSize);

		// +(void)distanceTransform:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst distanceType:(DistanceTypes)distanceType maskSize:(DistanceTransformMasks)maskSize dstType:(int)dstType __attribute__((swift_name("distanceTransform(src:dst:distanceType:maskSize:dstType:)")));
		[Static]
		[Export ("distanceTransform:dst:distanceType:maskSize:dstType:")]
		void DistanceTransform (Mat src, Mat dst, DistanceTypes distanceType, DistanceTransformMasks maskSize, int dstType);

		// +(void)distanceTransform:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst distanceType:(DistanceTypes)distanceType maskSize:(DistanceTransformMasks)maskSize __attribute__((swift_name("distanceTransform(src:dst:distanceType:maskSize:)")));
		[Static]
		[Export ("distanceTransform:dst:distanceType:maskSize:")]
		void DistanceTransform (Mat src, Mat dst, DistanceTypes distanceType, DistanceTransformMasks maskSize);

		// +(int)floodFill:(Mat * _Nonnull)image mask:(Mat * _Nonnull)mask seedPoint:(Point2i * _Nonnull)seedPoint newVal:(Scalar * _Nonnull)newVal rect:(Rect2i * _Nonnull)rect loDiff:(Scalar * _Nonnull)loDiff upDiff:(Scalar * _Nonnull)upDiff flags:(int)flags __attribute__((swift_name("floodFill(image:mask:seedPoint:newVal:rect:loDiff:upDiff:flags:)")));
		[Static]
		[Export ("floodFill:mask:seedPoint:newVal:rect:loDiff:upDiff:flags:")]
		int FloodFill (Mat image, Mat mask, Point2i seedPoint, Scalar newVal, Rect2i rect, Scalar loDiff, Scalar upDiff, int flags);

		// +(int)floodFill:(Mat * _Nonnull)image mask:(Mat * _Nonnull)mask seedPoint:(Point2i * _Nonnull)seedPoint newVal:(Scalar * _Nonnull)newVal rect:(Rect2i * _Nonnull)rect loDiff:(Scalar * _Nonnull)loDiff upDiff:(Scalar * _Nonnull)upDiff __attribute__((swift_name("floodFill(image:mask:seedPoint:newVal:rect:loDiff:upDiff:)")));
		[Static]
		[Export ("floodFill:mask:seedPoint:newVal:rect:loDiff:upDiff:")]
		int FloodFill (Mat image, Mat mask, Point2i seedPoint, Scalar newVal, Rect2i rect, Scalar loDiff, Scalar upDiff);

		// +(int)floodFill:(Mat * _Nonnull)image mask:(Mat * _Nonnull)mask seedPoint:(Point2i * _Nonnull)seedPoint newVal:(Scalar * _Nonnull)newVal rect:(Rect2i * _Nonnull)rect loDiff:(Scalar * _Nonnull)loDiff __attribute__((swift_name("floodFill(image:mask:seedPoint:newVal:rect:loDiff:)")));
		[Static]
		[Export ("floodFill:mask:seedPoint:newVal:rect:loDiff:")]
		int FloodFill (Mat image, Mat mask, Point2i seedPoint, Scalar newVal, Rect2i rect, Scalar loDiff);

		// +(int)floodFill:(Mat * _Nonnull)image mask:(Mat * _Nonnull)mask seedPoint:(Point2i * _Nonnull)seedPoint newVal:(Scalar * _Nonnull)newVal rect:(Rect2i * _Nonnull)rect __attribute__((swift_name("floodFill(image:mask:seedPoint:newVal:rect:)")));
		[Static]
		[Export ("floodFill:mask:seedPoint:newVal:rect:")]
		int FloodFill (Mat image, Mat mask, Point2i seedPoint, Scalar newVal, Rect2i rect);

		// +(int)floodFill:(Mat * _Nonnull)image mask:(Mat * _Nonnull)mask seedPoint:(Point2i * _Nonnull)seedPoint newVal:(Scalar * _Nonnull)newVal __attribute__((swift_name("floodFill(image:mask:seedPoint:newVal:)")));
		[Static]
		[Export ("floodFill:mask:seedPoint:newVal:")]
		int FloodFill (Mat image, Mat mask, Point2i seedPoint, Scalar newVal);

		// +(void)blendLinear:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 weights1:(Mat * _Nonnull)weights1 weights2:(Mat * _Nonnull)weights2 dst:(Mat * _Nonnull)dst __attribute__((swift_name("blendLinear(src1:src2:weights1:weights2:dst:)")));
		[Static]
		[Export ("blendLinear:src2:weights1:weights2:dst:")]
		void BlendLinear (Mat src1, Mat src2, Mat weights1, Mat weights2, Mat dst);

		// +(void)cvtColor:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst code:(ColorConversionCodes)code dstCn:(int)dstCn hint:(AlgorithmHint)hint __attribute__((swift_name("cvtColor(src:dst:code:dstCn:hint:)")));
		[Static]
		[Export ("cvtColor:dst:code:dstCn:hint:")]
		void CvtColor (Mat src, Mat dst, ColorConversionCodes code, int dstCn, AlgorithmHint hint);

		// +(void)cvtColor:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst code:(ColorConversionCodes)code dstCn:(int)dstCn __attribute__((swift_name("cvtColor(src:dst:code:dstCn:)")));
		[Static]
		[Export ("cvtColor:dst:code:dstCn:")]
		void CvtColor (Mat src, Mat dst, ColorConversionCodes code, int dstCn);

		// +(void)cvtColor:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst code:(ColorConversionCodes)code __attribute__((swift_name("cvtColor(src:dst:code:)")));
		[Static]
		[Export ("cvtColor:dst:code:")]
		void CvtColor (Mat src, Mat dst, ColorConversionCodes code);

		// +(void)cvtColorTwoPlane:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst code:(int)code hint:(AlgorithmHint)hint __attribute__((swift_name("cvtColorTwoPlane(src1:src2:dst:code:hint:)")));
		[Static]
		[Export ("cvtColorTwoPlane:src2:dst:code:hint:")]
		void CvtColorTwoPlane (Mat src1, Mat src2, Mat dst, int code, AlgorithmHint hint);

		// +(void)cvtColorTwoPlane:(Mat * _Nonnull)src1 src2:(Mat * _Nonnull)src2 dst:(Mat * _Nonnull)dst code:(int)code __attribute__((swift_name("cvtColorTwoPlane(src1:src2:dst:code:)")));
		[Static]
		[Export ("cvtColorTwoPlane:src2:dst:code:")]
		void CvtColorTwoPlane (Mat src1, Mat src2, Mat dst, int code);

		// +(void)demosaicing:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst code:(int)code dstCn:(int)dstCn __attribute__((swift_name("demosaicing(src:dst:code:dstCn:)")));
		[Static]
		[Export ("demosaicing:dst:code:dstCn:")]
		void Demosaicing (Mat src, Mat dst, int code, int dstCn);

		// +(void)demosaicing:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst code:(int)code __attribute__((swift_name("demosaicing(src:dst:code:)")));
		[Static]
		[Export ("demosaicing:dst:code:")]
		void Demosaicing (Mat src, Mat dst, int code);

		// +(Moments * _Nonnull)moments:(Mat * _Nonnull)array binaryImage:(BOOL)binaryImage __attribute__((swift_name("moments(array:binaryImage:)")));
		[Static]
		[Export ("moments:binaryImage:")]
		Moments Moments (Mat array, bool binaryImage);

		// +(Moments * _Nonnull)moments:(Mat * _Nonnull)array __attribute__((swift_name("moments(array:)")));
		[Static]
		[Export ("moments:")]
		Moments Moments (Mat array);

		// +(void)HuMoments:(Moments * _Nonnull)m hu:(Mat * _Nonnull)hu __attribute__((swift_name("HuMoments(m:hu:)")));
		[Static]
		[Export ("HuMoments:hu:")]
		void HuMoments (Moments m, Mat hu);

		// +(void)matchTemplate:(Mat * _Nonnull)image templ:(Mat * _Nonnull)templ result:(Mat * _Nonnull)result method:(TemplateMatchModes)method mask:(Mat * _Nonnull)mask __attribute__((swift_name("matchTemplate(image:templ:result:method:mask:)")));
		[Static]
		[Export ("matchTemplate:templ:result:method:mask:")]
		void MatchTemplate (Mat image, Mat templ, Mat result, TemplateMatchModes method, Mat mask);

		// +(void)matchTemplate:(Mat * _Nonnull)image templ:(Mat * _Nonnull)templ result:(Mat * _Nonnull)result method:(TemplateMatchModes)method __attribute__((swift_name("matchTemplate(image:templ:result:method:)")));
		[Static]
		[Export ("matchTemplate:templ:result:method:")]
		void MatchTemplate (Mat image, Mat templ, Mat result, TemplateMatchModes method);

		// +(int)connectedComponentsWithAlgorithm:(Mat * _Nonnull)image labels:(Mat * _Nonnull)labels connectivity:(int)connectivity ltype:(int)ltype ccltype:(int)ccltype __attribute__((swift_name("connectedComponents(image:labels:connectivity:ltype:ccltype:)")));
		[Static]
		[Export ("connectedComponentsWithAlgorithm:labels:connectivity:ltype:ccltype:")]
		int ConnectedComponentsWithAlgorithm (Mat image, Mat labels, int connectivity, int ltype, int ccltype);

		// +(int)connectedComponents:(Mat * _Nonnull)image labels:(Mat * _Nonnull)labels connectivity:(int)connectivity ltype:(int)ltype __attribute__((swift_name("connectedComponents(image:labels:connectivity:ltype:)")));
		[Static]
		[Export ("connectedComponents:labels:connectivity:ltype:")]
		int ConnectedComponents (Mat image, Mat labels, int connectivity, int ltype);

		// +(int)connectedComponents:(Mat * _Nonnull)image labels:(Mat * _Nonnull)labels connectivity:(int)connectivity __attribute__((swift_name("connectedComponents(image:labels:connectivity:)")));
		[Static]
		[Export ("connectedComponents:labels:connectivity:")]
		int ConnectedComponents (Mat image, Mat labels, int connectivity);

		// +(int)connectedComponents:(Mat * _Nonnull)image labels:(Mat * _Nonnull)labels __attribute__((swift_name("connectedComponents(image:labels:)")));
		[Static]
		[Export ("connectedComponents:labels:")]
		int ConnectedComponents (Mat image, Mat labels);

		// +(int)connectedComponentsWithStatsWithAlgorithm:(Mat * _Nonnull)image labels:(Mat * _Nonnull)labels stats:(Mat * _Nonnull)stats centroids:(Mat * _Nonnull)centroids connectivity:(int)connectivity ltype:(int)ltype ccltype:(ConnectedComponentsAlgorithmsTypes)ccltype __attribute__((swift_name("connectedComponentsWithStats(image:labels:stats:centroids:connectivity:ltype:ccltype:)")));
		[Static]
		[Export ("connectedComponentsWithStatsWithAlgorithm:labels:stats:centroids:connectivity:ltype:ccltype:")]
		int ConnectedComponentsWithStatsWithAlgorithm (Mat image, Mat labels, Mat stats, Mat centroids, int connectivity, int ltype, ConnectedComponentsAlgorithmsTypes ccltype);

		// +(int)connectedComponentsWithStats:(Mat * _Nonnull)image labels:(Mat * _Nonnull)labels stats:(Mat * _Nonnull)stats centroids:(Mat * _Nonnull)centroids connectivity:(int)connectivity ltype:(int)ltype __attribute__((swift_name("connectedComponentsWithStats(image:labels:stats:centroids:connectivity:ltype:)")));
		[Static]
		[Export ("connectedComponentsWithStats:labels:stats:centroids:connectivity:ltype:")]
		int ConnectedComponentsWithStats (Mat image, Mat labels, Mat stats, Mat centroids, int connectivity, int ltype);

		// +(int)connectedComponentsWithStats:(Mat * _Nonnull)image labels:(Mat * _Nonnull)labels stats:(Mat * _Nonnull)stats centroids:(Mat * _Nonnull)centroids connectivity:(int)connectivity __attribute__((swift_name("connectedComponentsWithStats(image:labels:stats:centroids:connectivity:)")));
		[Static]
		[Export ("connectedComponentsWithStats:labels:stats:centroids:connectivity:")]
		int ConnectedComponentsWithStats (Mat image, Mat labels, Mat stats, Mat centroids, int connectivity);

		// +(int)connectedComponentsWithStats:(Mat * _Nonnull)image labels:(Mat * _Nonnull)labels stats:(Mat * _Nonnull)stats centroids:(Mat * _Nonnull)centroids __attribute__((swift_name("connectedComponentsWithStats(image:labels:stats:centroids:)")));
		[Static]
		[Export ("connectedComponentsWithStats:labels:stats:centroids:")]
		int ConnectedComponentsWithStats (Mat image, Mat labels, Mat stats, Mat centroids);

		// +(void)findContours:(Mat * _Nonnull)image contours:(NSMutableArray<NSMutableArray<Point2i *> *> * _Nonnull)contours hierarchy:(Mat * _Nonnull)hierarchy mode:(RetrievalModes)mode method:(ContourApproximationModes)method offset:(Point2i * _Nonnull)offset __attribute__((swift_name("findContours(image:contours:hierarchy:mode:method:offset:)")));
		[Static]
		[Export ("findContours:contours:hierarchy:mode:method:offset:")]
		void FindContours (Mat image, NSMutableArray<NSMutableArray<Point2i>> contours, Mat hierarchy, RetrievalModes mode, ContourApproximationModes method, Point2i offset);

		// +(void)findContours:(Mat * _Nonnull)image contours:(NSMutableArray<NSMutableArray<Point2i *> *> * _Nonnull)contours hierarchy:(Mat * _Nonnull)hierarchy mode:(RetrievalModes)mode method:(ContourApproximationModes)method __attribute__((swift_name("findContours(image:contours:hierarchy:mode:method:)")));
		[Static]
		[Export ("findContours:contours:hierarchy:mode:method:")]
		void FindContours (Mat image, NSMutableArray<NSMutableArray<Point2i>> contours, Mat hierarchy, RetrievalModes mode, ContourApproximationModes method);

		// +(void)findContoursLinkRuns:(Mat * _Nonnull)image contours:(NSMutableArray<Mat *> * _Nonnull)contours hierarchy:(Mat * _Nonnull)hierarchy __attribute__((swift_name("findContoursLinkRuns(image:contours:hierarchy:)")));
		[Static]
		[Export ("findContoursLinkRuns:contours:hierarchy:")]
		void FindContoursLinkRuns (Mat image, NSMutableArray<Mat> contours, Mat hierarchy);

		// +(void)findContoursLinkRuns:(Mat * _Nonnull)image contours:(NSMutableArray<Mat *> * _Nonnull)contours __attribute__((swift_name("findContoursLinkRuns(image:contours:)")));
		[Static]
		[Export ("findContoursLinkRuns:contours:")]
		void FindContoursLinkRuns (Mat image, NSMutableArray<Mat> contours);

		// +(void)approxPolyDP:(NSArray<Point2f *> * _Nonnull)curve approxCurve:(NSMutableArray<Point2f *> * _Nonnull)approxCurve epsilon:(double)epsilon closed:(BOOL)closed __attribute__((swift_name("approxPolyDP(curve:approxCurve:epsilon:closed:)")));
		[Static]
		[Export ("approxPolyDP:approxCurve:epsilon:closed:")]
		void ApproxPolyDP (Point2f[] curve, NSMutableArray<Point2f> approxCurve, double epsilon, bool closed);

		// +(void)approxPolyN:(Mat * _Nonnull)curve approxCurve:(Mat * _Nonnull)approxCurve nsides:(int)nsides epsilon_percentage:(float)epsilon_percentage ensure_convex:(BOOL)ensure_convex __attribute__((swift_name("approxPolyN(curve:approxCurve:nsides:epsilon_percentage:ensure_convex:)")));
		[Static]
		[Export ("approxPolyN:approxCurve:nsides:epsilon_percentage:ensure_convex:")]
		void ApproxPolyN (Mat curve, Mat approxCurve, int nsides, float epsilon_percentage, bool ensure_convex);

		// +(void)approxPolyN:(Mat * _Nonnull)curve approxCurve:(Mat * _Nonnull)approxCurve nsides:(int)nsides epsilon_percentage:(float)epsilon_percentage __attribute__((swift_name("approxPolyN(curve:approxCurve:nsides:epsilon_percentage:)")));
		[Static]
		[Export ("approxPolyN:approxCurve:nsides:epsilon_percentage:")]
		void ApproxPolyN (Mat curve, Mat approxCurve, int nsides, float epsilon_percentage);

		// +(void)approxPolyN:(Mat * _Nonnull)curve approxCurve:(Mat * _Nonnull)approxCurve nsides:(int)nsides __attribute__((swift_name("approxPolyN(curve:approxCurve:nsides:)")));
		[Static]
		[Export ("approxPolyN:approxCurve:nsides:")]
		void ApproxPolyN (Mat curve, Mat approxCurve, int nsides);

		// +(double)arcLength:(NSArray<Point2f *> * _Nonnull)curve closed:(BOOL)closed __attribute__((swift_name("arcLength(curve:closed:)")));
		[Static]
		[Export ("arcLength:closed:")]
		double ArcLength (Point2f[] curve, bool closed);

		// +(Rect2i * _Nonnull)boundingRect:(Mat * _Nonnull)array __attribute__((swift_name("boundingRect(array:)")));
		[Static]
		[Export ("boundingRect:")]
		Rect2i BoundingRect (Mat array);

		// +(double)contourArea:(Mat * _Nonnull)contour oriented:(BOOL)oriented __attribute__((swift_name("contourArea(contour:oriented:)")));
		[Static]
		[Export ("contourArea:oriented:")]
		double ContourArea (Mat contour, bool oriented);

		// +(double)contourArea:(Mat * _Nonnull)contour __attribute__((swift_name("contourArea(contour:)")));
		[Static]
		[Export ("contourArea:")]
		double ContourArea (Mat contour);

		// +(RotatedRect * _Nonnull)minAreaRect:(NSArray<Point2f *> * _Nonnull)points __attribute__((swift_name("minAreaRect(points:)")));
		[Static]
		[Export ("minAreaRect:")]
		RotatedRect MinAreaRect (Point2f[] points);

		// +(void)boxPoints:(RotatedRect * _Nonnull)box points:(Mat * _Nonnull)points __attribute__((swift_name("boxPoints(box:points:)")));
		[Static]
		[Export ("boxPoints:points:")]
		void BoxPoints (RotatedRect box, Mat points);

		// +(void)minEnclosingCircle:(NSArray<Point2f *> * _Nonnull)points center:(Point2f * _Nonnull)center radius:(float * _Nonnull)radius __attribute__((swift_name("minEnclosingCircle(points:center:radius:)")));
		[Static]
		[Export ("minEnclosingCircle:center:radius:")]
		unsafe void MinEnclosingCircle (Point2f[] points, Point2f center, float* radius);

		// +(double)minEnclosingTriangle:(Mat * _Nonnull)points triangle:(Mat * _Nonnull)triangle __attribute__((swift_name("minEnclosingTriangle(points:triangle:)")));
		[Static]
		[Export ("minEnclosingTriangle:triangle:")]
		double MinEnclosingTriangle (Mat points, Mat triangle);

		// +(double)matchShapes:(Mat * _Nonnull)contour1 contour2:(Mat * _Nonnull)contour2 method:(ShapeMatchModes)method parameter:(double)parameter __attribute__((swift_name("matchShapes(contour1:contour2:method:parameter:)")));
		[Static]
		[Export ("matchShapes:contour2:method:parameter:")]
		double MatchShapes (Mat contour1, Mat contour2, ShapeMatchModes method, double parameter);

		// +(void)convexHull:(NSArray<Point2i *> * _Nonnull)points hull:(IntVector * _Nonnull)hull clockwise:(BOOL)clockwise __attribute__((swift_name("convexHull(points:hull:clockwise:)")));
		[Static]
		[Export ("convexHull:hull:clockwise:")]
		void ConvexHull (Point2i[] points, IntVector hull, bool clockwise);

		// +(void)convexHull:(NSArray<Point2i *> * _Nonnull)points hull:(IntVector * _Nonnull)hull __attribute__((swift_name("convexHull(points:hull:)")));
		[Static]
		[Export ("convexHull:hull:")]
		void ConvexHull (Point2i[] points, IntVector hull);

		// +(void)convexityDefects:(NSArray<Point2i *> * _Nonnull)contour convexhull:(IntVector * _Nonnull)convexhull convexityDefects:(NSMutableArray<Int4 *> * _Nonnull)convexityDefects __attribute__((swift_name("convexityDefects(contour:convexhull:convexityDefects:)")));
		[Static]
		[Export ("convexityDefects:convexhull:convexityDefects:")]
		void ConvexityDefects (Point2i[] contour, IntVector convexhull, NSMutableArray<Int4> convexityDefects);

		// +(BOOL)isContourConvex:(NSArray<Point2i *> * _Nonnull)contour __attribute__((swift_name("isContourConvex(contour:)")));
		[Static]
		[Export ("isContourConvex:")]
		bool IsContourConvex (Point2i[] contour);

		// +(float)intersectConvexConvex:(Mat * _Nonnull)p1 p2:(Mat * _Nonnull)p2 p12:(Mat * _Nonnull)p12 handleNested:(BOOL)handleNested __attribute__((swift_name("intersectConvexConvex(p1:p2:p12:handleNested:)")));
		[Static]
		[Export ("intersectConvexConvex:p2:p12:handleNested:")]
		float IntersectConvexConvex (Mat p1, Mat p2, Mat p12, bool handleNested);

		// +(float)intersectConvexConvex:(Mat * _Nonnull)p1 p2:(Mat * _Nonnull)p2 p12:(Mat * _Nonnull)p12 __attribute__((swift_name("intersectConvexConvex(p1:p2:p12:)")));
		[Static]
		[Export ("intersectConvexConvex:p2:p12:")]
		float IntersectConvexConvex (Mat p1, Mat p2, Mat p12);

		// +(RotatedRect * _Nonnull)fitEllipse:(NSArray<Point2f *> * _Nonnull)points __attribute__((swift_name("fitEllipse(points:)")));
		[Static]
		[Export ("fitEllipse:")]
		RotatedRect FitEllipse (Point2f[] points);

		// +(RotatedRect * _Nonnull)fitEllipseAMS:(Mat * _Nonnull)points __attribute__((swift_name("fitEllipseAMS(points:)")));
		[Static]
		[Export ("fitEllipseAMS:")]
		RotatedRect FitEllipseAMS (Mat points);

		// +(RotatedRect * _Nonnull)fitEllipseDirect:(Mat * _Nonnull)points __attribute__((swift_name("fitEllipseDirect(points:)")));
		[Static]
		[Export ("fitEllipseDirect:")]
		RotatedRect FitEllipseDirect (Mat points);

		// +(void)getClosestEllipsePoints:(RotatedRect * _Nonnull)ellipse_params points:(Mat * _Nonnull)points closest_pts:(Mat * _Nonnull)closest_pts __attribute__((swift_name("getClosestEllipsePoints(ellipse_params:points:closest_pts:)")));
		[Static]
		[Export ("getClosestEllipsePoints:points:closest_pts:")]
		void GetClosestEllipsePoints (RotatedRect ellipse_params, Mat points, Mat closest_pts);

		// +(void)fitLine:(Mat * _Nonnull)points line:(Mat * _Nonnull)line distType:(DistanceTypes)distType param:(double)param reps:(double)reps aeps:(double)aeps __attribute__((swift_name("fitLine(points:line:distType:param:reps:aeps:)")));
		[Static]
		[Export ("fitLine:line:distType:param:reps:aeps:")]
		void FitLine (Mat points, Mat line, DistanceTypes distType, double param, double reps, double aeps);

		// +(double)pointPolygonTest:(NSArray<Point2f *> * _Nonnull)contour pt:(Point2f * _Nonnull)pt measureDist:(BOOL)measureDist __attribute__((swift_name("pointPolygonTest(contour:pt:measureDist:)")));
		[Static]
		[Export ("pointPolygonTest:pt:measureDist:")]
		double PointPolygonTest (Point2f[] contour, Point2f pt, bool measureDist);

		// +(int)rotatedRectangleIntersection:(RotatedRect * _Nonnull)rect1 rect2:(RotatedRect * _Nonnull)rect2 intersectingRegion:(Mat * _Nonnull)intersectingRegion __attribute__((swift_name("rotatedRectangleIntersection(rect1:rect2:intersectingRegion:)")));
		[Static]
		[Export ("rotatedRectangleIntersection:rect2:intersectingRegion:")]
		int RotatedRectangleIntersection (RotatedRect rect1, RotatedRect rect2, Mat intersectingRegion);

		// +(GeneralizedHoughBallard * _Nonnull)createGeneralizedHoughBallard __attribute__((swift_name("createGeneralizedHoughBallard()")));
		[Static]
		[Export ("createGeneralizedHoughBallard")]
		GeneralizedHoughBallard CreateGeneralizedHoughBallard ();

		// +(GeneralizedHoughGuil * _Nonnull)createGeneralizedHoughGuil __attribute__((swift_name("createGeneralizedHoughGuil()")));
		[Static]
		[Export ("createGeneralizedHoughGuil")]
		GeneralizedHoughGuil CreateGeneralizedHoughGuil ();

		// +(void)applyColorMap:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst colormap:(ColormapTypes)colormap __attribute__((swift_name("applyColorMap(src:dst:colormap:)")));
		[Static]
		[Export ("applyColorMap:dst:colormap:")]
		void ApplyColorMap (Mat src, Mat dst, ColormapTypes colormap);

		// +(void)applyColorMap:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst userColor:(Mat * _Nonnull)userColor __attribute__((swift_name("applyColorMap(src:dst:userColor:)")));
		[Static]
		[Export ("applyColorMap:dst:userColor:")]
		void ApplyColorMap (Mat src, Mat dst, Mat userColor);

		// +(void)line:(Mat * _Nonnull)img pt1:(Point2i * _Nonnull)pt1 pt2:(Point2i * _Nonnull)pt2 color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType shift:(int)shift __attribute__((swift_name("line(img:pt1:pt2:color:thickness:lineType:shift:)")));
		[Static]
		[Export ("line:pt1:pt2:color:thickness:lineType:shift:")]
		void Line (Mat img, Point2i pt1, Point2i pt2, Scalar color, int thickness, LineTypes lineType, int shift);

		// +(void)line:(Mat * _Nonnull)img pt1:(Point2i * _Nonnull)pt1 pt2:(Point2i * _Nonnull)pt2 color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType __attribute__((swift_name("line(img:pt1:pt2:color:thickness:lineType:)")));
		[Static]
		[Export ("line:pt1:pt2:color:thickness:lineType:")]
		void Line (Mat img, Point2i pt1, Point2i pt2, Scalar color, int thickness, LineTypes lineType);

		// +(void)line:(Mat * _Nonnull)img pt1:(Point2i * _Nonnull)pt1 pt2:(Point2i * _Nonnull)pt2 color:(Scalar * _Nonnull)color thickness:(int)thickness __attribute__((swift_name("line(img:pt1:pt2:color:thickness:)")));
		[Static]
		[Export ("line:pt1:pt2:color:thickness:")]
		void Line (Mat img, Point2i pt1, Point2i pt2, Scalar color, int thickness);

		// +(void)line:(Mat * _Nonnull)img pt1:(Point2i * _Nonnull)pt1 pt2:(Point2i * _Nonnull)pt2 color:(Scalar * _Nonnull)color __attribute__((swift_name("line(img:pt1:pt2:color:)")));
		[Static]
		[Export ("line:pt1:pt2:color:")]
		void Line (Mat img, Point2i pt1, Point2i pt2, Scalar color);

		// +(void)arrowedLine:(Mat * _Nonnull)img pt1:(Point2i * _Nonnull)pt1 pt2:(Point2i * _Nonnull)pt2 color:(Scalar * _Nonnull)color thickness:(int)thickness line_type:(LineTypes)line_type shift:(int)shift tipLength:(double)tipLength __attribute__((swift_name("arrowedLine(img:pt1:pt2:color:thickness:line_type:shift:tipLength:)")));
		[Static]
		[Export ("arrowedLine:pt1:pt2:color:thickness:line_type:shift:tipLength:")]
		void ArrowedLine (Mat img, Point2i pt1, Point2i pt2, Scalar color, int thickness, LineTypes line_type, int shift, double tipLength);

		// +(void)arrowedLine:(Mat * _Nonnull)img pt1:(Point2i * _Nonnull)pt1 pt2:(Point2i * _Nonnull)pt2 color:(Scalar * _Nonnull)color thickness:(int)thickness line_type:(LineTypes)line_type shift:(int)shift __attribute__((swift_name("arrowedLine(img:pt1:pt2:color:thickness:line_type:shift:)")));
		[Static]
		[Export ("arrowedLine:pt1:pt2:color:thickness:line_type:shift:")]
		void ArrowedLine (Mat img, Point2i pt1, Point2i pt2, Scalar color, int thickness, LineTypes line_type, int shift);

		// +(void)arrowedLine:(Mat * _Nonnull)img pt1:(Point2i * _Nonnull)pt1 pt2:(Point2i * _Nonnull)pt2 color:(Scalar * _Nonnull)color thickness:(int)thickness line_type:(LineTypes)line_type __attribute__((swift_name("arrowedLine(img:pt1:pt2:color:thickness:line_type:)")));
		[Static]
		[Export ("arrowedLine:pt1:pt2:color:thickness:line_type:")]
		void ArrowedLine (Mat img, Point2i pt1, Point2i pt2, Scalar color, int thickness, LineTypes line_type);

		// +(void)arrowedLine:(Mat * _Nonnull)img pt1:(Point2i * _Nonnull)pt1 pt2:(Point2i * _Nonnull)pt2 color:(Scalar * _Nonnull)color thickness:(int)thickness __attribute__((swift_name("arrowedLine(img:pt1:pt2:color:thickness:)")));
		[Static]
		[Export ("arrowedLine:pt1:pt2:color:thickness:")]
		void ArrowedLine (Mat img, Point2i pt1, Point2i pt2, Scalar color, int thickness);

		// +(void)arrowedLine:(Mat * _Nonnull)img pt1:(Point2i * _Nonnull)pt1 pt2:(Point2i * _Nonnull)pt2 color:(Scalar * _Nonnull)color __attribute__((swift_name("arrowedLine(img:pt1:pt2:color:)")));
		[Static]
		[Export ("arrowedLine:pt1:pt2:color:")]
		void ArrowedLine (Mat img, Point2i pt1, Point2i pt2, Scalar color);

		// +(void)rectangle:(Mat * _Nonnull)img pt1:(Point2i * _Nonnull)pt1 pt2:(Point2i * _Nonnull)pt2 color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType shift:(int)shift __attribute__((swift_name("rectangle(img:pt1:pt2:color:thickness:lineType:shift:)")));
		[Static]
		[Export ("rectangle:pt1:pt2:color:thickness:lineType:shift:")]
		void Rectangle (Mat img, Point2i pt1, Point2i pt2, Scalar color, int thickness, LineTypes lineType, int shift);

		// +(void)rectangle:(Mat * _Nonnull)img pt1:(Point2i * _Nonnull)pt1 pt2:(Point2i * _Nonnull)pt2 color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType __attribute__((swift_name("rectangle(img:pt1:pt2:color:thickness:lineType:)")));
		[Static]
		[Export ("rectangle:pt1:pt2:color:thickness:lineType:")]
		void Rectangle (Mat img, Point2i pt1, Point2i pt2, Scalar color, int thickness, LineTypes lineType);

		// +(void)rectangle:(Mat * _Nonnull)img pt1:(Point2i * _Nonnull)pt1 pt2:(Point2i * _Nonnull)pt2 color:(Scalar * _Nonnull)color thickness:(int)thickness __attribute__((swift_name("rectangle(img:pt1:pt2:color:thickness:)")));
		[Static]
		[Export ("rectangle:pt1:pt2:color:thickness:")]
		void Rectangle (Mat img, Point2i pt1, Point2i pt2, Scalar color, int thickness);

		// +(void)rectangle:(Mat * _Nonnull)img pt1:(Point2i * _Nonnull)pt1 pt2:(Point2i * _Nonnull)pt2 color:(Scalar * _Nonnull)color __attribute__((swift_name("rectangle(img:pt1:pt2:color:)")));
		[Static]
		[Export ("rectangle:pt1:pt2:color:")]
		void Rectangle (Mat img, Point2i pt1, Point2i pt2, Scalar color);

		// +(void)rectangle:(Mat * _Nonnull)img rec:(Rect2i * _Nonnull)rec color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType shift:(int)shift __attribute__((swift_name("rectangle(img:rec:color:thickness:lineType:shift:)")));
		[Static]
		[Export ("rectangle:rec:color:thickness:lineType:shift:")]
		void Rectangle (Mat img, Rect2i rec, Scalar color, int thickness, LineTypes lineType, int shift);

		// +(void)rectangle:(Mat * _Nonnull)img rec:(Rect2i * _Nonnull)rec color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType __attribute__((swift_name("rectangle(img:rec:color:thickness:lineType:)")));
		[Static]
		[Export ("rectangle:rec:color:thickness:lineType:")]
		void Rectangle (Mat img, Rect2i rec, Scalar color, int thickness, LineTypes lineType);

		// +(void)rectangle:(Mat * _Nonnull)img rec:(Rect2i * _Nonnull)rec color:(Scalar * _Nonnull)color thickness:(int)thickness __attribute__((swift_name("rectangle(img:rec:color:thickness:)")));
		[Static]
		[Export ("rectangle:rec:color:thickness:")]
		void Rectangle (Mat img, Rect2i rec, Scalar color, int thickness);

		// +(void)rectangle:(Mat * _Nonnull)img rec:(Rect2i * _Nonnull)rec color:(Scalar * _Nonnull)color __attribute__((swift_name("rectangle(img:rec:color:)")));
		[Static]
		[Export ("rectangle:rec:color:")]
		void Rectangle (Mat img, Rect2i rec, Scalar color);

		// +(void)circle:(Mat * _Nonnull)img center:(Point2i * _Nonnull)center radius:(int)radius color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType shift:(int)shift __attribute__((swift_name("circle(img:center:radius:color:thickness:lineType:shift:)")));
		[Static]
		[Export ("circle:center:radius:color:thickness:lineType:shift:")]
		void Circle (Mat img, Point2i center, int radius, Scalar color, int thickness, LineTypes lineType, int shift);

		// +(void)circle:(Mat * _Nonnull)img center:(Point2i * _Nonnull)center radius:(int)radius color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType __attribute__((swift_name("circle(img:center:radius:color:thickness:lineType:)")));
		[Static]
		[Export ("circle:center:radius:color:thickness:lineType:")]
		void Circle (Mat img, Point2i center, int radius, Scalar color, int thickness, LineTypes lineType);

		// +(void)circle:(Mat * _Nonnull)img center:(Point2i * _Nonnull)center radius:(int)radius color:(Scalar * _Nonnull)color thickness:(int)thickness __attribute__((swift_name("circle(img:center:radius:color:thickness:)")));
		[Static]
		[Export ("circle:center:radius:color:thickness:")]
		void Circle (Mat img, Point2i center, int radius, Scalar color, int thickness);

		// +(void)circle:(Mat * _Nonnull)img center:(Point2i * _Nonnull)center radius:(int)radius color:(Scalar * _Nonnull)color __attribute__((swift_name("circle(img:center:radius:color:)")));
		[Static]
		[Export ("circle:center:radius:color:")]
		void Circle (Mat img, Point2i center, int radius, Scalar color);

		// +(void)ellipse:(Mat * _Nonnull)img center:(Point2i * _Nonnull)center axes:(Size2i * _Nonnull)axes angle:(double)angle startAngle:(double)startAngle endAngle:(double)endAngle color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType shift:(int)shift __attribute__((swift_name("ellipse(img:center:axes:angle:startAngle:endAngle:color:thickness:lineType:shift:)")));
		[Static]
		[Export ("ellipse:center:axes:angle:startAngle:endAngle:color:thickness:lineType:shift:")]
		void Ellipse (Mat img, Point2i center, Size2i axes, double angle, double startAngle, double endAngle, Scalar color, int thickness, LineTypes lineType, int shift);

		// +(void)ellipse:(Mat * _Nonnull)img center:(Point2i * _Nonnull)center axes:(Size2i * _Nonnull)axes angle:(double)angle startAngle:(double)startAngle endAngle:(double)endAngle color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType __attribute__((swift_name("ellipse(img:center:axes:angle:startAngle:endAngle:color:thickness:lineType:)")));
		[Static]
		[Export ("ellipse:center:axes:angle:startAngle:endAngle:color:thickness:lineType:")]
		void Ellipse (Mat img, Point2i center, Size2i axes, double angle, double startAngle, double endAngle, Scalar color, int thickness, LineTypes lineType);

		// +(void)ellipse:(Mat * _Nonnull)img center:(Point2i * _Nonnull)center axes:(Size2i * _Nonnull)axes angle:(double)angle startAngle:(double)startAngle endAngle:(double)endAngle color:(Scalar * _Nonnull)color thickness:(int)thickness __attribute__((swift_name("ellipse(img:center:axes:angle:startAngle:endAngle:color:thickness:)")));
		[Static]
		[Export ("ellipse:center:axes:angle:startAngle:endAngle:color:thickness:")]
		void Ellipse (Mat img, Point2i center, Size2i axes, double angle, double startAngle, double endAngle, Scalar color, int thickness);

		// +(void)ellipse:(Mat * _Nonnull)img center:(Point2i * _Nonnull)center axes:(Size2i * _Nonnull)axes angle:(double)angle startAngle:(double)startAngle endAngle:(double)endAngle color:(Scalar * _Nonnull)color __attribute__((swift_name("ellipse(img:center:axes:angle:startAngle:endAngle:color:)")));
		[Static]
		[Export ("ellipse:center:axes:angle:startAngle:endAngle:color:")]
		void Ellipse (Mat img, Point2i center, Size2i axes, double angle, double startAngle, double endAngle, Scalar color);

		// +(void)ellipse:(Mat * _Nonnull)img box:(RotatedRect * _Nonnull)box color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType __attribute__((swift_name("ellipse(img:box:color:thickness:lineType:)")));
		[Static]
		[Export ("ellipse:box:color:thickness:lineType:")]
		void Ellipse (Mat img, RotatedRect box, Scalar color, int thickness, LineTypes lineType);

		// +(void)ellipse:(Mat * _Nonnull)img box:(RotatedRect * _Nonnull)box color:(Scalar * _Nonnull)color thickness:(int)thickness __attribute__((swift_name("ellipse(img:box:color:thickness:)")));
		[Static]
		[Export ("ellipse:box:color:thickness:")]
		void Ellipse (Mat img, RotatedRect box, Scalar color, int thickness);

		// +(void)ellipse:(Mat * _Nonnull)img box:(RotatedRect * _Nonnull)box color:(Scalar * _Nonnull)color __attribute__((swift_name("ellipse(img:box:color:)")));
		[Static]
		[Export ("ellipse:box:color:")]
		void Ellipse (Mat img, RotatedRect box, Scalar color);

		// +(void)drawMarker:(Mat * _Nonnull)img position:(Point2i * _Nonnull)position color:(Scalar * _Nonnull)color markerType:(MarkerTypes)markerType markerSize:(int)markerSize thickness:(int)thickness line_type:(LineTypes)line_type __attribute__((swift_name("drawMarker(img:position:color:markerType:markerSize:thickness:line_type:)")));
		[Static]
		[Export ("drawMarker:position:color:markerType:markerSize:thickness:line_type:")]
		void DrawMarker (Mat img, Point2i position, Scalar color, MarkerTypes markerType, int markerSize, int thickness, LineTypes line_type);

		// +(void)drawMarker:(Mat * _Nonnull)img position:(Point2i * _Nonnull)position color:(Scalar * _Nonnull)color markerType:(MarkerTypes)markerType markerSize:(int)markerSize thickness:(int)thickness __attribute__((swift_name("drawMarker(img:position:color:markerType:markerSize:thickness:)")));
		[Static]
		[Export ("drawMarker:position:color:markerType:markerSize:thickness:")]
		void DrawMarker (Mat img, Point2i position, Scalar color, MarkerTypes markerType, int markerSize, int thickness);

		// +(void)drawMarker:(Mat * _Nonnull)img position:(Point2i * _Nonnull)position color:(Scalar * _Nonnull)color markerType:(MarkerTypes)markerType markerSize:(int)markerSize __attribute__((swift_name("drawMarker(img:position:color:markerType:markerSize:)")));
		[Static]
		[Export ("drawMarker:position:color:markerType:markerSize:")]
		void DrawMarker (Mat img, Point2i position, Scalar color, MarkerTypes markerType, int markerSize);

		// +(void)drawMarker:(Mat * _Nonnull)img position:(Point2i * _Nonnull)position color:(Scalar * _Nonnull)color markerType:(MarkerTypes)markerType __attribute__((swift_name("drawMarker(img:position:color:markerType:)")));
		[Static]
		[Export ("drawMarker:position:color:markerType:")]
		void DrawMarker (Mat img, Point2i position, Scalar color, MarkerTypes markerType);

		// +(void)drawMarker:(Mat * _Nonnull)img position:(Point2i * _Nonnull)position color:(Scalar * _Nonnull)color __attribute__((swift_name("drawMarker(img:position:color:)")));
		[Static]
		[Export ("drawMarker:position:color:")]
		void DrawMarker (Mat img, Point2i position, Scalar color);

		// +(void)fillConvexPoly:(Mat * _Nonnull)img points:(NSArray<Point2i *> * _Nonnull)points color:(Scalar * _Nonnull)color lineType:(LineTypes)lineType shift:(int)shift __attribute__((swift_name("fillConvexPoly(img:points:color:lineType:shift:)")));
		[Static]
		[Export ("fillConvexPoly:points:color:lineType:shift:")]
		void FillConvexPoly (Mat img, Point2i[] points, Scalar color, LineTypes lineType, int shift);

		// +(void)fillConvexPoly:(Mat * _Nonnull)img points:(NSArray<Point2i *> * _Nonnull)points color:(Scalar * _Nonnull)color lineType:(LineTypes)lineType __attribute__((swift_name("fillConvexPoly(img:points:color:lineType:)")));
		[Static]
		[Export ("fillConvexPoly:points:color:lineType:")]
		void FillConvexPoly (Mat img, Point2i[] points, Scalar color, LineTypes lineType);

		// +(void)fillConvexPoly:(Mat * _Nonnull)img points:(NSArray<Point2i *> * _Nonnull)points color:(Scalar * _Nonnull)color __attribute__((swift_name("fillConvexPoly(img:points:color:)")));
		[Static]
		[Export ("fillConvexPoly:points:color:")]
		void FillConvexPoly (Mat img, Point2i[] points, Scalar color);

		// +(void)fillPoly:(Mat * _Nonnull)img pts:(NSArray<NSArray<Point2i *> *> * _Nonnull)pts color:(Scalar * _Nonnull)color lineType:(LineTypes)lineType shift:(int)shift offset:(Point2i * _Nonnull)offset __attribute__((swift_name("fillPoly(img:pts:color:lineType:shift:offset:)")));
		[Static]
		[Export ("fillPoly:pts:color:lineType:shift:offset:")]
		void FillPoly (Mat img, NSArray<Point2i>[] pts, Scalar color, LineTypes lineType, int shift, Point2i offset);

		// +(void)fillPoly:(Mat * _Nonnull)img pts:(NSArray<NSArray<Point2i *> *> * _Nonnull)pts color:(Scalar * _Nonnull)color lineType:(LineTypes)lineType shift:(int)shift __attribute__((swift_name("fillPoly(img:pts:color:lineType:shift:)")));
		[Static]
		[Export ("fillPoly:pts:color:lineType:shift:")]
		void FillPoly (Mat img, NSArray<Point2i>[] pts, Scalar color, LineTypes lineType, int shift);

		// +(void)fillPoly:(Mat * _Nonnull)img pts:(NSArray<NSArray<Point2i *> *> * _Nonnull)pts color:(Scalar * _Nonnull)color lineType:(LineTypes)lineType __attribute__((swift_name("fillPoly(img:pts:color:lineType:)")));
		[Static]
		[Export ("fillPoly:pts:color:lineType:")]
		void FillPoly (Mat img, NSArray<Point2i>[] pts, Scalar color, LineTypes lineType);

		// +(void)fillPoly:(Mat * _Nonnull)img pts:(NSArray<NSArray<Point2i *> *> * _Nonnull)pts color:(Scalar * _Nonnull)color __attribute__((swift_name("fillPoly(img:pts:color:)")));
		[Static]
		[Export ("fillPoly:pts:color:")]
		void FillPoly (Mat img, NSArray<Point2i>[] pts, Scalar color);

		// +(void)polylines:(Mat * _Nonnull)img pts:(NSArray<NSArray<Point2i *> *> * _Nonnull)pts isClosed:(BOOL)isClosed color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType shift:(int)shift __attribute__((swift_name("polylines(img:pts:isClosed:color:thickness:lineType:shift:)")));
		[Static]
		[Export ("polylines:pts:isClosed:color:thickness:lineType:shift:")]
		void Polylines (Mat img, NSArray<Point2i>[] pts, bool isClosed, Scalar color, int thickness, LineTypes lineType, int shift);

		// +(void)polylines:(Mat * _Nonnull)img pts:(NSArray<NSArray<Point2i *> *> * _Nonnull)pts isClosed:(BOOL)isClosed color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType __attribute__((swift_name("polylines(img:pts:isClosed:color:thickness:lineType:)")));
		[Static]
		[Export ("polylines:pts:isClosed:color:thickness:lineType:")]
		void Polylines (Mat img, NSArray<Point2i>[] pts, bool isClosed, Scalar color, int thickness, LineTypes lineType);

		// +(void)polylines:(Mat * _Nonnull)img pts:(NSArray<NSArray<Point2i *> *> * _Nonnull)pts isClosed:(BOOL)isClosed color:(Scalar * _Nonnull)color thickness:(int)thickness __attribute__((swift_name("polylines(img:pts:isClosed:color:thickness:)")));
		[Static]
		[Export ("polylines:pts:isClosed:color:thickness:")]
		void Polylines (Mat img, NSArray<Point2i>[] pts, bool isClosed, Scalar color, int thickness);

		// +(void)polylines:(Mat * _Nonnull)img pts:(NSArray<NSArray<Point2i *> *> * _Nonnull)pts isClosed:(BOOL)isClosed color:(Scalar * _Nonnull)color __attribute__((swift_name("polylines(img:pts:isClosed:color:)")));
		[Static]
		[Export ("polylines:pts:isClosed:color:")]
		void Polylines (Mat img, NSArray<Point2i>[] pts, bool isClosed, Scalar color);

		// +(void)drawContours:(Mat * _Nonnull)image contours:(NSArray<NSArray<Point2i *> *> * _Nonnull)contours contourIdx:(int)contourIdx color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType hierarchy:(Mat * _Nonnull)hierarchy maxLevel:(int)maxLevel offset:(Point2i * _Nonnull)offset __attribute__((swift_name("drawContours(image:contours:contourIdx:color:thickness:lineType:hierarchy:maxLevel:offset:)")));
		[Static]
		[Export ("drawContours:contours:contourIdx:color:thickness:lineType:hierarchy:maxLevel:offset:")]
		void DrawContours (Mat image, NSArray<Point2i>[] contours, int contourIdx, Scalar color, int thickness, LineTypes lineType, Mat hierarchy, int maxLevel, Point2i offset);

		// +(void)drawContours:(Mat * _Nonnull)image contours:(NSArray<NSArray<Point2i *> *> * _Nonnull)contours contourIdx:(int)contourIdx color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType hierarchy:(Mat * _Nonnull)hierarchy maxLevel:(int)maxLevel __attribute__((swift_name("drawContours(image:contours:contourIdx:color:thickness:lineType:hierarchy:maxLevel:)")));
		[Static]
		[Export ("drawContours:contours:contourIdx:color:thickness:lineType:hierarchy:maxLevel:")]
		void DrawContours (Mat image, NSArray<Point2i>[] contours, int contourIdx, Scalar color, int thickness, LineTypes lineType, Mat hierarchy, int maxLevel);

		// +(void)drawContours:(Mat * _Nonnull)image contours:(NSArray<NSArray<Point2i *> *> * _Nonnull)contours contourIdx:(int)contourIdx color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType hierarchy:(Mat * _Nonnull)hierarchy __attribute__((swift_name("drawContours(image:contours:contourIdx:color:thickness:lineType:hierarchy:)")));
		[Static]
		[Export ("drawContours:contours:contourIdx:color:thickness:lineType:hierarchy:")]
		void DrawContours (Mat image, NSArray<Point2i>[] contours, int contourIdx, Scalar color, int thickness, LineTypes lineType, Mat hierarchy);

		// +(void)drawContours:(Mat * _Nonnull)image contours:(NSArray<NSArray<Point2i *> *> * _Nonnull)contours contourIdx:(int)contourIdx color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType __attribute__((swift_name("drawContours(image:contours:contourIdx:color:thickness:lineType:)")));
		[Static]
		[Export ("drawContours:contours:contourIdx:color:thickness:lineType:")]
		void DrawContours (Mat image, NSArray<Point2i>[] contours, int contourIdx, Scalar color, int thickness, LineTypes lineType);

		// +(void)drawContours:(Mat * _Nonnull)image contours:(NSArray<NSArray<Point2i *> *> * _Nonnull)contours contourIdx:(int)contourIdx color:(Scalar * _Nonnull)color thickness:(int)thickness __attribute__((swift_name("drawContours(image:contours:contourIdx:color:thickness:)")));
		[Static]
		[Export ("drawContours:contours:contourIdx:color:thickness:")]
		void DrawContours (Mat image, NSArray<Point2i>[] contours, int contourIdx, Scalar color, int thickness);

		// +(void)drawContours:(Mat * _Nonnull)image contours:(NSArray<NSArray<Point2i *> *> * _Nonnull)contours contourIdx:(int)contourIdx color:(Scalar * _Nonnull)color __attribute__((swift_name("drawContours(image:contours:contourIdx:color:)")));
		[Static]
		[Export ("drawContours:contours:contourIdx:color:")]
		void DrawContours (Mat image, NSArray<Point2i>[] contours, int contourIdx, Scalar color);

		// +(BOOL)clipLine:(Rect2i * _Nonnull)imgRect pt1:(Point2i * _Nonnull)pt1 pt2:(Point2i * _Nonnull)pt2 __attribute__((swift_name("clipLine(imgRect:pt1:pt2:)")));
		[Static]
		[Export ("clipLine:pt1:pt2:")]
		bool ClipLine (Rect2i imgRect, Point2i pt1, Point2i pt2);

		// +(void)ellipse2Poly:(Point2i * _Nonnull)center axes:(Size2i * _Nonnull)axes angle:(int)angle arcStart:(int)arcStart arcEnd:(int)arcEnd delta:(int)delta pts:(NSMutableArray<Point2i *> * _Nonnull)pts __attribute__((swift_name("ellipse2Poly(center:axes:angle:arcStart:arcEnd:delta:pts:)")));
		[Static]
		[Export ("ellipse2Poly:axes:angle:arcStart:arcEnd:delta:pts:")]
		void Ellipse2Poly (Point2i center, Size2i axes, int angle, int arcStart, int arcEnd, int delta, NSMutableArray<Point2i> pts);

		// +(void)putText:(Mat * _Nonnull)img text:(NSString * _Nonnull)text org:(Point2i * _Nonnull)org fontFace:(HersheyFonts)fontFace fontScale:(double)fontScale color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType bottomLeftOrigin:(BOOL)bottomLeftOrigin __attribute__((swift_name("putText(img:text:org:fontFace:fontScale:color:thickness:lineType:bottomLeftOrigin:)")));
		[Static]
		[Export ("putText:text:org:fontFace:fontScale:color:thickness:lineType:bottomLeftOrigin:")]
		void PutText (Mat img, string text, Point2i org, HersheyFonts fontFace, double fontScale, Scalar color, int thickness, LineTypes lineType, bool bottomLeftOrigin);

		// +(void)putText:(Mat * _Nonnull)img text:(NSString * _Nonnull)text org:(Point2i * _Nonnull)org fontFace:(HersheyFonts)fontFace fontScale:(double)fontScale color:(Scalar * _Nonnull)color thickness:(int)thickness lineType:(LineTypes)lineType __attribute__((swift_name("putText(img:text:org:fontFace:fontScale:color:thickness:lineType:)")));
		[Static]
		[Export ("putText:text:org:fontFace:fontScale:color:thickness:lineType:")]
		void PutText (Mat img, string text, Point2i org, HersheyFonts fontFace, double fontScale, Scalar color, int thickness, LineTypes lineType);

		// +(void)putText:(Mat * _Nonnull)img text:(NSString * _Nonnull)text org:(Point2i * _Nonnull)org fontFace:(HersheyFonts)fontFace fontScale:(double)fontScale color:(Scalar * _Nonnull)color thickness:(int)thickness __attribute__((swift_name("putText(img:text:org:fontFace:fontScale:color:thickness:)")));
		[Static]
		[Export ("putText:text:org:fontFace:fontScale:color:thickness:")]
		void PutText (Mat img, string text, Point2i org, HersheyFonts fontFace, double fontScale, Scalar color, int thickness);

		// +(void)putText:(Mat * _Nonnull)img text:(NSString * _Nonnull)text org:(Point2i * _Nonnull)org fontFace:(HersheyFonts)fontFace fontScale:(double)fontScale color:(Scalar * _Nonnull)color __attribute__((swift_name("putText(img:text:org:fontFace:fontScale:color:)")));
		[Static]
		[Export ("putText:text:org:fontFace:fontScale:color:")]
		void PutText (Mat img, string text, Point2i org, HersheyFonts fontFace, double fontScale, Scalar color);

		// +(Size2i * _Nonnull)getTextSize:(NSString * _Nonnull)text fontFace:(HersheyFonts)fontFace fontScale:(double)fontScale thickness:(int)thickness baseLine:(int * _Nonnull)baseLine __attribute__((swift_name("getTextSize(text:fontFace:fontScale:thickness:baseLine:)")));
		[Static]
		[Export ("getTextSize:fontFace:fontScale:thickness:baseLine:")]
		unsafe Size2i GetTextSize (string text, HersheyFonts fontFace, double fontScale, int thickness, int* baseLine);

		// +(double)getFontScaleFromHeight:(int)fontFace pixelHeight:(int)pixelHeight thickness:(int)thickness __attribute__((swift_name("getFontScaleFromHeight(fontFace:pixelHeight:thickness:)")));
		[Static]
		[Export ("getFontScaleFromHeight:pixelHeight:thickness:")]
		double GetFontScaleFromHeight (int fontFace, int pixelHeight, int thickness);

		// +(double)getFontScaleFromHeight:(int)fontFace pixelHeight:(int)pixelHeight __attribute__((swift_name("getFontScaleFromHeight(fontFace:pixelHeight:)")));
		[Static]
		[Export ("getFontScaleFromHeight:pixelHeight:")]
		double GetFontScaleFromHeight (int fontFace, int pixelHeight);

		// +(void)HoughLinesWithAccumulator:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold srn:(double)srn stn:(double)stn min_theta:(double)min_theta max_theta:(double)max_theta use_edgeval:(BOOL)use_edgeval __attribute__((swift_name("HoughLinesWithAccumulator(image:lines:rho:theta:threshold:srn:stn:min_theta:max_theta:use_edgeval:)")));
		[Static]
		[Export ("HoughLinesWithAccumulator:lines:rho:theta:threshold:srn:stn:min_theta:max_theta:use_edgeval:")]
		void HoughLinesWithAccumulator (Mat image, Mat lines, double rho, double theta, int threshold, double srn, double stn, double min_theta, double max_theta, bool use_edgeval);

		// +(void)HoughLinesWithAccumulator:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold srn:(double)srn stn:(double)stn min_theta:(double)min_theta max_theta:(double)max_theta __attribute__((swift_name("HoughLinesWithAccumulator(image:lines:rho:theta:threshold:srn:stn:min_theta:max_theta:)")));
		[Static]
		[Export ("HoughLinesWithAccumulator:lines:rho:theta:threshold:srn:stn:min_theta:max_theta:")]
		void HoughLinesWithAccumulator (Mat image, Mat lines, double rho, double theta, int threshold, double srn, double stn, double min_theta, double max_theta);

		// +(void)HoughLinesWithAccumulator:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold srn:(double)srn stn:(double)stn min_theta:(double)min_theta __attribute__((swift_name("HoughLinesWithAccumulator(image:lines:rho:theta:threshold:srn:stn:min_theta:)")));
		[Static]
		[Export ("HoughLinesWithAccumulator:lines:rho:theta:threshold:srn:stn:min_theta:")]
		void HoughLinesWithAccumulator (Mat image, Mat lines, double rho, double theta, int threshold, double srn, double stn, double min_theta);

		// +(void)HoughLinesWithAccumulator:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold srn:(double)srn stn:(double)stn __attribute__((swift_name("HoughLinesWithAccumulator(image:lines:rho:theta:threshold:srn:stn:)")));
		[Static]
		[Export ("HoughLinesWithAccumulator:lines:rho:theta:threshold:srn:stn:")]
		void HoughLinesWithAccumulator (Mat image, Mat lines, double rho, double theta, int threshold, double srn, double stn);

		// +(void)HoughLinesWithAccumulator:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold srn:(double)srn __attribute__((swift_name("HoughLinesWithAccumulator(image:lines:rho:theta:threshold:srn:)")));
		[Static]
		[Export ("HoughLinesWithAccumulator:lines:rho:theta:threshold:srn:")]
		void HoughLinesWithAccumulator (Mat image, Mat lines, double rho, double theta, int threshold, double srn);

		// +(void)HoughLinesWithAccumulator:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines rho:(double)rho theta:(double)theta threshold:(int)threshold __attribute__((swift_name("HoughLinesWithAccumulator(image:lines:rho:theta:threshold:)")));
		[Static]
		[Export ("HoughLinesWithAccumulator:lines:rho:theta:threshold:")]
		void HoughLinesWithAccumulator (Mat image, Mat lines, double rho, double theta, int threshold);

		// +(void)HoughCirclesWithAccumulator:(Mat * _Nonnull)image circles:(Mat * _Nonnull)circles method:(int)method dp:(double)dp minDist:(double)minDist param1:(double)param1 param2:(double)param2 minRadius:(int)minRadius maxRadius:(int)maxRadius __attribute__((swift_name("HoughCirclesWithAccumulator(image:circles:method:dp:minDist:param1:param2:minRadius:maxRadius:)")));
		[Static]
		[Export ("HoughCirclesWithAccumulator:circles:method:dp:minDist:param1:param2:minRadius:maxRadius:")]
		void HoughCirclesWithAccumulator (Mat image, Mat circles, int method, double dp, double minDist, double param1, double param2, int minRadius, int maxRadius);

		// +(void)HoughCirclesWithAccumulator:(Mat * _Nonnull)image circles:(Mat * _Nonnull)circles method:(int)method dp:(double)dp minDist:(double)minDist param1:(double)param1 param2:(double)param2 minRadius:(int)minRadius __attribute__((swift_name("HoughCirclesWithAccumulator(image:circles:method:dp:minDist:param1:param2:minRadius:)")));
		[Static]
		[Export ("HoughCirclesWithAccumulator:circles:method:dp:minDist:param1:param2:minRadius:")]
		void HoughCirclesWithAccumulator (Mat image, Mat circles, int method, double dp, double minDist, double param1, double param2, int minRadius);

		// +(void)HoughCirclesWithAccumulator:(Mat * _Nonnull)image circles:(Mat * _Nonnull)circles method:(int)method dp:(double)dp minDist:(double)minDist param1:(double)param1 param2:(double)param2 __attribute__((swift_name("HoughCirclesWithAccumulator(image:circles:method:dp:minDist:param1:param2:)")));
		[Static]
		[Export ("HoughCirclesWithAccumulator:circles:method:dp:minDist:param1:param2:")]
		void HoughCirclesWithAccumulator (Mat image, Mat circles, int method, double dp, double minDist, double param1, double param2);

		// +(void)HoughCirclesWithAccumulator:(Mat * _Nonnull)image circles:(Mat * _Nonnull)circles method:(int)method dp:(double)dp minDist:(double)minDist param1:(double)param1 __attribute__((swift_name("HoughCirclesWithAccumulator(image:circles:method:dp:minDist:param1:)")));
		[Static]
		[Export ("HoughCirclesWithAccumulator:circles:method:dp:minDist:param1:")]
		void HoughCirclesWithAccumulator (Mat image, Mat circles, int method, double dp, double minDist, double param1);

		// +(void)HoughCirclesWithAccumulator:(Mat * _Nonnull)image circles:(Mat * _Nonnull)circles method:(int)method dp:(double)dp minDist:(double)minDist __attribute__((swift_name("HoughCirclesWithAccumulator(image:circles:method:dp:minDist:)")));
		[Static]
		[Export ("HoughCirclesWithAccumulator:circles:method:dp:minDist:")]
		void HoughCirclesWithAccumulator (Mat image, Mat circles, int method, double dp, double minDist);
	}

	// @interface CLAHE : Algorithm
	[BaseType (typeof(Algorithm))]
	interface CLAHE
	{
		// -(void)apply:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("apply(src:dst:)")));
		[Export ("apply:dst:")]
		void Apply (Mat src, Mat dst);

		// -(void)setClipLimit:(double)clipLimit __attribute__((swift_name("setClipLimit(clipLimit:)")));
		[Export ("setClipLimit:")]
		void SetClipLimit (double clipLimit);

		// -(double)getClipLimit __attribute__((swift_name("getClipLimit()")));
		[Export ("getClipLimit")]
		double ClipLimit { get; }

		// -(void)setTilesGridSize:(Size2i * _Nonnull)tileGridSize __attribute__((swift_name("setTilesGridSize(tileGridSize:)")));
		[Export ("setTilesGridSize:")]
		void SetTilesGridSize (Size2i tileGridSize);

		// -(Size2i * _Nonnull)getTilesGridSize __attribute__((swift_name("getTilesGridSize()")));
		[Export ("getTilesGridSize")]
		Size2i TilesGridSize { get; }

		// -(void)collectGarbage __attribute__((swift_name("collectGarbage()")));
		[Export ("collectGarbage")]
		void CollectGarbage ();
	}

	// @interface GeneralizedHough : Algorithm
	[BaseType (typeof(Algorithm))]
	interface GeneralizedHough
	{
		// -(void)setTemplate:(Mat * _Nonnull)templ templCenter:(Point2i * _Nonnull)templCenter __attribute__((swift_name("setTemplate(templ:templCenter:)")));
		[Export ("setTemplate:templCenter:")]
		void SetTemplate (Mat templ, Point2i templCenter);

		// -(void)setTemplate:(Mat * _Nonnull)templ __attribute__((swift_name("setTemplate(templ:)")));
		[Export ("setTemplate:")]
		void SetTemplate (Mat templ);

		// -(void)setTemplate:(Mat * _Nonnull)edges dx:(Mat * _Nonnull)dx dy:(Mat * _Nonnull)dy templCenter:(Point2i * _Nonnull)templCenter __attribute__((swift_name("setTemplate(edges:dx:dy:templCenter:)")));
		[Export ("setTemplate:dx:dy:templCenter:")]
		void SetTemplate (Mat edges, Mat dx, Mat dy, Point2i templCenter);

		// -(void)setTemplate:(Mat * _Nonnull)edges dx:(Mat * _Nonnull)dx dy:(Mat * _Nonnull)dy __attribute__((swift_name("setTemplate(edges:dx:dy:)")));
		[Export ("setTemplate:dx:dy:")]
		void SetTemplate (Mat edges, Mat dx, Mat dy);

		// -(void)detect:(Mat * _Nonnull)image positions:(Mat * _Nonnull)positions votes:(Mat * _Nonnull)votes __attribute__((swift_name("detect(image:positions:votes:)")));
		[Export ("detect:positions:votes:")]
		void Detect (Mat image, Mat positions, Mat votes);

		// -(void)detect:(Mat * _Nonnull)image positions:(Mat * _Nonnull)positions __attribute__((swift_name("detect(image:positions:)")));
		[Export ("detect:positions:")]
		void Detect (Mat image, Mat positions);

		// -(void)detect:(Mat * _Nonnull)edges dx:(Mat * _Nonnull)dx dy:(Mat * _Nonnull)dy positions:(Mat * _Nonnull)positions votes:(Mat * _Nonnull)votes __attribute__((swift_name("detect(edges:dx:dy:positions:votes:)")));
		[Export ("detect:dx:dy:positions:votes:")]
		void Detect (Mat edges, Mat dx, Mat dy, Mat positions, Mat votes);

		// -(void)detect:(Mat * _Nonnull)edges dx:(Mat * _Nonnull)dx dy:(Mat * _Nonnull)dy positions:(Mat * _Nonnull)positions __attribute__((swift_name("detect(edges:dx:dy:positions:)")));
		[Export ("detect:dx:dy:positions:")]
		void Detect (Mat edges, Mat dx, Mat dy, Mat positions);

		// -(void)setCannyLowThresh:(int)cannyLowThresh __attribute__((swift_name("setCannyLowThresh(cannyLowThresh:)")));
		[Export ("setCannyLowThresh:")]
		void SetCannyLowThresh (int cannyLowThresh);

		// -(int)getCannyLowThresh __attribute__((swift_name("getCannyLowThresh()")));
		[Export ("getCannyLowThresh")]
		int CannyLowThresh { get; }

		// -(void)setCannyHighThresh:(int)cannyHighThresh __attribute__((swift_name("setCannyHighThresh(cannyHighThresh:)")));
		[Export ("setCannyHighThresh:")]
		void SetCannyHighThresh (int cannyHighThresh);

		// -(int)getCannyHighThresh __attribute__((swift_name("getCannyHighThresh()")));
		[Export ("getCannyHighThresh")]
		int CannyHighThresh { get; }

		// -(void)setMinDist:(double)minDist __attribute__((swift_name("setMinDist(minDist:)")));
		[Export ("setMinDist:")]
		void SetMinDist (double minDist);

		// -(double)getMinDist __attribute__((swift_name("getMinDist()")));
		[Export ("getMinDist")]
		double MinDist { get; }

		// -(void)setDp:(double)dp __attribute__((swift_name("setDp(dp:)")));
		[Export ("setDp:")]
		void SetDp (double dp);

		// -(double)getDp __attribute__((swift_name("getDp()")));
		[Export ("getDp")]
		double Dp { get; }

		// -(void)setMaxBufferSize:(int)maxBufferSize __attribute__((swift_name("setMaxBufferSize(maxBufferSize:)")));
		[Export ("setMaxBufferSize:")]
		void SetMaxBufferSize (int maxBufferSize);

		// -(int)getMaxBufferSize __attribute__((swift_name("getMaxBufferSize()")));
		[Export ("getMaxBufferSize")]
		int MaxBufferSize { get; }
	}

	// @interface GeneralizedHoughBallard : GeneralizedHough
	[BaseType (typeof(GeneralizedHough))]
	interface GeneralizedHoughBallard
	{
		// -(void)setLevels:(int)levels __attribute__((swift_name("setLevels(levels:)")));
		[Export ("setLevels:")]
		void SetLevels (int levels);

		// -(int)getLevels __attribute__((swift_name("getLevels()")));
		[Export ("getLevels")]
		int Levels { get; }

		// -(void)setVotesThreshold:(int)votesThreshold __attribute__((swift_name("setVotesThreshold(votesThreshold:)")));
		[Export ("setVotesThreshold:")]
		void SetVotesThreshold (int votesThreshold);

		// -(int)getVotesThreshold __attribute__((swift_name("getVotesThreshold()")));
		[Export ("getVotesThreshold")]
		int VotesThreshold { get; }
	}

	// @interface GeneralizedHoughGuil : GeneralizedHough
	[BaseType (typeof(GeneralizedHough))]
	interface GeneralizedHoughGuil
	{
		// -(void)setXi:(double)xi __attribute__((swift_name("setXi(xi:)")));
		[Export ("setXi:")]
		void SetXi (double xi);

		// -(double)getXi __attribute__((swift_name("getXi()")));
		[Export ("getXi")]
		double Xi { get; }

		// -(void)setLevels:(int)levels __attribute__((swift_name("setLevels(levels:)")));
		[Export ("setLevels:")]
		void SetLevels (int levels);

		// -(int)getLevels __attribute__((swift_name("getLevels()")));
		[Export ("getLevels")]
		int Levels { get; }

		// -(void)setAngleEpsilon:(double)angleEpsilon __attribute__((swift_name("setAngleEpsilon(angleEpsilon:)")));
		[Export ("setAngleEpsilon:")]
		void SetAngleEpsilon (double angleEpsilon);

		// -(double)getAngleEpsilon __attribute__((swift_name("getAngleEpsilon()")));
		[Export ("getAngleEpsilon")]
		double AngleEpsilon { get; }

		// -(void)setMinAngle:(double)minAngle __attribute__((swift_name("setMinAngle(minAngle:)")));
		[Export ("setMinAngle:")]
		void SetMinAngle (double minAngle);

		// -(double)getMinAngle __attribute__((swift_name("getMinAngle()")));
		[Export ("getMinAngle")]
		double MinAngle { get; }

		// -(void)setMaxAngle:(double)maxAngle __attribute__((swift_name("setMaxAngle(maxAngle:)")));
		[Export ("setMaxAngle:")]
		void SetMaxAngle (double maxAngle);

		// -(double)getMaxAngle __attribute__((swift_name("getMaxAngle()")));
		[Export ("getMaxAngle")]
		double MaxAngle { get; }

		// -(void)setAngleStep:(double)angleStep __attribute__((swift_name("setAngleStep(angleStep:)")));
		[Export ("setAngleStep:")]
		void SetAngleStep (double angleStep);

		// -(double)getAngleStep __attribute__((swift_name("getAngleStep()")));
		[Export ("getAngleStep")]
		double AngleStep { get; }

		// -(void)setAngleThresh:(int)angleThresh __attribute__((swift_name("setAngleThresh(angleThresh:)")));
		[Export ("setAngleThresh:")]
		void SetAngleThresh (int angleThresh);

		// -(int)getAngleThresh __attribute__((swift_name("getAngleThresh()")));
		[Export ("getAngleThresh")]
		int AngleThresh { get; }

		// -(void)setMinScale:(double)minScale __attribute__((swift_name("setMinScale(minScale:)")));
		[Export ("setMinScale:")]
		void SetMinScale (double minScale);

		// -(double)getMinScale __attribute__((swift_name("getMinScale()")));
		[Export ("getMinScale")]
		double MinScale { get; }

		// -(void)setMaxScale:(double)maxScale __attribute__((swift_name("setMaxScale(maxScale:)")));
		[Export ("setMaxScale:")]
		void SetMaxScale (double maxScale);

		// -(double)getMaxScale __attribute__((swift_name("getMaxScale()")));
		[Export ("getMaxScale")]
		double MaxScale { get; }

		// -(void)setScaleStep:(double)scaleStep __attribute__((swift_name("setScaleStep(scaleStep:)")));
		[Export ("setScaleStep:")]
		void SetScaleStep (double scaleStep);

		// -(double)getScaleStep __attribute__((swift_name("getScaleStep()")));
		[Export ("getScaleStep")]
		double ScaleStep { get; }

		// -(void)setScaleThresh:(int)scaleThresh __attribute__((swift_name("setScaleThresh(scaleThresh:)")));
		[Export ("setScaleThresh:")]
		void SetScaleThresh (int scaleThresh);

		// -(int)getScaleThresh __attribute__((swift_name("getScaleThresh()")));
		[Export ("getScaleThresh")]
		int ScaleThresh { get; }

		// -(void)setPosThresh:(int)posThresh __attribute__((swift_name("setPosThresh(posThresh:)")));
		[Export ("setPosThresh:")]
		void SetPosThresh (int posThresh);

		// -(int)getPosThresh __attribute__((swift_name("getPosThresh()")));
		[Export ("getPosThresh")]
		int PosThresh { get; }
	}

	// @interface LineSegmentDetector : Algorithm
	[BaseType (typeof(Algorithm))]
	interface LineSegmentDetector
	{
		// -(void)detect:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines width:(Mat * _Nonnull)width prec:(Mat * _Nonnull)prec nfa:(Mat * _Nonnull)nfa __attribute__((swift_name("detect(image:lines:width:prec:nfa:)")));
		[Export ("detect:lines:width:prec:nfa:")]
		void Detect (Mat image, Mat lines, Mat width, Mat prec, Mat nfa);

		// -(void)detect:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines width:(Mat * _Nonnull)width prec:(Mat * _Nonnull)prec __attribute__((swift_name("detect(image:lines:width:prec:)")));
		[Export ("detect:lines:width:prec:")]
		void Detect (Mat image, Mat lines, Mat width, Mat prec);

		// -(void)detect:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines width:(Mat * _Nonnull)width __attribute__((swift_name("detect(image:lines:width:)")));
		[Export ("detect:lines:width:")]
		void Detect (Mat image, Mat lines, Mat width);

		// -(void)detect:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines __attribute__((swift_name("detect(image:lines:)")));
		[Export ("detect:lines:")]
		void Detect (Mat image, Mat lines);

		// -(void)drawSegments:(Mat * _Nonnull)image lines:(Mat * _Nonnull)lines __attribute__((swift_name("drawSegments(image:lines:)")));
		[Export ("drawSegments:lines:")]
		void DrawSegments (Mat image, Mat lines);

		// -(int)compareSegments:(Size2i * _Nonnull)size lines1:(Mat * _Nonnull)lines1 lines2:(Mat * _Nonnull)lines2 image:(Mat * _Nonnull)image __attribute__((swift_name("compareSegments(size:lines1:lines2:image:)")));
		[Export ("compareSegments:lines1:lines2:image:")]
		int CompareSegments (Size2i size, Mat lines1, Mat lines2, Mat image);

		// -(int)compareSegments:(Size2i * _Nonnull)size lines1:(Mat * _Nonnull)lines1 lines2:(Mat * _Nonnull)lines2 __attribute__((swift_name("compareSegments(size:lines1:lines2:)")));
		[Export ("compareSegments:lines1:lines2:")]
		int CompareSegments (Size2i size, Mat lines1, Mat lines2);
	}

	// @interface Subdiv2D : NSObject
	[BaseType (typeof(NSObject))]
	interface Subdiv2D
	{
		// @property (readonly, class) int PTLOC_ERROR __attribute__((swift_name("PTLOC_ERROR")));
		[Static]
		[Export ("PTLOC_ERROR")]
		int PTLOC_ERROR { get; }

		// @property (readonly, class) int PTLOC_OUTSIDE_RECT __attribute__((swift_name("PTLOC_OUTSIDE_RECT")));
		[Static]
		[Export ("PTLOC_OUTSIDE_RECT")]
		int PTLOC_OUTSIDE_RECT { get; }

		// @property (readonly, class) int PTLOC_INSIDE __attribute__((swift_name("PTLOC_INSIDE")));
		[Static]
		[Export ("PTLOC_INSIDE")]
		int PTLOC_INSIDE { get; }

		// @property (readonly, class) int PTLOC_VERTEX __attribute__((swift_name("PTLOC_VERTEX")));
		[Static]
		[Export ("PTLOC_VERTEX")]
		int PTLOC_VERTEX { get; }

		// @property (readonly, class) int PTLOC_ON_EDGE __attribute__((swift_name("PTLOC_ON_EDGE")));
		[Static]
		[Export ("PTLOC_ON_EDGE")]
		int PTLOC_ON_EDGE { get; }

		// @property (readonly, class) int NEXT_AROUND_ORG __attribute__((swift_name("NEXT_AROUND_ORG")));
		[Static]
		[Export ("NEXT_AROUND_ORG")]
		int NEXT_AROUND_ORG { get; }

		// @property (readonly, class) int NEXT_AROUND_DST __attribute__((swift_name("NEXT_AROUND_DST")));
		[Static]
		[Export ("NEXT_AROUND_DST")]
		int NEXT_AROUND_DST { get; }

		// @property (readonly, class) int PREV_AROUND_ORG __attribute__((swift_name("PREV_AROUND_ORG")));
		[Static]
		[Export ("PREV_AROUND_ORG")]
		int PREV_AROUND_ORG { get; }

		// @property (readonly, class) int PREV_AROUND_DST __attribute__((swift_name("PREV_AROUND_DST")));
		[Static]
		[Export ("PREV_AROUND_DST")]
		int PREV_AROUND_DST { get; }

		// @property (readonly, class) int NEXT_AROUND_LEFT __attribute__((swift_name("NEXT_AROUND_LEFT")));
		[Static]
		[Export ("NEXT_AROUND_LEFT")]
		int NEXT_AROUND_LEFT { get; }

		// @property (readonly, class) int NEXT_AROUND_RIGHT __attribute__((swift_name("NEXT_AROUND_RIGHT")));
		[Static]
		[Export ("NEXT_AROUND_RIGHT")]
		int NEXT_AROUND_RIGHT { get; }

		// @property (readonly, class) int PREV_AROUND_LEFT __attribute__((swift_name("PREV_AROUND_LEFT")));
		[Static]
		[Export ("PREV_AROUND_LEFT")]
		int PREV_AROUND_LEFT { get; }

		// @property (readonly, class) int PREV_AROUND_RIGHT __attribute__((swift_name("PREV_AROUND_RIGHT")));
		[Static]
		[Export ("PREV_AROUND_RIGHT")]
		int PREV_AROUND_RIGHT { get; }

		// -(instancetype _Nonnull)initWithRect:(Rect2i * _Nonnull)rect;
		[Export ("initWithRect:")]
		NativeHandle Constructor (Rect2i rect);

		// -(void)initDelaunay:(Rect2i * _Nonnull)rect __attribute__((swift_name("initDelaunay(rect:)")));
		[Export ("initDelaunay:")]
		void InitDelaunay (Rect2i rect);

		// -(int)insert:(Point2f * _Nonnull)pt __attribute__((swift_name("insert(pt:)")));
		[Export ("insert:")]
		int Insert (Point2f pt);

		// -(void)insertVector:(NSArray<Point2f *> * _Nonnull)ptvec __attribute__((swift_name("insert(ptvec:)")));
		[Export ("insertVector:")]
		void InsertVector (Point2f[] ptvec);

		// -(int)locate:(Point2f * _Nonnull)pt edge:(int * _Nonnull)edge vertex:(int * _Nonnull)vertex __attribute__((swift_name("locate(pt:edge:vertex:)")));
		[Export ("locate:edge:vertex:")]
		unsafe int Locate (Point2f pt, int* edge, int* vertex);

		// -(int)findNearest:(Point2f * _Nonnull)pt nearestPt:(Point2f * _Nonnull)nearestPt __attribute__((swift_name("findNearest(pt:nearestPt:)")));
		[Export ("findNearest:nearestPt:")]
		int FindNearest (Point2f pt, Point2f nearestPt);

		// -(int)findNearest:(Point2f * _Nonnull)pt __attribute__((swift_name("findNearest(pt:)")));
		[Export ("findNearest:")]
		int FindNearest (Point2f pt);

		// -(void)getEdgeList:(NSMutableArray<Float4 *> * _Nonnull)edgeList __attribute__((swift_name("getEdgeList(edgeList:)")));
		[Export ("getEdgeList:")]
		void GetEdgeList (NSMutableArray<Float4> edgeList);

		// -(void)getLeadingEdgeList:(IntVector * _Nonnull)leadingEdgeList __attribute__((swift_name("getLeadingEdgeList(leadingEdgeList:)")));
		[Export ("getLeadingEdgeList:")]
		void GetLeadingEdgeList (IntVector leadingEdgeList);

		// -(void)getTriangleList:(NSMutableArray<Float6 *> * _Nonnull)triangleList __attribute__((swift_name("getTriangleList(triangleList:)")));
		[Export ("getTriangleList:")]
		void GetTriangleList (NSMutableArray<Float6> triangleList);

		// -(void)getVoronoiFacetList:(IntVector * _Nonnull)idx facetList:(NSMutableArray<NSMutableArray<Point2f *> *> * _Nonnull)facetList facetCenters:(NSMutableArray<Point2f *> * _Nonnull)facetCenters __attribute__((swift_name("getVoronoiFacetList(idx:facetList:facetCenters:)")));
		[Export ("getVoronoiFacetList:facetList:facetCenters:")]
		void GetVoronoiFacetList (IntVector idx, NSMutableArray<NSMutableArray<Point2f>> facetList, NSMutableArray<Point2f> facetCenters);

		// -(Point2f * _Nonnull)getVertex:(int)vertex firstEdge:(int * _Nonnull)firstEdge __attribute__((swift_name("getVertex(vertex:firstEdge:)")));
		[Export ("getVertex:firstEdge:")]
		unsafe Point2f GetVertex (int vertex, int* firstEdge);

		// -(Point2f * _Nonnull)getVertex:(int)vertex __attribute__((swift_name("getVertex(vertex:)")));
		[Export ("getVertex:")]
		Point2f GetVertex (int vertex);

		// -(int)getEdge:(int)edge nextEdgeType:(int)nextEdgeType __attribute__((swift_name("getEdge(edge:nextEdgeType:)")));
		[Export ("getEdge:nextEdgeType:")]
		int GetEdge (int edge, int nextEdgeType);

		// -(int)nextEdge:(int)edge __attribute__((swift_name("nextEdge(edge:)")));
		[Export ("nextEdge:")]
		int NextEdge (int edge);

		// -(int)rotateEdge:(int)edge rotate:(int)rotate __attribute__((swift_name("rotateEdge(edge:rotate:)")));
		[Export ("rotateEdge:rotate:")]
		int RotateEdge (int edge, int rotate);

		// -(int)symEdge:(int)edge __attribute__((swift_name("symEdge(edge:)")));
		[Export ("symEdge:")]
		int SymEdge (int edge);

		// -(int)edgeOrg:(int)edge orgpt:(Point2f * _Nonnull)orgpt __attribute__((swift_name("edgeOrg(edge:orgpt:)")));
		[Export ("edgeOrg:orgpt:")]
		int EdgeOrg (int edge, Point2f orgpt);

		// -(int)edgeOrg:(int)edge __attribute__((swift_name("edgeOrg(edge:)")));
		[Export ("edgeOrg:")]
		int EdgeOrg (int edge);

		// -(int)edgeDst:(int)edge dstpt:(Point2f * _Nonnull)dstpt __attribute__((swift_name("edgeDst(edge:dstpt:)")));
		[Export ("edgeDst:dstpt:")]
		int EdgeDst (int edge, Point2f dstpt);

		// -(int)edgeDst:(int)edge __attribute__((swift_name("edgeDst(edge:)")));
		[Export ("edgeDst:")]
		int EdgeDst (int edge);
	}

	// @interface IntelligentScissorsMB : NSObject
	[BaseType (typeof(NSObject))]
	interface IntelligentScissorsMB
	{
		// -(IntelligentScissorsMB * _Nonnull)setWeights:(float)weight_non_edge weight_gradient_direction:(float)weight_gradient_direction weight_gradient_magnitude:(float)weight_gradient_magnitude __attribute__((swift_name("setWeights(weight_non_edge:weight_gradient_direction:weight_gradient_magnitude:)")));
		[Export ("setWeights:weight_gradient_direction:weight_gradient_magnitude:")]
		IntelligentScissorsMB SetWeights (float weight_non_edge, float weight_gradient_direction, float weight_gradient_magnitude);

		// -(IntelligentScissorsMB * _Nonnull)setGradientMagnitudeMaxLimit:(float)gradient_magnitude_threshold_max __attribute__((swift_name("setGradientMagnitudeMaxLimit(gradient_magnitude_threshold_max:)")));
		[Export ("setGradientMagnitudeMaxLimit:")]
		IntelligentScissorsMB SetGradientMagnitudeMaxLimit (float gradient_magnitude_threshold_max);

		// -(IntelligentScissorsMB * _Nonnull)setGradientMagnitudeMaxLimit __attribute__((swift_name("setGradientMagnitudeMaxLimit()")));
		[Export ("setGradientMagnitudeMaxLimit")]
		IntelligentScissorsMB SetGradientMagnitudeMaxLimit ();

		// -(IntelligentScissorsMB * _Nonnull)setEdgeFeatureZeroCrossingParameters:(float)gradient_magnitude_min_value __attribute__((swift_name("setEdgeFeatureZeroCrossingParameters(gradient_magnitude_min_value:)")));
		[Export ("setEdgeFeatureZeroCrossingParameters:")]
		IntelligentScissorsMB SetEdgeFeatureZeroCrossingParameters (float gradient_magnitude_min_value);

		// -(IntelligentScissorsMB * _Nonnull)setEdgeFeatureZeroCrossingParameters __attribute__((swift_name("setEdgeFeatureZeroCrossingParameters()")));
		[Export ("setEdgeFeatureZeroCrossingParameters")]
		IntelligentScissorsMB SetEdgeFeatureZeroCrossingParameters ();

		// -(IntelligentScissorsMB * _Nonnull)setEdgeFeatureCannyParameters:(double)threshold1 threshold2:(double)threshold2 apertureSize:(int)apertureSize L2gradient:(BOOL)L2gradient __attribute__((swift_name("setEdgeFeatureCannyParameters(threshold1:threshold2:apertureSize:L2gradient:)")));
		[Export ("setEdgeFeatureCannyParameters:threshold2:apertureSize:L2gradient:")]
		IntelligentScissorsMB SetEdgeFeatureCannyParameters (double threshold1, double threshold2, int apertureSize, bool L2gradient);

		// -(IntelligentScissorsMB * _Nonnull)setEdgeFeatureCannyParameters:(double)threshold1 threshold2:(double)threshold2 apertureSize:(int)apertureSize __attribute__((swift_name("setEdgeFeatureCannyParameters(threshold1:threshold2:apertureSize:)")));
		[Export ("setEdgeFeatureCannyParameters:threshold2:apertureSize:")]
		IntelligentScissorsMB SetEdgeFeatureCannyParameters (double threshold1, double threshold2, int apertureSize);

		// -(IntelligentScissorsMB * _Nonnull)setEdgeFeatureCannyParameters:(double)threshold1 threshold2:(double)threshold2 __attribute__((swift_name("setEdgeFeatureCannyParameters(threshold1:threshold2:)")));
		[Export ("setEdgeFeatureCannyParameters:threshold2:")]
		IntelligentScissorsMB SetEdgeFeatureCannyParameters (double threshold1, double threshold2);

		// -(IntelligentScissorsMB * _Nonnull)applyImage:(Mat * _Nonnull)image __attribute__((swift_name("applyImage(image:)")));
		[Export ("applyImage:")]
		IntelligentScissorsMB ApplyImage (Mat image);

		// -(IntelligentScissorsMB * _Nonnull)applyImageFeatures:(Mat * _Nonnull)non_edge gradient_direction:(Mat * _Nonnull)gradient_direction gradient_magnitude:(Mat * _Nonnull)gradient_magnitude image:(Mat * _Nonnull)image __attribute__((swift_name("applyImageFeatures(non_edge:gradient_direction:gradient_magnitude:image:)")));
		[Export ("applyImageFeatures:gradient_direction:gradient_magnitude:image:")]
		IntelligentScissorsMB ApplyImageFeatures (Mat non_edge, Mat gradient_direction, Mat gradient_magnitude, Mat image);

		// -(IntelligentScissorsMB * _Nonnull)applyImageFeatures:(Mat * _Nonnull)non_edge gradient_direction:(Mat * _Nonnull)gradient_direction gradient_magnitude:(Mat * _Nonnull)gradient_magnitude __attribute__((swift_name("applyImageFeatures(non_edge:gradient_direction:gradient_magnitude:)")));
		[Export ("applyImageFeatures:gradient_direction:gradient_magnitude:")]
		IntelligentScissorsMB ApplyImageFeatures (Mat non_edge, Mat gradient_direction, Mat gradient_magnitude);

		// -(void)buildMap:(Point2i * _Nonnull)sourcePt __attribute__((swift_name("buildMap(sourcePt:)")));
		[Export ("buildMap:")]
		void BuildMap (Point2i sourcePt);

		// -(void)getContour:(Point2i * _Nonnull)targetPt contour:(Mat * _Nonnull)contour backward:(BOOL)backward __attribute__((swift_name("getContour(targetPt:contour:backward:)")));
		[Export ("getContour:contour:backward:")]
		void GetContour (Point2i targetPt, Mat contour, bool backward);

		// -(void)getContour:(Point2i * _Nonnull)targetPt contour:(Mat * _Nonnull)contour __attribute__((swift_name("getContour(targetPt:contour:)")));
		[Export ("getContour:contour:")]
		void GetContour (Point2i targetPt, Mat contour);
	}

	// @interface Ml : NSObject
	[BaseType (typeof(NSObject))]
	interface Ml
	{
	}

	// @interface StatModel : Algorithm
	[BaseType (typeof(Algorithm))]
	interface StatModel
	{
		// -(int)getVarCount __attribute__((swift_name("getVarCount()")));
		[Export ("getVarCount")]
		int VarCount { get; }

		// -(BOOL)empty __attribute__((swift_name("empty()")));
		[Export ("empty")]
		bool Empty { get; }

		// -(BOOL)isTrained __attribute__((swift_name("isTrained()")));
		[Export ("isTrained")]
		bool IsTrained { get; }

		// -(BOOL)isClassifier __attribute__((swift_name("isClassifier()")));
		[Export ("isClassifier")]
		bool IsClassifier { get; }

		// -(BOOL)train:(TrainData * _Nonnull)trainData flags:(int)flags __attribute__((swift_name("train(trainData:flags:)")));
		[Export ("train:flags:")]
		bool Train (TrainData trainData, int flags);

		// -(BOOL)train:(TrainData * _Nonnull)trainData __attribute__((swift_name("train(trainData:)")));
		[Export ("train:")]
		bool Train (TrainData trainData);

		// -(BOOL)train:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses __attribute__((swift_name("train(samples:layout:responses:)")));
		[Export ("train:layout:responses:")]
		bool Train (Mat samples, int layout, Mat responses);

		// -(float)calcError:(TrainData * _Nonnull)data test:(BOOL)test resp:(Mat * _Nonnull)resp __attribute__((swift_name("calcError(data:test:resp:)")));
		[Export ("calcError:test:resp:")]
		float CalcError (TrainData data, bool test, Mat resp);

		// -(float)predict:(Mat * _Nonnull)samples results:(Mat * _Nonnull)results flags:(int)flags __attribute__((swift_name("predict(samples:results:flags:)")));
		[Export ("predict:results:flags:")]
		float Predict (Mat samples, Mat results, int flags);

		// -(float)predict:(Mat * _Nonnull)samples results:(Mat * _Nonnull)results __attribute__((swift_name("predict(samples:results:)")));
		[Export ("predict:results:")]
		float Predict (Mat samples, Mat results);

		// -(float)predict:(Mat * _Nonnull)samples __attribute__((swift_name("predict(samples:)")));
		[Export ("predict:")]
		float Predict (Mat samples);
	}

	// @interface ANN_MLP : StatModel
	[BaseType (typeof(StatModel))]
	interface ANN_MLP
	{
		// -(void)setTrainMethod:(int)method param1:(double)param1 param2:(double)param2 __attribute__((swift_name("setTrainMethod(method:param1:param2:)")));
		[Export ("setTrainMethod:param1:param2:")]
		void SetTrainMethod (int method, double param1, double param2);

		// -(void)setTrainMethod:(int)method param1:(double)param1 __attribute__((swift_name("setTrainMethod(method:param1:)")));
		[Export ("setTrainMethod:param1:")]
		void SetTrainMethod (int method, double param1);

		// -(void)setTrainMethod:(int)method __attribute__((swift_name("setTrainMethod(method:)")));
		[Export ("setTrainMethod:")]
		void SetTrainMethod (int method);

		// -(int)getTrainMethod __attribute__((swift_name("getTrainMethod()")));
		[Export ("getTrainMethod")]
		int TrainMethod { get; }

		// -(void)setActivationFunction:(int)type param1:(double)param1 param2:(double)param2 __attribute__((swift_name("setActivationFunction(type:param1:param2:)")));
		[Export ("setActivationFunction:param1:param2:")]
		void SetActivationFunction (int type, double param1, double param2);

		// -(void)setActivationFunction:(int)type param1:(double)param1 __attribute__((swift_name("setActivationFunction(type:param1:)")));
		[Export ("setActivationFunction:param1:")]
		void SetActivationFunction (int type, double param1);

		// -(void)setActivationFunction:(int)type __attribute__((swift_name("setActivationFunction(type:)")));
		[Export ("setActivationFunction:")]
		void SetActivationFunction (int type);

		// -(void)setLayerSizes:(Mat * _Nonnull)_layer_sizes __attribute__((swift_name("setLayerSizes(_layer_sizes:)")));
		[Export ("setLayerSizes:")]
		void SetLayerSizes (Mat _layer_sizes);

		// -(Mat * _Nonnull)getLayerSizes __attribute__((swift_name("getLayerSizes()")));
		[Export ("getLayerSizes")]
		Mat LayerSizes { get; }

		// -(TermCriteria * _Nonnull)getTermCriteria __attribute__((swift_name("getTermCriteria()")));
		[Export ("getTermCriteria")]
		TermCriteria TermCriteria { get; }

		// -(void)setTermCriteria:(TermCriteria * _Nonnull)val __attribute__((swift_name("setTermCriteria(val:)")));
		[Export ("setTermCriteria:")]
		void SetTermCriteria (TermCriteria val);

		// -(double)getBackpropWeightScale __attribute__((swift_name("getBackpropWeightScale()")));
		[Export ("getBackpropWeightScale")]
		double BackpropWeightScale { get; }

		// -(void)setBackpropWeightScale:(double)val __attribute__((swift_name("setBackpropWeightScale(val:)")));
		[Export ("setBackpropWeightScale:")]
		void SetBackpropWeightScale (double val);

		// -(double)getBackpropMomentumScale __attribute__((swift_name("getBackpropMomentumScale()")));
		[Export ("getBackpropMomentumScale")]
		double BackpropMomentumScale { get; }

		// -(void)setBackpropMomentumScale:(double)val __attribute__((swift_name("setBackpropMomentumScale(val:)")));
		[Export ("setBackpropMomentumScale:")]
		void SetBackpropMomentumScale (double val);

		// -(double)getRpropDW0 __attribute__((swift_name("getRpropDW0()")));
		[Export ("getRpropDW0")]
		double RpropDW0 { get; }

		// -(void)setRpropDW0:(double)val __attribute__((swift_name("setRpropDW0(val:)")));
		[Export ("setRpropDW0:")]
		void SetRpropDW0 (double val);

		// -(double)getRpropDWPlus __attribute__((swift_name("getRpropDWPlus()")));
		[Export ("getRpropDWPlus")]
		double RpropDWPlus { get; }

		// -(void)setRpropDWPlus:(double)val __attribute__((swift_name("setRpropDWPlus(val:)")));
		[Export ("setRpropDWPlus:")]
		void SetRpropDWPlus (double val);

		// -(double)getRpropDWMinus __attribute__((swift_name("getRpropDWMinus()")));
		[Export ("getRpropDWMinus")]
		double RpropDWMinus { get; }

		// -(void)setRpropDWMinus:(double)val __attribute__((swift_name("setRpropDWMinus(val:)")));
		[Export ("setRpropDWMinus:")]
		void SetRpropDWMinus (double val);

		// -(double)getRpropDWMin __attribute__((swift_name("getRpropDWMin()")));
		[Export ("getRpropDWMin")]
		double RpropDWMin { get; }

		// -(void)setRpropDWMin:(double)val __attribute__((swift_name("setRpropDWMin(val:)")));
		[Export ("setRpropDWMin:")]
		void SetRpropDWMin (double val);

		// -(double)getRpropDWMax __attribute__((swift_name("getRpropDWMax()")));
		[Export ("getRpropDWMax")]
		double RpropDWMax { get; }

		// -(void)setRpropDWMax:(double)val __attribute__((swift_name("setRpropDWMax(val:)")));
		[Export ("setRpropDWMax:")]
		void SetRpropDWMax (double val);

		// -(double)getAnnealInitialT __attribute__((swift_name("getAnnealInitialT()")));
		[Export ("getAnnealInitialT")]
		double AnnealInitialT { get; }

		// -(void)setAnnealInitialT:(double)val __attribute__((swift_name("setAnnealInitialT(val:)")));
		[Export ("setAnnealInitialT:")]
		void SetAnnealInitialT (double val);

		// -(double)getAnnealFinalT __attribute__((swift_name("getAnnealFinalT()")));
		[Export ("getAnnealFinalT")]
		double AnnealFinalT { get; }

		// -(void)setAnnealFinalT:(double)val __attribute__((swift_name("setAnnealFinalT(val:)")));
		[Export ("setAnnealFinalT:")]
		void SetAnnealFinalT (double val);

		// -(double)getAnnealCoolingRatio __attribute__((swift_name("getAnnealCoolingRatio()")));
		[Export ("getAnnealCoolingRatio")]
		double AnnealCoolingRatio { get; }

		// -(void)setAnnealCoolingRatio:(double)val __attribute__((swift_name("setAnnealCoolingRatio(val:)")));
		[Export ("setAnnealCoolingRatio:")]
		void SetAnnealCoolingRatio (double val);

		// -(int)getAnnealItePerStep __attribute__((swift_name("getAnnealItePerStep()")));
		[Export ("getAnnealItePerStep")]
		int AnnealItePerStep { get; }

		// -(void)setAnnealItePerStep:(int)val __attribute__((swift_name("setAnnealItePerStep(val:)")));
		[Export ("setAnnealItePerStep:")]
		void SetAnnealItePerStep (int val);

		// -(Mat * _Nonnull)getWeights:(int)layerIdx __attribute__((swift_name("getWeights(layerIdx:)")));
		[Export ("getWeights:")]
		Mat GetWeights (int layerIdx);

		// +(ANN_MLP * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		ANN_MLP Create ();

		// +(ANN_MLP * _Nonnull)load:(NSString * _Nonnull)filepath __attribute__((swift_name("load(filepath:)")));
		[Static]
		[Export ("load:")]
		ANN_MLP Load (string filepath);
	}

	// @interface DTrees : StatModel
	[BaseType (typeof(StatModel))]
	interface DTrees
	{
		// -(int)getMaxCategories __attribute__((swift_name("getMaxCategories()")));
		[Export ("getMaxCategories")]
		int MaxCategories { get; }

		// -(void)setMaxCategories:(int)val __attribute__((swift_name("setMaxCategories(val:)")));
		[Export ("setMaxCategories:")]
		void SetMaxCategories (int val);

		// -(int)getMaxDepth __attribute__((swift_name("getMaxDepth()")));
		[Export ("getMaxDepth")]
		int MaxDepth { get; }

		// -(void)setMaxDepth:(int)val __attribute__((swift_name("setMaxDepth(val:)")));
		[Export ("setMaxDepth:")]
		void SetMaxDepth (int val);

		// -(int)getMinSampleCount __attribute__((swift_name("getMinSampleCount()")));
		[Export ("getMinSampleCount")]
		int MinSampleCount { get; }

		// -(void)setMinSampleCount:(int)val __attribute__((swift_name("setMinSampleCount(val:)")));
		[Export ("setMinSampleCount:")]
		void SetMinSampleCount (int val);

		// -(int)getCVFolds __attribute__((swift_name("getCVFolds()")));
		[Export ("getCVFolds")]
		int CVFolds { get; }

		// -(void)setCVFolds:(int)val __attribute__((swift_name("setCVFolds(val:)")));
		[Export ("setCVFolds:")]
		void SetCVFolds (int val);

		// -(BOOL)getUseSurrogates __attribute__((swift_name("getUseSurrogates()")));
		[Export ("getUseSurrogates")]
		bool UseSurrogates { get; }

		// -(void)setUseSurrogates:(BOOL)val __attribute__((swift_name("setUseSurrogates(val:)")));
		[Export ("setUseSurrogates:")]
		void SetUseSurrogates (bool val);

		// -(BOOL)getUse1SERule __attribute__((swift_name("getUse1SERule()")));
		[Export ("getUse1SERule")]
		bool Use1SERule { get; }

		// -(void)setUse1SERule:(BOOL)val __attribute__((swift_name("setUse1SERule(val:)")));
		[Export ("setUse1SERule:")]
		void SetUse1SERule (bool val);

		// -(BOOL)getTruncatePrunedTree __attribute__((swift_name("getTruncatePrunedTree()")));
		[Export ("getTruncatePrunedTree")]
		bool TruncatePrunedTree { get; }

		// -(void)setTruncatePrunedTree:(BOOL)val __attribute__((swift_name("setTruncatePrunedTree(val:)")));
		[Export ("setTruncatePrunedTree:")]
		void SetTruncatePrunedTree (bool val);

		// -(float)getRegressionAccuracy __attribute__((swift_name("getRegressionAccuracy()")));
		[Export ("getRegressionAccuracy")]
		float RegressionAccuracy { get; }

		// -(void)setRegressionAccuracy:(float)val __attribute__((swift_name("setRegressionAccuracy(val:)")));
		[Export ("setRegressionAccuracy:")]
		void SetRegressionAccuracy (float val);

		// -(Mat * _Nonnull)getPriors __attribute__((swift_name("getPriors()")));
		[Export ("getPriors")]
		Mat Priors { get; }

		// -(void)setPriors:(Mat * _Nonnull)val __attribute__((swift_name("setPriors(val:)")));
		[Export ("setPriors:")]
		void SetPriors (Mat val);

		// +(DTrees * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		DTrees Create ();

		// +(DTrees * _Nonnull)load:(NSString * _Nonnull)filepath nodeName:(NSString * _Nonnull)nodeName __attribute__((swift_name("load(filepath:nodeName:)")));
		[Static]
		[Export ("load:nodeName:")]
		DTrees Load (string filepath, string nodeName);

		// +(DTrees * _Nonnull)load:(NSString * _Nonnull)filepath __attribute__((swift_name("load(filepath:)")));
		[Static]
		[Export ("load:")]
		DTrees Load (string filepath);
	}

	// @interface Boost : DTrees
	[BaseType (typeof(DTrees))]
	interface Boost
	{
		// -(int)getBoostType __attribute__((swift_name("getBoostType()")));
		[Export ("getBoostType")]
		int BoostType { get; }

		// -(void)setBoostType:(int)val __attribute__((swift_name("setBoostType(val:)")));
		[Export ("setBoostType:")]
		void SetBoostType (int val);

		// -(int)getWeakCount __attribute__((swift_name("getWeakCount()")));
		[Export ("getWeakCount")]
		int WeakCount { get; }

		// -(void)setWeakCount:(int)val __attribute__((swift_name("setWeakCount(val:)")));
		[Export ("setWeakCount:")]
		void SetWeakCount (int val);

		// -(double)getWeightTrimRate __attribute__((swift_name("getWeightTrimRate()")));
		[Export ("getWeightTrimRate")]
		double WeightTrimRate { get; }

		// -(void)setWeightTrimRate:(double)val __attribute__((swift_name("setWeightTrimRate(val:)")));
		[Export ("setWeightTrimRate:")]
		void SetWeightTrimRate (double val);

		// +(Boost * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		Boost Create ();

		// +(Boost * _Nonnull)load:(NSString * _Nonnull)filepath nodeName:(NSString * _Nonnull)nodeName __attribute__((swift_name("load(filepath:nodeName:)")));
		[Static]
		[Export ("load:nodeName:")]
		Boost Load (string filepath, string nodeName);

		// +(Boost * _Nonnull)load:(NSString * _Nonnull)filepath __attribute__((swift_name("load(filepath:)")));
		[Static]
		[Export ("load:")]
		Boost Load (string filepath);
	}

	// @interface EM : StatModel
	[BaseType (typeof(StatModel))]
	interface EM
	{
		// @property (readonly, class) int DEFAULT_NCLUSTERS __attribute__((swift_name("DEFAULT_NCLUSTERS")));
		[Static]
		[Export ("DEFAULT_NCLUSTERS")]
		int DEFAULT_NCLUSTERS { get; }

		// @property (readonly, class) int DEFAULT_MAX_ITERS __attribute__((swift_name("DEFAULT_MAX_ITERS")));
		[Static]
		[Export ("DEFAULT_MAX_ITERS")]
		int DEFAULT_MAX_ITERS { get; }

		// @property (readonly, class) int START_E_STEP __attribute__((swift_name("START_E_STEP")));
		[Static]
		[Export ("START_E_STEP")]
		int START_E_STEP { get; }

		// @property (readonly, class) int START_M_STEP __attribute__((swift_name("START_M_STEP")));
		[Static]
		[Export ("START_M_STEP")]
		int START_M_STEP { get; }

		// @property (readonly, class) int START_AUTO_STEP __attribute__((swift_name("START_AUTO_STEP")));
		[Static]
		[Export ("START_AUTO_STEP")]
		int START_AUTO_STEP { get; }

		// -(int)getClustersNumber __attribute__((swift_name("getClustersNumber()")));
		[Export ("getClustersNumber")]
		int ClustersNumber { get; }

		// -(void)setClustersNumber:(int)val __attribute__((swift_name("setClustersNumber(val:)")));
		[Export ("setClustersNumber:")]
		void SetClustersNumber (int val);

		// -(int)getCovarianceMatrixType __attribute__((swift_name("getCovarianceMatrixType()")));
		[Export ("getCovarianceMatrixType")]
		int CovarianceMatrixType { get; }

		// -(void)setCovarianceMatrixType:(int)val __attribute__((swift_name("setCovarianceMatrixType(val:)")));
		[Export ("setCovarianceMatrixType:")]
		void SetCovarianceMatrixType (int val);

		// -(TermCriteria * _Nonnull)getTermCriteria __attribute__((swift_name("getTermCriteria()")));
		[Export ("getTermCriteria")]
		TermCriteria TermCriteria { get; }

		// -(void)setTermCriteria:(TermCriteria * _Nonnull)val __attribute__((swift_name("setTermCriteria(val:)")));
		[Export ("setTermCriteria:")]
		void SetTermCriteria (TermCriteria val);

		// -(Mat * _Nonnull)getWeights __attribute__((swift_name("getWeights()")));
		[Export ("getWeights")]
		Mat Weights { get; }

		// -(Mat * _Nonnull)getMeans __attribute__((swift_name("getMeans()")));
		[Export ("getMeans")]
		Mat Means { get; }

		// -(void)getCovs:(NSMutableArray<Mat *> * _Nonnull)covs __attribute__((swift_name("getCovs(covs:)")));
		[Export ("getCovs:")]
		void GetCovs (NSMutableArray<Mat> covs);

		// -(float)predict:(Mat * _Nonnull)samples results:(Mat * _Nonnull)results flags:(int)flags __attribute__((swift_name("predict(samples:results:flags:)")));
		[Export ("predict:results:flags:")]
		float Predict (Mat samples, Mat results, int flags);

		// -(float)predict:(Mat * _Nonnull)samples results:(Mat * _Nonnull)results __attribute__((swift_name("predict(samples:results:)")));
		[Export ("predict:results:")]
		float Predict (Mat samples, Mat results);

		// -(float)predict:(Mat * _Nonnull)samples __attribute__((swift_name("predict(samples:)")));
		[Export ("predict:")]
		float Predict (Mat samples);

		// -(Double2 * _Nonnull)predict2:(Mat * _Nonnull)sample probs:(Mat * _Nonnull)probs __attribute__((swift_name("predict2(sample:probs:)")));
		[Export ("predict2:probs:")]
		Double2 Predict2 (Mat sample, Mat probs);

		// -(BOOL)trainEM:(Mat * _Nonnull)samples logLikelihoods:(Mat * _Nonnull)logLikelihoods labels:(Mat * _Nonnull)labels probs:(Mat * _Nonnull)probs __attribute__((swift_name("trainEM(samples:logLikelihoods:labels:probs:)")));
		[Export ("trainEM:logLikelihoods:labels:probs:")]
		bool TrainEM (Mat samples, Mat logLikelihoods, Mat labels, Mat probs);

		// -(BOOL)trainEM:(Mat * _Nonnull)samples logLikelihoods:(Mat * _Nonnull)logLikelihoods labels:(Mat * _Nonnull)labels __attribute__((swift_name("trainEM(samples:logLikelihoods:labels:)")));
		[Export ("trainEM:logLikelihoods:labels:")]
		bool TrainEM (Mat samples, Mat logLikelihoods, Mat labels);

		// -(BOOL)trainEM:(Mat * _Nonnull)samples logLikelihoods:(Mat * _Nonnull)logLikelihoods __attribute__((swift_name("trainEM(samples:logLikelihoods:)")));
		[Export ("trainEM:logLikelihoods:")]
		bool TrainEM (Mat samples, Mat logLikelihoods);

		// -(BOOL)trainEM:(Mat * _Nonnull)samples __attribute__((swift_name("trainEM(samples:)")));
		[Export ("trainEM:")]
		bool TrainEM (Mat samples);

		// -(BOOL)trainE:(Mat * _Nonnull)samples means0:(Mat * _Nonnull)means0 covs0:(Mat * _Nonnull)covs0 weights0:(Mat * _Nonnull)weights0 logLikelihoods:(Mat * _Nonnull)logLikelihoods labels:(Mat * _Nonnull)labels probs:(Mat * _Nonnull)probs __attribute__((swift_name("trainE(samples:means0:covs0:weights0:logLikelihoods:labels:probs:)")));
		[Export ("trainE:means0:covs0:weights0:logLikelihoods:labels:probs:")]
		bool TrainE (Mat samples, Mat means0, Mat covs0, Mat weights0, Mat logLikelihoods, Mat labels, Mat probs);

		// -(BOOL)trainE:(Mat * _Nonnull)samples means0:(Mat * _Nonnull)means0 covs0:(Mat * _Nonnull)covs0 weights0:(Mat * _Nonnull)weights0 logLikelihoods:(Mat * _Nonnull)logLikelihoods labels:(Mat * _Nonnull)labels __attribute__((swift_name("trainE(samples:means0:covs0:weights0:logLikelihoods:labels:)")));
		[Export ("trainE:means0:covs0:weights0:logLikelihoods:labels:")]
		bool TrainE (Mat samples, Mat means0, Mat covs0, Mat weights0, Mat logLikelihoods, Mat labels);

		// -(BOOL)trainE:(Mat * _Nonnull)samples means0:(Mat * _Nonnull)means0 covs0:(Mat * _Nonnull)covs0 weights0:(Mat * _Nonnull)weights0 logLikelihoods:(Mat * _Nonnull)logLikelihoods __attribute__((swift_name("trainE(samples:means0:covs0:weights0:logLikelihoods:)")));
		[Export ("trainE:means0:covs0:weights0:logLikelihoods:")]
		bool TrainE (Mat samples, Mat means0, Mat covs0, Mat weights0, Mat logLikelihoods);

		// -(BOOL)trainE:(Mat * _Nonnull)samples means0:(Mat * _Nonnull)means0 covs0:(Mat * _Nonnull)covs0 weights0:(Mat * _Nonnull)weights0 __attribute__((swift_name("trainE(samples:means0:covs0:weights0:)")));
		[Export ("trainE:means0:covs0:weights0:")]
		bool TrainE (Mat samples, Mat means0, Mat covs0, Mat weights0);

		// -(BOOL)trainE:(Mat * _Nonnull)samples means0:(Mat * _Nonnull)means0 covs0:(Mat * _Nonnull)covs0 __attribute__((swift_name("trainE(samples:means0:covs0:)")));
		[Export ("trainE:means0:covs0:")]
		bool TrainE (Mat samples, Mat means0, Mat covs0);

		// -(BOOL)trainE:(Mat * _Nonnull)samples means0:(Mat * _Nonnull)means0 __attribute__((swift_name("trainE(samples:means0:)")));
		[Export ("trainE:means0:")]
		bool TrainE (Mat samples, Mat means0);

		// -(BOOL)trainM:(Mat * _Nonnull)samples probs0:(Mat * _Nonnull)probs0 logLikelihoods:(Mat * _Nonnull)logLikelihoods labels:(Mat * _Nonnull)labels probs:(Mat * _Nonnull)probs __attribute__((swift_name("trainM(samples:probs0:logLikelihoods:labels:probs:)")));
		[Export ("trainM:probs0:logLikelihoods:labels:probs:")]
		bool TrainM (Mat samples, Mat probs0, Mat logLikelihoods, Mat labels, Mat probs);

		// -(BOOL)trainM:(Mat * _Nonnull)samples probs0:(Mat * _Nonnull)probs0 logLikelihoods:(Mat * _Nonnull)logLikelihoods labels:(Mat * _Nonnull)labels __attribute__((swift_name("trainM(samples:probs0:logLikelihoods:labels:)")));
		[Export ("trainM:probs0:logLikelihoods:labels:")]
		bool TrainM (Mat samples, Mat probs0, Mat logLikelihoods, Mat labels);

		// -(BOOL)trainM:(Mat * _Nonnull)samples probs0:(Mat * _Nonnull)probs0 logLikelihoods:(Mat * _Nonnull)logLikelihoods __attribute__((swift_name("trainM(samples:probs0:logLikelihoods:)")));
		[Export ("trainM:probs0:logLikelihoods:")]
		bool TrainM (Mat samples, Mat probs0, Mat logLikelihoods);

		// -(BOOL)trainM:(Mat * _Nonnull)samples probs0:(Mat * _Nonnull)probs0 __attribute__((swift_name("trainM(samples:probs0:)")));
		[Export ("trainM:probs0:")]
		bool TrainM (Mat samples, Mat probs0);

		// +(EM * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		EM Create ();

		// +(EM * _Nonnull)load:(NSString * _Nonnull)filepath nodeName:(NSString * _Nonnull)nodeName __attribute__((swift_name("load(filepath:nodeName:)")));
		[Static]
		[Export ("load:nodeName:")]
		EM Load (string filepath, string nodeName);

		// +(EM * _Nonnull)load:(NSString * _Nonnull)filepath __attribute__((swift_name("load(filepath:)")));
		[Static]
		[Export ("load:")]
		EM Load (string filepath);
	}

	// @interface KNearest : StatModel
	[BaseType (typeof(StatModel))]
	interface KNearest
	{
		// -(int)getDefaultK __attribute__((swift_name("getDefaultK()")));
		[Export ("getDefaultK")]
		int DefaultK { get; }

		// -(void)setDefaultK:(int)val __attribute__((swift_name("setDefaultK(val:)")));
		[Export ("setDefaultK:")]
		void SetDefaultK (int val);

		// -(BOOL)getIsClassifier __attribute__((swift_name("getIsClassifier()")));
		[Export ("getIsClassifier")]
		bool IsClassifier { get; }

		// -(void)setIsClassifier:(BOOL)val __attribute__((swift_name("setIsClassifier(val:)")));
		[Export ("setIsClassifier:")]
		void SetIsClassifier (bool val);

		// -(int)getEmax __attribute__((swift_name("getEmax()")));
		[Export ("getEmax")]
		int Emax { get; }

		// -(void)setEmax:(int)val __attribute__((swift_name("setEmax(val:)")));
		[Export ("setEmax:")]
		void SetEmax (int val);

		// -(int)getAlgorithmType __attribute__((swift_name("getAlgorithmType()")));
		[Export ("getAlgorithmType")]
		int AlgorithmType { get; }

		// -(void)setAlgorithmType:(int)val __attribute__((swift_name("setAlgorithmType(val:)")));
		[Export ("setAlgorithmType:")]
		void SetAlgorithmType (int val);

		// -(float)findNearest:(Mat * _Nonnull)samples k:(int)k results:(Mat * _Nonnull)results neighborResponses:(Mat * _Nonnull)neighborResponses dist:(Mat * _Nonnull)dist __attribute__((swift_name("findNearest(samples:k:results:neighborResponses:dist:)")));
		[Export ("findNearest:k:results:neighborResponses:dist:")]
		float FindNearest (Mat samples, int k, Mat results, Mat neighborResponses, Mat dist);

		// -(float)findNearest:(Mat * _Nonnull)samples k:(int)k results:(Mat * _Nonnull)results neighborResponses:(Mat * _Nonnull)neighborResponses __attribute__((swift_name("findNearest(samples:k:results:neighborResponses:)")));
		[Export ("findNearest:k:results:neighborResponses:")]
		float FindNearest (Mat samples, int k, Mat results, Mat neighborResponses);

		// -(float)findNearest:(Mat * _Nonnull)samples k:(int)k results:(Mat * _Nonnull)results __attribute__((swift_name("findNearest(samples:k:results:)")));
		[Export ("findNearest:k:results:")]
		float FindNearest (Mat samples, int k, Mat results);

		// +(KNearest * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		KNearest Create ();

		// +(KNearest * _Nonnull)load:(NSString * _Nonnull)filepath __attribute__((swift_name("load(filepath:)")));
		[Static]
		[Export ("load:")]
		KNearest Load (string filepath);
	}

	// @interface LogisticRegression : StatModel
	[BaseType (typeof(StatModel))]
	interface LogisticRegression
	{
		// -(double)getLearningRate __attribute__((swift_name("getLearningRate()")));
		[Export ("getLearningRate")]
		double LearningRate { get; }

		// -(void)setLearningRate:(double)val __attribute__((swift_name("setLearningRate(val:)")));
		[Export ("setLearningRate:")]
		void SetLearningRate (double val);

		// -(int)getIterations __attribute__((swift_name("getIterations()")));
		[Export ("getIterations")]
		int Iterations { get; }

		// -(void)setIterations:(int)val __attribute__((swift_name("setIterations(val:)")));
		[Export ("setIterations:")]
		void SetIterations (int val);

		// -(int)getRegularization __attribute__((swift_name("getRegularization()")));
		[Export ("getRegularization")]
		int Regularization { get; }

		// -(void)setRegularization:(int)val __attribute__((swift_name("setRegularization(val:)")));
		[Export ("setRegularization:")]
		void SetRegularization (int val);

		// -(int)getTrainMethod __attribute__((swift_name("getTrainMethod()")));
		[Export ("getTrainMethod")]
		int TrainMethod { get; }

		// -(void)setTrainMethod:(int)val __attribute__((swift_name("setTrainMethod(val:)")));
		[Export ("setTrainMethod:")]
		void SetTrainMethod (int val);

		// -(int)getMiniBatchSize __attribute__((swift_name("getMiniBatchSize()")));
		[Export ("getMiniBatchSize")]
		int MiniBatchSize { get; }

		// -(void)setMiniBatchSize:(int)val __attribute__((swift_name("setMiniBatchSize(val:)")));
		[Export ("setMiniBatchSize:")]
		void SetMiniBatchSize (int val);

		// -(TermCriteria * _Nonnull)getTermCriteria __attribute__((swift_name("getTermCriteria()")));
		[Export ("getTermCriteria")]
		TermCriteria TermCriteria { get; }

		// -(void)setTermCriteria:(TermCriteria * _Nonnull)val __attribute__((swift_name("setTermCriteria(val:)")));
		[Export ("setTermCriteria:")]
		void SetTermCriteria (TermCriteria val);

		// -(float)predict:(Mat * _Nonnull)samples results:(Mat * _Nonnull)results flags:(int)flags __attribute__((swift_name("predict(samples:results:flags:)")));
		[Export ("predict:results:flags:")]
		float Predict (Mat samples, Mat results, int flags);

		// -(float)predict:(Mat * _Nonnull)samples results:(Mat * _Nonnull)results __attribute__((swift_name("predict(samples:results:)")));
		[Export ("predict:results:")]
		float Predict (Mat samples, Mat results);

		// -(float)predict:(Mat * _Nonnull)samples __attribute__((swift_name("predict(samples:)")));
		[Export ("predict:")]
		float Predict (Mat samples);

		// -(Mat * _Nonnull)get_learnt_thetas __attribute__((swift_name("get_learnt_thetas()")));
		[Export ("get_learnt_thetas")]
		Mat Get_learnt_thetas { get; }

		// +(LogisticRegression * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		LogisticRegression Create ();

		// +(LogisticRegression * _Nonnull)load:(NSString * _Nonnull)filepath nodeName:(NSString * _Nonnull)nodeName __attribute__((swift_name("load(filepath:nodeName:)")));
		[Static]
		[Export ("load:nodeName:")]
		LogisticRegression Load (string filepath, string nodeName);

		// +(LogisticRegression * _Nonnull)load:(NSString * _Nonnull)filepath __attribute__((swift_name("load(filepath:)")));
		[Static]
		[Export ("load:")]
		LogisticRegression Load (string filepath);
	}

	// @interface NormalBayesClassifier : StatModel
	[BaseType (typeof(StatModel))]
	interface NormalBayesClassifier
	{
		// -(float)predictProb:(Mat * _Nonnull)inputs outputs:(Mat * _Nonnull)outputs outputProbs:(Mat * _Nonnull)outputProbs flags:(int)flags __attribute__((swift_name("predictProb(inputs:outputs:outputProbs:flags:)")));
		[Export ("predictProb:outputs:outputProbs:flags:")]
		float PredictProb (Mat inputs, Mat outputs, Mat outputProbs, int flags);

		// -(float)predictProb:(Mat * _Nonnull)inputs outputs:(Mat * _Nonnull)outputs outputProbs:(Mat * _Nonnull)outputProbs __attribute__((swift_name("predictProb(inputs:outputs:outputProbs:)")));
		[Export ("predictProb:outputs:outputProbs:")]
		float PredictProb (Mat inputs, Mat outputs, Mat outputProbs);

		// +(NormalBayesClassifier * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		NormalBayesClassifier Create ();

		// +(NormalBayesClassifier * _Nonnull)load:(NSString * _Nonnull)filepath nodeName:(NSString * _Nonnull)nodeName __attribute__((swift_name("load(filepath:nodeName:)")));
		[Static]
		[Export ("load:nodeName:")]
		NormalBayesClassifier Load (string filepath, string nodeName);

		// +(NormalBayesClassifier * _Nonnull)load:(NSString * _Nonnull)filepath __attribute__((swift_name("load(filepath:)")));
		[Static]
		[Export ("load:")]
		NormalBayesClassifier Load (string filepath);
	}

	// @interface ParamGrid : NSObject
	[BaseType (typeof(NSObject))]
	interface ParamGrid
	{
		// +(ParamGrid * _Nonnull)create:(double)minVal maxVal:(double)maxVal logstep:(double)logstep __attribute__((swift_name("create(minVal:maxVal:logstep:)")));
		[Static]
		[Export ("create:maxVal:logstep:")]
		ParamGrid Create (double minVal, double maxVal, double logstep);

		// +(ParamGrid * _Nonnull)create:(double)minVal maxVal:(double)maxVal __attribute__((swift_name("create(minVal:maxVal:)")));
		[Static]
		[Export ("create:maxVal:")]
		ParamGrid Create (double minVal, double maxVal);

		// +(ParamGrid * _Nonnull)create:(double)minVal __attribute__((swift_name("create(minVal:)")));
		[Static]
		[Export ("create:")]
		ParamGrid Create (double minVal);

		// +(ParamGrid * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		ParamGrid Create ();

		// @property double minVal;
		[Export ("minVal")]
		double MinVal { get; set; }

		// @property double maxVal;
		[Export ("maxVal")]
		double MaxVal { get; set; }

		// @property double logStep;
		[Export ("logStep")]
		double LogStep { get; set; }
	}

	// @interface RTrees : DTrees
	[BaseType (typeof(DTrees))]
	interface RTrees
	{
		// -(BOOL)getCalculateVarImportance __attribute__((swift_name("getCalculateVarImportance()")));
		[Export ("getCalculateVarImportance")]
		bool CalculateVarImportance { get; }

		// -(void)setCalculateVarImportance:(BOOL)val __attribute__((swift_name("setCalculateVarImportance(val:)")));
		[Export ("setCalculateVarImportance:")]
		void SetCalculateVarImportance (bool val);

		// -(int)getActiveVarCount __attribute__((swift_name("getActiveVarCount()")));
		[Export ("getActiveVarCount")]
		int ActiveVarCount { get; }

		// -(void)setActiveVarCount:(int)val __attribute__((swift_name("setActiveVarCount(val:)")));
		[Export ("setActiveVarCount:")]
		void SetActiveVarCount (int val);

		// -(TermCriteria * _Nonnull)getTermCriteria __attribute__((swift_name("getTermCriteria()")));
		[Export ("getTermCriteria")]
		TermCriteria TermCriteria { get; }

		// -(void)setTermCriteria:(TermCriteria * _Nonnull)val __attribute__((swift_name("setTermCriteria(val:)")));
		[Export ("setTermCriteria:")]
		void SetTermCriteria (TermCriteria val);

		// -(Mat * _Nonnull)getVarImportance __attribute__((swift_name("getVarImportance()")));
		[Export ("getVarImportance")]
		Mat VarImportance { get; }

		// -(void)getVotes:(Mat * _Nonnull)samples results:(Mat * _Nonnull)results flags:(int)flags __attribute__((swift_name("getVotes(samples:results:flags:)")));
		[Export ("getVotes:results:flags:")]
		void GetVotes (Mat samples, Mat results, int flags);

		// -(double)getOOBError __attribute__((swift_name("getOOBError()")));
		[Export ("getOOBError")]
		double OOBError { get; }

		// +(RTrees * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		RTrees Create ();

		// +(RTrees * _Nonnull)load:(NSString * _Nonnull)filepath nodeName:(NSString * _Nonnull)nodeName __attribute__((swift_name("load(filepath:nodeName:)")));
		[Static]
		[Export ("load:nodeName:")]
		RTrees Load (string filepath, string nodeName);

		// +(RTrees * _Nonnull)load:(NSString * _Nonnull)filepath __attribute__((swift_name("load(filepath:)")));
		[Static]
		[Export ("load:")]
		RTrees Load (string filepath);
	}

	// @interface SVM : StatModel
	[BaseType (typeof(StatModel))]
	interface SVM
	{
		// -(int)getType __attribute__((swift_name("getType()")));
		[Export ("getType")]
		int Type { get; }

		// -(void)setType:(int)val __attribute__((swift_name("setType(val:)")));
		[Export ("setType:")]
		void SetType (int val);

		// -(double)getGamma __attribute__((swift_name("getGamma()")));
		[Export ("getGamma")]
		double Gamma { get; }

		// -(void)setGamma:(double)val __attribute__((swift_name("setGamma(val:)")));
		[Export ("setGamma:")]
		void SetGamma (double val);

		// -(double)getCoef0 __attribute__((swift_name("getCoef0()")));
		[Export ("getCoef0")]
		double Coef0 { get; }

		// -(void)setCoef0:(double)val __attribute__((swift_name("setCoef0(val:)")));
		[Export ("setCoef0:")]
		void SetCoef0 (double val);

		// -(double)getDegree __attribute__((swift_name("getDegree()")));
		[Export ("getDegree")]
		double Degree { get; }

		// -(void)setDegree:(double)val __attribute__((swift_name("setDegree(val:)")));
		[Export ("setDegree:")]
		void SetDegree (double val);

		// -(double)getC __attribute__((swift_name("getC()")));
		[Export ("getC")]
		double C { get; }

		// -(void)setC:(double)val __attribute__((swift_name("setC(val:)")));
		[Export ("setC:")]
		void SetC (double val);

		// -(double)getNu __attribute__((swift_name("getNu()")));
		[Export ("getNu")]
		double Nu { get; }

		// -(void)setNu:(double)val __attribute__((swift_name("setNu(val:)")));
		[Export ("setNu:")]
		void SetNu (double val);

		// -(double)getP __attribute__((swift_name("getP()")));
		[Export ("getP")]
		double P { get; }

		// -(void)setP:(double)val __attribute__((swift_name("setP(val:)")));
		[Export ("setP:")]
		void SetP (double val);

		// -(Mat * _Nonnull)getClassWeights __attribute__((swift_name("getClassWeights()")));
		[Export ("getClassWeights")]
		Mat ClassWeights { get; }

		// -(void)setClassWeights:(Mat * _Nonnull)val __attribute__((swift_name("setClassWeights(val:)")));
		[Export ("setClassWeights:")]
		void SetClassWeights (Mat val);

		// -(TermCriteria * _Nonnull)getTermCriteria __attribute__((swift_name("getTermCriteria()")));
		[Export ("getTermCriteria")]
		TermCriteria TermCriteria { get; }

		// -(void)setTermCriteria:(TermCriteria * _Nonnull)val __attribute__((swift_name("setTermCriteria(val:)")));
		[Export ("setTermCriteria:")]
		void SetTermCriteria (TermCriteria val);

		// -(int)getKernelType __attribute__((swift_name("getKernelType()")));
		[Export ("getKernelType")]
		int KernelType { get; }

		// -(void)setKernel:(int)kernelType __attribute__((swift_name("setKernel(kernelType:)")));
		[Export ("setKernel:")]
		void SetKernel (int kernelType);

		// -(BOOL)trainAuto:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses kFold:(int)kFold Cgrid:(ParamGrid * _Nonnull)Cgrid gammaGrid:(ParamGrid * _Nonnull)gammaGrid pGrid:(ParamGrid * _Nonnull)pGrid nuGrid:(ParamGrid * _Nonnull)nuGrid coeffGrid:(ParamGrid * _Nonnull)coeffGrid degreeGrid:(ParamGrid * _Nonnull)degreeGrid balanced:(BOOL)balanced __attribute__((swift_name("trainAuto(samples:layout:responses:kFold:Cgrid:gammaGrid:pGrid:nuGrid:coeffGrid:degreeGrid:balanced:)")));
		[Export ("trainAuto:layout:responses:kFold:Cgrid:gammaGrid:pGrid:nuGrid:coeffGrid:degreeGrid:balanced:")]
		bool TrainAuto (Mat samples, int layout, Mat responses, int kFold, ParamGrid Cgrid, ParamGrid gammaGrid, ParamGrid pGrid, ParamGrid nuGrid, ParamGrid coeffGrid, ParamGrid degreeGrid, bool balanced);

		// -(BOOL)trainAuto:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses kFold:(int)kFold Cgrid:(ParamGrid * _Nonnull)Cgrid gammaGrid:(ParamGrid * _Nonnull)gammaGrid pGrid:(ParamGrid * _Nonnull)pGrid nuGrid:(ParamGrid * _Nonnull)nuGrid coeffGrid:(ParamGrid * _Nonnull)coeffGrid degreeGrid:(ParamGrid * _Nonnull)degreeGrid __attribute__((swift_name("trainAuto(samples:layout:responses:kFold:Cgrid:gammaGrid:pGrid:nuGrid:coeffGrid:degreeGrid:)")));
		[Export ("trainAuto:layout:responses:kFold:Cgrid:gammaGrid:pGrid:nuGrid:coeffGrid:degreeGrid:")]
		bool TrainAuto (Mat samples, int layout, Mat responses, int kFold, ParamGrid Cgrid, ParamGrid gammaGrid, ParamGrid pGrid, ParamGrid nuGrid, ParamGrid coeffGrid, ParamGrid degreeGrid);

		// -(BOOL)trainAuto:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses kFold:(int)kFold Cgrid:(ParamGrid * _Nonnull)Cgrid gammaGrid:(ParamGrid * _Nonnull)gammaGrid pGrid:(ParamGrid * _Nonnull)pGrid nuGrid:(ParamGrid * _Nonnull)nuGrid coeffGrid:(ParamGrid * _Nonnull)coeffGrid __attribute__((swift_name("trainAuto(samples:layout:responses:kFold:Cgrid:gammaGrid:pGrid:nuGrid:coeffGrid:)")));
		[Export ("trainAuto:layout:responses:kFold:Cgrid:gammaGrid:pGrid:nuGrid:coeffGrid:")]
		bool TrainAuto (Mat samples, int layout, Mat responses, int kFold, ParamGrid Cgrid, ParamGrid gammaGrid, ParamGrid pGrid, ParamGrid nuGrid, ParamGrid coeffGrid);

		// -(BOOL)trainAuto:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses kFold:(int)kFold Cgrid:(ParamGrid * _Nonnull)Cgrid gammaGrid:(ParamGrid * _Nonnull)gammaGrid pGrid:(ParamGrid * _Nonnull)pGrid nuGrid:(ParamGrid * _Nonnull)nuGrid __attribute__((swift_name("trainAuto(samples:layout:responses:kFold:Cgrid:gammaGrid:pGrid:nuGrid:)")));
		[Export ("trainAuto:layout:responses:kFold:Cgrid:gammaGrid:pGrid:nuGrid:")]
		bool TrainAuto (Mat samples, int layout, Mat responses, int kFold, ParamGrid Cgrid, ParamGrid gammaGrid, ParamGrid pGrid, ParamGrid nuGrid);

		// -(BOOL)trainAuto:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses kFold:(int)kFold Cgrid:(ParamGrid * _Nonnull)Cgrid gammaGrid:(ParamGrid * _Nonnull)gammaGrid pGrid:(ParamGrid * _Nonnull)pGrid __attribute__((swift_name("trainAuto(samples:layout:responses:kFold:Cgrid:gammaGrid:pGrid:)")));
		[Export ("trainAuto:layout:responses:kFold:Cgrid:gammaGrid:pGrid:")]
		bool TrainAuto (Mat samples, int layout, Mat responses, int kFold, ParamGrid Cgrid, ParamGrid gammaGrid, ParamGrid pGrid);

		// -(BOOL)trainAuto:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses kFold:(int)kFold Cgrid:(ParamGrid * _Nonnull)Cgrid gammaGrid:(ParamGrid * _Nonnull)gammaGrid __attribute__((swift_name("trainAuto(samples:layout:responses:kFold:Cgrid:gammaGrid:)")));
		[Export ("trainAuto:layout:responses:kFold:Cgrid:gammaGrid:")]
		bool TrainAuto (Mat samples, int layout, Mat responses, int kFold, ParamGrid Cgrid, ParamGrid gammaGrid);

		// -(BOOL)trainAuto:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses kFold:(int)kFold Cgrid:(ParamGrid * _Nonnull)Cgrid __attribute__((swift_name("trainAuto(samples:layout:responses:kFold:Cgrid:)")));
		[Export ("trainAuto:layout:responses:kFold:Cgrid:")]
		bool TrainAuto (Mat samples, int layout, Mat responses, int kFold, ParamGrid Cgrid);

		// -(BOOL)trainAuto:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses kFold:(int)kFold __attribute__((swift_name("trainAuto(samples:layout:responses:kFold:)")));
		[Export ("trainAuto:layout:responses:kFold:")]
		bool TrainAuto (Mat samples, int layout, Mat responses, int kFold);

		// -(BOOL)trainAuto:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses __attribute__((swift_name("trainAuto(samples:layout:responses:)")));
		[Export ("trainAuto:layout:responses:")]
		bool TrainAuto (Mat samples, int layout, Mat responses);

		// -(Mat * _Nonnull)getSupportVectors __attribute__((swift_name("getSupportVectors()")));
		[Export ("getSupportVectors")]
		Mat SupportVectors { get; }

		// -(Mat * _Nonnull)getUncompressedSupportVectors __attribute__((swift_name("getUncompressedSupportVectors()")));
		[Export ("getUncompressedSupportVectors")]
		Mat UncompressedSupportVectors { get; }

		// -(double)getDecisionFunction:(int)i alpha:(Mat * _Nonnull)alpha svidx:(Mat * _Nonnull)svidx __attribute__((swift_name("getDecisionFunction(i:alpha:svidx:)")));
		[Export ("getDecisionFunction:alpha:svidx:")]
		double GetDecisionFunction (int i, Mat alpha, Mat svidx);

		// +(ParamGrid * _Nonnull)getDefaultGridPtr:(int)param_id __attribute__((swift_name("getDefaultGridPtr(param_id:)")));
		[Static]
		[Export ("getDefaultGridPtr:")]
		ParamGrid GetDefaultGridPtr (int param_id);

		// +(SVM * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		SVM Create ();

		// +(SVM * _Nonnull)load:(NSString * _Nonnull)filepath __attribute__((swift_name("load(filepath:)")));
		[Static]
		[Export ("load:")]
		SVM Load (string filepath);
	}

	// @interface SVMSGD : StatModel
	[BaseType (typeof(StatModel))]
	interface SVMSGD
	{
		// -(Mat * _Nonnull)getWeights __attribute__((swift_name("getWeights()")));
		[Export ("getWeights")]
		Mat Weights { get; }

		// -(float)getShift __attribute__((swift_name("getShift()")));
		[Export ("getShift")]
		float Shift { get; }

		// +(SVMSGD * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		SVMSGD Create ();

		// +(SVMSGD * _Nonnull)load:(NSString * _Nonnull)filepath nodeName:(NSString * _Nonnull)nodeName __attribute__((swift_name("load(filepath:nodeName:)")));
		[Static]
		[Export ("load:nodeName:")]
		SVMSGD Load (string filepath, string nodeName);

		// +(SVMSGD * _Nonnull)load:(NSString * _Nonnull)filepath __attribute__((swift_name("load(filepath:)")));
		[Static]
		[Export ("load:")]
		SVMSGD Load (string filepath);

		// -(void)setOptimalParameters:(int)svmsgdType marginType:(int)marginType __attribute__((swift_name("setOptimalParameters(svmsgdType:marginType:)")));
		[Export ("setOptimalParameters:marginType:")]
		void SetOptimalParameters (int svmsgdType, int marginType);

		// -(void)setOptimalParameters:(int)svmsgdType __attribute__((swift_name("setOptimalParameters(svmsgdType:)")));
		[Export ("setOptimalParameters:")]
		void SetOptimalParameters (int svmsgdType);

		// -(void)setOptimalParameters __attribute__((swift_name("setOptimalParameters()")));
		[Export ("setOptimalParameters")]
		void SetOptimalParameters ();

		// -(int)getSvmsgdType __attribute__((swift_name("getSvmsgdType()")));
		[Export ("getSvmsgdType")]
		int SvmsgdType { get; }

		// -(void)setSvmsgdType:(int)svmsgdType __attribute__((swift_name("setSvmsgdType(svmsgdType:)")));
		[Export ("setSvmsgdType:")]
		void SetSvmsgdType (int svmsgdType);

		// -(int)getMarginType __attribute__((swift_name("getMarginType()")));
		[Export ("getMarginType")]
		int MarginType { get; }

		// -(void)setMarginType:(int)marginType __attribute__((swift_name("setMarginType(marginType:)")));
		[Export ("setMarginType:")]
		void SetMarginType (int marginType);

		// -(float)getMarginRegularization __attribute__((swift_name("getMarginRegularization()")));
		[Export ("getMarginRegularization")]
		float MarginRegularization { get; }

		// -(void)setMarginRegularization:(float)marginRegularization __attribute__((swift_name("setMarginRegularization(marginRegularization:)")));
		[Export ("setMarginRegularization:")]
		void SetMarginRegularization (float marginRegularization);

		// -(float)getInitialStepSize __attribute__((swift_name("getInitialStepSize()")));
		[Export ("getInitialStepSize")]
		float InitialStepSize { get; }

		// -(void)setInitialStepSize:(float)InitialStepSize __attribute__((swift_name("setInitialStepSize(InitialStepSize:)")));
		[Export ("setInitialStepSize:")]
		void SetInitialStepSize (float InitialStepSize);

		// -(float)getStepDecreasingPower __attribute__((swift_name("getStepDecreasingPower()")));
		[Export ("getStepDecreasingPower")]
		float StepDecreasingPower { get; }

		// -(void)setStepDecreasingPower:(float)stepDecreasingPower __attribute__((swift_name("setStepDecreasingPower(stepDecreasingPower:)")));
		[Export ("setStepDecreasingPower:")]
		void SetStepDecreasingPower (float stepDecreasingPower);

		// -(TermCriteria * _Nonnull)getTermCriteria __attribute__((swift_name("getTermCriteria()")));
		[Export ("getTermCriteria")]
		TermCriteria TermCriteria { get; }

		// -(void)setTermCriteria:(TermCriteria * _Nonnull)val __attribute__((swift_name("setTermCriteria(val:)")));
		[Export ("setTermCriteria:")]
		void SetTermCriteria (TermCriteria val);
	}

	// @interface TrainData : NSObject
	[BaseType (typeof(NSObject))]
	interface TrainData
	{
		// -(int)getLayout __attribute__((swift_name("getLayout()")));
		[Export ("getLayout")]
		int Layout { get; }

		// -(int)getNTrainSamples __attribute__((swift_name("getNTrainSamples()")));
		[Export ("getNTrainSamples")]
		int NTrainSamples { get; }

		// -(int)getNTestSamples __attribute__((swift_name("getNTestSamples()")));
		[Export ("getNTestSamples")]
		int NTestSamples { get; }

		// -(int)getNSamples __attribute__((swift_name("getNSamples()")));
		[Export ("getNSamples")]
		int NSamples { get; }

		// -(int)getNVars __attribute__((swift_name("getNVars()")));
		[Export ("getNVars")]
		int NVars { get; }

		// -(int)getNAllVars __attribute__((swift_name("getNAllVars()")));
		[Export ("getNAllVars")]
		int NAllVars { get; }

		// -(void)getSample:(Mat * _Nonnull)varIdx sidx:(int)sidx buf:(float)buf __attribute__((swift_name("getSample(varIdx:sidx:buf:)")));
		[Export ("getSample:sidx:buf:")]
		void GetSample (Mat varIdx, int sidx, float buf);

		// -(Mat * _Nonnull)getSamples __attribute__((swift_name("getSamples()")));
		[Export ("getSamples")]
		Mat Samples { get; }

		// -(Mat * _Nonnull)getMissing __attribute__((swift_name("getMissing()")));
		[Export ("getMissing")]
		Mat Missing { get; }

		// -(Mat * _Nonnull)getTrainSamples:(int)layout compressSamples:(BOOL)compressSamples compressVars:(BOOL)compressVars __attribute__((swift_name("getTrainSamples(layout:compressSamples:compressVars:)")));
		[Export ("getTrainSamples:compressSamples:compressVars:")]
		Mat GetTrainSamples (int layout, bool compressSamples, bool compressVars);

		// -(Mat * _Nonnull)getTrainSamples:(int)layout compressSamples:(BOOL)compressSamples __attribute__((swift_name("getTrainSamples(layout:compressSamples:)")));
		[Export ("getTrainSamples:compressSamples:")]
		Mat GetTrainSamples (int layout, bool compressSamples);

		// -(Mat * _Nonnull)getTrainSamples:(int)layout __attribute__((swift_name("getTrainSamples(layout:)")));
		[Export ("getTrainSamples:")]
		Mat GetTrainSamples (int layout);

		// -(Mat * _Nonnull)getTrainSamples __attribute__((swift_name("getTrainSamples()")));
		[Export ("getTrainSamples")]
		Mat TrainSamples { get; }

		// -(Mat * _Nonnull)getTrainResponses __attribute__((swift_name("getTrainResponses()")));
		[Export ("getTrainResponses")]
		Mat TrainResponses { get; }

		// -(Mat * _Nonnull)getTrainNormCatResponses __attribute__((swift_name("getTrainNormCatResponses()")));
		[Export ("getTrainNormCatResponses")]
		Mat TrainNormCatResponses { get; }

		// -(Mat * _Nonnull)getTestResponses __attribute__((swift_name("getTestResponses()")));
		[Export ("getTestResponses")]
		Mat TestResponses { get; }

		// -(Mat * _Nonnull)getTestNormCatResponses __attribute__((swift_name("getTestNormCatResponses()")));
		[Export ("getTestNormCatResponses")]
		Mat TestNormCatResponses { get; }

		// -(Mat * _Nonnull)getResponses __attribute__((swift_name("getResponses()")));
		[Export ("getResponses")]
		Mat Responses { get; }

		// -(Mat * _Nonnull)getNormCatResponses __attribute__((swift_name("getNormCatResponses()")));
		[Export ("getNormCatResponses")]
		Mat NormCatResponses { get; }

		// -(Mat * _Nonnull)getSampleWeights __attribute__((swift_name("getSampleWeights()")));
		[Export ("getSampleWeights")]
		Mat SampleWeights { get; }

		// -(Mat * _Nonnull)getTrainSampleWeights __attribute__((swift_name("getTrainSampleWeights()")));
		[Export ("getTrainSampleWeights")]
		Mat TrainSampleWeights { get; }

		// -(Mat * _Nonnull)getTestSampleWeights __attribute__((swift_name("getTestSampleWeights()")));
		[Export ("getTestSampleWeights")]
		Mat TestSampleWeights { get; }

		// -(Mat * _Nonnull)getVarIdx __attribute__((swift_name("getVarIdx()")));
		[Export ("getVarIdx")]
		Mat VarIdx { get; }

		// -(Mat * _Nonnull)getVarType __attribute__((swift_name("getVarType()")));
		[Export ("getVarType")]
		Mat VarType { get; }

		// -(Mat * _Nonnull)getVarSymbolFlags __attribute__((swift_name("getVarSymbolFlags()")));
		[Export ("getVarSymbolFlags")]
		Mat VarSymbolFlags { get; }

		// -(int)getResponseType __attribute__((swift_name("getResponseType()")));
		[Export ("getResponseType")]
		int ResponseType { get; }

		// -(Mat * _Nonnull)getTrainSampleIdx __attribute__((swift_name("getTrainSampleIdx()")));
		[Export ("getTrainSampleIdx")]
		Mat TrainSampleIdx { get; }

		// -(Mat * _Nonnull)getTestSampleIdx __attribute__((swift_name("getTestSampleIdx()")));
		[Export ("getTestSampleIdx")]
		Mat TestSampleIdx { get; }

		// -(void)getValues:(int)vi sidx:(Mat * _Nonnull)sidx values:(float)values __attribute__((swift_name("getValues(vi:sidx:values:)")));
		[Export ("getValues:sidx:values:")]
		void GetValues (int vi, Mat sidx, float values);

		// -(Mat * _Nonnull)getDefaultSubstValues __attribute__((swift_name("getDefaultSubstValues()")));
		[Export ("getDefaultSubstValues")]
		Mat DefaultSubstValues { get; }

		// -(int)getCatCount:(int)vi __attribute__((swift_name("getCatCount(vi:)")));
		[Export ("getCatCount:")]
		int GetCatCount (int vi);

		// -(Mat * _Nonnull)getClassLabels __attribute__((swift_name("getClassLabels()")));
		[Export ("getClassLabels")]
		Mat ClassLabels { get; }

		// -(Mat * _Nonnull)getCatOfs __attribute__((swift_name("getCatOfs()")));
		[Export ("getCatOfs")]
		Mat CatOfs { get; }

		// -(Mat * _Nonnull)getCatMap __attribute__((swift_name("getCatMap()")));
		[Export ("getCatMap")]
		Mat CatMap { get; }

		// -(void)setTrainTestSplit:(int)count shuffle:(BOOL)shuffle __attribute__((swift_name("setTrainTestSplit(count:shuffle:)")));
		[Export ("setTrainTestSplit:shuffle:")]
		void SetTrainTestSplit (int count, bool shuffle);

		// -(void)setTrainTestSplit:(int)count __attribute__((swift_name("setTrainTestSplit(count:)")));
		[Export ("setTrainTestSplit:")]
		void SetTrainTestSplit (int count);

		// -(void)setTrainTestSplitRatio:(double)ratio shuffle:(BOOL)shuffle __attribute__((swift_name("setTrainTestSplitRatio(ratio:shuffle:)")));
		[Export ("setTrainTestSplitRatio:shuffle:")]
		void SetTrainTestSplitRatio (double ratio, bool shuffle);

		// -(void)setTrainTestSplitRatio:(double)ratio __attribute__((swift_name("setTrainTestSplitRatio(ratio:)")));
		[Export ("setTrainTestSplitRatio:")]
		void SetTrainTestSplitRatio (double ratio);

		// -(void)shuffleTrainTest __attribute__((swift_name("shuffleTrainTest()")));
		[Export ("shuffleTrainTest")]
		void ShuffleTrainTest ();

		// -(Mat * _Nonnull)getTestSamples __attribute__((swift_name("getTestSamples()")));
		[Export ("getTestSamples")]
		Mat TestSamples { get; }

		// -(void)getNames:(NSArray<NSString *> * _Nonnull)names __attribute__((swift_name("getNames(names:)")));
		[Export ("getNames:")]
		void GetNames (string[] names);

		// +(Mat * _Nonnull)getSubVector:(Mat * _Nonnull)vec idx:(Mat * _Nonnull)idx __attribute__((swift_name("getSubVector(vec:idx:)")));
		[Static]
		[Export ("getSubVector:idx:")]
		Mat GetSubVector (Mat vec, Mat idx);

		// +(Mat * _Nonnull)getSubMatrix:(Mat * _Nonnull)matrix idx:(Mat * _Nonnull)idx layout:(int)layout __attribute__((swift_name("getSubMatrix(matrix:idx:layout:)")));
		[Static]
		[Export ("getSubMatrix:idx:layout:")]
		Mat GetSubMatrix (Mat matrix, Mat idx, int layout);

		// +(TrainData * _Nonnull)create:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses varIdx:(Mat * _Nonnull)varIdx sampleIdx:(Mat * _Nonnull)sampleIdx sampleWeights:(Mat * _Nonnull)sampleWeights varType:(Mat * _Nonnull)varType __attribute__((swift_name("create(samples:layout:responses:varIdx:sampleIdx:sampleWeights:varType:)")));
		[Static]
		[Export ("create:layout:responses:varIdx:sampleIdx:sampleWeights:varType:")]
		TrainData Create (Mat samples, int layout, Mat responses, Mat varIdx, Mat sampleIdx, Mat sampleWeights, Mat varType);

		// +(TrainData * _Nonnull)create:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses varIdx:(Mat * _Nonnull)varIdx sampleIdx:(Mat * _Nonnull)sampleIdx sampleWeights:(Mat * _Nonnull)sampleWeights __attribute__((swift_name("create(samples:layout:responses:varIdx:sampleIdx:sampleWeights:)")));
		[Static]
		[Export ("create:layout:responses:varIdx:sampleIdx:sampleWeights:")]
		TrainData Create (Mat samples, int layout, Mat responses, Mat varIdx, Mat sampleIdx, Mat sampleWeights);

		// +(TrainData * _Nonnull)create:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses varIdx:(Mat * _Nonnull)varIdx sampleIdx:(Mat * _Nonnull)sampleIdx __attribute__((swift_name("create(samples:layout:responses:varIdx:sampleIdx:)")));
		[Static]
		[Export ("create:layout:responses:varIdx:sampleIdx:")]
		TrainData Create (Mat samples, int layout, Mat responses, Mat varIdx, Mat sampleIdx);

		// +(TrainData * _Nonnull)create:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses varIdx:(Mat * _Nonnull)varIdx __attribute__((swift_name("create(samples:layout:responses:varIdx:)")));
		[Static]
		[Export ("create:layout:responses:varIdx:")]
		TrainData Create (Mat samples, int layout, Mat responses, Mat varIdx);

		// +(TrainData * _Nonnull)create:(Mat * _Nonnull)samples layout:(int)layout responses:(Mat * _Nonnull)responses __attribute__((swift_name("create(samples:layout:responses:)")));
		[Static]
		[Export ("create:layout:responses:")]
		TrainData Create (Mat samples, int layout, Mat responses);
	}

	// @interface Photo : NSObject
	[BaseType (typeof(NSObject))]
	interface Photo
	{
		// @property (readonly, class) int INPAINT_NS __attribute__((swift_name("INPAINT_NS")));
		[Static]
		[Export ("INPAINT_NS")]
		int INPAINT_NS { get; }

		// @property (readonly, class) int INPAINT_TELEA __attribute__((swift_name("INPAINT_TELEA")));
		[Static]
		[Export ("INPAINT_TELEA")]
		int INPAINT_TELEA { get; }

		// @property (readonly, class) int LDR_SIZE __attribute__((swift_name("LDR_SIZE")));
		[Static]
		[Export ("LDR_SIZE")]
		int LDR_SIZE { get; }

		// @property (readonly, class) int RECURS_FILTER __attribute__((swift_name("RECURS_FILTER")));
		[Static]
		[Export ("RECURS_FILTER")]
		int RECURS_FILTER { get; }

		// @property (readonly, class) int NORMCONV_FILTER __attribute__((swift_name("NORMCONV_FILTER")));
		[Static]
		[Export ("NORMCONV_FILTER")]
		int NORMCONV_FILTER { get; }

		// +(void)inpaint:(Mat * _Nonnull)src inpaintMask:(Mat * _Nonnull)inpaintMask dst:(Mat * _Nonnull)dst inpaintRadius:(double)inpaintRadius flags:(int)flags __attribute__((swift_name("inpaint(src:inpaintMask:dst:inpaintRadius:flags:)")));
		[Static]
		[Export ("inpaint:inpaintMask:dst:inpaintRadius:flags:")]
		void Inpaint (Mat src, Mat inpaintMask, Mat dst, double inpaintRadius, int flags);

		// +(void)fastNlMeansDenoising:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize __attribute__((swift_name("fastNlMeansDenoising(src:dst:h:templateWindowSize:searchWindowSize:)")));
		[Static]
		[Export ("fastNlMeansDenoising:dst:h:templateWindowSize:searchWindowSize:")]
		void FastNlMeansDenoising (Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize);

		// +(void)fastNlMeansDenoising:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst h:(float)h templateWindowSize:(int)templateWindowSize __attribute__((swift_name("fastNlMeansDenoising(src:dst:h:templateWindowSize:)")));
		[Static]
		[Export ("fastNlMeansDenoising:dst:h:templateWindowSize:")]
		void FastNlMeansDenoising (Mat src, Mat dst, float h, int templateWindowSize);

		// +(void)fastNlMeansDenoising:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst h:(float)h __attribute__((swift_name("fastNlMeansDenoising(src:dst:h:)")));
		[Static]
		[Export ("fastNlMeansDenoising:dst:h:")]
		void FastNlMeansDenoising (Mat src, Mat dst, float h);

		// +(void)fastNlMeansDenoising:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("fastNlMeansDenoising(src:dst:)")));
		[Static]
		[Export ("fastNlMeansDenoising:dst:")]
		void FastNlMeansDenoising (Mat src, Mat dst);

		// +(void)fastNlMeansDenoising:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst hVector:(FloatVector * _Nonnull)hVector templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize normType:(int)normType __attribute__((swift_name("fastNlMeansDenoising(src:dst:hVector:templateWindowSize:searchWindowSize:normType:)")));
		[Static]
		[Export ("fastNlMeansDenoising:dst:hVector:templateWindowSize:searchWindowSize:normType:")]
		void FastNlMeansDenoising (Mat src, Mat dst, FloatVector hVector, int templateWindowSize, int searchWindowSize, int normType);

		// +(void)fastNlMeansDenoising:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst hVector:(FloatVector * _Nonnull)hVector templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize __attribute__((swift_name("fastNlMeansDenoising(src:dst:hVector:templateWindowSize:searchWindowSize:)")));
		[Static]
		[Export ("fastNlMeansDenoising:dst:hVector:templateWindowSize:searchWindowSize:")]
		void FastNlMeansDenoising (Mat src, Mat dst, FloatVector hVector, int templateWindowSize, int searchWindowSize);

		// +(void)fastNlMeansDenoising:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst hVector:(FloatVector * _Nonnull)hVector templateWindowSize:(int)templateWindowSize __attribute__((swift_name("fastNlMeansDenoising(src:dst:hVector:templateWindowSize:)")));
		[Static]
		[Export ("fastNlMeansDenoising:dst:hVector:templateWindowSize:")]
		void FastNlMeansDenoising (Mat src, Mat dst, FloatVector hVector, int templateWindowSize);

		// +(void)fastNlMeansDenoising:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst hVector:(FloatVector * _Nonnull)hVector __attribute__((swift_name("fastNlMeansDenoising(src:dst:hVector:)")));
		[Static]
		[Export ("fastNlMeansDenoising:dst:hVector:")]
		void FastNlMeansDenoising (Mat src, Mat dst, FloatVector hVector);

		// +(void)fastNlMeansDenoisingColored:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst h:(float)h hColor:(float)hColor templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize __attribute__((swift_name("fastNlMeansDenoisingColored(src:dst:h:hColor:templateWindowSize:searchWindowSize:)")));
		[Static]
		[Export ("fastNlMeansDenoisingColored:dst:h:hColor:templateWindowSize:searchWindowSize:")]
		void FastNlMeansDenoisingColored (Mat src, Mat dst, float h, float hColor, int templateWindowSize, int searchWindowSize);

		// +(void)fastNlMeansDenoisingColored:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst h:(float)h hColor:(float)hColor templateWindowSize:(int)templateWindowSize __attribute__((swift_name("fastNlMeansDenoisingColored(src:dst:h:hColor:templateWindowSize:)")));
		[Static]
		[Export ("fastNlMeansDenoisingColored:dst:h:hColor:templateWindowSize:")]
		void FastNlMeansDenoisingColored (Mat src, Mat dst, float h, float hColor, int templateWindowSize);

		// +(void)fastNlMeansDenoisingColored:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst h:(float)h hColor:(float)hColor __attribute__((swift_name("fastNlMeansDenoisingColored(src:dst:h:hColor:)")));
		[Static]
		[Export ("fastNlMeansDenoisingColored:dst:h:hColor:")]
		void FastNlMeansDenoisingColored (Mat src, Mat dst, float h, float hColor);

		// +(void)fastNlMeansDenoisingColored:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst h:(float)h __attribute__((swift_name("fastNlMeansDenoisingColored(src:dst:h:)")));
		[Static]
		[Export ("fastNlMeansDenoisingColored:dst:h:")]
		void FastNlMeansDenoisingColored (Mat src, Mat dst, float h);

		// +(void)fastNlMeansDenoisingColored:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("fastNlMeansDenoisingColored(src:dst:)")));
		[Static]
		[Export ("fastNlMeansDenoisingColored:dst:")]
		void FastNlMeansDenoisingColored (Mat src, Mat dst);

		// +(void)fastNlMeansDenoisingMulti:(NSArray<Mat *> * _Nonnull)srcImgs dst:(Mat * _Nonnull)dst imgToDenoiseIndex:(int)imgToDenoiseIndex temporalWindowSize:(int)temporalWindowSize h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize __attribute__((swift_name("fastNlMeansDenoisingMulti(srcImgs:dst:imgToDenoiseIndex:temporalWindowSize:h:templateWindowSize:searchWindowSize:)")));
		[Static]
		[Export ("fastNlMeansDenoisingMulti:dst:imgToDenoiseIndex:temporalWindowSize:h:templateWindowSize:searchWindowSize:")]
		void FastNlMeansDenoisingMulti (Mat[] srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, int templateWindowSize, int searchWindowSize);

		// +(void)fastNlMeansDenoisingMulti:(NSArray<Mat *> * _Nonnull)srcImgs dst:(Mat * _Nonnull)dst imgToDenoiseIndex:(int)imgToDenoiseIndex temporalWindowSize:(int)temporalWindowSize h:(float)h templateWindowSize:(int)templateWindowSize __attribute__((swift_name("fastNlMeansDenoisingMulti(srcImgs:dst:imgToDenoiseIndex:temporalWindowSize:h:templateWindowSize:)")));
		[Static]
		[Export ("fastNlMeansDenoisingMulti:dst:imgToDenoiseIndex:temporalWindowSize:h:templateWindowSize:")]
		void FastNlMeansDenoisingMulti (Mat[] srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, int templateWindowSize);

		// +(void)fastNlMeansDenoisingMulti:(NSArray<Mat *> * _Nonnull)srcImgs dst:(Mat * _Nonnull)dst imgToDenoiseIndex:(int)imgToDenoiseIndex temporalWindowSize:(int)temporalWindowSize h:(float)h __attribute__((swift_name("fastNlMeansDenoisingMulti(srcImgs:dst:imgToDenoiseIndex:temporalWindowSize:h:)")));
		[Static]
		[Export ("fastNlMeansDenoisingMulti:dst:imgToDenoiseIndex:temporalWindowSize:h:")]
		void FastNlMeansDenoisingMulti (Mat[] srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h);

		// +(void)fastNlMeansDenoisingMulti:(NSArray<Mat *> * _Nonnull)srcImgs dst:(Mat * _Nonnull)dst imgToDenoiseIndex:(int)imgToDenoiseIndex temporalWindowSize:(int)temporalWindowSize __attribute__((swift_name("fastNlMeansDenoisingMulti(srcImgs:dst:imgToDenoiseIndex:temporalWindowSize:)")));
		[Static]
		[Export ("fastNlMeansDenoisingMulti:dst:imgToDenoiseIndex:temporalWindowSize:")]
		void FastNlMeansDenoisingMulti (Mat[] srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize);

		// +(void)fastNlMeansDenoisingMulti:(NSArray<Mat *> * _Nonnull)srcImgs dst:(Mat * _Nonnull)dst imgToDenoiseIndex:(int)imgToDenoiseIndex temporalWindowSize:(int)temporalWindowSize hVector:(FloatVector * _Nonnull)hVector templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize normType:(int)normType __attribute__((swift_name("fastNlMeansDenoisingMulti(srcImgs:dst:imgToDenoiseIndex:temporalWindowSize:hVector:templateWindowSize:searchWindowSize:normType:)")));
		[Static]
		[Export ("fastNlMeansDenoisingMulti:dst:imgToDenoiseIndex:temporalWindowSize:hVector:templateWindowSize:searchWindowSize:normType:")]
		void FastNlMeansDenoisingMulti (Mat[] srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, FloatVector hVector, int templateWindowSize, int searchWindowSize, int normType);

		// +(void)fastNlMeansDenoisingMulti:(NSArray<Mat *> * _Nonnull)srcImgs dst:(Mat * _Nonnull)dst imgToDenoiseIndex:(int)imgToDenoiseIndex temporalWindowSize:(int)temporalWindowSize hVector:(FloatVector * _Nonnull)hVector templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize __attribute__((swift_name("fastNlMeansDenoisingMulti(srcImgs:dst:imgToDenoiseIndex:temporalWindowSize:hVector:templateWindowSize:searchWindowSize:)")));
		[Static]
		[Export ("fastNlMeansDenoisingMulti:dst:imgToDenoiseIndex:temporalWindowSize:hVector:templateWindowSize:searchWindowSize:")]
		void FastNlMeansDenoisingMulti (Mat[] srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, FloatVector hVector, int templateWindowSize, int searchWindowSize);

		// +(void)fastNlMeansDenoisingMulti:(NSArray<Mat *> * _Nonnull)srcImgs dst:(Mat * _Nonnull)dst imgToDenoiseIndex:(int)imgToDenoiseIndex temporalWindowSize:(int)temporalWindowSize hVector:(FloatVector * _Nonnull)hVector templateWindowSize:(int)templateWindowSize __attribute__((swift_name("fastNlMeansDenoisingMulti(srcImgs:dst:imgToDenoiseIndex:temporalWindowSize:hVector:templateWindowSize:)")));
		[Static]
		[Export ("fastNlMeansDenoisingMulti:dst:imgToDenoiseIndex:temporalWindowSize:hVector:templateWindowSize:")]
		void FastNlMeansDenoisingMulti (Mat[] srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, FloatVector hVector, int templateWindowSize);

		// +(void)fastNlMeansDenoisingMulti:(NSArray<Mat *> * _Nonnull)srcImgs dst:(Mat * _Nonnull)dst imgToDenoiseIndex:(int)imgToDenoiseIndex temporalWindowSize:(int)temporalWindowSize hVector:(FloatVector * _Nonnull)hVector __attribute__((swift_name("fastNlMeansDenoisingMulti(srcImgs:dst:imgToDenoiseIndex:temporalWindowSize:hVector:)")));
		[Static]
		[Export ("fastNlMeansDenoisingMulti:dst:imgToDenoiseIndex:temporalWindowSize:hVector:")]
		void FastNlMeansDenoisingMulti (Mat[] srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, FloatVector hVector);

		// +(void)fastNlMeansDenoisingColoredMulti:(NSArray<Mat *> * _Nonnull)srcImgs dst:(Mat * _Nonnull)dst imgToDenoiseIndex:(int)imgToDenoiseIndex temporalWindowSize:(int)temporalWindowSize h:(float)h hColor:(float)hColor templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize __attribute__((swift_name("fastNlMeansDenoisingColoredMulti(srcImgs:dst:imgToDenoiseIndex:temporalWindowSize:h:hColor:templateWindowSize:searchWindowSize:)")));
		[Static]
		[Export ("fastNlMeansDenoisingColoredMulti:dst:imgToDenoiseIndex:temporalWindowSize:h:hColor:templateWindowSize:searchWindowSize:")]
		void FastNlMeansDenoisingColoredMulti (Mat[] srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor, int templateWindowSize, int searchWindowSize);

		// +(void)fastNlMeansDenoisingColoredMulti:(NSArray<Mat *> * _Nonnull)srcImgs dst:(Mat * _Nonnull)dst imgToDenoiseIndex:(int)imgToDenoiseIndex temporalWindowSize:(int)temporalWindowSize h:(float)h hColor:(float)hColor templateWindowSize:(int)templateWindowSize __attribute__((swift_name("fastNlMeansDenoisingColoredMulti(srcImgs:dst:imgToDenoiseIndex:temporalWindowSize:h:hColor:templateWindowSize:)")));
		[Static]
		[Export ("fastNlMeansDenoisingColoredMulti:dst:imgToDenoiseIndex:temporalWindowSize:h:hColor:templateWindowSize:")]
		void FastNlMeansDenoisingColoredMulti (Mat[] srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor, int templateWindowSize);

		// +(void)fastNlMeansDenoisingColoredMulti:(NSArray<Mat *> * _Nonnull)srcImgs dst:(Mat * _Nonnull)dst imgToDenoiseIndex:(int)imgToDenoiseIndex temporalWindowSize:(int)temporalWindowSize h:(float)h hColor:(float)hColor __attribute__((swift_name("fastNlMeansDenoisingColoredMulti(srcImgs:dst:imgToDenoiseIndex:temporalWindowSize:h:hColor:)")));
		[Static]
		[Export ("fastNlMeansDenoisingColoredMulti:dst:imgToDenoiseIndex:temporalWindowSize:h:hColor:")]
		void FastNlMeansDenoisingColoredMulti (Mat[] srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor);

		// +(void)fastNlMeansDenoisingColoredMulti:(NSArray<Mat *> * _Nonnull)srcImgs dst:(Mat * _Nonnull)dst imgToDenoiseIndex:(int)imgToDenoiseIndex temporalWindowSize:(int)temporalWindowSize h:(float)h __attribute__((swift_name("fastNlMeansDenoisingColoredMulti(srcImgs:dst:imgToDenoiseIndex:temporalWindowSize:h:)")));
		[Static]
		[Export ("fastNlMeansDenoisingColoredMulti:dst:imgToDenoiseIndex:temporalWindowSize:h:")]
		void FastNlMeansDenoisingColoredMulti (Mat[] srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h);

		// +(void)fastNlMeansDenoisingColoredMulti:(NSArray<Mat *> * _Nonnull)srcImgs dst:(Mat * _Nonnull)dst imgToDenoiseIndex:(int)imgToDenoiseIndex temporalWindowSize:(int)temporalWindowSize __attribute__((swift_name("fastNlMeansDenoisingColoredMulti(srcImgs:dst:imgToDenoiseIndex:temporalWindowSize:)")));
		[Static]
		[Export ("fastNlMeansDenoisingColoredMulti:dst:imgToDenoiseIndex:temporalWindowSize:")]
		void FastNlMeansDenoisingColoredMulti (Mat[] srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize);

		// +(void)denoise_TVL1:(NSArray<Mat *> * _Nonnull)observations result:(Mat * _Nonnull)result lambda:(double)lambda niters:(int)niters __attribute__((swift_name("denoise_TVL1(observations:result:lambda:niters:)")));
		[Static]
		[Export ("denoise_TVL1:result:lambda:niters:")]
		void Denoise_TVL1 (Mat[] observations, Mat result, double lambda, int niters);

		// +(void)denoise_TVL1:(NSArray<Mat *> * _Nonnull)observations result:(Mat * _Nonnull)result lambda:(double)lambda __attribute__((swift_name("denoise_TVL1(observations:result:lambda:)")));
		[Static]
		[Export ("denoise_TVL1:result:lambda:")]
		void Denoise_TVL1 (Mat[] observations, Mat result, double lambda);

		// +(void)denoise_TVL1:(NSArray<Mat *> * _Nonnull)observations result:(Mat * _Nonnull)result __attribute__((swift_name("denoise_TVL1(observations:result:)")));
		[Static]
		[Export ("denoise_TVL1:result:")]
		void Denoise_TVL1 (Mat[] observations, Mat result);

		// +(Tonemap * _Nonnull)createTonemap:(float)gamma __attribute__((swift_name("createTonemap(gamma:)")));
		[Static]
		[Export ("createTonemap:")]
		Tonemap CreateTonemap (float gamma);

		// +(Tonemap * _Nonnull)createTonemap __attribute__((swift_name("createTonemap()")));
		[Static]
		[Export ("createTonemap")]
		Tonemap CreateTonemap ();

		// +(TonemapDrago * _Nonnull)createTonemapDrago:(float)gamma saturation:(float)saturation bias:(float)bias __attribute__((swift_name("createTonemapDrago(gamma:saturation:bias:)")));
		[Static]
		[Export ("createTonemapDrago:saturation:bias:")]
		TonemapDrago CreateTonemapDrago (float gamma, float saturation, float bias);

		// +(TonemapDrago * _Nonnull)createTonemapDrago:(float)gamma saturation:(float)saturation __attribute__((swift_name("createTonemapDrago(gamma:saturation:)")));
		[Static]
		[Export ("createTonemapDrago:saturation:")]
		TonemapDrago CreateTonemapDrago (float gamma, float saturation);

		// +(TonemapDrago * _Nonnull)createTonemapDrago:(float)gamma __attribute__((swift_name("createTonemapDrago(gamma:)")));
		[Static]
		[Export ("createTonemapDrago:")]
		TonemapDrago CreateTonemapDrago (float gamma);

		// +(TonemapDrago * _Nonnull)createTonemapDrago __attribute__((swift_name("createTonemapDrago()")));
		[Static]
		[Export ("createTonemapDrago")]
		TonemapDrago CreateTonemapDrago ();

		// +(TonemapReinhard * _Nonnull)createTonemapReinhard:(float)gamma intensity:(float)intensity light_adapt:(float)light_adapt color_adapt:(float)color_adapt __attribute__((swift_name("createTonemapReinhard(gamma:intensity:light_adapt:color_adapt:)")));
		[Static]
		[Export ("createTonemapReinhard:intensity:light_adapt:color_adapt:")]
		TonemapReinhard CreateTonemapReinhard (float gamma, float intensity, float light_adapt, float color_adapt);

		// +(TonemapReinhard * _Nonnull)createTonemapReinhard:(float)gamma intensity:(float)intensity light_adapt:(float)light_adapt __attribute__((swift_name("createTonemapReinhard(gamma:intensity:light_adapt:)")));
		[Static]
		[Export ("createTonemapReinhard:intensity:light_adapt:")]
		TonemapReinhard CreateTonemapReinhard (float gamma, float intensity, float light_adapt);

		// +(TonemapReinhard * _Nonnull)createTonemapReinhard:(float)gamma intensity:(float)intensity __attribute__((swift_name("createTonemapReinhard(gamma:intensity:)")));
		[Static]
		[Export ("createTonemapReinhard:intensity:")]
		TonemapReinhard CreateTonemapReinhard (float gamma, float intensity);

		// +(TonemapReinhard * _Nonnull)createTonemapReinhard:(float)gamma __attribute__((swift_name("createTonemapReinhard(gamma:)")));
		[Static]
		[Export ("createTonemapReinhard:")]
		TonemapReinhard CreateTonemapReinhard (float gamma);

		// +(TonemapReinhard * _Nonnull)createTonemapReinhard __attribute__((swift_name("createTonemapReinhard()")));
		[Static]
		[Export ("createTonemapReinhard")]
		TonemapReinhard CreateTonemapReinhard ();

		// +(TonemapMantiuk * _Nonnull)createTonemapMantiuk:(float)gamma scale:(float)scale saturation:(float)saturation __attribute__((swift_name("createTonemapMantiuk(gamma:scale:saturation:)")));
		[Static]
		[Export ("createTonemapMantiuk:scale:saturation:")]
		TonemapMantiuk CreateTonemapMantiuk (float gamma, float scale, float saturation);

		// +(TonemapMantiuk * _Nonnull)createTonemapMantiuk:(float)gamma scale:(float)scale __attribute__((swift_name("createTonemapMantiuk(gamma:scale:)")));
		[Static]
		[Export ("createTonemapMantiuk:scale:")]
		TonemapMantiuk CreateTonemapMantiuk (float gamma, float scale);

		// +(TonemapMantiuk * _Nonnull)createTonemapMantiuk:(float)gamma __attribute__((swift_name("createTonemapMantiuk(gamma:)")));
		[Static]
		[Export ("createTonemapMantiuk:")]
		TonemapMantiuk CreateTonemapMantiuk (float gamma);

		// +(TonemapMantiuk * _Nonnull)createTonemapMantiuk __attribute__((swift_name("createTonemapMantiuk()")));
		[Static]
		[Export ("createTonemapMantiuk")]
		TonemapMantiuk CreateTonemapMantiuk ();

		// +(AlignMTB * _Nonnull)createAlignMTB:(int)max_bits exclude_range:(int)exclude_range cut:(BOOL)cut __attribute__((swift_name("createAlignMTB(max_bits:exclude_range:cut:)")));
		[Static]
		[Export ("createAlignMTB:exclude_range:cut:")]
		AlignMTB CreateAlignMTB (int max_bits, int exclude_range, bool cut);

		// +(AlignMTB * _Nonnull)createAlignMTB:(int)max_bits exclude_range:(int)exclude_range __attribute__((swift_name("createAlignMTB(max_bits:exclude_range:)")));
		[Static]
		[Export ("createAlignMTB:exclude_range:")]
		AlignMTB CreateAlignMTB (int max_bits, int exclude_range);

		// +(AlignMTB * _Nonnull)createAlignMTB:(int)max_bits __attribute__((swift_name("createAlignMTB(max_bits:)")));
		[Static]
		[Export ("createAlignMTB:")]
		AlignMTB CreateAlignMTB (int max_bits);

		// +(AlignMTB * _Nonnull)createAlignMTB __attribute__((swift_name("createAlignMTB()")));
		[Static]
		[Export ("createAlignMTB")]
		AlignMTB CreateAlignMTB ();

		// +(CalibrateDebevec * _Nonnull)createCalibrateDebevec:(int)samples lambda:(float)lambda random:(BOOL)random __attribute__((swift_name("createCalibrateDebevec(samples:lambda:random:)")));
		[Static]
		[Export ("createCalibrateDebevec:lambda:random:")]
		CalibrateDebevec CreateCalibrateDebevec (int samples, float lambda, bool random);

		// +(CalibrateDebevec * _Nonnull)createCalibrateDebevec:(int)samples lambda:(float)lambda __attribute__((swift_name("createCalibrateDebevec(samples:lambda:)")));
		[Static]
		[Export ("createCalibrateDebevec:lambda:")]
		CalibrateDebevec CreateCalibrateDebevec (int samples, float lambda);

		// +(CalibrateDebevec * _Nonnull)createCalibrateDebevec:(int)samples __attribute__((swift_name("createCalibrateDebevec(samples:)")));
		[Static]
		[Export ("createCalibrateDebevec:")]
		CalibrateDebevec CreateCalibrateDebevec (int samples);

		// +(CalibrateDebevec * _Nonnull)createCalibrateDebevec __attribute__((swift_name("createCalibrateDebevec()")));
		[Static]
		[Export ("createCalibrateDebevec")]
		CalibrateDebevec CreateCalibrateDebevec ();

		// +(CalibrateRobertson * _Nonnull)createCalibrateRobertson:(int)max_iter threshold:(float)threshold __attribute__((swift_name("createCalibrateRobertson(max_iter:threshold:)")));
		[Static]
		[Export ("createCalibrateRobertson:threshold:")]
		CalibrateRobertson CreateCalibrateRobertson (int max_iter, float threshold);

		// +(CalibrateRobertson * _Nonnull)createCalibrateRobertson:(int)max_iter __attribute__((swift_name("createCalibrateRobertson(max_iter:)")));
		[Static]
		[Export ("createCalibrateRobertson:")]
		CalibrateRobertson CreateCalibrateRobertson (int max_iter);

		// +(CalibrateRobertson * _Nonnull)createCalibrateRobertson __attribute__((swift_name("createCalibrateRobertson()")));
		[Static]
		[Export ("createCalibrateRobertson")]
		CalibrateRobertson CreateCalibrateRobertson ();

		// +(MergeDebevec * _Nonnull)createMergeDebevec __attribute__((swift_name("createMergeDebevec()")));
		[Static]
		[Export ("createMergeDebevec")]
		MergeDebevec CreateMergeDebevec ();

		// +(MergeMertens * _Nonnull)createMergeMertens:(float)contrast_weight saturation_weight:(float)saturation_weight exposure_weight:(float)exposure_weight __attribute__((swift_name("createMergeMertens(contrast_weight:saturation_weight:exposure_weight:)")));
		[Static]
		[Export ("createMergeMertens:saturation_weight:exposure_weight:")]
		MergeMertens CreateMergeMertens (float contrast_weight, float saturation_weight, float exposure_weight);

		// +(MergeMertens * _Nonnull)createMergeMertens:(float)contrast_weight saturation_weight:(float)saturation_weight __attribute__((swift_name("createMergeMertens(contrast_weight:saturation_weight:)")));
		[Static]
		[Export ("createMergeMertens:saturation_weight:")]
		MergeMertens CreateMergeMertens (float contrast_weight, float saturation_weight);

		// +(MergeMertens * _Nonnull)createMergeMertens:(float)contrast_weight __attribute__((swift_name("createMergeMertens(contrast_weight:)")));
		[Static]
		[Export ("createMergeMertens:")]
		MergeMertens CreateMergeMertens (float contrast_weight);

		// +(MergeMertens * _Nonnull)createMergeMertens __attribute__((swift_name("createMergeMertens()")));
		[Static]
		[Export ("createMergeMertens")]
		MergeMertens CreateMergeMertens ();

		// +(MergeRobertson * _Nonnull)createMergeRobertson __attribute__((swift_name("createMergeRobertson()")));
		[Static]
		[Export ("createMergeRobertson")]
		MergeRobertson CreateMergeRobertson ();

		// +(void)decolor:(Mat * _Nonnull)src grayscale:(Mat * _Nonnull)grayscale color_boost:(Mat * _Nonnull)color_boost __attribute__((swift_name("decolor(src:grayscale:color_boost:)")));
		[Static]
		[Export ("decolor:grayscale:color_boost:")]
		void Decolor (Mat src, Mat grayscale, Mat color_boost);

		// +(void)seamlessClone:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst mask:(Mat * _Nonnull)mask p:(Point2i * _Nonnull)p blend:(Mat * _Nonnull)blend flags:(int)flags __attribute__((swift_name("seamlessClone(src:dst:mask:p:blend:flags:)")));
		[Static]
		[Export ("seamlessClone:dst:mask:p:blend:flags:")]
		void SeamlessClone (Mat src, Mat dst, Mat mask, Point2i p, Mat blend, int flags);

		// +(void)colorChange:(Mat * _Nonnull)src mask:(Mat * _Nonnull)mask dst:(Mat * _Nonnull)dst red_mul:(float)red_mul green_mul:(float)green_mul blue_mul:(float)blue_mul __attribute__((swift_name("colorChange(src:mask:dst:red_mul:green_mul:blue_mul:)")));
		[Static]
		[Export ("colorChange:mask:dst:red_mul:green_mul:blue_mul:")]
		void ColorChange (Mat src, Mat mask, Mat dst, float red_mul, float green_mul, float blue_mul);

		// +(void)colorChange:(Mat * _Nonnull)src mask:(Mat * _Nonnull)mask dst:(Mat * _Nonnull)dst red_mul:(float)red_mul green_mul:(float)green_mul __attribute__((swift_name("colorChange(src:mask:dst:red_mul:green_mul:)")));
		[Static]
		[Export ("colorChange:mask:dst:red_mul:green_mul:")]
		void ColorChange (Mat src, Mat mask, Mat dst, float red_mul, float green_mul);

		// +(void)colorChange:(Mat * _Nonnull)src mask:(Mat * _Nonnull)mask dst:(Mat * _Nonnull)dst red_mul:(float)red_mul __attribute__((swift_name("colorChange(src:mask:dst:red_mul:)")));
		[Static]
		[Export ("colorChange:mask:dst:red_mul:")]
		void ColorChange (Mat src, Mat mask, Mat dst, float red_mul);

		// +(void)colorChange:(Mat * _Nonnull)src mask:(Mat * _Nonnull)mask dst:(Mat * _Nonnull)dst __attribute__((swift_name("colorChange(src:mask:dst:)")));
		[Static]
		[Export ("colorChange:mask:dst:")]
		void ColorChange (Mat src, Mat mask, Mat dst);

		// +(void)illuminationChange:(Mat * _Nonnull)src mask:(Mat * _Nonnull)mask dst:(Mat * _Nonnull)dst alpha:(float)alpha beta:(float)beta __attribute__((swift_name("illuminationChange(src:mask:dst:alpha:beta:)")));
		[Static]
		[Export ("illuminationChange:mask:dst:alpha:beta:")]
		void IlluminationChange (Mat src, Mat mask, Mat dst, float alpha, float beta);

		// +(void)illuminationChange:(Mat * _Nonnull)src mask:(Mat * _Nonnull)mask dst:(Mat * _Nonnull)dst alpha:(float)alpha __attribute__((swift_name("illuminationChange(src:mask:dst:alpha:)")));
		[Static]
		[Export ("illuminationChange:mask:dst:alpha:")]
		void IlluminationChange (Mat src, Mat mask, Mat dst, float alpha);

		// +(void)illuminationChange:(Mat * _Nonnull)src mask:(Mat * _Nonnull)mask dst:(Mat * _Nonnull)dst __attribute__((swift_name("illuminationChange(src:mask:dst:)")));
		[Static]
		[Export ("illuminationChange:mask:dst:")]
		void IlluminationChange (Mat src, Mat mask, Mat dst);

		// +(void)textureFlattening:(Mat * _Nonnull)src mask:(Mat * _Nonnull)mask dst:(Mat * _Nonnull)dst low_threshold:(float)low_threshold high_threshold:(float)high_threshold kernel_size:(int)kernel_size __attribute__((swift_name("textureFlattening(src:mask:dst:low_threshold:high_threshold:kernel_size:)")));
		[Static]
		[Export ("textureFlattening:mask:dst:low_threshold:high_threshold:kernel_size:")]
		void TextureFlattening (Mat src, Mat mask, Mat dst, float low_threshold, float high_threshold, int kernel_size);

		// +(void)textureFlattening:(Mat * _Nonnull)src mask:(Mat * _Nonnull)mask dst:(Mat * _Nonnull)dst low_threshold:(float)low_threshold high_threshold:(float)high_threshold __attribute__((swift_name("textureFlattening(src:mask:dst:low_threshold:high_threshold:)")));
		[Static]
		[Export ("textureFlattening:mask:dst:low_threshold:high_threshold:")]
		void TextureFlattening (Mat src, Mat mask, Mat dst, float low_threshold, float high_threshold);

		// +(void)textureFlattening:(Mat * _Nonnull)src mask:(Mat * _Nonnull)mask dst:(Mat * _Nonnull)dst low_threshold:(float)low_threshold __attribute__((swift_name("textureFlattening(src:mask:dst:low_threshold:)")));
		[Static]
		[Export ("textureFlattening:mask:dst:low_threshold:")]
		void TextureFlattening (Mat src, Mat mask, Mat dst, float low_threshold);

		// +(void)textureFlattening:(Mat * _Nonnull)src mask:(Mat * _Nonnull)mask dst:(Mat * _Nonnull)dst __attribute__((swift_name("textureFlattening(src:mask:dst:)")));
		[Static]
		[Export ("textureFlattening:mask:dst:")]
		void TextureFlattening (Mat src, Mat mask, Mat dst);

		// +(void)edgePreservingFilter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst flags:(int)flags sigma_s:(float)sigma_s sigma_r:(float)sigma_r __attribute__((swift_name("edgePreservingFilter(src:dst:flags:sigma_s:sigma_r:)")));
		[Static]
		[Export ("edgePreservingFilter:dst:flags:sigma_s:sigma_r:")]
		void EdgePreservingFilter (Mat src, Mat dst, int flags, float sigma_s, float sigma_r);

		// +(void)edgePreservingFilter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst flags:(int)flags sigma_s:(float)sigma_s __attribute__((swift_name("edgePreservingFilter(src:dst:flags:sigma_s:)")));
		[Static]
		[Export ("edgePreservingFilter:dst:flags:sigma_s:")]
		void EdgePreservingFilter (Mat src, Mat dst, int flags, float sigma_s);

		// +(void)edgePreservingFilter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst flags:(int)flags __attribute__((swift_name("edgePreservingFilter(src:dst:flags:)")));
		[Static]
		[Export ("edgePreservingFilter:dst:flags:")]
		void EdgePreservingFilter (Mat src, Mat dst, int flags);

		// +(void)edgePreservingFilter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("edgePreservingFilter(src:dst:)")));
		[Static]
		[Export ("edgePreservingFilter:dst:")]
		void EdgePreservingFilter (Mat src, Mat dst);

		// +(void)detailEnhance:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst sigma_s:(float)sigma_s sigma_r:(float)sigma_r __attribute__((swift_name("detailEnhance(src:dst:sigma_s:sigma_r:)")));
		[Static]
		[Export ("detailEnhance:dst:sigma_s:sigma_r:")]
		void DetailEnhance (Mat src, Mat dst, float sigma_s, float sigma_r);

		// +(void)detailEnhance:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst sigma_s:(float)sigma_s __attribute__((swift_name("detailEnhance(src:dst:sigma_s:)")));
		[Static]
		[Export ("detailEnhance:dst:sigma_s:")]
		void DetailEnhance (Mat src, Mat dst, float sigma_s);

		// +(void)detailEnhance:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("detailEnhance(src:dst:)")));
		[Static]
		[Export ("detailEnhance:dst:")]
		void DetailEnhance (Mat src, Mat dst);

		// +(void)pencilSketch:(Mat * _Nonnull)src dst1:(Mat * _Nonnull)dst1 dst2:(Mat * _Nonnull)dst2 sigma_s:(float)sigma_s sigma_r:(float)sigma_r shade_factor:(float)shade_factor __attribute__((swift_name("pencilSketch(src:dst1:dst2:sigma_s:sigma_r:shade_factor:)")));
		[Static]
		[Export ("pencilSketch:dst1:dst2:sigma_s:sigma_r:shade_factor:")]
		void PencilSketch (Mat src, Mat dst1, Mat dst2, float sigma_s, float sigma_r, float shade_factor);

		// +(void)pencilSketch:(Mat * _Nonnull)src dst1:(Mat * _Nonnull)dst1 dst2:(Mat * _Nonnull)dst2 sigma_s:(float)sigma_s sigma_r:(float)sigma_r __attribute__((swift_name("pencilSketch(src:dst1:dst2:sigma_s:sigma_r:)")));
		[Static]
		[Export ("pencilSketch:dst1:dst2:sigma_s:sigma_r:")]
		void PencilSketch (Mat src, Mat dst1, Mat dst2, float sigma_s, float sigma_r);

		// +(void)pencilSketch:(Mat * _Nonnull)src dst1:(Mat * _Nonnull)dst1 dst2:(Mat * _Nonnull)dst2 sigma_s:(float)sigma_s __attribute__((swift_name("pencilSketch(src:dst1:dst2:sigma_s:)")));
		[Static]
		[Export ("pencilSketch:dst1:dst2:sigma_s:")]
		void PencilSketch (Mat src, Mat dst1, Mat dst2, float sigma_s);

		// +(void)pencilSketch:(Mat * _Nonnull)src dst1:(Mat * _Nonnull)dst1 dst2:(Mat * _Nonnull)dst2 __attribute__((swift_name("pencilSketch(src:dst1:dst2:)")));
		[Static]
		[Export ("pencilSketch:dst1:dst2:")]
		void PencilSketch (Mat src, Mat dst1, Mat dst2);

		// +(void)stylization:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst sigma_s:(float)sigma_s sigma_r:(float)sigma_r __attribute__((swift_name("stylization(src:dst:sigma_s:sigma_r:)")));
		[Static]
		[Export ("stylization:dst:sigma_s:sigma_r:")]
		void Stylization (Mat src, Mat dst, float sigma_s, float sigma_r);

		// +(void)stylization:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst sigma_s:(float)sigma_s __attribute__((swift_name("stylization(src:dst:sigma_s:)")));
		[Static]
		[Export ("stylization:dst:sigma_s:")]
		void Stylization (Mat src, Mat dst, float sigma_s);

		// +(void)stylization:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("stylization(src:dst:)")));
		[Static]
		[Export ("stylization:dst:")]
		void Stylization (Mat src, Mat dst);
	}

	// @interface AlignExposures : Algorithm
	[BaseType (typeof(Algorithm))]
	interface AlignExposures
	{
		// -(void)process:(NSArray<Mat *> * _Nonnull)src dst:(NSArray<Mat *> * _Nonnull)dst times:(Mat * _Nonnull)times response:(Mat * _Nonnull)response __attribute__((swift_name("process(src:dst:times:response:)")));
		[Export ("process:dst:times:response:")]
		void Process (Mat[] src, Mat[] dst, Mat times, Mat response);
	}

	// @interface AlignMTB : AlignExposures
	[BaseType (typeof(AlignExposures))]
	interface AlignMTB
	{
		// -(void)process:(NSArray<Mat *> * _Nonnull)src dst:(NSArray<Mat *> * _Nonnull)dst times:(Mat * _Nonnull)times response:(Mat * _Nonnull)response __attribute__((swift_name("process(src:dst:times:response:)")));
		[Export ("process:dst:times:response:")]
		void Process (Mat[] src, Mat[] dst, Mat times, Mat response);

		// -(void)process:(NSArray<Mat *> * _Nonnull)src dst:(NSArray<Mat *> * _Nonnull)dst __attribute__((swift_name("process(src:dst:)")));
		[Export ("process:dst:")]
		void Process (Mat[] src, Mat[] dst);

		// -(Point2i * _Nonnull)calculateShift:(Mat * _Nonnull)img0 img1:(Mat * _Nonnull)img1 __attribute__((swift_name("calculateShift(img0:img1:)")));
		[Export ("calculateShift:img1:")]
		Point2i CalculateShift (Mat img0, Mat img1);

		// -(void)shiftMat:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst shift:(Point2i * _Nonnull)shift __attribute__((swift_name("shiftMat(src:dst:shift:)")));
		[Export ("shiftMat:dst:shift:")]
		void ShiftMat (Mat src, Mat dst, Point2i shift);

		// -(void)computeBitmaps:(Mat * _Nonnull)img tb:(Mat * _Nonnull)tb eb:(Mat * _Nonnull)eb __attribute__((swift_name("computeBitmaps(img:tb:eb:)")));
		[Export ("computeBitmaps:tb:eb:")]
		void ComputeBitmaps (Mat img, Mat tb, Mat eb);

		// -(int)getMaxBits __attribute__((swift_name("getMaxBits()")));
		[Export ("getMaxBits")]
		int MaxBits { get; }

		// -(void)setMaxBits:(int)max_bits __attribute__((swift_name("setMaxBits(max_bits:)")));
		[Export ("setMaxBits:")]
		void SetMaxBits (int max_bits);

		// -(int)getExcludeRange __attribute__((swift_name("getExcludeRange()")));
		[Export ("getExcludeRange")]
		int ExcludeRange { get; }

		// -(void)setExcludeRange:(int)exclude_range __attribute__((swift_name("setExcludeRange(exclude_range:)")));
		[Export ("setExcludeRange:")]
		void SetExcludeRange (int exclude_range);

		// -(BOOL)getCut __attribute__((swift_name("getCut()")));
		[Export ("getCut")]
		bool Cut { get; }

		// -(void)setCut:(BOOL)value __attribute__((swift_name("setCut(value:)")));
		[Export ("setCut:")]
		void SetCut (bool value);
	}

	// @interface CalibrateCRF : Algorithm
	[BaseType (typeof(Algorithm))]
	interface CalibrateCRF
	{
		// -(void)process:(NSArray<Mat *> * _Nonnull)src dst:(Mat * _Nonnull)dst times:(Mat * _Nonnull)times __attribute__((swift_name("process(src:dst:times:)")));
		[Export ("process:dst:times:")]
		void Process (Mat[] src, Mat dst, Mat times);
	}

	// @interface CalibrateDebevec : CalibrateCRF
	[BaseType (typeof(CalibrateCRF))]
	interface CalibrateDebevec
	{
		// -(float)getLambda __attribute__((swift_name("getLambda()")));
		[Export ("getLambda")]
		float Lambda { get; }

		// -(void)setLambda:(float)lambda __attribute__((swift_name("setLambda(lambda:)")));
		[Export ("setLambda:")]
		void SetLambda (float lambda);

		// -(int)getSamples __attribute__((swift_name("getSamples()")));
		[Export ("getSamples")]
		int Samples { get; }

		// -(void)setSamples:(int)samples __attribute__((swift_name("setSamples(samples:)")));
		[Export ("setSamples:")]
		void SetSamples (int samples);

		// -(BOOL)getRandom __attribute__((swift_name("getRandom()")));
		[Export ("getRandom")]
		bool Random { get; }

		// -(void)setRandom:(BOOL)random __attribute__((swift_name("setRandom(random:)")));
		[Export ("setRandom:")]
		void SetRandom (bool random);
	}

	// @interface CalibrateRobertson : CalibrateCRF
	[BaseType (typeof(CalibrateCRF))]
	interface CalibrateRobertson
	{
		// -(int)getMaxIter __attribute__((swift_name("getMaxIter()")));
		[Export ("getMaxIter")]
		int MaxIter { get; }

		// -(void)setMaxIter:(int)max_iter __attribute__((swift_name("setMaxIter(max_iter:)")));
		[Export ("setMaxIter:")]
		void SetMaxIter (int max_iter);

		// -(float)getThreshold __attribute__((swift_name("getThreshold()")));
		[Export ("getThreshold")]
		float Threshold { get; }

		// -(void)setThreshold:(float)threshold __attribute__((swift_name("setThreshold(threshold:)")));
		[Export ("setThreshold:")]
		void SetThreshold (float threshold);

		// -(Mat * _Nonnull)getRadiance __attribute__((swift_name("getRadiance()")));
		[Export ("getRadiance")]
		Mat Radiance { get; }
	}

	// @interface MergeExposures : Algorithm
	[BaseType (typeof(Algorithm))]
	interface MergeExposures
	{
		// -(void)process:(NSArray<Mat *> * _Nonnull)src dst:(Mat * _Nonnull)dst times:(Mat * _Nonnull)times response:(Mat * _Nonnull)response __attribute__((swift_name("process(src:dst:times:response:)")));
		[Export ("process:dst:times:response:")]
		void Process (Mat[] src, Mat dst, Mat times, Mat response);
	}

	// @interface MergeDebevec : MergeExposures
	[BaseType (typeof(MergeExposures))]
	interface MergeDebevec
	{
		// -(void)process:(NSArray<Mat *> * _Nonnull)src dst:(Mat * _Nonnull)dst times:(Mat * _Nonnull)times response:(Mat * _Nonnull)response __attribute__((swift_name("process(src:dst:times:response:)")));
		[Export ("process:dst:times:response:")]
		void Process (Mat[] src, Mat dst, Mat times, Mat response);

		// -(void)process:(NSArray<Mat *> * _Nonnull)src dst:(Mat * _Nonnull)dst times:(Mat * _Nonnull)times __attribute__((swift_name("process(src:dst:times:)")));
		[Export ("process:dst:times:")]
		void Process (Mat[] src, Mat dst, Mat times);
	}

	// @interface MergeMertens : MergeExposures
	[BaseType (typeof(MergeExposures))]
	interface MergeMertens
	{
		// -(void)process:(NSArray<Mat *> * _Nonnull)src dst:(Mat * _Nonnull)dst times:(Mat * _Nonnull)times response:(Mat * _Nonnull)response __attribute__((swift_name("process(src:dst:times:response:)")));
		[Export ("process:dst:times:response:")]
		void Process (Mat[] src, Mat dst, Mat times, Mat response);

		// -(void)process:(NSArray<Mat *> * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("process(src:dst:)")));
		[Export ("process:dst:")]
		void Process (Mat[] src, Mat dst);

		// -(float)getContrastWeight __attribute__((swift_name("getContrastWeight()")));
		[Export ("getContrastWeight")]
		float ContrastWeight { get; }

		// -(void)setContrastWeight:(float)contrast_weiht __attribute__((swift_name("setContrastWeight(contrast_weiht:)")));
		[Export ("setContrastWeight:")]
		void SetContrastWeight (float contrast_weiht);

		// -(float)getSaturationWeight __attribute__((swift_name("getSaturationWeight()")));
		[Export ("getSaturationWeight")]
		float SaturationWeight { get; }

		// -(void)setSaturationWeight:(float)saturation_weight __attribute__((swift_name("setSaturationWeight(saturation_weight:)")));
		[Export ("setSaturationWeight:")]
		void SetSaturationWeight (float saturation_weight);

		// -(float)getExposureWeight __attribute__((swift_name("getExposureWeight()")));
		[Export ("getExposureWeight")]
		float ExposureWeight { get; }

		// -(void)setExposureWeight:(float)exposure_weight __attribute__((swift_name("setExposureWeight(exposure_weight:)")));
		[Export ("setExposureWeight:")]
		void SetExposureWeight (float exposure_weight);
	}

	// @interface MergeRobertson : MergeExposures
	[BaseType (typeof(MergeExposures))]
	interface MergeRobertson
	{
		// -(void)process:(NSArray<Mat *> * _Nonnull)src dst:(Mat * _Nonnull)dst times:(Mat * _Nonnull)times response:(Mat * _Nonnull)response __attribute__((swift_name("process(src:dst:times:response:)")));
		[Export ("process:dst:times:response:")]
		void Process (Mat[] src, Mat dst, Mat times, Mat response);

		// -(void)process:(NSArray<Mat *> * _Nonnull)src dst:(Mat * _Nonnull)dst times:(Mat * _Nonnull)times __attribute__((swift_name("process(src:dst:times:)")));
		[Export ("process:dst:times:")]
		void Process (Mat[] src, Mat dst, Mat times);
	}

	// @interface Tonemap : Algorithm
	[BaseType (typeof(Algorithm))]
	interface Tonemap
	{
		// -(void)process:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("process(src:dst:)")));
		[Export ("process:dst:")]
		void Process (Mat src, Mat dst);

		// -(float)getGamma __attribute__((swift_name("getGamma()")));
		[Export ("getGamma")]
		float Gamma { get; }

		// -(void)setGamma:(float)gamma __attribute__((swift_name("setGamma(gamma:)")));
		[Export ("setGamma:")]
		void SetGamma (float gamma);
	}

	// @interface TonemapDrago : Tonemap
	[BaseType (typeof(Tonemap))]
	interface TonemapDrago
	{
		// -(float)getSaturation __attribute__((swift_name("getSaturation()")));
		[Export ("getSaturation")]
		float Saturation { get; }

		// -(void)setSaturation:(float)saturation __attribute__((swift_name("setSaturation(saturation:)")));
		[Export ("setSaturation:")]
		void SetSaturation (float saturation);

		// -(float)getBias __attribute__((swift_name("getBias()")));
		[Export ("getBias")]
		float Bias { get; }

		// -(void)setBias:(float)bias __attribute__((swift_name("setBias(bias:)")));
		[Export ("setBias:")]
		void SetBias (float bias);
	}

	// @interface TonemapMantiuk : Tonemap
	[BaseType (typeof(Tonemap))]
	interface TonemapMantiuk
	{
		// -(float)getScale __attribute__((swift_name("getScale()")));
		[Export ("getScale")]
		float Scale { get; }

		// -(void)setScale:(float)scale __attribute__((swift_name("setScale(scale:)")));
		[Export ("setScale:")]
		void SetScale (float scale);

		// -(float)getSaturation __attribute__((swift_name("getSaturation()")));
		[Export ("getSaturation")]
		float Saturation { get; }

		// -(void)setSaturation:(float)saturation __attribute__((swift_name("setSaturation(saturation:)")));
		[Export ("setSaturation:")]
		void SetSaturation (float saturation);
	}

	// @interface TonemapReinhard : Tonemap
	[BaseType (typeof(Tonemap))]
	interface TonemapReinhard
	{
		// -(float)getIntensity __attribute__((swift_name("getIntensity()")));
		[Export ("getIntensity")]
		float Intensity { get; }

		// -(void)setIntensity:(float)intensity __attribute__((swift_name("setIntensity(intensity:)")));
		[Export ("setIntensity:")]
		void SetIntensity (float intensity);

		// -(float)getLightAdaptation __attribute__((swift_name("getLightAdaptation()")));
		[Export ("getLightAdaptation")]
		float LightAdaptation { get; }

		// -(void)setLightAdaptation:(float)light_adapt __attribute__((swift_name("setLightAdaptation(light_adapt:)")));
		[Export ("setLightAdaptation:")]
		void SetLightAdaptation (float light_adapt);

		// -(float)getColorAdaptation __attribute__((swift_name("getColorAdaptation()")));
		[Export ("getColorAdaptation")]
		float ColorAdaptation { get; }

		// -(void)setColorAdaptation:(float)color_adapt __attribute__((swift_name("setColorAdaptation(color_adapt:)")));
		[Export ("setColorAdaptation:")]
		void SetColorAdaptation (float color_adapt);
	}

	// @interface Dnn : NSObject
	[BaseType (typeof(NSObject))]
	interface Dnn
	{
		// +(Net * _Nonnull)readNetFromDarknetFile:(NSString * _Nonnull)cfgFile darknetModel:(NSString * _Nonnull)darknetModel __attribute__((swift_name("readNetFromDarknet(cfgFile:darknetModel:)")));
		[Static]
		[Export ("readNetFromDarknetFile:darknetModel:")]
		Net ReadNetFromDarknetFile (string cfgFile, string darknetModel);

		// +(Net * _Nonnull)readNetFromDarknetFile:(NSString * _Nonnull)cfgFile __attribute__((swift_name("readNetFromDarknet(cfgFile:)")));
		[Static]
		[Export ("readNetFromDarknetFile:")]
		Net ReadNetFromDarknetFile (string cfgFile);

		// +(Net * _Nonnull)readNetFromDarknetBuffer:(ByteVector * _Nonnull)bufferCfg bufferModel:(ByteVector * _Nonnull)bufferModel __attribute__((swift_name("readNetFromDarknet(bufferCfg:bufferModel:)")));
		[Static]
		[Export ("readNetFromDarknetBuffer:bufferModel:")]
		Net ReadNetFromDarknetBuffer (ByteVector bufferCfg, ByteVector bufferModel);

		// +(Net * _Nonnull)readNetFromDarknetBuffer:(ByteVector * _Nonnull)bufferCfg __attribute__((swift_name("readNetFromDarknet(bufferCfg:)")));
		[Static]
		[Export ("readNetFromDarknetBuffer:")]
		Net ReadNetFromDarknetBuffer (ByteVector bufferCfg);

		// +(Net * _Nonnull)readNetFromCaffeFile:(NSString * _Nonnull)prototxt caffeModel:(NSString * _Nonnull)caffeModel __attribute__((swift_name("readNetFromCaffe(prototxt:caffeModel:)")));
		[Static]
		[Export ("readNetFromCaffeFile:caffeModel:")]
		Net ReadNetFromCaffeFile (string prototxt, string caffeModel);

		// +(Net * _Nonnull)readNetFromCaffeFile:(NSString * _Nonnull)prototxt __attribute__((swift_name("readNetFromCaffe(prototxt:)")));
		[Static]
		[Export ("readNetFromCaffeFile:")]
		Net ReadNetFromCaffeFile (string prototxt);

		// +(Net * _Nonnull)readNetFromCaffeBuffer:(ByteVector * _Nonnull)bufferProto bufferModel:(ByteVector * _Nonnull)bufferModel __attribute__((swift_name("readNetFromCaffe(bufferProto:bufferModel:)")));
		[Static]
		[Export ("readNetFromCaffeBuffer:bufferModel:")]
		Net ReadNetFromCaffeBuffer (ByteVector bufferProto, ByteVector bufferModel);

		// +(Net * _Nonnull)readNetFromCaffeBuffer:(ByteVector * _Nonnull)bufferProto __attribute__((swift_name("readNetFromCaffe(bufferProto:)")));
		[Static]
		[Export ("readNetFromCaffeBuffer:")]
		Net ReadNetFromCaffeBuffer (ByteVector bufferProto);

		// +(Net * _Nonnull)readNetFromTensorflowFile:(NSString * _Nonnull)model config:(NSString * _Nonnull)config __attribute__((swift_name("readNetFromTensorflow(model:config:)")));
		[Static]
		[Export ("readNetFromTensorflowFile:config:")]
		Net ReadNetFromTensorflowFile (string model, string config);

		// +(Net * _Nonnull)readNetFromTensorflowFile:(NSString * _Nonnull)model __attribute__((swift_name("readNetFromTensorflow(model:)")));
		[Static]
		[Export ("readNetFromTensorflowFile:")]
		Net ReadNetFromTensorflowFile (string model);

		// +(Net * _Nonnull)readNetFromTensorflowBuffer:(ByteVector * _Nonnull)bufferModel bufferConfig:(ByteVector * _Nonnull)bufferConfig __attribute__((swift_name("readNetFromTensorflow(bufferModel:bufferConfig:)")));
		[Static]
		[Export ("readNetFromTensorflowBuffer:bufferConfig:")]
		Net ReadNetFromTensorflowBuffer (ByteVector bufferModel, ByteVector bufferConfig);

		// +(Net * _Nonnull)readNetFromTensorflowBuffer:(ByteVector * _Nonnull)bufferModel __attribute__((swift_name("readNetFromTensorflow(bufferModel:)")));
		[Static]
		[Export ("readNetFromTensorflowBuffer:")]
		Net ReadNetFromTensorflowBuffer (ByteVector bufferModel);

		// +(Net * _Nonnull)readNetFromTFLiteFile:(NSString * _Nonnull)model __attribute__((swift_name("readNetFromTFLite(model:)")));
		[Static]
		[Export ("readNetFromTFLiteFile:")]
		Net ReadNetFromTFLiteFile (string model);

		// +(Net * _Nonnull)readNetFromTFLite:(ByteVector * _Nonnull)bufferModel __attribute__((swift_name("readNetFromTFLite(bufferModel:)")));
		[Static]
		[Export ("readNetFromTFLite:")]
		Net ReadNetFromTFLite (ByteVector bufferModel);

		// +(Net * _Nonnull)readNetFromTorch:(NSString * _Nonnull)model isBinary:(BOOL)isBinary evaluate:(BOOL)evaluate __attribute__((swift_name("readNetFromTorch(model:isBinary:evaluate:)")));
		[Static]
		[Export ("readNetFromTorch:isBinary:evaluate:")]
		Net ReadNetFromTorch (string model, bool isBinary, bool evaluate);

		// +(Net * _Nonnull)readNetFromTorch:(NSString * _Nonnull)model isBinary:(BOOL)isBinary __attribute__((swift_name("readNetFromTorch(model:isBinary:)")));
		[Static]
		[Export ("readNetFromTorch:isBinary:")]
		Net ReadNetFromTorch (string model, bool isBinary);

		// +(Net * _Nonnull)readNetFromTorch:(NSString * _Nonnull)model __attribute__((swift_name("readNetFromTorch(model:)")));
		[Static]
		[Export ("readNetFromTorch:")]
		Net ReadNetFromTorch (string model);

		// +(Net * _Nonnull)readNet:(NSString * _Nonnull)model config:(NSString * _Nonnull)config framework:(NSString * _Nonnull)framework __attribute__((swift_name("readNet(model:config:framework:)")));
		[Static]
		[Export ("readNet:config:framework:")]
		Net ReadNet (string model, string config, string framework);

		// +(Net * _Nonnull)readNet:(NSString * _Nonnull)model config:(NSString * _Nonnull)config __attribute__((swift_name("readNet(model:config:)")));
		[Static]
		[Export ("readNet:config:")]
		Net ReadNet (string model, string config);

		// +(Net * _Nonnull)readNet:(NSString * _Nonnull)model __attribute__((swift_name("readNet(model:)")));
		[Static]
		[Export ("readNet:")]
		Net ReadNet (string model);

		// +(Net * _Nonnull)readNet:(NSString * _Nonnull)framework bufferModel:(ByteVector * _Nonnull)bufferModel bufferConfig:(ByteVector * _Nonnull)bufferConfig __attribute__((swift_name("readNet(framework:bufferModel:bufferConfig:)")));
		[Static]
		[Export ("readNet:bufferModel:bufferConfig:")]
		Net ReadNet (string framework, ByteVector bufferModel, ByteVector bufferConfig);

		// +(Net * _Nonnull)readNet:(NSString * _Nonnull)framework bufferModel:(ByteVector * _Nonnull)bufferModel __attribute__((swift_name("readNet(framework:bufferModel:)")));
		[Static]
		[Export ("readNet:bufferModel:")]
		Net ReadNet (string framework, ByteVector bufferModel);

		// +(Mat * _Nonnull)readTorchBlob:(NSString * _Nonnull)filename isBinary:(BOOL)isBinary __attribute__((swift_name("readTorchBlob(filename:isBinary:)")));
		[Static]
		[Export ("readTorchBlob:isBinary:")]
		Mat ReadTorchBlob (string filename, bool isBinary);

		// +(Mat * _Nonnull)readTorchBlob:(NSString * _Nonnull)filename __attribute__((swift_name("readTorchBlob(filename:)")));
		[Static]
		[Export ("readTorchBlob:")]
		Mat ReadTorchBlob (string filename);

		// +(Net * _Nonnull)readNetFromModelOptimizer:(NSString * _Nonnull)xml bin:(NSString * _Nonnull)bin __attribute__((swift_name("readNetFromModelOptimizer(xml:bin:)")));
		[Static]
		[Export ("readNetFromModelOptimizer:bin:")]
		Net ReadNetFromModelOptimizer (string xml, string bin);

		// +(Net * _Nonnull)readNetFromModelOptimizer:(NSString * _Nonnull)xml __attribute__((swift_name("readNetFromModelOptimizer(xml:)")));
		[Static]
		[Export ("readNetFromModelOptimizer:")]
		Net ReadNetFromModelOptimizer (string xml);

		// +(Net * _Nonnull)readNetFromModelOptimizer:(ByteVector * _Nonnull)bufferModelConfig bufferWeights:(ByteVector * _Nonnull)bufferWeights __attribute__((swift_name("readNetFromModelOptimizer(bufferModelConfig:bufferWeights:)")));
		[Static]
		[Export ("readNetFromModelOptimizer:bufferWeights:")]
		Net ReadNetFromModelOptimizer (ByteVector bufferModelConfig, ByteVector bufferWeights);

		// +(Net * _Nonnull)readNetFromONNXFile:(NSString * _Nonnull)onnxFile __attribute__((swift_name("readNetFromONNX(onnxFile:)")));
		[Static]
		[Export ("readNetFromONNXFile:")]
		Net ReadNetFromONNXFile (string onnxFile);

		// +(Net * _Nonnull)readNetFromONNXBuffer:(ByteVector * _Nonnull)buffer __attribute__((swift_name("readNetFromONNX(buffer:)")));
		[Static]
		[Export ("readNetFromONNXBuffer:")]
		Net ReadNetFromONNXBuffer (ByteVector buffer);

		// +(Mat * _Nonnull)readTensorFromONNX:(NSString * _Nonnull)path __attribute__((swift_name("readTensorFromONNX(path:)")));
		[Static]
		[Export ("readTensorFromONNX:")]
		Mat ReadTensorFromONNX (string path);

		// +(Mat * _Nonnull)blobFromImage:(Mat * _Nonnull)image scalefactor:(double)scalefactor size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean swapRB:(BOOL)swapRB crop:(BOOL)crop ddepth:(int)ddepth __attribute__((swift_name("blobFromImage(image:scalefactor:size:mean:swapRB:crop:ddepth:)")));
		[Static]
		[Export ("blobFromImage:scalefactor:size:mean:swapRB:crop:ddepth:")]
		Mat BlobFromImage (Mat image, double scalefactor, Size2i size, Scalar mean, bool swapRB, bool crop, int ddepth);

		// +(Mat * _Nonnull)blobFromImage:(Mat * _Nonnull)image scalefactor:(double)scalefactor size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean swapRB:(BOOL)swapRB crop:(BOOL)crop __attribute__((swift_name("blobFromImage(image:scalefactor:size:mean:swapRB:crop:)")));
		[Static]
		[Export ("blobFromImage:scalefactor:size:mean:swapRB:crop:")]
		Mat BlobFromImage (Mat image, double scalefactor, Size2i size, Scalar mean, bool swapRB, bool crop);

		// +(Mat * _Nonnull)blobFromImage:(Mat * _Nonnull)image scalefactor:(double)scalefactor size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean swapRB:(BOOL)swapRB __attribute__((swift_name("blobFromImage(image:scalefactor:size:mean:swapRB:)")));
		[Static]
		[Export ("blobFromImage:scalefactor:size:mean:swapRB:")]
		Mat BlobFromImage (Mat image, double scalefactor, Size2i size, Scalar mean, bool swapRB);

		// +(Mat * _Nonnull)blobFromImage:(Mat * _Nonnull)image scalefactor:(double)scalefactor size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean __attribute__((swift_name("blobFromImage(image:scalefactor:size:mean:)")));
		[Static]
		[Export ("blobFromImage:scalefactor:size:mean:")]
		Mat BlobFromImage (Mat image, double scalefactor, Size2i size, Scalar mean);

		// +(Mat * _Nonnull)blobFromImage:(Mat * _Nonnull)image scalefactor:(double)scalefactor size:(Size2i * _Nonnull)size __attribute__((swift_name("blobFromImage(image:scalefactor:size:)")));
		[Static]
		[Export ("blobFromImage:scalefactor:size:")]
		Mat BlobFromImage (Mat image, double scalefactor, Size2i size);

		// +(Mat * _Nonnull)blobFromImage:(Mat * _Nonnull)image scalefactor:(double)scalefactor __attribute__((swift_name("blobFromImage(image:scalefactor:)")));
		[Static]
		[Export ("blobFromImage:scalefactor:")]
		Mat BlobFromImage (Mat image, double scalefactor);

		// +(Mat * _Nonnull)blobFromImage:(Mat * _Nonnull)image __attribute__((swift_name("blobFromImage(image:)")));
		[Static]
		[Export ("blobFromImage:")]
		Mat BlobFromImage (Mat image);

		// +(Mat * _Nonnull)blobFromImages:(NSArray<Mat *> * _Nonnull)images scalefactor:(double)scalefactor size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean swapRB:(BOOL)swapRB crop:(BOOL)crop ddepth:(int)ddepth __attribute__((swift_name("blobFromImages(images:scalefactor:size:mean:swapRB:crop:ddepth:)")));
		[Static]
		[Export ("blobFromImages:scalefactor:size:mean:swapRB:crop:ddepth:")]
		Mat BlobFromImages (Mat[] images, double scalefactor, Size2i size, Scalar mean, bool swapRB, bool crop, int ddepth);

		// +(Mat * _Nonnull)blobFromImages:(NSArray<Mat *> * _Nonnull)images scalefactor:(double)scalefactor size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean swapRB:(BOOL)swapRB crop:(BOOL)crop __attribute__((swift_name("blobFromImages(images:scalefactor:size:mean:swapRB:crop:)")));
		[Static]
		[Export ("blobFromImages:scalefactor:size:mean:swapRB:crop:")]
		Mat BlobFromImages (Mat[] images, double scalefactor, Size2i size, Scalar mean, bool swapRB, bool crop);

		// +(Mat * _Nonnull)blobFromImages:(NSArray<Mat *> * _Nonnull)images scalefactor:(double)scalefactor size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean swapRB:(BOOL)swapRB __attribute__((swift_name("blobFromImages(images:scalefactor:size:mean:swapRB:)")));
		[Static]
		[Export ("blobFromImages:scalefactor:size:mean:swapRB:")]
		Mat BlobFromImages (Mat[] images, double scalefactor, Size2i size, Scalar mean, bool swapRB);

		// +(Mat * _Nonnull)blobFromImages:(NSArray<Mat *> * _Nonnull)images scalefactor:(double)scalefactor size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean __attribute__((swift_name("blobFromImages(images:scalefactor:size:mean:)")));
		[Static]
		[Export ("blobFromImages:scalefactor:size:mean:")]
		Mat BlobFromImages (Mat[] images, double scalefactor, Size2i size, Scalar mean);

		// +(Mat * _Nonnull)blobFromImages:(NSArray<Mat *> * _Nonnull)images scalefactor:(double)scalefactor size:(Size2i * _Nonnull)size __attribute__((swift_name("blobFromImages(images:scalefactor:size:)")));
		[Static]
		[Export ("blobFromImages:scalefactor:size:")]
		Mat BlobFromImages (Mat[] images, double scalefactor, Size2i size);

		// +(Mat * _Nonnull)blobFromImages:(NSArray<Mat *> * _Nonnull)images scalefactor:(double)scalefactor __attribute__((swift_name("blobFromImages(images:scalefactor:)")));
		[Static]
		[Export ("blobFromImages:scalefactor:")]
		Mat BlobFromImages (Mat[] images, double scalefactor);

		// +(Mat * _Nonnull)blobFromImages:(NSArray<Mat *> * _Nonnull)images __attribute__((swift_name("blobFromImages(images:)")));
		[Static]
		[Export ("blobFromImages:")]
		Mat BlobFromImages (Mat[] images);

		// +(Mat * _Nonnull)blobFromImageWithParams:(Mat * _Nonnull)image param:(Image2BlobParams * _Nonnull)param __attribute__((swift_name("blobFromImageWithParams(image:param:)")));
		[Static]
		[Export ("blobFromImageWithParams:param:")]
		Mat BlobFromImageWithParams (Mat image, Image2BlobParams param);

		// +(Mat * _Nonnull)blobFromImageWithParams:(Mat * _Nonnull)image __attribute__((swift_name("blobFromImageWithParams(image:)")));
		[Static]
		[Export ("blobFromImageWithParams:")]
		Mat BlobFromImageWithParams (Mat image);

		// +(void)blobFromImageWithParams:(Mat * _Nonnull)image blob:(Mat * _Nonnull)blob param:(Image2BlobParams * _Nonnull)param __attribute__((swift_name("blobFromImageWithParams(image:blob:param:)")));
		[Static]
		[Export ("blobFromImageWithParams:blob:param:")]
		void BlobFromImageWithParams (Mat image, Mat blob, Image2BlobParams param);

		// +(void)blobFromImageWithParams:(Mat * _Nonnull)image blob:(Mat * _Nonnull)blob __attribute__((swift_name("blobFromImageWithParams(image:blob:)")));
		[Static]
		[Export ("blobFromImageWithParams:blob:")]
		void BlobFromImageWithParams (Mat image, Mat blob);

		// +(Mat * _Nonnull)blobFromImagesWithParams:(NSArray<Mat *> * _Nonnull)images param:(Image2BlobParams * _Nonnull)param __attribute__((swift_name("blobFromImagesWithParams(images:param:)")));
		[Static]
		[Export ("blobFromImagesWithParams:param:")]
		Mat BlobFromImagesWithParams (Mat[] images, Image2BlobParams param);

		// +(Mat * _Nonnull)blobFromImagesWithParams:(NSArray<Mat *> * _Nonnull)images __attribute__((swift_name("blobFromImagesWithParams(images:)")));
		[Static]
		[Export ("blobFromImagesWithParams:")]
		Mat BlobFromImagesWithParams (Mat[] images);

		// +(void)blobFromImagesWithParams:(NSArray<Mat *> * _Nonnull)images blob:(Mat * _Nonnull)blob param:(Image2BlobParams * _Nonnull)param __attribute__((swift_name("blobFromImagesWithParams(images:blob:param:)")));
		[Static]
		[Export ("blobFromImagesWithParams:blob:param:")]
		void BlobFromImagesWithParams (Mat[] images, Mat blob, Image2BlobParams param);

		// +(void)blobFromImagesWithParams:(NSArray<Mat *> * _Nonnull)images blob:(Mat * _Nonnull)blob __attribute__((swift_name("blobFromImagesWithParams(images:blob:)")));
		[Static]
		[Export ("blobFromImagesWithParams:blob:")]
		void BlobFromImagesWithParams (Mat[] images, Mat blob);

		// +(void)imagesFromBlob:(Mat * _Nonnull)blob_ images_:(NSMutableArray<Mat *> * _Nonnull)images_ __attribute__((swift_name("imagesFromBlob(blob_:images_:)")));
		[Static]
		[Export ("imagesFromBlob:images_:")]
		void ImagesFromBlob (Mat blob_, NSMutableArray<Mat> images_);

		// +(void)shrinkCaffeModel:(NSString * _Nonnull)src dst:(NSString * _Nonnull)dst layersTypes:(NSArray<NSString *> * _Nonnull)layersTypes __attribute__((swift_name("shrinkCaffeModel(src:dst:layersTypes:)")));
		[Static]
		[Export ("shrinkCaffeModel:dst:layersTypes:")]
		void ShrinkCaffeModel (string src, string dst, string[] layersTypes);

		// +(void)shrinkCaffeModel:(NSString * _Nonnull)src dst:(NSString * _Nonnull)dst __attribute__((swift_name("shrinkCaffeModel(src:dst:)")));
		[Static]
		[Export ("shrinkCaffeModel:dst:")]
		void ShrinkCaffeModel (string src, string dst);

		// +(void)writeTextGraph:(NSString * _Nonnull)model output:(NSString * _Nonnull)output __attribute__((swift_name("writeTextGraph(model:output:)")));
		[Static]
		[Export ("writeTextGraph:output:")]
		void WriteTextGraph (string model, string output);

		// +(void)NMSBoxes:(NSArray<Rect2d *> * _Nonnull)bboxes scores:(FloatVector * _Nonnull)scores score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold indices:(IntVector * _Nonnull)indices eta:(float)eta top_k:(int)top_k __attribute__((swift_name("NMSBoxes(bboxes:scores:score_threshold:nms_threshold:indices:eta:top_k:)")));
		[Static]
		[Export ("NMSBoxes:scores:score_threshold:nms_threshold:indices:eta:top_k:")]
		void NMSBoxes (Rect2d[] bboxes, FloatVector scores, float score_threshold, float nms_threshold, IntVector indices, float eta, int top_k);

		// +(void)NMSBoxes:(NSArray<Rect2d *> * _Nonnull)bboxes scores:(FloatVector * _Nonnull)scores score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold indices:(IntVector * _Nonnull)indices eta:(float)eta __attribute__((swift_name("NMSBoxes(bboxes:scores:score_threshold:nms_threshold:indices:eta:)")));
		[Static]
		[Export ("NMSBoxes:scores:score_threshold:nms_threshold:indices:eta:")]
		void NMSBoxes (Rect2d[] bboxes, FloatVector scores, float score_threshold, float nms_threshold, IntVector indices, float eta);

		// +(void)NMSBoxes:(NSArray<Rect2d *> * _Nonnull)bboxes scores:(FloatVector * _Nonnull)scores score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold indices:(IntVector * _Nonnull)indices __attribute__((swift_name("NMSBoxes(bboxes:scores:score_threshold:nms_threshold:indices:)")));
		[Static]
		[Export ("NMSBoxes:scores:score_threshold:nms_threshold:indices:")]
		void NMSBoxes (Rect2d[] bboxes, FloatVector scores, float score_threshold, float nms_threshold, IntVector indices);

		// +(void)NMSBoxesRotated:(NSArray<RotatedRect *> * _Nonnull)bboxes scores:(FloatVector * _Nonnull)scores score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold indices:(IntVector * _Nonnull)indices eta:(float)eta top_k:(int)top_k __attribute__((swift_name("NMSBoxes(bboxes:scores:score_threshold:nms_threshold:indices:eta:top_k:)")));
		[Static]
		[Export ("NMSBoxesRotated:scores:score_threshold:nms_threshold:indices:eta:top_k:")]
		void NMSBoxesRotated (RotatedRect[] bboxes, FloatVector scores, float score_threshold, float nms_threshold, IntVector indices, float eta, int top_k);

		// +(void)NMSBoxesRotated:(NSArray<RotatedRect *> * _Nonnull)bboxes scores:(FloatVector * _Nonnull)scores score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold indices:(IntVector * _Nonnull)indices eta:(float)eta __attribute__((swift_name("NMSBoxes(bboxes:scores:score_threshold:nms_threshold:indices:eta:)")));
		[Static]
		[Export ("NMSBoxesRotated:scores:score_threshold:nms_threshold:indices:eta:")]
		void NMSBoxesRotated (RotatedRect[] bboxes, FloatVector scores, float score_threshold, float nms_threshold, IntVector indices, float eta);

		// +(void)NMSBoxesRotated:(NSArray<RotatedRect *> * _Nonnull)bboxes scores:(FloatVector * _Nonnull)scores score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold indices:(IntVector * _Nonnull)indices __attribute__((swift_name("NMSBoxes(bboxes:scores:score_threshold:nms_threshold:indices:)")));
		[Static]
		[Export ("NMSBoxesRotated:scores:score_threshold:nms_threshold:indices:")]
		void NMSBoxesRotated (RotatedRect[] bboxes, FloatVector scores, float score_threshold, float nms_threshold, IntVector indices);

		// +(void)NMSBoxesBatched:(NSArray<Rect2d *> * _Nonnull)bboxes scores:(FloatVector * _Nonnull)scores class_ids:(IntVector * _Nonnull)class_ids score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold indices:(IntVector * _Nonnull)indices eta:(float)eta top_k:(int)top_k __attribute__((swift_name("NMSBoxesBatched(bboxes:scores:class_ids:score_threshold:nms_threshold:indices:eta:top_k:)")));
		[Static]
		[Export ("NMSBoxesBatched:scores:class_ids:score_threshold:nms_threshold:indices:eta:top_k:")]
		void NMSBoxesBatched (Rect2d[] bboxes, FloatVector scores, IntVector class_ids, float score_threshold, float nms_threshold, IntVector indices, float eta, int top_k);

		// +(void)NMSBoxesBatched:(NSArray<Rect2d *> * _Nonnull)bboxes scores:(FloatVector * _Nonnull)scores class_ids:(IntVector * _Nonnull)class_ids score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold indices:(IntVector * _Nonnull)indices eta:(float)eta __attribute__((swift_name("NMSBoxesBatched(bboxes:scores:class_ids:score_threshold:nms_threshold:indices:eta:)")));
		[Static]
		[Export ("NMSBoxesBatched:scores:class_ids:score_threshold:nms_threshold:indices:eta:")]
		void NMSBoxesBatched (Rect2d[] bboxes, FloatVector scores, IntVector class_ids, float score_threshold, float nms_threshold, IntVector indices, float eta);

		// +(void)NMSBoxesBatched:(NSArray<Rect2d *> * _Nonnull)bboxes scores:(FloatVector * _Nonnull)scores class_ids:(IntVector * _Nonnull)class_ids score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold indices:(IntVector * _Nonnull)indices __attribute__((swift_name("NMSBoxesBatched(bboxes:scores:class_ids:score_threshold:nms_threshold:indices:)")));
		[Static]
		[Export ("NMSBoxesBatched:scores:class_ids:score_threshold:nms_threshold:indices:")]
		void NMSBoxesBatched (Rect2d[] bboxes, FloatVector scores, IntVector class_ids, float score_threshold, float nms_threshold, IntVector indices);

		// +(void)softNMSBoxes:(NSArray<Rect2i *> * _Nonnull)bboxes scores:(FloatVector * _Nonnull)scores updated_scores:(FloatVector * _Nonnull)updated_scores score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold indices:(IntVector * _Nonnull)indices top_k:(size_t)top_k sigma:(float)sigma method:(SoftNMSMethod)method __attribute__((swift_name("softNMSBoxes(bboxes:scores:updated_scores:score_threshold:nms_threshold:indices:top_k:sigma:method:)")));
		[Static]
		[Export ("softNMSBoxes:scores:updated_scores:score_threshold:nms_threshold:indices:top_k:sigma:method:")]
		void SoftNMSBoxes (Rect2i[] bboxes, FloatVector scores, FloatVector updated_scores, float score_threshold, float nms_threshold, IntVector indices, nuint top_k, float sigma, SoftNMSMethod method);

		// +(void)softNMSBoxes:(NSArray<Rect2i *> * _Nonnull)bboxes scores:(FloatVector * _Nonnull)scores updated_scores:(FloatVector * _Nonnull)updated_scores score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold indices:(IntVector * _Nonnull)indices top_k:(size_t)top_k sigma:(float)sigma __attribute__((swift_name("softNMSBoxes(bboxes:scores:updated_scores:score_threshold:nms_threshold:indices:top_k:sigma:)")));
		[Static]
		[Export ("softNMSBoxes:scores:updated_scores:score_threshold:nms_threshold:indices:top_k:sigma:")]
		void SoftNMSBoxes (Rect2i[] bboxes, FloatVector scores, FloatVector updated_scores, float score_threshold, float nms_threshold, IntVector indices, nuint top_k, float sigma);

		// +(void)softNMSBoxes:(NSArray<Rect2i *> * _Nonnull)bboxes scores:(FloatVector * _Nonnull)scores updated_scores:(FloatVector * _Nonnull)updated_scores score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold indices:(IntVector * _Nonnull)indices top_k:(size_t)top_k __attribute__((swift_name("softNMSBoxes(bboxes:scores:updated_scores:score_threshold:nms_threshold:indices:top_k:)")));
		[Static]
		[Export ("softNMSBoxes:scores:updated_scores:score_threshold:nms_threshold:indices:top_k:")]
		void SoftNMSBoxes (Rect2i[] bboxes, FloatVector scores, FloatVector updated_scores, float score_threshold, float nms_threshold, IntVector indices, nuint top_k);

		// +(void)softNMSBoxes:(NSArray<Rect2i *> * _Nonnull)bboxes scores:(FloatVector * _Nonnull)scores updated_scores:(FloatVector * _Nonnull)updated_scores score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold indices:(IntVector * _Nonnull)indices __attribute__((swift_name("softNMSBoxes(bboxes:scores:updated_scores:score_threshold:nms_threshold:indices:)")));
		[Static]
		[Export ("softNMSBoxes:scores:updated_scores:score_threshold:nms_threshold:indices:")]
		void SoftNMSBoxes (Rect2i[] bboxes, FloatVector scores, FloatVector updated_scores, float score_threshold, float nms_threshold, IntVector indices);

		// +(NSString * _Nonnull)getInferenceEngineBackendType __attribute__((swift_name("getInferenceEngineBackendType()"))) __attribute__((deprecated("")));
		[Static]
		[Export ("getInferenceEngineBackendType")]
		string InferenceEngineBackendType { get; }

		// +(NSString * _Nonnull)setInferenceEngineBackendType:(NSString * _Nonnull)newBackendType __attribute__((swift_name("setInferenceEngineBackendType(newBackendType:)"))) __attribute__((deprecated("")));
		[Static]
		[Export ("setInferenceEngineBackendType:")]
		string SetInferenceEngineBackendType (string newBackendType);

		// +(void)resetMyriadDevice __attribute__((swift_name("resetMyriadDevice()")));
		[Static]
		[Export ("resetMyriadDevice")]
		void ResetMyriadDevice ();

		// +(NSString * _Nonnull)getInferenceEngineVPUType __attribute__((swift_name("getInferenceEngineVPUType()")));
		[Static]
		[Export ("getInferenceEngineVPUType")]
		string InferenceEngineVPUType { get; }

		// +(NSString * _Nonnull)getInferenceEngineCPUType __attribute__((swift_name("getInferenceEngineCPUType()")));
		[Static]
		[Export ("getInferenceEngineCPUType")]
		string InferenceEngineCPUType { get; }

		// +(void)releaseHDDLPlugin __attribute__((swift_name("releaseHDDLPlugin()")));
		[Static]
		[Export ("releaseHDDLPlugin")]
		void ReleaseHDDLPlugin ();
	}

	// @interface Model : NSObject
	[BaseType (typeof(NSObject))]
	interface Model
	{
		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model config:(NSString * _Nonnull)config;
		[Export ("initWithModel:config:")]
		NativeHandle Constructor (string model, string config);

		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model;
		[Export ("initWithModel:")]
		NativeHandle Constructor (string model);

		// -(instancetype _Nonnull)initWithNetwork:(Net * _Nonnull)network;
		[Export ("initWithNetwork:")]
		NativeHandle Constructor (Net network);

		// -(Model * _Nonnull)setInputSize:(Size2i * _Nonnull)size __attribute__((swift_name("setInputSize(size:)")));
		[Export ("setInputSize:")]
		Model SetInputSize (Size2i size);

		// -(Model * _Nonnull)setInputSize:(int)width height:(int)height __attribute__((swift_name("setInputSize(width:height:)")));
		[Export ("setInputSize:height:")]
		Model SetInputSize (int width, int height);

		// -(Model * _Nonnull)setInputMean:(Scalar * _Nonnull)mean __attribute__((swift_name("setInputMean(mean:)")));
		[Export ("setInputMean:")]
		Model SetInputMean (Scalar mean);

		// -(Model * _Nonnull)setInputScale:(Scalar * _Nonnull)scale __attribute__((swift_name("setInputScale(scale:)")));
		[Export ("setInputScale:")]
		Model SetInputScale (Scalar scale);

		// -(Model * _Nonnull)setInputCrop:(BOOL)crop __attribute__((swift_name("setInputCrop(crop:)")));
		[Export ("setInputCrop:")]
		Model SetInputCrop (bool crop);

		// -(Model * _Nonnull)setInputSwapRB:(BOOL)swapRB __attribute__((swift_name("setInputSwapRB(swapRB:)")));
		[Export ("setInputSwapRB:")]
		Model SetInputSwapRB (bool swapRB);

		// -(Model * _Nonnull)setOutputNames:(NSArray<NSString *> * _Nonnull)outNames __attribute__((swift_name("setOutputNames(outNames:)")));
		[Export ("setOutputNames:")]
		Model SetOutputNames (string[] outNames);

		// -(void)setInputParams:(double)scale size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean swapRB:(BOOL)swapRB crop:(BOOL)crop __attribute__((swift_name("setInputParams(scale:size:mean:swapRB:crop:)")));
		[Export ("setInputParams:size:mean:swapRB:crop:")]
		void SetInputParams (double scale, Size2i size, Scalar mean, bool swapRB, bool crop);

		// -(void)setInputParams:(double)scale size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean swapRB:(BOOL)swapRB __attribute__((swift_name("setInputParams(scale:size:mean:swapRB:)")));
		[Export ("setInputParams:size:mean:swapRB:")]
		void SetInputParams (double scale, Size2i size, Scalar mean, bool swapRB);

		// -(void)setInputParams:(double)scale size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean __attribute__((swift_name("setInputParams(scale:size:mean:)")));
		[Export ("setInputParams:size:mean:")]
		void SetInputParams (double scale, Size2i size, Scalar mean);

		// -(void)setInputParams:(double)scale size:(Size2i * _Nonnull)size __attribute__((swift_name("setInputParams(scale:size:)")));
		[Export ("setInputParams:size:")]
		void SetInputParams (double scale, Size2i size);

		// -(void)setInputParams:(double)scale __attribute__((swift_name("setInputParams(scale:)")));
		[Export ("setInputParams:")]
		void SetInputParams (double scale);

		// -(void)setInputParams __attribute__((swift_name("setInputParams()")));
		[Export ("setInputParams")]
		void SetInputParams ();

		// -(void)predict:(Mat * _Nonnull)frame outs:(NSMutableArray<Mat *> * _Nonnull)outs __attribute__((swift_name("predict(frame:outs:)")));
		[Export ("predict:outs:")]
		void Predict (Mat frame, NSMutableArray<Mat> outs);

		// -(Model * _Nonnull)setPreferableBackend:(Backend)backendId __attribute__((swift_name("setPreferableBackend(backendId:)")));
		[Export ("setPreferableBackend:")]
		Model SetPreferableBackend (Backend backendId);

		// -(Model * _Nonnull)setPreferableTarget:(Target)targetId __attribute__((swift_name("setPreferableTarget(targetId:)")));
		[Export ("setPreferableTarget:")]
		Model SetPreferableTarget (Target targetId);

		// -(Model * _Nonnull)enableWinograd:(BOOL)useWinograd __attribute__((swift_name("enableWinograd(useWinograd:)")));
		[Export ("enableWinograd:")]
		Model EnableWinograd (bool useWinograd);
	}

	// @interface ClassificationModel : Model
	[BaseType (typeof(Model))]
	interface ClassificationModel
	{
		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model config:(NSString * _Nonnull)config;
		[Export ("initWithModel:config:")]
		NativeHandle Constructor (string model, string config);

		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model;
		[Export ("initWithModel:")]
		NativeHandle Constructor (string model);

		// -(instancetype _Nonnull)initWithNetwork:(Net * _Nonnull)network;
		[Export ("initWithNetwork:")]
		NativeHandle Constructor (Net network);

		// -(ClassificationModel * _Nonnull)setEnableSoftmaxPostProcessing:(BOOL)enable __attribute__((swift_name("setEnableSoftmaxPostProcessing(enable:)")));
		[Export ("setEnableSoftmaxPostProcessing:")]
		ClassificationModel SetEnableSoftmaxPostProcessing (bool enable);

		// -(BOOL)getEnableSoftmaxPostProcessing __attribute__((swift_name("getEnableSoftmaxPostProcessing()")));
		[Export ("getEnableSoftmaxPostProcessing")]
		bool EnableSoftmaxPostProcessing { get; }

		// -(void)classify:(Mat * _Nonnull)frame classId:(int * _Nonnull)classId conf:(float * _Nonnull)conf __attribute__((swift_name("classify(frame:classId:conf:)")));
		[Export ("classify:classId:conf:")]
		unsafe void Classify (Mat frame, int* classId, float* conf);
	}

	// @interface DetectionModel : Model
	[BaseType (typeof(Model))]
	interface DetectionModel
	{
		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model config:(NSString * _Nonnull)config;
		[Export ("initWithModel:config:")]
		NativeHandle Constructor (string model, string config);

		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model;
		[Export ("initWithModel:")]
		NativeHandle Constructor (string model);

		// -(instancetype _Nonnull)initWithNetwork:(Net * _Nonnull)network;
		[Export ("initWithNetwork:")]
		NativeHandle Constructor (Net network);

		// -(DetectionModel * _Nonnull)setNmsAcrossClasses:(BOOL)value __attribute__((swift_name("setNmsAcrossClasses(value:)")));
		[Export ("setNmsAcrossClasses:")]
		DetectionModel SetNmsAcrossClasses (bool value);

		// -(BOOL)getNmsAcrossClasses __attribute__((swift_name("getNmsAcrossClasses()")));
		[Export ("getNmsAcrossClasses")]
		bool NmsAcrossClasses { get; }

		// -(void)detect:(Mat * _Nonnull)frame classIds:(IntVector * _Nonnull)classIds confidences:(FloatVector * _Nonnull)confidences boxes:(NSMutableArray<Rect2i *> * _Nonnull)boxes confThreshold:(float)confThreshold nmsThreshold:(float)nmsThreshold __attribute__((swift_name("detect(frame:classIds:confidences:boxes:confThreshold:nmsThreshold:)")));
		[Export ("detect:classIds:confidences:boxes:confThreshold:nmsThreshold:")]
		void Detect (Mat frame, IntVector classIds, FloatVector confidences, NSMutableArray<Rect2i> boxes, float confThreshold, float nmsThreshold);

		// -(void)detect:(Mat * _Nonnull)frame classIds:(IntVector * _Nonnull)classIds confidences:(FloatVector * _Nonnull)confidences boxes:(NSMutableArray<Rect2i *> * _Nonnull)boxes confThreshold:(float)confThreshold __attribute__((swift_name("detect(frame:classIds:confidences:boxes:confThreshold:)")));
		[Export ("detect:classIds:confidences:boxes:confThreshold:")]
		void Detect (Mat frame, IntVector classIds, FloatVector confidences, NSMutableArray<Rect2i> boxes, float confThreshold);

		// -(void)detect:(Mat * _Nonnull)frame classIds:(IntVector * _Nonnull)classIds confidences:(FloatVector * _Nonnull)confidences boxes:(NSMutableArray<Rect2i *> * _Nonnull)boxes __attribute__((swift_name("detect(frame:classIds:confidences:boxes:)")));
		[Export ("detect:classIds:confidences:boxes:")]
		void Detect (Mat frame, IntVector classIds, FloatVector confidences, NSMutableArray<Rect2i> boxes);
	}

	// @interface DictValue : NSObject
	[BaseType (typeof(NSObject))]
	interface DictValue
	{
		// -(instancetype _Nonnull)initWithI:(int)i;
		[Export ("initWithI:")]
		NativeHandle Constructor (int i);

		// -(instancetype _Nonnull)initWithP:(double)p;
		[Export ("initWithP:")]
		NativeHandle Constructor (double p);

		// -(instancetype _Nonnull)initWithS:(NSString * _Nonnull)s;
		[Export ("initWithS:")]
		NativeHandle Constructor (string s);

		// -(BOOL)isInt __attribute__((swift_name("isInt()")));
		[Export ("isInt")]
		bool IsInt { get; }

		// -(BOOL)isString __attribute__((swift_name("isString()")));
		[Export ("isString")]
		bool IsString { get; }

		// -(BOOL)isReal __attribute__((swift_name("isReal()")));
		[Export ("isReal")]
		bool IsReal { get; }

		// -(int)getIntValue:(int)idx __attribute__((swift_name("getIntValue(idx:)")));
		[Export ("getIntValue:")]
		int GetIntValue (int idx);

		// -(int)getIntValue __attribute__((swift_name("getIntValue()")));
		[Export ("getIntValue")]
		int IntValue { get; }

		// -(double)getRealValue:(int)idx __attribute__((swift_name("getRealValue(idx:)")));
		[Export ("getRealValue:")]
		double GetRealValue (int idx);

		// -(double)getRealValue __attribute__((swift_name("getRealValue()")));
		[Export ("getRealValue")]
		double RealValue { get; }

		// -(NSString * _Nonnull)getStringValue:(int)idx __attribute__((swift_name("getStringValue(idx:)")));
		[Export ("getStringValue:")]
		string GetStringValue (int idx);

		// -(NSString * _Nonnull)getStringValue __attribute__((swift_name("getStringValue()")));
		[Export ("getStringValue")]
		string StringValue { get; }
	}

	// @interface Image2BlobParams : NSObject
	[BaseType (typeof(NSObject))]
	interface Image2BlobParams
	{
		// -(instancetype _Nonnull)initWithScalefactor:(Scalar * _Nonnull)scalefactor size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean swapRB:(BOOL)swapRB ddepth:(int)ddepth datalayout:(DataLayout)datalayout mode:(ImagePaddingMode)mode borderValue:(Scalar * _Nonnull)borderValue;
		[Export ("initWithScalefactor:size:mean:swapRB:ddepth:datalayout:mode:borderValue:")]
		NativeHandle Constructor (Scalar scalefactor, Size2i size, Scalar mean, bool swapRB, int ddepth, DataLayout datalayout, ImagePaddingMode mode, Scalar borderValue);

		// -(instancetype _Nonnull)initWithScalefactor:(Scalar * _Nonnull)scalefactor size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean swapRB:(BOOL)swapRB ddepth:(int)ddepth datalayout:(DataLayout)datalayout mode:(ImagePaddingMode)mode;
		[Export ("initWithScalefactor:size:mean:swapRB:ddepth:datalayout:mode:")]
		NativeHandle Constructor (Scalar scalefactor, Size2i size, Scalar mean, bool swapRB, int ddepth, DataLayout datalayout, ImagePaddingMode mode);

		// -(instancetype _Nonnull)initWithScalefactor:(Scalar * _Nonnull)scalefactor size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean swapRB:(BOOL)swapRB ddepth:(int)ddepth datalayout:(DataLayout)datalayout;
		[Export ("initWithScalefactor:size:mean:swapRB:ddepth:datalayout:")]
		NativeHandle Constructor (Scalar scalefactor, Size2i size, Scalar mean, bool swapRB, int ddepth, DataLayout datalayout);

		// -(instancetype _Nonnull)initWithScalefactor:(Scalar * _Nonnull)scalefactor size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean swapRB:(BOOL)swapRB ddepth:(int)ddepth;
		[Export ("initWithScalefactor:size:mean:swapRB:ddepth:")]
		NativeHandle Constructor (Scalar scalefactor, Size2i size, Scalar mean, bool swapRB, int ddepth);

		// -(instancetype _Nonnull)initWithScalefactor:(Scalar * _Nonnull)scalefactor size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean swapRB:(BOOL)swapRB;
		[Export ("initWithScalefactor:size:mean:swapRB:")]
		NativeHandle Constructor (Scalar scalefactor, Size2i size, Scalar mean, bool swapRB);

		// -(instancetype _Nonnull)initWithScalefactor:(Scalar * _Nonnull)scalefactor size:(Size2i * _Nonnull)size mean:(Scalar * _Nonnull)mean;
		[Export ("initWithScalefactor:size:mean:")]
		NativeHandle Constructor (Scalar scalefactor, Size2i size, Scalar mean);

		// -(instancetype _Nonnull)initWithScalefactor:(Scalar * _Nonnull)scalefactor size:(Size2i * _Nonnull)size;
		[Export ("initWithScalefactor:size:")]
		NativeHandle Constructor (Scalar scalefactor, Size2i size);

		// -(instancetype _Nonnull)initWithScalefactor:(Scalar * _Nonnull)scalefactor;
		[Export ("initWithScalefactor:")]
		NativeHandle Constructor (Scalar scalefactor);

		// -(Rect2i * _Nonnull)blobRectToImageRect:(Rect2i * _Nonnull)rBlob size:(Size2i * _Nonnull)size __attribute__((swift_name("blobRectToImageRect(rBlob:size:)")));
		[Export ("blobRectToImageRect:size:")]
		Rect2i BlobRectToImageRect (Rect2i rBlob, Size2i size);

		// -(void)blobRectsToImageRects:(NSArray<Rect2i *> * _Nonnull)rBlob rImg:(NSMutableArray<Rect2i *> * _Nonnull)rImg size:(Size2i * _Nonnull)size __attribute__((swift_name("blobRectsToImageRects(rBlob:rImg:size:)")));
		[Export ("blobRectsToImageRects:rImg:size:")]
		void BlobRectsToImageRects (Rect2i[] rBlob, NSMutableArray<Rect2i> rImg, Size2i size);

		// @property Scalar * _Nonnull scalefactor;
		[Export ("scalefactor", ArgumentSemantic.Assign)]
		Scalar Scalefactor { get; set; }

		// @property Size2i * _Nonnull size;
		[Export ("size", ArgumentSemantic.Assign)]
		Size2i Size { get; set; }

		// @property Scalar * _Nonnull mean;
		[Export ("mean", ArgumentSemantic.Assign)]
		Scalar Mean { get; set; }

		// @property BOOL swapRB;
		[Export ("swapRB")]
		bool SwapRB { get; set; }

		// @property int ddepth;
		[Export ("ddepth")]
		int Ddepth { get; set; }

		// @property DataLayout datalayout;
		[Export ("datalayout", ArgumentSemantic.Assign)]
		DataLayout Datalayout { get; set; }

		// @property ImagePaddingMode paddingmode;
		[Export ("paddingmode", ArgumentSemantic.Assign)]
		ImagePaddingMode Paddingmode { get; set; }

		// @property Scalar * _Nonnull borderValue;
		[Export ("borderValue", ArgumentSemantic.Assign)]
		Scalar BorderValue { get; set; }
	}

	// @interface KeypointsModel : Model
	[BaseType (typeof(Model))]
	interface KeypointsModel
	{
		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model config:(NSString * _Nonnull)config;
		[Export ("initWithModel:config:")]
		NativeHandle Constructor (string model, string config);

		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model;
		[Export ("initWithModel:")]
		NativeHandle Constructor (string model);

		// -(instancetype _Nonnull)initWithNetwork:(Net * _Nonnull)network;
		[Export ("initWithNetwork:")]
		NativeHandle Constructor (Net network);

		// -(NSArray<Point2f *> * _Nonnull)estimate:(Mat * _Nonnull)frame thresh:(float)thresh __attribute__((swift_name("estimate(frame:thresh:)")));
		[Export ("estimate:thresh:")]
		Point2f[] Estimate (Mat frame, float thresh);

		// -(NSArray<Point2f *> * _Nonnull)estimate:(Mat * _Nonnull)frame __attribute__((swift_name("estimate(frame:)")));
		[Export ("estimate:")]
		Point2f[] Estimate (Mat frame);
	}

	// @interface Layer : Algorithm
	[BaseType (typeof(Algorithm))]
	interface Layer
	{
		// -(void)finalize:(NSArray<Mat *> * _Nonnull)inputs outputs:(NSMutableArray<Mat *> * _Nonnull)outputs __attribute__((swift_name("finalize(inputs:outputs:)")));
		[Export ("finalize:outputs:")]
		void Finalize (Mat[] inputs, NSMutableArray<Mat> outputs);

		// -(void)run:(NSArray<Mat *> * _Nonnull)inputs outputs:(NSMutableArray<Mat *> * _Nonnull)outputs internals:(NSMutableArray<Mat *> * _Nonnull)internals __attribute__((swift_name("run(inputs:outputs:internals:)"))) __attribute__((deprecated("")));
		[Export ("run:outputs:internals:")]
		void Run (Mat[] inputs, NSMutableArray<Mat> outputs, NSMutableArray<Mat> internals);

		// -(int)outputNameToIndex:(NSString * _Nonnull)outputName __attribute__((swift_name("outputNameToIndex(outputName:)")));
		[Export ("outputNameToIndex:")]
		int OutputNameToIndex (string outputName);

		// @property Mat * _Nonnull blobs;
		[Export ("blobs", ArgumentSemantic.Assign)]
		Mat Blobs { get; set; }

		// @property (readonly) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly) NSString * _Nonnull type;
		[Export ("type")]
		string Type { get; }

		// @property (readonly) int preferableTarget;
		[Export ("preferableTarget")]
		int PreferableTarget { get; }
	}

	// @interface Net : NSObject
	[BaseType (typeof(NSObject))]
	interface Net
	{
		// +(Net * _Nonnull)readFromModelOptimizer:(NSString * _Nonnull)xml bin:(NSString * _Nonnull)bin __attribute__((swift_name("readFromModelOptimizer(xml:bin:)")));
		[Static]
		[Export ("readFromModelOptimizer:bin:")]
		Net ReadFromModelOptimizer (string xml, string bin);

		// +(Net * _Nonnull)readFromModelOptimizer:(ByteVector * _Nonnull)bufferModelConfig bufferWeights:(ByteVector * _Nonnull)bufferWeights __attribute__((swift_name("readFromModelOptimizer(bufferModelConfig:bufferWeights:)")));
		[Static]
		[Export ("readFromModelOptimizer:bufferWeights:")]
		Net ReadFromModelOptimizer (ByteVector bufferModelConfig, ByteVector bufferWeights);

		// -(BOOL)empty __attribute__((swift_name("empty()")));
		[Export ("empty")]
		bool Empty { get; }

		// -(NSString * _Nonnull)dump __attribute__((swift_name("dump()")));
		[Export ("dump")]
		string Dump ();

		// -(void)dumpToFile:(NSString * _Nonnull)path __attribute__((swift_name("dumpToFile(path:)")));
		[Export ("dumpToFile:")]
		void DumpToFile (string path);

		// -(void)dumpToPbtxt:(NSString * _Nonnull)path __attribute__((swift_name("dumpToPbtxt(path:)")));
		[Export ("dumpToPbtxt:")]
		void DumpToPbtxt (string path);

		// -(int)getLayerId:(NSString * _Nonnull)layer __attribute__((swift_name("getLayerId(layer:)")));
		[Export ("getLayerId:")]
		int GetLayerId (string layer);

		// -(NSArray<NSString *> * _Nonnull)getLayerNames __attribute__((swift_name("getLayerNames()")));
		[Export ("getLayerNames")]
		string[] LayerNames { get; }

		// -(Layer * _Nonnull)getLayer:(int)layerId __attribute__((swift_name("getLayer(layerId:)")));
		[Export ("getLayer:")]
		Layer GetLayer (int layerId);

		// -(Layer * _Nonnull)getLayerByName:(NSString * _Nonnull)layerName __attribute__((swift_name("getLayer(layerName:)"))) __attribute__((deprecated("")));
		[Export ("getLayerByName:")]
		Layer GetLayerByName (string layerName);

		// -(Layer * _Nonnull)getLayerByDictValue:(DictValue * _Nonnull)layerId __attribute__((swift_name("getLayer(layerId:)"))) __attribute__((deprecated("")));
		[Export ("getLayerByDictValue:")]
		Layer GetLayerByDictValue (DictValue layerId);

		// -(void)connect:(NSString * _Nonnull)outPin inpPin:(NSString * _Nonnull)inpPin __attribute__((swift_name("connect(outPin:inpPin:)")));
		[Export ("connect:inpPin:")]
		void Connect (string outPin, string inpPin);

		// -(int)registerOutput:(NSString * _Nonnull)outputName layerId:(int)layerId outputPort:(int)outputPort __attribute__((swift_name("registerOutput(outputName:layerId:outputPort:)")));
		[Export ("registerOutput:layerId:outputPort:")]
		int RegisterOutput (string outputName, int layerId, int outputPort);

		// -(void)setInputsNames:(NSArray<NSString *> * _Nonnull)inputBlobNames __attribute__((swift_name("setInputsNames(inputBlobNames:)")));
		[Export ("setInputsNames:")]
		void SetInputsNames (string[] inputBlobNames);

		// -(void)setInputShape:(NSString * _Nonnull)inputName shape:(IntVector * _Nonnull)shape __attribute__((swift_name("setInputShape(inputName:shape:)")));
		[Export ("setInputShape:shape:")]
		void SetInputShape (string inputName, IntVector shape);

		// -(Mat * _Nonnull)forward:(NSString * _Nonnull)outputName __attribute__((swift_name("forward(outputName:)")));
		[Export ("forward:")]
		Mat Forward (string outputName);

		// -(Mat * _Nonnull)forward __attribute__((swift_name("forward()")));
		[Export ("forward")]
		Mat Forward ();

		// -(void)forwardOutputBlobs:(NSMutableArray<Mat *> * _Nonnull)outputBlobs outputName:(NSString * _Nonnull)outputName __attribute__((swift_name("forward(outputBlobs:outputName:)")));
		[Export ("forwardOutputBlobs:outputName:")]
		void ForwardOutputBlobs (NSMutableArray<Mat> outputBlobs, string outputName);

		// -(void)forwardOutputBlobs:(NSMutableArray<Mat *> * _Nonnull)outputBlobs __attribute__((swift_name("forward(outputBlobs:)")));
		[Export ("forwardOutputBlobs:")]
		void ForwardOutputBlobs (NSMutableArray<Mat> outputBlobs);

		// -(void)forwardOutputBlobs:(NSMutableArray<Mat *> * _Nonnull)outputBlobs outBlobNames:(NSArray<NSString *> * _Nonnull)outBlobNames __attribute__((swift_name("forward(outputBlobs:outBlobNames:)")));
		[Export ("forwardOutputBlobs:outBlobNames:")]
		void ForwardOutputBlobs (NSMutableArray<Mat> outputBlobs, string[] outBlobNames);

		// -(void)forwardAndRetrieve:(NSMutableArray<NSMutableArray<Mat *> *> * _Nonnull)outputBlobs outBlobNames:(NSArray<NSString *> * _Nonnull)outBlobNames __attribute__((swift_name("forwardAndRetrieve(outputBlobs:outBlobNames:)")));
		[Export ("forwardAndRetrieve:outBlobNames:")]
		void ForwardAndRetrieve (NSMutableArray<NSMutableArray<Mat>> outputBlobs, string[] outBlobNames);

		// -(Net * _Nonnull)quantize:(NSArray<Mat *> * _Nonnull)calibData inputsDtype:(int)inputsDtype outputsDtype:(int)outputsDtype perChannel:(BOOL)perChannel __attribute__((swift_name("quantize(calibData:inputsDtype:outputsDtype:perChannel:)")));
		[Export ("quantize:inputsDtype:outputsDtype:perChannel:")]
		Net Quantize (Mat[] calibData, int inputsDtype, int outputsDtype, bool perChannel);

		// -(Net * _Nonnull)quantize:(NSArray<Mat *> * _Nonnull)calibData inputsDtype:(int)inputsDtype outputsDtype:(int)outputsDtype __attribute__((swift_name("quantize(calibData:inputsDtype:outputsDtype:)")));
		[Export ("quantize:inputsDtype:outputsDtype:")]
		Net Quantize (Mat[] calibData, int inputsDtype, int outputsDtype);

		// -(void)getInputDetails:(FloatVector * _Nonnull)scales zeropoints:(IntVector * _Nonnull)zeropoints __attribute__((swift_name("getInputDetails(scales:zeropoints:)")));
		[Export ("getInputDetails:zeropoints:")]
		void GetInputDetails (FloatVector scales, IntVector zeropoints);

		// -(void)getOutputDetails:(FloatVector * _Nonnull)scales zeropoints:(IntVector * _Nonnull)zeropoints __attribute__((swift_name("getOutputDetails(scales:zeropoints:)")));
		[Export ("getOutputDetails:zeropoints:")]
		void GetOutputDetails (FloatVector scales, IntVector zeropoints);

		// -(void)setHalideScheduler:(NSString * _Nonnull)scheduler __attribute__((swift_name("setHalideScheduler(scheduler:)")));
		[Export ("setHalideScheduler:")]
		void SetHalideScheduler (string scheduler);

		// -(void)setPreferableBackend:(int)backendId __attribute__((swift_name("setPreferableBackend(backendId:)")));
		[Export ("setPreferableBackend:")]
		void SetPreferableBackend (int backendId);

		// -(void)setPreferableTarget:(int)targetId __attribute__((swift_name("setPreferableTarget(targetId:)")));
		[Export ("setPreferableTarget:")]
		void SetPreferableTarget (int targetId);

		// -(void)setInput:(Mat * _Nonnull)blob name:(NSString * _Nonnull)name scalefactor:(double)scalefactor mean:(Scalar * _Nonnull)mean __attribute__((swift_name("setInput(blob:name:scalefactor:mean:)")));
		[Export ("setInput:name:scalefactor:mean:")]
		void SetInput (Mat blob, string name, double scalefactor, Scalar mean);

		// -(void)setInput:(Mat * _Nonnull)blob name:(NSString * _Nonnull)name scalefactor:(double)scalefactor __attribute__((swift_name("setInput(blob:name:scalefactor:)")));
		[Export ("setInput:name:scalefactor:")]
		void SetInput (Mat blob, string name, double scalefactor);

		// -(void)setInput:(Mat * _Nonnull)blob name:(NSString * _Nonnull)name __attribute__((swift_name("setInput(blob:name:)")));
		[Export ("setInput:name:")]
		void SetInput (Mat blob, string name);

		// -(void)setInput:(Mat * _Nonnull)blob __attribute__((swift_name("setInput(blob:)")));
		[Export ("setInput:")]
		void SetInput (Mat blob);

		// -(void)setParam:(int)layer numParam:(int)numParam blob:(Mat * _Nonnull)blob __attribute__((swift_name("setParam(layer:numParam:blob:)")));
		[Export ("setParam:numParam:blob:")]
		void SetParam (int layer, int numParam, Mat blob);

		// -(void)setParamByName:(NSString * _Nonnull)layerName numParam:(int)numParam blob:(Mat * _Nonnull)blob __attribute__((swift_name("setParam(layerName:numParam:blob:)")));
		[Export ("setParamByName:numParam:blob:")]
		void SetParamByName (string layerName, int numParam, Mat blob);

		// -(Mat * _Nonnull)getParam:(int)layer numParam:(int)numParam __attribute__((swift_name("getParam(layer:numParam:)")));
		[Export ("getParam:numParam:")]
		Mat GetParam (int layer, int numParam);

		// -(Mat * _Nonnull)getParam:(int)layer __attribute__((swift_name("getParam(layer:)")));
		[Export ("getParam:")]
		Mat GetParam (int layer);

		// -(Mat * _Nonnull)getParamByName:(NSString * _Nonnull)layerName numParam:(int)numParam __attribute__((swift_name("getParam(layerName:numParam:)")));
		[Export ("getParamByName:numParam:")]
		Mat GetParamByName (string layerName, int numParam);

		// -(Mat * _Nonnull)getParamByName:(NSString * _Nonnull)layerName __attribute__((swift_name("getParam(layerName:)")));
		[Export ("getParamByName:")]
		Mat GetParamByName (string layerName);

		// -(IntVector * _Nonnull)getUnconnectedOutLayers __attribute__((swift_name("getUnconnectedOutLayers()")));
		[Export ("getUnconnectedOutLayers")]
		IntVector UnconnectedOutLayers { get; }

		// -(NSArray<NSString *> * _Nonnull)getUnconnectedOutLayersNames __attribute__((swift_name("getUnconnectedOutLayersNames()")));
		[Export ("getUnconnectedOutLayersNames")]
		string[] UnconnectedOutLayersNames { get; }

		// -(void)getLayersShapesWithNetInputShapes:(NSArray<IntVector *> * _Nonnull)netInputShapes layersIds:(IntVector * _Nonnull)layersIds inLayersShapes:(NSMutableArray<NSMutableArray<IntVector *> *> * _Nonnull)inLayersShapes outLayersShapes:(NSMutableArray<NSMutableArray<IntVector *> *> * _Nonnull)outLayersShapes __attribute__((swift_name("getLayersShapes(netInputShapes:layersIds:inLayersShapes:outLayersShapes:)")));
		[Export ("getLayersShapesWithNetInputShapes:layersIds:inLayersShapes:outLayersShapes:")]
		void GetLayersShapesWithNetInputShapes (IntVector[] netInputShapes, IntVector layersIds, NSMutableArray<NSMutableArray<IntVector>> inLayersShapes, NSMutableArray<NSMutableArray<IntVector>> outLayersShapes);

		// -(void)getLayersShapesWithNetInputShape:(IntVector * _Nonnull)netInputShape layersIds:(IntVector * _Nonnull)layersIds inLayersShapes:(NSMutableArray<NSMutableArray<IntVector *> *> * _Nonnull)inLayersShapes outLayersShapes:(NSMutableArray<NSMutableArray<IntVector *> *> * _Nonnull)outLayersShapes __attribute__((swift_name("getLayersShapes(netInputShape:layersIds:inLayersShapes:outLayersShapes:)")));
		[Export ("getLayersShapesWithNetInputShape:layersIds:inLayersShapes:outLayersShapes:")]
		void GetLayersShapesWithNetInputShape (IntVector netInputShape, IntVector layersIds, NSMutableArray<NSMutableArray<IntVector>> inLayersShapes, NSMutableArray<NSMutableArray<IntVector>> outLayersShapes);

		// -(long)getFLOPSWithNetInputShapes:(NSArray<IntVector *> * _Nonnull)netInputShapes __attribute__((swift_name("getFLOPS(netInputShapes:)")));
		[Export ("getFLOPSWithNetInputShapes:")]
		nint GetFLOPSWithNetInputShapes (IntVector[] netInputShapes);

		// -(long)getFLOPSWithNetInputShape:(IntVector * _Nonnull)netInputShape __attribute__((swift_name("getFLOPS(netInputShape:)")));
		[Export ("getFLOPSWithNetInputShape:")]
		nint GetFLOPSWithNetInputShape (IntVector netInputShape);

		// -(long)getFLOPSWithLayerId:(int)layerId netInputShapes:(NSArray<IntVector *> * _Nonnull)netInputShapes __attribute__((swift_name("getFLOPS(layerId:netInputShapes:)")));
		[Export ("getFLOPSWithLayerId:netInputShapes:")]
		nint GetFLOPSWithLayerId (int layerId, IntVector[] netInputShapes);

		// -(long)getFLOPSWithLayerId:(int)layerId netInputShape:(IntVector * _Nonnull)netInputShape __attribute__((swift_name("getFLOPS(layerId:netInputShape:)")));
		[Export ("getFLOPSWithLayerId:netInputShape:")]
		nint GetFLOPSWithLayerId (int layerId, IntVector netInputShape);

		// -(void)getLayerTypes:(NSMutableArray<NSString *> * _Nonnull)layersTypes __attribute__((swift_name("getLayerTypes(layersTypes:)")));
		[Export ("getLayerTypes:")]
		void GetLayerTypes (NSMutableArray<NSString> layersTypes);

		// -(int)getLayersCount:(NSString * _Nonnull)layerType __attribute__((swift_name("getLayersCount(layerType:)")));
		[Export ("getLayersCount:")]
		int GetLayersCount (string layerType);

		// -(void)getMemoryConsumption:(IntVector * _Nonnull)netInputShape weights:(size_t)weights blobs:(size_t)blobs __attribute__((swift_name("getMemoryConsumption(netInputShape:weights:blobs:)")));
		[Export ("getMemoryConsumption:weights:blobs:")]
		void GetMemoryConsumption (IntVector netInputShape, nuint weights, nuint blobs);

		// -(void)getMemoryConsumption:(int)layerId netInputShapes:(NSArray<IntVector *> * _Nonnull)netInputShapes weights:(size_t)weights blobs:(size_t)blobs __attribute__((swift_name("getMemoryConsumption(layerId:netInputShapes:weights:blobs:)")));
		[Export ("getMemoryConsumption:netInputShapes:weights:blobs:")]
		void GetMemoryConsumption (int layerId, IntVector[] netInputShapes, nuint weights, nuint blobs);

		// -(void)getMemoryConsumption:(int)layerId netInputShape:(IntVector * _Nonnull)netInputShape weights:(size_t)weights blobs:(size_t)blobs __attribute__((swift_name("getMemoryConsumption(layerId:netInputShape:weights:blobs:)")));
		[Export ("getMemoryConsumption:netInputShape:weights:blobs:")]
		void GetMemoryConsumption (int layerId, IntVector netInputShape, nuint weights, nuint blobs);

		// -(void)enableFusion:(BOOL)fusion __attribute__((swift_name("enableFusion(fusion:)")));
		[Export ("enableFusion:")]
		void EnableFusion (bool fusion);

		// -(void)enableWinograd:(BOOL)useWinograd __attribute__((swift_name("enableWinograd(useWinograd:)")));
		[Export ("enableWinograd:")]
		void EnableWinograd (bool useWinograd);

		// -(long)getPerfProfile:(DoubleVector * _Nonnull)timings __attribute__((swift_name("getPerfProfile(timings:)")));
		[Export ("getPerfProfile:")]
		nint GetPerfProfile (DoubleVector timings);
	}

	// @interface SegmentationModel : Model
	[BaseType (typeof(Model))]
	interface SegmentationModel
	{
		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model config:(NSString * _Nonnull)config;
		[Export ("initWithModel:config:")]
		NativeHandle Constructor (string model, string config);

		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model;
		[Export ("initWithModel:")]
		NativeHandle Constructor (string model);

		// -(instancetype _Nonnull)initWithNetwork:(Net * _Nonnull)network;
		[Export ("initWithNetwork:")]
		NativeHandle Constructor (Net network);

		// -(void)segment:(Mat * _Nonnull)frame mask:(Mat * _Nonnull)mask __attribute__((swift_name("segment(frame:mask:)")));
		[Export ("segment:mask:")]
		void Segment (Mat frame, Mat mask);
	}

	// @interface TextDetectionModel : Model
	[BaseType (typeof(Model))]
	interface TextDetectionModel
	{
		// -(void)detect:(Mat * _Nonnull)frame detections:(NSMutableArray<NSMutableArray<Point2i *> *> * _Nonnull)detections confidences:(FloatVector * _Nonnull)confidences __attribute__((swift_name("detect(frame:detections:confidences:)")));
		[Export ("detect:detections:confidences:")]
		void Detect (Mat frame, NSMutableArray<NSMutableArray<Point2i>> detections, FloatVector confidences);

		// -(void)detect:(Mat * _Nonnull)frame detections:(NSMutableArray<NSMutableArray<Point2i *> *> * _Nonnull)detections __attribute__((swift_name("detect(frame:detections:)")));
		[Export ("detect:detections:")]
		void Detect (Mat frame, NSMutableArray<NSMutableArray<Point2i>> detections);

		// -(void)detectTextRectangles:(Mat * _Nonnull)frame detections:(NSMutableArray<RotatedRect *> * _Nonnull)detections confidences:(FloatVector * _Nonnull)confidences __attribute__((swift_name("detectTextRectangles(frame:detections:confidences:)")));
		[Export ("detectTextRectangles:detections:confidences:")]
		void DetectTextRectangles (Mat frame, NSMutableArray<RotatedRect> detections, FloatVector confidences);

		// -(void)detectTextRectangles:(Mat * _Nonnull)frame detections:(NSMutableArray<RotatedRect *> * _Nonnull)detections __attribute__((swift_name("detectTextRectangles(frame:detections:)")));
		[Export ("detectTextRectangles:detections:")]
		void DetectTextRectangles (Mat frame, NSMutableArray<RotatedRect> detections);
	}

	// @interface TextDetectionModel_DB : TextDetectionModel
	[BaseType (typeof(TextDetectionModel))]
	interface TextDetectionModel_DB
	{
		// -(instancetype _Nonnull)initWithNetwork:(Net * _Nonnull)network;
		[Export ("initWithNetwork:")]
		NativeHandle Constructor (Net network);

		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model config:(NSString * _Nonnull)config;
		[Export ("initWithModel:config:")]
		NativeHandle Constructor (string model, string config);

		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model;
		[Export ("initWithModel:")]
		NativeHandle Constructor (string model);

		// -(TextDetectionModel_DB * _Nonnull)setBinaryThreshold:(float)binaryThreshold __attribute__((swift_name("setBinaryThreshold(binaryThreshold:)")));
		[Export ("setBinaryThreshold:")]
		TextDetectionModel_DB SetBinaryThreshold (float binaryThreshold);

		// -(float)getBinaryThreshold __attribute__((swift_name("getBinaryThreshold()")));
		[Export ("getBinaryThreshold")]
		float BinaryThreshold { get; }

		// -(TextDetectionModel_DB * _Nonnull)setPolygonThreshold:(float)polygonThreshold __attribute__((swift_name("setPolygonThreshold(polygonThreshold:)")));
		[Export ("setPolygonThreshold:")]
		TextDetectionModel_DB SetPolygonThreshold (float polygonThreshold);

		// -(float)getPolygonThreshold __attribute__((swift_name("getPolygonThreshold()")));
		[Export ("getPolygonThreshold")]
		float PolygonThreshold { get; }

		// -(TextDetectionModel_DB * _Nonnull)setUnclipRatio:(double)unclipRatio __attribute__((swift_name("setUnclipRatio(unclipRatio:)")));
		[Export ("setUnclipRatio:")]
		TextDetectionModel_DB SetUnclipRatio (double unclipRatio);

		// -(double)getUnclipRatio __attribute__((swift_name("getUnclipRatio()")));
		[Export ("getUnclipRatio")]
		double UnclipRatio { get; }

		// -(TextDetectionModel_DB * _Nonnull)setMaxCandidates:(int)maxCandidates __attribute__((swift_name("setMaxCandidates(maxCandidates:)")));
		[Export ("setMaxCandidates:")]
		TextDetectionModel_DB SetMaxCandidates (int maxCandidates);

		// -(int)getMaxCandidates __attribute__((swift_name("getMaxCandidates()")));
		[Export ("getMaxCandidates")]
		int MaxCandidates { get; }
	}

	// @interface TextDetectionModel_EAST : TextDetectionModel
	[BaseType (typeof(TextDetectionModel))]
	interface TextDetectionModel_EAST
	{
		// -(instancetype _Nonnull)initWithNetwork:(Net * _Nonnull)network;
		[Export ("initWithNetwork:")]
		NativeHandle Constructor (Net network);

		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model config:(NSString * _Nonnull)config;
		[Export ("initWithModel:config:")]
		NativeHandle Constructor (string model, string config);

		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model;
		[Export ("initWithModel:")]
		NativeHandle Constructor (string model);

		// -(TextDetectionModel_EAST * _Nonnull)setConfidenceThreshold:(float)confThreshold __attribute__((swift_name("setConfidenceThreshold(confThreshold:)")));
		[Export ("setConfidenceThreshold:")]
		TextDetectionModel_EAST SetConfidenceThreshold (float confThreshold);

		// -(float)getConfidenceThreshold __attribute__((swift_name("getConfidenceThreshold()")));
		[Export ("getConfidenceThreshold")]
		float ConfidenceThreshold { get; }

		// -(TextDetectionModel_EAST * _Nonnull)setNMSThreshold:(float)nmsThreshold __attribute__((swift_name("setNMSThreshold(nmsThreshold:)")));
		[Export ("setNMSThreshold:")]
		TextDetectionModel_EAST SetNMSThreshold (float nmsThreshold);

		// -(float)getNMSThreshold __attribute__((swift_name("getNMSThreshold()")));
		[Export ("getNMSThreshold")]
		float NMSThreshold { get; }
	}

	// @interface TextRecognitionModel : Model
	[BaseType (typeof(Model))]
	interface TextRecognitionModel
	{
		// -(instancetype _Nonnull)initWithNetwork:(Net * _Nonnull)network;
		[Export ("initWithNetwork:")]
		NativeHandle Constructor (Net network);

		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model config:(NSString * _Nonnull)config;
		[Export ("initWithModel:config:")]
		NativeHandle Constructor (string model, string config);

		// -(instancetype _Nonnull)initWithModel:(NSString * _Nonnull)model;
		[Export ("initWithModel:")]
		NativeHandle Constructor (string model);

		// -(TextRecognitionModel * _Nonnull)setDecodeType:(NSString * _Nonnull)decodeType __attribute__((swift_name("setDecodeType(decodeType:)")));
		[Export ("setDecodeType:")]
		TextRecognitionModel SetDecodeType (string decodeType);

		// -(NSString * _Nonnull)getDecodeType __attribute__((swift_name("getDecodeType()")));
		[Export ("getDecodeType")]
		string DecodeType { get; }

		// -(TextRecognitionModel * _Nonnull)setDecodeOptsCTCPrefixBeamSearch:(int)beamSize vocPruneSize:(int)vocPruneSize __attribute__((swift_name("setDecodeOptsCTCPrefixBeamSearch(beamSize:vocPruneSize:)")));
		[Export ("setDecodeOptsCTCPrefixBeamSearch:vocPruneSize:")]
		TextRecognitionModel SetDecodeOptsCTCPrefixBeamSearch (int beamSize, int vocPruneSize);

		// -(TextRecognitionModel * _Nonnull)setDecodeOptsCTCPrefixBeamSearch:(int)beamSize __attribute__((swift_name("setDecodeOptsCTCPrefixBeamSearch(beamSize:)")));
		[Export ("setDecodeOptsCTCPrefixBeamSearch:")]
		TextRecognitionModel SetDecodeOptsCTCPrefixBeamSearch (int beamSize);

		// -(TextRecognitionModel * _Nonnull)setVocabulary:(NSArray<NSString *> * _Nonnull)vocabulary __attribute__((swift_name("setVocabulary(vocabulary:)")));
		[Export ("setVocabulary:")]
		TextRecognitionModel SetVocabulary (string[] vocabulary);

		// -(NSArray<NSString *> * _Nonnull)getVocabulary __attribute__((swift_name("getVocabulary()")));
		[Export ("getVocabulary")]
		string[] Vocabulary { get; }

		// -(NSString * _Nonnull)recognize:(Mat * _Nonnull)frame __attribute__((swift_name("recognize(frame:)")));
		[Export ("recognize:")]
		string Recognize (Mat frame);

		// -(void)recognize:(Mat * _Nonnull)frame roiRects:(NSArray<Mat *> * _Nonnull)roiRects results:(NSMutableArray<NSString *> * _Nonnull)results __attribute__((swift_name("recognize(frame:roiRects:results:)")));
		[Export ("recognize:roiRects:results:")]
		void Recognize (Mat frame, Mat[] roiRects, NSMutableArray<NSString> results);
	}

	// @interface Features2d : NSObject
	[BaseType (typeof(NSObject))]
	interface Features2d
	{
		// +(void)drawKeypoints:(Mat * _Nonnull)image keypoints:(NSArray<KeyPoint *> * _Nonnull)keypoints outImage:(Mat * _Nonnull)outImage color:(Scalar * _Nonnull)color flags:(DrawMatchesFlags)flags __attribute__((swift_name("drawKeypoints(image:keypoints:outImage:color:flags:)")));
		[Static]
		[Export ("drawKeypoints:keypoints:outImage:color:flags:")]
		void DrawKeypoints (Mat image, KeyPoint[] keypoints, Mat outImage, Scalar color, DrawMatchesFlags flags);

		// +(void)drawKeypoints:(Mat * _Nonnull)image keypoints:(NSArray<KeyPoint *> * _Nonnull)keypoints outImage:(Mat * _Nonnull)outImage color:(Scalar * _Nonnull)color __attribute__((swift_name("drawKeypoints(image:keypoints:outImage:color:)")));
		[Static]
		[Export ("drawKeypoints:keypoints:outImage:color:")]
		void DrawKeypoints (Mat image, KeyPoint[] keypoints, Mat outImage, Scalar color);

		// +(void)drawKeypoints:(Mat * _Nonnull)image keypoints:(NSArray<KeyPoint *> * _Nonnull)keypoints outImage:(Mat * _Nonnull)outImage __attribute__((swift_name("drawKeypoints(image:keypoints:outImage:)")));
		[Static]
		[Export ("drawKeypoints:keypoints:outImage:")]
		void DrawKeypoints (Mat image, KeyPoint[] keypoints, Mat outImage);

		// +(void)drawMatches:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<DMatch *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg matchColor:(Scalar * _Nonnull)matchColor singlePointColor:(Scalar * _Nonnull)singlePointColor matchesMask:(ByteVector * _Nonnull)matchesMask flags:(DrawMatchesFlags)flags __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:singlePointColor:matchesMask:flags:)")));
		[Static]
		[Export ("drawMatches:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:singlePointColor:matchesMask:flags:")]
		void DrawMatches (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, DMatch[] matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor, ByteVector matchesMask, DrawMatchesFlags flags);

		// +(void)drawMatches:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<DMatch *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg matchColor:(Scalar * _Nonnull)matchColor singlePointColor:(Scalar * _Nonnull)singlePointColor matchesMask:(ByteVector * _Nonnull)matchesMask __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:singlePointColor:matchesMask:)")));
		[Static]
		[Export ("drawMatches:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:singlePointColor:matchesMask:")]
		void DrawMatches (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, DMatch[] matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor, ByteVector matchesMask);

		// +(void)drawMatches:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<DMatch *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg matchColor:(Scalar * _Nonnull)matchColor singlePointColor:(Scalar * _Nonnull)singlePointColor __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:singlePointColor:)")));
		[Static]
		[Export ("drawMatches:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:singlePointColor:")]
		void DrawMatches (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, DMatch[] matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor);

		// +(void)drawMatches:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<DMatch *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg matchColor:(Scalar * _Nonnull)matchColor __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:)")));
		[Static]
		[Export ("drawMatches:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:")]
		void DrawMatches (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, DMatch[] matches1to2, Mat outImg, Scalar matchColor);

		// +(void)drawMatches:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<DMatch *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:)")));
		[Static]
		[Export ("drawMatches:keypoints1:img2:keypoints2:matches1to2:outImg:")]
		void DrawMatches (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, DMatch[] matches1to2, Mat outImg);

		// +(void)drawMatches:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<DMatch *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg matchesThickness:(int)matchesThickness matchColor:(Scalar * _Nonnull)matchColor singlePointColor:(Scalar * _Nonnull)singlePointColor matchesMask:(ByteVector * _Nonnull)matchesMask flags:(DrawMatchesFlags)flags __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:matchesThickness:matchColor:singlePointColor:matchesMask:flags:)")));
		[Static]
		[Export ("drawMatches:keypoints1:img2:keypoints2:matches1to2:outImg:matchesThickness:matchColor:singlePointColor:matchesMask:flags:")]
		void DrawMatches (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, DMatch[] matches1to2, Mat outImg, int matchesThickness, Scalar matchColor, Scalar singlePointColor, ByteVector matchesMask, DrawMatchesFlags flags);

		// +(void)drawMatches:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<DMatch *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg matchesThickness:(int)matchesThickness matchColor:(Scalar * _Nonnull)matchColor singlePointColor:(Scalar * _Nonnull)singlePointColor matchesMask:(ByteVector * _Nonnull)matchesMask __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:matchesThickness:matchColor:singlePointColor:matchesMask:)")));
		[Static]
		[Export ("drawMatches:keypoints1:img2:keypoints2:matches1to2:outImg:matchesThickness:matchColor:singlePointColor:matchesMask:")]
		void DrawMatches (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, DMatch[] matches1to2, Mat outImg, int matchesThickness, Scalar matchColor, Scalar singlePointColor, ByteVector matchesMask);

		// +(void)drawMatches:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<DMatch *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg matchesThickness:(int)matchesThickness matchColor:(Scalar * _Nonnull)matchColor singlePointColor:(Scalar * _Nonnull)singlePointColor __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:matchesThickness:matchColor:singlePointColor:)")));
		[Static]
		[Export ("drawMatches:keypoints1:img2:keypoints2:matches1to2:outImg:matchesThickness:matchColor:singlePointColor:")]
		void DrawMatches (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, DMatch[] matches1to2, Mat outImg, int matchesThickness, Scalar matchColor, Scalar singlePointColor);

		// +(void)drawMatches:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<DMatch *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg matchesThickness:(int)matchesThickness matchColor:(Scalar * _Nonnull)matchColor __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:matchesThickness:matchColor:)")));
		[Static]
		[Export ("drawMatches:keypoints1:img2:keypoints2:matches1to2:outImg:matchesThickness:matchColor:")]
		void DrawMatches (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, DMatch[] matches1to2, Mat outImg, int matchesThickness, Scalar matchColor);

		// +(void)drawMatches:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<DMatch *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg matchesThickness:(int)matchesThickness __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:matchesThickness:)")));
		[Static]
		[Export ("drawMatches:keypoints1:img2:keypoints2:matches1to2:outImg:matchesThickness:")]
		void DrawMatches (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, DMatch[] matches1to2, Mat outImg, int matchesThickness);

		// +(void)drawMatchesKnn:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<NSArray<DMatch *> *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg matchColor:(Scalar * _Nonnull)matchColor singlePointColor:(Scalar * _Nonnull)singlePointColor matchesMask:(NSArray<ByteVector *> * _Nonnull)matchesMask flags:(DrawMatchesFlags)flags __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:singlePointColor:matchesMask:flags:)")));
		[Static]
		[Export ("drawMatchesKnn:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:singlePointColor:matchesMask:flags:")]
		void DrawMatchesKnn (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, NSArray<DMatch>[] matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor, ByteVector[] matchesMask, DrawMatchesFlags flags);

		// +(void)drawMatchesKnn:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<NSArray<DMatch *> *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg matchColor:(Scalar * _Nonnull)matchColor singlePointColor:(Scalar * _Nonnull)singlePointColor matchesMask:(NSArray<ByteVector *> * _Nonnull)matchesMask __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:singlePointColor:matchesMask:)")));
		[Static]
		[Export ("drawMatchesKnn:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:singlePointColor:matchesMask:")]
		void DrawMatchesKnn (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, NSArray<DMatch>[] matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor, ByteVector[] matchesMask);

		// +(void)drawMatchesKnn:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<NSArray<DMatch *> *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg matchColor:(Scalar * _Nonnull)matchColor singlePointColor:(Scalar * _Nonnull)singlePointColor __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:singlePointColor:)")));
		[Static]
		[Export ("drawMatchesKnn:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:singlePointColor:")]
		void DrawMatchesKnn (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, NSArray<DMatch>[] matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor);

		// +(void)drawMatchesKnn:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<NSArray<DMatch *> *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg matchColor:(Scalar * _Nonnull)matchColor __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:)")));
		[Static]
		[Export ("drawMatchesKnn:keypoints1:img2:keypoints2:matches1to2:outImg:matchColor:")]
		void DrawMatchesKnn (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, NSArray<DMatch>[] matches1to2, Mat outImg, Scalar matchColor);

		// +(void)drawMatchesKnn:(Mat * _Nonnull)img1 keypoints1:(NSArray<KeyPoint *> * _Nonnull)keypoints1 img2:(Mat * _Nonnull)img2 keypoints2:(NSArray<KeyPoint *> * _Nonnull)keypoints2 matches1to2:(NSArray<NSArray<DMatch *> *> * _Nonnull)matches1to2 outImg:(Mat * _Nonnull)outImg __attribute__((swift_name("drawMatches(img1:keypoints1:img2:keypoints2:matches1to2:outImg:)")));
		[Static]
		[Export ("drawMatchesKnn:keypoints1:img2:keypoints2:matches1to2:outImg:")]
		void DrawMatchesKnn (Mat img1, KeyPoint[] keypoints1, Mat img2, KeyPoint[] keypoints2, NSArray<DMatch>[] matches1to2, Mat outImg);
	}

	// @interface Feature2D : Algorithm
	[BaseType (typeof(Algorithm))]
	interface Feature2D
	{
		// -(void)detect:(Mat * _Nonnull)image keypoints:(NSMutableArray<KeyPoint *> * _Nonnull)keypoints mask:(Mat * _Nonnull)mask __attribute__((swift_name("detect(image:keypoints:mask:)")));
		[Export ("detect:keypoints:mask:")]
		void Detect (Mat image, NSMutableArray<KeyPoint> keypoints, Mat mask);

		// -(void)detect:(Mat * _Nonnull)image keypoints:(NSMutableArray<KeyPoint *> * _Nonnull)keypoints __attribute__((swift_name("detect(image:keypoints:)")));
		[Export ("detect:keypoints:")]
		void Detect (Mat image, NSMutableArray<KeyPoint> keypoints);

		// -(void)detect2:(NSArray<Mat *> * _Nonnull)images keypoints:(NSMutableArray<NSMutableArray<KeyPoint *> *> * _Nonnull)keypoints masks:(NSArray<Mat *> * _Nonnull)masks __attribute__((swift_name("detect(images:keypoints:masks:)")));
		[Export ("detect2:keypoints:masks:")]
		void Detect2 (Mat[] images, NSMutableArray<NSMutableArray<KeyPoint>> keypoints, Mat[] masks);

		// -(void)detect2:(NSArray<Mat *> * _Nonnull)images keypoints:(NSMutableArray<NSMutableArray<KeyPoint *> *> * _Nonnull)keypoints __attribute__((swift_name("detect(images:keypoints:)")));
		[Export ("detect2:keypoints:")]
		void Detect2 (Mat[] images, NSMutableArray<NSMutableArray<KeyPoint>> keypoints);

		// -(void)compute:(Mat * _Nonnull)image keypoints:(NSMutableArray<KeyPoint *> * _Nonnull)keypoints descriptors:(Mat * _Nonnull)descriptors __attribute__((swift_name("compute(image:keypoints:descriptors:)")));
		[Export ("compute:keypoints:descriptors:")]
		void Compute (Mat image, NSMutableArray<KeyPoint> keypoints, Mat descriptors);

		// -(void)compute2:(NSArray<Mat *> * _Nonnull)images keypoints:(NSMutableArray<NSMutableArray<KeyPoint *> *> * _Nonnull)keypoints descriptors:(NSMutableArray<Mat *> * _Nonnull)descriptors __attribute__((swift_name("compute(images:keypoints:descriptors:)")));
		[Export ("compute2:keypoints:descriptors:")]
		void Compute2 (Mat[] images, NSMutableArray<NSMutableArray<KeyPoint>> keypoints, NSMutableArray<Mat> descriptors);

		// -(void)detectAndCompute:(Mat * _Nonnull)image mask:(Mat * _Nonnull)mask keypoints:(NSMutableArray<KeyPoint *> * _Nonnull)keypoints descriptors:(Mat * _Nonnull)descriptors useProvidedKeypoints:(BOOL)useProvidedKeypoints __attribute__((swift_name("detectAndCompute(image:mask:keypoints:descriptors:useProvidedKeypoints:)")));
		[Export ("detectAndCompute:mask:keypoints:descriptors:useProvidedKeypoints:")]
		void DetectAndCompute (Mat image, Mat mask, NSMutableArray<KeyPoint> keypoints, Mat descriptors, bool useProvidedKeypoints);

		// -(void)detectAndCompute:(Mat * _Nonnull)image mask:(Mat * _Nonnull)mask keypoints:(NSMutableArray<KeyPoint *> * _Nonnull)keypoints descriptors:(Mat * _Nonnull)descriptors __attribute__((swift_name("detectAndCompute(image:mask:keypoints:descriptors:)")));
		[Export ("detectAndCompute:mask:keypoints:descriptors:")]
		void DetectAndCompute (Mat image, Mat mask, NSMutableArray<KeyPoint> keypoints, Mat descriptors);

		// -(int)descriptorSize __attribute__((swift_name("descriptorSize()")));
		[Export ("descriptorSize")]
		int DescriptorSize { get; }

		// -(int)descriptorType __attribute__((swift_name("descriptorType()")));
		[Export ("descriptorType")]
		int DescriptorType { get; }

		// -(int)defaultNorm __attribute__((swift_name("defaultNorm()")));
		[Export ("defaultNorm")]
		int DefaultNorm { get; }

		// -(void)write:(NSString * _Nonnull)fileName __attribute__((swift_name("write(fileName:)")));
		[Export ("write:")]
		void Write (string fileName);

		// -(void)read:(NSString * _Nonnull)fileName __attribute__((swift_name("read(fileName:)")));
		[Export ("read:")]
		void Read (string fileName);

		// -(BOOL)empty __attribute__((swift_name("empty()")));
		[Export ("empty")]
		bool Empty { get; }

		// -(NSString * _Nonnull)getDefaultName __attribute__((swift_name("getDefaultName()")));
		[Export ("getDefaultName")]
		string DefaultName { get; }
	}

	// @interface KAZE : Feature2D
	[BaseType (typeof(Feature2D))]
	interface KAZE
	{
		// +(KAZE * _Nonnull)create:(BOOL)extended upright:(BOOL)upright threshold:(float)threshold nOctaves:(int)nOctaves nOctaveLayers:(int)nOctaveLayers diffusivity:(DiffusivityType)diffusivity __attribute__((swift_name("create(extended:upright:threshold:nOctaves:nOctaveLayers:diffusivity:)")));
		[Static]
		[Export ("create:upright:threshold:nOctaves:nOctaveLayers:diffusivity:")]
		KAZE Create (bool extended, bool upright, float threshold, int nOctaves, int nOctaveLayers, DiffusivityType diffusivity);

		// +(KAZE * _Nonnull)create:(BOOL)extended upright:(BOOL)upright threshold:(float)threshold nOctaves:(int)nOctaves nOctaveLayers:(int)nOctaveLayers __attribute__((swift_name("create(extended:upright:threshold:nOctaves:nOctaveLayers:)")));
		[Static]
		[Export ("create:upright:threshold:nOctaves:nOctaveLayers:")]
		KAZE Create (bool extended, bool upright, float threshold, int nOctaves, int nOctaveLayers);

		// +(KAZE * _Nonnull)create:(BOOL)extended upright:(BOOL)upright threshold:(float)threshold nOctaves:(int)nOctaves __attribute__((swift_name("create(extended:upright:threshold:nOctaves:)")));
		[Static]
		[Export ("create:upright:threshold:nOctaves:")]
		KAZE Create (bool extended, bool upright, float threshold, int nOctaves);

		// +(KAZE * _Nonnull)create:(BOOL)extended upright:(BOOL)upright threshold:(float)threshold __attribute__((swift_name("create(extended:upright:threshold:)")));
		[Static]
		[Export ("create:upright:threshold:")]
		KAZE Create (bool extended, bool upright, float threshold);

		// +(KAZE * _Nonnull)create:(BOOL)extended upright:(BOOL)upright __attribute__((swift_name("create(extended:upright:)")));
		[Static]
		[Export ("create:upright:")]
		KAZE Create (bool extended, bool upright);

		// +(KAZE * _Nonnull)create:(BOOL)extended __attribute__((swift_name("create(extended:)")));
		[Static]
		[Export ("create:")]
		KAZE Create (bool extended);

		// +(KAZE * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		KAZE Create ();

		// -(void)setExtended:(BOOL)extended __attribute__((swift_name("setExtended(extended:)")));
		[Export ("setExtended:")]
		void SetExtended (bool extended);

		// -(BOOL)getExtended __attribute__((swift_name("getExtended()")));
		[Export ("getExtended")]
		bool Extended { get; }

		// -(void)setUpright:(BOOL)upright __attribute__((swift_name("setUpright(upright:)")));
		[Export ("setUpright:")]
		void SetUpright (bool upright);

		// -(BOOL)getUpright __attribute__((swift_name("getUpright()")));
		[Export ("getUpright")]
		bool Upright { get; }

		// -(void)setThreshold:(double)threshold __attribute__((swift_name("setThreshold(threshold:)")));
		[Export ("setThreshold:")]
		void SetThreshold (double threshold);

		// -(double)getThreshold __attribute__((swift_name("getThreshold()")));
		[Export ("getThreshold")]
		double Threshold { get; }

		// -(void)setNOctaves:(int)octaves __attribute__((swift_name("setNOctaves(octaves:)")));
		[Export ("setNOctaves:")]
		void SetNOctaves (int octaves);

		// -(int)getNOctaves __attribute__((swift_name("getNOctaves()")));
		[Export ("getNOctaves")]
		int NOctaves { get; }

		// -(void)setNOctaveLayers:(int)octaveLayers __attribute__((swift_name("setNOctaveLayers(octaveLayers:)")));
		[Export ("setNOctaveLayers:")]
		void SetNOctaveLayers (int octaveLayers);

		// -(int)getNOctaveLayers __attribute__((swift_name("getNOctaveLayers()")));
		[Export ("getNOctaveLayers")]
		int NOctaveLayers { get; }

		// -(void)setDiffusivity:(DiffusivityType)diff __attribute__((swift_name("setDiffusivity(diff:)")));
		[Export ("setDiffusivity:")]
		void SetDiffusivity (DiffusivityType diff);

		// -(DiffusivityType)getDiffusivity __attribute__((swift_name("getDiffusivity()")));
		[Export ("getDiffusivity")]
		DiffusivityType Diffusivity { get; }

		// -(NSString * _Nonnull)getDefaultName __attribute__((swift_name("getDefaultName()")));
		[Export ("getDefaultName")]
		string DefaultName { get; }
	}

	// @interface AKAZE : Feature2D
	[BaseType (typeof(Feature2D))]
	interface AKAZE
	{
		// +(AKAZE * _Nonnull)create:(DescriptorType)descriptor_type descriptor_size:(int)descriptor_size descriptor_channels:(int)descriptor_channels threshold:(float)threshold nOctaves:(int)nOctaves nOctaveLayers:(int)nOctaveLayers diffusivity:(DiffusivityType)diffusivity max_points:(int)max_points __attribute__((swift_name("create(descriptor_type:descriptor_size:descriptor_channels:threshold:nOctaves:nOctaveLayers:diffusivity:max_points:)")));
		[Static]
		[Export ("create:descriptor_size:descriptor_channels:threshold:nOctaves:nOctaveLayers:diffusivity:max_points:")]
		AKAZE Create (DescriptorType descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves, int nOctaveLayers, DiffusivityType diffusivity, int max_points);

		// +(AKAZE * _Nonnull)create:(DescriptorType)descriptor_type descriptor_size:(int)descriptor_size descriptor_channels:(int)descriptor_channels threshold:(float)threshold nOctaves:(int)nOctaves nOctaveLayers:(int)nOctaveLayers diffusivity:(DiffusivityType)diffusivity __attribute__((swift_name("create(descriptor_type:descriptor_size:descriptor_channels:threshold:nOctaves:nOctaveLayers:diffusivity:)")));
		[Static]
		[Export ("create:descriptor_size:descriptor_channels:threshold:nOctaves:nOctaveLayers:diffusivity:")]
		AKAZE Create (DescriptorType descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves, int nOctaveLayers, DiffusivityType diffusivity);

		// +(AKAZE * _Nonnull)create:(DescriptorType)descriptor_type descriptor_size:(int)descriptor_size descriptor_channels:(int)descriptor_channels threshold:(float)threshold nOctaves:(int)nOctaves nOctaveLayers:(int)nOctaveLayers __attribute__((swift_name("create(descriptor_type:descriptor_size:descriptor_channels:threshold:nOctaves:nOctaveLayers:)")));
		[Static]
		[Export ("create:descriptor_size:descriptor_channels:threshold:nOctaves:nOctaveLayers:")]
		AKAZE Create (DescriptorType descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves, int nOctaveLayers);

		// +(AKAZE * _Nonnull)create:(DescriptorType)descriptor_type descriptor_size:(int)descriptor_size descriptor_channels:(int)descriptor_channels threshold:(float)threshold nOctaves:(int)nOctaves __attribute__((swift_name("create(descriptor_type:descriptor_size:descriptor_channels:threshold:nOctaves:)")));
		[Static]
		[Export ("create:descriptor_size:descriptor_channels:threshold:nOctaves:")]
		AKAZE Create (DescriptorType descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves);

		// +(AKAZE * _Nonnull)create:(DescriptorType)descriptor_type descriptor_size:(int)descriptor_size descriptor_channels:(int)descriptor_channels threshold:(float)threshold __attribute__((swift_name("create(descriptor_type:descriptor_size:descriptor_channels:threshold:)")));
		[Static]
		[Export ("create:descriptor_size:descriptor_channels:threshold:")]
		AKAZE Create (DescriptorType descriptor_type, int descriptor_size, int descriptor_channels, float threshold);

		// +(AKAZE * _Nonnull)create:(DescriptorType)descriptor_type descriptor_size:(int)descriptor_size descriptor_channels:(int)descriptor_channels __attribute__((swift_name("create(descriptor_type:descriptor_size:descriptor_channels:)")));
		[Static]
		[Export ("create:descriptor_size:descriptor_channels:")]
		AKAZE Create (DescriptorType descriptor_type, int descriptor_size, int descriptor_channels);

		// +(AKAZE * _Nonnull)create:(DescriptorType)descriptor_type descriptor_size:(int)descriptor_size __attribute__((swift_name("create(descriptor_type:descriptor_size:)")));
		[Static]
		[Export ("create:descriptor_size:")]
		AKAZE Create (DescriptorType descriptor_type, int descriptor_size);

		// +(AKAZE * _Nonnull)create:(DescriptorType)descriptor_type __attribute__((swift_name("create(descriptor_type:)")));
		[Static]
		[Export ("create:")]
		AKAZE Create (DescriptorType descriptor_type);

		// +(AKAZE * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		AKAZE Create ();

		// -(void)setDescriptorType:(DescriptorType)dtype __attribute__((swift_name("setDescriptorType(dtype:)")));
		[Export ("setDescriptorType:")]
		void SetDescriptorType (DescriptorType dtype);

		// -(DescriptorType)getDescriptorType __attribute__((swift_name("getDescriptorType()")));
		[Export ("getDescriptorType")]
		DescriptorType DescriptorType { get; }

		// -(void)setDescriptorSize:(int)dsize __attribute__((swift_name("setDescriptorSize(dsize:)")));
		[Export ("setDescriptorSize:")]
		void SetDescriptorSize (int dsize);

		// -(int)getDescriptorSize __attribute__((swift_name("getDescriptorSize()")));
		[Export ("getDescriptorSize")]
		int DescriptorSize { get; }

		// -(void)setDescriptorChannels:(int)dch __attribute__((swift_name("setDescriptorChannels(dch:)")));
		[Export ("setDescriptorChannels:")]
		void SetDescriptorChannels (int dch);

		// -(int)getDescriptorChannels __attribute__((swift_name("getDescriptorChannels()")));
		[Export ("getDescriptorChannels")]
		int DescriptorChannels { get; }

		// -(void)setThreshold:(double)threshold __attribute__((swift_name("setThreshold(threshold:)")));
		[Export ("setThreshold:")]
		void SetThreshold (double threshold);

		// -(double)getThreshold __attribute__((swift_name("getThreshold()")));
		[Export ("getThreshold")]
		double Threshold { get; }

		// -(void)setNOctaves:(int)octaves __attribute__((swift_name("setNOctaves(octaves:)")));
		[Export ("setNOctaves:")]
		void SetNOctaves (int octaves);

		// -(int)getNOctaves __attribute__((swift_name("getNOctaves()")));
		[Export ("getNOctaves")]
		int NOctaves { get; }

		// -(void)setNOctaveLayers:(int)octaveLayers __attribute__((swift_name("setNOctaveLayers(octaveLayers:)")));
		[Export ("setNOctaveLayers:")]
		void SetNOctaveLayers (int octaveLayers);

		// -(int)getNOctaveLayers __attribute__((swift_name("getNOctaveLayers()")));
		[Export ("getNOctaveLayers")]
		int NOctaveLayers { get; }

		// -(void)setDiffusivity:(DiffusivityType)diff __attribute__((swift_name("setDiffusivity(diff:)")));
		[Export ("setDiffusivity:")]
		void SetDiffusivity (DiffusivityType diff);

		// -(DiffusivityType)getDiffusivity __attribute__((swift_name("getDiffusivity()")));
		[Export ("getDiffusivity")]
		DiffusivityType Diffusivity { get; }

		// -(NSString * _Nonnull)getDefaultName __attribute__((swift_name("getDefaultName()")));
		[Export ("getDefaultName")]
		string DefaultName { get; }

		// -(void)setMaxPoints:(int)max_points __attribute__((swift_name("setMaxPoints(max_points:)")));
		[Export ("setMaxPoints:")]
		void SetMaxPoints (int max_points);

		// -(int)getMaxPoints __attribute__((swift_name("getMaxPoints()")));
		[Export ("getMaxPoints")]
		int MaxPoints { get; }
	}

	// @interface AffineFeature : Feature2D
	[BaseType (typeof(Feature2D))]
	interface AffineFeature
	{
		// +(AffineFeature * _Nonnull)create:(Feature2D * _Nonnull)backend maxTilt:(int)maxTilt minTilt:(int)minTilt tiltStep:(float)tiltStep rotateStepBase:(float)rotateStepBase __attribute__((swift_name("create(backend:maxTilt:minTilt:tiltStep:rotateStepBase:)")));
		[Static]
		[Export ("create:maxTilt:minTilt:tiltStep:rotateStepBase:")]
		AffineFeature Create (Feature2D backend, int maxTilt, int minTilt, float tiltStep, float rotateStepBase);

		// +(AffineFeature * _Nonnull)create:(Feature2D * _Nonnull)backend maxTilt:(int)maxTilt minTilt:(int)minTilt tiltStep:(float)tiltStep __attribute__((swift_name("create(backend:maxTilt:minTilt:tiltStep:)")));
		[Static]
		[Export ("create:maxTilt:minTilt:tiltStep:")]
		AffineFeature Create (Feature2D backend, int maxTilt, int minTilt, float tiltStep);

		// +(AffineFeature * _Nonnull)create:(Feature2D * _Nonnull)backend maxTilt:(int)maxTilt minTilt:(int)minTilt __attribute__((swift_name("create(backend:maxTilt:minTilt:)")));
		[Static]
		[Export ("create:maxTilt:minTilt:")]
		AffineFeature Create (Feature2D backend, int maxTilt, int minTilt);

		// +(AffineFeature * _Nonnull)create:(Feature2D * _Nonnull)backend maxTilt:(int)maxTilt __attribute__((swift_name("create(backend:maxTilt:)")));
		[Static]
		[Export ("create:maxTilt:")]
		AffineFeature Create (Feature2D backend, int maxTilt);

		// +(AffineFeature * _Nonnull)create:(Feature2D * _Nonnull)backend __attribute__((swift_name("create(backend:)")));
		[Static]
		[Export ("create:")]
		AffineFeature Create (Feature2D backend);

		// -(void)setViewParams:(FloatVector * _Nonnull)tilts rolls:(FloatVector * _Nonnull)rolls __attribute__((swift_name("setViewParams(tilts:rolls:)")));
		[Export ("setViewParams:rolls:")]
		void SetViewParams (FloatVector tilts, FloatVector rolls);

		// -(void)getViewParams:(FloatVector * _Nonnull)tilts rolls:(FloatVector * _Nonnull)rolls __attribute__((swift_name("getViewParams(tilts:rolls:)")));
		[Export ("getViewParams:rolls:")]
		void GetViewParams (FloatVector tilts, FloatVector rolls);

		// -(NSString * _Nonnull)getDefaultName __attribute__((swift_name("getDefaultName()")));
		[Export ("getDefaultName")]
		string DefaultName { get; }
	}

	// @interface AgastFeatureDetector : Feature2D
	[BaseType (typeof(Feature2D))]
	interface AgastFeatureDetector
	{
		// @property (readonly, class) int THRESHOLD __attribute__((swift_name("THRESHOLD")));
		[Static]
		[Export ("THRESHOLD")]
		int THRESHOLD { get; }

		// @property (readonly, class) int NONMAX_SUPPRESSION __attribute__((swift_name("NONMAX_SUPPRESSION")));
		[Static]
		[Export ("NONMAX_SUPPRESSION")]
		int NONMAX_SUPPRESSION { get; }

		// +(AgastFeatureDetector * _Nonnull)create:(int)threshold nonmaxSuppression:(BOOL)nonmaxSuppression type:(AgastDetectorType)type __attribute__((swift_name("create(threshold:nonmaxSuppression:type:)")));
		[Static]
		[Export ("create:nonmaxSuppression:type:")]
		AgastFeatureDetector Create (int threshold, bool nonmaxSuppression, AgastDetectorType type);

		// +(AgastFeatureDetector * _Nonnull)create:(int)threshold nonmaxSuppression:(BOOL)nonmaxSuppression __attribute__((swift_name("create(threshold:nonmaxSuppression:)")));
		[Static]
		[Export ("create:nonmaxSuppression:")]
		AgastFeatureDetector Create (int threshold, bool nonmaxSuppression);

		// +(AgastFeatureDetector * _Nonnull)create:(int)threshold __attribute__((swift_name("create(threshold:)")));
		[Static]
		[Export ("create:")]
		AgastFeatureDetector Create (int threshold);

		// +(AgastFeatureDetector * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		AgastFeatureDetector Create ();

		// -(void)setThreshold:(int)threshold __attribute__((swift_name("setThreshold(threshold:)")));
		[Export ("setThreshold:")]
		void SetThreshold (int threshold);

		// -(int)getThreshold __attribute__((swift_name("getThreshold()")));
		[Export ("getThreshold")]
		int Threshold { get; }

		// -(void)setNonmaxSuppression:(BOOL)f __attribute__((swift_name("setNonmaxSuppression(f:)")));
		[Export ("setNonmaxSuppression:")]
		void SetNonmaxSuppression (bool f);

		// -(BOOL)getNonmaxSuppression __attribute__((swift_name("getNonmaxSuppression()")));
		[Export ("getNonmaxSuppression")]
		bool NonmaxSuppression { get; }

		// -(void)setType:(AgastDetectorType)type __attribute__((swift_name("setType(type:)")));
		[Export ("setType:")]
		void SetType (AgastDetectorType type);

		// -(AgastDetectorType)getType __attribute__((swift_name("getType()")));
		[Export ("getType")]
		AgastDetectorType Type { get; }

		// -(NSString * _Nonnull)getDefaultName __attribute__((swift_name("getDefaultName()")));
		[Export ("getDefaultName")]
		string DefaultName { get; }
	}

	// @interface DescriptorMatcher : Algorithm
	[BaseType (typeof(Algorithm))]
	interface DescriptorMatcher
	{
		// -(void)add:(NSArray<Mat *> * _Nonnull)descriptors __attribute__((swift_name("add(descriptors:)")));
		[Export ("add:")]
		void Add (Mat[] descriptors);

		// -(NSArray<Mat *> * _Nonnull)getTrainDescriptors __attribute__((swift_name("getTrainDescriptors()")));
		[Export ("getTrainDescriptors")]
		Mat[] TrainDescriptors { get; }

		// -(void)clear __attribute__((swift_name("clear()")));
		[Export ("clear")]
		void Clear ();

		// -(BOOL)empty __attribute__((swift_name("empty()")));
		[Export ("empty")]
		bool Empty { get; }

		// -(BOOL)isMaskSupported __attribute__((swift_name("isMaskSupported()")));
		[Export ("isMaskSupported")]
		bool IsMaskSupported { get; }

		// -(void)train __attribute__((swift_name("train()")));
		[Export ("train")]
		void Train ();

		// -(void)match:(Mat * _Nonnull)queryDescriptors trainDescriptors:(Mat * _Nonnull)trainDescriptors matches:(NSMutableArray<DMatch *> * _Nonnull)matches mask:(Mat * _Nonnull)mask __attribute__((swift_name("match(queryDescriptors:trainDescriptors:matches:mask:)")));
		[Export ("match:trainDescriptors:matches:mask:")]
		void Match (Mat queryDescriptors, Mat trainDescriptors, NSMutableArray<DMatch> matches, Mat mask);

		// -(void)match:(Mat * _Nonnull)queryDescriptors trainDescriptors:(Mat * _Nonnull)trainDescriptors matches:(NSMutableArray<DMatch *> * _Nonnull)matches __attribute__((swift_name("match(queryDescriptors:trainDescriptors:matches:)")));
		[Export ("match:trainDescriptors:matches:")]
		void Match (Mat queryDescriptors, Mat trainDescriptors, NSMutableArray<DMatch> matches);

		// -(void)knnMatch:(Mat * _Nonnull)queryDescriptors trainDescriptors:(Mat * _Nonnull)trainDescriptors matches:(NSMutableArray<NSMutableArray<DMatch *> *> * _Nonnull)matches k:(int)k mask:(Mat * _Nonnull)mask compactResult:(BOOL)compactResult __attribute__((swift_name("knnMatch(queryDescriptors:trainDescriptors:matches:k:mask:compactResult:)")));
		[Export ("knnMatch:trainDescriptors:matches:k:mask:compactResult:")]
		void KnnMatch (Mat queryDescriptors, Mat trainDescriptors, NSMutableArray<NSMutableArray<DMatch>> matches, int k, Mat mask, bool compactResult);

		// -(void)knnMatch:(Mat * _Nonnull)queryDescriptors trainDescriptors:(Mat * _Nonnull)trainDescriptors matches:(NSMutableArray<NSMutableArray<DMatch *> *> * _Nonnull)matches k:(int)k mask:(Mat * _Nonnull)mask __attribute__((swift_name("knnMatch(queryDescriptors:trainDescriptors:matches:k:mask:)")));
		[Export ("knnMatch:trainDescriptors:matches:k:mask:")]
		void KnnMatch (Mat queryDescriptors, Mat trainDescriptors, NSMutableArray<NSMutableArray<DMatch>> matches, int k, Mat mask);

		// -(void)knnMatch:(Mat * _Nonnull)queryDescriptors trainDescriptors:(Mat * _Nonnull)trainDescriptors matches:(NSMutableArray<NSMutableArray<DMatch *> *> * _Nonnull)matches k:(int)k __attribute__((swift_name("knnMatch(queryDescriptors:trainDescriptors:matches:k:)")));
		[Export ("knnMatch:trainDescriptors:matches:k:")]
		void KnnMatch (Mat queryDescriptors, Mat trainDescriptors, NSMutableArray<NSMutableArray<DMatch>> matches, int k);

		// -(void)radiusMatch:(Mat * _Nonnull)queryDescriptors trainDescriptors:(Mat * _Nonnull)trainDescriptors matches:(NSMutableArray<NSMutableArray<DMatch *> *> * _Nonnull)matches maxDistance:(float)maxDistance mask:(Mat * _Nonnull)mask compactResult:(BOOL)compactResult __attribute__((swift_name("radiusMatch(queryDescriptors:trainDescriptors:matches:maxDistance:mask:compactResult:)")));
		[Export ("radiusMatch:trainDescriptors:matches:maxDistance:mask:compactResult:")]
		void RadiusMatch (Mat queryDescriptors, Mat trainDescriptors, NSMutableArray<NSMutableArray<DMatch>> matches, float maxDistance, Mat mask, bool compactResult);

		// -(void)radiusMatch:(Mat * _Nonnull)queryDescriptors trainDescriptors:(Mat * _Nonnull)trainDescriptors matches:(NSMutableArray<NSMutableArray<DMatch *> *> * _Nonnull)matches maxDistance:(float)maxDistance mask:(Mat * _Nonnull)mask __attribute__((swift_name("radiusMatch(queryDescriptors:trainDescriptors:matches:maxDistance:mask:)")));
		[Export ("radiusMatch:trainDescriptors:matches:maxDistance:mask:")]
		void RadiusMatch (Mat queryDescriptors, Mat trainDescriptors, NSMutableArray<NSMutableArray<DMatch>> matches, float maxDistance, Mat mask);

		// -(void)radiusMatch:(Mat * _Nonnull)queryDescriptors trainDescriptors:(Mat * _Nonnull)trainDescriptors matches:(NSMutableArray<NSMutableArray<DMatch *> *> * _Nonnull)matches maxDistance:(float)maxDistance __attribute__((swift_name("radiusMatch(queryDescriptors:trainDescriptors:matches:maxDistance:)")));
		[Export ("radiusMatch:trainDescriptors:matches:maxDistance:")]
		void RadiusMatch (Mat queryDescriptors, Mat trainDescriptors, NSMutableArray<NSMutableArray<DMatch>> matches, float maxDistance);

		// -(void)match:(Mat * _Nonnull)queryDescriptors matches:(NSMutableArray<DMatch *> * _Nonnull)matches masks:(NSArray<Mat *> * _Nonnull)masks __attribute__((swift_name("match(queryDescriptors:matches:masks:)")));
		[Export ("match:matches:masks:")]
		void Match (Mat queryDescriptors, NSMutableArray<DMatch> matches, Mat[] masks);

		// -(void)match:(Mat * _Nonnull)queryDescriptors matches:(NSMutableArray<DMatch *> * _Nonnull)matches __attribute__((swift_name("match(queryDescriptors:matches:)")));
		[Export ("match:matches:")]
		void Match (Mat queryDescriptors, NSMutableArray<DMatch> matches);

		// -(void)knnMatch:(Mat * _Nonnull)queryDescriptors matches:(NSMutableArray<NSMutableArray<DMatch *> *> * _Nonnull)matches k:(int)k masks:(NSArray<Mat *> * _Nonnull)masks compactResult:(BOOL)compactResult __attribute__((swift_name("knnMatch(queryDescriptors:matches:k:masks:compactResult:)")));
		[Export ("knnMatch:matches:k:masks:compactResult:")]
		void KnnMatch (Mat queryDescriptors, NSMutableArray<NSMutableArray<DMatch>> matches, int k, Mat[] masks, bool compactResult);

		// -(void)knnMatch:(Mat * _Nonnull)queryDescriptors matches:(NSMutableArray<NSMutableArray<DMatch *> *> * _Nonnull)matches k:(int)k masks:(NSArray<Mat *> * _Nonnull)masks __attribute__((swift_name("knnMatch(queryDescriptors:matches:k:masks:)")));
		[Export ("knnMatch:matches:k:masks:")]
		void KnnMatch (Mat queryDescriptors, NSMutableArray<NSMutableArray<DMatch>> matches, int k, Mat[] masks);

		// -(void)knnMatch:(Mat * _Nonnull)queryDescriptors matches:(NSMutableArray<NSMutableArray<DMatch *> *> * _Nonnull)matches k:(int)k __attribute__((swift_name("knnMatch(queryDescriptors:matches:k:)")));
		[Export ("knnMatch:matches:k:")]
		void KnnMatch (Mat queryDescriptors, NSMutableArray<NSMutableArray<DMatch>> matches, int k);

		// -(void)radiusMatch:(Mat * _Nonnull)queryDescriptors matches:(NSMutableArray<NSMutableArray<DMatch *> *> * _Nonnull)matches maxDistance:(float)maxDistance masks:(NSArray<Mat *> * _Nonnull)masks compactResult:(BOOL)compactResult __attribute__((swift_name("radiusMatch(queryDescriptors:matches:maxDistance:masks:compactResult:)")));
		[Export ("radiusMatch:matches:maxDistance:masks:compactResult:")]
		void RadiusMatch (Mat queryDescriptors, NSMutableArray<NSMutableArray<DMatch>> matches, float maxDistance, Mat[] masks, bool compactResult);

		// -(void)radiusMatch:(Mat * _Nonnull)queryDescriptors matches:(NSMutableArray<NSMutableArray<DMatch *> *> * _Nonnull)matches maxDistance:(float)maxDistance masks:(NSArray<Mat *> * _Nonnull)masks __attribute__((swift_name("radiusMatch(queryDescriptors:matches:maxDistance:masks:)")));
		[Export ("radiusMatch:matches:maxDistance:masks:")]
		void RadiusMatch (Mat queryDescriptors, NSMutableArray<NSMutableArray<DMatch>> matches, float maxDistance, Mat[] masks);

		// -(void)radiusMatch:(Mat * _Nonnull)queryDescriptors matches:(NSMutableArray<NSMutableArray<DMatch *> *> * _Nonnull)matches maxDistance:(float)maxDistance __attribute__((swift_name("radiusMatch(queryDescriptors:matches:maxDistance:)")));
		[Export ("radiusMatch:matches:maxDistance:")]
		void RadiusMatch (Mat queryDescriptors, NSMutableArray<NSMutableArray<DMatch>> matches, float maxDistance);

		// -(void)write:(NSString * _Nonnull)fileName __attribute__((swift_name("write(fileName:)")));
		[Export ("write:")]
		void Write (string fileName);

		// -(void)read:(NSString * _Nonnull)fileName __attribute__((swift_name("read(fileName:)")));
		[Export ("read:")]
		void Read (string fileName);

		// -(DescriptorMatcher * _Nonnull)clone:(BOOL)emptyTrainData __attribute__((swift_name("clone(emptyTrainData:)")));
		[Export ("clone:")]
		DescriptorMatcher Clone (bool emptyTrainData);

		// -(DescriptorMatcher * _Nonnull)clone __attribute__((swift_name("clone()")));
		[Export ("clone")]
		DescriptorMatcher Clone ();

		// +(DescriptorMatcher * _Nonnull)create2:(NSString * _Nonnull)descriptorMatcherType __attribute__((swift_name("create(descriptorMatcherType:)")));
		[Static]
		[Export ("create2:")]
		DescriptorMatcher Create2 (string descriptorMatcherType);

		// +(DescriptorMatcher * _Nonnull)create:(MatcherType)matcherType __attribute__((swift_name("create(matcherType:)")));
		[Static]
		[Export ("create:")]
		DescriptorMatcher Create (MatcherType matcherType);
	}

	// @interface BFMatcher : DescriptorMatcher
	[BaseType (typeof(DescriptorMatcher))]
	interface BFMatcher
	{
		// -(instancetype _Nonnull)initWithNormType:(NormTypes)normType crossCheck:(BOOL)crossCheck;
		[Export ("initWithNormType:crossCheck:")]
		NativeHandle Constructor (NormTypes normType, bool crossCheck);

		// -(instancetype _Nonnull)initWithNormType:(NormTypes)normType;
		[Export ("initWithNormType:")]
		NativeHandle Constructor (NormTypes normType);

		// +(BFMatcher * _Nonnull)createBFMatcher:(NormTypes)normType crossCheck:(BOOL)crossCheck __attribute__((swift_name("create(normType:crossCheck:)")));
		[Static]
		[Export ("createBFMatcher:crossCheck:")]
		BFMatcher CreateBFMatcher (NormTypes normType, bool crossCheck);

		// +(BFMatcher * _Nonnull)createBFMatcher:(NormTypes)normType __attribute__((swift_name("create(normType:)")));
		[Static]
		[Export ("createBFMatcher:")]
		BFMatcher CreateBFMatcher (NormTypes normType);

		// +(BFMatcher * _Nonnull)createBFMatcher __attribute__((swift_name("create()")));
		[Static]
		[Export ("createBFMatcher")]
		BFMatcher CreateBFMatcher ();
	}

	// @interface BOWImgDescriptorExtractor : NSObject
	[BaseType (typeof(NSObject))]
	interface BOWImgDescriptorExtractor
	{
		// -(instancetype _Nonnull)initWithDextractor:(Feature2D * _Nonnull)dextractor dmatcher:(DescriptorMatcher * _Nonnull)dmatcher;
		[Export ("initWithDextractor:dmatcher:")]
		NativeHandle Constructor (Feature2D dextractor, DescriptorMatcher dmatcher);

		// -(void)setVocabulary:(Mat * _Nonnull)vocabulary __attribute__((swift_name("setVocabulary(vocabulary:)")));
		[Export ("setVocabulary:")]
		void SetVocabulary (Mat vocabulary);

		// -(Mat * _Nonnull)getVocabulary __attribute__((swift_name("getVocabulary()")));
		[Export ("getVocabulary")]
		Mat Vocabulary { get; }

		// -(void)compute:(Mat * _Nonnull)image keypoints:(NSArray<KeyPoint *> * _Nonnull)keypoints imgDescriptor:(Mat * _Nonnull)imgDescriptor __attribute__((swift_name("compute2(image:keypoints:imgDescriptor:)")));
		[Export ("compute:keypoints:imgDescriptor:")]
		void Compute (Mat image, KeyPoint[] keypoints, Mat imgDescriptor);

		// -(int)descriptorSize __attribute__((swift_name("descriptorSize()")));
		[Export ("descriptorSize")]
		int DescriptorSize { get; }

		// -(int)descriptorType __attribute__((swift_name("descriptorType()")));
		[Export ("descriptorType")]
		int DescriptorType { get; }
	}

	// @interface BOWTrainer : NSObject
	[BaseType (typeof(NSObject))]
	interface BOWTrainer
	{
		// -(void)add:(Mat * _Nonnull)descriptors __attribute__((swift_name("add(descriptors:)")));
		[Export ("add:")]
		void Add (Mat descriptors);

		// -(NSArray<Mat *> * _Nonnull)getDescriptors __attribute__((swift_name("getDescriptors()")));
		[Export ("getDescriptors")]
		Mat[] Descriptors { get; }

		// -(int)descriptorsCount __attribute__((swift_name("descriptorsCount()")));
		[Export ("descriptorsCount")]
		int DescriptorsCount { get; }

		// -(void)clear __attribute__((swift_name("clear()")));
		[Export ("clear")]
		void Clear ();

		// -(Mat * _Nonnull)cluster __attribute__((swift_name("cluster()")));
		[Export ("cluster")]
		Mat Cluster ();

		// -(Mat * _Nonnull)cluster:(Mat * _Nonnull)descriptors __attribute__((swift_name("cluster(descriptors:)")));
		[Export ("cluster:")]
		Mat Cluster (Mat descriptors);
	}

	// @interface BOWKMeansTrainer : BOWTrainer
	[BaseType (typeof(BOWTrainer))]
	interface BOWKMeansTrainer
	{
		// -(instancetype _Nonnull)initWithClusterCount:(int)clusterCount termcrit:(TermCriteria * _Nonnull)termcrit attempts:(int)attempts flags:(int)flags;
		[Export ("initWithClusterCount:termcrit:attempts:flags:")]
		NativeHandle Constructor (int clusterCount, TermCriteria termcrit, int attempts, int flags);

		// -(instancetype _Nonnull)initWithClusterCount:(int)clusterCount termcrit:(TermCriteria * _Nonnull)termcrit attempts:(int)attempts;
		[Export ("initWithClusterCount:termcrit:attempts:")]
		NativeHandle Constructor (int clusterCount, TermCriteria termcrit, int attempts);

		// -(instancetype _Nonnull)initWithClusterCount:(int)clusterCount termcrit:(TermCriteria * _Nonnull)termcrit;
		[Export ("initWithClusterCount:termcrit:")]
		NativeHandle Constructor (int clusterCount, TermCriteria termcrit);

		// -(instancetype _Nonnull)initWithClusterCount:(int)clusterCount;
		[Export ("initWithClusterCount:")]
		NativeHandle Constructor (int clusterCount);

		// -(Mat * _Nonnull)cluster __attribute__((swift_name("cluster()")));
		[Export ("cluster")]
		Mat Cluster ();

		// -(Mat * _Nonnull)cluster:(Mat * _Nonnull)descriptors __attribute__((swift_name("cluster(descriptors:)")));
		[Export ("cluster:")]
		Mat Cluster (Mat descriptors);
	}

	// @interface BRISK : Feature2D
	[BaseType (typeof(Feature2D))]
	interface BRISK
	{
		// +(BRISK * _Nonnull)create:(int)thresh octaves:(int)octaves patternScale:(float)patternScale __attribute__((swift_name("create(thresh:octaves:patternScale:)")));
		[Static]
		[Export ("create:octaves:patternScale:")]
		BRISK Create (int thresh, int octaves, float patternScale);

		// +(BRISK * _Nonnull)create:(int)thresh octaves:(int)octaves __attribute__((swift_name("create(thresh:octaves:)")));
		[Static]
		[Export ("create:octaves:")]
		BRISK Create (int thresh, int octaves);

		// +(BRISK * _Nonnull)create:(int)thresh __attribute__((swift_name("create(thresh:)")));
		[Static]
		[Export ("create:")]
		BRISK Create (int thresh);

		// +(BRISK * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		BRISK Create ();

		// +(BRISK * _Nonnull)create:(FloatVector * _Nonnull)radiusList numberList:(IntVector * _Nonnull)numberList dMax:(float)dMax dMin:(float)dMin indexChange:(IntVector * _Nonnull)indexChange __attribute__((swift_name("create(radiusList:numberList:dMax:dMin:indexChange:)")));
		[Static]
		[Export ("create:numberList:dMax:dMin:indexChange:")]
		BRISK Create (FloatVector radiusList, IntVector numberList, float dMax, float dMin, IntVector indexChange);

		// +(BRISK * _Nonnull)create:(FloatVector * _Nonnull)radiusList numberList:(IntVector * _Nonnull)numberList dMax:(float)dMax dMin:(float)dMin __attribute__((swift_name("create(radiusList:numberList:dMax:dMin:)")));
		[Static]
		[Export ("create:numberList:dMax:dMin:")]
		BRISK Create (FloatVector radiusList, IntVector numberList, float dMax, float dMin);

		// +(BRISK * _Nonnull)create:(FloatVector * _Nonnull)radiusList numberList:(IntVector * _Nonnull)numberList dMax:(float)dMax __attribute__((swift_name("create(radiusList:numberList:dMax:)")));
		[Static]
		[Export ("create:numberList:dMax:")]
		BRISK Create (FloatVector radiusList, IntVector numberList, float dMax);

		// +(BRISK * _Nonnull)create:(FloatVector * _Nonnull)radiusList numberList:(IntVector * _Nonnull)numberList __attribute__((swift_name("create(radiusList:numberList:)")));
		[Static]
		[Export ("create:numberList:")]
		BRISK Create (FloatVector radiusList, IntVector numberList);

		// +(BRISK * _Nonnull)create:(int)thresh octaves:(int)octaves radiusList:(FloatVector * _Nonnull)radiusList numberList:(IntVector * _Nonnull)numberList dMax:(float)dMax dMin:(float)dMin indexChange:(IntVector * _Nonnull)indexChange __attribute__((swift_name("create(thresh:octaves:radiusList:numberList:dMax:dMin:indexChange:)")));
		[Static]
		[Export ("create:octaves:radiusList:numberList:dMax:dMin:indexChange:")]
		BRISK Create (int thresh, int octaves, FloatVector radiusList, IntVector numberList, float dMax, float dMin, IntVector indexChange);

		// +(BRISK * _Nonnull)create:(int)thresh octaves:(int)octaves radiusList:(FloatVector * _Nonnull)radiusList numberList:(IntVector * _Nonnull)numberList dMax:(float)dMax dMin:(float)dMin __attribute__((swift_name("create(thresh:octaves:radiusList:numberList:dMax:dMin:)")));
		[Static]
		[Export ("create:octaves:radiusList:numberList:dMax:dMin:")]
		BRISK Create (int thresh, int octaves, FloatVector radiusList, IntVector numberList, float dMax, float dMin);

		// +(BRISK * _Nonnull)create:(int)thresh octaves:(int)octaves radiusList:(FloatVector * _Nonnull)radiusList numberList:(IntVector * _Nonnull)numberList dMax:(float)dMax __attribute__((swift_name("create(thresh:octaves:radiusList:numberList:dMax:)")));
		[Static]
		[Export ("create:octaves:radiusList:numberList:dMax:")]
		BRISK Create (int thresh, int octaves, FloatVector radiusList, IntVector numberList, float dMax);

		// +(BRISK * _Nonnull)create:(int)thresh octaves:(int)octaves radiusList:(FloatVector * _Nonnull)radiusList numberList:(IntVector * _Nonnull)numberList __attribute__((swift_name("create(thresh:octaves:radiusList:numberList:)")));
		[Static]
		[Export ("create:octaves:radiusList:numberList:")]
		BRISK Create (int thresh, int octaves, FloatVector radiusList, IntVector numberList);

		// -(NSString * _Nonnull)getDefaultName __attribute__((swift_name("getDefaultName()")));
		[Export ("getDefaultName")]
		string DefaultName { get; }

		// -(void)setThreshold:(int)threshold __attribute__((swift_name("setThreshold(threshold:)")));
		[Export ("setThreshold:")]
		void SetThreshold (int threshold);

		// -(int)getThreshold __attribute__((swift_name("getThreshold()")));
		[Export ("getThreshold")]
		int Threshold { get; }

		// -(void)setOctaves:(int)octaves __attribute__((swift_name("setOctaves(octaves:)")));
		[Export ("setOctaves:")]
		void SetOctaves (int octaves);

		// -(int)getOctaves __attribute__((swift_name("getOctaves()")));
		[Export ("getOctaves")]
		int Octaves { get; }

		// -(void)setPatternScale:(float)patternScale __attribute__((swift_name("setPatternScale(patternScale:)")));
		[Export ("setPatternScale:")]
		void SetPatternScale (float patternScale);

		// -(float)getPatternScale __attribute__((swift_name("getPatternScale()")));
		[Export ("getPatternScale")]
		float PatternScale { get; }
	}

	// @interface FastFeatureDetector : Feature2D
	[BaseType (typeof(Feature2D))]
	interface FastFeatureDetector
	{
		// @property (readonly, class) int THRESHOLD __attribute__((swift_name("THRESHOLD")));
		[Static]
		[Export ("THRESHOLD")]
		int THRESHOLD { get; }

		// @property (readonly, class) int NONMAX_SUPPRESSION __attribute__((swift_name("NONMAX_SUPPRESSION")));
		[Static]
		[Export ("NONMAX_SUPPRESSION")]
		int NONMAX_SUPPRESSION { get; }

		// @property (readonly, class) int FAST_N __attribute__((swift_name("FAST_N")));
		[Static]
		[Export ("FAST_N")]
		int FAST_N { get; }

		// +(FastFeatureDetector * _Nonnull)create:(int)threshold nonmaxSuppression:(BOOL)nonmaxSuppression type:(FastDetectorType)type __attribute__((swift_name("create(threshold:nonmaxSuppression:type:)")));
		[Static]
		[Export ("create:nonmaxSuppression:type:")]
		FastFeatureDetector Create (int threshold, bool nonmaxSuppression, FastDetectorType type);

		// +(FastFeatureDetector * _Nonnull)create:(int)threshold nonmaxSuppression:(BOOL)nonmaxSuppression __attribute__((swift_name("create(threshold:nonmaxSuppression:)")));
		[Static]
		[Export ("create:nonmaxSuppression:")]
		FastFeatureDetector Create (int threshold, bool nonmaxSuppression);

		// +(FastFeatureDetector * _Nonnull)create:(int)threshold __attribute__((swift_name("create(threshold:)")));
		[Static]
		[Export ("create:")]
		FastFeatureDetector Create (int threshold);

		// +(FastFeatureDetector * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		FastFeatureDetector Create ();

		// -(void)setThreshold:(int)threshold __attribute__((swift_name("setThreshold(threshold:)")));
		[Export ("setThreshold:")]
		void SetThreshold (int threshold);

		// -(int)getThreshold __attribute__((swift_name("getThreshold()")));
		[Export ("getThreshold")]
		int Threshold { get; }

		// -(void)setNonmaxSuppression:(BOOL)f __attribute__((swift_name("setNonmaxSuppression(f:)")));
		[Export ("setNonmaxSuppression:")]
		void SetNonmaxSuppression (bool f);

		// -(BOOL)getNonmaxSuppression __attribute__((swift_name("getNonmaxSuppression()")));
		[Export ("getNonmaxSuppression")]
		bool NonmaxSuppression { get; }

		// -(void)setType:(FastDetectorType)type __attribute__((swift_name("setType(type:)")));
		[Export ("setType:")]
		void SetType (FastDetectorType type);

		// -(FastDetectorType)getType __attribute__((swift_name("getType()")));
		[Export ("getType")]
		FastDetectorType Type { get; }

		// -(NSString * _Nonnull)getDefaultName __attribute__((swift_name("getDefaultName()")));
		[Export ("getDefaultName")]
		string DefaultName { get; }
	}

	// @interface FlannBasedMatcher : DescriptorMatcher
	[BaseType (typeof(DescriptorMatcher))]
	interface FlannBasedMatcher
	{
		// +(FlannBasedMatcher * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		FlannBasedMatcher Create ();
	}

	// @interface GFTTDetector : Feature2D
	[BaseType (typeof(Feature2D))]
	interface GFTTDetector
	{
		// +(GFTTDetector * _Nonnull)create:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance blockSize:(int)blockSize useHarrisDetector:(BOOL)useHarrisDetector k:(double)k __attribute__((swift_name("create(maxCorners:qualityLevel:minDistance:blockSize:useHarrisDetector:k:)")));
		[Static]
		[Export ("create:qualityLevel:minDistance:blockSize:useHarrisDetector:k:")]
		GFTTDetector Create (int maxCorners, double qualityLevel, double minDistance, int blockSize, bool useHarrisDetector, double k);

		// +(GFTTDetector * _Nonnull)create:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance blockSize:(int)blockSize useHarrisDetector:(BOOL)useHarrisDetector __attribute__((swift_name("create(maxCorners:qualityLevel:minDistance:blockSize:useHarrisDetector:)")));
		[Static]
		[Export ("create:qualityLevel:minDistance:blockSize:useHarrisDetector:")]
		GFTTDetector Create (int maxCorners, double qualityLevel, double minDistance, int blockSize, bool useHarrisDetector);

		// +(GFTTDetector * _Nonnull)create:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance blockSize:(int)blockSize __attribute__((swift_name("create(maxCorners:qualityLevel:minDistance:blockSize:)")));
		[Static]
		[Export ("create:qualityLevel:minDistance:blockSize:")]
		GFTTDetector Create (int maxCorners, double qualityLevel, double minDistance, int blockSize);

		// +(GFTTDetector * _Nonnull)create:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance __attribute__((swift_name("create(maxCorners:qualityLevel:minDistance:)")));
		[Static]
		[Export ("create:qualityLevel:minDistance:")]
		GFTTDetector Create (int maxCorners, double qualityLevel, double minDistance);

		// +(GFTTDetector * _Nonnull)create:(int)maxCorners qualityLevel:(double)qualityLevel __attribute__((swift_name("create(maxCorners:qualityLevel:)")));
		[Static]
		[Export ("create:qualityLevel:")]
		GFTTDetector Create (int maxCorners, double qualityLevel);

		// +(GFTTDetector * _Nonnull)create:(int)maxCorners __attribute__((swift_name("create(maxCorners:)")));
		[Static]
		[Export ("create:")]
		GFTTDetector Create (int maxCorners);

		// +(GFTTDetector * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		GFTTDetector Create ();

		// +(GFTTDetector * _Nonnull)create:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance blockSize:(int)blockSize gradiantSize:(int)gradiantSize useHarrisDetector:(BOOL)useHarrisDetector k:(double)k __attribute__((swift_name("create(maxCorners:qualityLevel:minDistance:blockSize:gradiantSize:useHarrisDetector:k:)")));
		[Static]
		[Export ("create:qualityLevel:minDistance:blockSize:gradiantSize:useHarrisDetector:k:")]
		GFTTDetector Create (int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, bool useHarrisDetector, double k);

		// +(GFTTDetector * _Nonnull)create:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance blockSize:(int)blockSize gradiantSize:(int)gradiantSize useHarrisDetector:(BOOL)useHarrisDetector __attribute__((swift_name("create(maxCorners:qualityLevel:minDistance:blockSize:gradiantSize:useHarrisDetector:)")));
		[Static]
		[Export ("create:qualityLevel:minDistance:blockSize:gradiantSize:useHarrisDetector:")]
		GFTTDetector Create (int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, bool useHarrisDetector);

		// +(GFTTDetector * _Nonnull)create:(int)maxCorners qualityLevel:(double)qualityLevel minDistance:(double)minDistance blockSize:(int)blockSize gradiantSize:(int)gradiantSize __attribute__((swift_name("create(maxCorners:qualityLevel:minDistance:blockSize:gradiantSize:)")));
		[Static]
		[Export ("create:qualityLevel:minDistance:blockSize:gradiantSize:")]
		GFTTDetector Create (int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize);

		// -(void)setMaxFeatures:(int)maxFeatures __attribute__((swift_name("setMaxFeatures(maxFeatures:)")));
		[Export ("setMaxFeatures:")]
		void SetMaxFeatures (int maxFeatures);

		// -(int)getMaxFeatures __attribute__((swift_name("getMaxFeatures()")));
		[Export ("getMaxFeatures")]
		int MaxFeatures { get; }

		// -(void)setQualityLevel:(double)qlevel __attribute__((swift_name("setQualityLevel(qlevel:)")));
		[Export ("setQualityLevel:")]
		void SetQualityLevel (double qlevel);

		// -(double)getQualityLevel __attribute__((swift_name("getQualityLevel()")));
		[Export ("getQualityLevel")]
		double QualityLevel { get; }

		// -(void)setMinDistance:(double)minDistance __attribute__((swift_name("setMinDistance(minDistance:)")));
		[Export ("setMinDistance:")]
		void SetMinDistance (double minDistance);

		// -(double)getMinDistance __attribute__((swift_name("getMinDistance()")));
		[Export ("getMinDistance")]
		double MinDistance { get; }

		// -(void)setBlockSize:(int)blockSize __attribute__((swift_name("setBlockSize(blockSize:)")));
		[Export ("setBlockSize:")]
		void SetBlockSize (int blockSize);

		// -(int)getBlockSize __attribute__((swift_name("getBlockSize()")));
		[Export ("getBlockSize")]
		int BlockSize { get; }

		// -(void)setGradientSize:(int)gradientSize_ __attribute__((swift_name("setGradientSize(gradientSize_:)")));
		[Export ("setGradientSize:")]
		void SetGradientSize (int gradientSize_);

		// -(int)getGradientSize __attribute__((swift_name("getGradientSize()")));
		[Export ("getGradientSize")]
		int GradientSize { get; }

		// -(void)setHarrisDetector:(BOOL)val __attribute__((swift_name("setHarrisDetector(val:)")));
		[Export ("setHarrisDetector:")]
		void SetHarrisDetector (bool val);

		// -(BOOL)getHarrisDetector __attribute__((swift_name("getHarrisDetector()")));
		[Export ("getHarrisDetector")]
		bool HarrisDetector { get; }

		// -(void)setK:(double)k __attribute__((swift_name("setK(k:)")));
		[Export ("setK:")]
		void SetK (double k);

		// -(double)getK __attribute__((swift_name("getK()")));
		[Export ("getK")]
		double K { get; }

		// -(NSString * _Nonnull)getDefaultName __attribute__((swift_name("getDefaultName()")));
		[Export ("getDefaultName")]
		string DefaultName { get; }
	}

	// @interface MSER : Feature2D
	[BaseType (typeof(Feature2D))]
	interface MSER
	{
		// +(MSER * _Nonnull)create:(int)delta min_area:(int)min_area max_area:(int)max_area max_variation:(double)max_variation min_diversity:(double)min_diversity max_evolution:(int)max_evolution area_threshold:(double)area_threshold min_margin:(double)min_margin edge_blur_size:(int)edge_blur_size __attribute__((swift_name("create(delta:min_area:max_area:max_variation:min_diversity:max_evolution:area_threshold:min_margin:edge_blur_size:)")));
		[Static]
		[Export ("create:min_area:max_area:max_variation:min_diversity:max_evolution:area_threshold:min_margin:edge_blur_size:")]
		MSER Create (int delta, int min_area, int max_area, double max_variation, double min_diversity, int max_evolution, double area_threshold, double min_margin, int edge_blur_size);

		// +(MSER * _Nonnull)create:(int)delta min_area:(int)min_area max_area:(int)max_area max_variation:(double)max_variation min_diversity:(double)min_diversity max_evolution:(int)max_evolution area_threshold:(double)area_threshold min_margin:(double)min_margin __attribute__((swift_name("create(delta:min_area:max_area:max_variation:min_diversity:max_evolution:area_threshold:min_margin:)")));
		[Static]
		[Export ("create:min_area:max_area:max_variation:min_diversity:max_evolution:area_threshold:min_margin:")]
		MSER Create (int delta, int min_area, int max_area, double max_variation, double min_diversity, int max_evolution, double area_threshold, double min_margin);

		// +(MSER * _Nonnull)create:(int)delta min_area:(int)min_area max_area:(int)max_area max_variation:(double)max_variation min_diversity:(double)min_diversity max_evolution:(int)max_evolution area_threshold:(double)area_threshold __attribute__((swift_name("create(delta:min_area:max_area:max_variation:min_diversity:max_evolution:area_threshold:)")));
		[Static]
		[Export ("create:min_area:max_area:max_variation:min_diversity:max_evolution:area_threshold:")]
		MSER Create (int delta, int min_area, int max_area, double max_variation, double min_diversity, int max_evolution, double area_threshold);

		// +(MSER * _Nonnull)create:(int)delta min_area:(int)min_area max_area:(int)max_area max_variation:(double)max_variation min_diversity:(double)min_diversity max_evolution:(int)max_evolution __attribute__((swift_name("create(delta:min_area:max_area:max_variation:min_diversity:max_evolution:)")));
		[Static]
		[Export ("create:min_area:max_area:max_variation:min_diversity:max_evolution:")]
		MSER Create (int delta, int min_area, int max_area, double max_variation, double min_diversity, int max_evolution);

		// +(MSER * _Nonnull)create:(int)delta min_area:(int)min_area max_area:(int)max_area max_variation:(double)max_variation min_diversity:(double)min_diversity __attribute__((swift_name("create(delta:min_area:max_area:max_variation:min_diversity:)")));
		[Static]
		[Export ("create:min_area:max_area:max_variation:min_diversity:")]
		MSER Create (int delta, int min_area, int max_area, double max_variation, double min_diversity);

		// +(MSER * _Nonnull)create:(int)delta min_area:(int)min_area max_area:(int)max_area max_variation:(double)max_variation __attribute__((swift_name("create(delta:min_area:max_area:max_variation:)")));
		[Static]
		[Export ("create:min_area:max_area:max_variation:")]
		MSER Create (int delta, int min_area, int max_area, double max_variation);

		// +(MSER * _Nonnull)create:(int)delta min_area:(int)min_area max_area:(int)max_area __attribute__((swift_name("create(delta:min_area:max_area:)")));
		[Static]
		[Export ("create:min_area:max_area:")]
		MSER Create (int delta, int min_area, int max_area);

		// +(MSER * _Nonnull)create:(int)delta min_area:(int)min_area __attribute__((swift_name("create(delta:min_area:)")));
		[Static]
		[Export ("create:min_area:")]
		MSER Create (int delta, int min_area);

		// +(MSER * _Nonnull)create:(int)delta __attribute__((swift_name("create(delta:)")));
		[Static]
		[Export ("create:")]
		MSER Create (int delta);

		// +(MSER * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		MSER Create ();

		// -(void)detectRegions:(Mat * _Nonnull)image msers:(NSMutableArray<NSMutableArray<Point2i *> *> * _Nonnull)msers bboxes:(NSMutableArray<Rect2i *> * _Nonnull)bboxes __attribute__((swift_name("detectRegions(image:msers:bboxes:)")));
		[Export ("detectRegions:msers:bboxes:")]
		void DetectRegions (Mat image, NSMutableArray<NSMutableArray<Point2i>> msers, NSMutableArray<Rect2i> bboxes);

		// -(void)setDelta:(int)delta __attribute__((swift_name("setDelta(delta:)")));
		[Export ("setDelta:")]
		void SetDelta (int delta);

		// -(int)getDelta __attribute__((swift_name("getDelta()")));
		[Export ("getDelta")]
		int Delta { get; }

		// -(void)setMinArea:(int)minArea __attribute__((swift_name("setMinArea(minArea:)")));
		[Export ("setMinArea:")]
		void SetMinArea (int minArea);

		// -(int)getMinArea __attribute__((swift_name("getMinArea()")));
		[Export ("getMinArea")]
		int MinArea { get; }

		// -(void)setMaxArea:(int)maxArea __attribute__((swift_name("setMaxArea(maxArea:)")));
		[Export ("setMaxArea:")]
		void SetMaxArea (int maxArea);

		// -(int)getMaxArea __attribute__((swift_name("getMaxArea()")));
		[Export ("getMaxArea")]
		int MaxArea { get; }

		// -(void)setMaxVariation:(double)maxVariation __attribute__((swift_name("setMaxVariation(maxVariation:)")));
		[Export ("setMaxVariation:")]
		void SetMaxVariation (double maxVariation);

		// -(double)getMaxVariation __attribute__((swift_name("getMaxVariation()")));
		[Export ("getMaxVariation")]
		double MaxVariation { get; }

		// -(void)setMinDiversity:(double)minDiversity __attribute__((swift_name("setMinDiversity(minDiversity:)")));
		[Export ("setMinDiversity:")]
		void SetMinDiversity (double minDiversity);

		// -(double)getMinDiversity __attribute__((swift_name("getMinDiversity()")));
		[Export ("getMinDiversity")]
		double MinDiversity { get; }

		// -(void)setMaxEvolution:(int)maxEvolution __attribute__((swift_name("setMaxEvolution(maxEvolution:)")));
		[Export ("setMaxEvolution:")]
		void SetMaxEvolution (int maxEvolution);

		// -(int)getMaxEvolution __attribute__((swift_name("getMaxEvolution()")));
		[Export ("getMaxEvolution")]
		int MaxEvolution { get; }

		// -(void)setAreaThreshold:(double)areaThreshold __attribute__((swift_name("setAreaThreshold(areaThreshold:)")));
		[Export ("setAreaThreshold:")]
		void SetAreaThreshold (double areaThreshold);

		// -(double)getAreaThreshold __attribute__((swift_name("getAreaThreshold()")));
		[Export ("getAreaThreshold")]
		double AreaThreshold { get; }

		// -(void)setMinMargin:(double)min_margin __attribute__((swift_name("setMinMargin(min_margin:)")));
		[Export ("setMinMargin:")]
		void SetMinMargin (double min_margin);

		// -(double)getMinMargin __attribute__((swift_name("getMinMargin()")));
		[Export ("getMinMargin")]
		double MinMargin { get; }

		// -(void)setEdgeBlurSize:(int)edge_blur_size __attribute__((swift_name("setEdgeBlurSize(edge_blur_size:)")));
		[Export ("setEdgeBlurSize:")]
		void SetEdgeBlurSize (int edge_blur_size);

		// -(int)getEdgeBlurSize __attribute__((swift_name("getEdgeBlurSize()")));
		[Export ("getEdgeBlurSize")]
		int EdgeBlurSize { get; }

		// -(void)setPass2Only:(BOOL)f __attribute__((swift_name("setPass2Only(f:)")));
		[Export ("setPass2Only:")]
		void SetPass2Only (bool f);

		// -(BOOL)getPass2Only __attribute__((swift_name("getPass2Only()")));
		[Export ("getPass2Only")]
		bool Pass2Only { get; }

		// -(NSString * _Nonnull)getDefaultName __attribute__((swift_name("getDefaultName()")));
		[Export ("getDefaultName")]
		string DefaultName { get; }
	}

	// @interface ORB : Feature2D
	[BaseType (typeof(Feature2D))]
	interface ORB
	{
		// +(ORB * _Nonnull)create:(int)nfeatures scaleFactor:(float)scaleFactor nlevels:(int)nlevels edgeThreshold:(int)edgeThreshold firstLevel:(int)firstLevel WTA_K:(int)WTA_K scoreType:(ScoreType)scoreType patchSize:(int)patchSize fastThreshold:(int)fastThreshold __attribute__((swift_name("create(nfeatures:scaleFactor:nlevels:edgeThreshold:firstLevel:WTA_K:scoreType:patchSize:fastThreshold:)")));
		[Static]
		[Export ("create:scaleFactor:nlevels:edgeThreshold:firstLevel:WTA_K:scoreType:patchSize:fastThreshold:")]
		ORB Create (int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, ScoreType scoreType, int patchSize, int fastThreshold);

		// +(ORB * _Nonnull)create:(int)nfeatures scaleFactor:(float)scaleFactor nlevels:(int)nlevels edgeThreshold:(int)edgeThreshold firstLevel:(int)firstLevel WTA_K:(int)WTA_K scoreType:(ScoreType)scoreType patchSize:(int)patchSize __attribute__((swift_name("create(nfeatures:scaleFactor:nlevels:edgeThreshold:firstLevel:WTA_K:scoreType:patchSize:)")));
		[Static]
		[Export ("create:scaleFactor:nlevels:edgeThreshold:firstLevel:WTA_K:scoreType:patchSize:")]
		ORB Create (int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, ScoreType scoreType, int patchSize);

		// +(ORB * _Nonnull)create:(int)nfeatures scaleFactor:(float)scaleFactor nlevels:(int)nlevels edgeThreshold:(int)edgeThreshold firstLevel:(int)firstLevel WTA_K:(int)WTA_K scoreType:(ScoreType)scoreType __attribute__((swift_name("create(nfeatures:scaleFactor:nlevels:edgeThreshold:firstLevel:WTA_K:scoreType:)")));
		[Static]
		[Export ("create:scaleFactor:nlevels:edgeThreshold:firstLevel:WTA_K:scoreType:")]
		ORB Create (int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, ScoreType scoreType);

		// +(ORB * _Nonnull)create:(int)nfeatures scaleFactor:(float)scaleFactor nlevels:(int)nlevels edgeThreshold:(int)edgeThreshold firstLevel:(int)firstLevel WTA_K:(int)WTA_K __attribute__((swift_name("create(nfeatures:scaleFactor:nlevels:edgeThreshold:firstLevel:WTA_K:)")));
		[Static]
		[Export ("create:scaleFactor:nlevels:edgeThreshold:firstLevel:WTA_K:")]
		ORB Create (int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K);

		// +(ORB * _Nonnull)create:(int)nfeatures scaleFactor:(float)scaleFactor nlevels:(int)nlevels edgeThreshold:(int)edgeThreshold firstLevel:(int)firstLevel __attribute__((swift_name("create(nfeatures:scaleFactor:nlevels:edgeThreshold:firstLevel:)")));
		[Static]
		[Export ("create:scaleFactor:nlevels:edgeThreshold:firstLevel:")]
		ORB Create (int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel);

		// +(ORB * _Nonnull)create:(int)nfeatures scaleFactor:(float)scaleFactor nlevels:(int)nlevels edgeThreshold:(int)edgeThreshold __attribute__((swift_name("create(nfeatures:scaleFactor:nlevels:edgeThreshold:)")));
		[Static]
		[Export ("create:scaleFactor:nlevels:edgeThreshold:")]
		ORB Create (int nfeatures, float scaleFactor, int nlevels, int edgeThreshold);

		// +(ORB * _Nonnull)create:(int)nfeatures scaleFactor:(float)scaleFactor nlevels:(int)nlevels __attribute__((swift_name("create(nfeatures:scaleFactor:nlevels:)")));
		[Static]
		[Export ("create:scaleFactor:nlevels:")]
		ORB Create (int nfeatures, float scaleFactor, int nlevels);

		// +(ORB * _Nonnull)create:(int)nfeatures scaleFactor:(float)scaleFactor __attribute__((swift_name("create(nfeatures:scaleFactor:)")));
		[Static]
		[Export ("create:scaleFactor:")]
		ORB Create (int nfeatures, float scaleFactor);

		// +(ORB * _Nonnull)create:(int)nfeatures __attribute__((swift_name("create(nfeatures:)")));
		[Static]
		[Export ("create:")]
		ORB Create (int nfeatures);

		// +(ORB * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		ORB Create ();

		// -(void)setMaxFeatures:(int)maxFeatures __attribute__((swift_name("setMaxFeatures(maxFeatures:)")));
		[Export ("setMaxFeatures:")]
		void SetMaxFeatures (int maxFeatures);

		// -(int)getMaxFeatures __attribute__((swift_name("getMaxFeatures()")));
		[Export ("getMaxFeatures")]
		int MaxFeatures { get; }

		// -(void)setScaleFactor:(double)scaleFactor __attribute__((swift_name("setScaleFactor(scaleFactor:)")));
		[Export ("setScaleFactor:")]
		void SetScaleFactor (double scaleFactor);

		// -(double)getScaleFactor __attribute__((swift_name("getScaleFactor()")));
		[Export ("getScaleFactor")]
		double ScaleFactor { get; }

		// -(void)setNLevels:(int)nlevels __attribute__((swift_name("setNLevels(nlevels:)")));
		[Export ("setNLevels:")]
		void SetNLevels (int nlevels);

		// -(int)getNLevels __attribute__((swift_name("getNLevels()")));
		[Export ("getNLevels")]
		int NLevels { get; }

		// -(void)setEdgeThreshold:(int)edgeThreshold __attribute__((swift_name("setEdgeThreshold(edgeThreshold:)")));
		[Export ("setEdgeThreshold:")]
		void SetEdgeThreshold (int edgeThreshold);

		// -(int)getEdgeThreshold __attribute__((swift_name("getEdgeThreshold()")));
		[Export ("getEdgeThreshold")]
		int EdgeThreshold { get; }

		// -(void)setFirstLevel:(int)firstLevel __attribute__((swift_name("setFirstLevel(firstLevel:)")));
		[Export ("setFirstLevel:")]
		void SetFirstLevel (int firstLevel);

		// -(int)getFirstLevel __attribute__((swift_name("getFirstLevel()")));
		[Export ("getFirstLevel")]
		int FirstLevel { get; }

		// -(void)setWTA_K:(int)wta_k __attribute__((swift_name("setWTA_K(wta_k:)")));
		[Export ("setWTA_K:")]
		void SetWTA_K (int wta_k);

		// -(int)getWTA_K __attribute__((swift_name("getWTA_K()")));
		[Export ("getWTA_K")]
		int WTA_K { get; }

		// -(void)setScoreType:(ScoreType)scoreType __attribute__((swift_name("setScoreType(scoreType:)")));
		[Export ("setScoreType:")]
		void SetScoreType (ScoreType scoreType);

		// -(ScoreType)getScoreType __attribute__((swift_name("getScoreType()")));
		[Export ("getScoreType")]
		ScoreType ScoreType { get; }

		// -(void)setPatchSize:(int)patchSize __attribute__((swift_name("setPatchSize(patchSize:)")));
		[Export ("setPatchSize:")]
		void SetPatchSize (int patchSize);

		// -(int)getPatchSize __attribute__((swift_name("getPatchSize()")));
		[Export ("getPatchSize")]
		int PatchSize { get; }

		// -(void)setFastThreshold:(int)fastThreshold __attribute__((swift_name("setFastThreshold(fastThreshold:)")));
		[Export ("setFastThreshold:")]
		void SetFastThreshold (int fastThreshold);

		// -(int)getFastThreshold __attribute__((swift_name("getFastThreshold()")));
		[Export ("getFastThreshold")]
		int FastThreshold { get; }

		// -(NSString * _Nonnull)getDefaultName __attribute__((swift_name("getDefaultName()")));
		[Export ("getDefaultName")]
		string DefaultName { get; }
	}

	// @interface SIFT : Feature2D
	[BaseType (typeof(Feature2D))]
	interface SIFT
	{
		// +(SIFT * _Nonnull)create:(int)nfeatures nOctaveLayers:(int)nOctaveLayers contrastThreshold:(double)contrastThreshold edgeThreshold:(double)edgeThreshold sigma:(double)sigma enable_precise_upscale:(BOOL)enable_precise_upscale __attribute__((swift_name("create(nfeatures:nOctaveLayers:contrastThreshold:edgeThreshold:sigma:enable_precise_upscale:)")));
		[Static]
		[Export ("create:nOctaveLayers:contrastThreshold:edgeThreshold:sigma:enable_precise_upscale:")]
		SIFT Create (int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold, double sigma, bool enable_precise_upscale);

		// +(SIFT * _Nonnull)create:(int)nfeatures nOctaveLayers:(int)nOctaveLayers contrastThreshold:(double)contrastThreshold edgeThreshold:(double)edgeThreshold sigma:(double)sigma __attribute__((swift_name("create(nfeatures:nOctaveLayers:contrastThreshold:edgeThreshold:sigma:)")));
		[Static]
		[Export ("create:nOctaveLayers:contrastThreshold:edgeThreshold:sigma:")]
		SIFT Create (int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold, double sigma);

		// +(SIFT * _Nonnull)create:(int)nfeatures nOctaveLayers:(int)nOctaveLayers contrastThreshold:(double)contrastThreshold edgeThreshold:(double)edgeThreshold __attribute__((swift_name("create(nfeatures:nOctaveLayers:contrastThreshold:edgeThreshold:)")));
		[Static]
		[Export ("create:nOctaveLayers:contrastThreshold:edgeThreshold:")]
		SIFT Create (int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold);

		// +(SIFT * _Nonnull)create:(int)nfeatures nOctaveLayers:(int)nOctaveLayers contrastThreshold:(double)contrastThreshold __attribute__((swift_name("create(nfeatures:nOctaveLayers:contrastThreshold:)")));
		[Static]
		[Export ("create:nOctaveLayers:contrastThreshold:")]
		SIFT Create (int nfeatures, int nOctaveLayers, double contrastThreshold);

		// +(SIFT * _Nonnull)create:(int)nfeatures nOctaveLayers:(int)nOctaveLayers __attribute__((swift_name("create(nfeatures:nOctaveLayers:)")));
		[Static]
		[Export ("create:nOctaveLayers:")]
		SIFT Create (int nfeatures, int nOctaveLayers);

		// +(SIFT * _Nonnull)create:(int)nfeatures __attribute__((swift_name("create(nfeatures:)")));
		[Static]
		[Export ("create:")]
		SIFT Create (int nfeatures);

		// +(SIFT * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		SIFT Create ();

		// +(SIFT * _Nonnull)create:(int)nfeatures nOctaveLayers:(int)nOctaveLayers contrastThreshold:(double)contrastThreshold edgeThreshold:(double)edgeThreshold sigma:(double)sigma descriptorType:(int)descriptorType enable_precise_upscale:(BOOL)enable_precise_upscale __attribute__((swift_name("create(nfeatures:nOctaveLayers:contrastThreshold:edgeThreshold:sigma:descriptorType:enable_precise_upscale:)")));
		[Static]
		[Export ("create:nOctaveLayers:contrastThreshold:edgeThreshold:sigma:descriptorType:enable_precise_upscale:")]
		SIFT Create (int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold, double sigma, int descriptorType, bool enable_precise_upscale);

		// +(SIFT * _Nonnull)create:(int)nfeatures nOctaveLayers:(int)nOctaveLayers contrastThreshold:(double)contrastThreshold edgeThreshold:(double)edgeThreshold sigma:(double)sigma descriptorType:(int)descriptorType __attribute__((swift_name("create(nfeatures:nOctaveLayers:contrastThreshold:edgeThreshold:sigma:descriptorType:)")));
		[Static]
		[Export ("create:nOctaveLayers:contrastThreshold:edgeThreshold:sigma:descriptorType:")]
		SIFT Create (int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold, double sigma, int descriptorType);

		// -(NSString * _Nonnull)getDefaultName __attribute__((swift_name("getDefaultName()")));
		[Export ("getDefaultName")]
		string DefaultName { get; }

		// -(void)setNFeatures:(int)maxFeatures __attribute__((swift_name("setNFeatures(maxFeatures:)")));
		[Export ("setNFeatures:")]
		void SetNFeatures (int maxFeatures);

		// -(int)getNFeatures __attribute__((swift_name("getNFeatures()")));
		[Export ("getNFeatures")]
		int NFeatures { get; }

		// -(void)setNOctaveLayers:(int)nOctaveLayers __attribute__((swift_name("setNOctaveLayers(nOctaveLayers:)")));
		[Export ("setNOctaveLayers:")]
		void SetNOctaveLayers (int nOctaveLayers);

		// -(int)getNOctaveLayers __attribute__((swift_name("getNOctaveLayers()")));
		[Export ("getNOctaveLayers")]
		int NOctaveLayers { get; }

		// -(void)setContrastThreshold:(double)contrastThreshold __attribute__((swift_name("setContrastThreshold(contrastThreshold:)")));
		[Export ("setContrastThreshold:")]
		void SetContrastThreshold (double contrastThreshold);

		// -(double)getContrastThreshold __attribute__((swift_name("getContrastThreshold()")));
		[Export ("getContrastThreshold")]
		double ContrastThreshold { get; }

		// -(void)setEdgeThreshold:(double)edgeThreshold __attribute__((swift_name("setEdgeThreshold(edgeThreshold:)")));
		[Export ("setEdgeThreshold:")]
		void SetEdgeThreshold (double edgeThreshold);

		// -(double)getEdgeThreshold __attribute__((swift_name("getEdgeThreshold()")));
		[Export ("getEdgeThreshold")]
		double EdgeThreshold { get; }

		// -(void)setSigma:(double)sigma __attribute__((swift_name("setSigma(sigma:)")));
		[Export ("setSigma:")]
		void SetSigma (double sigma);

		// -(double)getSigma __attribute__((swift_name("getSigma()")));
		[Export ("getSigma")]
		double Sigma { get; }
	}

	// @interface SimpleBlobDetector : Feature2D
	[BaseType (typeof(Feature2D))]
	interface SimpleBlobDetector
	{
		// +(SimpleBlobDetector * _Nonnull)create:(SimpleBlobDetectorParams * _Nonnull)parameters __attribute__((swift_name("create(parameters:)")));
		[Static]
		[Export ("create:")]
		SimpleBlobDetector Create (SimpleBlobDetectorParams parameters);

		// +(SimpleBlobDetector * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		SimpleBlobDetector Create ();

		// -(NSString * _Nonnull)getDefaultName __attribute__((swift_name("getDefaultName()")));
		[Export ("getDefaultName")]
		string DefaultName { get; }

		// -(NSArray<NSArray<Point2i *> *> * _Nonnull)getBlobContours __attribute__((swift_name("getBlobContours()")));
		[Export ("getBlobContours")]
		NSArray<Point2i>[] BlobContours { get; }
	}

	// @interface SimpleBlobDetectorParams : NSObject
	[BaseType (typeof(NSObject))]
	interface SimpleBlobDetectorParams
	{
		// @property float thresholdStep;
		[Export ("thresholdStep")]
		float ThresholdStep { get; set; }

		// @property float minThreshold;
		[Export ("minThreshold")]
		float MinThreshold { get; set; }

		// @property float maxThreshold;
		[Export ("maxThreshold")]
		float MaxThreshold { get; set; }

		// @property size_t minRepeatability;
		[Export ("minRepeatability")]
		nuint MinRepeatability { get; set; }

		// @property float minDistBetweenBlobs;
		[Export ("minDistBetweenBlobs")]
		float MinDistBetweenBlobs { get; set; }

		// @property BOOL filterByColor;
		[Export ("filterByColor")]
		bool FilterByColor { get; set; }

		// @property unsigned char blobColor;
		[Export ("blobColor")]
		byte BlobColor { get; set; }

		// @property BOOL filterByArea;
		[Export ("filterByArea")]
		bool FilterByArea { get; set; }

		// @property float minArea;
		[Export ("minArea")]
		float MinArea { get; set; }

		// @property float maxArea;
		[Export ("maxArea")]
		float MaxArea { get; set; }

		// @property BOOL filterByCircularity;
		[Export ("filterByCircularity")]
		bool FilterByCircularity { get; set; }

		// @property float minCircularity;
		[Export ("minCircularity")]
		float MinCircularity { get; set; }

		// @property float maxCircularity;
		[Export ("maxCircularity")]
		float MaxCircularity { get; set; }

		// @property BOOL filterByInertia;
		[Export ("filterByInertia")]
		bool FilterByInertia { get; set; }

		// @property float minInertiaRatio;
		[Export ("minInertiaRatio")]
		float MinInertiaRatio { get; set; }

		// @property float maxInertiaRatio;
		[Export ("maxInertiaRatio")]
		float MaxInertiaRatio { get; set; }

		// @property BOOL filterByConvexity;
		[Export ("filterByConvexity")]
		bool FilterByConvexity { get; set; }

		// @property float minConvexity;
		[Export ("minConvexity")]
		float MinConvexity { get; set; }

		// @property float maxConvexity;
		[Export ("maxConvexity")]
		float MaxConvexity { get; set; }

		// @property BOOL collectContours;
		[Export ("collectContours")]
		bool CollectContours { get; set; }
	}

	// @interface MatConverters : NSObject
	[BaseType (typeof(NSObject))]
	interface MatConverters
	{
		// +(CGImageRef _Nonnull)convertMatToCGImageRef:(Mat * _Nonnull)mat __attribute__((cf_returns_retained));
		[Static]
		[Export ("convertMatToCGImageRef:")]
		CGImage ConvertMatToCGImageRef (Mat mat);

		// +(Mat * _Nonnull)convertCGImageRefToMat:(CGImageRef _Nonnull)image;
		[Static]
		[Export ("convertCGImageRefToMat:")]
		Mat ConvertCGImageRefToMat (CGImage image);

		// +(Mat * _Nonnull)convertCGImageRefToMat:(CGImageRef _Nonnull)image alphaExist:(BOOL)alphaExist;
		[Static]
		[Export ("convertCGImageRefToMat:alphaExist:")]
		Mat ConvertCGImageRefToMat (CGImage image, bool alphaExist);

		// +(UIImage * _Nonnull)converMatToUIImage:(Mat * _Nonnull)mat;
		[Static]
		[Export ("converMatToUIImage:")]
		UIImage ConverMatToUIImage (Mat mat);

		// +(Mat * _Nonnull)convertUIImageToMat:(UIImage * _Nonnull)image;
		[Static]
		[Export ("convertUIImageToMat:")]
		Mat ConvertUIImageToMat (UIImage image);

		// +(Mat * _Nonnull)convertUIImageToMat:(UIImage * _Nonnull)image alphaExist:(BOOL)alphaExist;
		[Static]
		[Export ("convertUIImageToMat:alphaExist:")]
		Mat ConvertUIImageToMat (UIImage image, bool alphaExist);
	}

	// @interface MatQuickLook : NSObject
	[BaseType (typeof(NSObject))]
	interface MatQuickLook
	{
		// +(id _Nonnull)matDebugQuickLookObject:(Mat * _Nonnull)mat;
		[Static]
		[Export ("matDebugQuickLookObject:")]
		NSObject MatDebugQuickLookObject (Mat mat);
	}

	// @interface Imgcodecs : NSObject
	[BaseType (typeof(NSObject))]
	interface Imgcodecs
	{
		// +(Mat * _Nonnull)imread:(NSString * _Nonnull)filename flags:(int)flags __attribute__((swift_name("imread(filename:flags:)")));
		[Static]
		[Export ("imread:flags:")]
		Mat Imread (string filename, int flags);

		// +(Mat * _Nonnull)imread:(NSString * _Nonnull)filename __attribute__((swift_name("imread(filename:)")));
		[Static]
		[Export ("imread:")]
		Mat Imread (string filename);

		// +(void)imread:(NSString * _Nonnull)filename dst:(Mat * _Nonnull)dst flags:(int)flags __attribute__((swift_name("imread(filename:dst:flags:)")));
		[Static]
		[Export ("imread:dst:flags:")]
		void Imread (string filename, Mat dst, int flags);

		// +(void)imread:(NSString * _Nonnull)filename dst:(Mat * _Nonnull)dst __attribute__((swift_name("imread(filename:dst:)")));
		[Static]
		[Export ("imread:dst:")]
		void Imread (string filename, Mat dst);

		// +(Mat * _Nonnull)imreadWithMetadata:(NSString * _Nonnull)filename metadataTypes:(IntVector * _Nonnull)metadataTypes metadata:(NSMutableArray<Mat *> * _Nonnull)metadata flags:(int)flags __attribute__((swift_name("imreadWithMetadata(filename:metadataTypes:metadata:flags:)")));
		[Static]
		[Export ("imreadWithMetadata:metadataTypes:metadata:flags:")]
		Mat ImreadWithMetadata (string filename, IntVector metadataTypes, NSMutableArray<Mat> metadata, int flags);

		// +(Mat * _Nonnull)imreadWithMetadata:(NSString * _Nonnull)filename metadataTypes:(IntVector * _Nonnull)metadataTypes metadata:(NSMutableArray<Mat *> * _Nonnull)metadata __attribute__((swift_name("imreadWithMetadata(filename:metadataTypes:metadata:)")));
		[Static]
		[Export ("imreadWithMetadata:metadataTypes:metadata:")]
		Mat ImreadWithMetadata (string filename, IntVector metadataTypes, NSMutableArray<Mat> metadata);

		// +(BOOL)imreadmulti:(NSString * _Nonnull)filename mats:(NSMutableArray<Mat *> * _Nonnull)mats flags:(int)flags __attribute__((swift_name("imreadmulti(filename:mats:flags:)")));
		[Static]
		[Export ("imreadmulti:mats:flags:")]
		bool Imreadmulti (string filename, NSMutableArray<Mat> mats, int flags);

		// +(BOOL)imreadmulti:(NSString * _Nonnull)filename mats:(NSMutableArray<Mat *> * _Nonnull)mats __attribute__((swift_name("imreadmulti(filename:mats:)")));
		[Static]
		[Export ("imreadmulti:mats:")]
		bool Imreadmulti (string filename, NSMutableArray<Mat> mats);

		// +(BOOL)imreadmulti:(NSString * _Nonnull)filename mats:(NSMutableArray<Mat *> * _Nonnull)mats start:(int)start count:(int)count flags:(int)flags __attribute__((swift_name("imreadmulti(filename:mats:start:count:flags:)")));
		[Static]
		[Export ("imreadmulti:mats:start:count:flags:")]
		bool Imreadmulti (string filename, NSMutableArray<Mat> mats, int start, int count, int flags);

		// +(BOOL)imreadmulti:(NSString * _Nonnull)filename mats:(NSMutableArray<Mat *> * _Nonnull)mats start:(int)start count:(int)count __attribute__((swift_name("imreadmulti(filename:mats:start:count:)")));
		[Static]
		[Export ("imreadmulti:mats:start:count:")]
		bool Imreadmulti (string filename, NSMutableArray<Mat> mats, int start, int count);

		// +(BOOL)imreadanimation:(NSString * _Nonnull)filename animation:(Animation * _Nonnull)animation start:(int)start count:(int)count __attribute__((swift_name("imreadanimation(filename:animation:start:count:)")));
		[Static]
		[Export ("imreadanimation:animation:start:count:")]
		bool Imreadanimation (string filename, Animation animation, int start, int count);

		// +(BOOL)imreadanimation:(NSString * _Nonnull)filename animation:(Animation * _Nonnull)animation start:(int)start __attribute__((swift_name("imreadanimation(filename:animation:start:)")));
		[Static]
		[Export ("imreadanimation:animation:start:")]
		bool Imreadanimation (string filename, Animation animation, int start);

		// +(BOOL)imreadanimation:(NSString * _Nonnull)filename animation:(Animation * _Nonnull)animation __attribute__((swift_name("imreadanimation(filename:animation:)")));
		[Static]
		[Export ("imreadanimation:animation:")]
		bool Imreadanimation (string filename, Animation animation);

		// +(BOOL)imdecodeanimation:(Mat * _Nonnull)buf animation:(Animation * _Nonnull)animation start:(int)start count:(int)count __attribute__((swift_name("imdecodeanimation(buf:animation:start:count:)")));
		[Static]
		[Export ("imdecodeanimation:animation:start:count:")]
		bool Imdecodeanimation (Mat buf, Animation animation, int start, int count);

		// +(BOOL)imdecodeanimation:(Mat * _Nonnull)buf animation:(Animation * _Nonnull)animation start:(int)start __attribute__((swift_name("imdecodeanimation(buf:animation:start:)")));
		[Static]
		[Export ("imdecodeanimation:animation:start:")]
		bool Imdecodeanimation (Mat buf, Animation animation, int start);

		// +(BOOL)imdecodeanimation:(Mat * _Nonnull)buf animation:(Animation * _Nonnull)animation __attribute__((swift_name("imdecodeanimation(buf:animation:)")));
		[Static]
		[Export ("imdecodeanimation:animation:")]
		bool Imdecodeanimation (Mat buf, Animation animation);

		// +(BOOL)imwriteanimation:(NSString * _Nonnull)filename animation:(Animation * _Nonnull)animation params:(IntVector * _Nonnull)params __attribute__((swift_name("imwriteanimation(filename:animation:params:)")));
		[Static]
		[Export ("imwriteanimation:animation:params:")]
		bool Imwriteanimation (string filename, Animation animation, IntVector @params);

		// +(BOOL)imwriteanimation:(NSString * _Nonnull)filename animation:(Animation * _Nonnull)animation __attribute__((swift_name("imwriteanimation(filename:animation:)")));
		[Static]
		[Export ("imwriteanimation:animation:")]
		bool Imwriteanimation (string filename, Animation animation);

		// +(BOOL)imencodeanimation:(NSString * _Nonnull)ext animation:(Animation * _Nonnull)animation buf:(ByteVector * _Nonnull)buf params:(IntVector * _Nonnull)params __attribute__((swift_name("imencodeanimation(ext:animation:buf:params:)")));
		[Static]
		[Export ("imencodeanimation:animation:buf:params:")]
		bool Imencodeanimation (string ext, Animation animation, ByteVector buf, IntVector @params);

		// +(BOOL)imencodeanimation:(NSString * _Nonnull)ext animation:(Animation * _Nonnull)animation buf:(ByteVector * _Nonnull)buf __attribute__((swift_name("imencodeanimation(ext:animation:buf:)")));
		[Static]
		[Export ("imencodeanimation:animation:buf:")]
		bool Imencodeanimation (string ext, Animation animation, ByteVector buf);

		// +(size_t)imcount:(NSString * _Nonnull)filename flags:(int)flags __attribute__((swift_name("imcount(filename:flags:)")));
		[Static]
		[Export ("imcount:flags:")]
		nuint Imcount (string filename, int flags);

		// +(size_t)imcount:(NSString * _Nonnull)filename __attribute__((swift_name("imcount(filename:)")));
		[Static]
		[Export ("imcount:")]
		nuint Imcount (string filename);

		// +(BOOL)imwrite:(NSString * _Nonnull)filename img:(Mat * _Nonnull)img params:(IntVector * _Nonnull)params __attribute__((swift_name("imwrite(filename:img:params:)")));
		[Static]
		[Export ("imwrite:img:params:")]
		bool Imwrite (string filename, Mat img, IntVector @params);

		// +(BOOL)imwrite:(NSString * _Nonnull)filename img:(Mat * _Nonnull)img __attribute__((swift_name("imwrite(filename:img:)")));
		[Static]
		[Export ("imwrite:img:")]
		bool Imwrite (string filename, Mat img);

		// +(BOOL)imwriteWithMetadata:(NSString * _Nonnull)filename img:(Mat * _Nonnull)img metadataTypes:(IntVector * _Nonnull)metadataTypes metadata:(NSArray<Mat *> * _Nonnull)metadata params:(IntVector * _Nonnull)params __attribute__((swift_name("imwriteWithMetadata(filename:img:metadataTypes:metadata:params:)")));
		[Static]
		[Export ("imwriteWithMetadata:img:metadataTypes:metadata:params:")]
		bool ImwriteWithMetadata (string filename, Mat img, IntVector metadataTypes, Mat[] metadata, IntVector @params);

		// +(BOOL)imwriteWithMetadata:(NSString * _Nonnull)filename img:(Mat * _Nonnull)img metadataTypes:(IntVector * _Nonnull)metadataTypes metadata:(NSArray<Mat *> * _Nonnull)metadata __attribute__((swift_name("imwriteWithMetadata(filename:img:metadataTypes:metadata:)")));
		[Static]
		[Export ("imwriteWithMetadata:img:metadataTypes:metadata:")]
		bool ImwriteWithMetadata (string filename, Mat img, IntVector metadataTypes, Mat[] metadata);

		// +(BOOL)imwritemulti:(NSString * _Nonnull)filename img:(NSArray<Mat *> * _Nonnull)img params:(IntVector * _Nonnull)params __attribute__((swift_name("imwritemulti(filename:img:params:)")));
		[Static]
		[Export ("imwritemulti:img:params:")]
		bool Imwritemulti (string filename, Mat[] img, IntVector @params);

		// +(BOOL)imwritemulti:(NSString * _Nonnull)filename img:(NSArray<Mat *> * _Nonnull)img __attribute__((swift_name("imwritemulti(filename:img:)")));
		[Static]
		[Export ("imwritemulti:img:")]
		bool Imwritemulti (string filename, Mat[] img);

		// +(Mat * _Nonnull)imdecode:(Mat * _Nonnull)buf flags:(int)flags __attribute__((swift_name("imdecode(buf:flags:)")));
		[Static]
		[Export ("imdecode:flags:")]
		Mat Imdecode (Mat buf, int flags);

		// +(Mat * _Nonnull)imdecodeWithMetadata:(Mat * _Nonnull)buf metadataTypes:(IntVector * _Nonnull)metadataTypes metadata:(NSMutableArray<Mat *> * _Nonnull)metadata flags:(int)flags __attribute__((swift_name("imdecodeWithMetadata(buf:metadataTypes:metadata:flags:)")));
		[Static]
		[Export ("imdecodeWithMetadata:metadataTypes:metadata:flags:")]
		Mat ImdecodeWithMetadata (Mat buf, IntVector metadataTypes, NSMutableArray<Mat> metadata, int flags);

		// +(Mat * _Nonnull)imdecodeWithMetadata:(Mat * _Nonnull)buf metadataTypes:(IntVector * _Nonnull)metadataTypes metadata:(NSMutableArray<Mat *> * _Nonnull)metadata __attribute__((swift_name("imdecodeWithMetadata(buf:metadataTypes:metadata:)")));
		[Static]
		[Export ("imdecodeWithMetadata:metadataTypes:metadata:")]
		Mat ImdecodeWithMetadata (Mat buf, IntVector metadataTypes, NSMutableArray<Mat> metadata);

		// +(BOOL)imdecodemulti:(Mat * _Nonnull)buf flags:(int)flags mats:(NSMutableArray<Mat *> * _Nonnull)mats range:(Range * _Nonnull)range __attribute__((swift_name("imdecodemulti(buf:flags:mats:range:)")));
		[Static]
		[Export ("imdecodemulti:flags:mats:range:")]
		bool Imdecodemulti (Mat buf, int flags, NSMutableArray<Mat> mats, Range range);

		// +(BOOL)imdecodemulti:(Mat * _Nonnull)buf flags:(int)flags mats:(NSMutableArray<Mat *> * _Nonnull)mats __attribute__((swift_name("imdecodemulti(buf:flags:mats:)")));
		[Static]
		[Export ("imdecodemulti:flags:mats:")]
		bool Imdecodemulti (Mat buf, int flags, NSMutableArray<Mat> mats);

		// +(BOOL)imencode:(NSString * _Nonnull)ext img:(Mat * _Nonnull)img buf:(ByteVector * _Nonnull)buf params:(IntVector * _Nonnull)params __attribute__((swift_name("imencode(ext:img:buf:params:)")));
		[Static]
		[Export ("imencode:img:buf:params:")]
		bool Imencode (string ext, Mat img, ByteVector buf, IntVector @params);

		// +(BOOL)imencode:(NSString * _Nonnull)ext img:(Mat * _Nonnull)img buf:(ByteVector * _Nonnull)buf __attribute__((swift_name("imencode(ext:img:buf:)")));
		[Static]
		[Export ("imencode:img:buf:")]
		bool Imencode (string ext, Mat img, ByteVector buf);

		// +(BOOL)imencodeWithMetadata:(NSString * _Nonnull)ext img:(Mat * _Nonnull)img metadataTypes:(IntVector * _Nonnull)metadataTypes metadata:(NSArray<Mat *> * _Nonnull)metadata buf:(ByteVector * _Nonnull)buf params:(IntVector * _Nonnull)params __attribute__((swift_name("imencodeWithMetadata(ext:img:metadataTypes:metadata:buf:params:)")));
		[Static]
		[Export ("imencodeWithMetadata:img:metadataTypes:metadata:buf:params:")]
		bool ImencodeWithMetadata (string ext, Mat img, IntVector metadataTypes, Mat[] metadata, ByteVector buf, IntVector @params);

		// +(BOOL)imencodeWithMetadata:(NSString * _Nonnull)ext img:(Mat * _Nonnull)img metadataTypes:(IntVector * _Nonnull)metadataTypes metadata:(NSArray<Mat *> * _Nonnull)metadata buf:(ByteVector * _Nonnull)buf __attribute__((swift_name("imencodeWithMetadata(ext:img:metadataTypes:metadata:buf:)")));
		[Static]
		[Export ("imencodeWithMetadata:img:metadataTypes:metadata:buf:")]
		bool ImencodeWithMetadata (string ext, Mat img, IntVector metadataTypes, Mat[] metadata, ByteVector buf);

		// +(BOOL)imencodemulti:(NSString * _Nonnull)ext imgs:(NSArray<Mat *> * _Nonnull)imgs buf:(ByteVector * _Nonnull)buf params:(IntVector * _Nonnull)params __attribute__((swift_name("imencodemulti(ext:imgs:buf:params:)")));
		[Static]
		[Export ("imencodemulti:imgs:buf:params:")]
		bool Imencodemulti (string ext, Mat[] imgs, ByteVector buf, IntVector @params);

		// +(BOOL)imencodemulti:(NSString * _Nonnull)ext imgs:(NSArray<Mat *> * _Nonnull)imgs buf:(ByteVector * _Nonnull)buf __attribute__((swift_name("imencodemulti(ext:imgs:buf:)")));
		[Static]
		[Export ("imencodemulti:imgs:buf:")]
		bool Imencodemulti (string ext, Mat[] imgs, ByteVector buf);

		// +(BOOL)haveImageReader:(NSString * _Nonnull)filename __attribute__((swift_name("haveImageReader(filename:)")));
		[Static]
		[Export ("haveImageReader:")]
		bool HaveImageReader (string filename);

		// +(BOOL)haveImageWriter:(NSString * _Nonnull)filename __attribute__((swift_name("haveImageWriter(filename:)")));
		[Static]
		[Export ("haveImageWriter:")]
		bool HaveImageWriter (string filename);
	}

	// @interface Animation : NSObject
	[BaseType (typeof(NSObject))]
	interface Animation
	{
		// -(instancetype _Nonnull)initWithLoopCount:(int)loopCount bgColor:(Scalar * _Nonnull)bgColor;
		[Export ("initWithLoopCount:bgColor:")]
		NativeHandle Constructor (int loopCount, Scalar bgColor);

		// -(instancetype _Nonnull)initWithLoopCount:(int)loopCount;
		[Export ("initWithLoopCount:")]
		NativeHandle Constructor (int loopCount);

		// @property int loop_count;
		[Export ("loop_count")]
		int Loop_count { get; set; }

		// @property Scalar * _Nonnull bgcolor;
		[Export ("bgcolor", ArgumentSemantic.Assign)]
		Scalar Bgcolor { get; set; }

		// @property IntVector * _Nonnull durations;
		[Export ("durations", ArgumentSemantic.Assign)]
		IntVector Durations { get; set; }

		// @property Mat * _Nonnull frames;
		[Export ("frames", ArgumentSemantic.Assign)]
		Mat Frames { get; set; }

		// @property Mat * _Nonnull still_image;
		[Export ("still_image", ArgumentSemantic.Assign)]
		Mat Still_image { get; set; }
	}

	// @interface CvAbstractCamera2 : NSObject
	[BaseType (typeof(NSObject))]
	interface CvAbstractCamera2
	{
		// @property UIDeviceOrientation currentDeviceOrientation;
		[Export ("currentDeviceOrientation", ArgumentSemantic.Assign)]
		UIDeviceOrientation CurrentDeviceOrientation { get; set; }

		// @property BOOL cameraAvailable;
		[Export ("cameraAvailable")]
		bool CameraAvailable { get; set; }

		// @property (nonatomic, strong) AVCaptureSession * captureSession;
		[Export ("captureSession", ArgumentSemantic.Strong)]
		AVCaptureSession CaptureSession { get; set; }

		// @property (nonatomic, strong) AVCaptureConnection * videoCaptureConnection;
		[Export ("videoCaptureConnection", ArgumentSemantic.Strong)]
		AVCaptureConnection VideoCaptureConnection { get; set; }

		// @property (readonly, nonatomic) BOOL running;
		[Export ("running")]
		bool Running { get; }

		// @property (readonly, nonatomic) BOOL captureSessionLoaded;
		[Export ("captureSessionLoaded")]
		bool CaptureSessionLoaded { get; }

		// @property (assign, nonatomic) int defaultFPS;
		[Export ("defaultFPS")]
		int DefaultFPS { get; set; }

		// @property (readonly, nonatomic) AVCaptureVideoPreviewLayer * captureVideoPreviewLayer;
		[Export ("captureVideoPreviewLayer")]
		AVCaptureVideoPreviewLayer CaptureVideoPreviewLayer { get; }

		// @property (assign, nonatomic) AVCaptureDevicePosition defaultAVCaptureDevicePosition;
		[Export ("defaultAVCaptureDevicePosition", ArgumentSemantic.Assign)]
		AVCaptureDevicePosition DefaultAVCaptureDevicePosition { get; set; }

		// @property (assign, nonatomic) AVCaptureVideoOrientation defaultAVCaptureVideoOrientation;
		[Export ("defaultAVCaptureVideoOrientation", ArgumentSemantic.Assign)]
		AVCaptureVideoOrientation DefaultAVCaptureVideoOrientation { get; set; }

		// @property (assign, nonatomic) BOOL useAVCaptureVideoPreviewLayer;
		[Export ("useAVCaptureVideoPreviewLayer")]
		bool UseAVCaptureVideoPreviewLayer { get; set; }

		// @property (nonatomic, strong) NSString *const defaultAVCaptureSessionPreset;
		[Export ("defaultAVCaptureSessionPreset", ArgumentSemantic.Strong)]
		string DefaultAVCaptureSessionPreset { get; set; }

		// @property (assign, nonatomic) int imageWidth;
		[Export ("imageWidth")]
		int ImageWidth { get; set; }

		// @property (assign, nonatomic) int imageHeight;
		[Export ("imageHeight")]
		int ImageHeight { get; set; }

		// @property (nonatomic, strong) UIView * parentView;
		[Export ("parentView", ArgumentSemantic.Strong)]
		UIView ParentView { get; set; }

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(void)switchCameras;
		[Export ("switchCameras")]
		void SwitchCameras ();

		// -(id)initWithParentView:(UIView *)parent;
		[Export ("initWithParentView:")]
		NativeHandle Constructor (UIView parent);

		// -(void)createCaptureOutput;
		[Export ("createCaptureOutput")]
		void CreateCaptureOutput ();

		// -(void)createVideoPreviewLayer;
		[Export ("createVideoPreviewLayer")]
		void CreateVideoPreviewLayer ();

		// -(void)updateOrientation;
		[Export ("updateOrientation")]
		void UpdateOrientation ();

		// -(void)lockFocus;
		[Export ("lockFocus")]
		void LockFocus ();

		// -(void)unlockFocus;
		[Export ("unlockFocus")]
		void UnlockFocus ();

		// -(void)lockExposure;
		[Export ("lockExposure")]
		void LockExposure ();

		// -(void)unlockExposure;
		[Export ("unlockExposure")]
		void UnlockExposure ();

		// -(void)lockBalance;
		[Export ("lockBalance")]
		void LockBalance ();

		// -(void)unlockBalance;
		[Export ("unlockBalance")]
		void UnlockBalance ();
	}

	// @protocol CvVideoCameraDelegate2 <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface CvVideoCameraDelegate2
	{
		// @required -(void)processImage:(Mat *)image;
		[Abstract]
		[Export ("processImage:")]
		void ProcessImage (Mat image);
	}

	interface ICvVideoCameraDelegate2 { };

	// @interface CvVideoCamera2 : CvAbstractCamera2 <AVCaptureVideoDataOutputSampleBufferDelegate>
	[BaseType (typeof(CvAbstractCamera2))]
	interface CvVideoCamera2 : IAVCaptureVideoDataOutputSampleBufferDelegate
	{
		[Wrap ("WeakDelegate")]
		ICvVideoCameraDelegate2 Delegate { get; set; }

		// @property (nonatomic, weak) id<CvVideoCameraDelegate2> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(id)initWithParentView:(UIView *)parent;
		[Export ("initWithParentView:")]
		NativeHandle Constructor (UIView parent);

		// @property (assign, nonatomic) BOOL grayscaleMode;
		[Export ("grayscaleMode")]
		bool GrayscaleMode { get; set; }

		// @property (assign, nonatomic) BOOL recordVideo;
		[Export ("recordVideo")]
		bool RecordVideo { get; set; }

		// @property (assign, nonatomic) BOOL rotateVideo;
		[Export ("rotateVideo")]
		bool RotateVideo { get; set; }

		// @property (nonatomic, strong) AVAssetWriterInput * recordAssetWriterInput;
		[Export ("recordAssetWriterInput", ArgumentSemantic.Strong)]
		AVAssetWriterInput RecordAssetWriterInput { get; set; }

		// @property (nonatomic, strong) AVAssetWriterInputPixelBufferAdaptor * recordPixelBufferAdaptor;
		[Export ("recordPixelBufferAdaptor", ArgumentSemantic.Strong)]
		AVAssetWriterInputPixelBufferAdaptor RecordPixelBufferAdaptor { get; set; }

		// @property (nonatomic, strong) AVAssetWriter * recordAssetWriter;
		[Export ("recordAssetWriter", ArgumentSemantic.Strong)]
		AVAssetWriter RecordAssetWriter { get; set; }

		// -(void)adjustLayoutToInterfaceOrientation:(UIInterfaceOrientation)interfaceOrientation;
		[Export ("adjustLayoutToInterfaceOrientation:")]
		void AdjustLayoutToInterfaceOrientation (UIInterfaceOrientation interfaceOrientation);

		// -(void)layoutPreviewLayer;
		[Export ("layoutPreviewLayer")]
		void LayoutPreviewLayer ();

		// -(void)saveVideo;
		[Export ("saveVideo")]
		void SaveVideo ();

		// -(NSURL *)videoFileURL;
		[Export ("videoFileURL")]
		NSUrl VideoFileURL { get; }

		// -(NSString *)videoFileString;
		[Export ("videoFileString")]
		string VideoFileString { get; }
	}

	// @protocol CvPhotoCameraDelegate2 <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface CvPhotoCameraDelegate2
	{
		// @required -(void)photoCamera:(CvPhotoCamera2 *)photoCamera capturedImage:(UIImage *)image;
		[Abstract]
		[Export ("photoCamera:capturedImage:")]
		void PhotoCamera (CvPhotoCamera2 photoCamera, UIImage image);

		// @required -(void)photoCameraCancel:(CvPhotoCamera2 *)photoCamera;
		[Abstract]
		[Export ("photoCameraCancel:")]
		void PhotoCameraCancel (CvPhotoCamera2 photoCamera);
	}

	interface ICvPhotoCameraDelegate2 { };

	// @interface CvPhotoCamera2 : CvAbstractCamera2 <AVCapturePhotoCaptureDelegate>
	[BaseType (typeof(CvAbstractCamera2))]
	interface CvPhotoCamera2 : IAVCapturePhotoCaptureDelegate
	{
		[Wrap ("WeakDelegate")]
		ICvPhotoCameraDelegate2 Delegate { get; set; }

		// @property (nonatomic, weak) id<CvPhotoCameraDelegate2> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(id)initWithParentView:(UIView *)parent;
		[Export ("initWithParentView:")]
		NativeHandle Constructor (UIView parent);

		// -(void)takePicture;
		[Export ("takePicture")]
		void TakePicture ();
	}

	// @interface Videoio : NSObject
	[BaseType (typeof(NSObject))]
	interface Videoio
	{
		// @property (readonly, class) int CAP_PROP_DC1394_OFF __attribute__((swift_name("CAP_PROP_DC1394_OFF")));
		[Static]
		[Export ("CAP_PROP_DC1394_OFF")]
		int CAP_PROP_DC1394_OFF { get; }

		// @property (readonly, class) int CAP_PROP_DC1394_MODE_MANUAL __attribute__((swift_name("CAP_PROP_DC1394_MODE_MANUAL")));
		[Static]
		[Export ("CAP_PROP_DC1394_MODE_MANUAL")]
		int CAP_PROP_DC1394_MODE_MANUAL { get; }

		// @property (readonly, class) int CAP_PROP_DC1394_MODE_AUTO __attribute__((swift_name("CAP_PROP_DC1394_MODE_AUTO")));
		[Static]
		[Export ("CAP_PROP_DC1394_MODE_AUTO")]
		int CAP_PROP_DC1394_MODE_AUTO { get; }

		// @property (readonly, class) int CAP_PROP_DC1394_MODE_ONE_PUSH_AUTO __attribute__((swift_name("CAP_PROP_DC1394_MODE_ONE_PUSH_AUTO")));
		[Static]
		[Export ("CAP_PROP_DC1394_MODE_ONE_PUSH_AUTO")]
		int CAP_PROP_DC1394_MODE_ONE_PUSH_AUTO { get; }

		// @property (readonly, class) int CAP_PROP_DC1394_MAX __attribute__((swift_name("CAP_PROP_DC1394_MAX")));
		[Static]
		[Export ("CAP_PROP_DC1394_MAX")]
		int CAP_PROP_DC1394_MAX { get; }

		// @property (readonly, class) int CAP_OPENNI_DEPTH_GENERATOR __attribute__((swift_name("CAP_OPENNI_DEPTH_GENERATOR")));
		[Static]
		[Export ("CAP_OPENNI_DEPTH_GENERATOR")]
		int CAP_OPENNI_DEPTH_GENERATOR { get; }

		// @property (readonly, class) int CAP_OPENNI_IMAGE_GENERATOR __attribute__((swift_name("CAP_OPENNI_IMAGE_GENERATOR")));
		[Static]
		[Export ("CAP_OPENNI_IMAGE_GENERATOR")]
		int CAP_OPENNI_IMAGE_GENERATOR { get; }

		// @property (readonly, class) int CAP_OPENNI_IR_GENERATOR __attribute__((swift_name("CAP_OPENNI_IR_GENERATOR")));
		[Static]
		[Export ("CAP_OPENNI_IR_GENERATOR")]
		int CAP_OPENNI_IR_GENERATOR { get; }

		// @property (readonly, class) int CAP_OPENNI_GENERATORS_MASK __attribute__((swift_name("CAP_OPENNI_GENERATORS_MASK")));
		[Static]
		[Export ("CAP_OPENNI_GENERATORS_MASK")]
		int CAP_OPENNI_GENERATORS_MASK { get; }

		// @property (readonly, class) int CAP_PROP_OPENNI_OUTPUT_MODE __attribute__((swift_name("CAP_PROP_OPENNI_OUTPUT_MODE")));
		[Static]
		[Export ("CAP_PROP_OPENNI_OUTPUT_MODE")]
		int CAP_PROP_OPENNI_OUTPUT_MODE { get; }

		// @property (readonly, class) int CAP_PROP_OPENNI_FRAME_MAX_DEPTH __attribute__((swift_name("CAP_PROP_OPENNI_FRAME_MAX_DEPTH")));
		[Static]
		[Export ("CAP_PROP_OPENNI_FRAME_MAX_DEPTH")]
		int CAP_PROP_OPENNI_FRAME_MAX_DEPTH { get; }

		// @property (readonly, class) int CAP_PROP_OPENNI_BASELINE __attribute__((swift_name("CAP_PROP_OPENNI_BASELINE")));
		[Static]
		[Export ("CAP_PROP_OPENNI_BASELINE")]
		int CAP_PROP_OPENNI_BASELINE { get; }

		// @property (readonly, class) int CAP_PROP_OPENNI_FOCAL_LENGTH __attribute__((swift_name("CAP_PROP_OPENNI_FOCAL_LENGTH")));
		[Static]
		[Export ("CAP_PROP_OPENNI_FOCAL_LENGTH")]
		int CAP_PROP_OPENNI_FOCAL_LENGTH { get; }

		// @property (readonly, class) int CAP_PROP_OPENNI_REGISTRATION __attribute__((swift_name("CAP_PROP_OPENNI_REGISTRATION")));
		[Static]
		[Export ("CAP_PROP_OPENNI_REGISTRATION")]
		int CAP_PROP_OPENNI_REGISTRATION { get; }

		// @property (readonly, class) int CAP_PROP_OPENNI_REGISTRATION_ON __attribute__((swift_name("CAP_PROP_OPENNI_REGISTRATION_ON")));
		[Static]
		[Export ("CAP_PROP_OPENNI_REGISTRATION_ON")]
		int CAP_PROP_OPENNI_REGISTRATION_ON { get; }

		// @property (readonly, class) int CAP_PROP_OPENNI_APPROX_FRAME_SYNC __attribute__((swift_name("CAP_PROP_OPENNI_APPROX_FRAME_SYNC")));
		[Static]
		[Export ("CAP_PROP_OPENNI_APPROX_FRAME_SYNC")]
		int CAP_PROP_OPENNI_APPROX_FRAME_SYNC { get; }

		// @property (readonly, class) int CAP_PROP_OPENNI_MAX_BUFFER_SIZE __attribute__((swift_name("CAP_PROP_OPENNI_MAX_BUFFER_SIZE")));
		[Static]
		[Export ("CAP_PROP_OPENNI_MAX_BUFFER_SIZE")]
		int CAP_PROP_OPENNI_MAX_BUFFER_SIZE { get; }

		// @property (readonly, class) int CAP_PROP_OPENNI_CIRCLE_BUFFER __attribute__((swift_name("CAP_PROP_OPENNI_CIRCLE_BUFFER")));
		[Static]
		[Export ("CAP_PROP_OPENNI_CIRCLE_BUFFER")]
		int CAP_PROP_OPENNI_CIRCLE_BUFFER { get; }

		// @property (readonly, class) int CAP_PROP_OPENNI_MAX_TIME_DURATION __attribute__((swift_name("CAP_PROP_OPENNI_MAX_TIME_DURATION")));
		[Static]
		[Export ("CAP_PROP_OPENNI_MAX_TIME_DURATION")]
		int CAP_PROP_OPENNI_MAX_TIME_DURATION { get; }

		// @property (readonly, class) int CAP_PROP_OPENNI_GENERATOR_PRESENT __attribute__((swift_name("CAP_PROP_OPENNI_GENERATOR_PRESENT")));
		[Static]
		[Export ("CAP_PROP_OPENNI_GENERATOR_PRESENT")]
		int CAP_PROP_OPENNI_GENERATOR_PRESENT { get; }

		// @property (readonly, class) int CAP_PROP_OPENNI2_SYNC __attribute__((swift_name("CAP_PROP_OPENNI2_SYNC")));
		[Static]
		[Export ("CAP_PROP_OPENNI2_SYNC")]
		int CAP_PROP_OPENNI2_SYNC { get; }

		// @property (readonly, class) int CAP_PROP_OPENNI2_MIRROR __attribute__((swift_name("CAP_PROP_OPENNI2_MIRROR")));
		[Static]
		[Export ("CAP_PROP_OPENNI2_MIRROR")]
		int CAP_PROP_OPENNI2_MIRROR { get; }

		// @property (readonly, class) int CAP_OPENNI_IMAGE_GENERATOR_PRESENT __attribute__((swift_name("CAP_OPENNI_IMAGE_GENERATOR_PRESENT")));
		[Static]
		[Export ("CAP_OPENNI_IMAGE_GENERATOR_PRESENT")]
		int CAP_OPENNI_IMAGE_GENERATOR_PRESENT { get; }

		// @property (readonly, class) int CAP_OPENNI_IMAGE_GENERATOR_OUTPUT_MODE __attribute__((swift_name("CAP_OPENNI_IMAGE_GENERATOR_OUTPUT_MODE")));
		[Static]
		[Export ("CAP_OPENNI_IMAGE_GENERATOR_OUTPUT_MODE")]
		int CAP_OPENNI_IMAGE_GENERATOR_OUTPUT_MODE { get; }

		// @property (readonly, class) int CAP_OPENNI_DEPTH_GENERATOR_PRESENT __attribute__((swift_name("CAP_OPENNI_DEPTH_GENERATOR_PRESENT")));
		[Static]
		[Export ("CAP_OPENNI_DEPTH_GENERATOR_PRESENT")]
		int CAP_OPENNI_DEPTH_GENERATOR_PRESENT { get; }

		// @property (readonly, class) int CAP_OPENNI_DEPTH_GENERATOR_BASELINE __attribute__((swift_name("CAP_OPENNI_DEPTH_GENERATOR_BASELINE")));
		[Static]
		[Export ("CAP_OPENNI_DEPTH_GENERATOR_BASELINE")]
		int CAP_OPENNI_DEPTH_GENERATOR_BASELINE { get; }

		// @property (readonly, class) int CAP_OPENNI_DEPTH_GENERATOR_FOCAL_LENGTH __attribute__((swift_name("CAP_OPENNI_DEPTH_GENERATOR_FOCAL_LENGTH")));
		[Static]
		[Export ("CAP_OPENNI_DEPTH_GENERATOR_FOCAL_LENGTH")]
		int CAP_OPENNI_DEPTH_GENERATOR_FOCAL_LENGTH { get; }

		// @property (readonly, class) int CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION __attribute__((swift_name("CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION")));
		[Static]
		[Export ("CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION")]
		int CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION { get; }

		// @property (readonly, class) int CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION_ON __attribute__((swift_name("CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION_ON")));
		[Static]
		[Export ("CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION_ON")]
		int CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION_ON { get; }

		// @property (readonly, class) int CAP_OPENNI_IR_GENERATOR_PRESENT __attribute__((swift_name("CAP_OPENNI_IR_GENERATOR_PRESENT")));
		[Static]
		[Export ("CAP_OPENNI_IR_GENERATOR_PRESENT")]
		int CAP_OPENNI_IR_GENERATOR_PRESENT { get; }

		// @property (readonly, class) int CAP_OPENNI_DEPTH_MAP __attribute__((swift_name("CAP_OPENNI_DEPTH_MAP")));
		[Static]
		[Export ("CAP_OPENNI_DEPTH_MAP")]
		int CAP_OPENNI_DEPTH_MAP { get; }

		// @property (readonly, class) int CAP_OPENNI_POINT_CLOUD_MAP __attribute__((swift_name("CAP_OPENNI_POINT_CLOUD_MAP")));
		[Static]
		[Export ("CAP_OPENNI_POINT_CLOUD_MAP")]
		int CAP_OPENNI_POINT_CLOUD_MAP { get; }

		// @property (readonly, class) int CAP_OPENNI_DISPARITY_MAP __attribute__((swift_name("CAP_OPENNI_DISPARITY_MAP")));
		[Static]
		[Export ("CAP_OPENNI_DISPARITY_MAP")]
		int CAP_OPENNI_DISPARITY_MAP { get; }

		// @property (readonly, class) int CAP_OPENNI_DISPARITY_MAP_32F __attribute__((swift_name("CAP_OPENNI_DISPARITY_MAP_32F")));
		[Static]
		[Export ("CAP_OPENNI_DISPARITY_MAP_32F")]
		int CAP_OPENNI_DISPARITY_MAP_32F { get; }

		// @property (readonly, class) int CAP_OPENNI_VALID_DEPTH_MASK __attribute__((swift_name("CAP_OPENNI_VALID_DEPTH_MASK")));
		[Static]
		[Export ("CAP_OPENNI_VALID_DEPTH_MASK")]
		int CAP_OPENNI_VALID_DEPTH_MASK { get; }

		// @property (readonly, class) int CAP_OPENNI_BGR_IMAGE __attribute__((swift_name("CAP_OPENNI_BGR_IMAGE")));
		[Static]
		[Export ("CAP_OPENNI_BGR_IMAGE")]
		int CAP_OPENNI_BGR_IMAGE { get; }

		// @property (readonly, class) int CAP_OPENNI_GRAY_IMAGE __attribute__((swift_name("CAP_OPENNI_GRAY_IMAGE")));
		[Static]
		[Export ("CAP_OPENNI_GRAY_IMAGE")]
		int CAP_OPENNI_GRAY_IMAGE { get; }

		// @property (readonly, class) int CAP_OPENNI_IR_IMAGE __attribute__((swift_name("CAP_OPENNI_IR_IMAGE")));
		[Static]
		[Export ("CAP_OPENNI_IR_IMAGE")]
		int CAP_OPENNI_IR_IMAGE { get; }

		// @property (readonly, class) int CAP_OPENNI_VGA_30HZ __attribute__((swift_name("CAP_OPENNI_VGA_30HZ")));
		[Static]
		[Export ("CAP_OPENNI_VGA_30HZ")]
		int CAP_OPENNI_VGA_30HZ { get; }

		// @property (readonly, class) int CAP_OPENNI_SXGA_15HZ __attribute__((swift_name("CAP_OPENNI_SXGA_15HZ")));
		[Static]
		[Export ("CAP_OPENNI_SXGA_15HZ")]
		int CAP_OPENNI_SXGA_15HZ { get; }

		// @property (readonly, class) int CAP_OPENNI_SXGA_30HZ __attribute__((swift_name("CAP_OPENNI_SXGA_30HZ")));
		[Static]
		[Export ("CAP_OPENNI_SXGA_30HZ")]
		int CAP_OPENNI_SXGA_30HZ { get; }

		// @property (readonly, class) int CAP_OPENNI_QVGA_30HZ __attribute__((swift_name("CAP_OPENNI_QVGA_30HZ")));
		[Static]
		[Export ("CAP_OPENNI_QVGA_30HZ")]
		int CAP_OPENNI_QVGA_30HZ { get; }

		// @property (readonly, class) int CAP_OPENNI_QVGA_60HZ __attribute__((swift_name("CAP_OPENNI_QVGA_60HZ")));
		[Static]
		[Export ("CAP_OPENNI_QVGA_60HZ")]
		int CAP_OPENNI_QVGA_60HZ { get; }

		// @property (readonly, class) int CAP_PROP_GSTREAMER_QUEUE_LENGTH __attribute__((swift_name("CAP_PROP_GSTREAMER_QUEUE_LENGTH")));
		[Static]
		[Export ("CAP_PROP_GSTREAMER_QUEUE_LENGTH")]
		int CAP_PROP_GSTREAMER_QUEUE_LENGTH { get; }

		// @property (readonly, class) int CAP_PROP_PVAPI_MULTICASTIP __attribute__((swift_name("CAP_PROP_PVAPI_MULTICASTIP")));
		[Static]
		[Export ("CAP_PROP_PVAPI_MULTICASTIP")]
		int CAP_PROP_PVAPI_MULTICASTIP { get; }

		// @property (readonly, class) int CAP_PROP_PVAPI_FRAMESTARTTRIGGERMODE __attribute__((swift_name("CAP_PROP_PVAPI_FRAMESTARTTRIGGERMODE")));
		[Static]
		[Export ("CAP_PROP_PVAPI_FRAMESTARTTRIGGERMODE")]
		int CAP_PROP_PVAPI_FRAMESTARTTRIGGERMODE { get; }

		// @property (readonly, class) int CAP_PROP_PVAPI_DECIMATIONHORIZONTAL __attribute__((swift_name("CAP_PROP_PVAPI_DECIMATIONHORIZONTAL")));
		[Static]
		[Export ("CAP_PROP_PVAPI_DECIMATIONHORIZONTAL")]
		int CAP_PROP_PVAPI_DECIMATIONHORIZONTAL { get; }

		// @property (readonly, class) int CAP_PROP_PVAPI_DECIMATIONVERTICAL __attribute__((swift_name("CAP_PROP_PVAPI_DECIMATIONVERTICAL")));
		[Static]
		[Export ("CAP_PROP_PVAPI_DECIMATIONVERTICAL")]
		int CAP_PROP_PVAPI_DECIMATIONVERTICAL { get; }

		// @property (readonly, class) int CAP_PROP_PVAPI_BINNINGX __attribute__((swift_name("CAP_PROP_PVAPI_BINNINGX")));
		[Static]
		[Export ("CAP_PROP_PVAPI_BINNINGX")]
		int CAP_PROP_PVAPI_BINNINGX { get; }

		// @property (readonly, class) int CAP_PROP_PVAPI_BINNINGY __attribute__((swift_name("CAP_PROP_PVAPI_BINNINGY")));
		[Static]
		[Export ("CAP_PROP_PVAPI_BINNINGY")]
		int CAP_PROP_PVAPI_BINNINGY { get; }

		// @property (readonly, class) int CAP_PROP_PVAPI_PIXELFORMAT __attribute__((swift_name("CAP_PROP_PVAPI_PIXELFORMAT")));
		[Static]
		[Export ("CAP_PROP_PVAPI_PIXELFORMAT")]
		int CAP_PROP_PVAPI_PIXELFORMAT { get; }

		// @property (readonly, class) int CAP_PVAPI_FSTRIGMODE_FREERUN __attribute__((swift_name("CAP_PVAPI_FSTRIGMODE_FREERUN")));
		[Static]
		[Export ("CAP_PVAPI_FSTRIGMODE_FREERUN")]
		int CAP_PVAPI_FSTRIGMODE_FREERUN { get; }

		// @property (readonly, class) int CAP_PVAPI_FSTRIGMODE_SYNCIN1 __attribute__((swift_name("CAP_PVAPI_FSTRIGMODE_SYNCIN1")));
		[Static]
		[Export ("CAP_PVAPI_FSTRIGMODE_SYNCIN1")]
		int CAP_PVAPI_FSTRIGMODE_SYNCIN1 { get; }

		// @property (readonly, class) int CAP_PVAPI_FSTRIGMODE_SYNCIN2 __attribute__((swift_name("CAP_PVAPI_FSTRIGMODE_SYNCIN2")));
		[Static]
		[Export ("CAP_PVAPI_FSTRIGMODE_SYNCIN2")]
		int CAP_PVAPI_FSTRIGMODE_SYNCIN2 { get; }

		// @property (readonly, class) int CAP_PVAPI_FSTRIGMODE_FIXEDRATE __attribute__((swift_name("CAP_PVAPI_FSTRIGMODE_FIXEDRATE")));
		[Static]
		[Export ("CAP_PVAPI_FSTRIGMODE_FIXEDRATE")]
		int CAP_PVAPI_FSTRIGMODE_FIXEDRATE { get; }

		// @property (readonly, class) int CAP_PVAPI_FSTRIGMODE_SOFTWARE __attribute__((swift_name("CAP_PVAPI_FSTRIGMODE_SOFTWARE")));
		[Static]
		[Export ("CAP_PVAPI_FSTRIGMODE_SOFTWARE")]
		int CAP_PVAPI_FSTRIGMODE_SOFTWARE { get; }

		// @property (readonly, class) int CAP_PVAPI_DECIMATION_OFF __attribute__((swift_name("CAP_PVAPI_DECIMATION_OFF")));
		[Static]
		[Export ("CAP_PVAPI_DECIMATION_OFF")]
		int CAP_PVAPI_DECIMATION_OFF { get; }

		// @property (readonly, class) int CAP_PVAPI_DECIMATION_2OUTOF4 __attribute__((swift_name("CAP_PVAPI_DECIMATION_2OUTOF4")));
		[Static]
		[Export ("CAP_PVAPI_DECIMATION_2OUTOF4")]
		int CAP_PVAPI_DECIMATION_2OUTOF4 { get; }

		// @property (readonly, class) int CAP_PVAPI_DECIMATION_2OUTOF8 __attribute__((swift_name("CAP_PVAPI_DECIMATION_2OUTOF8")));
		[Static]
		[Export ("CAP_PVAPI_DECIMATION_2OUTOF8")]
		int CAP_PVAPI_DECIMATION_2OUTOF8 { get; }

		// @property (readonly, class) int CAP_PVAPI_DECIMATION_2OUTOF16 __attribute__((swift_name("CAP_PVAPI_DECIMATION_2OUTOF16")));
		[Static]
		[Export ("CAP_PVAPI_DECIMATION_2OUTOF16")]
		int CAP_PVAPI_DECIMATION_2OUTOF16 { get; }

		// @property (readonly, class) int CAP_PVAPI_PIXELFORMAT_MONO8 __attribute__((swift_name("CAP_PVAPI_PIXELFORMAT_MONO8")));
		[Static]
		[Export ("CAP_PVAPI_PIXELFORMAT_MONO8")]
		int CAP_PVAPI_PIXELFORMAT_MONO8 { get; }

		// @property (readonly, class) int CAP_PVAPI_PIXELFORMAT_MONO16 __attribute__((swift_name("CAP_PVAPI_PIXELFORMAT_MONO16")));
		[Static]
		[Export ("CAP_PVAPI_PIXELFORMAT_MONO16")]
		int CAP_PVAPI_PIXELFORMAT_MONO16 { get; }

		// @property (readonly, class) int CAP_PVAPI_PIXELFORMAT_BAYER8 __attribute__((swift_name("CAP_PVAPI_PIXELFORMAT_BAYER8")));
		[Static]
		[Export ("CAP_PVAPI_PIXELFORMAT_BAYER8")]
		int CAP_PVAPI_PIXELFORMAT_BAYER8 { get; }

		// @property (readonly, class) int CAP_PVAPI_PIXELFORMAT_BAYER16 __attribute__((swift_name("CAP_PVAPI_PIXELFORMAT_BAYER16")));
		[Static]
		[Export ("CAP_PVAPI_PIXELFORMAT_BAYER16")]
		int CAP_PVAPI_PIXELFORMAT_BAYER16 { get; }

		// @property (readonly, class) int CAP_PVAPI_PIXELFORMAT_RGB24 __attribute__((swift_name("CAP_PVAPI_PIXELFORMAT_RGB24")));
		[Static]
		[Export ("CAP_PVAPI_PIXELFORMAT_RGB24")]
		int CAP_PVAPI_PIXELFORMAT_RGB24 { get; }

		// @property (readonly, class) int CAP_PVAPI_PIXELFORMAT_BGR24 __attribute__((swift_name("CAP_PVAPI_PIXELFORMAT_BGR24")));
		[Static]
		[Export ("CAP_PVAPI_PIXELFORMAT_BGR24")]
		int CAP_PVAPI_PIXELFORMAT_BGR24 { get; }

		// @property (readonly, class) int CAP_PVAPI_PIXELFORMAT_RGBA32 __attribute__((swift_name("CAP_PVAPI_PIXELFORMAT_RGBA32")));
		[Static]
		[Export ("CAP_PVAPI_PIXELFORMAT_RGBA32")]
		int CAP_PVAPI_PIXELFORMAT_RGBA32 { get; }

		// @property (readonly, class) int CAP_PVAPI_PIXELFORMAT_BGRA32 __attribute__((swift_name("CAP_PVAPI_PIXELFORMAT_BGRA32")));
		[Static]
		[Export ("CAP_PVAPI_PIXELFORMAT_BGRA32")]
		int CAP_PVAPI_PIXELFORMAT_BGRA32 { get; }

		// @property (readonly, class) int CAP_PROP_XI_DOWNSAMPLING __attribute__((swift_name("CAP_PROP_XI_DOWNSAMPLING")));
		[Static]
		[Export ("CAP_PROP_XI_DOWNSAMPLING")]
		int CAP_PROP_XI_DOWNSAMPLING { get; }

		// @property (readonly, class) int CAP_PROP_XI_DATA_FORMAT __attribute__((swift_name("CAP_PROP_XI_DATA_FORMAT")));
		[Static]
		[Export ("CAP_PROP_XI_DATA_FORMAT")]
		int CAP_PROP_XI_DATA_FORMAT { get; }

		// @property (readonly, class) int CAP_PROP_XI_OFFSET_X __attribute__((swift_name("CAP_PROP_XI_OFFSET_X")));
		[Static]
		[Export ("CAP_PROP_XI_OFFSET_X")]
		int CAP_PROP_XI_OFFSET_X { get; }

		// @property (readonly, class) int CAP_PROP_XI_OFFSET_Y __attribute__((swift_name("CAP_PROP_XI_OFFSET_Y")));
		[Static]
		[Export ("CAP_PROP_XI_OFFSET_Y")]
		int CAP_PROP_XI_OFFSET_Y { get; }

		// @property (readonly, class) int CAP_PROP_XI_TRG_SOURCE __attribute__((swift_name("CAP_PROP_XI_TRG_SOURCE")));
		[Static]
		[Export ("CAP_PROP_XI_TRG_SOURCE")]
		int CAP_PROP_XI_TRG_SOURCE { get; }

		// @property (readonly, class) int CAP_PROP_XI_TRG_SOFTWARE __attribute__((swift_name("CAP_PROP_XI_TRG_SOFTWARE")));
		[Static]
		[Export ("CAP_PROP_XI_TRG_SOFTWARE")]
		int CAP_PROP_XI_TRG_SOFTWARE { get; }

		// @property (readonly, class) int CAP_PROP_XI_GPI_SELECTOR __attribute__((swift_name("CAP_PROP_XI_GPI_SELECTOR")));
		[Static]
		[Export ("CAP_PROP_XI_GPI_SELECTOR")]
		int CAP_PROP_XI_GPI_SELECTOR { get; }

		// @property (readonly, class) int CAP_PROP_XI_GPI_MODE __attribute__((swift_name("CAP_PROP_XI_GPI_MODE")));
		[Static]
		[Export ("CAP_PROP_XI_GPI_MODE")]
		int CAP_PROP_XI_GPI_MODE { get; }

		// @property (readonly, class) int CAP_PROP_XI_GPI_LEVEL __attribute__((swift_name("CAP_PROP_XI_GPI_LEVEL")));
		[Static]
		[Export ("CAP_PROP_XI_GPI_LEVEL")]
		int CAP_PROP_XI_GPI_LEVEL { get; }

		// @property (readonly, class) int CAP_PROP_XI_GPO_SELECTOR __attribute__((swift_name("CAP_PROP_XI_GPO_SELECTOR")));
		[Static]
		[Export ("CAP_PROP_XI_GPO_SELECTOR")]
		int CAP_PROP_XI_GPO_SELECTOR { get; }

		// @property (readonly, class) int CAP_PROP_XI_GPO_MODE __attribute__((swift_name("CAP_PROP_XI_GPO_MODE")));
		[Static]
		[Export ("CAP_PROP_XI_GPO_MODE")]
		int CAP_PROP_XI_GPO_MODE { get; }

		// @property (readonly, class) int CAP_PROP_XI_LED_SELECTOR __attribute__((swift_name("CAP_PROP_XI_LED_SELECTOR")));
		[Static]
		[Export ("CAP_PROP_XI_LED_SELECTOR")]
		int CAP_PROP_XI_LED_SELECTOR { get; }

		// @property (readonly, class) int CAP_PROP_XI_LED_MODE __attribute__((swift_name("CAP_PROP_XI_LED_MODE")));
		[Static]
		[Export ("CAP_PROP_XI_LED_MODE")]
		int CAP_PROP_XI_LED_MODE { get; }

		// @property (readonly, class) int CAP_PROP_XI_MANUAL_WB __attribute__((swift_name("CAP_PROP_XI_MANUAL_WB")));
		[Static]
		[Export ("CAP_PROP_XI_MANUAL_WB")]
		int CAP_PROP_XI_MANUAL_WB { get; }

		// @property (readonly, class) int CAP_PROP_XI_AUTO_WB __attribute__((swift_name("CAP_PROP_XI_AUTO_WB")));
		[Static]
		[Export ("CAP_PROP_XI_AUTO_WB")]
		int CAP_PROP_XI_AUTO_WB { get; }

		// @property (readonly, class) int CAP_PROP_XI_AEAG __attribute__((swift_name("CAP_PROP_XI_AEAG")));
		[Static]
		[Export ("CAP_PROP_XI_AEAG")]
		int CAP_PROP_XI_AEAG { get; }

		// @property (readonly, class) int CAP_PROP_XI_EXP_PRIORITY __attribute__((swift_name("CAP_PROP_XI_EXP_PRIORITY")));
		[Static]
		[Export ("CAP_PROP_XI_EXP_PRIORITY")]
		int CAP_PROP_XI_EXP_PRIORITY { get; }

		// @property (readonly, class) int CAP_PROP_XI_AE_MAX_LIMIT __attribute__((swift_name("CAP_PROP_XI_AE_MAX_LIMIT")));
		[Static]
		[Export ("CAP_PROP_XI_AE_MAX_LIMIT")]
		int CAP_PROP_XI_AE_MAX_LIMIT { get; }

		// @property (readonly, class) int CAP_PROP_XI_AG_MAX_LIMIT __attribute__((swift_name("CAP_PROP_XI_AG_MAX_LIMIT")));
		[Static]
		[Export ("CAP_PROP_XI_AG_MAX_LIMIT")]
		int CAP_PROP_XI_AG_MAX_LIMIT { get; }

		// @property (readonly, class) int CAP_PROP_XI_AEAG_LEVEL __attribute__((swift_name("CAP_PROP_XI_AEAG_LEVEL")));
		[Static]
		[Export ("CAP_PROP_XI_AEAG_LEVEL")]
		int CAP_PROP_XI_AEAG_LEVEL { get; }

		// @property (readonly, class) int CAP_PROP_XI_TIMEOUT __attribute__((swift_name("CAP_PROP_XI_TIMEOUT")));
		[Static]
		[Export ("CAP_PROP_XI_TIMEOUT")]
		int CAP_PROP_XI_TIMEOUT { get; }

		// @property (readonly, class) int CAP_PROP_XI_EXPOSURE __attribute__((swift_name("CAP_PROP_XI_EXPOSURE")));
		[Static]
		[Export ("CAP_PROP_XI_EXPOSURE")]
		int CAP_PROP_XI_EXPOSURE { get; }

		// @property (readonly, class) int CAP_PROP_XI_EXPOSURE_BURST_COUNT __attribute__((swift_name("CAP_PROP_XI_EXPOSURE_BURST_COUNT")));
		[Static]
		[Export ("CAP_PROP_XI_EXPOSURE_BURST_COUNT")]
		int CAP_PROP_XI_EXPOSURE_BURST_COUNT { get; }

		// @property (readonly, class) int CAP_PROP_XI_GAIN_SELECTOR __attribute__((swift_name("CAP_PROP_XI_GAIN_SELECTOR")));
		[Static]
		[Export ("CAP_PROP_XI_GAIN_SELECTOR")]
		int CAP_PROP_XI_GAIN_SELECTOR { get; }

		// @property (readonly, class) int CAP_PROP_XI_GAIN __attribute__((swift_name("CAP_PROP_XI_GAIN")));
		[Static]
		[Export ("CAP_PROP_XI_GAIN")]
		int CAP_PROP_XI_GAIN { get; }

		// @property (readonly, class) int CAP_PROP_XI_DOWNSAMPLING_TYPE __attribute__((swift_name("CAP_PROP_XI_DOWNSAMPLING_TYPE")));
		[Static]
		[Export ("CAP_PROP_XI_DOWNSAMPLING_TYPE")]
		int CAP_PROP_XI_DOWNSAMPLING_TYPE { get; }

		// @property (readonly, class) int CAP_PROP_XI_BINNING_SELECTOR __attribute__((swift_name("CAP_PROP_XI_BINNING_SELECTOR")));
		[Static]
		[Export ("CAP_PROP_XI_BINNING_SELECTOR")]
		int CAP_PROP_XI_BINNING_SELECTOR { get; }

		// @property (readonly, class) int CAP_PROP_XI_BINNING_VERTICAL __attribute__((swift_name("CAP_PROP_XI_BINNING_VERTICAL")));
		[Static]
		[Export ("CAP_PROP_XI_BINNING_VERTICAL")]
		int CAP_PROP_XI_BINNING_VERTICAL { get; }

		// @property (readonly, class) int CAP_PROP_XI_BINNING_HORIZONTAL __attribute__((swift_name("CAP_PROP_XI_BINNING_HORIZONTAL")));
		[Static]
		[Export ("CAP_PROP_XI_BINNING_HORIZONTAL")]
		int CAP_PROP_XI_BINNING_HORIZONTAL { get; }

		// @property (readonly, class) int CAP_PROP_XI_BINNING_PATTERN __attribute__((swift_name("CAP_PROP_XI_BINNING_PATTERN")));
		[Static]
		[Export ("CAP_PROP_XI_BINNING_PATTERN")]
		int CAP_PROP_XI_BINNING_PATTERN { get; }

		// @property (readonly, class) int CAP_PROP_XI_DECIMATION_SELECTOR __attribute__((swift_name("CAP_PROP_XI_DECIMATION_SELECTOR")));
		[Static]
		[Export ("CAP_PROP_XI_DECIMATION_SELECTOR")]
		int CAP_PROP_XI_DECIMATION_SELECTOR { get; }

		// @property (readonly, class) int CAP_PROP_XI_DECIMATION_VERTICAL __attribute__((swift_name("CAP_PROP_XI_DECIMATION_VERTICAL")));
		[Static]
		[Export ("CAP_PROP_XI_DECIMATION_VERTICAL")]
		int CAP_PROP_XI_DECIMATION_VERTICAL { get; }

		// @property (readonly, class) int CAP_PROP_XI_DECIMATION_HORIZONTAL __attribute__((swift_name("CAP_PROP_XI_DECIMATION_HORIZONTAL")));
		[Static]
		[Export ("CAP_PROP_XI_DECIMATION_HORIZONTAL")]
		int CAP_PROP_XI_DECIMATION_HORIZONTAL { get; }

		// @property (readonly, class) int CAP_PROP_XI_DECIMATION_PATTERN __attribute__((swift_name("CAP_PROP_XI_DECIMATION_PATTERN")));
		[Static]
		[Export ("CAP_PROP_XI_DECIMATION_PATTERN")]
		int CAP_PROP_XI_DECIMATION_PATTERN { get; }

		// @property (readonly, class) int CAP_PROP_XI_TEST_PATTERN_GENERATOR_SELECTOR __attribute__((swift_name("CAP_PROP_XI_TEST_PATTERN_GENERATOR_SELECTOR")));
		[Static]
		[Export ("CAP_PROP_XI_TEST_PATTERN_GENERATOR_SELECTOR")]
		int CAP_PROP_XI_TEST_PATTERN_GENERATOR_SELECTOR { get; }

		// @property (readonly, class) int CAP_PROP_XI_TEST_PATTERN __attribute__((swift_name("CAP_PROP_XI_TEST_PATTERN")));
		[Static]
		[Export ("CAP_PROP_XI_TEST_PATTERN")]
		int CAP_PROP_XI_TEST_PATTERN { get; }

		// @property (readonly, class) int CAP_PROP_XI_IMAGE_DATA_FORMAT __attribute__((swift_name("CAP_PROP_XI_IMAGE_DATA_FORMAT")));
		[Static]
		[Export ("CAP_PROP_XI_IMAGE_DATA_FORMAT")]
		int CAP_PROP_XI_IMAGE_DATA_FORMAT { get; }

		// @property (readonly, class) int CAP_PROP_XI_SHUTTER_TYPE __attribute__((swift_name("CAP_PROP_XI_SHUTTER_TYPE")));
		[Static]
		[Export ("CAP_PROP_XI_SHUTTER_TYPE")]
		int CAP_PROP_XI_SHUTTER_TYPE { get; }

		// @property (readonly, class) int CAP_PROP_XI_SENSOR_TAPS __attribute__((swift_name("CAP_PROP_XI_SENSOR_TAPS")));
		[Static]
		[Export ("CAP_PROP_XI_SENSOR_TAPS")]
		int CAP_PROP_XI_SENSOR_TAPS { get; }

		// @property (readonly, class) int CAP_PROP_XI_AEAG_ROI_OFFSET_X __attribute__((swift_name("CAP_PROP_XI_AEAG_ROI_OFFSET_X")));
		[Static]
		[Export ("CAP_PROP_XI_AEAG_ROI_OFFSET_X")]
		int CAP_PROP_XI_AEAG_ROI_OFFSET_X { get; }

		// @property (readonly, class) int CAP_PROP_XI_AEAG_ROI_OFFSET_Y __attribute__((swift_name("CAP_PROP_XI_AEAG_ROI_OFFSET_Y")));
		[Static]
		[Export ("CAP_PROP_XI_AEAG_ROI_OFFSET_Y")]
		int CAP_PROP_XI_AEAG_ROI_OFFSET_Y { get; }

		// @property (readonly, class) int CAP_PROP_XI_AEAG_ROI_WIDTH __attribute__((swift_name("CAP_PROP_XI_AEAG_ROI_WIDTH")));
		[Static]
		[Export ("CAP_PROP_XI_AEAG_ROI_WIDTH")]
		int CAP_PROP_XI_AEAG_ROI_WIDTH { get; }

		// @property (readonly, class) int CAP_PROP_XI_AEAG_ROI_HEIGHT __attribute__((swift_name("CAP_PROP_XI_AEAG_ROI_HEIGHT")));
		[Static]
		[Export ("CAP_PROP_XI_AEAG_ROI_HEIGHT")]
		int CAP_PROP_XI_AEAG_ROI_HEIGHT { get; }

		// @property (readonly, class) int CAP_PROP_XI_BPC __attribute__((swift_name("CAP_PROP_XI_BPC")));
		[Static]
		[Export ("CAP_PROP_XI_BPC")]
		int CAP_PROP_XI_BPC { get; }

		// @property (readonly, class) int CAP_PROP_XI_WB_KR __attribute__((swift_name("CAP_PROP_XI_WB_KR")));
		[Static]
		[Export ("CAP_PROP_XI_WB_KR")]
		int CAP_PROP_XI_WB_KR { get; }

		// @property (readonly, class) int CAP_PROP_XI_WB_KG __attribute__((swift_name("CAP_PROP_XI_WB_KG")));
		[Static]
		[Export ("CAP_PROP_XI_WB_KG")]
		int CAP_PROP_XI_WB_KG { get; }

		// @property (readonly, class) int CAP_PROP_XI_WB_KB __attribute__((swift_name("CAP_PROP_XI_WB_KB")));
		[Static]
		[Export ("CAP_PROP_XI_WB_KB")]
		int CAP_PROP_XI_WB_KB { get; }

		// @property (readonly, class) int CAP_PROP_XI_WIDTH __attribute__((swift_name("CAP_PROP_XI_WIDTH")));
		[Static]
		[Export ("CAP_PROP_XI_WIDTH")]
		int CAP_PROP_XI_WIDTH { get; }

		// @property (readonly, class) int CAP_PROP_XI_HEIGHT __attribute__((swift_name("CAP_PROP_XI_HEIGHT")));
		[Static]
		[Export ("CAP_PROP_XI_HEIGHT")]
		int CAP_PROP_XI_HEIGHT { get; }

		// @property (readonly, class) int CAP_PROP_XI_REGION_SELECTOR __attribute__((swift_name("CAP_PROP_XI_REGION_SELECTOR")));
		[Static]
		[Export ("CAP_PROP_XI_REGION_SELECTOR")]
		int CAP_PROP_XI_REGION_SELECTOR { get; }

		// @property (readonly, class) int CAP_PROP_XI_REGION_MODE __attribute__((swift_name("CAP_PROP_XI_REGION_MODE")));
		[Static]
		[Export ("CAP_PROP_XI_REGION_MODE")]
		int CAP_PROP_XI_REGION_MODE { get; }

		// @property (readonly, class) int CAP_PROP_XI_LIMIT_BANDWIDTH __attribute__((swift_name("CAP_PROP_XI_LIMIT_BANDWIDTH")));
		[Static]
		[Export ("CAP_PROP_XI_LIMIT_BANDWIDTH")]
		int CAP_PROP_XI_LIMIT_BANDWIDTH { get; }

		// @property (readonly, class) int CAP_PROP_XI_SENSOR_DATA_BIT_DEPTH __attribute__((swift_name("CAP_PROP_XI_SENSOR_DATA_BIT_DEPTH")));
		[Static]
		[Export ("CAP_PROP_XI_SENSOR_DATA_BIT_DEPTH")]
		int CAP_PROP_XI_SENSOR_DATA_BIT_DEPTH { get; }

		// @property (readonly, class) int CAP_PROP_XI_OUTPUT_DATA_BIT_DEPTH __attribute__((swift_name("CAP_PROP_XI_OUTPUT_DATA_BIT_DEPTH")));
		[Static]
		[Export ("CAP_PROP_XI_OUTPUT_DATA_BIT_DEPTH")]
		int CAP_PROP_XI_OUTPUT_DATA_BIT_DEPTH { get; }

		// @property (readonly, class) int CAP_PROP_XI_IMAGE_DATA_BIT_DEPTH __attribute__((swift_name("CAP_PROP_XI_IMAGE_DATA_BIT_DEPTH")));
		[Static]
		[Export ("CAP_PROP_XI_IMAGE_DATA_BIT_DEPTH")]
		int CAP_PROP_XI_IMAGE_DATA_BIT_DEPTH { get; }

		// @property (readonly, class) int CAP_PROP_XI_OUTPUT_DATA_PACKING __attribute__((swift_name("CAP_PROP_XI_OUTPUT_DATA_PACKING")));
		[Static]
		[Export ("CAP_PROP_XI_OUTPUT_DATA_PACKING")]
		int CAP_PROP_XI_OUTPUT_DATA_PACKING { get; }

		// @property (readonly, class) int CAP_PROP_XI_OUTPUT_DATA_PACKING_TYPE __attribute__((swift_name("CAP_PROP_XI_OUTPUT_DATA_PACKING_TYPE")));
		[Static]
		[Export ("CAP_PROP_XI_OUTPUT_DATA_PACKING_TYPE")]
		int CAP_PROP_XI_OUTPUT_DATA_PACKING_TYPE { get; }

		// @property (readonly, class) int CAP_PROP_XI_IS_COOLED __attribute__((swift_name("CAP_PROP_XI_IS_COOLED")));
		[Static]
		[Export ("CAP_PROP_XI_IS_COOLED")]
		int CAP_PROP_XI_IS_COOLED { get; }

		// @property (readonly, class) int CAP_PROP_XI_COOLING __attribute__((swift_name("CAP_PROP_XI_COOLING")));
		[Static]
		[Export ("CAP_PROP_XI_COOLING")]
		int CAP_PROP_XI_COOLING { get; }

		// @property (readonly, class) int CAP_PROP_XI_TARGET_TEMP __attribute__((swift_name("CAP_PROP_XI_TARGET_TEMP")));
		[Static]
		[Export ("CAP_PROP_XI_TARGET_TEMP")]
		int CAP_PROP_XI_TARGET_TEMP { get; }

		// @property (readonly, class) int CAP_PROP_XI_CHIP_TEMP __attribute__((swift_name("CAP_PROP_XI_CHIP_TEMP")));
		[Static]
		[Export ("CAP_PROP_XI_CHIP_TEMP")]
		int CAP_PROP_XI_CHIP_TEMP { get; }

		// @property (readonly, class) int CAP_PROP_XI_HOUS_TEMP __attribute__((swift_name("CAP_PROP_XI_HOUS_TEMP")));
		[Static]
		[Export ("CAP_PROP_XI_HOUS_TEMP")]
		int CAP_PROP_XI_HOUS_TEMP { get; }

		// @property (readonly, class) int CAP_PROP_XI_HOUS_BACK_SIDE_TEMP __attribute__((swift_name("CAP_PROP_XI_HOUS_BACK_SIDE_TEMP")));
		[Static]
		[Export ("CAP_PROP_XI_HOUS_BACK_SIDE_TEMP")]
		int CAP_PROP_XI_HOUS_BACK_SIDE_TEMP { get; }

		// @property (readonly, class) int CAP_PROP_XI_SENSOR_BOARD_TEMP __attribute__((swift_name("CAP_PROP_XI_SENSOR_BOARD_TEMP")));
		[Static]
		[Export ("CAP_PROP_XI_SENSOR_BOARD_TEMP")]
		int CAP_PROP_XI_SENSOR_BOARD_TEMP { get; }

		// @property (readonly, class) int CAP_PROP_XI_CMS __attribute__((swift_name("CAP_PROP_XI_CMS")));
		[Static]
		[Export ("CAP_PROP_XI_CMS")]
		int CAP_PROP_XI_CMS { get; }

		// @property (readonly, class) int CAP_PROP_XI_APPLY_CMS __attribute__((swift_name("CAP_PROP_XI_APPLY_CMS")));
		[Static]
		[Export ("CAP_PROP_XI_APPLY_CMS")]
		int CAP_PROP_XI_APPLY_CMS { get; }

		// @property (readonly, class) int CAP_PROP_XI_IMAGE_IS_COLOR __attribute__((swift_name("CAP_PROP_XI_IMAGE_IS_COLOR")));
		[Static]
		[Export ("CAP_PROP_XI_IMAGE_IS_COLOR")]
		int CAP_PROP_XI_IMAGE_IS_COLOR { get; }

		// @property (readonly, class) int CAP_PROP_XI_COLOR_FILTER_ARRAY __attribute__((swift_name("CAP_PROP_XI_COLOR_FILTER_ARRAY")));
		[Static]
		[Export ("CAP_PROP_XI_COLOR_FILTER_ARRAY")]
		int CAP_PROP_XI_COLOR_FILTER_ARRAY { get; }

		// @property (readonly, class) int CAP_PROP_XI_GAMMAY __attribute__((swift_name("CAP_PROP_XI_GAMMAY")));
		[Static]
		[Export ("CAP_PROP_XI_GAMMAY")]
		int CAP_PROP_XI_GAMMAY { get; }

		// @property (readonly, class) int CAP_PROP_XI_GAMMAC __attribute__((swift_name("CAP_PROP_XI_GAMMAC")));
		[Static]
		[Export ("CAP_PROP_XI_GAMMAC")]
		int CAP_PROP_XI_GAMMAC { get; }

		// @property (readonly, class) int CAP_PROP_XI_SHARPNESS __attribute__((swift_name("CAP_PROP_XI_SHARPNESS")));
		[Static]
		[Export ("CAP_PROP_XI_SHARPNESS")]
		int CAP_PROP_XI_SHARPNESS { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_00 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_00")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_00")]
		int CAP_PROP_XI_CC_MATRIX_00 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_01 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_01")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_01")]
		int CAP_PROP_XI_CC_MATRIX_01 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_02 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_02")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_02")]
		int CAP_PROP_XI_CC_MATRIX_02 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_03 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_03")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_03")]
		int CAP_PROP_XI_CC_MATRIX_03 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_10 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_10")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_10")]
		int CAP_PROP_XI_CC_MATRIX_10 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_11 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_11")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_11")]
		int CAP_PROP_XI_CC_MATRIX_11 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_12 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_12")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_12")]
		int CAP_PROP_XI_CC_MATRIX_12 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_13 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_13")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_13")]
		int CAP_PROP_XI_CC_MATRIX_13 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_20 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_20")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_20")]
		int CAP_PROP_XI_CC_MATRIX_20 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_21 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_21")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_21")]
		int CAP_PROP_XI_CC_MATRIX_21 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_22 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_22")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_22")]
		int CAP_PROP_XI_CC_MATRIX_22 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_23 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_23")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_23")]
		int CAP_PROP_XI_CC_MATRIX_23 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_30 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_30")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_30")]
		int CAP_PROP_XI_CC_MATRIX_30 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_31 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_31")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_31")]
		int CAP_PROP_XI_CC_MATRIX_31 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_32 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_32")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_32")]
		int CAP_PROP_XI_CC_MATRIX_32 { get; }

		// @property (readonly, class) int CAP_PROP_XI_CC_MATRIX_33 __attribute__((swift_name("CAP_PROP_XI_CC_MATRIX_33")));
		[Static]
		[Export ("CAP_PROP_XI_CC_MATRIX_33")]
		int CAP_PROP_XI_CC_MATRIX_33 { get; }

		// @property (readonly, class) int CAP_PROP_XI_DEFAULT_CC_MATRIX __attribute__((swift_name("CAP_PROP_XI_DEFAULT_CC_MATRIX")));
		[Static]
		[Export ("CAP_PROP_XI_DEFAULT_CC_MATRIX")]
		int CAP_PROP_XI_DEFAULT_CC_MATRIX { get; }

		// @property (readonly, class) int CAP_PROP_XI_TRG_SELECTOR __attribute__((swift_name("CAP_PROP_XI_TRG_SELECTOR")));
		[Static]
		[Export ("CAP_PROP_XI_TRG_SELECTOR")]
		int CAP_PROP_XI_TRG_SELECTOR { get; }

		// @property (readonly, class) int CAP_PROP_XI_ACQ_FRAME_BURST_COUNT __attribute__((swift_name("CAP_PROP_XI_ACQ_FRAME_BURST_COUNT")));
		[Static]
		[Export ("CAP_PROP_XI_ACQ_FRAME_BURST_COUNT")]
		int CAP_PROP_XI_ACQ_FRAME_BURST_COUNT { get; }

		// @property (readonly, class) int CAP_PROP_XI_DEBOUNCE_EN __attribute__((swift_name("CAP_PROP_XI_DEBOUNCE_EN")));
		[Static]
		[Export ("CAP_PROP_XI_DEBOUNCE_EN")]
		int CAP_PROP_XI_DEBOUNCE_EN { get; }

		// @property (readonly, class) int CAP_PROP_XI_DEBOUNCE_T0 __attribute__((swift_name("CAP_PROP_XI_DEBOUNCE_T0")));
		[Static]
		[Export ("CAP_PROP_XI_DEBOUNCE_T0")]
		int CAP_PROP_XI_DEBOUNCE_T0 { get; }

		// @property (readonly, class) int CAP_PROP_XI_DEBOUNCE_T1 __attribute__((swift_name("CAP_PROP_XI_DEBOUNCE_T1")));
		[Static]
		[Export ("CAP_PROP_XI_DEBOUNCE_T1")]
		int CAP_PROP_XI_DEBOUNCE_T1 { get; }

		// @property (readonly, class) int CAP_PROP_XI_DEBOUNCE_POL __attribute__((swift_name("CAP_PROP_XI_DEBOUNCE_POL")));
		[Static]
		[Export ("CAP_PROP_XI_DEBOUNCE_POL")]
		int CAP_PROP_XI_DEBOUNCE_POL { get; }

		// @property (readonly, class) int CAP_PROP_XI_LENS_MODE __attribute__((swift_name("CAP_PROP_XI_LENS_MODE")));
		[Static]
		[Export ("CAP_PROP_XI_LENS_MODE")]
		int CAP_PROP_XI_LENS_MODE { get; }

		// @property (readonly, class) int CAP_PROP_XI_LENS_APERTURE_VALUE __attribute__((swift_name("CAP_PROP_XI_LENS_APERTURE_VALUE")));
		[Static]
		[Export ("CAP_PROP_XI_LENS_APERTURE_VALUE")]
		int CAP_PROP_XI_LENS_APERTURE_VALUE { get; }

		// @property (readonly, class) int CAP_PROP_XI_LENS_FOCUS_MOVEMENT_VALUE __attribute__((swift_name("CAP_PROP_XI_LENS_FOCUS_MOVEMENT_VALUE")));
		[Static]
		[Export ("CAP_PROP_XI_LENS_FOCUS_MOVEMENT_VALUE")]
		int CAP_PROP_XI_LENS_FOCUS_MOVEMENT_VALUE { get; }

		// @property (readonly, class) int CAP_PROP_XI_LENS_FOCUS_MOVE __attribute__((swift_name("CAP_PROP_XI_LENS_FOCUS_MOVE")));
		[Static]
		[Export ("CAP_PROP_XI_LENS_FOCUS_MOVE")]
		int CAP_PROP_XI_LENS_FOCUS_MOVE { get; }

		// @property (readonly, class) int CAP_PROP_XI_LENS_FOCUS_DISTANCE __attribute__((swift_name("CAP_PROP_XI_LENS_FOCUS_DISTANCE")));
		[Static]
		[Export ("CAP_PROP_XI_LENS_FOCUS_DISTANCE")]
		int CAP_PROP_XI_LENS_FOCUS_DISTANCE { get; }

		// @property (readonly, class) int CAP_PROP_XI_LENS_FOCAL_LENGTH __attribute__((swift_name("CAP_PROP_XI_LENS_FOCAL_LENGTH")));
		[Static]
		[Export ("CAP_PROP_XI_LENS_FOCAL_LENGTH")]
		int CAP_PROP_XI_LENS_FOCAL_LENGTH { get; }

		// @property (readonly, class) int CAP_PROP_XI_LENS_FEATURE_SELECTOR __attribute__((swift_name("CAP_PROP_XI_LENS_FEATURE_SELECTOR")));
		[Static]
		[Export ("CAP_PROP_XI_LENS_FEATURE_SELECTOR")]
		int CAP_PROP_XI_LENS_FEATURE_SELECTOR { get; }

		// @property (readonly, class) int CAP_PROP_XI_LENS_FEATURE __attribute__((swift_name("CAP_PROP_XI_LENS_FEATURE")));
		[Static]
		[Export ("CAP_PROP_XI_LENS_FEATURE")]
		int CAP_PROP_XI_LENS_FEATURE { get; }

		// @property (readonly, class) int CAP_PROP_XI_DEVICE_MODEL_ID __attribute__((swift_name("CAP_PROP_XI_DEVICE_MODEL_ID")));
		[Static]
		[Export ("CAP_PROP_XI_DEVICE_MODEL_ID")]
		int CAP_PROP_XI_DEVICE_MODEL_ID { get; }

		// @property (readonly, class) int CAP_PROP_XI_DEVICE_SN __attribute__((swift_name("CAP_PROP_XI_DEVICE_SN")));
		[Static]
		[Export ("CAP_PROP_XI_DEVICE_SN")]
		int CAP_PROP_XI_DEVICE_SN { get; }

		// @property (readonly, class) int CAP_PROP_XI_IMAGE_DATA_FORMAT_RGB32_ALPHA __attribute__((swift_name("CAP_PROP_XI_IMAGE_DATA_FORMAT_RGB32_ALPHA")));
		[Static]
		[Export ("CAP_PROP_XI_IMAGE_DATA_FORMAT_RGB32_ALPHA")]
		int CAP_PROP_XI_IMAGE_DATA_FORMAT_RGB32_ALPHA { get; }

		// @property (readonly, class) int CAP_PROP_XI_IMAGE_PAYLOAD_SIZE __attribute__((swift_name("CAP_PROP_XI_IMAGE_PAYLOAD_SIZE")));
		[Static]
		[Export ("CAP_PROP_XI_IMAGE_PAYLOAD_SIZE")]
		int CAP_PROP_XI_IMAGE_PAYLOAD_SIZE { get; }

		// @property (readonly, class) int CAP_PROP_XI_TRANSPORT_PIXEL_FORMAT __attribute__((swift_name("CAP_PROP_XI_TRANSPORT_PIXEL_FORMAT")));
		[Static]
		[Export ("CAP_PROP_XI_TRANSPORT_PIXEL_FORMAT")]
		int CAP_PROP_XI_TRANSPORT_PIXEL_FORMAT { get; }

		// @property (readonly, class) int CAP_PROP_XI_SENSOR_CLOCK_FREQ_HZ __attribute__((swift_name("CAP_PROP_XI_SENSOR_CLOCK_FREQ_HZ")));
		[Static]
		[Export ("CAP_PROP_XI_SENSOR_CLOCK_FREQ_HZ")]
		int CAP_PROP_XI_SENSOR_CLOCK_FREQ_HZ { get; }

		// @property (readonly, class) int CAP_PROP_XI_SENSOR_CLOCK_FREQ_INDEX __attribute__((swift_name("CAP_PROP_XI_SENSOR_CLOCK_FREQ_INDEX")));
		[Static]
		[Export ("CAP_PROP_XI_SENSOR_CLOCK_FREQ_INDEX")]
		int CAP_PROP_XI_SENSOR_CLOCK_FREQ_INDEX { get; }

		// @property (readonly, class) int CAP_PROP_XI_SENSOR_OUTPUT_CHANNEL_COUNT __attribute__((swift_name("CAP_PROP_XI_SENSOR_OUTPUT_CHANNEL_COUNT")));
		[Static]
		[Export ("CAP_PROP_XI_SENSOR_OUTPUT_CHANNEL_COUNT")]
		int CAP_PROP_XI_SENSOR_OUTPUT_CHANNEL_COUNT { get; }

		// @property (readonly, class) int CAP_PROP_XI_FRAMERATE __attribute__((swift_name("CAP_PROP_XI_FRAMERATE")));
		[Static]
		[Export ("CAP_PROP_XI_FRAMERATE")]
		int CAP_PROP_XI_FRAMERATE { get; }

		// @property (readonly, class) int CAP_PROP_XI_COUNTER_SELECTOR __attribute__((swift_name("CAP_PROP_XI_COUNTER_SELECTOR")));
		[Static]
		[Export ("CAP_PROP_XI_COUNTER_SELECTOR")]
		int CAP_PROP_XI_COUNTER_SELECTOR { get; }

		// @property (readonly, class) int CAP_PROP_XI_COUNTER_VALUE __attribute__((swift_name("CAP_PROP_XI_COUNTER_VALUE")));
		[Static]
		[Export ("CAP_PROP_XI_COUNTER_VALUE")]
		int CAP_PROP_XI_COUNTER_VALUE { get; }

		// @property (readonly, class) int CAP_PROP_XI_ACQ_TIMING_MODE __attribute__((swift_name("CAP_PROP_XI_ACQ_TIMING_MODE")));
		[Static]
		[Export ("CAP_PROP_XI_ACQ_TIMING_MODE")]
		int CAP_PROP_XI_ACQ_TIMING_MODE { get; }

		// @property (readonly, class) int CAP_PROP_XI_AVAILABLE_BANDWIDTH __attribute__((swift_name("CAP_PROP_XI_AVAILABLE_BANDWIDTH")));
		[Static]
		[Export ("CAP_PROP_XI_AVAILABLE_BANDWIDTH")]
		int CAP_PROP_XI_AVAILABLE_BANDWIDTH { get; }

		// @property (readonly, class) int CAP_PROP_XI_BUFFER_POLICY __attribute__((swift_name("CAP_PROP_XI_BUFFER_POLICY")));
		[Static]
		[Export ("CAP_PROP_XI_BUFFER_POLICY")]
		int CAP_PROP_XI_BUFFER_POLICY { get; }

		// @property (readonly, class) int CAP_PROP_XI_LUT_EN __attribute__((swift_name("CAP_PROP_XI_LUT_EN")));
		[Static]
		[Export ("CAP_PROP_XI_LUT_EN")]
		int CAP_PROP_XI_LUT_EN { get; }

		// @property (readonly, class) int CAP_PROP_XI_LUT_INDEX __attribute__((swift_name("CAP_PROP_XI_LUT_INDEX")));
		[Static]
		[Export ("CAP_PROP_XI_LUT_INDEX")]
		int CAP_PROP_XI_LUT_INDEX { get; }

		// @property (readonly, class) int CAP_PROP_XI_LUT_VALUE __attribute__((swift_name("CAP_PROP_XI_LUT_VALUE")));
		[Static]
		[Export ("CAP_PROP_XI_LUT_VALUE")]
		int CAP_PROP_XI_LUT_VALUE { get; }

		// @property (readonly, class) int CAP_PROP_XI_TRG_DELAY __attribute__((swift_name("CAP_PROP_XI_TRG_DELAY")));
		[Static]
		[Export ("CAP_PROP_XI_TRG_DELAY")]
		int CAP_PROP_XI_TRG_DELAY { get; }

		// @property (readonly, class) int CAP_PROP_XI_TS_RST_MODE __attribute__((swift_name("CAP_PROP_XI_TS_RST_MODE")));
		[Static]
		[Export ("CAP_PROP_XI_TS_RST_MODE")]
		int CAP_PROP_XI_TS_RST_MODE { get; }

		// @property (readonly, class) int CAP_PROP_XI_TS_RST_SOURCE __attribute__((swift_name("CAP_PROP_XI_TS_RST_SOURCE")));
		[Static]
		[Export ("CAP_PROP_XI_TS_RST_SOURCE")]
		int CAP_PROP_XI_TS_RST_SOURCE { get; }

		// @property (readonly, class) int CAP_PROP_XI_IS_DEVICE_EXIST __attribute__((swift_name("CAP_PROP_XI_IS_DEVICE_EXIST")));
		[Static]
		[Export ("CAP_PROP_XI_IS_DEVICE_EXIST")]
		int CAP_PROP_XI_IS_DEVICE_EXIST { get; }

		// @property (readonly, class) int CAP_PROP_XI_ACQ_BUFFER_SIZE __attribute__((swift_name("CAP_PROP_XI_ACQ_BUFFER_SIZE")));
		[Static]
		[Export ("CAP_PROP_XI_ACQ_BUFFER_SIZE")]
		int CAP_PROP_XI_ACQ_BUFFER_SIZE { get; }

		// @property (readonly, class) int CAP_PROP_XI_ACQ_BUFFER_SIZE_UNIT __attribute__((swift_name("CAP_PROP_XI_ACQ_BUFFER_SIZE_UNIT")));
		[Static]
		[Export ("CAP_PROP_XI_ACQ_BUFFER_SIZE_UNIT")]
		int CAP_PROP_XI_ACQ_BUFFER_SIZE_UNIT { get; }

		// @property (readonly, class) int CAP_PROP_XI_ACQ_TRANSPORT_BUFFER_SIZE __attribute__((swift_name("CAP_PROP_XI_ACQ_TRANSPORT_BUFFER_SIZE")));
		[Static]
		[Export ("CAP_PROP_XI_ACQ_TRANSPORT_BUFFER_SIZE")]
		int CAP_PROP_XI_ACQ_TRANSPORT_BUFFER_SIZE { get; }

		// @property (readonly, class) int CAP_PROP_XI_BUFFERS_QUEUE_SIZE __attribute__((swift_name("CAP_PROP_XI_BUFFERS_QUEUE_SIZE")));
		[Static]
		[Export ("CAP_PROP_XI_BUFFERS_QUEUE_SIZE")]
		int CAP_PROP_XI_BUFFERS_QUEUE_SIZE { get; }

		// @property (readonly, class) int CAP_PROP_XI_ACQ_TRANSPORT_BUFFER_COMMIT __attribute__((swift_name("CAP_PROP_XI_ACQ_TRANSPORT_BUFFER_COMMIT")));
		[Static]
		[Export ("CAP_PROP_XI_ACQ_TRANSPORT_BUFFER_COMMIT")]
		int CAP_PROP_XI_ACQ_TRANSPORT_BUFFER_COMMIT { get; }

		// @property (readonly, class) int CAP_PROP_XI_RECENT_FRAME __attribute__((swift_name("CAP_PROP_XI_RECENT_FRAME")));
		[Static]
		[Export ("CAP_PROP_XI_RECENT_FRAME")]
		int CAP_PROP_XI_RECENT_FRAME { get; }

		// @property (readonly, class) int CAP_PROP_XI_DEVICE_RESET __attribute__((swift_name("CAP_PROP_XI_DEVICE_RESET")));
		[Static]
		[Export ("CAP_PROP_XI_DEVICE_RESET")]
		int CAP_PROP_XI_DEVICE_RESET { get; }

		// @property (readonly, class) int CAP_PROP_XI_COLUMN_FPN_CORRECTION __attribute__((swift_name("CAP_PROP_XI_COLUMN_FPN_CORRECTION")));
		[Static]
		[Export ("CAP_PROP_XI_COLUMN_FPN_CORRECTION")]
		int CAP_PROP_XI_COLUMN_FPN_CORRECTION { get; }

		// @property (readonly, class) int CAP_PROP_XI_ROW_FPN_CORRECTION __attribute__((swift_name("CAP_PROP_XI_ROW_FPN_CORRECTION")));
		[Static]
		[Export ("CAP_PROP_XI_ROW_FPN_CORRECTION")]
		int CAP_PROP_XI_ROW_FPN_CORRECTION { get; }

		// @property (readonly, class) int CAP_PROP_XI_SENSOR_MODE __attribute__((swift_name("CAP_PROP_XI_SENSOR_MODE")));
		[Static]
		[Export ("CAP_PROP_XI_SENSOR_MODE")]
		int CAP_PROP_XI_SENSOR_MODE { get; }

		// @property (readonly, class) int CAP_PROP_XI_HDR __attribute__((swift_name("CAP_PROP_XI_HDR")));
		[Static]
		[Export ("CAP_PROP_XI_HDR")]
		int CAP_PROP_XI_HDR { get; }

		// @property (readonly, class) int CAP_PROP_XI_HDR_KNEEPOINT_COUNT __attribute__((swift_name("CAP_PROP_XI_HDR_KNEEPOINT_COUNT")));
		[Static]
		[Export ("CAP_PROP_XI_HDR_KNEEPOINT_COUNT")]
		int CAP_PROP_XI_HDR_KNEEPOINT_COUNT { get; }

		// @property (readonly, class) int CAP_PROP_XI_HDR_T1 __attribute__((swift_name("CAP_PROP_XI_HDR_T1")));
		[Static]
		[Export ("CAP_PROP_XI_HDR_T1")]
		int CAP_PROP_XI_HDR_T1 { get; }

		// @property (readonly, class) int CAP_PROP_XI_HDR_T2 __attribute__((swift_name("CAP_PROP_XI_HDR_T2")));
		[Static]
		[Export ("CAP_PROP_XI_HDR_T2")]
		int CAP_PROP_XI_HDR_T2 { get; }

		// @property (readonly, class) int CAP_PROP_XI_KNEEPOINT1 __attribute__((swift_name("CAP_PROP_XI_KNEEPOINT1")));
		[Static]
		[Export ("CAP_PROP_XI_KNEEPOINT1")]
		int CAP_PROP_XI_KNEEPOINT1 { get; }

		// @property (readonly, class) int CAP_PROP_XI_KNEEPOINT2 __attribute__((swift_name("CAP_PROP_XI_KNEEPOINT2")));
		[Static]
		[Export ("CAP_PROP_XI_KNEEPOINT2")]
		int CAP_PROP_XI_KNEEPOINT2 { get; }

		// @property (readonly, class) int CAP_PROP_XI_IMAGE_BLACK_LEVEL __attribute__((swift_name("CAP_PROP_XI_IMAGE_BLACK_LEVEL")));
		[Static]
		[Export ("CAP_PROP_XI_IMAGE_BLACK_LEVEL")]
		int CAP_PROP_XI_IMAGE_BLACK_LEVEL { get; }

		// @property (readonly, class) int CAP_PROP_XI_HW_REVISION __attribute__((swift_name("CAP_PROP_XI_HW_REVISION")));
		[Static]
		[Export ("CAP_PROP_XI_HW_REVISION")]
		int CAP_PROP_XI_HW_REVISION { get; }

		// @property (readonly, class) int CAP_PROP_XI_DEBUG_LEVEL __attribute__((swift_name("CAP_PROP_XI_DEBUG_LEVEL")));
		[Static]
		[Export ("CAP_PROP_XI_DEBUG_LEVEL")]
		int CAP_PROP_XI_DEBUG_LEVEL { get; }

		// @property (readonly, class) int CAP_PROP_XI_AUTO_BANDWIDTH_CALCULATION __attribute__((swift_name("CAP_PROP_XI_AUTO_BANDWIDTH_CALCULATION")));
		[Static]
		[Export ("CAP_PROP_XI_AUTO_BANDWIDTH_CALCULATION")]
		int CAP_PROP_XI_AUTO_BANDWIDTH_CALCULATION { get; }

		// @property (readonly, class) int CAP_PROP_XI_FFS_FILE_ID __attribute__((swift_name("CAP_PROP_XI_FFS_FILE_ID")));
		[Static]
		[Export ("CAP_PROP_XI_FFS_FILE_ID")]
		int CAP_PROP_XI_FFS_FILE_ID { get; }

		// @property (readonly, class) int CAP_PROP_XI_FFS_FILE_SIZE __attribute__((swift_name("CAP_PROP_XI_FFS_FILE_SIZE")));
		[Static]
		[Export ("CAP_PROP_XI_FFS_FILE_SIZE")]
		int CAP_PROP_XI_FFS_FILE_SIZE { get; }

		// @property (readonly, class) int CAP_PROP_XI_FREE_FFS_SIZE __attribute__((swift_name("CAP_PROP_XI_FREE_FFS_SIZE")));
		[Static]
		[Export ("CAP_PROP_XI_FREE_FFS_SIZE")]
		int CAP_PROP_XI_FREE_FFS_SIZE { get; }

		// @property (readonly, class) int CAP_PROP_XI_USED_FFS_SIZE __attribute__((swift_name("CAP_PROP_XI_USED_FFS_SIZE")));
		[Static]
		[Export ("CAP_PROP_XI_USED_FFS_SIZE")]
		int CAP_PROP_XI_USED_FFS_SIZE { get; }

		// @property (readonly, class) int CAP_PROP_XI_FFS_ACCESS_KEY __attribute__((swift_name("CAP_PROP_XI_FFS_ACCESS_KEY")));
		[Static]
		[Export ("CAP_PROP_XI_FFS_ACCESS_KEY")]
		int CAP_PROP_XI_FFS_ACCESS_KEY { get; }

		// @property (readonly, class) int CAP_PROP_XI_SENSOR_FEATURE_SELECTOR __attribute__((swift_name("CAP_PROP_XI_SENSOR_FEATURE_SELECTOR")));
		[Static]
		[Export ("CAP_PROP_XI_SENSOR_FEATURE_SELECTOR")]
		int CAP_PROP_XI_SENSOR_FEATURE_SELECTOR { get; }

		// @property (readonly, class) int CAP_PROP_XI_SENSOR_FEATURE_VALUE __attribute__((swift_name("CAP_PROP_XI_SENSOR_FEATURE_VALUE")));
		[Static]
		[Export ("CAP_PROP_XI_SENSOR_FEATURE_VALUE")]
		int CAP_PROP_XI_SENSOR_FEATURE_VALUE { get; }

		// @property (readonly, class) int CAP_PROP_ARAVIS_AUTOTRIGGER __attribute__((swift_name("CAP_PROP_ARAVIS_AUTOTRIGGER")));
		[Static]
		[Export ("CAP_PROP_ARAVIS_AUTOTRIGGER")]
		int CAP_PROP_ARAVIS_AUTOTRIGGER { get; }

		// @property (readonly, class) int CAP_PROP_ANDROID_DEVICE_TORCH __attribute__((swift_name("CAP_PROP_ANDROID_DEVICE_TORCH")));
		[Static]
		[Export ("CAP_PROP_ANDROID_DEVICE_TORCH")]
		int CAP_PROP_ANDROID_DEVICE_TORCH { get; }

		// @property (readonly, class) int CAP_PROP_IOS_DEVICE_FOCUS __attribute__((swift_name("CAP_PROP_IOS_DEVICE_FOCUS")));
		[Static]
		[Export ("CAP_PROP_IOS_DEVICE_FOCUS")]
		int CAP_PROP_IOS_DEVICE_FOCUS { get; }

		// @property (readonly, class) int CAP_PROP_IOS_DEVICE_EXPOSURE __attribute__((swift_name("CAP_PROP_IOS_DEVICE_EXPOSURE")));
		[Static]
		[Export ("CAP_PROP_IOS_DEVICE_EXPOSURE")]
		int CAP_PROP_IOS_DEVICE_EXPOSURE { get; }

		// @property (readonly, class) int CAP_PROP_IOS_DEVICE_FLASH __attribute__((swift_name("CAP_PROP_IOS_DEVICE_FLASH")));
		[Static]
		[Export ("CAP_PROP_IOS_DEVICE_FLASH")]
		int CAP_PROP_IOS_DEVICE_FLASH { get; }

		// @property (readonly, class) int CAP_PROP_IOS_DEVICE_WHITEBALANCE __attribute__((swift_name("CAP_PROP_IOS_DEVICE_WHITEBALANCE")));
		[Static]
		[Export ("CAP_PROP_IOS_DEVICE_WHITEBALANCE")]
		int CAP_PROP_IOS_DEVICE_WHITEBALANCE { get; }

		// @property (readonly, class) int CAP_PROP_IOS_DEVICE_TORCH __attribute__((swift_name("CAP_PROP_IOS_DEVICE_TORCH")));
		[Static]
		[Export ("CAP_PROP_IOS_DEVICE_TORCH")]
		int CAP_PROP_IOS_DEVICE_TORCH { get; }

		// @property (readonly, class) int CAP_PROP_GIGA_FRAME_OFFSET_X __attribute__((swift_name("CAP_PROP_GIGA_FRAME_OFFSET_X")));
		[Static]
		[Export ("CAP_PROP_GIGA_FRAME_OFFSET_X")]
		int CAP_PROP_GIGA_FRAME_OFFSET_X { get; }

		// @property (readonly, class) int CAP_PROP_GIGA_FRAME_OFFSET_Y __attribute__((swift_name("CAP_PROP_GIGA_FRAME_OFFSET_Y")));
		[Static]
		[Export ("CAP_PROP_GIGA_FRAME_OFFSET_Y")]
		int CAP_PROP_GIGA_FRAME_OFFSET_Y { get; }

		// @property (readonly, class) int CAP_PROP_GIGA_FRAME_WIDTH_MAX __attribute__((swift_name("CAP_PROP_GIGA_FRAME_WIDTH_MAX")));
		[Static]
		[Export ("CAP_PROP_GIGA_FRAME_WIDTH_MAX")]
		int CAP_PROP_GIGA_FRAME_WIDTH_MAX { get; }

		// @property (readonly, class) int CAP_PROP_GIGA_FRAME_HEIGH_MAX __attribute__((swift_name("CAP_PROP_GIGA_FRAME_HEIGH_MAX")));
		[Static]
		[Export ("CAP_PROP_GIGA_FRAME_HEIGH_MAX")]
		int CAP_PROP_GIGA_FRAME_HEIGH_MAX { get; }

		// @property (readonly, class) int CAP_PROP_GIGA_FRAME_SENS_WIDTH __attribute__((swift_name("CAP_PROP_GIGA_FRAME_SENS_WIDTH")));
		[Static]
		[Export ("CAP_PROP_GIGA_FRAME_SENS_WIDTH")]
		int CAP_PROP_GIGA_FRAME_SENS_WIDTH { get; }

		// @property (readonly, class) int CAP_PROP_GIGA_FRAME_SENS_HEIGH __attribute__((swift_name("CAP_PROP_GIGA_FRAME_SENS_HEIGH")));
		[Static]
		[Export ("CAP_PROP_GIGA_FRAME_SENS_HEIGH")]
		int CAP_PROP_GIGA_FRAME_SENS_HEIGH { get; }

		// @property (readonly, class) int CAP_PROP_INTELPERC_PROFILE_COUNT __attribute__((swift_name("CAP_PROP_INTELPERC_PROFILE_COUNT")));
		[Static]
		[Export ("CAP_PROP_INTELPERC_PROFILE_COUNT")]
		int CAP_PROP_INTELPERC_PROFILE_COUNT { get; }

		// @property (readonly, class) int CAP_PROP_INTELPERC_PROFILE_IDX __attribute__((swift_name("CAP_PROP_INTELPERC_PROFILE_IDX")));
		[Static]
		[Export ("CAP_PROP_INTELPERC_PROFILE_IDX")]
		int CAP_PROP_INTELPERC_PROFILE_IDX { get; }

		// @property (readonly, class) int CAP_PROP_INTELPERC_DEPTH_LOW_CONFIDENCE_VALUE __attribute__((swift_name("CAP_PROP_INTELPERC_DEPTH_LOW_CONFIDENCE_VALUE")));
		[Static]
		[Export ("CAP_PROP_INTELPERC_DEPTH_LOW_CONFIDENCE_VALUE")]
		int CAP_PROP_INTELPERC_DEPTH_LOW_CONFIDENCE_VALUE { get; }

		// @property (readonly, class) int CAP_PROP_INTELPERC_DEPTH_SATURATION_VALUE __attribute__((swift_name("CAP_PROP_INTELPERC_DEPTH_SATURATION_VALUE")));
		[Static]
		[Export ("CAP_PROP_INTELPERC_DEPTH_SATURATION_VALUE")]
		int CAP_PROP_INTELPERC_DEPTH_SATURATION_VALUE { get; }

		// @property (readonly, class) int CAP_PROP_INTELPERC_DEPTH_CONFIDENCE_THRESHOLD __attribute__((swift_name("CAP_PROP_INTELPERC_DEPTH_CONFIDENCE_THRESHOLD")));
		[Static]
		[Export ("CAP_PROP_INTELPERC_DEPTH_CONFIDENCE_THRESHOLD")]
		int CAP_PROP_INTELPERC_DEPTH_CONFIDENCE_THRESHOLD { get; }

		// @property (readonly, class) int CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_HORZ __attribute__((swift_name("CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_HORZ")));
		[Static]
		[Export ("CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_HORZ")]
		int CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_HORZ { get; }

		// @property (readonly, class) int CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_VERT __attribute__((swift_name("CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_VERT")));
		[Static]
		[Export ("CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_VERT")]
		int CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_VERT { get; }

		// @property (readonly, class) int CAP_INTELPERC_DEPTH_GENERATOR __attribute__((swift_name("CAP_INTELPERC_DEPTH_GENERATOR")));
		[Static]
		[Export ("CAP_INTELPERC_DEPTH_GENERATOR")]
		int CAP_INTELPERC_DEPTH_GENERATOR { get; }

		// @property (readonly, class) int CAP_INTELPERC_IMAGE_GENERATOR __attribute__((swift_name("CAP_INTELPERC_IMAGE_GENERATOR")));
		[Static]
		[Export ("CAP_INTELPERC_IMAGE_GENERATOR")]
		int CAP_INTELPERC_IMAGE_GENERATOR { get; }

		// @property (readonly, class) int CAP_INTELPERC_IR_GENERATOR __attribute__((swift_name("CAP_INTELPERC_IR_GENERATOR")));
		[Static]
		[Export ("CAP_INTELPERC_IR_GENERATOR")]
		int CAP_INTELPERC_IR_GENERATOR { get; }

		// @property (readonly, class) int CAP_INTELPERC_GENERATORS_MASK __attribute__((swift_name("CAP_INTELPERC_GENERATORS_MASK")));
		[Static]
		[Export ("CAP_INTELPERC_GENERATORS_MASK")]
		int CAP_INTELPERC_GENERATORS_MASK { get; }

		// @property (readonly, class) int CAP_INTELPERC_DEPTH_MAP __attribute__((swift_name("CAP_INTELPERC_DEPTH_MAP")));
		[Static]
		[Export ("CAP_INTELPERC_DEPTH_MAP")]
		int CAP_INTELPERC_DEPTH_MAP { get; }

		// @property (readonly, class) int CAP_INTELPERC_UVDEPTH_MAP __attribute__((swift_name("CAP_INTELPERC_UVDEPTH_MAP")));
		[Static]
		[Export ("CAP_INTELPERC_UVDEPTH_MAP")]
		int CAP_INTELPERC_UVDEPTH_MAP { get; }

		// @property (readonly, class) int CAP_INTELPERC_IR_MAP __attribute__((swift_name("CAP_INTELPERC_IR_MAP")));
		[Static]
		[Export ("CAP_INTELPERC_IR_MAP")]
		int CAP_INTELPERC_IR_MAP { get; }

		// @property (readonly, class) int CAP_INTELPERC_IMAGE __attribute__((swift_name("CAP_INTELPERC_IMAGE")));
		[Static]
		[Export ("CAP_INTELPERC_IMAGE")]
		int CAP_INTELPERC_IMAGE { get; }

		// @property (readonly, class) int CAP_PROP_GPHOTO2_PREVIEW __attribute__((swift_name("CAP_PROP_GPHOTO2_PREVIEW")));
		[Static]
		[Export ("CAP_PROP_GPHOTO2_PREVIEW")]
		int CAP_PROP_GPHOTO2_PREVIEW { get; }

		// @property (readonly, class) int CAP_PROP_GPHOTO2_WIDGET_ENUMERATE __attribute__((swift_name("CAP_PROP_GPHOTO2_WIDGET_ENUMERATE")));
		[Static]
		[Export ("CAP_PROP_GPHOTO2_WIDGET_ENUMERATE")]
		int CAP_PROP_GPHOTO2_WIDGET_ENUMERATE { get; }

		// @property (readonly, class) int CAP_PROP_GPHOTO2_RELOAD_CONFIG __attribute__((swift_name("CAP_PROP_GPHOTO2_RELOAD_CONFIG")));
		[Static]
		[Export ("CAP_PROP_GPHOTO2_RELOAD_CONFIG")]
		int CAP_PROP_GPHOTO2_RELOAD_CONFIG { get; }

		// @property (readonly, class) int CAP_PROP_GPHOTO2_RELOAD_ON_CHANGE __attribute__((swift_name("CAP_PROP_GPHOTO2_RELOAD_ON_CHANGE")));
		[Static]
		[Export ("CAP_PROP_GPHOTO2_RELOAD_ON_CHANGE")]
		int CAP_PROP_GPHOTO2_RELOAD_ON_CHANGE { get; }

		// @property (readonly, class) int CAP_PROP_GPHOTO2_COLLECT_MSGS __attribute__((swift_name("CAP_PROP_GPHOTO2_COLLECT_MSGS")));
		[Static]
		[Export ("CAP_PROP_GPHOTO2_COLLECT_MSGS")]
		int CAP_PROP_GPHOTO2_COLLECT_MSGS { get; }

		// @property (readonly, class) int CAP_PROP_GPHOTO2_FLUSH_MSGS __attribute__((swift_name("CAP_PROP_GPHOTO2_FLUSH_MSGS")));
		[Static]
		[Export ("CAP_PROP_GPHOTO2_FLUSH_MSGS")]
		int CAP_PROP_GPHOTO2_FLUSH_MSGS { get; }

		// @property (readonly, class) int CAP_PROP_SPEED __attribute__((swift_name("CAP_PROP_SPEED")));
		[Static]
		[Export ("CAP_PROP_SPEED")]
		int CAP_PROP_SPEED { get; }

		// @property (readonly, class) int CAP_PROP_APERTURE __attribute__((swift_name("CAP_PROP_APERTURE")));
		[Static]
		[Export ("CAP_PROP_APERTURE")]
		int CAP_PROP_APERTURE { get; }

		// @property (readonly, class) int CAP_PROP_EXPOSUREPROGRAM __attribute__((swift_name("CAP_PROP_EXPOSUREPROGRAM")));
		[Static]
		[Export ("CAP_PROP_EXPOSUREPROGRAM")]
		int CAP_PROP_EXPOSUREPROGRAM { get; }

		// @property (readonly, class) int CAP_PROP_VIEWFINDER __attribute__((swift_name("CAP_PROP_VIEWFINDER")));
		[Static]
		[Export ("CAP_PROP_VIEWFINDER")]
		int CAP_PROP_VIEWFINDER { get; }

		// @property (readonly, class) int CAP_PROP_IMAGES_BASE __attribute__((swift_name("CAP_PROP_IMAGES_BASE")));
		[Static]
		[Export ("CAP_PROP_IMAGES_BASE")]
		int CAP_PROP_IMAGES_BASE { get; }

		// @property (readonly, class) int CAP_PROP_IMAGES_LAST __attribute__((swift_name("CAP_PROP_IMAGES_LAST")));
		[Static]
		[Export ("CAP_PROP_IMAGES_LAST")]
		int CAP_PROP_IMAGES_LAST { get; }

		// +(NSString * _Nonnull)getBackendName:(VideoCaptureAPIs)api __attribute__((swift_name("getBackendName(api:)")));
		[Static]
		[Export ("getBackendName:")]
		string GetBackendName (VideoCaptureAPIs api);

		// +(BOOL)hasBackend:(VideoCaptureAPIs)api __attribute__((swift_name("hasBackend(api:)")));
		[Static]
		[Export ("hasBackend:")]
		bool HasBackend (VideoCaptureAPIs api);

		// +(BOOL)isBackendBuiltIn:(VideoCaptureAPIs)api __attribute__((swift_name("isBackendBuiltIn(api:)")));
		[Static]
		[Export ("isBackendBuiltIn:")]
		bool IsBackendBuiltIn (VideoCaptureAPIs api);

		// +(NSString * _Nonnull)getCameraBackendPluginVersion:(VideoCaptureAPIs)api version_ABI:(int * _Nonnull)version_ABI version_API:(int * _Nonnull)version_API __attribute__((swift_name("getCameraBackendPluginVersion(api:version_ABI:version_API:)")));
		[Static]
		[Export ("getCameraBackendPluginVersion:version_ABI:version_API:")]
		unsafe string GetCameraBackendPluginVersion (VideoCaptureAPIs api, int* version_ABI, int* version_API);

		// +(NSString * _Nonnull)getStreamBackendPluginVersion:(VideoCaptureAPIs)api version_ABI:(int * _Nonnull)version_ABI version_API:(int * _Nonnull)version_API __attribute__((swift_name("getStreamBackendPluginVersion(api:version_ABI:version_API:)")));
		[Static]
		[Export ("getStreamBackendPluginVersion:version_ABI:version_API:")]
		unsafe string GetStreamBackendPluginVersion (VideoCaptureAPIs api, int* version_ABI, int* version_API);

		// +(NSString * _Nonnull)getStreamBufferedBackendPluginVersion:(VideoCaptureAPIs)api version_ABI:(int * _Nonnull)version_ABI version_API:(int * _Nonnull)version_API __attribute__((swift_name("getStreamBufferedBackendPluginVersion(api:version_ABI:version_API:)")));
		[Static]
		[Export ("getStreamBufferedBackendPluginVersion:version_ABI:version_API:")]
		unsafe string GetStreamBufferedBackendPluginVersion (VideoCaptureAPIs api, int* version_ABI, int* version_API);

		// +(NSString * _Nonnull)getWriterBackendPluginVersion:(VideoCaptureAPIs)api version_ABI:(int * _Nonnull)version_ABI version_API:(int * _Nonnull)version_API __attribute__((swift_name("getWriterBackendPluginVersion(api:version_ABI:version_API:)")));
		[Static]
		[Export ("getWriterBackendPluginVersion:version_ABI:version_API:")]
		unsafe string GetWriterBackendPluginVersion (VideoCaptureAPIs api, int* version_ABI, int* version_API);
	}

	// @interface IStreamReader : NSObject
	[BaseType (typeof(NSObject))]
	interface IStreamReader
	{
	}

	// @interface VideoCapture : NSObject
	[BaseType (typeof(NSObject))]
	interface VideoCapture
	{
		// -(instancetype _Nonnull)initWithFilename:(NSString * _Nonnull)filename apiPreference:(int)apiPreference;
		[Export ("initWithFilename:apiPreference:")]
		NativeHandle Constructor (string filename, int apiPreference);

		// -(instancetype _Nonnull)initWithFilename:(NSString * _Nonnull)filename;
		[Export ("initWithFilename:")]
		NativeHandle Constructor (string filename);

		// -(instancetype _Nonnull)initWithFilename:(NSString * _Nonnull)filename apiPreference:(int)apiPreference params:(IntVector * _Nonnull)params;
		[Export ("initWithFilename:apiPreference:params:")]
		NativeHandle Constructor (string filename, int apiPreference, IntVector @params);

		// -(instancetype _Nonnull)initWithIndex:(int)index apiPreference:(int)apiPreference;
		[Export ("initWithIndex:apiPreference:")]
		NativeHandle Constructor (int index, int apiPreference);

		// -(instancetype _Nonnull)initWithIndex:(int)index;
		[Export ("initWithIndex:")]
		NativeHandle Constructor (int index);

		// -(instancetype _Nonnull)initWithIndex:(int)index apiPreference:(int)apiPreference params:(IntVector * _Nonnull)params;
		[Export ("initWithIndex:apiPreference:params:")]
		NativeHandle Constructor (int index, int apiPreference, IntVector @params);

		// -(instancetype _Nonnull)initWithSource:(IStreamReader * _Nonnull)source apiPreference:(int)apiPreference params:(IntVector * _Nonnull)params;
		[Export ("initWithSource:apiPreference:params:")]
		NativeHandle Constructor (IStreamReader source, int apiPreference, IntVector @params);

		// -(BOOL)open:(NSString * _Nonnull)filename apiPreference:(int)apiPreference __attribute__((swift_name("open(filename:apiPreference:)")));
		[Export ("open:apiPreference:")]
		bool Open (string filename, int apiPreference);

		// -(BOOL)open:(NSString * _Nonnull)filename __attribute__((swift_name("open(filename:)")));
		[Export ("open:")]
		bool Open (string filename);

		// -(BOOL)open:(NSString * _Nonnull)filename apiPreference:(int)apiPreference params:(IntVector * _Nonnull)params __attribute__((swift_name("open(filename:apiPreference:params:)")));
		[Export ("open:apiPreference:params:")]
		bool Open (string filename, int apiPreference, IntVector @params);

		// -(BOOL)openWithIndex:(int)index apiPreference:(int)apiPreference __attribute__((swift_name("open(index:apiPreference:)")));
		[Export ("openWithIndex:apiPreference:")]
		bool OpenWithIndex (int index, int apiPreference);

		// -(BOOL)openWithIndex:(int)index __attribute__((swift_name("open(index:)")));
		[Export ("openWithIndex:")]
		bool OpenWithIndex (int index);

		// -(BOOL)openWithIndexAndParameters:(int)index apiPreference:(int)apiPreference params:(IntVector * _Nonnull)params __attribute__((swift_name("open(index:apiPreference:params:)")));
		[Export ("openWithIndexAndParameters:apiPreference:params:")]
		bool OpenWithIndexAndParameters (int index, int apiPreference, IntVector @params);

		// -(BOOL)openWithStreamReader:(IStreamReader * _Nonnull)source apiPreference:(int)apiPreference params:(IntVector * _Nonnull)params __attribute__((swift_name("open(source:apiPreference:params:)")));
		[Export ("openWithStreamReader:apiPreference:params:")]
		bool OpenWithStreamReader (IStreamReader source, int apiPreference, IntVector @params);

		// -(BOOL)isOpened __attribute__((swift_name("isOpened()")));
		[Export ("isOpened")]
		bool IsOpened { get; }

		// -(BOOL)grab __attribute__((swift_name("grab()")));
		[Export ("grab")]
		bool Grab { get; }

		// -(BOOL)retrieve:(Mat * _Nonnull)image flag:(int)flag __attribute__((swift_name("retrieve(image:flag:)")));
		[Export ("retrieve:flag:")]
		bool Retrieve (Mat image, int flag);

		// -(BOOL)retrieve:(Mat * _Nonnull)image __attribute__((swift_name("retrieve(image:)")));
		[Export ("retrieve:")]
		bool Retrieve (Mat image);

		// -(BOOL)read:(Mat * _Nonnull)image __attribute__((swift_name("read(image:)")));
		[Export ("read:")]
		bool Read (Mat image);

		// -(BOOL)set:(int)propId value:(double)value __attribute__((swift_name("set(propId:value:)")));
		[Export ("set:value:")]
		bool Set (int propId, double value);

		// -(double)get:(int)propId __attribute__((swift_name("get(propId:)")));
		[Export ("get:")]
		double Get (int propId);

		// -(NSString * _Nonnull)getBackendName __attribute__((swift_name("getBackendName()")));
		[Export ("getBackendName")]
		string BackendName { get; }

		// -(void)setExceptionMode:(BOOL)enable __attribute__((swift_name("setExceptionMode(enable:)")));
		[Export ("setExceptionMode:")]
		void SetExceptionMode (bool enable);

		// -(BOOL)getExceptionMode __attribute__((swift_name("getExceptionMode()")));
		[Export ("getExceptionMode")]
		bool ExceptionMode { get; }
	}

	// @interface VideoWriter : NSObject
	[BaseType (typeof(NSObject))]
	interface VideoWriter
	{
		// -(instancetype _Nonnull)initWithFilename:(NSString * _Nonnull)filename fourcc:(int)fourcc fps:(double)fps frameSize:(Size2i * _Nonnull)frameSize isColor:(BOOL)isColor;
		[Export ("initWithFilename:fourcc:fps:frameSize:isColor:")]
		NativeHandle Constructor (string filename, int fourcc, double fps, Size2i frameSize, bool isColor);

		// -(instancetype _Nonnull)initWithFilename:(NSString * _Nonnull)filename fourcc:(int)fourcc fps:(double)fps frameSize:(Size2i * _Nonnull)frameSize;
		[Export ("initWithFilename:fourcc:fps:frameSize:")]
		NativeHandle Constructor (string filename, int fourcc, double fps, Size2i frameSize);

		// -(instancetype _Nonnull)initWithFilename:(NSString * _Nonnull)filename apiPreference:(int)apiPreference fourcc:(int)fourcc fps:(double)fps frameSize:(Size2i * _Nonnull)frameSize isColor:(BOOL)isColor;
		[Export ("initWithFilename:apiPreference:fourcc:fps:frameSize:isColor:")]
		NativeHandle Constructor (string filename, int apiPreference, int fourcc, double fps, Size2i frameSize, bool isColor);

		// -(instancetype _Nonnull)initWithFilename:(NSString * _Nonnull)filename apiPreference:(int)apiPreference fourcc:(int)fourcc fps:(double)fps frameSize:(Size2i * _Nonnull)frameSize;
		[Export ("initWithFilename:apiPreference:fourcc:fps:frameSize:")]
		NativeHandle Constructor (string filename, int apiPreference, int fourcc, double fps, Size2i frameSize);

		// -(instancetype _Nonnull)initWithFilename:(NSString * _Nonnull)filename fourcc:(int)fourcc fps:(double)fps frameSize:(Size2i * _Nonnull)frameSize params:(IntVector * _Nonnull)params;
		[Export ("initWithFilename:fourcc:fps:frameSize:params:")]
		NativeHandle Constructor (string filename, int fourcc, double fps, Size2i frameSize, IntVector @params);

		// -(instancetype _Nonnull)initWithFilename:(NSString * _Nonnull)filename apiPreference:(int)apiPreference fourcc:(int)fourcc fps:(double)fps frameSize:(Size2i * _Nonnull)frameSize params:(IntVector * _Nonnull)params;
		[Export ("initWithFilename:apiPreference:fourcc:fps:frameSize:params:")]
		NativeHandle Constructor (string filename, int apiPreference, int fourcc, double fps, Size2i frameSize, IntVector @params);

		// -(BOOL)open:(NSString * _Nonnull)filename fourcc:(int)fourcc fps:(double)fps frameSize:(Size2i * _Nonnull)frameSize isColor:(BOOL)isColor __attribute__((swift_name("open(filename:fourcc:fps:frameSize:isColor:)")));
		[Export ("open:fourcc:fps:frameSize:isColor:")]
		bool Open (string filename, int fourcc, double fps, Size2i frameSize, bool isColor);

		// -(BOOL)open:(NSString * _Nonnull)filename fourcc:(int)fourcc fps:(double)fps frameSize:(Size2i * _Nonnull)frameSize __attribute__((swift_name("open(filename:fourcc:fps:frameSize:)")));
		[Export ("open:fourcc:fps:frameSize:")]
		bool Open (string filename, int fourcc, double fps, Size2i frameSize);

		// -(BOOL)open:(NSString * _Nonnull)filename apiPreference:(int)apiPreference fourcc:(int)fourcc fps:(double)fps frameSize:(Size2i * _Nonnull)frameSize isColor:(BOOL)isColor __attribute__((swift_name("open(filename:apiPreference:fourcc:fps:frameSize:isColor:)")));
		[Export ("open:apiPreference:fourcc:fps:frameSize:isColor:")]
		bool Open (string filename, int apiPreference, int fourcc, double fps, Size2i frameSize, bool isColor);

		// -(BOOL)open:(NSString * _Nonnull)filename apiPreference:(int)apiPreference fourcc:(int)fourcc fps:(double)fps frameSize:(Size2i * _Nonnull)frameSize __attribute__((swift_name("open(filename:apiPreference:fourcc:fps:frameSize:)")));
		[Export ("open:apiPreference:fourcc:fps:frameSize:")]
		bool Open (string filename, int apiPreference, int fourcc, double fps, Size2i frameSize);

		// -(BOOL)open:(NSString * _Nonnull)filename fourcc:(int)fourcc fps:(double)fps frameSize:(Size2i * _Nonnull)frameSize params:(IntVector * _Nonnull)params __attribute__((swift_name("open(filename:fourcc:fps:frameSize:params:)")));
		[Export ("open:fourcc:fps:frameSize:params:")]
		bool Open (string filename, int fourcc, double fps, Size2i frameSize, IntVector @params);

		// -(BOOL)open:(NSString * _Nonnull)filename apiPreference:(int)apiPreference fourcc:(int)fourcc fps:(double)fps frameSize:(Size2i * _Nonnull)frameSize params:(IntVector * _Nonnull)params __attribute__((swift_name("open(filename:apiPreference:fourcc:fps:frameSize:params:)")));
		[Export ("open:apiPreference:fourcc:fps:frameSize:params:")]
		bool Open (string filename, int apiPreference, int fourcc, double fps, Size2i frameSize, IntVector @params);

		// -(BOOL)isOpened __attribute__((swift_name("isOpened()")));
		[Export ("isOpened")]
		bool IsOpened { get; }

		// -(void)write:(Mat * _Nonnull)image __attribute__((swift_name("write(image:)")));
		[Export ("write:")]
		void Write (Mat image);

		// -(BOOL)set:(int)propId value:(double)value __attribute__((swift_name("set(propId:value:)")));
		[Export ("set:value:")]
		bool Set (int propId, double value);

		// -(double)get:(int)propId __attribute__((swift_name("get(propId:)")));
		[Export ("get:")]
		double Get (int propId);

		// +(int)fourcc:(char)c1 c2:(char)c2 c3:(char)c3 c4:(char)c4 __attribute__((swift_name("fourcc(c1:c2:c3:c4:)")));
		[Static]
		[Export ("fourcc:c2:c3:c4:")]
		int Fourcc (sbyte c1, sbyte c2, sbyte c3, sbyte c4);

		// -(NSString * _Nonnull)getBackendName __attribute__((swift_name("getBackendName()")));
		[Export ("getBackendName")]
		string BackendName { get; }
	}

	// @interface Calib3d : NSObject
	[BaseType (typeof(NSObject))]
	interface Calib3d
	{
		// @property (readonly, class) int CV_ITERATIVE __attribute__((swift_name("CV_ITERATIVE")));
		[Static]
		[Export ("CV_ITERATIVE")]
		int CV_ITERATIVE { get; }

		// @property (readonly, class) int CV_EPNP __attribute__((swift_name("CV_EPNP")));
		[Static]
		[Export ("CV_EPNP")]
		int CV_EPNP { get; }

		// @property (readonly, class) int CV_P3P __attribute__((swift_name("CV_P3P")));
		[Static]
		[Export ("CV_P3P")]
		int CV_P3P { get; }

		// @property (readonly, class) int CV_DLS __attribute__((swift_name("CV_DLS")));
		[Static]
		[Export ("CV_DLS")]
		int CV_DLS { get; }

		// @property (readonly, class) int CvLevMarq_DONE __attribute__((swift_name("CvLevMarq_DONE")));
		[Static]
		[Export ("CvLevMarq_DONE")]
		int CvLevMarq_DONE { get; }

		// @property (readonly, class) int CvLevMarq_STARTED __attribute__((swift_name("CvLevMarq_STARTED")));
		[Static]
		[Export ("CvLevMarq_STARTED")]
		int CvLevMarq_STARTED { get; }

		// @property (readonly, class) int CvLevMarq_CALC_J __attribute__((swift_name("CvLevMarq_CALC_J")));
		[Static]
		[Export ("CvLevMarq_CALC_J")]
		int CvLevMarq_CALC_J { get; }

		// @property (readonly, class) int CvLevMarq_CHECK_ERR __attribute__((swift_name("CvLevMarq_CHECK_ERR")));
		[Static]
		[Export ("CvLevMarq_CHECK_ERR")]
		int CvLevMarq_CHECK_ERR { get; }

		// @property (readonly, class) int LMEDS __attribute__((swift_name("LMEDS")));
		[Static]
		[Export ("LMEDS")]
		int LMEDS { get; }

		// @property (readonly, class) int RANSAC __attribute__((swift_name("RANSAC")));
		[Static]
		[Export ("RANSAC")]
		int RANSAC { get; }

		// @property (readonly, class) int RHO __attribute__((swift_name("RHO")));
		[Static]
		[Export ("RHO")]
		int RHO { get; }

		// @property (readonly, class) int USAC_DEFAULT __attribute__((swift_name("USAC_DEFAULT")));
		[Static]
		[Export ("USAC_DEFAULT")]
		int USAC_DEFAULT { get; }

		// @property (readonly, class) int USAC_PARALLEL __attribute__((swift_name("USAC_PARALLEL")));
		[Static]
		[Export ("USAC_PARALLEL")]
		int USAC_PARALLEL { get; }

		// @property (readonly, class) int USAC_FM_8PTS __attribute__((swift_name("USAC_FM_8PTS")));
		[Static]
		[Export ("USAC_FM_8PTS")]
		int USAC_FM_8PTS { get; }

		// @property (readonly, class) int USAC_FAST __attribute__((swift_name("USAC_FAST")));
		[Static]
		[Export ("USAC_FAST")]
		int USAC_FAST { get; }

		// @property (readonly, class) int USAC_ACCURATE __attribute__((swift_name("USAC_ACCURATE")));
		[Static]
		[Export ("USAC_ACCURATE")]
		int USAC_ACCURATE { get; }

		// @property (readonly, class) int USAC_PROSAC __attribute__((swift_name("USAC_PROSAC")));
		[Static]
		[Export ("USAC_PROSAC")]
		int USAC_PROSAC { get; }

		// @property (readonly, class) int USAC_MAGSAC __attribute__((swift_name("USAC_MAGSAC")));
		[Static]
		[Export ("USAC_MAGSAC")]
		int USAC_MAGSAC { get; }

		// @property (readonly, class) int CALIB_CB_ADAPTIVE_THRESH __attribute__((swift_name("CALIB_CB_ADAPTIVE_THRESH")));
		[Static]
		[Export ("CALIB_CB_ADAPTIVE_THRESH")]
		int CALIB_CB_ADAPTIVE_THRESH { get; }

		// @property (readonly, class) int CALIB_CB_NORMALIZE_IMAGE __attribute__((swift_name("CALIB_CB_NORMALIZE_IMAGE")));
		[Static]
		[Export ("CALIB_CB_NORMALIZE_IMAGE")]
		int CALIB_CB_NORMALIZE_IMAGE { get; }

		// @property (readonly, class) int CALIB_CB_FILTER_QUADS __attribute__((swift_name("CALIB_CB_FILTER_QUADS")));
		[Static]
		[Export ("CALIB_CB_FILTER_QUADS")]
		int CALIB_CB_FILTER_QUADS { get; }

		// @property (readonly, class) int CALIB_CB_FAST_CHECK __attribute__((swift_name("CALIB_CB_FAST_CHECK")));
		[Static]
		[Export ("CALIB_CB_FAST_CHECK")]
		int CALIB_CB_FAST_CHECK { get; }

		// @property (readonly, class) int CALIB_CB_EXHAUSTIVE __attribute__((swift_name("CALIB_CB_EXHAUSTIVE")));
		[Static]
		[Export ("CALIB_CB_EXHAUSTIVE")]
		int CALIB_CB_EXHAUSTIVE { get; }

		// @property (readonly, class) int CALIB_CB_ACCURACY __attribute__((swift_name("CALIB_CB_ACCURACY")));
		[Static]
		[Export ("CALIB_CB_ACCURACY")]
		int CALIB_CB_ACCURACY { get; }

		// @property (readonly, class) int CALIB_CB_LARGER __attribute__((swift_name("CALIB_CB_LARGER")));
		[Static]
		[Export ("CALIB_CB_LARGER")]
		int CALIB_CB_LARGER { get; }

		// @property (readonly, class) int CALIB_CB_MARKER __attribute__((swift_name("CALIB_CB_MARKER")));
		[Static]
		[Export ("CALIB_CB_MARKER")]
		int CALIB_CB_MARKER { get; }

		// @property (readonly, class) int CALIB_CB_PLAIN __attribute__((swift_name("CALIB_CB_PLAIN")));
		[Static]
		[Export ("CALIB_CB_PLAIN")]
		int CALIB_CB_PLAIN { get; }

		// @property (readonly, class) int CALIB_CB_SYMMETRIC_GRID __attribute__((swift_name("CALIB_CB_SYMMETRIC_GRID")));
		[Static]
		[Export ("CALIB_CB_SYMMETRIC_GRID")]
		int CALIB_CB_SYMMETRIC_GRID { get; }

		// @property (readonly, class) int CALIB_CB_ASYMMETRIC_GRID __attribute__((swift_name("CALIB_CB_ASYMMETRIC_GRID")));
		[Static]
		[Export ("CALIB_CB_ASYMMETRIC_GRID")]
		int CALIB_CB_ASYMMETRIC_GRID { get; }

		// @property (readonly, class) int CALIB_CB_CLUSTERING __attribute__((swift_name("CALIB_CB_CLUSTERING")));
		[Static]
		[Export ("CALIB_CB_CLUSTERING")]
		int CALIB_CB_CLUSTERING { get; }

		// @property (readonly, class) int CALIB_NINTRINSIC __attribute__((swift_name("CALIB_NINTRINSIC")));
		[Static]
		[Export ("CALIB_NINTRINSIC")]
		int CALIB_NINTRINSIC { get; }

		// @property (readonly, class) int CALIB_USE_INTRINSIC_GUESS __attribute__((swift_name("CALIB_USE_INTRINSIC_GUESS")));
		[Static]
		[Export ("CALIB_USE_INTRINSIC_GUESS")]
		int CALIB_USE_INTRINSIC_GUESS { get; }

		// @property (readonly, class) int CALIB_FIX_ASPECT_RATIO __attribute__((swift_name("CALIB_FIX_ASPECT_RATIO")));
		[Static]
		[Export ("CALIB_FIX_ASPECT_RATIO")]
		int CALIB_FIX_ASPECT_RATIO { get; }

		// @property (readonly, class) int CALIB_FIX_PRINCIPAL_POINT __attribute__((swift_name("CALIB_FIX_PRINCIPAL_POINT")));
		[Static]
		[Export ("CALIB_FIX_PRINCIPAL_POINT")]
		int CALIB_FIX_PRINCIPAL_POINT { get; }

		// @property (readonly, class) int CALIB_ZERO_TANGENT_DIST __attribute__((swift_name("CALIB_ZERO_TANGENT_DIST")));
		[Static]
		[Export ("CALIB_ZERO_TANGENT_DIST")]
		int CALIB_ZERO_TANGENT_DIST { get; }

		// @property (readonly, class) int CALIB_FIX_FOCAL_LENGTH __attribute__((swift_name("CALIB_FIX_FOCAL_LENGTH")));
		[Static]
		[Export ("CALIB_FIX_FOCAL_LENGTH")]
		int CALIB_FIX_FOCAL_LENGTH { get; }

		// @property (readonly, class) int CALIB_FIX_K1 __attribute__((swift_name("CALIB_FIX_K1")));
		[Static]
		[Export ("CALIB_FIX_K1")]
		int CALIB_FIX_K1 { get; }

		// @property (readonly, class) int CALIB_FIX_K2 __attribute__((swift_name("CALIB_FIX_K2")));
		[Static]
		[Export ("CALIB_FIX_K2")]
		int CALIB_FIX_K2 { get; }

		// @property (readonly, class) int CALIB_FIX_K3 __attribute__((swift_name("CALIB_FIX_K3")));
		[Static]
		[Export ("CALIB_FIX_K3")]
		int CALIB_FIX_K3 { get; }

		// @property (readonly, class) int CALIB_FIX_K4 __attribute__((swift_name("CALIB_FIX_K4")));
		[Static]
		[Export ("CALIB_FIX_K4")]
		int CALIB_FIX_K4 { get; }

		// @property (readonly, class) int CALIB_FIX_K5 __attribute__((swift_name("CALIB_FIX_K5")));
		[Static]
		[Export ("CALIB_FIX_K5")]
		int CALIB_FIX_K5 { get; }

		// @property (readonly, class) int CALIB_FIX_K6 __attribute__((swift_name("CALIB_FIX_K6")));
		[Static]
		[Export ("CALIB_FIX_K6")]
		int CALIB_FIX_K6 { get; }

		// @property (readonly, class) int CALIB_RATIONAL_MODEL __attribute__((swift_name("CALIB_RATIONAL_MODEL")));
		[Static]
		[Export ("CALIB_RATIONAL_MODEL")]
		int CALIB_RATIONAL_MODEL { get; }

		// @property (readonly, class) int CALIB_THIN_PRISM_MODEL __attribute__((swift_name("CALIB_THIN_PRISM_MODEL")));
		[Static]
		[Export ("CALIB_THIN_PRISM_MODEL")]
		int CALIB_THIN_PRISM_MODEL { get; }

		// @property (readonly, class) int CALIB_FIX_S1_S2_S3_S4 __attribute__((swift_name("CALIB_FIX_S1_S2_S3_S4")));
		[Static]
		[Export ("CALIB_FIX_S1_S2_S3_S4")]
		int CALIB_FIX_S1_S2_S3_S4 { get; }

		// @property (readonly, class) int CALIB_TILTED_MODEL __attribute__((swift_name("CALIB_TILTED_MODEL")));
		[Static]
		[Export ("CALIB_TILTED_MODEL")]
		int CALIB_TILTED_MODEL { get; }

		// @property (readonly, class) int CALIB_FIX_TAUX_TAUY __attribute__((swift_name("CALIB_FIX_TAUX_TAUY")));
		[Static]
		[Export ("CALIB_FIX_TAUX_TAUY")]
		int CALIB_FIX_TAUX_TAUY { get; }

		// @property (readonly, class) int CALIB_USE_QR __attribute__((swift_name("CALIB_USE_QR")));
		[Static]
		[Export ("CALIB_USE_QR")]
		int CALIB_USE_QR { get; }

		// @property (readonly, class) int CALIB_FIX_TANGENT_DIST __attribute__((swift_name("CALIB_FIX_TANGENT_DIST")));
		[Static]
		[Export ("CALIB_FIX_TANGENT_DIST")]
		int CALIB_FIX_TANGENT_DIST { get; }

		// @property (readonly, class) int CALIB_FIX_INTRINSIC __attribute__((swift_name("CALIB_FIX_INTRINSIC")));
		[Static]
		[Export ("CALIB_FIX_INTRINSIC")]
		int CALIB_FIX_INTRINSIC { get; }

		// @property (readonly, class) int CALIB_SAME_FOCAL_LENGTH __attribute__((swift_name("CALIB_SAME_FOCAL_LENGTH")));
		[Static]
		[Export ("CALIB_SAME_FOCAL_LENGTH")]
		int CALIB_SAME_FOCAL_LENGTH { get; }

		// @property (readonly, class) int CALIB_ZERO_DISPARITY __attribute__((swift_name("CALIB_ZERO_DISPARITY")));
		[Static]
		[Export ("CALIB_ZERO_DISPARITY")]
		int CALIB_ZERO_DISPARITY { get; }

		// @property (readonly, class) int CALIB_USE_LU __attribute__((swift_name("CALIB_USE_LU")));
		[Static]
		[Export ("CALIB_USE_LU")]
		int CALIB_USE_LU { get; }

		// @property (readonly, class) int CALIB_USE_EXTRINSIC_GUESS __attribute__((swift_name("CALIB_USE_EXTRINSIC_GUESS")));
		[Static]
		[Export ("CALIB_USE_EXTRINSIC_GUESS")]
		int CALIB_USE_EXTRINSIC_GUESS { get; }

		// @property (readonly, class) int FM_7POINT __attribute__((swift_name("FM_7POINT")));
		[Static]
		[Export ("FM_7POINT")]
		int FM_7POINT { get; }

		// @property (readonly, class) int FM_8POINT __attribute__((swift_name("FM_8POINT")));
		[Static]
		[Export ("FM_8POINT")]
		int FM_8POINT { get; }

		// @property (readonly, class) int FM_LMEDS __attribute__((swift_name("FM_LMEDS")));
		[Static]
		[Export ("FM_LMEDS")]
		int FM_LMEDS { get; }

		// @property (readonly, class) int FM_RANSAC __attribute__((swift_name("FM_RANSAC")));
		[Static]
		[Export ("FM_RANSAC")]
		int FM_RANSAC { get; }

		// @property (readonly, class) int fisheye_CALIB_USE_INTRINSIC_GUESS __attribute__((swift_name("fisheye_CALIB_USE_INTRINSIC_GUESS")));
		[Static]
		[Export ("fisheye_CALIB_USE_INTRINSIC_GUESS")]
		int Fisheye_CALIB_USE_INTRINSIC_GUESS { get; }

		// @property (readonly, class) int fisheye_CALIB_RECOMPUTE_EXTRINSIC __attribute__((swift_name("fisheye_CALIB_RECOMPUTE_EXTRINSIC")));
		[Static]
		[Export ("fisheye_CALIB_RECOMPUTE_EXTRINSIC")]
		int Fisheye_CALIB_RECOMPUTE_EXTRINSIC { get; }

		// @property (readonly, class) int fisheye_CALIB_CHECK_COND __attribute__((swift_name("fisheye_CALIB_CHECK_COND")));
		[Static]
		[Export ("fisheye_CALIB_CHECK_COND")]
		int Fisheye_CALIB_CHECK_COND { get; }

		// @property (readonly, class) int fisheye_CALIB_FIX_SKEW __attribute__((swift_name("fisheye_CALIB_FIX_SKEW")));
		[Static]
		[Export ("fisheye_CALIB_FIX_SKEW")]
		int Fisheye_CALIB_FIX_SKEW { get; }

		// @property (readonly, class) int fisheye_CALIB_FIX_K1 __attribute__((swift_name("fisheye_CALIB_FIX_K1")));
		[Static]
		[Export ("fisheye_CALIB_FIX_K1")]
		int Fisheye_CALIB_FIX_K1 { get; }

		// @property (readonly, class) int fisheye_CALIB_FIX_K2 __attribute__((swift_name("fisheye_CALIB_FIX_K2")));
		[Static]
		[Export ("fisheye_CALIB_FIX_K2")]
		int Fisheye_CALIB_FIX_K2 { get; }

		// @property (readonly, class) int fisheye_CALIB_FIX_K3 __attribute__((swift_name("fisheye_CALIB_FIX_K3")));
		[Static]
		[Export ("fisheye_CALIB_FIX_K3")]
		int Fisheye_CALIB_FIX_K3 { get; }

		// @property (readonly, class) int fisheye_CALIB_FIX_K4 __attribute__((swift_name("fisheye_CALIB_FIX_K4")));
		[Static]
		[Export ("fisheye_CALIB_FIX_K4")]
		int Fisheye_CALIB_FIX_K4 { get; }

		// @property (readonly, class) int fisheye_CALIB_FIX_INTRINSIC __attribute__((swift_name("fisheye_CALIB_FIX_INTRINSIC")));
		[Static]
		[Export ("fisheye_CALIB_FIX_INTRINSIC")]
		int Fisheye_CALIB_FIX_INTRINSIC { get; }

		// @property (readonly, class) int fisheye_CALIB_FIX_PRINCIPAL_POINT __attribute__((swift_name("fisheye_CALIB_FIX_PRINCIPAL_POINT")));
		[Static]
		[Export ("fisheye_CALIB_FIX_PRINCIPAL_POINT")]
		int Fisheye_CALIB_FIX_PRINCIPAL_POINT { get; }

		// @property (readonly, class) int fisheye_CALIB_ZERO_DISPARITY __attribute__((swift_name("fisheye_CALIB_ZERO_DISPARITY")));
		[Static]
		[Export ("fisheye_CALIB_ZERO_DISPARITY")]
		int Fisheye_CALIB_ZERO_DISPARITY { get; }

		// @property (readonly, class) int fisheye_CALIB_FIX_FOCAL_LENGTH __attribute__((swift_name("fisheye_CALIB_FIX_FOCAL_LENGTH")));
		[Static]
		[Export ("fisheye_CALIB_FIX_FOCAL_LENGTH")]
		int Fisheye_CALIB_FIX_FOCAL_LENGTH { get; }

		// +(void)Rodrigues:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst jacobian:(Mat * _Nonnull)jacobian __attribute__((swift_name("Rodrigues(src:dst:jacobian:)")));
		[Static]
		[Export ("Rodrigues:dst:jacobian:")]
		void Rodrigues (Mat src, Mat dst, Mat jacobian);

		// +(void)Rodrigues:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("Rodrigues(src:dst:)")));
		[Static]
		[Export ("Rodrigues:dst:")]
		void Rodrigues (Mat src, Mat dst);

		// +(Mat * _Nonnull)findHomography:(Mat * _Nonnull)srcPoints dstPoints:(Mat * _Nonnull)dstPoints method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold mask:(Mat * _Nonnull)mask maxIters:(int)maxIters confidence:(double)confidence __attribute__((swift_name("findHomography(srcPoints:dstPoints:method:ransacReprojThreshold:mask:maxIters:confidence:)")));
		[Static]
		[Export ("findHomography:dstPoints:method:ransacReprojThreshold:mask:maxIters:confidence:")]
		Mat FindHomography (Mat srcPoints, Mat dstPoints, int method, double ransacReprojThreshold, Mat mask, int maxIters, double confidence);

		// +(Mat * _Nonnull)findHomography:(Mat * _Nonnull)srcPoints dstPoints:(Mat * _Nonnull)dstPoints method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold mask:(Mat * _Nonnull)mask maxIters:(int)maxIters __attribute__((swift_name("findHomography(srcPoints:dstPoints:method:ransacReprojThreshold:mask:maxIters:)")));
		[Static]
		[Export ("findHomography:dstPoints:method:ransacReprojThreshold:mask:maxIters:")]
		Mat FindHomography (Mat srcPoints, Mat dstPoints, int method, double ransacReprojThreshold, Mat mask, int maxIters);

		// +(Mat * _Nonnull)findHomography:(Mat * _Nonnull)srcPoints dstPoints:(Mat * _Nonnull)dstPoints method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold mask:(Mat * _Nonnull)mask __attribute__((swift_name("findHomography(srcPoints:dstPoints:method:ransacReprojThreshold:mask:)")));
		[Static]
		[Export ("findHomography:dstPoints:method:ransacReprojThreshold:mask:")]
		Mat FindHomography (Mat srcPoints, Mat dstPoints, int method, double ransacReprojThreshold, Mat mask);

		// +(Mat * _Nonnull)findHomography:(Mat * _Nonnull)srcPoints dstPoints:(Mat * _Nonnull)dstPoints method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold __attribute__((swift_name("findHomography(srcPoints:dstPoints:method:ransacReprojThreshold:)")));
		[Static]
		[Export ("findHomography:dstPoints:method:ransacReprojThreshold:")]
		Mat FindHomography (Mat srcPoints, Mat dstPoints, int method, double ransacReprojThreshold);

		// +(Mat * _Nonnull)findHomography:(Mat * _Nonnull)srcPoints dstPoints:(Mat * _Nonnull)dstPoints method:(int)method __attribute__((swift_name("findHomography(srcPoints:dstPoints:method:)")));
		[Static]
		[Export ("findHomography:dstPoints:method:")]
		Mat FindHomography (Mat srcPoints, Mat dstPoints, int method);

		// +(Mat * _Nonnull)findHomography:(Mat * _Nonnull)srcPoints dstPoints:(Mat * _Nonnull)dstPoints __attribute__((swift_name("findHomography(srcPoints:dstPoints:)")));
		[Static]
		[Export ("findHomography:dstPoints:")]
		Mat FindHomography (Mat srcPoints, Mat dstPoints);

		// +(Mat * _Nonnull)findHomography:(Mat * _Nonnull)srcPoints dstPoints:(Mat * _Nonnull)dstPoints mask:(Mat * _Nonnull)mask params:(UsacParams * _Nonnull)params __attribute__((swift_name("findHomography(srcPoints:dstPoints:mask:params:)")));
		[Static]
		[Export ("findHomography:dstPoints:mask:params:")]
		Mat FindHomography (Mat srcPoints, Mat dstPoints, Mat mask, UsacParams @params);

		// +(Double3 * _Nonnull)RQDecomp3x3:(Mat * _Nonnull)src mtxR:(Mat * _Nonnull)mtxR mtxQ:(Mat * _Nonnull)mtxQ Qx:(Mat * _Nonnull)Qx Qy:(Mat * _Nonnull)Qy Qz:(Mat * _Nonnull)Qz __attribute__((swift_name("RQDecomp3x3(src:mtxR:mtxQ:Qx:Qy:Qz:)")));
		[Static]
		[Export ("RQDecomp3x3:mtxR:mtxQ:Qx:Qy:Qz:")]
		Double3 RQDecomp3x3 (Mat src, Mat mtxR, Mat mtxQ, Mat Qx, Mat Qy, Mat Qz);

		// +(Double3 * _Nonnull)RQDecomp3x3:(Mat * _Nonnull)src mtxR:(Mat * _Nonnull)mtxR mtxQ:(Mat * _Nonnull)mtxQ Qx:(Mat * _Nonnull)Qx Qy:(Mat * _Nonnull)Qy __attribute__((swift_name("RQDecomp3x3(src:mtxR:mtxQ:Qx:Qy:)")));
		[Static]
		[Export ("RQDecomp3x3:mtxR:mtxQ:Qx:Qy:")]
		Double3 RQDecomp3x3 (Mat src, Mat mtxR, Mat mtxQ, Mat Qx, Mat Qy);

		// +(Double3 * _Nonnull)RQDecomp3x3:(Mat * _Nonnull)src mtxR:(Mat * _Nonnull)mtxR mtxQ:(Mat * _Nonnull)mtxQ Qx:(Mat * _Nonnull)Qx __attribute__((swift_name("RQDecomp3x3(src:mtxR:mtxQ:Qx:)")));
		[Static]
		[Export ("RQDecomp3x3:mtxR:mtxQ:Qx:")]
		Double3 RQDecomp3x3 (Mat src, Mat mtxR, Mat mtxQ, Mat Qx);

		// +(Double3 * _Nonnull)RQDecomp3x3:(Mat * _Nonnull)src mtxR:(Mat * _Nonnull)mtxR mtxQ:(Mat * _Nonnull)mtxQ __attribute__((swift_name("RQDecomp3x3(src:mtxR:mtxQ:)")));
		[Static]
		[Export ("RQDecomp3x3:mtxR:mtxQ:")]
		Double3 RQDecomp3x3 (Mat src, Mat mtxR, Mat mtxQ);

		// +(void)decomposeProjectionMatrix:(Mat * _Nonnull)projMatrix cameraMatrix:(Mat * _Nonnull)cameraMatrix rotMatrix:(Mat * _Nonnull)rotMatrix transVect:(Mat * _Nonnull)transVect rotMatrixX:(Mat * _Nonnull)rotMatrixX rotMatrixY:(Mat * _Nonnull)rotMatrixY rotMatrixZ:(Mat * _Nonnull)rotMatrixZ eulerAngles:(Mat * _Nonnull)eulerAngles __attribute__((swift_name("decomposeProjectionMatrix(projMatrix:cameraMatrix:rotMatrix:transVect:rotMatrixX:rotMatrixY:rotMatrixZ:eulerAngles:)")));
		[Static]
		[Export ("decomposeProjectionMatrix:cameraMatrix:rotMatrix:transVect:rotMatrixX:rotMatrixY:rotMatrixZ:eulerAngles:")]
		void DecomposeProjectionMatrix (Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect, Mat rotMatrixX, Mat rotMatrixY, Mat rotMatrixZ, Mat eulerAngles);

		// +(void)decomposeProjectionMatrix:(Mat * _Nonnull)projMatrix cameraMatrix:(Mat * _Nonnull)cameraMatrix rotMatrix:(Mat * _Nonnull)rotMatrix transVect:(Mat * _Nonnull)transVect rotMatrixX:(Mat * _Nonnull)rotMatrixX rotMatrixY:(Mat * _Nonnull)rotMatrixY rotMatrixZ:(Mat * _Nonnull)rotMatrixZ __attribute__((swift_name("decomposeProjectionMatrix(projMatrix:cameraMatrix:rotMatrix:transVect:rotMatrixX:rotMatrixY:rotMatrixZ:)")));
		[Static]
		[Export ("decomposeProjectionMatrix:cameraMatrix:rotMatrix:transVect:rotMatrixX:rotMatrixY:rotMatrixZ:")]
		void DecomposeProjectionMatrix (Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect, Mat rotMatrixX, Mat rotMatrixY, Mat rotMatrixZ);

		// +(void)decomposeProjectionMatrix:(Mat * _Nonnull)projMatrix cameraMatrix:(Mat * _Nonnull)cameraMatrix rotMatrix:(Mat * _Nonnull)rotMatrix transVect:(Mat * _Nonnull)transVect rotMatrixX:(Mat * _Nonnull)rotMatrixX rotMatrixY:(Mat * _Nonnull)rotMatrixY __attribute__((swift_name("decomposeProjectionMatrix(projMatrix:cameraMatrix:rotMatrix:transVect:rotMatrixX:rotMatrixY:)")));
		[Static]
		[Export ("decomposeProjectionMatrix:cameraMatrix:rotMatrix:transVect:rotMatrixX:rotMatrixY:")]
		void DecomposeProjectionMatrix (Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect, Mat rotMatrixX, Mat rotMatrixY);

		// +(void)decomposeProjectionMatrix:(Mat * _Nonnull)projMatrix cameraMatrix:(Mat * _Nonnull)cameraMatrix rotMatrix:(Mat * _Nonnull)rotMatrix transVect:(Mat * _Nonnull)transVect rotMatrixX:(Mat * _Nonnull)rotMatrixX __attribute__((swift_name("decomposeProjectionMatrix(projMatrix:cameraMatrix:rotMatrix:transVect:rotMatrixX:)")));
		[Static]
		[Export ("decomposeProjectionMatrix:cameraMatrix:rotMatrix:transVect:rotMatrixX:")]
		void DecomposeProjectionMatrix (Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect, Mat rotMatrixX);

		// +(void)decomposeProjectionMatrix:(Mat * _Nonnull)projMatrix cameraMatrix:(Mat * _Nonnull)cameraMatrix rotMatrix:(Mat * _Nonnull)rotMatrix transVect:(Mat * _Nonnull)transVect __attribute__((swift_name("decomposeProjectionMatrix(projMatrix:cameraMatrix:rotMatrix:transVect:)")));
		[Static]
		[Export ("decomposeProjectionMatrix:cameraMatrix:rotMatrix:transVect:")]
		void DecomposeProjectionMatrix (Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect);

		// +(void)matMulDeriv:(Mat * _Nonnull)A B:(Mat * _Nonnull)B dABdA:(Mat * _Nonnull)dABdA dABdB:(Mat * _Nonnull)dABdB __attribute__((swift_name("matMulDeriv(A:B:dABdA:dABdB:)")));
		[Static]
		[Export ("matMulDeriv:B:dABdA:dABdB:")]
		void MatMulDeriv (Mat A, Mat B, Mat dABdA, Mat dABdB);

		// +(void)composeRT:(Mat * _Nonnull)rvec1 tvec1:(Mat * _Nonnull)tvec1 rvec2:(Mat * _Nonnull)rvec2 tvec2:(Mat * _Nonnull)tvec2 rvec3:(Mat * _Nonnull)rvec3 tvec3:(Mat * _Nonnull)tvec3 dr3dr1:(Mat * _Nonnull)dr3dr1 dr3dt1:(Mat * _Nonnull)dr3dt1 dr3dr2:(Mat * _Nonnull)dr3dr2 dr3dt2:(Mat * _Nonnull)dr3dt2 dt3dr1:(Mat * _Nonnull)dt3dr1 dt3dt1:(Mat * _Nonnull)dt3dt1 dt3dr2:(Mat * _Nonnull)dt3dr2 dt3dt2:(Mat * _Nonnull)dt3dt2 __attribute__((swift_name("composeRT(rvec1:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:dr3dt1:dr3dr2:dr3dt2:dt3dr1:dt3dt1:dt3dr2:dt3dt2:)")));
		[Static]
		[Export ("composeRT:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:dr3dt1:dr3dr2:dr3dt2:dt3dr1:dt3dt1:dt3dr2:dt3dt2:")]
		void ComposeRT (Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2, Mat dt3dr1, Mat dt3dt1, Mat dt3dr2, Mat dt3dt2);

		// +(void)composeRT:(Mat * _Nonnull)rvec1 tvec1:(Mat * _Nonnull)tvec1 rvec2:(Mat * _Nonnull)rvec2 tvec2:(Mat * _Nonnull)tvec2 rvec3:(Mat * _Nonnull)rvec3 tvec3:(Mat * _Nonnull)tvec3 dr3dr1:(Mat * _Nonnull)dr3dr1 dr3dt1:(Mat * _Nonnull)dr3dt1 dr3dr2:(Mat * _Nonnull)dr3dr2 dr3dt2:(Mat * _Nonnull)dr3dt2 dt3dr1:(Mat * _Nonnull)dt3dr1 dt3dt1:(Mat * _Nonnull)dt3dt1 dt3dr2:(Mat * _Nonnull)dt3dr2 __attribute__((swift_name("composeRT(rvec1:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:dr3dt1:dr3dr2:dr3dt2:dt3dr1:dt3dt1:dt3dr2:)")));
		[Static]
		[Export ("composeRT:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:dr3dt1:dr3dr2:dr3dt2:dt3dr1:dt3dt1:dt3dr2:")]
		void ComposeRT (Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2, Mat dt3dr1, Mat dt3dt1, Mat dt3dr2);

		// +(void)composeRT:(Mat * _Nonnull)rvec1 tvec1:(Mat * _Nonnull)tvec1 rvec2:(Mat * _Nonnull)rvec2 tvec2:(Mat * _Nonnull)tvec2 rvec3:(Mat * _Nonnull)rvec3 tvec3:(Mat * _Nonnull)tvec3 dr3dr1:(Mat * _Nonnull)dr3dr1 dr3dt1:(Mat * _Nonnull)dr3dt1 dr3dr2:(Mat * _Nonnull)dr3dr2 dr3dt2:(Mat * _Nonnull)dr3dt2 dt3dr1:(Mat * _Nonnull)dt3dr1 dt3dt1:(Mat * _Nonnull)dt3dt1 __attribute__((swift_name("composeRT(rvec1:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:dr3dt1:dr3dr2:dr3dt2:dt3dr1:dt3dt1:)")));
		[Static]
		[Export ("composeRT:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:dr3dt1:dr3dr2:dr3dt2:dt3dr1:dt3dt1:")]
		void ComposeRT (Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2, Mat dt3dr1, Mat dt3dt1);

		// +(void)composeRT:(Mat * _Nonnull)rvec1 tvec1:(Mat * _Nonnull)tvec1 rvec2:(Mat * _Nonnull)rvec2 tvec2:(Mat * _Nonnull)tvec2 rvec3:(Mat * _Nonnull)rvec3 tvec3:(Mat * _Nonnull)tvec3 dr3dr1:(Mat * _Nonnull)dr3dr1 dr3dt1:(Mat * _Nonnull)dr3dt1 dr3dr2:(Mat * _Nonnull)dr3dr2 dr3dt2:(Mat * _Nonnull)dr3dt2 dt3dr1:(Mat * _Nonnull)dt3dr1 __attribute__((swift_name("composeRT(rvec1:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:dr3dt1:dr3dr2:dr3dt2:dt3dr1:)")));
		[Static]
		[Export ("composeRT:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:dr3dt1:dr3dr2:dr3dt2:dt3dr1:")]
		void ComposeRT (Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2, Mat dt3dr1);

		// +(void)composeRT:(Mat * _Nonnull)rvec1 tvec1:(Mat * _Nonnull)tvec1 rvec2:(Mat * _Nonnull)rvec2 tvec2:(Mat * _Nonnull)tvec2 rvec3:(Mat * _Nonnull)rvec3 tvec3:(Mat * _Nonnull)tvec3 dr3dr1:(Mat * _Nonnull)dr3dr1 dr3dt1:(Mat * _Nonnull)dr3dt1 dr3dr2:(Mat * _Nonnull)dr3dr2 dr3dt2:(Mat * _Nonnull)dr3dt2 __attribute__((swift_name("composeRT(rvec1:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:dr3dt1:dr3dr2:dr3dt2:)")));
		[Static]
		[Export ("composeRT:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:dr3dt1:dr3dr2:dr3dt2:")]
		void ComposeRT (Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2);

		// +(void)composeRT:(Mat * _Nonnull)rvec1 tvec1:(Mat * _Nonnull)tvec1 rvec2:(Mat * _Nonnull)rvec2 tvec2:(Mat * _Nonnull)tvec2 rvec3:(Mat * _Nonnull)rvec3 tvec3:(Mat * _Nonnull)tvec3 dr3dr1:(Mat * _Nonnull)dr3dr1 dr3dt1:(Mat * _Nonnull)dr3dt1 dr3dr2:(Mat * _Nonnull)dr3dr2 __attribute__((swift_name("composeRT(rvec1:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:dr3dt1:dr3dr2:)")));
		[Static]
		[Export ("composeRT:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:dr3dt1:dr3dr2:")]
		void ComposeRT (Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2);

		// +(void)composeRT:(Mat * _Nonnull)rvec1 tvec1:(Mat * _Nonnull)tvec1 rvec2:(Mat * _Nonnull)rvec2 tvec2:(Mat * _Nonnull)tvec2 rvec3:(Mat * _Nonnull)rvec3 tvec3:(Mat * _Nonnull)tvec3 dr3dr1:(Mat * _Nonnull)dr3dr1 dr3dt1:(Mat * _Nonnull)dr3dt1 __attribute__((swift_name("composeRT(rvec1:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:dr3dt1:)")));
		[Static]
		[Export ("composeRT:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:dr3dt1:")]
		void ComposeRT (Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1);

		// +(void)composeRT:(Mat * _Nonnull)rvec1 tvec1:(Mat * _Nonnull)tvec1 rvec2:(Mat * _Nonnull)rvec2 tvec2:(Mat * _Nonnull)tvec2 rvec3:(Mat * _Nonnull)rvec3 tvec3:(Mat * _Nonnull)tvec3 dr3dr1:(Mat * _Nonnull)dr3dr1 __attribute__((swift_name("composeRT(rvec1:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:)")));
		[Static]
		[Export ("composeRT:tvec1:rvec2:tvec2:rvec3:tvec3:dr3dr1:")]
		void ComposeRT (Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1);

		// +(void)composeRT:(Mat * _Nonnull)rvec1 tvec1:(Mat * _Nonnull)tvec1 rvec2:(Mat * _Nonnull)rvec2 tvec2:(Mat * _Nonnull)tvec2 rvec3:(Mat * _Nonnull)rvec3 tvec3:(Mat * _Nonnull)tvec3 __attribute__((swift_name("composeRT(rvec1:tvec1:rvec2:tvec2:rvec3:tvec3:)")));
		[Static]
		[Export ("composeRT:tvec1:rvec2:tvec2:rvec3:tvec3:")]
		void ComposeRT (Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3);

		// +(void)projectPoints:(Mat * _Nonnull)objectPoints rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs imagePoints:(Mat * _Nonnull)imagePoints jacobian:(Mat * _Nonnull)jacobian aspectRatio:(double)aspectRatio __attribute__((swift_name("projectPoints(objectPoints:rvec:tvec:cameraMatrix:distCoeffs:imagePoints:jacobian:aspectRatio:)")));
		[Static]
		[Export ("projectPoints:rvec:tvec:cameraMatrix:distCoeffs:imagePoints:jacobian:aspectRatio:")]
		void ProjectPoints (Mat objectPoints, Mat rvec, Mat tvec, Mat cameraMatrix, Mat distCoeffs, Mat imagePoints, Mat jacobian, double aspectRatio);

		// +(void)projectPoints:(Mat * _Nonnull)objectPoints rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs imagePoints:(Mat * _Nonnull)imagePoints jacobian:(Mat * _Nonnull)jacobian __attribute__((swift_name("projectPoints(objectPoints:rvec:tvec:cameraMatrix:distCoeffs:imagePoints:jacobian:)")));
		[Static]
		[Export ("projectPoints:rvec:tvec:cameraMatrix:distCoeffs:imagePoints:jacobian:")]
		void ProjectPoints (Mat objectPoints, Mat rvec, Mat tvec, Mat cameraMatrix, Mat distCoeffs, Mat imagePoints, Mat jacobian);

		// +(void)projectPoints:(Mat * _Nonnull)objectPoints rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs imagePoints:(Mat * _Nonnull)imagePoints __attribute__((swift_name("projectPoints(objectPoints:rvec:tvec:cameraMatrix:distCoeffs:imagePoints:)")));
		[Static]
		[Export ("projectPoints:rvec:tvec:cameraMatrix:distCoeffs:imagePoints:")]
		void ProjectPoints (Mat objectPoints, Mat rvec, Mat tvec, Mat cameraMatrix, Mat distCoeffs, Mat imagePoints);

		// +(BOOL)solvePnP:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess flags:(int)flags __attribute__((swift_name("solvePnP(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:flags:)")));
		[Static]
		[Export ("solvePnP:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:flags:")]
		bool SolvePnP (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int flags);

		// +(BOOL)solvePnP:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess __attribute__((swift_name("solvePnP(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:)")));
		[Static]
		[Export ("solvePnP:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:")]
		bool SolvePnP (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess);

		// +(BOOL)solvePnP:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec __attribute__((swift_name("solvePnP(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:)")));
		[Static]
		[Export ("solvePnP:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:")]
		bool SolvePnP (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec);

		// +(BOOL)solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess iterationsCount:(int)iterationsCount reprojectionError:(float)reprojectionError confidence:(double)confidence inliers:(Mat * _Nonnull)inliers flags:(int)flags __attribute__((swift_name("solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:confidence:inliers:flags:)")));
		[Static]
		[Export ("solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:confidence:inliers:flags:")]
		bool SolvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence, Mat inliers, int flags);

		// +(BOOL)solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess iterationsCount:(int)iterationsCount reprojectionError:(float)reprojectionError confidence:(double)confidence inliers:(Mat * _Nonnull)inliers __attribute__((swift_name("solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:confidence:inliers:)")));
		[Static]
		[Export ("solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:confidence:inliers:")]
		bool SolvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence, Mat inliers);

		// +(BOOL)solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess iterationsCount:(int)iterationsCount reprojectionError:(float)reprojectionError confidence:(double)confidence __attribute__((swift_name("solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:confidence:)")));
		[Static]
		[Export ("solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:confidence:")]
		bool SolvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence);

		// +(BOOL)solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess iterationsCount:(int)iterationsCount reprojectionError:(float)reprojectionError __attribute__((swift_name("solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:)")));
		[Static]
		[Export ("solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:")]
		bool SolvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError);

		// +(BOOL)solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess iterationsCount:(int)iterationsCount __attribute__((swift_name("solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:)")));
		[Static]
		[Export ("solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:")]
		bool SolvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount);

		// +(BOOL)solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess __attribute__((swift_name("solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:)")));
		[Static]
		[Export ("solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:")]
		bool SolvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess);

		// +(BOOL)solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec __attribute__((swift_name("solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:)")));
		[Static]
		[Export ("solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:")]
		bool SolvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec);

		// +(BOOL)solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec inliers:(Mat * _Nonnull)inliers params:(UsacParams * _Nonnull)params __attribute__((swift_name("solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:inliers:params:)")));
		[Static]
		[Export ("solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:inliers:params:")]
		bool SolvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, Mat inliers, UsacParams @params);

		// +(BOOL)solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec inliers:(Mat * _Nonnull)inliers __attribute__((swift_name("solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:inliers:)")));
		[Static]
		[Export ("solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:inliers:")]
		bool SolvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, Mat inliers);

		// +(int)solveP3P:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs flags:(int)flags __attribute__((swift_name("solveP3P(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvecs:tvecs:flags:)")));
		[Static]
		[Export ("solveP3P:imagePoints:cameraMatrix:distCoeffs:rvecs:tvecs:flags:")]
		int SolveP3P (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, int flags);

		// +(void)solvePnPRefineLM:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("solvePnPRefineLM(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:criteria:)")));
		[Static]
		[Export ("solvePnPRefineLM:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:criteria:")]
		void SolvePnPRefineLM (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, TermCriteria criteria);

		// +(void)solvePnPRefineLM:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec __attribute__((swift_name("solvePnPRefineLM(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:)")));
		[Static]
		[Export ("solvePnPRefineLM:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:")]
		void SolvePnPRefineLM (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec);

		// +(void)solvePnPRefineVVS:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec criteria:(TermCriteria * _Nonnull)criteria VVSlambda:(double)VVSlambda __attribute__((swift_name("solvePnPRefineVVS(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:criteria:VVSlambda:)")));
		[Static]
		[Export ("solvePnPRefineVVS:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:criteria:VVSlambda:")]
		void SolvePnPRefineVVS (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, TermCriteria criteria, double VVSlambda);

		// +(void)solvePnPRefineVVS:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("solvePnPRefineVVS(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:criteria:)")));
		[Static]
		[Export ("solvePnPRefineVVS:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:criteria:")]
		void SolvePnPRefineVVS (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, TermCriteria criteria);

		// +(void)solvePnPRefineVVS:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec __attribute__((swift_name("solvePnPRefineVVS(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:)")));
		[Static]
		[Export ("solvePnPRefineVVS:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:")]
		void SolvePnPRefineVVS (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec);

		// +(int)solvePnPGeneric:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs useExtrinsicGuess:(BOOL)useExtrinsicGuess flags:(SolvePnPMethod)flags rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec reprojectionError:(Mat * _Nonnull)reprojectionError __attribute__((swift_name("solvePnPGeneric(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvecs:tvecs:useExtrinsicGuess:flags:rvec:tvec:reprojectionError:)")));
		[Static]
		[Export ("solvePnPGeneric:imagePoints:cameraMatrix:distCoeffs:rvecs:tvecs:useExtrinsicGuess:flags:rvec:tvec:reprojectionError:")]
		int SolvePnPGeneric (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, bool useExtrinsicGuess, SolvePnPMethod flags, Mat rvec, Mat tvec, Mat reprojectionError);

		// +(int)solvePnPGeneric:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs useExtrinsicGuess:(BOOL)useExtrinsicGuess flags:(SolvePnPMethod)flags rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec __attribute__((swift_name("solvePnPGeneric(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvecs:tvecs:useExtrinsicGuess:flags:rvec:tvec:)")));
		[Static]
		[Export ("solvePnPGeneric:imagePoints:cameraMatrix:distCoeffs:rvecs:tvecs:useExtrinsicGuess:flags:rvec:tvec:")]
		int SolvePnPGeneric (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, bool useExtrinsicGuess, SolvePnPMethod flags, Mat rvec, Mat tvec);

		// +(int)solvePnPGeneric:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs useExtrinsicGuess:(BOOL)useExtrinsicGuess flags:(SolvePnPMethod)flags rvec:(Mat * _Nonnull)rvec __attribute__((swift_name("solvePnPGeneric(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvecs:tvecs:useExtrinsicGuess:flags:rvec:)")));
		[Static]
		[Export ("solvePnPGeneric:imagePoints:cameraMatrix:distCoeffs:rvecs:tvecs:useExtrinsicGuess:flags:rvec:")]
		int SolvePnPGeneric (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, bool useExtrinsicGuess, SolvePnPMethod flags, Mat rvec);

		// +(int)solvePnPGeneric:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs useExtrinsicGuess:(BOOL)useExtrinsicGuess flags:(SolvePnPMethod)flags __attribute__((swift_name("solvePnPGeneric(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvecs:tvecs:useExtrinsicGuess:flags:)")));
		[Static]
		[Export ("solvePnPGeneric:imagePoints:cameraMatrix:distCoeffs:rvecs:tvecs:useExtrinsicGuess:flags:")]
		int SolvePnPGeneric (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, bool useExtrinsicGuess, SolvePnPMethod flags);

		// +(int)solvePnPGeneric:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs useExtrinsicGuess:(BOOL)useExtrinsicGuess __attribute__((swift_name("solvePnPGeneric(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvecs:tvecs:useExtrinsicGuess:)")));
		[Static]
		[Export ("solvePnPGeneric:imagePoints:cameraMatrix:distCoeffs:rvecs:tvecs:useExtrinsicGuess:")]
		int SolvePnPGeneric (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, bool useExtrinsicGuess);

		// +(int)solvePnPGeneric:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs __attribute__((swift_name("solvePnPGeneric(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvecs:tvecs:)")));
		[Static]
		[Export ("solvePnPGeneric:imagePoints:cameraMatrix:distCoeffs:rvecs:tvecs:")]
		int SolvePnPGeneric (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs);

		// +(Mat * _Nonnull)initCameraMatrix2D:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints imageSize:(Size2i * _Nonnull)imageSize aspectRatio:(double)aspectRatio __attribute__((swift_name("initCameraMatrix2D(objectPoints:imagePoints:imageSize:aspectRatio:)")));
		[Static]
		[Export ("initCameraMatrix2D:imagePoints:imageSize:aspectRatio:")]
		Mat InitCameraMatrix2D (Mat[] objectPoints, Mat[] imagePoints, Size2i imageSize, double aspectRatio);

		// +(Mat * _Nonnull)initCameraMatrix2D:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints imageSize:(Size2i * _Nonnull)imageSize __attribute__((swift_name("initCameraMatrix2D(objectPoints:imagePoints:imageSize:)")));
		[Static]
		[Export ("initCameraMatrix2D:imagePoints:imageSize:")]
		Mat InitCameraMatrix2D (Mat[] objectPoints, Mat[] imagePoints, Size2i imageSize);

		// +(BOOL)findChessboardCorners:(Mat * _Nonnull)image patternSize:(Size2i * _Nonnull)patternSize corners:(Mat * _Nonnull)corners flags:(int)flags __attribute__((swift_name("findChessboardCorners(image:patternSize:corners:flags:)")));
		[Static]
		[Export ("findChessboardCorners:patternSize:corners:flags:")]
		bool FindChessboardCorners (Mat image, Size2i patternSize, Mat corners, int flags);

		// +(BOOL)findChessboardCorners:(Mat * _Nonnull)image patternSize:(Size2i * _Nonnull)patternSize corners:(Mat * _Nonnull)corners __attribute__((swift_name("findChessboardCorners(image:patternSize:corners:)")));
		[Static]
		[Export ("findChessboardCorners:patternSize:corners:")]
		bool FindChessboardCorners (Mat image, Size2i patternSize, Mat corners);

		// +(BOOL)checkChessboard:(Mat * _Nonnull)img size:(Size2i * _Nonnull)size __attribute__((swift_name("checkChessboard(img:size:)")));
		[Static]
		[Export ("checkChessboard:size:")]
		bool CheckChessboard (Mat img, Size2i size);

		// +(BOOL)findChessboardCornersSBWithMeta:(Mat * _Nonnull)image patternSize:(Size2i * _Nonnull)patternSize corners:(Mat * _Nonnull)corners flags:(int)flags meta:(Mat * _Nonnull)meta __attribute__((swift_name("findChessboardCornersSB(image:patternSize:corners:flags:meta:)")));
		[Static]
		[Export ("findChessboardCornersSBWithMeta:patternSize:corners:flags:meta:")]
		bool FindChessboardCornersSBWithMeta (Mat image, Size2i patternSize, Mat corners, int flags, Mat meta);

		// +(BOOL)findChessboardCornersSB:(Mat * _Nonnull)image patternSize:(Size2i * _Nonnull)patternSize corners:(Mat * _Nonnull)corners flags:(int)flags __attribute__((swift_name("findChessboardCornersSB(image:patternSize:corners:flags:)")));
		[Static]
		[Export ("findChessboardCornersSB:patternSize:corners:flags:")]
		bool FindChessboardCornersSB (Mat image, Size2i patternSize, Mat corners, int flags);

		// +(BOOL)findChessboardCornersSB:(Mat * _Nonnull)image patternSize:(Size2i * _Nonnull)patternSize corners:(Mat * _Nonnull)corners __attribute__((swift_name("findChessboardCornersSB(image:patternSize:corners:)")));
		[Static]
		[Export ("findChessboardCornersSB:patternSize:corners:")]
		bool FindChessboardCornersSB (Mat image, Size2i patternSize, Mat corners);

		// +(Scalar * _Nonnull)estimateChessboardSharpness:(Mat * _Nonnull)image patternSize:(Size2i * _Nonnull)patternSize corners:(Mat * _Nonnull)corners rise_distance:(float)rise_distance vertical:(BOOL)vertical sharpness:(Mat * _Nonnull)sharpness __attribute__((swift_name("estimateChessboardSharpness(image:patternSize:corners:rise_distance:vertical:sharpness:)")));
		[Static]
		[Export ("estimateChessboardSharpness:patternSize:corners:rise_distance:vertical:sharpness:")]
		Scalar EstimateChessboardSharpness (Mat image, Size2i patternSize, Mat corners, float rise_distance, bool vertical, Mat sharpness);

		// +(Scalar * _Nonnull)estimateChessboardSharpness:(Mat * _Nonnull)image patternSize:(Size2i * _Nonnull)patternSize corners:(Mat * _Nonnull)corners rise_distance:(float)rise_distance vertical:(BOOL)vertical __attribute__((swift_name("estimateChessboardSharpness(image:patternSize:corners:rise_distance:vertical:)")));
		[Static]
		[Export ("estimateChessboardSharpness:patternSize:corners:rise_distance:vertical:")]
		Scalar EstimateChessboardSharpness (Mat image, Size2i patternSize, Mat corners, float rise_distance, bool vertical);

		// +(Scalar * _Nonnull)estimateChessboardSharpness:(Mat * _Nonnull)image patternSize:(Size2i * _Nonnull)patternSize corners:(Mat * _Nonnull)corners rise_distance:(float)rise_distance __attribute__((swift_name("estimateChessboardSharpness(image:patternSize:corners:rise_distance:)")));
		[Static]
		[Export ("estimateChessboardSharpness:patternSize:corners:rise_distance:")]
		Scalar EstimateChessboardSharpness (Mat image, Size2i patternSize, Mat corners, float rise_distance);

		// +(Scalar * _Nonnull)estimateChessboardSharpness:(Mat * _Nonnull)image patternSize:(Size2i * _Nonnull)patternSize corners:(Mat * _Nonnull)corners __attribute__((swift_name("estimateChessboardSharpness(image:patternSize:corners:)")));
		[Static]
		[Export ("estimateChessboardSharpness:patternSize:corners:")]
		Scalar EstimateChessboardSharpness (Mat image, Size2i patternSize, Mat corners);

		// +(BOOL)find4QuadCornerSubpix:(Mat * _Nonnull)img corners:(Mat * _Nonnull)corners region_size:(Size2i * _Nonnull)region_size __attribute__((swift_name("find4QuadCornerSubpix(img:corners:region_size:)")));
		[Static]
		[Export ("find4QuadCornerSubpix:corners:region_size:")]
		bool Find4QuadCornerSubpix (Mat img, Mat corners, Size2i region_size);

		// +(void)drawChessboardCorners:(Mat * _Nonnull)image patternSize:(Size2i * _Nonnull)patternSize corners:(Mat * _Nonnull)corners patternWasFound:(BOOL)patternWasFound __attribute__((swift_name("drawChessboardCorners(image:patternSize:corners:patternWasFound:)")));
		[Static]
		[Export ("drawChessboardCorners:patternSize:corners:patternWasFound:")]
		void DrawChessboardCorners (Mat image, Size2i patternSize, Mat corners, bool patternWasFound);

		// +(void)drawFrameAxes:(Mat * _Nonnull)image cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec length:(float)length thickness:(int)thickness __attribute__((swift_name("drawFrameAxes(image:cameraMatrix:distCoeffs:rvec:tvec:length:thickness:)")));
		[Static]
		[Export ("drawFrameAxes:cameraMatrix:distCoeffs:rvec:tvec:length:thickness:")]
		void DrawFrameAxes (Mat image, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, float length, int thickness);

		// +(void)drawFrameAxes:(Mat * _Nonnull)image cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec length:(float)length __attribute__((swift_name("drawFrameAxes(image:cameraMatrix:distCoeffs:rvec:tvec:length:)")));
		[Static]
		[Export ("drawFrameAxes:cameraMatrix:distCoeffs:rvec:tvec:length:")]
		void DrawFrameAxes (Mat image, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, float length);

		// +(BOOL)findCirclesGrid:(Mat * _Nonnull)image patternSize:(Size2i * _Nonnull)patternSize centers:(Mat * _Nonnull)centers flags:(int)flags parameters:(CirclesGridFinderParameters * _Nonnull)parameters __attribute__((swift_name("findCirclesGrid(image:patternSize:centers:flags:parameters:)")));
		[Static]
		[Export ("findCirclesGrid:patternSize:centers:flags:parameters:")]
		bool FindCirclesGrid (Mat image, Size2i patternSize, Mat centers, int flags, CirclesGridFinderParameters parameters);

		// +(BOOL)findCirclesGrid:(Mat * _Nonnull)image patternSize:(Size2i * _Nonnull)patternSize centers:(Mat * _Nonnull)centers flags:(int)flags __attribute__((swift_name("findCirclesGrid(image:patternSize:centers:flags:)")));
		[Static]
		[Export ("findCirclesGrid:patternSize:centers:flags:")]
		bool FindCirclesGrid (Mat image, Size2i patternSize, Mat centers, int flags);

		// +(BOOL)findCirclesGrid:(Mat * _Nonnull)image patternSize:(Size2i * _Nonnull)patternSize centers:(Mat * _Nonnull)centers __attribute__((swift_name("findCirclesGrid(image:patternSize:centers:)")));
		[Static]
		[Export ("findCirclesGrid:patternSize:centers:")]
		bool FindCirclesGrid (Mat image, Size2i patternSize, Mat centers);

		// +(double)calibrateCameraExtended:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints imageSize:(Size2i * _Nonnull)imageSize cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs stdDeviationsIntrinsics:(Mat * _Nonnull)stdDeviationsIntrinsics stdDeviationsExtrinsics:(Mat * _Nonnull)stdDeviationsExtrinsics perViewErrors:(Mat * _Nonnull)perViewErrors flags:(int)flags criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("calibrateCamera(objectPoints:imagePoints:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:stdDeviationsIntrinsics:stdDeviationsExtrinsics:perViewErrors:flags:criteria:)")));
		[Static]
		[Export ("calibrateCameraExtended:imagePoints:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:stdDeviationsIntrinsics:stdDeviationsExtrinsics:perViewErrors:flags:criteria:")]
		double CalibrateCameraExtended (Mat[] objectPoints, Mat[] imagePoints, Size2i imageSize, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors, int flags, TermCriteria criteria);

		// +(double)calibrateCameraExtended:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints imageSize:(Size2i * _Nonnull)imageSize cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs stdDeviationsIntrinsics:(Mat * _Nonnull)stdDeviationsIntrinsics stdDeviationsExtrinsics:(Mat * _Nonnull)stdDeviationsExtrinsics perViewErrors:(Mat * _Nonnull)perViewErrors flags:(int)flags __attribute__((swift_name("calibrateCamera(objectPoints:imagePoints:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:stdDeviationsIntrinsics:stdDeviationsExtrinsics:perViewErrors:flags:)")));
		[Static]
		[Export ("calibrateCameraExtended:imagePoints:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:stdDeviationsIntrinsics:stdDeviationsExtrinsics:perViewErrors:flags:")]
		double CalibrateCameraExtended (Mat[] objectPoints, Mat[] imagePoints, Size2i imageSize, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors, int flags);

		// +(double)calibrateCameraExtended:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints imageSize:(Size2i * _Nonnull)imageSize cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs stdDeviationsIntrinsics:(Mat * _Nonnull)stdDeviationsIntrinsics stdDeviationsExtrinsics:(Mat * _Nonnull)stdDeviationsExtrinsics perViewErrors:(Mat * _Nonnull)perViewErrors __attribute__((swift_name("calibrateCamera(objectPoints:imagePoints:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:stdDeviationsIntrinsics:stdDeviationsExtrinsics:perViewErrors:)")));
		[Static]
		[Export ("calibrateCameraExtended:imagePoints:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:stdDeviationsIntrinsics:stdDeviationsExtrinsics:perViewErrors:")]
		double CalibrateCameraExtended (Mat[] objectPoints, Mat[] imagePoints, Size2i imageSize, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors);

		// +(double)calibrateCamera:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints imageSize:(Size2i * _Nonnull)imageSize cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs flags:(int)flags criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("calibrateCamera(objectPoints:imagePoints:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:flags:criteria:)")));
		[Static]
		[Export ("calibrateCamera:imagePoints:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:flags:criteria:")]
		double CalibrateCamera (Mat[] objectPoints, Mat[] imagePoints, Size2i imageSize, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, int flags, TermCriteria criteria);

		// +(double)calibrateCamera:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints imageSize:(Size2i * _Nonnull)imageSize cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs flags:(int)flags __attribute__((swift_name("calibrateCamera(objectPoints:imagePoints:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:flags:)")));
		[Static]
		[Export ("calibrateCamera:imagePoints:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:flags:")]
		double CalibrateCamera (Mat[] objectPoints, Mat[] imagePoints, Size2i imageSize, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, int flags);

		// +(double)calibrateCamera:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints imageSize:(Size2i * _Nonnull)imageSize cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs __attribute__((swift_name("calibrateCamera(objectPoints:imagePoints:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:)")));
		[Static]
		[Export ("calibrateCamera:imagePoints:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:")]
		double CalibrateCamera (Mat[] objectPoints, Mat[] imagePoints, Size2i imageSize, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs);

		// +(double)calibrateCameraROExtended:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints imageSize:(Size2i * _Nonnull)imageSize iFixedPoint:(int)iFixedPoint cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs newObjPoints:(Mat * _Nonnull)newObjPoints stdDeviationsIntrinsics:(Mat * _Nonnull)stdDeviationsIntrinsics stdDeviationsExtrinsics:(Mat * _Nonnull)stdDeviationsExtrinsics stdDeviationsObjPoints:(Mat * _Nonnull)stdDeviationsObjPoints perViewErrors:(Mat * _Nonnull)perViewErrors flags:(int)flags criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("calibrateCameraRO(objectPoints:imagePoints:imageSize:iFixedPoint:cameraMatrix:distCoeffs:rvecs:tvecs:newObjPoints:stdDeviationsIntrinsics:stdDeviationsExtrinsics:stdDeviationsObjPoints:perViewErrors:flags:criteria:)")));
		[Static]
		[Export ("calibrateCameraROExtended:imagePoints:imageSize:iFixedPoint:cameraMatrix:distCoeffs:rvecs:tvecs:newObjPoints:stdDeviationsIntrinsics:stdDeviationsExtrinsics:stdDeviationsObjPoints:perViewErrors:flags:criteria:")]
		double CalibrateCameraROExtended (Mat[] objectPoints, Mat[] imagePoints, Size2i imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, Mat newObjPoints, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat stdDeviationsObjPoints, Mat perViewErrors, int flags, TermCriteria criteria);

		// +(double)calibrateCameraROExtended:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints imageSize:(Size2i * _Nonnull)imageSize iFixedPoint:(int)iFixedPoint cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs newObjPoints:(Mat * _Nonnull)newObjPoints stdDeviationsIntrinsics:(Mat * _Nonnull)stdDeviationsIntrinsics stdDeviationsExtrinsics:(Mat * _Nonnull)stdDeviationsExtrinsics stdDeviationsObjPoints:(Mat * _Nonnull)stdDeviationsObjPoints perViewErrors:(Mat * _Nonnull)perViewErrors flags:(int)flags __attribute__((swift_name("calibrateCameraRO(objectPoints:imagePoints:imageSize:iFixedPoint:cameraMatrix:distCoeffs:rvecs:tvecs:newObjPoints:stdDeviationsIntrinsics:stdDeviationsExtrinsics:stdDeviationsObjPoints:perViewErrors:flags:)")));
		[Static]
		[Export ("calibrateCameraROExtended:imagePoints:imageSize:iFixedPoint:cameraMatrix:distCoeffs:rvecs:tvecs:newObjPoints:stdDeviationsIntrinsics:stdDeviationsExtrinsics:stdDeviationsObjPoints:perViewErrors:flags:")]
		double CalibrateCameraROExtended (Mat[] objectPoints, Mat[] imagePoints, Size2i imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, Mat newObjPoints, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat stdDeviationsObjPoints, Mat perViewErrors, int flags);

		// +(double)calibrateCameraROExtended:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints imageSize:(Size2i * _Nonnull)imageSize iFixedPoint:(int)iFixedPoint cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs newObjPoints:(Mat * _Nonnull)newObjPoints stdDeviationsIntrinsics:(Mat * _Nonnull)stdDeviationsIntrinsics stdDeviationsExtrinsics:(Mat * _Nonnull)stdDeviationsExtrinsics stdDeviationsObjPoints:(Mat * _Nonnull)stdDeviationsObjPoints perViewErrors:(Mat * _Nonnull)perViewErrors __attribute__((swift_name("calibrateCameraRO(objectPoints:imagePoints:imageSize:iFixedPoint:cameraMatrix:distCoeffs:rvecs:tvecs:newObjPoints:stdDeviationsIntrinsics:stdDeviationsExtrinsics:stdDeviationsObjPoints:perViewErrors:)")));
		[Static]
		[Export ("calibrateCameraROExtended:imagePoints:imageSize:iFixedPoint:cameraMatrix:distCoeffs:rvecs:tvecs:newObjPoints:stdDeviationsIntrinsics:stdDeviationsExtrinsics:stdDeviationsObjPoints:perViewErrors:")]
		double CalibrateCameraROExtended (Mat[] objectPoints, Mat[] imagePoints, Size2i imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, Mat newObjPoints, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat stdDeviationsObjPoints, Mat perViewErrors);

		// +(double)calibrateCameraRO:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints imageSize:(Size2i * _Nonnull)imageSize iFixedPoint:(int)iFixedPoint cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs newObjPoints:(Mat * _Nonnull)newObjPoints flags:(int)flags criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("calibrateCameraRO(objectPoints:imagePoints:imageSize:iFixedPoint:cameraMatrix:distCoeffs:rvecs:tvecs:newObjPoints:flags:criteria:)")));
		[Static]
		[Export ("calibrateCameraRO:imagePoints:imageSize:iFixedPoint:cameraMatrix:distCoeffs:rvecs:tvecs:newObjPoints:flags:criteria:")]
		double CalibrateCameraRO (Mat[] objectPoints, Mat[] imagePoints, Size2i imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, Mat newObjPoints, int flags, TermCriteria criteria);

		// +(double)calibrateCameraRO:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints imageSize:(Size2i * _Nonnull)imageSize iFixedPoint:(int)iFixedPoint cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs newObjPoints:(Mat * _Nonnull)newObjPoints flags:(int)flags __attribute__((swift_name("calibrateCameraRO(objectPoints:imagePoints:imageSize:iFixedPoint:cameraMatrix:distCoeffs:rvecs:tvecs:newObjPoints:flags:)")));
		[Static]
		[Export ("calibrateCameraRO:imagePoints:imageSize:iFixedPoint:cameraMatrix:distCoeffs:rvecs:tvecs:newObjPoints:flags:")]
		double CalibrateCameraRO (Mat[] objectPoints, Mat[] imagePoints, Size2i imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, Mat newObjPoints, int flags);

		// +(double)calibrateCameraRO:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints imageSize:(Size2i * _Nonnull)imageSize iFixedPoint:(int)iFixedPoint cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs newObjPoints:(Mat * _Nonnull)newObjPoints __attribute__((swift_name("calibrateCameraRO(objectPoints:imagePoints:imageSize:iFixedPoint:cameraMatrix:distCoeffs:rvecs:tvecs:newObjPoints:)")));
		[Static]
		[Export ("calibrateCameraRO:imagePoints:imageSize:iFixedPoint:cameraMatrix:distCoeffs:rvecs:tvecs:newObjPoints:")]
		double CalibrateCameraRO (Mat[] objectPoints, Mat[] imagePoints, Size2i imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, Mat newObjPoints);

		// +(void)calibrationMatrixValues:(Mat * _Nonnull)cameraMatrix imageSize:(Size2i * _Nonnull)imageSize apertureWidth:(double)apertureWidth apertureHeight:(double)apertureHeight fovx:(double * _Nonnull)fovx fovy:(double * _Nonnull)fovy focalLength:(double * _Nonnull)focalLength principalPoint:(Point2d * _Nonnull)principalPoint aspectRatio:(double * _Nonnull)aspectRatio __attribute__((swift_name("calibrationMatrixValues(cameraMatrix:imageSize:apertureWidth:apertureHeight:fovx:fovy:focalLength:principalPoint:aspectRatio:)")));
		[Static]
		[Export ("calibrationMatrixValues:imageSize:apertureWidth:apertureHeight:fovx:fovy:focalLength:principalPoint:aspectRatio:")]
		unsafe void CalibrationMatrixValues (Mat cameraMatrix, Size2i imageSize, double apertureWidth, double apertureHeight, double* fovx, double* fovy, double* focalLength, Point2d principalPoint, double* aspectRatio);

		// +(double)stereoCalibrateExtended:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T E:(Mat * _Nonnull)E F:(Mat * _Nonnull)F rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs perViewErrors:(Mat * _Nonnull)perViewErrors flags:(int)flags criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("stereoCalibrate(objectPoints:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:rvecs:tvecs:perViewErrors:flags:criteria:)")));
		[Static]
		[Export ("stereoCalibrateExtended:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:rvecs:tvecs:perViewErrors:flags:criteria:")]
		double StereoCalibrateExtended (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat E, Mat F, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, Mat perViewErrors, int flags, TermCriteria criteria);

		// +(double)stereoCalibrateExtended:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T E:(Mat * _Nonnull)E F:(Mat * _Nonnull)F rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs perViewErrors:(Mat * _Nonnull)perViewErrors flags:(int)flags __attribute__((swift_name("stereoCalibrate(objectPoints:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:rvecs:tvecs:perViewErrors:flags:)")));
		[Static]
		[Export ("stereoCalibrateExtended:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:rvecs:tvecs:perViewErrors:flags:")]
		double StereoCalibrateExtended (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat E, Mat F, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, Mat perViewErrors, int flags);

		// +(double)stereoCalibrateExtended:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T E:(Mat * _Nonnull)E F:(Mat * _Nonnull)F rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs perViewErrors:(Mat * _Nonnull)perViewErrors __attribute__((swift_name("stereoCalibrate(objectPoints:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:rvecs:tvecs:perViewErrors:)")));
		[Static]
		[Export ("stereoCalibrateExtended:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:rvecs:tvecs:perViewErrors:")]
		double StereoCalibrateExtended (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat E, Mat F, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, Mat perViewErrors);

		// +(double)stereoCalibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T E:(Mat * _Nonnull)E F:(Mat * _Nonnull)F flags:(int)flags criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("stereoCalibrate(objectPoints:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:flags:criteria:)")));
		[Static]
		[Export ("stereoCalibrate:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:flags:criteria:")]
		double StereoCalibrate (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat E, Mat F, int flags, TermCriteria criteria);

		// +(double)stereoCalibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T E:(Mat * _Nonnull)E F:(Mat * _Nonnull)F flags:(int)flags __attribute__((swift_name("stereoCalibrate(objectPoints:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:flags:)")));
		[Static]
		[Export ("stereoCalibrate:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:flags:")]
		double StereoCalibrate (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat E, Mat F, int flags);

		// +(double)stereoCalibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T E:(Mat * _Nonnull)E F:(Mat * _Nonnull)F __attribute__((swift_name("stereoCalibrate(objectPoints:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:)")));
		[Static]
		[Export ("stereoCalibrate:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:")]
		double StereoCalibrate (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat E, Mat F);

		// +(double)stereoCalibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T E:(Mat * _Nonnull)E F:(Mat * _Nonnull)F perViewErrors:(Mat * _Nonnull)perViewErrors flags:(int)flags criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("stereoCalibrate(objectPoints:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:perViewErrors:flags:criteria:)")));
		[Static]
		[Export ("stereoCalibrate:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:perViewErrors:flags:criteria:")]
		double StereoCalibrate (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat E, Mat F, Mat perViewErrors, int flags, TermCriteria criteria);

		// +(double)stereoCalibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T E:(Mat * _Nonnull)E F:(Mat * _Nonnull)F perViewErrors:(Mat * _Nonnull)perViewErrors flags:(int)flags __attribute__((swift_name("stereoCalibrate(objectPoints:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:perViewErrors:flags:)")));
		[Static]
		[Export ("stereoCalibrate:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:perViewErrors:flags:")]
		double StereoCalibrate (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat E, Mat F, Mat perViewErrors, int flags);

		// +(double)stereoCalibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T E:(Mat * _Nonnull)E F:(Mat * _Nonnull)F perViewErrors:(Mat * _Nonnull)perViewErrors __attribute__((swift_name("stereoCalibrate(objectPoints:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:perViewErrors:)")));
		[Static]
		[Export ("stereoCalibrate:imagePoints1:imagePoints2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:E:F:perViewErrors:")]
		double StereoCalibrate (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat E, Mat F, Mat perViewErrors);

		// +(void)stereoRectify:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T R1:(Mat * _Nonnull)R1 R2:(Mat * _Nonnull)R2 P1:(Mat * _Nonnull)P1 P2:(Mat * _Nonnull)P2 Q:(Mat * _Nonnull)Q flags:(int)flags alpha:(double)alpha newImageSize:(Size2i * _Nonnull)newImageSize validPixROI1:(Rect2i * _Nonnull)validPixROI1 validPixROI2:(Rect2i * _Nonnull)validPixROI2 __attribute__((swift_name("stereoRectify(cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:R1:R2:P1:P2:Q:flags:alpha:newImageSize:validPixROI1:validPixROI2:)")));
		[Static]
		[Export ("stereoRectify:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:R1:R2:P1:P2:Q:flags:alpha:newImageSize:validPixROI1:validPixROI2:")]
		void StereoRectify (Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, double alpha, Size2i newImageSize, Rect2i validPixROI1, Rect2i validPixROI2);

		// +(void)stereoRectify:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T R1:(Mat * _Nonnull)R1 R2:(Mat * _Nonnull)R2 P1:(Mat * _Nonnull)P1 P2:(Mat * _Nonnull)P2 Q:(Mat * _Nonnull)Q flags:(int)flags alpha:(double)alpha newImageSize:(Size2i * _Nonnull)newImageSize validPixROI1:(Rect2i * _Nonnull)validPixROI1 __attribute__((swift_name("stereoRectify(cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:R1:R2:P1:P2:Q:flags:alpha:newImageSize:validPixROI1:)")));
		[Static]
		[Export ("stereoRectify:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:R1:R2:P1:P2:Q:flags:alpha:newImageSize:validPixROI1:")]
		void StereoRectify (Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, double alpha, Size2i newImageSize, Rect2i validPixROI1);

		// +(void)stereoRectify:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T R1:(Mat * _Nonnull)R1 R2:(Mat * _Nonnull)R2 P1:(Mat * _Nonnull)P1 P2:(Mat * _Nonnull)P2 Q:(Mat * _Nonnull)Q flags:(int)flags alpha:(double)alpha newImageSize:(Size2i * _Nonnull)newImageSize __attribute__((swift_name("stereoRectify(cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:R1:R2:P1:P2:Q:flags:alpha:newImageSize:)")));
		[Static]
		[Export ("stereoRectify:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:R1:R2:P1:P2:Q:flags:alpha:newImageSize:")]
		void StereoRectify (Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, double alpha, Size2i newImageSize);

		// +(void)stereoRectify:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T R1:(Mat * _Nonnull)R1 R2:(Mat * _Nonnull)R2 P1:(Mat * _Nonnull)P1 P2:(Mat * _Nonnull)P2 Q:(Mat * _Nonnull)Q flags:(int)flags alpha:(double)alpha __attribute__((swift_name("stereoRectify(cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:R1:R2:P1:P2:Q:flags:alpha:)")));
		[Static]
		[Export ("stereoRectify:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:R1:R2:P1:P2:Q:flags:alpha:")]
		void StereoRectify (Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, double alpha);

		// +(void)stereoRectify:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T R1:(Mat * _Nonnull)R1 R2:(Mat * _Nonnull)R2 P1:(Mat * _Nonnull)P1 P2:(Mat * _Nonnull)P2 Q:(Mat * _Nonnull)Q flags:(int)flags __attribute__((swift_name("stereoRectify(cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:R1:R2:P1:P2:Q:flags:)")));
		[Static]
		[Export ("stereoRectify:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:R1:R2:P1:P2:Q:flags:")]
		void StereoRectify (Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags);

		// +(void)stereoRectify:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T R1:(Mat * _Nonnull)R1 R2:(Mat * _Nonnull)R2 P1:(Mat * _Nonnull)P1 P2:(Mat * _Nonnull)P2 Q:(Mat * _Nonnull)Q __attribute__((swift_name("stereoRectify(cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:R1:R2:P1:P2:Q:)")));
		[Static]
		[Export ("stereoRectify:distCoeffs1:cameraMatrix2:distCoeffs2:imageSize:R:T:R1:R2:P1:P2:Q:")]
		void StereoRectify (Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size2i imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q);

		// +(BOOL)stereoRectifyUncalibrated:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 F:(Mat * _Nonnull)F imgSize:(Size2i * _Nonnull)imgSize H1:(Mat * _Nonnull)H1 H2:(Mat * _Nonnull)H2 threshold:(double)threshold __attribute__((swift_name("stereoRectifyUncalibrated(points1:points2:F:imgSize:H1:H2:threshold:)")));
		[Static]
		[Export ("stereoRectifyUncalibrated:points2:F:imgSize:H1:H2:threshold:")]
		bool StereoRectifyUncalibrated (Mat points1, Mat points2, Mat F, Size2i imgSize, Mat H1, Mat H2, double threshold);

		// +(BOOL)stereoRectifyUncalibrated:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 F:(Mat * _Nonnull)F imgSize:(Size2i * _Nonnull)imgSize H1:(Mat * _Nonnull)H1 H2:(Mat * _Nonnull)H2 __attribute__((swift_name("stereoRectifyUncalibrated(points1:points2:F:imgSize:H1:H2:)")));
		[Static]
		[Export ("stereoRectifyUncalibrated:points2:F:imgSize:H1:H2:")]
		bool StereoRectifyUncalibrated (Mat points1, Mat points2, Mat F, Size2i imgSize, Mat H1, Mat H2);

		// +(float)rectify3Collinear:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 cameraMatrix3:(Mat * _Nonnull)cameraMatrix3 distCoeffs3:(Mat * _Nonnull)distCoeffs3 imgpt1:(NSArray<Mat *> * _Nonnull)imgpt1 imgpt3:(NSArray<Mat *> * _Nonnull)imgpt3 imageSize:(Size2i * _Nonnull)imageSize R12:(Mat * _Nonnull)R12 T12:(Mat * _Nonnull)T12 R13:(Mat * _Nonnull)R13 T13:(Mat * _Nonnull)T13 R1:(Mat * _Nonnull)R1 R2:(Mat * _Nonnull)R2 R3:(Mat * _Nonnull)R3 P1:(Mat * _Nonnull)P1 P2:(Mat * _Nonnull)P2 P3:(Mat * _Nonnull)P3 Q:(Mat * _Nonnull)Q alpha:(double)alpha newImgSize:(Size2i * _Nonnull)newImgSize roi1:(Rect2i * _Nonnull)roi1 roi2:(Rect2i * _Nonnull)roi2 flags:(int)flags __attribute__((swift_name("rectify3Collinear(cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:cameraMatrix3:distCoeffs3:imgpt1:imgpt3:imageSize:R12:T12:R13:T13:R1:R2:R3:P1:P2:P3:Q:alpha:newImgSize:roi1:roi2:flags:)")));
		[Static]
		[Export ("rectify3Collinear:distCoeffs1:cameraMatrix2:distCoeffs2:cameraMatrix3:distCoeffs3:imgpt1:imgpt3:imageSize:R12:T12:R13:T13:R1:R2:R3:P1:P2:P3:Q:alpha:newImgSize:roi1:roi2:flags:")]
		float Rectify3Collinear (Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat cameraMatrix3, Mat distCoeffs3, Mat[] imgpt1, Mat[] imgpt3, Size2i imageSize, Mat R12, Mat T12, Mat R13, Mat T13, Mat R1, Mat R2, Mat R3, Mat P1, Mat P2, Mat P3, Mat Q, double alpha, Size2i newImgSize, Rect2i roi1, Rect2i roi2, int flags);

		// +(Mat * _Nonnull)getOptimalNewCameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs imageSize:(Size2i * _Nonnull)imageSize alpha:(double)alpha newImgSize:(Size2i * _Nonnull)newImgSize validPixROI:(Rect2i * _Nonnull)validPixROI centerPrincipalPoint:(BOOL)centerPrincipalPoint __attribute__((swift_name("getOptimalNewCameraMatrix(cameraMatrix:distCoeffs:imageSize:alpha:newImgSize:validPixROI:centerPrincipalPoint:)")));
		[Static]
		[Export ("getOptimalNewCameraMatrix:distCoeffs:imageSize:alpha:newImgSize:validPixROI:centerPrincipalPoint:")]
		Mat GetOptimalNewCameraMatrix (Mat cameraMatrix, Mat distCoeffs, Size2i imageSize, double alpha, Size2i newImgSize, Rect2i validPixROI, bool centerPrincipalPoint);

		// +(Mat * _Nonnull)getOptimalNewCameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs imageSize:(Size2i * _Nonnull)imageSize alpha:(double)alpha newImgSize:(Size2i * _Nonnull)newImgSize validPixROI:(Rect2i * _Nonnull)validPixROI __attribute__((swift_name("getOptimalNewCameraMatrix(cameraMatrix:distCoeffs:imageSize:alpha:newImgSize:validPixROI:)")));
		[Static]
		[Export ("getOptimalNewCameraMatrix:distCoeffs:imageSize:alpha:newImgSize:validPixROI:")]
		Mat GetOptimalNewCameraMatrix (Mat cameraMatrix, Mat distCoeffs, Size2i imageSize, double alpha, Size2i newImgSize, Rect2i validPixROI);

		// +(Mat * _Nonnull)getOptimalNewCameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs imageSize:(Size2i * _Nonnull)imageSize alpha:(double)alpha newImgSize:(Size2i * _Nonnull)newImgSize __attribute__((swift_name("getOptimalNewCameraMatrix(cameraMatrix:distCoeffs:imageSize:alpha:newImgSize:)")));
		[Static]
		[Export ("getOptimalNewCameraMatrix:distCoeffs:imageSize:alpha:newImgSize:")]
		Mat GetOptimalNewCameraMatrix (Mat cameraMatrix, Mat distCoeffs, Size2i imageSize, double alpha, Size2i newImgSize);

		// +(Mat * _Nonnull)getOptimalNewCameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs imageSize:(Size2i * _Nonnull)imageSize alpha:(double)alpha __attribute__((swift_name("getOptimalNewCameraMatrix(cameraMatrix:distCoeffs:imageSize:alpha:)")));
		[Static]
		[Export ("getOptimalNewCameraMatrix:distCoeffs:imageSize:alpha:")]
		Mat GetOptimalNewCameraMatrix (Mat cameraMatrix, Mat distCoeffs, Size2i imageSize, double alpha);

		// +(void)calibrateHandEye:(NSArray<Mat *> * _Nonnull)R_gripper2base t_gripper2base:(NSArray<Mat *> * _Nonnull)t_gripper2base R_target2cam:(NSArray<Mat *> * _Nonnull)R_target2cam t_target2cam:(NSArray<Mat *> * _Nonnull)t_target2cam R_cam2gripper:(Mat * _Nonnull)R_cam2gripper t_cam2gripper:(Mat * _Nonnull)t_cam2gripper method:(HandEyeCalibrationMethod)method __attribute__((swift_name("calibrateHandEye(R_gripper2base:t_gripper2base:R_target2cam:t_target2cam:R_cam2gripper:t_cam2gripper:method:)")));
		[Static]
		[Export ("calibrateHandEye:t_gripper2base:R_target2cam:t_target2cam:R_cam2gripper:t_cam2gripper:method:")]
		void CalibrateHandEye (Mat[] R_gripper2base, Mat[] t_gripper2base, Mat[] R_target2cam, Mat[] t_target2cam, Mat R_cam2gripper, Mat t_cam2gripper, HandEyeCalibrationMethod method);

		// +(void)calibrateHandEye:(NSArray<Mat *> * _Nonnull)R_gripper2base t_gripper2base:(NSArray<Mat *> * _Nonnull)t_gripper2base R_target2cam:(NSArray<Mat *> * _Nonnull)R_target2cam t_target2cam:(NSArray<Mat *> * _Nonnull)t_target2cam R_cam2gripper:(Mat * _Nonnull)R_cam2gripper t_cam2gripper:(Mat * _Nonnull)t_cam2gripper __attribute__((swift_name("calibrateHandEye(R_gripper2base:t_gripper2base:R_target2cam:t_target2cam:R_cam2gripper:t_cam2gripper:)")));
		[Static]
		[Export ("calibrateHandEye:t_gripper2base:R_target2cam:t_target2cam:R_cam2gripper:t_cam2gripper:")]
		void CalibrateHandEye (Mat[] R_gripper2base, Mat[] t_gripper2base, Mat[] R_target2cam, Mat[] t_target2cam, Mat R_cam2gripper, Mat t_cam2gripper);

		// +(void)calibrateRobotWorldHandEye:(NSArray<Mat *> * _Nonnull)R_world2cam t_world2cam:(NSArray<Mat *> * _Nonnull)t_world2cam R_base2gripper:(NSArray<Mat *> * _Nonnull)R_base2gripper t_base2gripper:(NSArray<Mat *> * _Nonnull)t_base2gripper R_base2world:(Mat * _Nonnull)R_base2world t_base2world:(Mat * _Nonnull)t_base2world R_gripper2cam:(Mat * _Nonnull)R_gripper2cam t_gripper2cam:(Mat * _Nonnull)t_gripper2cam method:(RobotWorldHandEyeCalibrationMethod)method __attribute__((swift_name("calibrateRobotWorldHandEye(R_world2cam:t_world2cam:R_base2gripper:t_base2gripper:R_base2world:t_base2world:R_gripper2cam:t_gripper2cam:method:)")));
		[Static]
		[Export ("calibrateRobotWorldHandEye:t_world2cam:R_base2gripper:t_base2gripper:R_base2world:t_base2world:R_gripper2cam:t_gripper2cam:method:")]
		void CalibrateRobotWorldHandEye (Mat[] R_world2cam, Mat[] t_world2cam, Mat[] R_base2gripper, Mat[] t_base2gripper, Mat R_base2world, Mat t_base2world, Mat R_gripper2cam, Mat t_gripper2cam, RobotWorldHandEyeCalibrationMethod method);

		// +(void)calibrateRobotWorldHandEye:(NSArray<Mat *> * _Nonnull)R_world2cam t_world2cam:(NSArray<Mat *> * _Nonnull)t_world2cam R_base2gripper:(NSArray<Mat *> * _Nonnull)R_base2gripper t_base2gripper:(NSArray<Mat *> * _Nonnull)t_base2gripper R_base2world:(Mat * _Nonnull)R_base2world t_base2world:(Mat * _Nonnull)t_base2world R_gripper2cam:(Mat * _Nonnull)R_gripper2cam t_gripper2cam:(Mat * _Nonnull)t_gripper2cam __attribute__((swift_name("calibrateRobotWorldHandEye(R_world2cam:t_world2cam:R_base2gripper:t_base2gripper:R_base2world:t_base2world:R_gripper2cam:t_gripper2cam:)")));
		[Static]
		[Export ("calibrateRobotWorldHandEye:t_world2cam:R_base2gripper:t_base2gripper:R_base2world:t_base2world:R_gripper2cam:t_gripper2cam:")]
		void CalibrateRobotWorldHandEye (Mat[] R_world2cam, Mat[] t_world2cam, Mat[] R_base2gripper, Mat[] t_base2gripper, Mat R_base2world, Mat t_base2world, Mat R_gripper2cam, Mat t_gripper2cam);

		// +(void)convertPointsToHomogeneous:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("convertPointsToHomogeneous(src:dst:)")));
		[Static]
		[Export ("convertPointsToHomogeneous:dst:")]
		void ConvertPointsToHomogeneous (Mat src, Mat dst);

		// +(void)convertPointsFromHomogeneous:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("convertPointsFromHomogeneous(src:dst:)")));
		[Static]
		[Export ("convertPointsFromHomogeneous:dst:")]
		void ConvertPointsFromHomogeneous (Mat src, Mat dst);

		// +(Mat * _Nonnull)findFundamentalMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold confidence:(double)confidence maxIters:(int)maxIters mask:(Mat * _Nonnull)mask __attribute__((swift_name("findFundamentalMat(points1:points2:method:ransacReprojThreshold:confidence:maxIters:mask:)")));
		[Static]
		[Export ("findFundamentalMat:points2:method:ransacReprojThreshold:confidence:maxIters:mask:")]
		Mat FindFundamentalMat (Mat points1, Mat points2, int method, double ransacReprojThreshold, double confidence, int maxIters, Mat mask);

		// +(Mat * _Nonnull)findFundamentalMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold confidence:(double)confidence maxIters:(int)maxIters __attribute__((swift_name("findFundamentalMat(points1:points2:method:ransacReprojThreshold:confidence:maxIters:)")));
		[Static]
		[Export ("findFundamentalMat:points2:method:ransacReprojThreshold:confidence:maxIters:")]
		Mat FindFundamentalMat (Mat points1, Mat points2, int method, double ransacReprojThreshold, double confidence, int maxIters);

		// +(Mat * _Nonnull)findFundamentalMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold confidence:(double)confidence mask:(Mat * _Nonnull)mask __attribute__((swift_name("findFundamentalMat(points1:points2:method:ransacReprojThreshold:confidence:mask:)")));
		[Static]
		[Export ("findFundamentalMat:points2:method:ransacReprojThreshold:confidence:mask:")]
		Mat FindFundamentalMat (Mat points1, Mat points2, int method, double ransacReprojThreshold, double confidence, Mat mask);

		// +(Mat * _Nonnull)findFundamentalMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold confidence:(double)confidence __attribute__((swift_name("findFundamentalMat(points1:points2:method:ransacReprojThreshold:confidence:)")));
		[Static]
		[Export ("findFundamentalMat:points2:method:ransacReprojThreshold:confidence:")]
		Mat FindFundamentalMat (Mat points1, Mat points2, int method, double ransacReprojThreshold, double confidence);

		// +(Mat * _Nonnull)findFundamentalMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold __attribute__((swift_name("findFundamentalMat(points1:points2:method:ransacReprojThreshold:)")));
		[Static]
		[Export ("findFundamentalMat:points2:method:ransacReprojThreshold:")]
		Mat FindFundamentalMat (Mat points1, Mat points2, int method, double ransacReprojThreshold);

		// +(Mat * _Nonnull)findFundamentalMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 method:(int)method __attribute__((swift_name("findFundamentalMat(points1:points2:method:)")));
		[Static]
		[Export ("findFundamentalMat:points2:method:")]
		Mat FindFundamentalMat (Mat points1, Mat points2, int method);

		// +(Mat * _Nonnull)findFundamentalMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 __attribute__((swift_name("findFundamentalMat(points1:points2:)")));
		[Static]
		[Export ("findFundamentalMat:points2:")]
		Mat FindFundamentalMat (Mat points1, Mat points2);

		// +(Mat * _Nonnull)findFundamentalMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 mask:(Mat * _Nonnull)mask params:(UsacParams * _Nonnull)params __attribute__((swift_name("findFundamentalMat(points1:points2:mask:params:)")));
		[Static]
		[Export ("findFundamentalMat:points2:mask:params:")]
		Mat FindFundamentalMat (Mat points1, Mat points2, Mat mask, UsacParams @params);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix:(Mat * _Nonnull)cameraMatrix method:(int)method prob:(double)prob threshold:(double)threshold maxIters:(int)maxIters mask:(Mat * _Nonnull)mask __attribute__((swift_name("findEssentialMat(points1:points2:cameraMatrix:method:prob:threshold:maxIters:mask:)")));
		[Static]
		[Export ("findEssentialMat:points2:cameraMatrix:method:prob:threshold:maxIters:mask:")]
		Mat FindEssentialMat (Mat points1, Mat points2, Mat cameraMatrix, int method, double prob, double threshold, int maxIters, Mat mask);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix:(Mat * _Nonnull)cameraMatrix method:(int)method prob:(double)prob threshold:(double)threshold maxIters:(int)maxIters __attribute__((swift_name("findEssentialMat(points1:points2:cameraMatrix:method:prob:threshold:maxIters:)")));
		[Static]
		[Export ("findEssentialMat:points2:cameraMatrix:method:prob:threshold:maxIters:")]
		Mat FindEssentialMat (Mat points1, Mat points2, Mat cameraMatrix, int method, double prob, double threshold, int maxIters);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix:(Mat * _Nonnull)cameraMatrix method:(int)method prob:(double)prob threshold:(double)threshold __attribute__((swift_name("findEssentialMat(points1:points2:cameraMatrix:method:prob:threshold:)")));
		[Static]
		[Export ("findEssentialMat:points2:cameraMatrix:method:prob:threshold:")]
		Mat FindEssentialMat (Mat points1, Mat points2, Mat cameraMatrix, int method, double prob, double threshold);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix:(Mat * _Nonnull)cameraMatrix method:(int)method prob:(double)prob __attribute__((swift_name("findEssentialMat(points1:points2:cameraMatrix:method:prob:)")));
		[Static]
		[Export ("findEssentialMat:points2:cameraMatrix:method:prob:")]
		Mat FindEssentialMat (Mat points1, Mat points2, Mat cameraMatrix, int method, double prob);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix:(Mat * _Nonnull)cameraMatrix method:(int)method __attribute__((swift_name("findEssentialMat(points1:points2:cameraMatrix:method:)")));
		[Static]
		[Export ("findEssentialMat:points2:cameraMatrix:method:")]
		Mat FindEssentialMat (Mat points1, Mat points2, Mat cameraMatrix, int method);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix:(Mat * _Nonnull)cameraMatrix __attribute__((swift_name("findEssentialMat(points1:points2:cameraMatrix:)")));
		[Static]
		[Export ("findEssentialMat:points2:cameraMatrix:")]
		Mat FindEssentialMat (Mat points1, Mat points2, Mat cameraMatrix);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 focal:(double)focal pp:(Point2d * _Nonnull)pp method:(int)method prob:(double)prob threshold:(double)threshold maxIters:(int)maxIters mask:(Mat * _Nonnull)mask __attribute__((swift_name("findEssentialMat(points1:points2:focal:pp:method:prob:threshold:maxIters:mask:)")));
		[Static]
		[Export ("findEssentialMat:points2:focal:pp:method:prob:threshold:maxIters:mask:")]
		Mat FindEssentialMat (Mat points1, Mat points2, double focal, Point2d pp, int method, double prob, double threshold, int maxIters, Mat mask);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 focal:(double)focal pp:(Point2d * _Nonnull)pp method:(int)method prob:(double)prob threshold:(double)threshold maxIters:(int)maxIters __attribute__((swift_name("findEssentialMat(points1:points2:focal:pp:method:prob:threshold:maxIters:)")));
		[Static]
		[Export ("findEssentialMat:points2:focal:pp:method:prob:threshold:maxIters:")]
		Mat FindEssentialMat (Mat points1, Mat points2, double focal, Point2d pp, int method, double prob, double threshold, int maxIters);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 focal:(double)focal pp:(Point2d * _Nonnull)pp method:(int)method prob:(double)prob threshold:(double)threshold __attribute__((swift_name("findEssentialMat(points1:points2:focal:pp:method:prob:threshold:)")));
		[Static]
		[Export ("findEssentialMat:points2:focal:pp:method:prob:threshold:")]
		Mat FindEssentialMat (Mat points1, Mat points2, double focal, Point2d pp, int method, double prob, double threshold);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 focal:(double)focal pp:(Point2d * _Nonnull)pp method:(int)method prob:(double)prob __attribute__((swift_name("findEssentialMat(points1:points2:focal:pp:method:prob:)")));
		[Static]
		[Export ("findEssentialMat:points2:focal:pp:method:prob:")]
		Mat FindEssentialMat (Mat points1, Mat points2, double focal, Point2d pp, int method, double prob);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 focal:(double)focal pp:(Point2d * _Nonnull)pp method:(int)method __attribute__((swift_name("findEssentialMat(points1:points2:focal:pp:method:)")));
		[Static]
		[Export ("findEssentialMat:points2:focal:pp:method:")]
		Mat FindEssentialMat (Mat points1, Mat points2, double focal, Point2d pp, int method);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 focal:(double)focal pp:(Point2d * _Nonnull)pp __attribute__((swift_name("findEssentialMat(points1:points2:focal:pp:)")));
		[Static]
		[Export ("findEssentialMat:points2:focal:pp:")]
		Mat FindEssentialMat (Mat points1, Mat points2, double focal, Point2d pp);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 focal:(double)focal __attribute__((swift_name("findEssentialMat(points1:points2:focal:)")));
		[Static]
		[Export ("findEssentialMat:points2:focal:")]
		Mat FindEssentialMat (Mat points1, Mat points2, double focal);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 __attribute__((swift_name("findEssentialMat(points1:points2:)")));
		[Static]
		[Export ("findEssentialMat:points2:")]
		Mat FindEssentialMat (Mat points1, Mat points2);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 method:(int)method prob:(double)prob threshold:(double)threshold mask:(Mat * _Nonnull)mask __attribute__((swift_name("findEssentialMat(points1:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:method:prob:threshold:mask:)")));
		[Static]
		[Export ("findEssentialMat:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:method:prob:threshold:mask:")]
		Mat FindEssentialMat (Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, int method, double prob, double threshold, Mat mask);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 method:(int)method prob:(double)prob threshold:(double)threshold __attribute__((swift_name("findEssentialMat(points1:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:method:prob:threshold:)")));
		[Static]
		[Export ("findEssentialMat:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:method:prob:threshold:")]
		Mat FindEssentialMat (Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, int method, double prob, double threshold);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 method:(int)method prob:(double)prob __attribute__((swift_name("findEssentialMat(points1:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:method:prob:)")));
		[Static]
		[Export ("findEssentialMat:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:method:prob:")]
		Mat FindEssentialMat (Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, int method, double prob);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 method:(int)method __attribute__((swift_name("findEssentialMat(points1:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:method:)")));
		[Static]
		[Export ("findEssentialMat:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:method:")]
		Mat FindEssentialMat (Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, int method);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 __attribute__((swift_name("findEssentialMat(points1:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:)")));
		[Static]
		[Export ("findEssentialMat:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:")]
		Mat FindEssentialMat (Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2);

		// +(Mat * _Nonnull)findEssentialMat:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 dist_coeff1:(Mat * _Nonnull)dist_coeff1 dist_coeff2:(Mat * _Nonnull)dist_coeff2 mask:(Mat * _Nonnull)mask params:(UsacParams * _Nonnull)params __attribute__((swift_name("findEssentialMat(points1:points2:cameraMatrix1:cameraMatrix2:dist_coeff1:dist_coeff2:mask:params:)")));
		[Static]
		[Export ("findEssentialMat:points2:cameraMatrix1:cameraMatrix2:dist_coeff1:dist_coeff2:mask:params:")]
		Mat FindEssentialMat (Mat points1, Mat points2, Mat cameraMatrix1, Mat cameraMatrix2, Mat dist_coeff1, Mat dist_coeff2, Mat mask, UsacParams @params);

		// +(void)decomposeEssentialMat:(Mat * _Nonnull)E R1:(Mat * _Nonnull)R1 R2:(Mat * _Nonnull)R2 t:(Mat * _Nonnull)t __attribute__((swift_name("decomposeEssentialMat(E:R1:R2:t:)")));
		[Static]
		[Export ("decomposeEssentialMat:R1:R2:t:")]
		void DecomposeEssentialMat (Mat E, Mat R1, Mat R2, Mat t);

		// +(int)recoverPose:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 E:(Mat * _Nonnull)E R:(Mat * _Nonnull)R t:(Mat * _Nonnull)t method:(int)method prob:(double)prob threshold:(double)threshold mask:(Mat * _Nonnull)mask __attribute__((swift_name("recoverPose(points1:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:E:R:t:method:prob:threshold:mask:)")));
		[Static]
		[Export ("recoverPose:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:E:R:t:method:prob:threshold:mask:")]
		int RecoverPose (Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat E, Mat R, Mat t, int method, double prob, double threshold, Mat mask);

		// +(int)recoverPose:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 E:(Mat * _Nonnull)E R:(Mat * _Nonnull)R t:(Mat * _Nonnull)t method:(int)method prob:(double)prob threshold:(double)threshold __attribute__((swift_name("recoverPose(points1:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:E:R:t:method:prob:threshold:)")));
		[Static]
		[Export ("recoverPose:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:E:R:t:method:prob:threshold:")]
		int RecoverPose (Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat E, Mat R, Mat t, int method, double prob, double threshold);

		// +(int)recoverPose:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 E:(Mat * _Nonnull)E R:(Mat * _Nonnull)R t:(Mat * _Nonnull)t method:(int)method prob:(double)prob __attribute__((swift_name("recoverPose(points1:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:E:R:t:method:prob:)")));
		[Static]
		[Export ("recoverPose:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:E:R:t:method:prob:")]
		int RecoverPose (Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat E, Mat R, Mat t, int method, double prob);

		// +(int)recoverPose:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 E:(Mat * _Nonnull)E R:(Mat * _Nonnull)R t:(Mat * _Nonnull)t method:(int)method __attribute__((swift_name("recoverPose(points1:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:E:R:t:method:)")));
		[Static]
		[Export ("recoverPose:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:E:R:t:method:")]
		int RecoverPose (Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat E, Mat R, Mat t, int method);

		// +(int)recoverPose:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix1:(Mat * _Nonnull)cameraMatrix1 distCoeffs1:(Mat * _Nonnull)distCoeffs1 cameraMatrix2:(Mat * _Nonnull)cameraMatrix2 distCoeffs2:(Mat * _Nonnull)distCoeffs2 E:(Mat * _Nonnull)E R:(Mat * _Nonnull)R t:(Mat * _Nonnull)t __attribute__((swift_name("recoverPose(points1:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:E:R:t:)")));
		[Static]
		[Export ("recoverPose:points2:cameraMatrix1:distCoeffs1:cameraMatrix2:distCoeffs2:E:R:t:")]
		int RecoverPose (Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat E, Mat R, Mat t);

		// +(int)recoverPose:(Mat * _Nonnull)E points1:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix:(Mat * _Nonnull)cameraMatrix R:(Mat * _Nonnull)R t:(Mat * _Nonnull)t mask:(Mat * _Nonnull)mask __attribute__((swift_name("recoverPose(E:points1:points2:cameraMatrix:R:t:mask:)")));
		[Static]
		[Export ("recoverPose:points1:points2:cameraMatrix:R:t:mask:")]
		int RecoverPose (Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t, Mat mask);

		// +(int)recoverPose:(Mat * _Nonnull)E points1:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix:(Mat * _Nonnull)cameraMatrix R:(Mat * _Nonnull)R t:(Mat * _Nonnull)t __attribute__((swift_name("recoverPose(E:points1:points2:cameraMatrix:R:t:)")));
		[Static]
		[Export ("recoverPose:points1:points2:cameraMatrix:R:t:")]
		int RecoverPose (Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t);

		// +(int)recoverPose:(Mat * _Nonnull)E points1:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 R:(Mat * _Nonnull)R t:(Mat * _Nonnull)t focal:(double)focal pp:(Point2d * _Nonnull)pp mask:(Mat * _Nonnull)mask __attribute__((swift_name("recoverPose(E:points1:points2:R:t:focal:pp:mask:)")));
		[Static]
		[Export ("recoverPose:points1:points2:R:t:focal:pp:mask:")]
		int RecoverPose (Mat E, Mat points1, Mat points2, Mat R, Mat t, double focal, Point2d pp, Mat mask);

		// +(int)recoverPose:(Mat * _Nonnull)E points1:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 R:(Mat * _Nonnull)R t:(Mat * _Nonnull)t focal:(double)focal pp:(Point2d * _Nonnull)pp __attribute__((swift_name("recoverPose(E:points1:points2:R:t:focal:pp:)")));
		[Static]
		[Export ("recoverPose:points1:points2:R:t:focal:pp:")]
		int RecoverPose (Mat E, Mat points1, Mat points2, Mat R, Mat t, double focal, Point2d pp);

		// +(int)recoverPose:(Mat * _Nonnull)E points1:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 R:(Mat * _Nonnull)R t:(Mat * _Nonnull)t focal:(double)focal __attribute__((swift_name("recoverPose(E:points1:points2:R:t:focal:)")));
		[Static]
		[Export ("recoverPose:points1:points2:R:t:focal:")]
		int RecoverPose (Mat E, Mat points1, Mat points2, Mat R, Mat t, double focal);

		// +(int)recoverPose:(Mat * _Nonnull)E points1:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 R:(Mat * _Nonnull)R t:(Mat * _Nonnull)t __attribute__((swift_name("recoverPose(E:points1:points2:R:t:)")));
		[Static]
		[Export ("recoverPose:points1:points2:R:t:")]
		int RecoverPose (Mat E, Mat points1, Mat points2, Mat R, Mat t);

		// +(int)recoverPose:(Mat * _Nonnull)E points1:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix:(Mat * _Nonnull)cameraMatrix R:(Mat * _Nonnull)R t:(Mat * _Nonnull)t distanceThresh:(double)distanceThresh mask:(Mat * _Nonnull)mask triangulatedPoints:(Mat * _Nonnull)triangulatedPoints __attribute__((swift_name("recoverPose(E:points1:points2:cameraMatrix:R:t:distanceThresh:mask:triangulatedPoints:)")));
		[Static]
		[Export ("recoverPose:points1:points2:cameraMatrix:R:t:distanceThresh:mask:triangulatedPoints:")]
		int RecoverPose (Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t, double distanceThresh, Mat mask, Mat triangulatedPoints);

		// +(int)recoverPose:(Mat * _Nonnull)E points1:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix:(Mat * _Nonnull)cameraMatrix R:(Mat * _Nonnull)R t:(Mat * _Nonnull)t distanceThresh:(double)distanceThresh mask:(Mat * _Nonnull)mask __attribute__((swift_name("recoverPose(E:points1:points2:cameraMatrix:R:t:distanceThresh:mask:)")));
		[Static]
		[Export ("recoverPose:points1:points2:cameraMatrix:R:t:distanceThresh:mask:")]
		int RecoverPose (Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t, double distanceThresh, Mat mask);

		// +(int)recoverPose:(Mat * _Nonnull)E points1:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 cameraMatrix:(Mat * _Nonnull)cameraMatrix R:(Mat * _Nonnull)R t:(Mat * _Nonnull)t distanceThresh:(double)distanceThresh __attribute__((swift_name("recoverPose(E:points1:points2:cameraMatrix:R:t:distanceThresh:)")));
		[Static]
		[Export ("recoverPose:points1:points2:cameraMatrix:R:t:distanceThresh:")]
		int RecoverPose (Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t, double distanceThresh);

		// +(void)computeCorrespondEpilines:(Mat * _Nonnull)points whichImage:(int)whichImage F:(Mat * _Nonnull)F lines:(Mat * _Nonnull)lines __attribute__((swift_name("computeCorrespondEpilines(points:whichImage:F:lines:)")));
		[Static]
		[Export ("computeCorrespondEpilines:whichImage:F:lines:")]
		void ComputeCorrespondEpilines (Mat points, int whichImage, Mat F, Mat lines);

		// +(void)triangulatePoints:(Mat * _Nonnull)projMatr1 projMatr2:(Mat * _Nonnull)projMatr2 projPoints1:(Mat * _Nonnull)projPoints1 projPoints2:(Mat * _Nonnull)projPoints2 points4D:(Mat * _Nonnull)points4D __attribute__((swift_name("triangulatePoints(projMatr1:projMatr2:projPoints1:projPoints2:points4D:)")));
		[Static]
		[Export ("triangulatePoints:projMatr2:projPoints1:projPoints2:points4D:")]
		void TriangulatePoints (Mat projMatr1, Mat projMatr2, Mat projPoints1, Mat projPoints2, Mat points4D);

		// +(void)correctMatches:(Mat * _Nonnull)F points1:(Mat * _Nonnull)points1 points2:(Mat * _Nonnull)points2 newPoints1:(Mat * _Nonnull)newPoints1 newPoints2:(Mat * _Nonnull)newPoints2 __attribute__((swift_name("correctMatches(F:points1:points2:newPoints1:newPoints2:)")));
		[Static]
		[Export ("correctMatches:points1:points2:newPoints1:newPoints2:")]
		void CorrectMatches (Mat F, Mat points1, Mat points2, Mat newPoints1, Mat newPoints2);

		// +(void)filterSpeckles:(Mat * _Nonnull)img newVal:(double)newVal maxSpeckleSize:(int)maxSpeckleSize maxDiff:(double)maxDiff buf:(Mat * _Nonnull)buf __attribute__((swift_name("filterSpeckles(img:newVal:maxSpeckleSize:maxDiff:buf:)")));
		[Static]
		[Export ("filterSpeckles:newVal:maxSpeckleSize:maxDiff:buf:")]
		void FilterSpeckles (Mat img, double newVal, int maxSpeckleSize, double maxDiff, Mat buf);

		// +(void)filterSpeckles:(Mat * _Nonnull)img newVal:(double)newVal maxSpeckleSize:(int)maxSpeckleSize maxDiff:(double)maxDiff __attribute__((swift_name("filterSpeckles(img:newVal:maxSpeckleSize:maxDiff:)")));
		[Static]
		[Export ("filterSpeckles:newVal:maxSpeckleSize:maxDiff:")]
		void FilterSpeckles (Mat img, double newVal, int maxSpeckleSize, double maxDiff);

		// +(Rect2i * _Nonnull)getValidDisparityROI:(Rect2i * _Nonnull)roi1 roi2:(Rect2i * _Nonnull)roi2 minDisparity:(int)minDisparity numberOfDisparities:(int)numberOfDisparities blockSize:(int)blockSize __attribute__((swift_name("getValidDisparityROI(roi1:roi2:minDisparity:numberOfDisparities:blockSize:)")));
		[Static]
		[Export ("getValidDisparityROI:roi2:minDisparity:numberOfDisparities:blockSize:")]
		Rect2i GetValidDisparityROI (Rect2i roi1, Rect2i roi2, int minDisparity, int numberOfDisparities, int blockSize);

		// +(void)validateDisparity:(Mat * _Nonnull)disparity cost:(Mat * _Nonnull)cost minDisparity:(int)minDisparity numberOfDisparities:(int)numberOfDisparities disp12MaxDisp:(int)disp12MaxDisp __attribute__((swift_name("validateDisparity(disparity:cost:minDisparity:numberOfDisparities:disp12MaxDisp:)")));
		[Static]
		[Export ("validateDisparity:cost:minDisparity:numberOfDisparities:disp12MaxDisp:")]
		void ValidateDisparity (Mat disparity, Mat cost, int minDisparity, int numberOfDisparities, int disp12MaxDisp);

		// +(void)validateDisparity:(Mat * _Nonnull)disparity cost:(Mat * _Nonnull)cost minDisparity:(int)minDisparity numberOfDisparities:(int)numberOfDisparities __attribute__((swift_name("validateDisparity(disparity:cost:minDisparity:numberOfDisparities:)")));
		[Static]
		[Export ("validateDisparity:cost:minDisparity:numberOfDisparities:")]
		void ValidateDisparity (Mat disparity, Mat cost, int minDisparity, int numberOfDisparities);

		// +(void)reprojectImageTo3D:(Mat * _Nonnull)disparity _3dImage:(Mat * _Nonnull)_3dImage Q:(Mat * _Nonnull)Q handleMissingValues:(BOOL)handleMissingValues ddepth:(int)ddepth __attribute__((swift_name("reprojectImageTo3D(disparity:_3dImage:Q:handleMissingValues:ddepth:)")));
		[Static]
		[Export ("reprojectImageTo3D:_3dImage:Q:handleMissingValues:ddepth:")]
		void ReprojectImageTo3D (Mat disparity, Mat _3dImage, Mat Q, bool handleMissingValues, int ddepth);

		// +(void)reprojectImageTo3D:(Mat * _Nonnull)disparity _3dImage:(Mat * _Nonnull)_3dImage Q:(Mat * _Nonnull)Q handleMissingValues:(BOOL)handleMissingValues __attribute__((swift_name("reprojectImageTo3D(disparity:_3dImage:Q:handleMissingValues:)")));
		[Static]
		[Export ("reprojectImageTo3D:_3dImage:Q:handleMissingValues:")]
		void ReprojectImageTo3D (Mat disparity, Mat _3dImage, Mat Q, bool handleMissingValues);

		// +(void)reprojectImageTo3D:(Mat * _Nonnull)disparity _3dImage:(Mat * _Nonnull)_3dImage Q:(Mat * _Nonnull)Q __attribute__((swift_name("reprojectImageTo3D(disparity:_3dImage:Q:)")));
		[Static]
		[Export ("reprojectImageTo3D:_3dImage:Q:")]
		void ReprojectImageTo3D (Mat disparity, Mat _3dImage, Mat Q);

		// +(double)sampsonDistance:(Mat * _Nonnull)pt1 pt2:(Mat * _Nonnull)pt2 F:(Mat * _Nonnull)F __attribute__((swift_name("sampsonDistance(pt1:pt2:F:)")));
		[Static]
		[Export ("sampsonDistance:pt2:F:")]
		double SampsonDistance (Mat pt1, Mat pt2, Mat F);

		// +(int)estimateAffine3D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst out:(Mat * _Nonnull)out inliers:(Mat * _Nonnull)inliers ransacThreshold:(double)ransacThreshold confidence:(double)confidence __attribute__((swift_name("estimateAffine3D(src:dst:out:inliers:ransacThreshold:confidence:)")));
		[Static]
		[Export ("estimateAffine3D:dst:out:inliers:ransacThreshold:confidence:")]
		int EstimateAffine3D (Mat src, Mat dst, Mat @out, Mat inliers, double ransacThreshold, double confidence);

		// +(int)estimateAffine3D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst out:(Mat * _Nonnull)out inliers:(Mat * _Nonnull)inliers ransacThreshold:(double)ransacThreshold __attribute__((swift_name("estimateAffine3D(src:dst:out:inliers:ransacThreshold:)")));
		[Static]
		[Export ("estimateAffine3D:dst:out:inliers:ransacThreshold:")]
		int EstimateAffine3D (Mat src, Mat dst, Mat @out, Mat inliers, double ransacThreshold);

		// +(int)estimateAffine3D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst out:(Mat * _Nonnull)out inliers:(Mat * _Nonnull)inliers __attribute__((swift_name("estimateAffine3D(src:dst:out:inliers:)")));
		[Static]
		[Export ("estimateAffine3D:dst:out:inliers:")]
		int EstimateAffine3D (Mat src, Mat dst, Mat @out, Mat inliers);

		// +(Mat * _Nonnull)estimateAffine3D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst scale:(double * _Nonnull)scale force_rotation:(BOOL)force_rotation __attribute__((swift_name("estimateAffine3D(src:dst:scale:force_rotation:)")));
		[Static]
		[Export ("estimateAffine3D:dst:scale:force_rotation:")]
		unsafe Mat EstimateAffine3D (Mat src, Mat dst, double* scale, bool force_rotation);

		// +(Mat * _Nonnull)estimateAffine3D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst scale:(double * _Nonnull)scale __attribute__((swift_name("estimateAffine3D(src:dst:scale:)")));
		[Static]
		[Export ("estimateAffine3D:dst:scale:")]
		unsafe Mat EstimateAffine3D (Mat src, Mat dst, double* scale);

		// +(Mat * _Nonnull)estimateAffine3D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst __attribute__((swift_name("estimateAffine3D(src:dst:)")));
		[Static]
		[Export ("estimateAffine3D:dst:")]
		Mat EstimateAffine3D (Mat src, Mat dst);

		// +(int)estimateTranslation3D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst out:(Mat * _Nonnull)out inliers:(Mat * _Nonnull)inliers ransacThreshold:(double)ransacThreshold confidence:(double)confidence __attribute__((swift_name("estimateTranslation3D(src:dst:out:inliers:ransacThreshold:confidence:)")));
		[Static]
		[Export ("estimateTranslation3D:dst:out:inliers:ransacThreshold:confidence:")]
		int EstimateTranslation3D (Mat src, Mat dst, Mat @out, Mat inliers, double ransacThreshold, double confidence);

		// +(int)estimateTranslation3D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst out:(Mat * _Nonnull)out inliers:(Mat * _Nonnull)inliers ransacThreshold:(double)ransacThreshold __attribute__((swift_name("estimateTranslation3D(src:dst:out:inliers:ransacThreshold:)")));
		[Static]
		[Export ("estimateTranslation3D:dst:out:inliers:ransacThreshold:")]
		int EstimateTranslation3D (Mat src, Mat dst, Mat @out, Mat inliers, double ransacThreshold);

		// +(int)estimateTranslation3D:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst out:(Mat * _Nonnull)out inliers:(Mat * _Nonnull)inliers __attribute__((swift_name("estimateTranslation3D(src:dst:out:inliers:)")));
		[Static]
		[Export ("estimateTranslation3D:dst:out:inliers:")]
		int EstimateTranslation3D (Mat src, Mat dst, Mat @out, Mat inliers);

		// +(Mat * _Nonnull)estimateAffine2D:(Mat * _Nonnull)from to:(Mat * _Nonnull)to inliers:(Mat * _Nonnull)inliers method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold maxIters:(size_t)maxIters confidence:(double)confidence refineIters:(size_t)refineIters __attribute__((swift_name("estimateAffine2D(from:to:inliers:method:ransacReprojThreshold:maxIters:confidence:refineIters:)")));
		[Static]
		[Export ("estimateAffine2D:to:inliers:method:ransacReprojThreshold:maxIters:confidence:refineIters:")]
		Mat EstimateAffine2D (Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, nuint maxIters, double confidence, nuint refineIters);

		// +(Mat * _Nonnull)estimateAffine2D:(Mat * _Nonnull)from to:(Mat * _Nonnull)to inliers:(Mat * _Nonnull)inliers method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold maxIters:(size_t)maxIters confidence:(double)confidence __attribute__((swift_name("estimateAffine2D(from:to:inliers:method:ransacReprojThreshold:maxIters:confidence:)")));
		[Static]
		[Export ("estimateAffine2D:to:inliers:method:ransacReprojThreshold:maxIters:confidence:")]
		Mat EstimateAffine2D (Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, nuint maxIters, double confidence);

		// +(Mat * _Nonnull)estimateAffine2D:(Mat * _Nonnull)from to:(Mat * _Nonnull)to inliers:(Mat * _Nonnull)inliers method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold maxIters:(size_t)maxIters __attribute__((swift_name("estimateAffine2D(from:to:inliers:method:ransacReprojThreshold:maxIters:)")));
		[Static]
		[Export ("estimateAffine2D:to:inliers:method:ransacReprojThreshold:maxIters:")]
		Mat EstimateAffine2D (Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, nuint maxIters);

		// +(Mat * _Nonnull)estimateAffine2D:(Mat * _Nonnull)from to:(Mat * _Nonnull)to inliers:(Mat * _Nonnull)inliers method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold __attribute__((swift_name("estimateAffine2D(from:to:inliers:method:ransacReprojThreshold:)")));
		[Static]
		[Export ("estimateAffine2D:to:inliers:method:ransacReprojThreshold:")]
		Mat EstimateAffine2D (Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold);

		// +(Mat * _Nonnull)estimateAffine2D:(Mat * _Nonnull)from to:(Mat * _Nonnull)to inliers:(Mat * _Nonnull)inliers method:(int)method __attribute__((swift_name("estimateAffine2D(from:to:inliers:method:)")));
		[Static]
		[Export ("estimateAffine2D:to:inliers:method:")]
		Mat EstimateAffine2D (Mat from, Mat to, Mat inliers, int method);

		// +(Mat * _Nonnull)estimateAffine2D:(Mat * _Nonnull)from to:(Mat * _Nonnull)to inliers:(Mat * _Nonnull)inliers __attribute__((swift_name("estimateAffine2D(from:to:inliers:)")));
		[Static]
		[Export ("estimateAffine2D:to:inliers:")]
		Mat EstimateAffine2D (Mat from, Mat to, Mat inliers);

		// +(Mat * _Nonnull)estimateAffine2D:(Mat * _Nonnull)from to:(Mat * _Nonnull)to __attribute__((swift_name("estimateAffine2D(from:to:)")));
		[Static]
		[Export ("estimateAffine2D:to:")]
		Mat EstimateAffine2D (Mat from, Mat to);

		// +(Mat * _Nonnull)estimateAffine2D:(Mat * _Nonnull)pts1 pts2:(Mat * _Nonnull)pts2 inliers:(Mat * _Nonnull)inliers params:(UsacParams * _Nonnull)params __attribute__((swift_name("estimateAffine2D(pts1:pts2:inliers:params:)")));
		[Static]
		[Export ("estimateAffine2D:pts2:inliers:params:")]
		Mat EstimateAffine2D (Mat pts1, Mat pts2, Mat inliers, UsacParams @params);

		// +(Mat * _Nonnull)estimateAffinePartial2D:(Mat * _Nonnull)from to:(Mat * _Nonnull)to inliers:(Mat * _Nonnull)inliers method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold maxIters:(size_t)maxIters confidence:(double)confidence refineIters:(size_t)refineIters __attribute__((swift_name("estimateAffinePartial2D(from:to:inliers:method:ransacReprojThreshold:maxIters:confidence:refineIters:)")));
		[Static]
		[Export ("estimateAffinePartial2D:to:inliers:method:ransacReprojThreshold:maxIters:confidence:refineIters:")]
		Mat EstimateAffinePartial2D (Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, nuint maxIters, double confidence, nuint refineIters);

		// +(Mat * _Nonnull)estimateAffinePartial2D:(Mat * _Nonnull)from to:(Mat * _Nonnull)to inliers:(Mat * _Nonnull)inliers method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold maxIters:(size_t)maxIters confidence:(double)confidence __attribute__((swift_name("estimateAffinePartial2D(from:to:inliers:method:ransacReprojThreshold:maxIters:confidence:)")));
		[Static]
		[Export ("estimateAffinePartial2D:to:inliers:method:ransacReprojThreshold:maxIters:confidence:")]
		Mat EstimateAffinePartial2D (Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, nuint maxIters, double confidence);

		// +(Mat * _Nonnull)estimateAffinePartial2D:(Mat * _Nonnull)from to:(Mat * _Nonnull)to inliers:(Mat * _Nonnull)inliers method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold maxIters:(size_t)maxIters __attribute__((swift_name("estimateAffinePartial2D(from:to:inliers:method:ransacReprojThreshold:maxIters:)")));
		[Static]
		[Export ("estimateAffinePartial2D:to:inliers:method:ransacReprojThreshold:maxIters:")]
		Mat EstimateAffinePartial2D (Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, nuint maxIters);

		// +(Mat * _Nonnull)estimateAffinePartial2D:(Mat * _Nonnull)from to:(Mat * _Nonnull)to inliers:(Mat * _Nonnull)inliers method:(int)method ransacReprojThreshold:(double)ransacReprojThreshold __attribute__((swift_name("estimateAffinePartial2D(from:to:inliers:method:ransacReprojThreshold:)")));
		[Static]
		[Export ("estimateAffinePartial2D:to:inliers:method:ransacReprojThreshold:")]
		Mat EstimateAffinePartial2D (Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold);

		// +(Mat * _Nonnull)estimateAffinePartial2D:(Mat * _Nonnull)from to:(Mat * _Nonnull)to inliers:(Mat * _Nonnull)inliers method:(int)method __attribute__((swift_name("estimateAffinePartial2D(from:to:inliers:method:)")));
		[Static]
		[Export ("estimateAffinePartial2D:to:inliers:method:")]
		Mat EstimateAffinePartial2D (Mat from, Mat to, Mat inliers, int method);

		// +(Mat * _Nonnull)estimateAffinePartial2D:(Mat * _Nonnull)from to:(Mat * _Nonnull)to inliers:(Mat * _Nonnull)inliers __attribute__((swift_name("estimateAffinePartial2D(from:to:inliers:)")));
		[Static]
		[Export ("estimateAffinePartial2D:to:inliers:")]
		Mat EstimateAffinePartial2D (Mat from, Mat to, Mat inliers);

		// +(Mat * _Nonnull)estimateAffinePartial2D:(Mat * _Nonnull)from to:(Mat * _Nonnull)to __attribute__((swift_name("estimateAffinePartial2D(from:to:)")));
		[Static]
		[Export ("estimateAffinePartial2D:to:")]
		Mat EstimateAffinePartial2D (Mat from, Mat to);

		// +(int)decomposeHomographyMat:(Mat * _Nonnull)H K:(Mat * _Nonnull)K rotations:(NSMutableArray<Mat *> * _Nonnull)rotations translations:(NSMutableArray<Mat *> * _Nonnull)translations normals:(NSMutableArray<Mat *> * _Nonnull)normals __attribute__((swift_name("decomposeHomographyMat(H:K:rotations:translations:normals:)")));
		[Static]
		[Export ("decomposeHomographyMat:K:rotations:translations:normals:")]
		int DecomposeHomographyMat (Mat H, Mat K, NSMutableArray<Mat> rotations, NSMutableArray<Mat> translations, NSMutableArray<Mat> normals);

		// +(void)filterHomographyDecompByVisibleRefpoints:(NSArray<Mat *> * _Nonnull)rotations normals:(NSArray<Mat *> * _Nonnull)normals beforePoints:(Mat * _Nonnull)beforePoints afterPoints:(Mat * _Nonnull)afterPoints possibleSolutions:(Mat * _Nonnull)possibleSolutions pointsMask:(Mat * _Nonnull)pointsMask __attribute__((swift_name("filterHomographyDecompByVisibleRefpoints(rotations:normals:beforePoints:afterPoints:possibleSolutions:pointsMask:)")));
		[Static]
		[Export ("filterHomographyDecompByVisibleRefpoints:normals:beforePoints:afterPoints:possibleSolutions:pointsMask:")]
		void FilterHomographyDecompByVisibleRefpoints (Mat[] rotations, Mat[] normals, Mat beforePoints, Mat afterPoints, Mat possibleSolutions, Mat pointsMask);

		// +(void)filterHomographyDecompByVisibleRefpoints:(NSArray<Mat *> * _Nonnull)rotations normals:(NSArray<Mat *> * _Nonnull)normals beforePoints:(Mat * _Nonnull)beforePoints afterPoints:(Mat * _Nonnull)afterPoints possibleSolutions:(Mat * _Nonnull)possibleSolutions __attribute__((swift_name("filterHomographyDecompByVisibleRefpoints(rotations:normals:beforePoints:afterPoints:possibleSolutions:)")));
		[Static]
		[Export ("filterHomographyDecompByVisibleRefpoints:normals:beforePoints:afterPoints:possibleSolutions:")]
		void FilterHomographyDecompByVisibleRefpoints (Mat[] rotations, Mat[] normals, Mat beforePoints, Mat afterPoints, Mat possibleSolutions);

		// +(void)undistort:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs newCameraMatrix:(Mat * _Nonnull)newCameraMatrix __attribute__((swift_name("undistort(src:dst:cameraMatrix:distCoeffs:newCameraMatrix:)")));
		[Static]
		[Export ("undistort:dst:cameraMatrix:distCoeffs:newCameraMatrix:")]
		void Undistort (Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs, Mat newCameraMatrix);

		// +(void)undistort:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs __attribute__((swift_name("undistort(src:dst:cameraMatrix:distCoeffs:)")));
		[Static]
		[Export ("undistort:dst:cameraMatrix:distCoeffs:")]
		void Undistort (Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs);

		// +(void)initUndistortRectifyMap:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs R:(Mat * _Nonnull)R newCameraMatrix:(Mat * _Nonnull)newCameraMatrix size:(Size2i * _Nonnull)size m1type:(int)m1type map1:(Mat * _Nonnull)map1 map2:(Mat * _Nonnull)map2 __attribute__((swift_name("initUndistortRectifyMap(cameraMatrix:distCoeffs:R:newCameraMatrix:size:m1type:map1:map2:)")));
		[Static]
		[Export ("initUndistortRectifyMap:distCoeffs:R:newCameraMatrix:size:m1type:map1:map2:")]
		void InitUndistortRectifyMap (Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size2i size, int m1type, Mat map1, Mat map2);

		// +(void)initInverseRectificationMap:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs R:(Mat * _Nonnull)R newCameraMatrix:(Mat * _Nonnull)newCameraMatrix size:(Size2i * _Nonnull)size m1type:(int)m1type map1:(Mat * _Nonnull)map1 map2:(Mat * _Nonnull)map2 __attribute__((swift_name("initInverseRectificationMap(cameraMatrix:distCoeffs:R:newCameraMatrix:size:m1type:map1:map2:)")));
		[Static]
		[Export ("initInverseRectificationMap:distCoeffs:R:newCameraMatrix:size:m1type:map1:map2:")]
		void InitInverseRectificationMap (Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size2i size, int m1type, Mat map1, Mat map2);

		// +(Mat * _Nonnull)getDefaultNewCameraMatrix:(Mat * _Nonnull)cameraMatrix imgsize:(Size2i * _Nonnull)imgsize centerPrincipalPoint:(BOOL)centerPrincipalPoint __attribute__((swift_name("getDefaultNewCameraMatrix(cameraMatrix:imgsize:centerPrincipalPoint:)")));
		[Static]
		[Export ("getDefaultNewCameraMatrix:imgsize:centerPrincipalPoint:")]
		Mat GetDefaultNewCameraMatrix (Mat cameraMatrix, Size2i imgsize, bool centerPrincipalPoint);

		// +(Mat * _Nonnull)getDefaultNewCameraMatrix:(Mat * _Nonnull)cameraMatrix imgsize:(Size2i * _Nonnull)imgsize __attribute__((swift_name("getDefaultNewCameraMatrix(cameraMatrix:imgsize:)")));
		[Static]
		[Export ("getDefaultNewCameraMatrix:imgsize:")]
		Mat GetDefaultNewCameraMatrix (Mat cameraMatrix, Size2i imgsize);

		// +(Mat * _Nonnull)getDefaultNewCameraMatrix:(Mat * _Nonnull)cameraMatrix __attribute__((swift_name("getDefaultNewCameraMatrix(cameraMatrix:)")));
		[Static]
		[Export ("getDefaultNewCameraMatrix:")]
		Mat GetDefaultNewCameraMatrix (Mat cameraMatrix);

		// +(void)undistortPoints:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs R:(Mat * _Nonnull)R P:(Mat * _Nonnull)P __attribute__((swift_name("undistortPoints(src:dst:cameraMatrix:distCoeffs:R:P:)")));
		[Static]
		[Export ("undistortPoints:dst:cameraMatrix:distCoeffs:R:P:")]
		void UndistortPoints (Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs, Mat R, Mat P);

		// +(void)undistortPoints:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs R:(Mat * _Nonnull)R __attribute__((swift_name("undistortPoints(src:dst:cameraMatrix:distCoeffs:R:)")));
		[Static]
		[Export ("undistortPoints:dst:cameraMatrix:distCoeffs:R:")]
		void UndistortPoints (Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs, Mat R);

		// +(void)undistortPoints:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs __attribute__((swift_name("undistortPoints(src:dst:cameraMatrix:distCoeffs:)")));
		[Static]
		[Export ("undistortPoints:dst:cameraMatrix:distCoeffs:")]
		void UndistortPoints (Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs);

		// +(void)undistortPointsIter:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs R:(Mat * _Nonnull)R P:(Mat * _Nonnull)P criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("undistortPoints(src:dst:cameraMatrix:distCoeffs:R:P:criteria:)")));
		[Static]
		[Export ("undistortPointsIter:dst:cameraMatrix:distCoeffs:R:P:criteria:")]
		void UndistortPointsIter (Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs, Mat R, Mat P, TermCriteria criteria);

		// +(void)undistortImagePoints:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs arg1:(TermCriteria * _Nonnull)arg1 __attribute__((swift_name("undistortImagePoints(src:dst:cameraMatrix:distCoeffs:arg1:)")));
		[Static]
		[Export ("undistortImagePoints:dst:cameraMatrix:distCoeffs:arg1:")]
		void UndistortImagePoints (Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs, TermCriteria arg1);

		// +(void)undistortImagePoints:(Mat * _Nonnull)src dst:(Mat * _Nonnull)dst cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs __attribute__((swift_name("undistortImagePoints(src:dst:cameraMatrix:distCoeffs:)")));
		[Static]
		[Export ("undistortImagePoints:dst:cameraMatrix:distCoeffs:")]
		void UndistortImagePoints (Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs);

		// +(void)fisheye_projectPoints:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D alpha:(double)alpha jacobian:(Mat * _Nonnull)jacobian __attribute__((swift_name("fisheye_projectPoints(objectPoints:imagePoints:rvec:tvec:K:D:alpha:jacobian:)")));
		[Static]
		[Export ("fisheye_projectPoints:imagePoints:rvec:tvec:K:D:alpha:jacobian:")]
		void Fisheye_projectPoints (Mat objectPoints, Mat imagePoints, Mat rvec, Mat tvec, Mat K, Mat D, double alpha, Mat jacobian);

		// +(void)fisheye_projectPoints:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D alpha:(double)alpha __attribute__((swift_name("fisheye_projectPoints(objectPoints:imagePoints:rvec:tvec:K:D:alpha:)")));
		[Static]
		[Export ("fisheye_projectPoints:imagePoints:rvec:tvec:K:D:alpha:")]
		void Fisheye_projectPoints (Mat objectPoints, Mat imagePoints, Mat rvec, Mat tvec, Mat K, Mat D, double alpha);

		// +(void)fisheye_projectPoints:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D __attribute__((swift_name("fisheye_projectPoints(objectPoints:imagePoints:rvec:tvec:K:D:)")));
		[Static]
		[Export ("fisheye_projectPoints:imagePoints:rvec:tvec:K:D:")]
		void Fisheye_projectPoints (Mat objectPoints, Mat imagePoints, Mat rvec, Mat tvec, Mat K, Mat D);

		// +(void)fisheye_distortPoints:(Mat * _Nonnull)undistorted distorted:(Mat * _Nonnull)distorted K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D alpha:(double)alpha __attribute__((swift_name("fisheye_distortPoints(undistorted:distorted:K:D:alpha:)")));
		[Static]
		[Export ("fisheye_distortPoints:distorted:K:D:alpha:")]
		void Fisheye_distortPoints (Mat undistorted, Mat distorted, Mat K, Mat D, double alpha);

		// +(void)fisheye_distortPoints:(Mat * _Nonnull)undistorted distorted:(Mat * _Nonnull)distorted K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D __attribute__((swift_name("fisheye_distortPoints(undistorted:distorted:K:D:)")));
		[Static]
		[Export ("fisheye_distortPoints:distorted:K:D:")]
		void Fisheye_distortPoints (Mat undistorted, Mat distorted, Mat K, Mat D);

		// +(void)fisheye_distortPoints:(Mat * _Nonnull)undistorted distorted:(Mat * _Nonnull)distorted Kundistorted:(Mat * _Nonnull)Kundistorted K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D alpha:(double)alpha __attribute__((swift_name("fisheye_distortPoints(undistorted:distorted:Kundistorted:K:D:alpha:)")));
		[Static]
		[Export ("fisheye_distortPoints:distorted:Kundistorted:K:D:alpha:")]
		void Fisheye_distortPoints (Mat undistorted, Mat distorted, Mat Kundistorted, Mat K, Mat D, double alpha);

		// +(void)fisheye_distortPoints:(Mat * _Nonnull)undistorted distorted:(Mat * _Nonnull)distorted Kundistorted:(Mat * _Nonnull)Kundistorted K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D __attribute__((swift_name("fisheye_distortPoints(undistorted:distorted:Kundistorted:K:D:)")));
		[Static]
		[Export ("fisheye_distortPoints:distorted:Kundistorted:K:D:")]
		void Fisheye_distortPoints (Mat undistorted, Mat distorted, Mat Kundistorted, Mat K, Mat D);

		// +(void)fisheye_undistortPoints:(Mat * _Nonnull)distorted undistorted:(Mat * _Nonnull)undistorted K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D R:(Mat * _Nonnull)R P:(Mat * _Nonnull)P criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("fisheye_undistortPoints(distorted:undistorted:K:D:R:P:criteria:)")));
		[Static]
		[Export ("fisheye_undistortPoints:undistorted:K:D:R:P:criteria:")]
		void Fisheye_undistortPoints (Mat distorted, Mat undistorted, Mat K, Mat D, Mat R, Mat P, TermCriteria criteria);

		// +(void)fisheye_undistortPoints:(Mat * _Nonnull)distorted undistorted:(Mat * _Nonnull)undistorted K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D R:(Mat * _Nonnull)R P:(Mat * _Nonnull)P __attribute__((swift_name("fisheye_undistortPoints(distorted:undistorted:K:D:R:P:)")));
		[Static]
		[Export ("fisheye_undistortPoints:undistorted:K:D:R:P:")]
		void Fisheye_undistortPoints (Mat distorted, Mat undistorted, Mat K, Mat D, Mat R, Mat P);

		// +(void)fisheye_undistortPoints:(Mat * _Nonnull)distorted undistorted:(Mat * _Nonnull)undistorted K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D R:(Mat * _Nonnull)R __attribute__((swift_name("fisheye_undistortPoints(distorted:undistorted:K:D:R:)")));
		[Static]
		[Export ("fisheye_undistortPoints:undistorted:K:D:R:")]
		void Fisheye_undistortPoints (Mat distorted, Mat undistorted, Mat K, Mat D, Mat R);

		// +(void)fisheye_undistortPoints:(Mat * _Nonnull)distorted undistorted:(Mat * _Nonnull)undistorted K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D __attribute__((swift_name("fisheye_undistortPoints(distorted:undistorted:K:D:)")));
		[Static]
		[Export ("fisheye_undistortPoints:undistorted:K:D:")]
		void Fisheye_undistortPoints (Mat distorted, Mat undistorted, Mat K, Mat D);

		// +(void)fisheye_initUndistortRectifyMap:(Mat * _Nonnull)K D:(Mat * _Nonnull)D R:(Mat * _Nonnull)R P:(Mat * _Nonnull)P size:(Size2i * _Nonnull)size m1type:(int)m1type map1:(Mat * _Nonnull)map1 map2:(Mat * _Nonnull)map2 __attribute__((swift_name("fisheye_initUndistortRectifyMap(K:D:R:P:size:m1type:map1:map2:)")));
		[Static]
		[Export ("fisheye_initUndistortRectifyMap:D:R:P:size:m1type:map1:map2:")]
		void Fisheye_initUndistortRectifyMap (Mat K, Mat D, Mat R, Mat P, Size2i size, int m1type, Mat map1, Mat map2);

		// +(void)fisheye_undistortImage:(Mat * _Nonnull)distorted undistorted:(Mat * _Nonnull)undistorted K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D Knew:(Mat * _Nonnull)Knew new_size:(Size2i * _Nonnull)new_size __attribute__((swift_name("fisheye_undistortImage(distorted:undistorted:K:D:Knew:new_size:)")));
		[Static]
		[Export ("fisheye_undistortImage:undistorted:K:D:Knew:new_size:")]
		void Fisheye_undistortImage (Mat distorted, Mat undistorted, Mat K, Mat D, Mat Knew, Size2i new_size);

		// +(void)fisheye_undistortImage:(Mat * _Nonnull)distorted undistorted:(Mat * _Nonnull)undistorted K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D Knew:(Mat * _Nonnull)Knew __attribute__((swift_name("fisheye_undistortImage(distorted:undistorted:K:D:Knew:)")));
		[Static]
		[Export ("fisheye_undistortImage:undistorted:K:D:Knew:")]
		void Fisheye_undistortImage (Mat distorted, Mat undistorted, Mat K, Mat D, Mat Knew);

		// +(void)fisheye_undistortImage:(Mat * _Nonnull)distorted undistorted:(Mat * _Nonnull)undistorted K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D __attribute__((swift_name("fisheye_undistortImage(distorted:undistorted:K:D:)")));
		[Static]
		[Export ("fisheye_undistortImage:undistorted:K:D:")]
		void Fisheye_undistortImage (Mat distorted, Mat undistorted, Mat K, Mat D);

		// +(void)fisheye_estimateNewCameraMatrixForUndistortRectify:(Mat * _Nonnull)K D:(Mat * _Nonnull)D image_size:(Size2i * _Nonnull)image_size R:(Mat * _Nonnull)R P:(Mat * _Nonnull)P balance:(double)balance new_size:(Size2i * _Nonnull)new_size fov_scale:(double)fov_scale __attribute__((swift_name("fisheye_estimateNewCameraMatrixForUndistortRectify(K:D:image_size:R:P:balance:new_size:fov_scale:)")));
		[Static]
		[Export ("fisheye_estimateNewCameraMatrixForUndistortRectify:D:image_size:R:P:balance:new_size:fov_scale:")]
		void Fisheye_estimateNewCameraMatrixForUndistortRectify (Mat K, Mat D, Size2i image_size, Mat R, Mat P, double balance, Size2i new_size, double fov_scale);

		// +(void)fisheye_estimateNewCameraMatrixForUndistortRectify:(Mat * _Nonnull)K D:(Mat * _Nonnull)D image_size:(Size2i * _Nonnull)image_size R:(Mat * _Nonnull)R P:(Mat * _Nonnull)P balance:(double)balance new_size:(Size2i * _Nonnull)new_size __attribute__((swift_name("fisheye_estimateNewCameraMatrixForUndistortRectify(K:D:image_size:R:P:balance:new_size:)")));
		[Static]
		[Export ("fisheye_estimateNewCameraMatrixForUndistortRectify:D:image_size:R:P:balance:new_size:")]
		void Fisheye_estimateNewCameraMatrixForUndistortRectify (Mat K, Mat D, Size2i image_size, Mat R, Mat P, double balance, Size2i new_size);

		// +(void)fisheye_estimateNewCameraMatrixForUndistortRectify:(Mat * _Nonnull)K D:(Mat * _Nonnull)D image_size:(Size2i * _Nonnull)image_size R:(Mat * _Nonnull)R P:(Mat * _Nonnull)P balance:(double)balance __attribute__((swift_name("fisheye_estimateNewCameraMatrixForUndistortRectify(K:D:image_size:R:P:balance:)")));
		[Static]
		[Export ("fisheye_estimateNewCameraMatrixForUndistortRectify:D:image_size:R:P:balance:")]
		void Fisheye_estimateNewCameraMatrixForUndistortRectify (Mat K, Mat D, Size2i image_size, Mat R, Mat P, double balance);

		// +(void)fisheye_estimateNewCameraMatrixForUndistortRectify:(Mat * _Nonnull)K D:(Mat * _Nonnull)D image_size:(Size2i * _Nonnull)image_size R:(Mat * _Nonnull)R P:(Mat * _Nonnull)P __attribute__((swift_name("fisheye_estimateNewCameraMatrixForUndistortRectify(K:D:image_size:R:P:)")));
		[Static]
		[Export ("fisheye_estimateNewCameraMatrixForUndistortRectify:D:image_size:R:P:")]
		void Fisheye_estimateNewCameraMatrixForUndistortRectify (Mat K, Mat D, Size2i image_size, Mat R, Mat P);

		// +(double)fisheye_calibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints image_size:(Size2i * _Nonnull)image_size K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs flags:(int)flags criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("fisheye_calibrate(objectPoints:imagePoints:image_size:K:D:rvecs:tvecs:flags:criteria:)")));
		[Static]
		[Export ("fisheye_calibrate:imagePoints:image_size:K:D:rvecs:tvecs:flags:criteria:")]
		double Fisheye_calibrate (Mat[] objectPoints, Mat[] imagePoints, Size2i image_size, Mat K, Mat D, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, int flags, TermCriteria criteria);

		// +(double)fisheye_calibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints image_size:(Size2i * _Nonnull)image_size K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs flags:(int)flags __attribute__((swift_name("fisheye_calibrate(objectPoints:imagePoints:image_size:K:D:rvecs:tvecs:flags:)")));
		[Static]
		[Export ("fisheye_calibrate:imagePoints:image_size:K:D:rvecs:tvecs:flags:")]
		double Fisheye_calibrate (Mat[] objectPoints, Mat[] imagePoints, Size2i image_size, Mat K, Mat D, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, int flags);

		// +(double)fisheye_calibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints:(NSArray<Mat *> * _Nonnull)imagePoints image_size:(Size2i * _Nonnull)image_size K:(Mat * _Nonnull)K D:(Mat * _Nonnull)D rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs __attribute__((swift_name("fisheye_calibrate(objectPoints:imagePoints:image_size:K:D:rvecs:tvecs:)")));
		[Static]
		[Export ("fisheye_calibrate:imagePoints:image_size:K:D:rvecs:tvecs:")]
		double Fisheye_calibrate (Mat[] objectPoints, Mat[] imagePoints, Size2i image_size, Mat K, Mat D, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs);

		// +(void)fisheye_stereoRectify:(Mat * _Nonnull)K1 D1:(Mat * _Nonnull)D1 K2:(Mat * _Nonnull)K2 D2:(Mat * _Nonnull)D2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R tvec:(Mat * _Nonnull)tvec R1:(Mat * _Nonnull)R1 R2:(Mat * _Nonnull)R2 P1:(Mat * _Nonnull)P1 P2:(Mat * _Nonnull)P2 Q:(Mat * _Nonnull)Q flags:(int)flags newImageSize:(Size2i * _Nonnull)newImageSize balance:(double)balance fov_scale:(double)fov_scale __attribute__((swift_name("fisheye_stereoRectify(K1:D1:K2:D2:imageSize:R:tvec:R1:R2:P1:P2:Q:flags:newImageSize:balance:fov_scale:)")));
		[Static]
		[Export ("fisheye_stereoRectify:D1:K2:D2:imageSize:R:tvec:R1:R2:P1:P2:Q:flags:newImageSize:balance:fov_scale:")]
		void Fisheye_stereoRectify (Mat K1, Mat D1, Mat K2, Mat D2, Size2i imageSize, Mat R, Mat tvec, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, Size2i newImageSize, double balance, double fov_scale);

		// +(void)fisheye_stereoRectify:(Mat * _Nonnull)K1 D1:(Mat * _Nonnull)D1 K2:(Mat * _Nonnull)K2 D2:(Mat * _Nonnull)D2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R tvec:(Mat * _Nonnull)tvec R1:(Mat * _Nonnull)R1 R2:(Mat * _Nonnull)R2 P1:(Mat * _Nonnull)P1 P2:(Mat * _Nonnull)P2 Q:(Mat * _Nonnull)Q flags:(int)flags newImageSize:(Size2i * _Nonnull)newImageSize balance:(double)balance __attribute__((swift_name("fisheye_stereoRectify(K1:D1:K2:D2:imageSize:R:tvec:R1:R2:P1:P2:Q:flags:newImageSize:balance:)")));
		[Static]
		[Export ("fisheye_stereoRectify:D1:K2:D2:imageSize:R:tvec:R1:R2:P1:P2:Q:flags:newImageSize:balance:")]
		void Fisheye_stereoRectify (Mat K1, Mat D1, Mat K2, Mat D2, Size2i imageSize, Mat R, Mat tvec, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, Size2i newImageSize, double balance);

		// +(void)fisheye_stereoRectify:(Mat * _Nonnull)K1 D1:(Mat * _Nonnull)D1 K2:(Mat * _Nonnull)K2 D2:(Mat * _Nonnull)D2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R tvec:(Mat * _Nonnull)tvec R1:(Mat * _Nonnull)R1 R2:(Mat * _Nonnull)R2 P1:(Mat * _Nonnull)P1 P2:(Mat * _Nonnull)P2 Q:(Mat * _Nonnull)Q flags:(int)flags newImageSize:(Size2i * _Nonnull)newImageSize __attribute__((swift_name("fisheye_stereoRectify(K1:D1:K2:D2:imageSize:R:tvec:R1:R2:P1:P2:Q:flags:newImageSize:)")));
		[Static]
		[Export ("fisheye_stereoRectify:D1:K2:D2:imageSize:R:tvec:R1:R2:P1:P2:Q:flags:newImageSize:")]
		void Fisheye_stereoRectify (Mat K1, Mat D1, Mat K2, Mat D2, Size2i imageSize, Mat R, Mat tvec, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, Size2i newImageSize);

		// +(void)fisheye_stereoRectify:(Mat * _Nonnull)K1 D1:(Mat * _Nonnull)D1 K2:(Mat * _Nonnull)K2 D2:(Mat * _Nonnull)D2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R tvec:(Mat * _Nonnull)tvec R1:(Mat * _Nonnull)R1 R2:(Mat * _Nonnull)R2 P1:(Mat * _Nonnull)P1 P2:(Mat * _Nonnull)P2 Q:(Mat * _Nonnull)Q flags:(int)flags __attribute__((swift_name("fisheye_stereoRectify(K1:D1:K2:D2:imageSize:R:tvec:R1:R2:P1:P2:Q:flags:)")));
		[Static]
		[Export ("fisheye_stereoRectify:D1:K2:D2:imageSize:R:tvec:R1:R2:P1:P2:Q:flags:")]
		void Fisheye_stereoRectify (Mat K1, Mat D1, Mat K2, Mat D2, Size2i imageSize, Mat R, Mat tvec, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags);

		// +(double)fisheye_stereoCalibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 K1:(Mat * _Nonnull)K1 D1:(Mat * _Nonnull)D1 K2:(Mat * _Nonnull)K2 D2:(Mat * _Nonnull)D2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs flags:(int)flags criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("fisheye_stereoCalibrate(objectPoints:imagePoints1:imagePoints2:K1:D1:K2:D2:imageSize:R:T:rvecs:tvecs:flags:criteria:)")));
		[Static]
		[Export ("fisheye_stereoCalibrate:imagePoints1:imagePoints2:K1:D1:K2:D2:imageSize:R:T:rvecs:tvecs:flags:criteria:")]
		double Fisheye_stereoCalibrate (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size2i imageSize, Mat R, Mat T, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, int flags, TermCriteria criteria);

		// +(double)fisheye_stereoCalibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 K1:(Mat * _Nonnull)K1 D1:(Mat * _Nonnull)D1 K2:(Mat * _Nonnull)K2 D2:(Mat * _Nonnull)D2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs flags:(int)flags __attribute__((swift_name("fisheye_stereoCalibrate(objectPoints:imagePoints1:imagePoints2:K1:D1:K2:D2:imageSize:R:T:rvecs:tvecs:flags:)")));
		[Static]
		[Export ("fisheye_stereoCalibrate:imagePoints1:imagePoints2:K1:D1:K2:D2:imageSize:R:T:rvecs:tvecs:flags:")]
		double Fisheye_stereoCalibrate (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size2i imageSize, Mat R, Mat T, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs, int flags);

		// +(double)fisheye_stereoCalibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 K1:(Mat * _Nonnull)K1 D1:(Mat * _Nonnull)D1 K2:(Mat * _Nonnull)K2 D2:(Mat * _Nonnull)D2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T rvecs:(NSMutableArray<Mat *> * _Nonnull)rvecs tvecs:(NSMutableArray<Mat *> * _Nonnull)tvecs __attribute__((swift_name("fisheye_stereoCalibrate(objectPoints:imagePoints1:imagePoints2:K1:D1:K2:D2:imageSize:R:T:rvecs:tvecs:)")));
		[Static]
		[Export ("fisheye_stereoCalibrate:imagePoints1:imagePoints2:K1:D1:K2:D2:imageSize:R:T:rvecs:tvecs:")]
		double Fisheye_stereoCalibrate (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size2i imageSize, Mat R, Mat T, NSMutableArray<Mat> rvecs, NSMutableArray<Mat> tvecs);

		// +(double)fisheye_stereoCalibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 K1:(Mat * _Nonnull)K1 D1:(Mat * _Nonnull)D1 K2:(Mat * _Nonnull)K2 D2:(Mat * _Nonnull)D2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T flags:(int)flags criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("fisheye_stereoCalibrate(objectPoints:imagePoints1:imagePoints2:K1:D1:K2:D2:imageSize:R:T:flags:criteria:)")));
		[Static]
		[Export ("fisheye_stereoCalibrate:imagePoints1:imagePoints2:K1:D1:K2:D2:imageSize:R:T:flags:criteria:")]
		double Fisheye_stereoCalibrate (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size2i imageSize, Mat R, Mat T, int flags, TermCriteria criteria);

		// +(double)fisheye_stereoCalibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 K1:(Mat * _Nonnull)K1 D1:(Mat * _Nonnull)D1 K2:(Mat * _Nonnull)K2 D2:(Mat * _Nonnull)D2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T flags:(int)flags __attribute__((swift_name("fisheye_stereoCalibrate(objectPoints:imagePoints1:imagePoints2:K1:D1:K2:D2:imageSize:R:T:flags:)")));
		[Static]
		[Export ("fisheye_stereoCalibrate:imagePoints1:imagePoints2:K1:D1:K2:D2:imageSize:R:T:flags:")]
		double Fisheye_stereoCalibrate (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size2i imageSize, Mat R, Mat T, int flags);

		// +(double)fisheye_stereoCalibrate:(NSArray<Mat *> * _Nonnull)objectPoints imagePoints1:(NSArray<Mat *> * _Nonnull)imagePoints1 imagePoints2:(NSArray<Mat *> * _Nonnull)imagePoints2 K1:(Mat * _Nonnull)K1 D1:(Mat * _Nonnull)D1 K2:(Mat * _Nonnull)K2 D2:(Mat * _Nonnull)D2 imageSize:(Size2i * _Nonnull)imageSize R:(Mat * _Nonnull)R T:(Mat * _Nonnull)T __attribute__((swift_name("fisheye_stereoCalibrate(objectPoints:imagePoints1:imagePoints2:K1:D1:K2:D2:imageSize:R:T:)")));
		[Static]
		[Export ("fisheye_stereoCalibrate:imagePoints1:imagePoints2:K1:D1:K2:D2:imageSize:R:T:")]
		double Fisheye_stereoCalibrate (Mat[] objectPoints, Mat[] imagePoints1, Mat[] imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size2i imageSize, Mat R, Mat T);

		// +(BOOL)fisheye_solvePnP:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess flags:(int)flags criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("fisheye_solvePnP(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:flags:criteria:)")));
		[Static]
		[Export ("fisheye_solvePnP:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:flags:criteria:")]
		bool Fisheye_solvePnP (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int flags, TermCriteria criteria);

		// +(BOOL)fisheye_solvePnP:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess flags:(int)flags __attribute__((swift_name("fisheye_solvePnP(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:flags:)")));
		[Static]
		[Export ("fisheye_solvePnP:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:flags:")]
		bool Fisheye_solvePnP (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int flags);

		// +(BOOL)fisheye_solvePnP:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess __attribute__((swift_name("fisheye_solvePnP(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:)")));
		[Static]
		[Export ("fisheye_solvePnP:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:")]
		bool Fisheye_solvePnP (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess);

		// +(BOOL)fisheye_solvePnP:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec __attribute__((swift_name("fisheye_solvePnP(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:)")));
		[Static]
		[Export ("fisheye_solvePnP:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:")]
		bool Fisheye_solvePnP (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec);

		// +(BOOL)fisheye_solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess iterationsCount:(int)iterationsCount reprojectionError:(float)reprojectionError confidence:(double)confidence inliers:(Mat * _Nonnull)inliers flags:(int)flags criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("fisheye_solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:confidence:inliers:flags:criteria:)")));
		[Static]
		[Export ("fisheye_solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:confidence:inliers:flags:criteria:")]
		bool Fisheye_solvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence, Mat inliers, int flags, TermCriteria criteria);

		// +(BOOL)fisheye_solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess iterationsCount:(int)iterationsCount reprojectionError:(float)reprojectionError confidence:(double)confidence inliers:(Mat * _Nonnull)inliers flags:(int)flags __attribute__((swift_name("fisheye_solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:confidence:inliers:flags:)")));
		[Static]
		[Export ("fisheye_solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:confidence:inliers:flags:")]
		bool Fisheye_solvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence, Mat inliers, int flags);

		// +(BOOL)fisheye_solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess iterationsCount:(int)iterationsCount reprojectionError:(float)reprojectionError confidence:(double)confidence inliers:(Mat * _Nonnull)inliers __attribute__((swift_name("fisheye_solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:confidence:inliers:)")));
		[Static]
		[Export ("fisheye_solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:confidence:inliers:")]
		bool Fisheye_solvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence, Mat inliers);

		// +(BOOL)fisheye_solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess iterationsCount:(int)iterationsCount reprojectionError:(float)reprojectionError confidence:(double)confidence __attribute__((swift_name("fisheye_solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:confidence:)")));
		[Static]
		[Export ("fisheye_solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:confidence:")]
		bool Fisheye_solvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence);

		// +(BOOL)fisheye_solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess iterationsCount:(int)iterationsCount reprojectionError:(float)reprojectionError __attribute__((swift_name("fisheye_solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:)")));
		[Static]
		[Export ("fisheye_solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:reprojectionError:")]
		bool Fisheye_solvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError);

		// +(BOOL)fisheye_solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess iterationsCount:(int)iterationsCount __attribute__((swift_name("fisheye_solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:)")));
		[Static]
		[Export ("fisheye_solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:iterationsCount:")]
		bool Fisheye_solvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount);

		// +(BOOL)fisheye_solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess __attribute__((swift_name("fisheye_solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:)")));
		[Static]
		[Export ("fisheye_solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:")]
		bool Fisheye_solvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess);

		// +(BOOL)fisheye_solvePnPRansac:(Mat * _Nonnull)objectPoints imagePoints:(Mat * _Nonnull)imagePoints cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs rvec:(Mat * _Nonnull)rvec tvec:(Mat * _Nonnull)tvec __attribute__((swift_name("fisheye_solvePnPRansac(objectPoints:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:)")));
		[Static]
		[Export ("fisheye_solvePnPRansac:imagePoints:cameraMatrix:distCoeffs:rvec:tvec:")]
		bool Fisheye_solvePnPRansac (Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec);
	}

	// @interface CirclesGridFinderParameters : NSObject
	[BaseType (typeof(NSObject))]
	interface CirclesGridFinderParameters
	{
		// @property Size2f * _Nonnull densityNeighborhoodSize;
		[Export ("densityNeighborhoodSize", ArgumentSemantic.Assign)]
		Size2f DensityNeighborhoodSize { get; set; }

		// @property float minDensity;
		[Export ("minDensity")]
		float MinDensity { get; set; }

		// @property int kmeansAttempts;
		[Export ("kmeansAttempts")]
		int KmeansAttempts { get; set; }

		// @property int minDistanceToAddKeypoint;
		[Export ("minDistanceToAddKeypoint")]
		int MinDistanceToAddKeypoint { get; set; }

		// @property int keypointScale;
		[Export ("keypointScale")]
		int KeypointScale { get; set; }

		// @property float minGraphConfidence;
		[Export ("minGraphConfidence")]
		float MinGraphConfidence { get; set; }

		// @property float vertexGain;
		[Export ("vertexGain")]
		float VertexGain { get; set; }

		// @property float vertexPenalty;
		[Export ("vertexPenalty")]
		float VertexPenalty { get; set; }

		// @property float existingVertexGain;
		[Export ("existingVertexGain")]
		float ExistingVertexGain { get; set; }

		// @property float edgeGain;
		[Export ("edgeGain")]
		float EdgeGain { get; set; }

		// @property float edgePenalty;
		[Export ("edgePenalty")]
		float EdgePenalty { get; set; }

		// @property float convexHullFactor;
		[Export ("convexHullFactor")]
		float ConvexHullFactor { get; set; }

		// @property float minRNGEdgeSwitchDist;
		[Export ("minRNGEdgeSwitchDist")]
		float MinRNGEdgeSwitchDist { get; set; }

		// @property float squareSize;
		[Export ("squareSize")]
		float SquareSize { get; set; }

		// @property float maxRectifiedDistance;
		[Export ("maxRectifiedDistance")]
		float MaxRectifiedDistance { get; set; }
	}

	// @interface StereoMatcher : Algorithm
	[BaseType (typeof(Algorithm))]
	interface StereoMatcher
	{
		// @property (readonly, class) int DISP_SHIFT __attribute__((swift_name("DISP_SHIFT")));
		[Static]
		[Export ("DISP_SHIFT")]
		int DISP_SHIFT { get; }

		// @property (readonly, class) int DISP_SCALE __attribute__((swift_name("DISP_SCALE")));
		[Static]
		[Export ("DISP_SCALE")]
		int DISP_SCALE { get; }

		// -(void)compute:(Mat * _Nonnull)left right:(Mat * _Nonnull)right disparity:(Mat * _Nonnull)disparity __attribute__((swift_name("compute(left:right:disparity:)")));
		[Export ("compute:right:disparity:")]
		void Compute (Mat left, Mat right, Mat disparity);

		// -(int)getMinDisparity __attribute__((swift_name("getMinDisparity()")));
		[Export ("getMinDisparity")]
		int MinDisparity { get; }

		// -(void)setMinDisparity:(int)minDisparity __attribute__((swift_name("setMinDisparity(minDisparity:)")));
		[Export ("setMinDisparity:")]
		void SetMinDisparity (int minDisparity);

		// -(int)getNumDisparities __attribute__((swift_name("getNumDisparities()")));
		[Export ("getNumDisparities")]
		int NumDisparities { get; }

		// -(void)setNumDisparities:(int)numDisparities __attribute__((swift_name("setNumDisparities(numDisparities:)")));
		[Export ("setNumDisparities:")]
		void SetNumDisparities (int numDisparities);

		// -(int)getBlockSize __attribute__((swift_name("getBlockSize()")));
		[Export ("getBlockSize")]
		int BlockSize { get; }

		// -(void)setBlockSize:(int)blockSize __attribute__((swift_name("setBlockSize(blockSize:)")));
		[Export ("setBlockSize:")]
		void SetBlockSize (int blockSize);

		// -(int)getSpeckleWindowSize __attribute__((swift_name("getSpeckleWindowSize()")));
		[Export ("getSpeckleWindowSize")]
		int SpeckleWindowSize { get; }

		// -(void)setSpeckleWindowSize:(int)speckleWindowSize __attribute__((swift_name("setSpeckleWindowSize(speckleWindowSize:)")));
		[Export ("setSpeckleWindowSize:")]
		void SetSpeckleWindowSize (int speckleWindowSize);

		// -(int)getSpeckleRange __attribute__((swift_name("getSpeckleRange()")));
		[Export ("getSpeckleRange")]
		int SpeckleRange { get; }

		// -(void)setSpeckleRange:(int)speckleRange __attribute__((swift_name("setSpeckleRange(speckleRange:)")));
		[Export ("setSpeckleRange:")]
		void SetSpeckleRange (int speckleRange);

		// -(int)getDisp12MaxDiff __attribute__((swift_name("getDisp12MaxDiff()")));
		[Export ("getDisp12MaxDiff")]
		int Disp12MaxDiff { get; }

		// -(void)setDisp12MaxDiff:(int)disp12MaxDiff __attribute__((swift_name("setDisp12MaxDiff(disp12MaxDiff:)")));
		[Export ("setDisp12MaxDiff:")]
		void SetDisp12MaxDiff (int disp12MaxDiff);
	}

	// @interface StereoBM : StereoMatcher
	[BaseType (typeof(StereoMatcher))]
	interface StereoBM
	{
		// @property (readonly, class) int PREFILTER_NORMALIZED_RESPONSE __attribute__((swift_name("PREFILTER_NORMALIZED_RESPONSE")));
		[Static]
		[Export ("PREFILTER_NORMALIZED_RESPONSE")]
		int PREFILTER_NORMALIZED_RESPONSE { get; }

		// @property (readonly, class) int PREFILTER_XSOBEL __attribute__((swift_name("PREFILTER_XSOBEL")));
		[Static]
		[Export ("PREFILTER_XSOBEL")]
		int PREFILTER_XSOBEL { get; }

		// -(int)getPreFilterType __attribute__((swift_name("getPreFilterType()")));
		[Export ("getPreFilterType")]
		int PreFilterType { get; }

		// -(void)setPreFilterType:(int)preFilterType __attribute__((swift_name("setPreFilterType(preFilterType:)")));
		[Export ("setPreFilterType:")]
		void SetPreFilterType (int preFilterType);

		// -(int)getPreFilterSize __attribute__((swift_name("getPreFilterSize()")));
		[Export ("getPreFilterSize")]
		int PreFilterSize { get; }

		// -(void)setPreFilterSize:(int)preFilterSize __attribute__((swift_name("setPreFilterSize(preFilterSize:)")));
		[Export ("setPreFilterSize:")]
		void SetPreFilterSize (int preFilterSize);

		// -(int)getPreFilterCap __attribute__((swift_name("getPreFilterCap()")));
		[Export ("getPreFilterCap")]
		int PreFilterCap { get; }

		// -(void)setPreFilterCap:(int)preFilterCap __attribute__((swift_name("setPreFilterCap(preFilterCap:)")));
		[Export ("setPreFilterCap:")]
		void SetPreFilterCap (int preFilterCap);

		// -(int)getTextureThreshold __attribute__((swift_name("getTextureThreshold()")));
		[Export ("getTextureThreshold")]
		int TextureThreshold { get; }

		// -(void)setTextureThreshold:(int)textureThreshold __attribute__((swift_name("setTextureThreshold(textureThreshold:)")));
		[Export ("setTextureThreshold:")]
		void SetTextureThreshold (int textureThreshold);

		// -(int)getUniquenessRatio __attribute__((swift_name("getUniquenessRatio()")));
		[Export ("getUniquenessRatio")]
		int UniquenessRatio { get; }

		// -(void)setUniquenessRatio:(int)uniquenessRatio __attribute__((swift_name("setUniquenessRatio(uniquenessRatio:)")));
		[Export ("setUniquenessRatio:")]
		void SetUniquenessRatio (int uniquenessRatio);

		// -(int)getSmallerBlockSize __attribute__((swift_name("getSmallerBlockSize()")));
		[Export ("getSmallerBlockSize")]
		int SmallerBlockSize { get; }

		// -(void)setSmallerBlockSize:(int)blockSize __attribute__((swift_name("setSmallerBlockSize(blockSize:)")));
		[Export ("setSmallerBlockSize:")]
		void SetSmallerBlockSize (int blockSize);

		// -(Rect2i * _Nonnull)getROI1 __attribute__((swift_name("getROI1()")));
		[Export ("getROI1")]
		Rect2i ROI1 { get; }

		// -(void)setROI1:(Rect2i * _Nonnull)roi1 __attribute__((swift_name("setROI1(roi1:)")));
		[Export ("setROI1:")]
		void SetROI1 (Rect2i roi1);

		// -(Rect2i * _Nonnull)getROI2 __attribute__((swift_name("getROI2()")));
		[Export ("getROI2")]
		Rect2i ROI2 { get; }

		// -(void)setROI2:(Rect2i * _Nonnull)roi2 __attribute__((swift_name("setROI2(roi2:)")));
		[Export ("setROI2:")]
		void SetROI2 (Rect2i roi2);

		// +(StereoBM * _Nonnull)create:(int)numDisparities blockSize:(int)blockSize __attribute__((swift_name("create(numDisparities:blockSize:)")));
		[Static]
		[Export ("create:blockSize:")]
		StereoBM Create (int numDisparities, int blockSize);

		// +(StereoBM * _Nonnull)create:(int)numDisparities __attribute__((swift_name("create(numDisparities:)")));
		[Static]
		[Export ("create:")]
		StereoBM Create (int numDisparities);

		// +(StereoBM * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		StereoBM Create ();
	}

	// @interface StereoSGBM : StereoMatcher
	[BaseType (typeof(StereoMatcher))]
	interface StereoSGBM
	{
		// @property (readonly, class) int MODE_SGBM __attribute__((swift_name("MODE_SGBM")));
		[Static]
		[Export ("MODE_SGBM")]
		int MODE_SGBM { get; }

		// @property (readonly, class) int MODE_HH __attribute__((swift_name("MODE_HH")));
		[Static]
		[Export ("MODE_HH")]
		int MODE_HH { get; }

		// @property (readonly, class) int MODE_SGBM_3WAY __attribute__((swift_name("MODE_SGBM_3WAY")));
		[Static]
		[Export ("MODE_SGBM_3WAY")]
		int MODE_SGBM_3WAY { get; }

		// @property (readonly, class) int MODE_HH4 __attribute__((swift_name("MODE_HH4")));
		[Static]
		[Export ("MODE_HH4")]
		int MODE_HH4 { get; }

		// -(int)getPreFilterCap __attribute__((swift_name("getPreFilterCap()")));
		[Export ("getPreFilterCap")]
		int PreFilterCap { get; }

		// -(void)setPreFilterCap:(int)preFilterCap __attribute__((swift_name("setPreFilterCap(preFilterCap:)")));
		[Export ("setPreFilterCap:")]
		void SetPreFilterCap (int preFilterCap);

		// -(int)getUniquenessRatio __attribute__((swift_name("getUniquenessRatio()")));
		[Export ("getUniquenessRatio")]
		int UniquenessRatio { get; }

		// -(void)setUniquenessRatio:(int)uniquenessRatio __attribute__((swift_name("setUniquenessRatio(uniquenessRatio:)")));
		[Export ("setUniquenessRatio:")]
		void SetUniquenessRatio (int uniquenessRatio);

		// -(int)getP1 __attribute__((swift_name("getP1()")));
		[Export ("getP1")]
		int P1 { get; }

		// -(void)setP1:(int)P1 __attribute__((swift_name("setP1(P1:)")));
		[Export ("setP1:")]
		void SetP1 (int P1);

		// -(int)getP2 __attribute__((swift_name("getP2()")));
		[Export ("getP2")]
		int P2 { get; }

		// -(void)setP2:(int)P2 __attribute__((swift_name("setP2(P2:)")));
		[Export ("setP2:")]
		void SetP2 (int P2);

		// -(int)getMode __attribute__((swift_name("getMode()")));
		[Export ("getMode")]
		int Mode { get; }

		// -(void)setMode:(int)mode __attribute__((swift_name("setMode(mode:)")));
		[Export ("setMode:")]
		void SetMode (int mode);

		// +(StereoSGBM * _Nonnull)create:(int)minDisparity numDisparities:(int)numDisparities blockSize:(int)blockSize P1:(int)P1 P2:(int)P2 disp12MaxDiff:(int)disp12MaxDiff preFilterCap:(int)preFilterCap uniquenessRatio:(int)uniquenessRatio speckleWindowSize:(int)speckleWindowSize speckleRange:(int)speckleRange mode:(int)mode __attribute__((swift_name("create(minDisparity:numDisparities:blockSize:P1:P2:disp12MaxDiff:preFilterCap:uniquenessRatio:speckleWindowSize:speckleRange:mode:)")));
		[Static]
		[Export ("create:numDisparities:blockSize:P1:P2:disp12MaxDiff:preFilterCap:uniquenessRatio:speckleWindowSize:speckleRange:mode:")]
		StereoSGBM Create (int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange, int mode);

		// +(StereoSGBM * _Nonnull)create:(int)minDisparity numDisparities:(int)numDisparities blockSize:(int)blockSize P1:(int)P1 P2:(int)P2 disp12MaxDiff:(int)disp12MaxDiff preFilterCap:(int)preFilterCap uniquenessRatio:(int)uniquenessRatio speckleWindowSize:(int)speckleWindowSize speckleRange:(int)speckleRange __attribute__((swift_name("create(minDisparity:numDisparities:blockSize:P1:P2:disp12MaxDiff:preFilterCap:uniquenessRatio:speckleWindowSize:speckleRange:)")));
		[Static]
		[Export ("create:numDisparities:blockSize:P1:P2:disp12MaxDiff:preFilterCap:uniquenessRatio:speckleWindowSize:speckleRange:")]
		StereoSGBM Create (int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange);

		// +(StereoSGBM * _Nonnull)create:(int)minDisparity numDisparities:(int)numDisparities blockSize:(int)blockSize P1:(int)P1 P2:(int)P2 disp12MaxDiff:(int)disp12MaxDiff preFilterCap:(int)preFilterCap uniquenessRatio:(int)uniquenessRatio speckleWindowSize:(int)speckleWindowSize __attribute__((swift_name("create(minDisparity:numDisparities:blockSize:P1:P2:disp12MaxDiff:preFilterCap:uniquenessRatio:speckleWindowSize:)")));
		[Static]
		[Export ("create:numDisparities:blockSize:P1:P2:disp12MaxDiff:preFilterCap:uniquenessRatio:speckleWindowSize:")]
		StereoSGBM Create (int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize);

		// +(StereoSGBM * _Nonnull)create:(int)minDisparity numDisparities:(int)numDisparities blockSize:(int)blockSize P1:(int)P1 P2:(int)P2 disp12MaxDiff:(int)disp12MaxDiff preFilterCap:(int)preFilterCap uniquenessRatio:(int)uniquenessRatio __attribute__((swift_name("create(minDisparity:numDisparities:blockSize:P1:P2:disp12MaxDiff:preFilterCap:uniquenessRatio:)")));
		[Static]
		[Export ("create:numDisparities:blockSize:P1:P2:disp12MaxDiff:preFilterCap:uniquenessRatio:")]
		StereoSGBM Create (int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio);

		// +(StereoSGBM * _Nonnull)create:(int)minDisparity numDisparities:(int)numDisparities blockSize:(int)blockSize P1:(int)P1 P2:(int)P2 disp12MaxDiff:(int)disp12MaxDiff preFilterCap:(int)preFilterCap __attribute__((swift_name("create(minDisparity:numDisparities:blockSize:P1:P2:disp12MaxDiff:preFilterCap:)")));
		[Static]
		[Export ("create:numDisparities:blockSize:P1:P2:disp12MaxDiff:preFilterCap:")]
		StereoSGBM Create (int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap);

		// +(StereoSGBM * _Nonnull)create:(int)minDisparity numDisparities:(int)numDisparities blockSize:(int)blockSize P1:(int)P1 P2:(int)P2 disp12MaxDiff:(int)disp12MaxDiff __attribute__((swift_name("create(minDisparity:numDisparities:blockSize:P1:P2:disp12MaxDiff:)")));
		[Static]
		[Export ("create:numDisparities:blockSize:P1:P2:disp12MaxDiff:")]
		StereoSGBM Create (int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff);

		// +(StereoSGBM * _Nonnull)create:(int)minDisparity numDisparities:(int)numDisparities blockSize:(int)blockSize P1:(int)P1 P2:(int)P2 __attribute__((swift_name("create(minDisparity:numDisparities:blockSize:P1:P2:)")));
		[Static]
		[Export ("create:numDisparities:blockSize:P1:P2:")]
		StereoSGBM Create (int minDisparity, int numDisparities, int blockSize, int P1, int P2);

		// +(StereoSGBM * _Nonnull)create:(int)minDisparity numDisparities:(int)numDisparities blockSize:(int)blockSize P1:(int)P1 __attribute__((swift_name("create(minDisparity:numDisparities:blockSize:P1:)")));
		[Static]
		[Export ("create:numDisparities:blockSize:P1:")]
		StereoSGBM Create (int minDisparity, int numDisparities, int blockSize, int P1);

		// +(StereoSGBM * _Nonnull)create:(int)minDisparity numDisparities:(int)numDisparities blockSize:(int)blockSize __attribute__((swift_name("create(minDisparity:numDisparities:blockSize:)")));
		[Static]
		[Export ("create:numDisparities:blockSize:")]
		StereoSGBM Create (int minDisparity, int numDisparities, int blockSize);

		// +(StereoSGBM * _Nonnull)create:(int)minDisparity numDisparities:(int)numDisparities __attribute__((swift_name("create(minDisparity:numDisparities:)")));
		[Static]
		[Export ("create:numDisparities:")]
		StereoSGBM Create (int minDisparity, int numDisparities);

		// +(StereoSGBM * _Nonnull)create:(int)minDisparity __attribute__((swift_name("create(minDisparity:)")));
		[Static]
		[Export ("create:")]
		StereoSGBM Create (int minDisparity);

		// +(StereoSGBM * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		StereoSGBM Create ();
	}

	// @interface UsacParams : NSObject
	[BaseType (typeof(NSObject))]
	interface UsacParams
	{
		// @property double confidence;
		[Export ("confidence")]
		double Confidence { get; set; }

		// @property BOOL isParallel;
		[Export ("isParallel")]
		bool IsParallel { get; set; }

		// @property int loIterations;
		[Export ("loIterations")]
		int LoIterations { get; set; }

		// @property LocalOptimMethod loMethod;
		[Export ("loMethod", ArgumentSemantic.Assign)]
		LocalOptimMethod LoMethod { get; set; }

		// @property int loSampleSize;
		[Export ("loSampleSize")]
		int LoSampleSize { get; set; }

		// @property int maxIterations;
		[Export ("maxIterations")]
		int MaxIterations { get; set; }

		// @property NeighborSearchMethod neighborsSearch;
		[Export ("neighborsSearch", ArgumentSemantic.Assign)]
		NeighborSearchMethod NeighborsSearch { get; set; }

		// @property int randomGeneratorState;
		[Export ("randomGeneratorState")]
		int RandomGeneratorState { get; set; }

		// @property SamplingMethod sampler;
		[Export ("sampler", ArgumentSemantic.Assign)]
		SamplingMethod Sampler { get; set; }

		// @property ScoreMethod score;
		[Export ("score", ArgumentSemantic.Assign)]
		ScoreMethod Score { get; set; }

		// @property double threshold;
		[Export ("threshold")]
		double Threshold { get; set; }

		// @property PolishingMethod final_polisher;
		[Export ("final_polisher", ArgumentSemantic.Assign)]
		PolishingMethod Final_polisher { get; set; }

		// @property int final_polisher_iterations;
		[Export ("final_polisher_iterations")]
		int Final_polisher_iterations { get; set; }
	}

	// @interface Objdetect : NSObject
	[BaseType (typeof(NSObject))]
	interface Objdetect
	{
		// @property (readonly, class) int CASCADE_DO_CANNY_PRUNING __attribute__((swift_name("CASCADE_DO_CANNY_PRUNING")));
		[Static]
		[Export ("CASCADE_DO_CANNY_PRUNING")]
		int CASCADE_DO_CANNY_PRUNING { get; }

		// @property (readonly, class) int CASCADE_SCALE_IMAGE __attribute__((swift_name("CASCADE_SCALE_IMAGE")));
		[Static]
		[Export ("CASCADE_SCALE_IMAGE")]
		int CASCADE_SCALE_IMAGE { get; }

		// @property (readonly, class) int CASCADE_FIND_BIGGEST_OBJECT __attribute__((swift_name("CASCADE_FIND_BIGGEST_OBJECT")));
		[Static]
		[Export ("CASCADE_FIND_BIGGEST_OBJECT")]
		int CASCADE_FIND_BIGGEST_OBJECT { get; }

		// @property (readonly, class) int CASCADE_DO_ROUGH_SEARCH __attribute__((swift_name("CASCADE_DO_ROUGH_SEARCH")));
		[Static]
		[Export ("CASCADE_DO_ROUGH_SEARCH")]
		int CASCADE_DO_ROUGH_SEARCH { get; }

		// +(void)groupRectangles:(NSMutableArray<Rect2i *> * _Nonnull)rectList weights:(IntVector * _Nonnull)weights groupThreshold:(int)groupThreshold eps:(double)eps __attribute__((swift_name("groupRectangles(rectList:weights:groupThreshold:eps:)")));
		[Static]
		[Export ("groupRectangles:weights:groupThreshold:eps:")]
		void GroupRectangles (NSMutableArray<Rect2i> rectList, IntVector weights, int groupThreshold, double eps);

		// +(void)groupRectangles:(NSMutableArray<Rect2i *> * _Nonnull)rectList weights:(IntVector * _Nonnull)weights groupThreshold:(int)groupThreshold __attribute__((swift_name("groupRectangles(rectList:weights:groupThreshold:)")));
		[Static]
		[Export ("groupRectangles:weights:groupThreshold:")]
		void GroupRectangles (NSMutableArray<Rect2i> rectList, IntVector weights, int groupThreshold);

		// +(void)drawDetectedMarkers:(Mat * _Nonnull)image corners:(NSArray<Mat *> * _Nonnull)corners ids:(Mat * _Nonnull)ids borderColor:(Scalar * _Nonnull)borderColor __attribute__((swift_name("drawDetectedMarkers(image:corners:ids:borderColor:)")));
		[Static]
		[Export ("drawDetectedMarkers:corners:ids:borderColor:")]
		void DrawDetectedMarkers (Mat image, Mat[] corners, Mat ids, Scalar borderColor);

		// +(void)drawDetectedMarkers:(Mat * _Nonnull)image corners:(NSArray<Mat *> * _Nonnull)corners ids:(Mat * _Nonnull)ids __attribute__((swift_name("drawDetectedMarkers(image:corners:ids:)")));
		[Static]
		[Export ("drawDetectedMarkers:corners:ids:")]
		void DrawDetectedMarkers (Mat image, Mat[] corners, Mat ids);

		// +(void)drawDetectedMarkers:(Mat * _Nonnull)image corners:(NSArray<Mat *> * _Nonnull)corners __attribute__((swift_name("drawDetectedMarkers(image:corners:)")));
		[Static]
		[Export ("drawDetectedMarkers:corners:")]
		void DrawDetectedMarkers (Mat image, Mat[] corners);

		// +(void)generateImageMarker:(Dictionary * _Nonnull)dictionary id:(int)id sidePixels:(int)sidePixels img:(Mat * _Nonnull)img borderBits:(int)borderBits __attribute__((swift_name("generateImageMarker(dictionary:id:sidePixels:img:borderBits:)")));
		[Static]
		[Export ("generateImageMarker:id:sidePixels:img:borderBits:")]
		void GenerateImageMarker (Dictionary dictionary, int id, int sidePixels, Mat img, int borderBits);

		// +(void)generateImageMarker:(Dictionary * _Nonnull)dictionary id:(int)id sidePixels:(int)sidePixels img:(Mat * _Nonnull)img __attribute__((swift_name("generateImageMarker(dictionary:id:sidePixels:img:)")));
		[Static]
		[Export ("generateImageMarker:id:sidePixels:img:")]
		void GenerateImageMarker (Dictionary dictionary, int id, int sidePixels, Mat img);

		// +(Dictionary * _Nonnull)getPredefinedDictionary:(int)dict __attribute__((swift_name("getPredefinedDictionary(dict:)")));
		[Static]
		[Export ("getPredefinedDictionary:")]
		Dictionary GetPredefinedDictionary (int dict);

		// +(Dictionary * _Nonnull)extendDictionary:(int)nMarkers markerSize:(int)markerSize baseDictionary:(Dictionary * _Nonnull)baseDictionary randomSeed:(int)randomSeed __attribute__((swift_name("extendDictionary(nMarkers:markerSize:baseDictionary:randomSeed:)")));
		[Static]
		[Export ("extendDictionary:markerSize:baseDictionary:randomSeed:")]
		Dictionary ExtendDictionary (int nMarkers, int markerSize, Dictionary baseDictionary, int randomSeed);

		// +(Dictionary * _Nonnull)extendDictionary:(int)nMarkers markerSize:(int)markerSize baseDictionary:(Dictionary * _Nonnull)baseDictionary __attribute__((swift_name("extendDictionary(nMarkers:markerSize:baseDictionary:)")));
		[Static]
		[Export ("extendDictionary:markerSize:baseDictionary:")]
		Dictionary ExtendDictionary (int nMarkers, int markerSize, Dictionary baseDictionary);

		// +(Dictionary * _Nonnull)extendDictionary:(int)nMarkers markerSize:(int)markerSize __attribute__((swift_name("extendDictionary(nMarkers:markerSize:)")));
		[Static]
		[Export ("extendDictionary:markerSize:")]
		Dictionary ExtendDictionary (int nMarkers, int markerSize);

		// +(void)drawDetectedCornersCharuco:(Mat * _Nonnull)image charucoCorners:(Mat * _Nonnull)charucoCorners charucoIds:(Mat * _Nonnull)charucoIds cornerColor:(Scalar * _Nonnull)cornerColor __attribute__((swift_name("drawDetectedCornersCharuco(image:charucoCorners:charucoIds:cornerColor:)")));
		[Static]
		[Export ("drawDetectedCornersCharuco:charucoCorners:charucoIds:cornerColor:")]
		void DrawDetectedCornersCharuco (Mat image, Mat charucoCorners, Mat charucoIds, Scalar cornerColor);

		// +(void)drawDetectedCornersCharuco:(Mat * _Nonnull)image charucoCorners:(Mat * _Nonnull)charucoCorners charucoIds:(Mat * _Nonnull)charucoIds __attribute__((swift_name("drawDetectedCornersCharuco(image:charucoCorners:charucoIds:)")));
		[Static]
		[Export ("drawDetectedCornersCharuco:charucoCorners:charucoIds:")]
		void DrawDetectedCornersCharuco (Mat image, Mat charucoCorners, Mat charucoIds);

		// +(void)drawDetectedCornersCharuco:(Mat * _Nonnull)image charucoCorners:(Mat * _Nonnull)charucoCorners __attribute__((swift_name("drawDetectedCornersCharuco(image:charucoCorners:)")));
		[Static]
		[Export ("drawDetectedCornersCharuco:charucoCorners:")]
		void DrawDetectedCornersCharuco (Mat image, Mat charucoCorners);

		// +(void)drawDetectedDiamonds:(Mat * _Nonnull)image diamondCorners:(NSArray<Mat *> * _Nonnull)diamondCorners diamondIds:(Mat * _Nonnull)diamondIds borderColor:(Scalar * _Nonnull)borderColor __attribute__((swift_name("drawDetectedDiamonds(image:diamondCorners:diamondIds:borderColor:)")));
		[Static]
		[Export ("drawDetectedDiamonds:diamondCorners:diamondIds:borderColor:")]
		void DrawDetectedDiamonds (Mat image, Mat[] diamondCorners, Mat diamondIds, Scalar borderColor);

		// +(void)drawDetectedDiamonds:(Mat * _Nonnull)image diamondCorners:(NSArray<Mat *> * _Nonnull)diamondCorners diamondIds:(Mat * _Nonnull)diamondIds __attribute__((swift_name("drawDetectedDiamonds(image:diamondCorners:diamondIds:)")));
		[Static]
		[Export ("drawDetectedDiamonds:diamondCorners:diamondIds:")]
		void DrawDetectedDiamonds (Mat image, Mat[] diamondCorners, Mat diamondIds);

		// +(void)drawDetectedDiamonds:(Mat * _Nonnull)image diamondCorners:(NSArray<Mat *> * _Nonnull)diamondCorners __attribute__((swift_name("drawDetectedDiamonds(image:diamondCorners:)")));
		[Static]
		[Export ("drawDetectedDiamonds:diamondCorners:")]
		void DrawDetectedDiamonds (Mat image, Mat[] diamondCorners);
	}

	// @interface BaseCascadeClassifier : Algorithm
	[BaseType (typeof(Algorithm))]
	interface BaseCascadeClassifier
	{
	}

	// @interface CascadeClassifier : NSObject
	[BaseType (typeof(NSObject))]
	interface CascadeClassifier
	{
		// -(instancetype _Nonnull)initWithFilename:(NSString * _Nonnull)filename;
		[Export ("initWithFilename:")]
		NativeHandle Constructor (string filename);

		// -(BOOL)empty __attribute__((swift_name("empty()")));
		[Export ("empty")]
		bool Empty { get; }

		// -(BOOL)load:(NSString * _Nonnull)filename __attribute__((swift_name("load(filename:)")));
		[Export ("load:")]
		bool Load (string filename);

		// -(void)detectMultiScale:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects scaleFactor:(double)scaleFactor minNeighbors:(int)minNeighbors flags:(int)flags minSize:(Size2i * _Nonnull)minSize maxSize:(Size2i * _Nonnull)maxSize __attribute__((swift_name("detectMultiScale(image:objects:scaleFactor:minNeighbors:flags:minSize:maxSize:)")));
		[Export ("detectMultiScale:objects:scaleFactor:minNeighbors:flags:minSize:maxSize:")]
		void DetectMultiScale (Mat image, NSMutableArray<Rect2i> objects, double scaleFactor, int minNeighbors, int flags, Size2i minSize, Size2i maxSize);

		// -(void)detectMultiScale:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects scaleFactor:(double)scaleFactor minNeighbors:(int)minNeighbors flags:(int)flags minSize:(Size2i * _Nonnull)minSize __attribute__((swift_name("detectMultiScale(image:objects:scaleFactor:minNeighbors:flags:minSize:)")));
		[Export ("detectMultiScale:objects:scaleFactor:minNeighbors:flags:minSize:")]
		void DetectMultiScale (Mat image, NSMutableArray<Rect2i> objects, double scaleFactor, int minNeighbors, int flags, Size2i minSize);

		// -(void)detectMultiScale:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects scaleFactor:(double)scaleFactor minNeighbors:(int)minNeighbors flags:(int)flags __attribute__((swift_name("detectMultiScale(image:objects:scaleFactor:minNeighbors:flags:)")));
		[Export ("detectMultiScale:objects:scaleFactor:minNeighbors:flags:")]
		void DetectMultiScale (Mat image, NSMutableArray<Rect2i> objects, double scaleFactor, int minNeighbors, int flags);

		// -(void)detectMultiScale:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects scaleFactor:(double)scaleFactor minNeighbors:(int)minNeighbors __attribute__((swift_name("detectMultiScale(image:objects:scaleFactor:minNeighbors:)")));
		[Export ("detectMultiScale:objects:scaleFactor:minNeighbors:")]
		void DetectMultiScale (Mat image, NSMutableArray<Rect2i> objects, double scaleFactor, int minNeighbors);

		// -(void)detectMultiScale:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects scaleFactor:(double)scaleFactor __attribute__((swift_name("detectMultiScale(image:objects:scaleFactor:)")));
		[Export ("detectMultiScale:objects:scaleFactor:")]
		void DetectMultiScale (Mat image, NSMutableArray<Rect2i> objects, double scaleFactor);

		// -(void)detectMultiScale:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects __attribute__((swift_name("detectMultiScale(image:objects:)")));
		[Export ("detectMultiScale:objects:")]
		void DetectMultiScale (Mat image, NSMutableArray<Rect2i> objects);

		// -(void)detectMultiScale2:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects numDetections:(IntVector * _Nonnull)numDetections scaleFactor:(double)scaleFactor minNeighbors:(int)minNeighbors flags:(int)flags minSize:(Size2i * _Nonnull)minSize maxSize:(Size2i * _Nonnull)maxSize __attribute__((swift_name("detectMultiScale(image:objects:numDetections:scaleFactor:minNeighbors:flags:minSize:maxSize:)")));
		[Export ("detectMultiScale2:objects:numDetections:scaleFactor:minNeighbors:flags:minSize:maxSize:")]
		void DetectMultiScale2 (Mat image, NSMutableArray<Rect2i> objects, IntVector numDetections, double scaleFactor, int minNeighbors, int flags, Size2i minSize, Size2i maxSize);

		// -(void)detectMultiScale2:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects numDetections:(IntVector * _Nonnull)numDetections scaleFactor:(double)scaleFactor minNeighbors:(int)minNeighbors flags:(int)flags minSize:(Size2i * _Nonnull)minSize __attribute__((swift_name("detectMultiScale(image:objects:numDetections:scaleFactor:minNeighbors:flags:minSize:)")));
		[Export ("detectMultiScale2:objects:numDetections:scaleFactor:minNeighbors:flags:minSize:")]
		void DetectMultiScale2 (Mat image, NSMutableArray<Rect2i> objects, IntVector numDetections, double scaleFactor, int minNeighbors, int flags, Size2i minSize);

		// -(void)detectMultiScale2:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects numDetections:(IntVector * _Nonnull)numDetections scaleFactor:(double)scaleFactor minNeighbors:(int)minNeighbors flags:(int)flags __attribute__((swift_name("detectMultiScale(image:objects:numDetections:scaleFactor:minNeighbors:flags:)")));
		[Export ("detectMultiScale2:objects:numDetections:scaleFactor:minNeighbors:flags:")]
		void DetectMultiScale2 (Mat image, NSMutableArray<Rect2i> objects, IntVector numDetections, double scaleFactor, int minNeighbors, int flags);

		// -(void)detectMultiScale2:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects numDetections:(IntVector * _Nonnull)numDetections scaleFactor:(double)scaleFactor minNeighbors:(int)minNeighbors __attribute__((swift_name("detectMultiScale(image:objects:numDetections:scaleFactor:minNeighbors:)")));
		[Export ("detectMultiScale2:objects:numDetections:scaleFactor:minNeighbors:")]
		void DetectMultiScale2 (Mat image, NSMutableArray<Rect2i> objects, IntVector numDetections, double scaleFactor, int minNeighbors);

		// -(void)detectMultiScale2:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects numDetections:(IntVector * _Nonnull)numDetections scaleFactor:(double)scaleFactor __attribute__((swift_name("detectMultiScale(image:objects:numDetections:scaleFactor:)")));
		[Export ("detectMultiScale2:objects:numDetections:scaleFactor:")]
		void DetectMultiScale2 (Mat image, NSMutableArray<Rect2i> objects, IntVector numDetections, double scaleFactor);

		// -(void)detectMultiScale2:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects numDetections:(IntVector * _Nonnull)numDetections __attribute__((swift_name("detectMultiScale(image:objects:numDetections:)")));
		[Export ("detectMultiScale2:objects:numDetections:")]
		void DetectMultiScale2 (Mat image, NSMutableArray<Rect2i> objects, IntVector numDetections);

		// -(void)detectMultiScale3:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects rejectLevels:(IntVector * _Nonnull)rejectLevels levelWeights:(DoubleVector * _Nonnull)levelWeights scaleFactor:(double)scaleFactor minNeighbors:(int)minNeighbors flags:(int)flags minSize:(Size2i * _Nonnull)minSize maxSize:(Size2i * _Nonnull)maxSize outputRejectLevels:(BOOL)outputRejectLevels __attribute__((swift_name("detectMultiScale(image:objects:rejectLevels:levelWeights:scaleFactor:minNeighbors:flags:minSize:maxSize:outputRejectLevels:)")));
		[Export ("detectMultiScale3:objects:rejectLevels:levelWeights:scaleFactor:minNeighbors:flags:minSize:maxSize:outputRejectLevels:")]
		void DetectMultiScale3 (Mat image, NSMutableArray<Rect2i> objects, IntVector rejectLevels, DoubleVector levelWeights, double scaleFactor, int minNeighbors, int flags, Size2i minSize, Size2i maxSize, bool outputRejectLevels);

		// -(void)detectMultiScale3:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects rejectLevels:(IntVector * _Nonnull)rejectLevels levelWeights:(DoubleVector * _Nonnull)levelWeights scaleFactor:(double)scaleFactor minNeighbors:(int)minNeighbors flags:(int)flags minSize:(Size2i * _Nonnull)minSize maxSize:(Size2i * _Nonnull)maxSize __attribute__((swift_name("detectMultiScale(image:objects:rejectLevels:levelWeights:scaleFactor:minNeighbors:flags:minSize:maxSize:)")));
		[Export ("detectMultiScale3:objects:rejectLevels:levelWeights:scaleFactor:minNeighbors:flags:minSize:maxSize:")]
		void DetectMultiScale3 (Mat image, NSMutableArray<Rect2i> objects, IntVector rejectLevels, DoubleVector levelWeights, double scaleFactor, int minNeighbors, int flags, Size2i minSize, Size2i maxSize);

		// -(void)detectMultiScale3:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects rejectLevels:(IntVector * _Nonnull)rejectLevels levelWeights:(DoubleVector * _Nonnull)levelWeights scaleFactor:(double)scaleFactor minNeighbors:(int)minNeighbors flags:(int)flags minSize:(Size2i * _Nonnull)minSize __attribute__((swift_name("detectMultiScale(image:objects:rejectLevels:levelWeights:scaleFactor:minNeighbors:flags:minSize:)")));
		[Export ("detectMultiScale3:objects:rejectLevels:levelWeights:scaleFactor:minNeighbors:flags:minSize:")]
		void DetectMultiScale3 (Mat image, NSMutableArray<Rect2i> objects, IntVector rejectLevels, DoubleVector levelWeights, double scaleFactor, int minNeighbors, int flags, Size2i minSize);

		// -(void)detectMultiScale3:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects rejectLevels:(IntVector * _Nonnull)rejectLevels levelWeights:(DoubleVector * _Nonnull)levelWeights scaleFactor:(double)scaleFactor minNeighbors:(int)minNeighbors flags:(int)flags __attribute__((swift_name("detectMultiScale(image:objects:rejectLevels:levelWeights:scaleFactor:minNeighbors:flags:)")));
		[Export ("detectMultiScale3:objects:rejectLevels:levelWeights:scaleFactor:minNeighbors:flags:")]
		void DetectMultiScale3 (Mat image, NSMutableArray<Rect2i> objects, IntVector rejectLevels, DoubleVector levelWeights, double scaleFactor, int minNeighbors, int flags);

		// -(void)detectMultiScale3:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects rejectLevels:(IntVector * _Nonnull)rejectLevels levelWeights:(DoubleVector * _Nonnull)levelWeights scaleFactor:(double)scaleFactor minNeighbors:(int)minNeighbors __attribute__((swift_name("detectMultiScale(image:objects:rejectLevels:levelWeights:scaleFactor:minNeighbors:)")));
		[Export ("detectMultiScale3:objects:rejectLevels:levelWeights:scaleFactor:minNeighbors:")]
		void DetectMultiScale3 (Mat image, NSMutableArray<Rect2i> objects, IntVector rejectLevels, DoubleVector levelWeights, double scaleFactor, int minNeighbors);

		// -(void)detectMultiScale3:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects rejectLevels:(IntVector * _Nonnull)rejectLevels levelWeights:(DoubleVector * _Nonnull)levelWeights scaleFactor:(double)scaleFactor __attribute__((swift_name("detectMultiScale(image:objects:rejectLevels:levelWeights:scaleFactor:)")));
		[Export ("detectMultiScale3:objects:rejectLevels:levelWeights:scaleFactor:")]
		void DetectMultiScale3 (Mat image, NSMutableArray<Rect2i> objects, IntVector rejectLevels, DoubleVector levelWeights, double scaleFactor);

		// -(void)detectMultiScale3:(Mat * _Nonnull)image objects:(NSMutableArray<Rect2i *> * _Nonnull)objects rejectLevels:(IntVector * _Nonnull)rejectLevels levelWeights:(DoubleVector * _Nonnull)levelWeights __attribute__((swift_name("detectMultiScale(image:objects:rejectLevels:levelWeights:)")));
		[Export ("detectMultiScale3:objects:rejectLevels:levelWeights:")]
		void DetectMultiScale3 (Mat image, NSMutableArray<Rect2i> objects, IntVector rejectLevels, DoubleVector levelWeights);

		// -(BOOL)isOldFormatCascade __attribute__((swift_name("isOldFormatCascade()")));
		[Export ("isOldFormatCascade")]
		bool IsOldFormatCascade { get; }

		// -(Size2i * _Nonnull)getOriginalWindowSize __attribute__((swift_name("getOriginalWindowSize()")));
		[Export ("getOriginalWindowSize")]
		Size2i OriginalWindowSize { get; }

		// -(int)getFeatureType __attribute__((swift_name("getFeatureType()")));
		[Export ("getFeatureType")]
		int FeatureType { get; }

		// +(BOOL)convert:(NSString * _Nonnull)oldcascade newcascade:(NSString * _Nonnull)newcascade __attribute__((swift_name("convert(oldcascade:newcascade:)")));
		[Static]
		[Export ("convert:newcascade:")]
		bool Convert (string oldcascade, string newcascade);
	}

	// @interface FaceDetectorYN : NSObject
	[BaseType (typeof(NSObject))]
	interface FaceDetectorYN
	{
		// -(void)setInputSize:(Size2i * _Nonnull)input_size __attribute__((swift_name("setInputSize(input_size:)")));
		[Export ("setInputSize:")]
		void SetInputSize (Size2i input_size);

		// -(Size2i * _Nonnull)getInputSize __attribute__((swift_name("getInputSize()")));
		[Export ("getInputSize")]
		Size2i InputSize { get; }

		// -(void)setScoreThreshold:(float)score_threshold __attribute__((swift_name("setScoreThreshold(score_threshold:)")));
		[Export ("setScoreThreshold:")]
		void SetScoreThreshold (float score_threshold);

		// -(float)getScoreThreshold __attribute__((swift_name("getScoreThreshold()")));
		[Export ("getScoreThreshold")]
		float ScoreThreshold { get; }

		// -(void)setNMSThreshold:(float)nms_threshold __attribute__((swift_name("setNMSThreshold(nms_threshold:)")));
		[Export ("setNMSThreshold:")]
		void SetNMSThreshold (float nms_threshold);

		// -(float)getNMSThreshold __attribute__((swift_name("getNMSThreshold()")));
		[Export ("getNMSThreshold")]
		float NMSThreshold { get; }

		// -(void)setTopK:(int)top_k __attribute__((swift_name("setTopK(top_k:)")));
		[Export ("setTopK:")]
		void SetTopK (int top_k);

		// -(int)getTopK __attribute__((swift_name("getTopK()")));
		[Export ("getTopK")]
		int TopK { get; }

		// -(int)detect:(Mat * _Nonnull)image faces:(Mat * _Nonnull)faces __attribute__((swift_name("detect(image:faces:)")));
		[Export ("detect:faces:")]
		int Detect (Mat image, Mat faces);

		// +(FaceDetectorYN * _Nonnull)create:(NSString * _Nonnull)model config:(NSString * _Nonnull)config input_size:(Size2i * _Nonnull)input_size score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold top_k:(int)top_k backend_id:(int)backend_id target_id:(int)target_id __attribute__((swift_name("create(model:config:input_size:score_threshold:nms_threshold:top_k:backend_id:target_id:)")));
		[Static]
		[Export ("create:config:input_size:score_threshold:nms_threshold:top_k:backend_id:target_id:")]
		FaceDetectorYN Create (string model, string config, Size2i input_size, float score_threshold, float nms_threshold, int top_k, int backend_id, int target_id);

		// +(FaceDetectorYN * _Nonnull)create:(NSString * _Nonnull)model config:(NSString * _Nonnull)config input_size:(Size2i * _Nonnull)input_size score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold top_k:(int)top_k backend_id:(int)backend_id __attribute__((swift_name("create(model:config:input_size:score_threshold:nms_threshold:top_k:backend_id:)")));
		[Static]
		[Export ("create:config:input_size:score_threshold:nms_threshold:top_k:backend_id:")]
		FaceDetectorYN Create (string model, string config, Size2i input_size, float score_threshold, float nms_threshold, int top_k, int backend_id);

		// +(FaceDetectorYN * _Nonnull)create:(NSString * _Nonnull)model config:(NSString * _Nonnull)config input_size:(Size2i * _Nonnull)input_size score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold top_k:(int)top_k __attribute__((swift_name("create(model:config:input_size:score_threshold:nms_threshold:top_k:)")));
		[Static]
		[Export ("create:config:input_size:score_threshold:nms_threshold:top_k:")]
		FaceDetectorYN Create (string model, string config, Size2i input_size, float score_threshold, float nms_threshold, int top_k);

		// +(FaceDetectorYN * _Nonnull)create:(NSString * _Nonnull)model config:(NSString * _Nonnull)config input_size:(Size2i * _Nonnull)input_size score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold __attribute__((swift_name("create(model:config:input_size:score_threshold:nms_threshold:)")));
		[Static]
		[Export ("create:config:input_size:score_threshold:nms_threshold:")]
		FaceDetectorYN Create (string model, string config, Size2i input_size, float score_threshold, float nms_threshold);

		// +(FaceDetectorYN * _Nonnull)create:(NSString * _Nonnull)model config:(NSString * _Nonnull)config input_size:(Size2i * _Nonnull)input_size score_threshold:(float)score_threshold __attribute__((swift_name("create(model:config:input_size:score_threshold:)")));
		[Static]
		[Export ("create:config:input_size:score_threshold:")]
		FaceDetectorYN Create (string model, string config, Size2i input_size, float score_threshold);

		// +(FaceDetectorYN * _Nonnull)create:(NSString * _Nonnull)model config:(NSString * _Nonnull)config input_size:(Size2i * _Nonnull)input_size __attribute__((swift_name("create(model:config:input_size:)")));
		[Static]
		[Export ("create:config:input_size:")]
		FaceDetectorYN Create (string model, string config, Size2i input_size);

		// +(FaceDetectorYN * _Nonnull)create:(NSString * _Nonnull)framework bufferModel:(ByteVector * _Nonnull)bufferModel bufferConfig:(ByteVector * _Nonnull)bufferConfig input_size:(Size2i * _Nonnull)input_size score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold top_k:(int)top_k backend_id:(int)backend_id target_id:(int)target_id __attribute__((swift_name("create(framework:bufferModel:bufferConfig:input_size:score_threshold:nms_threshold:top_k:backend_id:target_id:)")));
		[Static]
		[Export ("create:bufferModel:bufferConfig:input_size:score_threshold:nms_threshold:top_k:backend_id:target_id:")]
		FaceDetectorYN Create (string framework, ByteVector bufferModel, ByteVector bufferConfig, Size2i input_size, float score_threshold, float nms_threshold, int top_k, int backend_id, int target_id);

		// +(FaceDetectorYN * _Nonnull)create:(NSString * _Nonnull)framework bufferModel:(ByteVector * _Nonnull)bufferModel bufferConfig:(ByteVector * _Nonnull)bufferConfig input_size:(Size2i * _Nonnull)input_size score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold top_k:(int)top_k backend_id:(int)backend_id __attribute__((swift_name("create(framework:bufferModel:bufferConfig:input_size:score_threshold:nms_threshold:top_k:backend_id:)")));
		[Static]
		[Export ("create:bufferModel:bufferConfig:input_size:score_threshold:nms_threshold:top_k:backend_id:")]
		FaceDetectorYN Create (string framework, ByteVector bufferModel, ByteVector bufferConfig, Size2i input_size, float score_threshold, float nms_threshold, int top_k, int backend_id);

		// +(FaceDetectorYN * _Nonnull)create:(NSString * _Nonnull)framework bufferModel:(ByteVector * _Nonnull)bufferModel bufferConfig:(ByteVector * _Nonnull)bufferConfig input_size:(Size2i * _Nonnull)input_size score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold top_k:(int)top_k __attribute__((swift_name("create(framework:bufferModel:bufferConfig:input_size:score_threshold:nms_threshold:top_k:)")));
		[Static]
		[Export ("create:bufferModel:bufferConfig:input_size:score_threshold:nms_threshold:top_k:")]
		FaceDetectorYN Create (string framework, ByteVector bufferModel, ByteVector bufferConfig, Size2i input_size, float score_threshold, float nms_threshold, int top_k);

		// +(FaceDetectorYN * _Nonnull)create:(NSString * _Nonnull)framework bufferModel:(ByteVector * _Nonnull)bufferModel bufferConfig:(ByteVector * _Nonnull)bufferConfig input_size:(Size2i * _Nonnull)input_size score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold __attribute__((swift_name("create(framework:bufferModel:bufferConfig:input_size:score_threshold:nms_threshold:)")));
		[Static]
		[Export ("create:bufferModel:bufferConfig:input_size:score_threshold:nms_threshold:")]
		FaceDetectorYN Create (string framework, ByteVector bufferModel, ByteVector bufferConfig, Size2i input_size, float score_threshold, float nms_threshold);

		// +(FaceDetectorYN * _Nonnull)create:(NSString * _Nonnull)framework bufferModel:(ByteVector * _Nonnull)bufferModel bufferConfig:(ByteVector * _Nonnull)bufferConfig input_size:(Size2i * _Nonnull)input_size score_threshold:(float)score_threshold __attribute__((swift_name("create(framework:bufferModel:bufferConfig:input_size:score_threshold:)")));
		[Static]
		[Export ("create:bufferModel:bufferConfig:input_size:score_threshold:")]
		FaceDetectorYN Create (string framework, ByteVector bufferModel, ByteVector bufferConfig, Size2i input_size, float score_threshold);

		// +(FaceDetectorYN * _Nonnull)create:(NSString * _Nonnull)framework bufferModel:(ByteVector * _Nonnull)bufferModel bufferConfig:(ByteVector * _Nonnull)bufferConfig input_size:(Size2i * _Nonnull)input_size __attribute__((swift_name("create(framework:bufferModel:bufferConfig:input_size:)")));
		[Static]
		[Export ("create:bufferModel:bufferConfig:input_size:")]
		FaceDetectorYN Create (string framework, ByteVector bufferModel, ByteVector bufferConfig, Size2i input_size);
	}

	// @interface FaceRecognizerSF : NSObject
	[BaseType (typeof(NSObject))]
	interface FaceRecognizerSF
	{
		// -(void)alignCrop:(Mat * _Nonnull)src_img face_box:(Mat * _Nonnull)face_box aligned_img:(Mat * _Nonnull)aligned_img __attribute__((swift_name("alignCrop(src_img:face_box:aligned_img:)")));
		[Export ("alignCrop:face_box:aligned_img:")]
		void AlignCrop (Mat src_img, Mat face_box, Mat aligned_img);

		// -(void)feature:(Mat * _Nonnull)aligned_img face_feature:(Mat * _Nonnull)face_feature __attribute__((swift_name("feature(aligned_img:face_feature:)")));
		[Export ("feature:face_feature:")]
		void Feature (Mat aligned_img, Mat face_feature);

		// -(double)match:(Mat * _Nonnull)face_feature1 face_feature2:(Mat * _Nonnull)face_feature2 dis_type:(int)dis_type __attribute__((swift_name("match(face_feature1:face_feature2:dis_type:)")));
		[Export ("match:face_feature2:dis_type:")]
		double Match (Mat face_feature1, Mat face_feature2, int dis_type);

		// -(double)match:(Mat * _Nonnull)face_feature1 face_feature2:(Mat * _Nonnull)face_feature2 __attribute__((swift_name("match(face_feature1:face_feature2:)")));
		[Export ("match:face_feature2:")]
		double Match (Mat face_feature1, Mat face_feature2);

		// +(FaceRecognizerSF * _Nonnull)create:(NSString * _Nonnull)model config:(NSString * _Nonnull)config backend_id:(int)backend_id target_id:(int)target_id __attribute__((swift_name("create(model:config:backend_id:target_id:)")));
		[Static]
		[Export ("create:config:backend_id:target_id:")]
		FaceRecognizerSF Create (string model, string config, int backend_id, int target_id);

		// +(FaceRecognizerSF * _Nonnull)create:(NSString * _Nonnull)model config:(NSString * _Nonnull)config backend_id:(int)backend_id __attribute__((swift_name("create(model:config:backend_id:)")));
		[Static]
		[Export ("create:config:backend_id:")]
		FaceRecognizerSF Create (string model, string config, int backend_id);

		// +(FaceRecognizerSF * _Nonnull)create:(NSString * _Nonnull)model config:(NSString * _Nonnull)config __attribute__((swift_name("create(model:config:)")));
		[Static]
		[Export ("create:config:")]
		FaceRecognizerSF Create (string model, string config);

		// +(FaceRecognizerSF * _Nonnull)create:(NSString * _Nonnull)framework bufferModel:(ByteVector * _Nonnull)bufferModel bufferConfig:(ByteVector * _Nonnull)bufferConfig backend_id:(int)backend_id target_id:(int)target_id __attribute__((swift_name("create(framework:bufferModel:bufferConfig:backend_id:target_id:)")));
		[Static]
		[Export ("create:bufferModel:bufferConfig:backend_id:target_id:")]
		FaceRecognizerSF Create (string framework, ByteVector bufferModel, ByteVector bufferConfig, int backend_id, int target_id);

		// +(FaceRecognizerSF * _Nonnull)create:(NSString * _Nonnull)framework bufferModel:(ByteVector * _Nonnull)bufferModel bufferConfig:(ByteVector * _Nonnull)bufferConfig backend_id:(int)backend_id __attribute__((swift_name("create(framework:bufferModel:bufferConfig:backend_id:)")));
		[Static]
		[Export ("create:bufferModel:bufferConfig:backend_id:")]
		FaceRecognizerSF Create (string framework, ByteVector bufferModel, ByteVector bufferConfig, int backend_id);

		// +(FaceRecognizerSF * _Nonnull)create:(NSString * _Nonnull)framework bufferModel:(ByteVector * _Nonnull)bufferModel bufferConfig:(ByteVector * _Nonnull)bufferConfig __attribute__((swift_name("create(framework:bufferModel:bufferConfig:)")));
		[Static]
		[Export ("create:bufferModel:bufferConfig:")]
		FaceRecognizerSF Create (string framework, ByteVector bufferModel, ByteVector bufferConfig);
	}

	// @interface GraphicalCodeDetector : NSObject
	[BaseType (typeof(NSObject))]
	interface GraphicalCodeDetector
	{
		// -(BOOL)detect:(Mat * _Nonnull)img points:(Mat * _Nonnull)points __attribute__((swift_name("detect(img:points:)")));
		[Export ("detect:points:")]
		bool Detect (Mat img, Mat points);

		// -(NSString * _Nonnull)decode:(Mat * _Nonnull)img points:(Mat * _Nonnull)points straight_code:(Mat * _Nonnull)straight_code __attribute__((swift_name("decode(img:points:straight_code:)")));
		[Export ("decode:points:straight_code:")]
		string Decode (Mat img, Mat points, Mat straight_code);

		// -(NSString * _Nonnull)decode:(Mat * _Nonnull)img points:(Mat * _Nonnull)points __attribute__((swift_name("decode(img:points:)")));
		[Export ("decode:points:")]
		string Decode (Mat img, Mat points);

		// -(NSString * _Nonnull)detectAndDecode:(Mat * _Nonnull)img points:(Mat * _Nonnull)points straight_code:(Mat * _Nonnull)straight_code __attribute__((swift_name("detectAndDecode(img:points:straight_code:)")));
		[Export ("detectAndDecode:points:straight_code:")]
		string DetectAndDecode (Mat img, Mat points, Mat straight_code);

		// -(NSString * _Nonnull)detectAndDecode:(Mat * _Nonnull)img points:(Mat * _Nonnull)points __attribute__((swift_name("detectAndDecode(img:points:)")));
		[Export ("detectAndDecode:points:")]
		string DetectAndDecode (Mat img, Mat points);

		// -(NSString * _Nonnull)detectAndDecode:(Mat * _Nonnull)img __attribute__((swift_name("detectAndDecode(img:)")));
		[Export ("detectAndDecode:")]
		string DetectAndDecode (Mat img);

		// -(BOOL)detectMulti:(Mat * _Nonnull)img points:(Mat * _Nonnull)points __attribute__((swift_name("detectMulti(img:points:)")));
		[Export ("detectMulti:points:")]
		bool DetectMulti (Mat img, Mat points);

		// -(BOOL)decodeMulti:(Mat * _Nonnull)img points:(Mat * _Nonnull)points decoded_info:(NSMutableArray<NSString *> * _Nonnull)decoded_info straight_code:(NSMutableArray<Mat *> * _Nonnull)straight_code __attribute__((swift_name("decodeMulti(img:points:decoded_info:straight_code:)")));
		[Export ("decodeMulti:points:decoded_info:straight_code:")]
		bool DecodeMulti (Mat img, Mat points, NSMutableArray<NSString> decoded_info, NSMutableArray<Mat> straight_code);

		// -(BOOL)decodeMulti:(Mat * _Nonnull)img points:(Mat * _Nonnull)points decoded_info:(NSMutableArray<NSString *> * _Nonnull)decoded_info __attribute__((swift_name("decodeMulti(img:points:decoded_info:)")));
		[Export ("decodeMulti:points:decoded_info:")]
		bool DecodeMulti (Mat img, Mat points, NSMutableArray<NSString> decoded_info);

		// -(BOOL)detectAndDecodeMulti:(Mat * _Nonnull)img decoded_info:(NSMutableArray<NSString *> * _Nonnull)decoded_info points:(Mat * _Nonnull)points straight_code:(NSMutableArray<Mat *> * _Nonnull)straight_code __attribute__((swift_name("detectAndDecodeMulti(img:decoded_info:points:straight_code:)")));
		[Export ("detectAndDecodeMulti:decoded_info:points:straight_code:")]
		bool DetectAndDecodeMulti (Mat img, NSMutableArray<NSString> decoded_info, Mat points, NSMutableArray<Mat> straight_code);

		// -(BOOL)detectAndDecodeMulti:(Mat * _Nonnull)img decoded_info:(NSMutableArray<NSString *> * _Nonnull)decoded_info points:(Mat * _Nonnull)points __attribute__((swift_name("detectAndDecodeMulti(img:decoded_info:points:)")));
		[Export ("detectAndDecodeMulti:decoded_info:points:")]
		bool DetectAndDecodeMulti (Mat img, NSMutableArray<NSString> decoded_info, Mat points);

		// -(BOOL)detectAndDecodeMulti:(Mat * _Nonnull)img decoded_info:(NSMutableArray<NSString *> * _Nonnull)decoded_info __attribute__((swift_name("detectAndDecodeMulti(img:decoded_info:)")));
		[Export ("detectAndDecodeMulti:decoded_info:")]
		bool DetectAndDecodeMulti (Mat img, NSMutableArray<NSString> decoded_info);
	}

	// @interface HOGDescriptor : NSObject
	[BaseType (typeof(NSObject))]
	interface HOGDescriptor
	{
		// @property (readonly, class) int DEFAULT_NLEVELS __attribute__((swift_name("DEFAULT_NLEVELS")));
		[Static]
		[Export ("DEFAULT_NLEVELS")]
		int DEFAULT_NLEVELS { get; }

		// -(instancetype _Nonnull)initWith_winSize:(Size2i * _Nonnull)_winSize _blockSize:(Size2i * _Nonnull)_blockSize _blockStride:(Size2i * _Nonnull)_blockStride _cellSize:(Size2i * _Nonnull)_cellSize _nbins:(int)_nbins _derivAperture:(int)_derivAperture _winSigma:(double)_winSigma _histogramNormType:(HistogramNormType)_histogramNormType _L2HysThreshold:(double)_L2HysThreshold _gammaCorrection:(BOOL)_gammaCorrection _nlevels:(int)_nlevels _signedGradient:(BOOL)_signedGradient;
		[Export ("initWith_winSize:_blockSize:_blockStride:_cellSize:_nbins:_derivAperture:_winSigma:_histogramNormType:_L2HysThreshold:_gammaCorrection:_nlevels:_signedGradient:")]
		NativeHandle Constructor (Size2i _winSize, Size2i _blockSize, Size2i _blockStride, Size2i _cellSize, int _nbins, int _derivAperture, double _winSigma, HistogramNormType _histogramNormType, double _L2HysThreshold, bool _gammaCorrection, int _nlevels, bool _signedGradient);

		// -(instancetype _Nonnull)initWith_winSize:(Size2i * _Nonnull)_winSize _blockSize:(Size2i * _Nonnull)_blockSize _blockStride:(Size2i * _Nonnull)_blockStride _cellSize:(Size2i * _Nonnull)_cellSize _nbins:(int)_nbins _derivAperture:(int)_derivAperture _winSigma:(double)_winSigma _histogramNormType:(HistogramNormType)_histogramNormType _L2HysThreshold:(double)_L2HysThreshold _gammaCorrection:(BOOL)_gammaCorrection _nlevels:(int)_nlevels;
		[Export ("initWith_winSize:_blockSize:_blockStride:_cellSize:_nbins:_derivAperture:_winSigma:_histogramNormType:_L2HysThreshold:_gammaCorrection:_nlevels:")]
		NativeHandle Constructor (Size2i _winSize, Size2i _blockSize, Size2i _blockStride, Size2i _cellSize, int _nbins, int _derivAperture, double _winSigma, HistogramNormType _histogramNormType, double _L2HysThreshold, bool _gammaCorrection, int _nlevels);

		// -(instancetype _Nonnull)initWith_winSize:(Size2i * _Nonnull)_winSize _blockSize:(Size2i * _Nonnull)_blockSize _blockStride:(Size2i * _Nonnull)_blockStride _cellSize:(Size2i * _Nonnull)_cellSize _nbins:(int)_nbins _derivAperture:(int)_derivAperture _winSigma:(double)_winSigma _histogramNormType:(HistogramNormType)_histogramNormType _L2HysThreshold:(double)_L2HysThreshold _gammaCorrection:(BOOL)_gammaCorrection;
		[Export ("initWith_winSize:_blockSize:_blockStride:_cellSize:_nbins:_derivAperture:_winSigma:_histogramNormType:_L2HysThreshold:_gammaCorrection:")]
		NativeHandle Constructor (Size2i _winSize, Size2i _blockSize, Size2i _blockStride, Size2i _cellSize, int _nbins, int _derivAperture, double _winSigma, HistogramNormType _histogramNormType, double _L2HysThreshold, bool _gammaCorrection);

		// -(instancetype _Nonnull)initWith_winSize:(Size2i * _Nonnull)_winSize _blockSize:(Size2i * _Nonnull)_blockSize _blockStride:(Size2i * _Nonnull)_blockStride _cellSize:(Size2i * _Nonnull)_cellSize _nbins:(int)_nbins _derivAperture:(int)_derivAperture _winSigma:(double)_winSigma _histogramNormType:(HistogramNormType)_histogramNormType _L2HysThreshold:(double)_L2HysThreshold;
		[Export ("initWith_winSize:_blockSize:_blockStride:_cellSize:_nbins:_derivAperture:_winSigma:_histogramNormType:_L2HysThreshold:")]
		NativeHandle Constructor (Size2i _winSize, Size2i _blockSize, Size2i _blockStride, Size2i _cellSize, int _nbins, int _derivAperture, double _winSigma, HistogramNormType _histogramNormType, double _L2HysThreshold);

		// -(instancetype _Nonnull)initWith_winSize:(Size2i * _Nonnull)_winSize _blockSize:(Size2i * _Nonnull)_blockSize _blockStride:(Size2i * _Nonnull)_blockStride _cellSize:(Size2i * _Nonnull)_cellSize _nbins:(int)_nbins _derivAperture:(int)_derivAperture _winSigma:(double)_winSigma _histogramNormType:(HistogramNormType)_histogramNormType;
		[Export ("initWith_winSize:_blockSize:_blockStride:_cellSize:_nbins:_derivAperture:_winSigma:_histogramNormType:")]
		NativeHandle Constructor (Size2i _winSize, Size2i _blockSize, Size2i _blockStride, Size2i _cellSize, int _nbins, int _derivAperture, double _winSigma, HistogramNormType _histogramNormType);

		// -(instancetype _Nonnull)initWith_winSize:(Size2i * _Nonnull)_winSize _blockSize:(Size2i * _Nonnull)_blockSize _blockStride:(Size2i * _Nonnull)_blockStride _cellSize:(Size2i * _Nonnull)_cellSize _nbins:(int)_nbins _derivAperture:(int)_derivAperture _winSigma:(double)_winSigma;
		[Export ("initWith_winSize:_blockSize:_blockStride:_cellSize:_nbins:_derivAperture:_winSigma:")]
		NativeHandle Constructor (Size2i _winSize, Size2i _blockSize, Size2i _blockStride, Size2i _cellSize, int _nbins, int _derivAperture, double _winSigma);

		// -(instancetype _Nonnull)initWith_winSize:(Size2i * _Nonnull)_winSize _blockSize:(Size2i * _Nonnull)_blockSize _blockStride:(Size2i * _Nonnull)_blockStride _cellSize:(Size2i * _Nonnull)_cellSize _nbins:(int)_nbins _derivAperture:(int)_derivAperture;
		[Export ("initWith_winSize:_blockSize:_blockStride:_cellSize:_nbins:_derivAperture:")]
		NativeHandle Constructor (Size2i _winSize, Size2i _blockSize, Size2i _blockStride, Size2i _cellSize, int _nbins, int _derivAperture);

		// -(instancetype _Nonnull)initWith_winSize:(Size2i * _Nonnull)_winSize _blockSize:(Size2i * _Nonnull)_blockSize _blockStride:(Size2i * _Nonnull)_blockStride _cellSize:(Size2i * _Nonnull)_cellSize _nbins:(int)_nbins;
		[Export ("initWith_winSize:_blockSize:_blockStride:_cellSize:_nbins:")]
		NativeHandle Constructor (Size2i _winSize, Size2i _blockSize, Size2i _blockStride, Size2i _cellSize, int _nbins);

		// -(instancetype _Nonnull)initWithFilename:(NSString * _Nonnull)filename;
		[Export ("initWithFilename:")]
		NativeHandle Constructor (string filename);

		// -(size_t)getDescriptorSize __attribute__((swift_name("getDescriptorSize()")));
		[Export ("getDescriptorSize")]
		nuint DescriptorSize { get; }

		// -(BOOL)checkDetectorSize __attribute__((swift_name("checkDetectorSize()")));
		[Export ("checkDetectorSize")]
		bool CheckDetectorSize { get; }

		// -(double)getWinSigma __attribute__((swift_name("getWinSigma()")));
		[Export ("getWinSigma")]
		double GetWinSigma ();

		// -(void)setSVMDetector:(Mat * _Nonnull)svmdetector __attribute__((swift_name("setSVMDetector(svmdetector:)")));
		[Export ("setSVMDetector:")]
		void SetSVMDetector (Mat svmdetector);

		// -(BOOL)load:(NSString * _Nonnull)filename objname:(NSString * _Nonnull)objname __attribute__((swift_name("load(filename:objname:)")));
		[Export ("load:objname:")]
		bool Load (string filename, string objname);

		// -(BOOL)load:(NSString * _Nonnull)filename __attribute__((swift_name("load(filename:)")));
		[Export ("load:")]
		bool Load (string filename);

		// -(void)save:(NSString * _Nonnull)filename objname:(NSString * _Nonnull)objname __attribute__((swift_name("save(filename:objname:)")));
		[Export ("save:objname:")]
		void Save (string filename, string objname);

		// -(void)save:(NSString * _Nonnull)filename __attribute__((swift_name("save(filename:)")));
		[Export ("save:")]
		void Save (string filename);

		// -(void)compute:(Mat * _Nonnull)img descriptors:(FloatVector * _Nonnull)descriptors winStride:(Size2i * _Nonnull)winStride padding:(Size2i * _Nonnull)padding locations:(NSArray<Point2i *> * _Nonnull)locations __attribute__((swift_name("compute(img:descriptors:winStride:padding:locations:)")));
		[Export ("compute:descriptors:winStride:padding:locations:")]
		void Compute (Mat img, FloatVector descriptors, Size2i winStride, Size2i padding, Point2i[] locations);

		// -(void)compute:(Mat * _Nonnull)img descriptors:(FloatVector * _Nonnull)descriptors winStride:(Size2i * _Nonnull)winStride padding:(Size2i * _Nonnull)padding __attribute__((swift_name("compute(img:descriptors:winStride:padding:)")));
		[Export ("compute:descriptors:winStride:padding:")]
		void Compute (Mat img, FloatVector descriptors, Size2i winStride, Size2i padding);

		// -(void)compute:(Mat * _Nonnull)img descriptors:(FloatVector * _Nonnull)descriptors winStride:(Size2i * _Nonnull)winStride __attribute__((swift_name("compute(img:descriptors:winStride:)")));
		[Export ("compute:descriptors:winStride:")]
		void Compute (Mat img, FloatVector descriptors, Size2i winStride);

		// -(void)compute:(Mat * _Nonnull)img descriptors:(FloatVector * _Nonnull)descriptors __attribute__((swift_name("compute(img:descriptors:)")));
		[Export ("compute:descriptors:")]
		void Compute (Mat img, FloatVector descriptors);

		// -(void)detect:(Mat * _Nonnull)img foundLocations:(NSMutableArray<Point2i *> * _Nonnull)foundLocations weights:(DoubleVector * _Nonnull)weights hitThreshold:(double)hitThreshold winStride:(Size2i * _Nonnull)winStride padding:(Size2i * _Nonnull)padding searchLocations:(NSArray<Point2i *> * _Nonnull)searchLocations __attribute__((swift_name("detect(img:foundLocations:weights:hitThreshold:winStride:padding:searchLocations:)")));
		[Export ("detect:foundLocations:weights:hitThreshold:winStride:padding:searchLocations:")]
		void Detect (Mat img, NSMutableArray<Point2i> foundLocations, DoubleVector weights, double hitThreshold, Size2i winStride, Size2i padding, Point2i[] searchLocations);

		// -(void)detect:(Mat * _Nonnull)img foundLocations:(NSMutableArray<Point2i *> * _Nonnull)foundLocations weights:(DoubleVector * _Nonnull)weights hitThreshold:(double)hitThreshold winStride:(Size2i * _Nonnull)winStride padding:(Size2i * _Nonnull)padding __attribute__((swift_name("detect(img:foundLocations:weights:hitThreshold:winStride:padding:)")));
		[Export ("detect:foundLocations:weights:hitThreshold:winStride:padding:")]
		void Detect (Mat img, NSMutableArray<Point2i> foundLocations, DoubleVector weights, double hitThreshold, Size2i winStride, Size2i padding);

		// -(void)detect:(Mat * _Nonnull)img foundLocations:(NSMutableArray<Point2i *> * _Nonnull)foundLocations weights:(DoubleVector * _Nonnull)weights hitThreshold:(double)hitThreshold winStride:(Size2i * _Nonnull)winStride __attribute__((swift_name("detect(img:foundLocations:weights:hitThreshold:winStride:)")));
		[Export ("detect:foundLocations:weights:hitThreshold:winStride:")]
		void Detect (Mat img, NSMutableArray<Point2i> foundLocations, DoubleVector weights, double hitThreshold, Size2i winStride);

		// -(void)detect:(Mat * _Nonnull)img foundLocations:(NSMutableArray<Point2i *> * _Nonnull)foundLocations weights:(DoubleVector * _Nonnull)weights hitThreshold:(double)hitThreshold __attribute__((swift_name("detect(img:foundLocations:weights:hitThreshold:)")));
		[Export ("detect:foundLocations:weights:hitThreshold:")]
		void Detect (Mat img, NSMutableArray<Point2i> foundLocations, DoubleVector weights, double hitThreshold);

		// -(void)detect:(Mat * _Nonnull)img foundLocations:(NSMutableArray<Point2i *> * _Nonnull)foundLocations weights:(DoubleVector * _Nonnull)weights __attribute__((swift_name("detect(img:foundLocations:weights:)")));
		[Export ("detect:foundLocations:weights:")]
		void Detect (Mat img, NSMutableArray<Point2i> foundLocations, DoubleVector weights);

		// -(void)detectMultiScale:(Mat * _Nonnull)img foundLocations:(NSMutableArray<Rect2i *> * _Nonnull)foundLocations foundWeights:(DoubleVector * _Nonnull)foundWeights hitThreshold:(double)hitThreshold winStride:(Size2i * _Nonnull)winStride padding:(Size2i * _Nonnull)padding scale:(double)scale groupThreshold:(double)groupThreshold useMeanshiftGrouping:(BOOL)useMeanshiftGrouping __attribute__((swift_name("detectMultiScale(img:foundLocations:foundWeights:hitThreshold:winStride:padding:scale:groupThreshold:useMeanshiftGrouping:)")));
		[Export ("detectMultiScale:foundLocations:foundWeights:hitThreshold:winStride:padding:scale:groupThreshold:useMeanshiftGrouping:")]
		void DetectMultiScale (Mat img, NSMutableArray<Rect2i> foundLocations, DoubleVector foundWeights, double hitThreshold, Size2i winStride, Size2i padding, double scale, double groupThreshold, bool useMeanshiftGrouping);

		// -(void)detectMultiScale:(Mat * _Nonnull)img foundLocations:(NSMutableArray<Rect2i *> * _Nonnull)foundLocations foundWeights:(DoubleVector * _Nonnull)foundWeights hitThreshold:(double)hitThreshold winStride:(Size2i * _Nonnull)winStride padding:(Size2i * _Nonnull)padding scale:(double)scale groupThreshold:(double)groupThreshold __attribute__((swift_name("detectMultiScale(img:foundLocations:foundWeights:hitThreshold:winStride:padding:scale:groupThreshold:)")));
		[Export ("detectMultiScale:foundLocations:foundWeights:hitThreshold:winStride:padding:scale:groupThreshold:")]
		void DetectMultiScale (Mat img, NSMutableArray<Rect2i> foundLocations, DoubleVector foundWeights, double hitThreshold, Size2i winStride, Size2i padding, double scale, double groupThreshold);

		// -(void)detectMultiScale:(Mat * _Nonnull)img foundLocations:(NSMutableArray<Rect2i *> * _Nonnull)foundLocations foundWeights:(DoubleVector * _Nonnull)foundWeights hitThreshold:(double)hitThreshold winStride:(Size2i * _Nonnull)winStride padding:(Size2i * _Nonnull)padding scale:(double)scale __attribute__((swift_name("detectMultiScale(img:foundLocations:foundWeights:hitThreshold:winStride:padding:scale:)")));
		[Export ("detectMultiScale:foundLocations:foundWeights:hitThreshold:winStride:padding:scale:")]
		void DetectMultiScale (Mat img, NSMutableArray<Rect2i> foundLocations, DoubleVector foundWeights, double hitThreshold, Size2i winStride, Size2i padding, double scale);

		// -(void)detectMultiScale:(Mat * _Nonnull)img foundLocations:(NSMutableArray<Rect2i *> * _Nonnull)foundLocations foundWeights:(DoubleVector * _Nonnull)foundWeights hitThreshold:(double)hitThreshold winStride:(Size2i * _Nonnull)winStride padding:(Size2i * _Nonnull)padding __attribute__((swift_name("detectMultiScale(img:foundLocations:foundWeights:hitThreshold:winStride:padding:)")));
		[Export ("detectMultiScale:foundLocations:foundWeights:hitThreshold:winStride:padding:")]
		void DetectMultiScale (Mat img, NSMutableArray<Rect2i> foundLocations, DoubleVector foundWeights, double hitThreshold, Size2i winStride, Size2i padding);

		// -(void)detectMultiScale:(Mat * _Nonnull)img foundLocations:(NSMutableArray<Rect2i *> * _Nonnull)foundLocations foundWeights:(DoubleVector * _Nonnull)foundWeights hitThreshold:(double)hitThreshold winStride:(Size2i * _Nonnull)winStride __attribute__((swift_name("detectMultiScale(img:foundLocations:foundWeights:hitThreshold:winStride:)")));
		[Export ("detectMultiScale:foundLocations:foundWeights:hitThreshold:winStride:")]
		void DetectMultiScale (Mat img, NSMutableArray<Rect2i> foundLocations, DoubleVector foundWeights, double hitThreshold, Size2i winStride);

		// -(void)detectMultiScale:(Mat * _Nonnull)img foundLocations:(NSMutableArray<Rect2i *> * _Nonnull)foundLocations foundWeights:(DoubleVector * _Nonnull)foundWeights hitThreshold:(double)hitThreshold __attribute__((swift_name("detectMultiScale(img:foundLocations:foundWeights:hitThreshold:)")));
		[Export ("detectMultiScale:foundLocations:foundWeights:hitThreshold:")]
		void DetectMultiScale (Mat img, NSMutableArray<Rect2i> foundLocations, DoubleVector foundWeights, double hitThreshold);

		// -(void)detectMultiScale:(Mat * _Nonnull)img foundLocations:(NSMutableArray<Rect2i *> * _Nonnull)foundLocations foundWeights:(DoubleVector * _Nonnull)foundWeights __attribute__((swift_name("detectMultiScale(img:foundLocations:foundWeights:)")));
		[Export ("detectMultiScale:foundLocations:foundWeights:")]
		void DetectMultiScale (Mat img, NSMutableArray<Rect2i> foundLocations, DoubleVector foundWeights);

		// -(void)computeGradient:(Mat * _Nonnull)img grad:(Mat * _Nonnull)grad angleOfs:(Mat * _Nonnull)angleOfs paddingTL:(Size2i * _Nonnull)paddingTL paddingBR:(Size2i * _Nonnull)paddingBR __attribute__((swift_name("computeGradient(img:grad:angleOfs:paddingTL:paddingBR:)")));
		[Export ("computeGradient:grad:angleOfs:paddingTL:paddingBR:")]
		void ComputeGradient (Mat img, Mat grad, Mat angleOfs, Size2i paddingTL, Size2i paddingBR);

		// -(void)computeGradient:(Mat * _Nonnull)img grad:(Mat * _Nonnull)grad angleOfs:(Mat * _Nonnull)angleOfs paddingTL:(Size2i * _Nonnull)paddingTL __attribute__((swift_name("computeGradient(img:grad:angleOfs:paddingTL:)")));
		[Export ("computeGradient:grad:angleOfs:paddingTL:")]
		void ComputeGradient (Mat img, Mat grad, Mat angleOfs, Size2i paddingTL);

		// -(void)computeGradient:(Mat * _Nonnull)img grad:(Mat * _Nonnull)grad angleOfs:(Mat * _Nonnull)angleOfs __attribute__((swift_name("computeGradient(img:grad:angleOfs:)")));
		[Export ("computeGradient:grad:angleOfs:")]
		void ComputeGradient (Mat img, Mat grad, Mat angleOfs);

		// +(FloatVector * _Nonnull)getDefaultPeopleDetector __attribute__((swift_name("getDefaultPeopleDetector()")));
		[Static]
		[Export ("getDefaultPeopleDetector")]
		FloatVector DefaultPeopleDetector { get; }

		// +(FloatVector * _Nonnull)getDaimlerPeopleDetector __attribute__((swift_name("getDaimlerPeopleDetector()")));
		[Static]
		[Export ("getDaimlerPeopleDetector")]
		FloatVector DaimlerPeopleDetector { get; }

		// @property (readonly) Size2i * _Nonnull winSize;
		[Export ("winSize")]
		Size2i WinSize { get; }

		// @property (readonly) Size2i * _Nonnull blockSize;
		[Export ("blockSize")]
		Size2i BlockSize { get; }

		// @property (readonly) Size2i * _Nonnull blockStride;
		[Export ("blockStride")]
		Size2i BlockStride { get; }

		// @property (readonly) Size2i * _Nonnull cellSize;
		[Export ("cellSize")]
		Size2i CellSize { get; }

		// @property (readonly) int nbins;
		[Export ("nbins")]
		int Nbins { get; }

		// @property (readonly) int derivAperture;
		[Export ("derivAperture")]
		int DerivAperture { get; }

		// @property (readonly) double winSigma;
		[Export ("winSigma")]
		double WinSigma { get; }

		// @property (readonly) HistogramNormType histogramNormType;
		[Export ("histogramNormType")]
		HistogramNormType HistogramNormType { get; }

		// @property (readonly) double L2HysThreshold;
		[Export ("L2HysThreshold")]
		double L2HysThreshold { get; }

		// @property (readonly) BOOL gammaCorrection;
		[Export ("gammaCorrection")]
		bool GammaCorrection { get; }

		// @property (readonly) FloatVector * _Nonnull svmDetector;
		[Export ("svmDetector")]
		FloatVector SvmDetector { get; }

		// @property (readonly) int nlevels;
		[Export ("nlevels")]
		int Nlevels { get; }

		// @property (readonly) BOOL signedGradient;
		[Export ("signedGradient")]
		bool SignedGradient { get; }
	}

	// @interface QRCodeEncoder : NSObject
	[BaseType (typeof(NSObject))]
	interface QRCodeEncoder
	{
		// +(QRCodeEncoder * _Nonnull)create:(QRCodeEncoderParams * _Nonnull)parameters __attribute__((swift_name("create(parameters:)")));
		[Static]
		[Export ("create:")]
		QRCodeEncoder Create (QRCodeEncoderParams parameters);

		// +(QRCodeEncoder * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		QRCodeEncoder Create ();

		// -(void)encode:(NSString * _Nonnull)encoded_info qrcode:(Mat * _Nonnull)qrcode __attribute__((swift_name("encode(encoded_info:qrcode:)")));
		[Export ("encode:qrcode:")]
		void Encode (string encoded_info, Mat qrcode);

		// -(void)encodeStructuredAppend:(NSString * _Nonnull)encoded_info qrcodes:(NSMutableArray<Mat *> * _Nonnull)qrcodes __attribute__((swift_name("encodeStructuredAppend(encoded_info:qrcodes:)")));
		[Export ("encodeStructuredAppend:qrcodes:")]
		void EncodeStructuredAppend (string encoded_info, NSMutableArray<Mat> qrcodes);
	}

	// @interface QRCodeDetector : GraphicalCodeDetector
	[BaseType (typeof(GraphicalCodeDetector))]
	interface QRCodeDetector
	{
		// -(QRCodeDetector * _Nonnull)setEpsX:(double)epsX __attribute__((swift_name("setEpsX(epsX:)")));
		[Export ("setEpsX:")]
		QRCodeDetector SetEpsX (double epsX);

		// -(QRCodeDetector * _Nonnull)setEpsY:(double)epsY __attribute__((swift_name("setEpsY(epsY:)")));
		[Export ("setEpsY:")]
		QRCodeDetector SetEpsY (double epsY);

		// -(QRCodeDetector * _Nonnull)setUseAlignmentMarkers:(BOOL)useAlignmentMarkers __attribute__((swift_name("setUseAlignmentMarkers(useAlignmentMarkers:)")));
		[Export ("setUseAlignmentMarkers:")]
		QRCodeDetector SetUseAlignmentMarkers (bool useAlignmentMarkers);

		// -(NSString * _Nonnull)decodeCurved:(Mat * _Nonnull)img points:(Mat * _Nonnull)points straight_qrcode:(Mat * _Nonnull)straight_qrcode __attribute__((swift_name("decodeCurved(img:points:straight_qrcode:)")));
		[Export ("decodeCurved:points:straight_qrcode:")]
		string DecodeCurved (Mat img, Mat points, Mat straight_qrcode);

		// -(NSString * _Nonnull)decodeCurved:(Mat * _Nonnull)img points:(Mat * _Nonnull)points __attribute__((swift_name("decodeCurved(img:points:)")));
		[Export ("decodeCurved:points:")]
		string DecodeCurved (Mat img, Mat points);

		// -(NSString * _Nonnull)detectAndDecodeCurved:(Mat * _Nonnull)img points:(Mat * _Nonnull)points straight_qrcode:(Mat * _Nonnull)straight_qrcode __attribute__((swift_name("detectAndDecodeCurved(img:points:straight_qrcode:)")));
		[Export ("detectAndDecodeCurved:points:straight_qrcode:")]
		string DetectAndDecodeCurved (Mat img, Mat points, Mat straight_qrcode);

		// -(NSString * _Nonnull)detectAndDecodeCurved:(Mat * _Nonnull)img points:(Mat * _Nonnull)points __attribute__((swift_name("detectAndDecodeCurved(img:points:)")));
		[Export ("detectAndDecodeCurved:points:")]
		string DetectAndDecodeCurved (Mat img, Mat points);

		// -(NSString * _Nonnull)detectAndDecodeCurved:(Mat * _Nonnull)img __attribute__((swift_name("detectAndDecodeCurved(img:)")));
		[Export ("detectAndDecodeCurved:")]
		string DetectAndDecodeCurved (Mat img);

		// -(ECIEncodings)getEncoding:(int)codeIdx __attribute__((swift_name("getEncoding(codeIdx:)")));
		[Export ("getEncoding:")]
		ECIEncodings GetEncoding (int codeIdx);

		// -(ECIEncodings)getEncoding __attribute__((swift_name("getEncoding()")));
		[Export ("getEncoding")]
		ECIEncodings Encoding { get; }
	}

	// @interface QRCodeDetectorAruco : GraphicalCodeDetector
	[BaseType (typeof(GraphicalCodeDetector))]
	interface QRCodeDetectorAruco
	{
		// -(instancetype _Nonnull)initWithParams:(QRCodeDetectorArucoParams * _Nonnull)params;
		[Export ("initWithParams:")]
		NativeHandle Constructor (QRCodeDetectorArucoParams @params);

		// -(QRCodeDetectorAruco * _Nonnull)setDetectorParameters:(QRCodeDetectorArucoParams * _Nonnull)params __attribute__((swift_name("setDetectorParameters(params:)")));
		[Export ("setDetectorParameters:")]
		QRCodeDetectorAruco SetDetectorParameters (QRCodeDetectorArucoParams @params);
	}

	// @interface QRCodeDetectorArucoParams : NSObject
	[BaseType (typeof(NSObject))]
	interface QRCodeDetectorArucoParams
	{
		// @property float minModuleSizeInPyramid;
		[Export ("minModuleSizeInPyramid")]
		float MinModuleSizeInPyramid { get; set; }

		// @property float maxRotation;
		[Export ("maxRotation")]
		float MaxRotation { get; set; }

		// @property float maxModuleSizeMismatch;
		[Export ("maxModuleSizeMismatch")]
		float MaxModuleSizeMismatch { get; set; }

		// @property float maxTimingPatternMismatch;
		[Export ("maxTimingPatternMismatch")]
		float MaxTimingPatternMismatch { get; set; }

		// @property float maxPenalties;
		[Export ("maxPenalties")]
		float MaxPenalties { get; set; }

		// @property float maxColorsMismatch;
		[Export ("maxColorsMismatch")]
		float MaxColorsMismatch { get; set; }

		// @property float scaleTimingPatternScore;
		[Export ("scaleTimingPatternScore")]
		float ScaleTimingPatternScore { get; set; }
	}

	// @interface QRCodeEncoderParams : NSObject
	[BaseType (typeof(NSObject))]
	interface QRCodeEncoderParams
	{
		// @property int version;
		[Export ("version")]
		int Version { get; set; }

		// @property CorrectionLevel correction_level;
		[Export ("correction_level", ArgumentSemantic.Assign)]
		CorrectionLevel Correction_level { get; set; }

		// @property EncodeMode mode;
		[Export ("mode", ArgumentSemantic.Assign)]
		EncodeMode Mode { get; set; }

		// @property int structure_number;
		[Export ("structure_number")]
		int Structure_number { get; set; }
	}

	// @interface ArucoDetector : Algorithm
	[BaseType (typeof(Algorithm))]
	interface ArucoDetector
	{
		// -(instancetype _Nonnull)initWithDictionary:(DetectorParameters * _Nonnull)detectorParams refineParams:(RefineParameters * _Nonnull)refineParams;
		[Export ("initWithDictionary:refineParams:")]
		NativeHandle Constructor (DetectorParameters detectorParams, RefineParameters refineParams);

		// -(instancetype _Nonnull)initWithDictionary:(DetectorParameters * _Nonnull)detectorParams;
		[Export ("initWithDictionary:")]
		NativeHandle Constructor (DetectorParameters detectorParams);

		// -(void)detectMarkers:(Mat * _Nonnull)image corners:(NSMutableArray<Mat *> * _Nonnull)corners ids:(Mat * _Nonnull)ids rejectedImgPoints:(NSMutableArray<Mat *> * _Nonnull)rejectedImgPoints __attribute__((swift_name("detectMarkers(image:corners:ids:rejectedImgPoints:)")));
		[Export ("detectMarkers:corners:ids:rejectedImgPoints:")]
		void DetectMarkers (Mat image, NSMutableArray<Mat> corners, Mat ids, NSMutableArray<Mat> rejectedImgPoints);

		// -(void)detectMarkers:(Mat * _Nonnull)image corners:(NSMutableArray<Mat *> * _Nonnull)corners ids:(Mat * _Nonnull)ids __attribute__((swift_name("detectMarkers(image:corners:ids:)")));
		[Export ("detectMarkers:corners:ids:")]
		void DetectMarkers (Mat image, NSMutableArray<Mat> corners, Mat ids);

		// -(void)refineDetectedMarkers:(Mat * _Nonnull)image board:(Board * _Nonnull)board detectedCorners:(NSMutableArray<Mat *> * _Nonnull)detectedCorners detectedIds:(Mat * _Nonnull)detectedIds rejectedCorners:(NSMutableArray<Mat *> * _Nonnull)rejectedCorners cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs recoveredIdxs:(Mat * _Nonnull)recoveredIdxs __attribute__((swift_name("refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:distCoeffs:recoveredIdxs:)")));
		[Export ("refineDetectedMarkers:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:distCoeffs:recoveredIdxs:")]
		void RefineDetectedMarkers (Mat image, Board board, NSMutableArray<Mat> detectedCorners, Mat detectedIds, NSMutableArray<Mat> rejectedCorners, Mat cameraMatrix, Mat distCoeffs, Mat recoveredIdxs);

		// -(void)refineDetectedMarkers:(Mat * _Nonnull)image board:(Board * _Nonnull)board detectedCorners:(NSMutableArray<Mat *> * _Nonnull)detectedCorners detectedIds:(Mat * _Nonnull)detectedIds rejectedCorners:(NSMutableArray<Mat *> * _Nonnull)rejectedCorners cameraMatrix:(Mat * _Nonnull)cameraMatrix distCoeffs:(Mat * _Nonnull)distCoeffs __attribute__((swift_name("refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:distCoeffs:)")));
		[Export ("refineDetectedMarkers:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:distCoeffs:")]
		void RefineDetectedMarkers (Mat image, Board board, NSMutableArray<Mat> detectedCorners, Mat detectedIds, NSMutableArray<Mat> rejectedCorners, Mat cameraMatrix, Mat distCoeffs);

		// -(void)refineDetectedMarkers:(Mat * _Nonnull)image board:(Board * _Nonnull)board detectedCorners:(NSMutableArray<Mat *> * _Nonnull)detectedCorners detectedIds:(Mat * _Nonnull)detectedIds rejectedCorners:(NSMutableArray<Mat *> * _Nonnull)rejectedCorners cameraMatrix:(Mat * _Nonnull)cameraMatrix __attribute__((swift_name("refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:)")));
		[Export ("refineDetectedMarkers:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:")]
		void RefineDetectedMarkers (Mat image, Board board, NSMutableArray<Mat> detectedCorners, Mat detectedIds, NSMutableArray<Mat> rejectedCorners, Mat cameraMatrix);

		// -(void)refineDetectedMarkers:(Mat * _Nonnull)image board:(Board * _Nonnull)board detectedCorners:(NSMutableArray<Mat *> * _Nonnull)detectedCorners detectedIds:(Mat * _Nonnull)detectedIds rejectedCorners:(NSMutableArray<Mat *> * _Nonnull)rejectedCorners __attribute__((swift_name("refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:)")));
		[Export ("refineDetectedMarkers:board:detectedCorners:detectedIds:rejectedCorners:")]
		void RefineDetectedMarkers (Mat image, Board board, NSMutableArray<Mat> detectedCorners, Mat detectedIds, NSMutableArray<Mat> rejectedCorners);

		// -(void)detectMarkersMultiDict:(Mat * _Nonnull)image corners:(NSMutableArray<Mat *> * _Nonnull)corners ids:(Mat * _Nonnull)ids rejectedImgPoints:(NSMutableArray<Mat *> * _Nonnull)rejectedImgPoints dictIndices:(Mat * _Nonnull)dictIndices __attribute__((swift_name("detectMarkersMultiDict(image:corners:ids:rejectedImgPoints:dictIndices:)")));
		[Export ("detectMarkersMultiDict:corners:ids:rejectedImgPoints:dictIndices:")]
		void DetectMarkersMultiDict (Mat image, NSMutableArray<Mat> corners, Mat ids, NSMutableArray<Mat> rejectedImgPoints, Mat dictIndices);

		// -(void)detectMarkersMultiDict:(Mat * _Nonnull)image corners:(NSMutableArray<Mat *> * _Nonnull)corners ids:(Mat * _Nonnull)ids rejectedImgPoints:(NSMutableArray<Mat *> * _Nonnull)rejectedImgPoints __attribute__((swift_name("detectMarkersMultiDict(image:corners:ids:rejectedImgPoints:)")));
		[Export ("detectMarkersMultiDict:corners:ids:rejectedImgPoints:")]
		void DetectMarkersMultiDict (Mat image, NSMutableArray<Mat> corners, Mat ids, NSMutableArray<Mat> rejectedImgPoints);

		// -(void)detectMarkersMultiDict:(Mat * _Nonnull)image corners:(NSMutableArray<Mat *> * _Nonnull)corners ids:(Mat * _Nonnull)ids __attribute__((swift_name("detectMarkersMultiDict(image:corners:ids:)")));
		[Export ("detectMarkersMultiDict:corners:ids:")]
		void DetectMarkersMultiDict (Mat image, NSMutableArray<Mat> corners, Mat ids);

		// -(Dictionary * _Nonnull)getDictionary __attribute__((swift_name("getDictionary()")));
		[Export ("getDictionary")]
		Dictionary Dictionary { get; }

		// -(void)setDictionary:(Dictionary * _Nonnull)dictionary __attribute__((swift_name("setDictionary(dictionary:)")));
		[Export ("setDictionary:")]
		void SetDictionary (Dictionary dictionary);

		// -(DetectorParameters * _Nonnull)getDetectorParameters __attribute__((swift_name("getDetectorParameters()")));
		[Export ("getDetectorParameters")]
		DetectorParameters DetectorParameters { get; }

		// -(void)setDetectorParameters:(DetectorParameters * _Nonnull)detectorParameters __attribute__((swift_name("setDetectorParameters(detectorParameters:)")));
		[Export ("setDetectorParameters:")]
		void SetDetectorParameters (DetectorParameters detectorParameters);

		// -(RefineParameters * _Nonnull)getRefineParameters __attribute__((swift_name("getRefineParameters()")));
		[Export ("getRefineParameters")]
		RefineParameters RefineParameters { get; }

		// -(void)setRefineParameters:(RefineParameters * _Nonnull)refineParameters __attribute__((swift_name("setRefineParameters(refineParameters:)")));
		[Export ("setRefineParameters:")]
		void SetRefineParameters (RefineParameters refineParameters);
	}

	// @interface Board : NSObject
	[BaseType (typeof(NSObject))]
	interface Board
	{
		// -(instancetype _Nonnull)initWithObjPoints:(NSArray<Mat *> * _Nonnull)objPoints dictionary:(Dictionary * _Nonnull)dictionary ids:(Mat * _Nonnull)ids;
		[Export ("initWithObjPoints:dictionary:ids:")]
		NativeHandle Constructor (Mat[] objPoints, Dictionary dictionary, Mat ids);

		// -(Dictionary * _Nonnull)getDictionary __attribute__((swift_name("getDictionary()")));
		[Export ("getDictionary")]
		Dictionary Dictionary { get; }

		// -(NSArray<NSArray<Point3f *> *> * _Nonnull)getObjPoints __attribute__((swift_name("getObjPoints()")));
		[Export ("getObjPoints")]
		NSArray<Point3f>[] ObjPoints { get; }

		// -(IntVector * _Nonnull)getIds __attribute__((swift_name("getIds()")));
		[Export ("getIds")]
		IntVector Ids { get; }

		// -(Point3f * _Nonnull)getRightBottomCorner __attribute__((swift_name("getRightBottomCorner()")));
		[Export ("getRightBottomCorner")]
		Point3f RightBottomCorner { get; }

		// -(void)matchImagePoints:(NSArray<Mat *> * _Nonnull)detectedCorners detectedIds:(Mat * _Nonnull)detectedIds objPoints:(Mat * _Nonnull)objPoints imgPoints:(Mat * _Nonnull)imgPoints __attribute__((swift_name("matchImagePoints(detectedCorners:detectedIds:objPoints:imgPoints:)")));
		[Export ("matchImagePoints:detectedIds:objPoints:imgPoints:")]
		void MatchImagePoints (Mat[] detectedCorners, Mat detectedIds, Mat objPoints, Mat imgPoints);

		// -(void)generateImage:(Size2i * _Nonnull)outSize img:(Mat * _Nonnull)img marginSize:(int)marginSize borderBits:(int)borderBits __attribute__((swift_name("generateImage(outSize:img:marginSize:borderBits:)")));
		[Export ("generateImage:img:marginSize:borderBits:")]
		void GenerateImage (Size2i outSize, Mat img, int marginSize, int borderBits);

		// -(void)generateImage:(Size2i * _Nonnull)outSize img:(Mat * _Nonnull)img marginSize:(int)marginSize __attribute__((swift_name("generateImage(outSize:img:marginSize:)")));
		[Export ("generateImage:img:marginSize:")]
		void GenerateImage (Size2i outSize, Mat img, int marginSize);

		// -(void)generateImage:(Size2i * _Nonnull)outSize img:(Mat * _Nonnull)img __attribute__((swift_name("generateImage(outSize:img:)")));
		[Export ("generateImage:img:")]
		void GenerateImage (Size2i outSize, Mat img);
	}

	// @interface CharucoBoard : Board
	[BaseType (typeof(Board))]
	interface CharucoBoard
	{
		// -(instancetype _Nonnull)initWithSize:(Size2i * _Nonnull)size squareLength:(float)squareLength markerLength:(float)markerLength dictionary:(Dictionary * _Nonnull)dictionary ids:(Mat * _Nonnull)ids;
		[Export ("initWithSize:squareLength:markerLength:dictionary:ids:")]
		NativeHandle Constructor (Size2i size, float squareLength, float markerLength, Dictionary dictionary, Mat ids);

		// -(instancetype _Nonnull)initWithSize:(Size2i * _Nonnull)size squareLength:(float)squareLength markerLength:(float)markerLength dictionary:(Dictionary * _Nonnull)dictionary;
		[Export ("initWithSize:squareLength:markerLength:dictionary:")]
		NativeHandle Constructor (Size2i size, float squareLength, float markerLength, Dictionary dictionary);

		// -(void)setLegacyPattern:(BOOL)legacyPattern __attribute__((swift_name("setLegacyPattern(legacyPattern:)")));
		[Export ("setLegacyPattern:")]
		void SetLegacyPattern (bool legacyPattern);

		// -(BOOL)getLegacyPattern __attribute__((swift_name("getLegacyPattern()")));
		[Export ("getLegacyPattern")]
		bool LegacyPattern { get; }

		// -(Size2i * _Nonnull)getChessboardSize __attribute__((swift_name("getChessboardSize()")));
		[Export ("getChessboardSize")]
		Size2i ChessboardSize { get; }

		// -(float)getSquareLength __attribute__((swift_name("getSquareLength()")));
		[Export ("getSquareLength")]
		float SquareLength { get; }

		// -(float)getMarkerLength __attribute__((swift_name("getMarkerLength()")));
		[Export ("getMarkerLength")]
		float MarkerLength { get; }

		// -(NSArray<Point3f *> * _Nonnull)getChessboardCorners __attribute__((swift_name("getChessboardCorners()")));
		[Export ("getChessboardCorners")]
		Point3f[] ChessboardCorners { get; }

		// -(BOOL)checkCharucoCornersCollinear:(Mat * _Nonnull)charucoIds __attribute__((swift_name("checkCharucoCornersCollinear(charucoIds:)")));
		[Export ("checkCharucoCornersCollinear:")]
		bool CheckCharucoCornersCollinear (Mat charucoIds);
	}

	// @interface CharucoDetector : Algorithm
	[BaseType (typeof(Algorithm))]
	interface CharucoDetector
	{
		// -(instancetype _Nonnull)initWithBoard:(CharucoBoard * _Nonnull)board charucoParams:(CharucoParameters * _Nonnull)charucoParams detectorParams:(DetectorParameters * _Nonnull)detectorParams refineParams:(RefineParameters * _Nonnull)refineParams;
		[Export ("initWithBoard:charucoParams:detectorParams:refineParams:")]
		NativeHandle Constructor (CharucoBoard board, CharucoParameters charucoParams, DetectorParameters detectorParams, RefineParameters refineParams);

		// -(instancetype _Nonnull)initWithBoard:(CharucoBoard * _Nonnull)board charucoParams:(CharucoParameters * _Nonnull)charucoParams detectorParams:(DetectorParameters * _Nonnull)detectorParams;
		[Export ("initWithBoard:charucoParams:detectorParams:")]
		NativeHandle Constructor (CharucoBoard board, CharucoParameters charucoParams, DetectorParameters detectorParams);

		// -(instancetype _Nonnull)initWithBoard:(CharucoBoard * _Nonnull)board charucoParams:(CharucoParameters * _Nonnull)charucoParams;
		[Export ("initWithBoard:charucoParams:")]
		NativeHandle Constructor (CharucoBoard board, CharucoParameters charucoParams);

		// -(instancetype _Nonnull)initWithBoard:(CharucoBoard * _Nonnull)board;
		[Export ("initWithBoard:")]
		NativeHandle Constructor (CharucoBoard board);

		// -(CharucoBoard * _Nonnull)getBoard __attribute__((swift_name("getBoard()")));
		[Export ("getBoard")]
		CharucoBoard Board { get; }

		// -(void)setBoard:(CharucoBoard * _Nonnull)board __attribute__((swift_name("setBoard(board:)")));
		[Export ("setBoard:")]
		void SetBoard (CharucoBoard board);

		// -(CharucoParameters * _Nonnull)getCharucoParameters __attribute__((swift_name("getCharucoParameters()")));
		[Export ("getCharucoParameters")]
		CharucoParameters CharucoParameters { get; }

		// -(void)setCharucoParameters:(CharucoParameters * _Nonnull)charucoParameters __attribute__((swift_name("setCharucoParameters(charucoParameters:)")));
		[Export ("setCharucoParameters:")]
		void SetCharucoParameters (CharucoParameters charucoParameters);

		// -(DetectorParameters * _Nonnull)getDetectorParameters __attribute__((swift_name("getDetectorParameters()")));
		[Export ("getDetectorParameters")]
		DetectorParameters DetectorParameters { get; }

		// -(void)setDetectorParameters:(DetectorParameters * _Nonnull)detectorParameters __attribute__((swift_name("setDetectorParameters(detectorParameters:)")));
		[Export ("setDetectorParameters:")]
		void SetDetectorParameters (DetectorParameters detectorParameters);

		// -(RefineParameters * _Nonnull)getRefineParameters __attribute__((swift_name("getRefineParameters()")));
		[Export ("getRefineParameters")]
		RefineParameters RefineParameters { get; }

		// -(void)setRefineParameters:(RefineParameters * _Nonnull)refineParameters __attribute__((swift_name("setRefineParameters(refineParameters:)")));
		[Export ("setRefineParameters:")]
		void SetRefineParameters (RefineParameters refineParameters);

		// -(void)detectBoard:(Mat * _Nonnull)image charucoCorners:(Mat * _Nonnull)charucoCorners charucoIds:(Mat * _Nonnull)charucoIds markerCorners:(NSMutableArray<Mat *> * _Nonnull)markerCorners markerIds:(Mat * _Nonnull)markerIds __attribute__((swift_name("detectBoard(image:charucoCorners:charucoIds:markerCorners:markerIds:)")));
		[Export ("detectBoard:charucoCorners:charucoIds:markerCorners:markerIds:")]
		void DetectBoard (Mat image, Mat charucoCorners, Mat charucoIds, NSMutableArray<Mat> markerCorners, Mat markerIds);

		// -(void)detectBoard:(Mat * _Nonnull)image charucoCorners:(Mat * _Nonnull)charucoCorners charucoIds:(Mat * _Nonnull)charucoIds markerCorners:(NSMutableArray<Mat *> * _Nonnull)markerCorners __attribute__((swift_name("detectBoard(image:charucoCorners:charucoIds:markerCorners:)")));
		[Export ("detectBoard:charucoCorners:charucoIds:markerCorners:")]
		void DetectBoard (Mat image, Mat charucoCorners, Mat charucoIds, NSMutableArray<Mat> markerCorners);

		// -(void)detectBoard:(Mat * _Nonnull)image charucoCorners:(Mat * _Nonnull)charucoCorners charucoIds:(Mat * _Nonnull)charucoIds __attribute__((swift_name("detectBoard(image:charucoCorners:charucoIds:)")));
		[Export ("detectBoard:charucoCorners:charucoIds:")]
		void DetectBoard (Mat image, Mat charucoCorners, Mat charucoIds);

		// -(void)detectDiamonds:(Mat * _Nonnull)image diamondCorners:(NSMutableArray<Mat *> * _Nonnull)diamondCorners diamondIds:(Mat * _Nonnull)diamondIds markerCorners:(NSMutableArray<Mat *> * _Nonnull)markerCorners markerIds:(Mat * _Nonnull)markerIds __attribute__((swift_name("detectDiamonds(image:diamondCorners:diamondIds:markerCorners:markerIds:)")));
		[Export ("detectDiamonds:diamondCorners:diamondIds:markerCorners:markerIds:")]
		void DetectDiamonds (Mat image, NSMutableArray<Mat> diamondCorners, Mat diamondIds, NSMutableArray<Mat> markerCorners, Mat markerIds);

		// -(void)detectDiamonds:(Mat * _Nonnull)image diamondCorners:(NSMutableArray<Mat *> * _Nonnull)diamondCorners diamondIds:(Mat * _Nonnull)diamondIds markerCorners:(NSMutableArray<Mat *> * _Nonnull)markerCorners __attribute__((swift_name("detectDiamonds(image:diamondCorners:diamondIds:markerCorners:)")));
		[Export ("detectDiamonds:diamondCorners:diamondIds:markerCorners:")]
		void DetectDiamonds (Mat image, NSMutableArray<Mat> diamondCorners, Mat diamondIds, NSMutableArray<Mat> markerCorners);

		// -(void)detectDiamonds:(Mat * _Nonnull)image diamondCorners:(NSMutableArray<Mat *> * _Nonnull)diamondCorners diamondIds:(Mat * _Nonnull)diamondIds __attribute__((swift_name("detectDiamonds(image:diamondCorners:diamondIds:)")));
		[Export ("detectDiamonds:diamondCorners:diamondIds:")]
		void DetectDiamonds (Mat image, NSMutableArray<Mat> diamondCorners, Mat diamondIds);
	}

	// @interface CharucoParameters : NSObject
	[BaseType (typeof(NSObject))]
	interface CharucoParameters
	{
		// @property Mat * _Nonnull cameraMatrix;
		[Export ("cameraMatrix", ArgumentSemantic.Assign)]
		Mat CameraMatrix { get; set; }

		// @property Mat * _Nonnull distCoeffs;
		[Export ("distCoeffs", ArgumentSemantic.Assign)]
		Mat DistCoeffs { get; set; }

		// @property int minMarkers;
		[Export ("minMarkers")]
		int MinMarkers { get; set; }

		// @property BOOL tryRefineMarkers;
		[Export ("tryRefineMarkers")]
		bool TryRefineMarkers { get; set; }

		// @property BOOL checkMarkers;
		[Export ("checkMarkers")]
		bool CheckMarkers { get; set; }
	}

	// @interface DetectorParameters : NSObject
	[BaseType (typeof(NSObject))]
	interface DetectorParameters
	{
		// @property int adaptiveThreshWinSizeMin;
		[Export ("adaptiveThreshWinSizeMin")]
		int AdaptiveThreshWinSizeMin { get; set; }

		// @property int adaptiveThreshWinSizeMax;
		[Export ("adaptiveThreshWinSizeMax")]
		int AdaptiveThreshWinSizeMax { get; set; }

		// @property int adaptiveThreshWinSizeStep;
		[Export ("adaptiveThreshWinSizeStep")]
		int AdaptiveThreshWinSizeStep { get; set; }

		// @property double adaptiveThreshConstant;
		[Export ("adaptiveThreshConstant")]
		double AdaptiveThreshConstant { get; set; }

		// @property double minMarkerPerimeterRate;
		[Export ("minMarkerPerimeterRate")]
		double MinMarkerPerimeterRate { get; set; }

		// @property double maxMarkerPerimeterRate;
		[Export ("maxMarkerPerimeterRate")]
		double MaxMarkerPerimeterRate { get; set; }

		// @property double polygonalApproxAccuracyRate;
		[Export ("polygonalApproxAccuracyRate")]
		double PolygonalApproxAccuracyRate { get; set; }

		// @property double minCornerDistanceRate;
		[Export ("minCornerDistanceRate")]
		double MinCornerDistanceRate { get; set; }

		// @property int minDistanceToBorder;
		[Export ("minDistanceToBorder")]
		int MinDistanceToBorder { get; set; }

		// @property double minMarkerDistanceRate;
		[Export ("minMarkerDistanceRate")]
		double MinMarkerDistanceRate { get; set; }

		// @property float minGroupDistance;
		[Export ("minGroupDistance")]
		float MinGroupDistance { get; set; }

		// @property int cornerRefinementMethod;
		[Export ("cornerRefinementMethod")]
		int CornerRefinementMethod { get; set; }

		// @property int cornerRefinementWinSize;
		[Export ("cornerRefinementWinSize")]
		int CornerRefinementWinSize { get; set; }

		// @property float relativeCornerRefinmentWinSize;
		[Export ("relativeCornerRefinmentWinSize")]
		float RelativeCornerRefinmentWinSize { get; set; }

		// @property int cornerRefinementMaxIterations;
		[Export ("cornerRefinementMaxIterations")]
		int CornerRefinementMaxIterations { get; set; }

		// @property double cornerRefinementMinAccuracy;
		[Export ("cornerRefinementMinAccuracy")]
		double CornerRefinementMinAccuracy { get; set; }

		// @property int markerBorderBits;
		[Export ("markerBorderBits")]
		int MarkerBorderBits { get; set; }

		// @property int perspectiveRemovePixelPerCell;
		[Export ("perspectiveRemovePixelPerCell")]
		int PerspectiveRemovePixelPerCell { get; set; }

		// @property double perspectiveRemoveIgnoredMarginPerCell;
		[Export ("perspectiveRemoveIgnoredMarginPerCell")]
		double PerspectiveRemoveIgnoredMarginPerCell { get; set; }

		// @property double maxErroneousBitsInBorderRate;
		[Export ("maxErroneousBitsInBorderRate")]
		double MaxErroneousBitsInBorderRate { get; set; }

		// @property double minOtsuStdDev;
		[Export ("minOtsuStdDev")]
		double MinOtsuStdDev { get; set; }

		// @property double errorCorrectionRate;
		[Export ("errorCorrectionRate")]
		double ErrorCorrectionRate { get; set; }

		// @property float aprilTagQuadDecimate;
		[Export ("aprilTagQuadDecimate")]
		float AprilTagQuadDecimate { get; set; }

		// @property float aprilTagQuadSigma;
		[Export ("aprilTagQuadSigma")]
		float AprilTagQuadSigma { get; set; }

		// @property int aprilTagMinClusterPixels;
		[Export ("aprilTagMinClusterPixels")]
		int AprilTagMinClusterPixels { get; set; }

		// @property int aprilTagMaxNmaxima;
		[Export ("aprilTagMaxNmaxima")]
		int AprilTagMaxNmaxima { get; set; }

		// @property float aprilTagCriticalRad;
		[Export ("aprilTagCriticalRad")]
		float AprilTagCriticalRad { get; set; }

		// @property float aprilTagMaxLineFitMse;
		[Export ("aprilTagMaxLineFitMse")]
		float AprilTagMaxLineFitMse { get; set; }

		// @property int aprilTagMinWhiteBlackDiff;
		[Export ("aprilTagMinWhiteBlackDiff")]
		int AprilTagMinWhiteBlackDiff { get; set; }

		// @property int aprilTagDeglitch;
		[Export ("aprilTagDeglitch")]
		int AprilTagDeglitch { get; set; }

		// @property BOOL detectInvertedMarker;
		[Export ("detectInvertedMarker")]
		bool DetectInvertedMarker { get; set; }

		// @property BOOL useAruco3Detection;
		[Export ("useAruco3Detection")]
		bool UseAruco3Detection { get; set; }

		// @property int minSideLengthCanonicalImg;
		[Export ("minSideLengthCanonicalImg")]
		int MinSideLengthCanonicalImg { get; set; }

		// @property float minMarkerLengthRatioOriginalImg;
		[Export ("minMarkerLengthRatioOriginalImg")]
		float MinMarkerLengthRatioOriginalImg { get; set; }
	}

	// @interface Dictionary : NSObject
	[BaseType (typeof(NSObject))]
	interface Dictionary
	{
		// -(instancetype _Nonnull)initWithBytesList:(Mat * _Nonnull)bytesList _markerSize:(int)_markerSize maxcorr:(int)maxcorr;
		[Export ("initWithBytesList:_markerSize:maxcorr:")]
		NativeHandle Constructor (Mat bytesList, int _markerSize, int maxcorr);

		// -(instancetype _Nonnull)initWithBytesList:(Mat * _Nonnull)bytesList _markerSize:(int)_markerSize;
		[Export ("initWithBytesList:_markerSize:")]
		NativeHandle Constructor (Mat bytesList, int _markerSize);

		// -(BOOL)identify:(Mat * _Nonnull)onlyBits idx:(int * _Nonnull)idx rotation:(int * _Nonnull)rotation maxCorrectionRate:(double)maxCorrectionRate __attribute__((swift_name("identify(onlyBits:idx:rotation:maxCorrectionRate:)")));
		[Export ("identify:idx:rotation:maxCorrectionRate:")]
		unsafe bool Identify (Mat onlyBits, int* idx, int* rotation, double maxCorrectionRate);

		// -(int)getDistanceToId:(Mat * _Nonnull)bits id:(int)id allRotations:(BOOL)allRotations __attribute__((swift_name("getDistanceToId(bits:id:allRotations:)")));
		[Export ("getDistanceToId:id:allRotations:")]
		int GetDistanceToId (Mat bits, int id, bool allRotations);

		// -(int)getDistanceToId:(Mat * _Nonnull)bits id:(int)id __attribute__((swift_name("getDistanceToId(bits:id:)")));
		[Export ("getDistanceToId:id:")]
		int GetDistanceToId (Mat bits, int id);

		// -(void)generateImageMarker:(int)id sidePixels:(int)sidePixels _img:(Mat * _Nonnull)_img borderBits:(int)borderBits __attribute__((swift_name("generateImageMarker(id:sidePixels:_img:borderBits:)")));
		[Export ("generateImageMarker:sidePixels:_img:borderBits:")]
		void GenerateImageMarker (int id, int sidePixels, Mat _img, int borderBits);

		// -(void)generateImageMarker:(int)id sidePixels:(int)sidePixels _img:(Mat * _Nonnull)_img __attribute__((swift_name("generateImageMarker(id:sidePixels:_img:)")));
		[Export ("generateImageMarker:sidePixels:_img:")]
		void GenerateImageMarker (int id, int sidePixels, Mat _img);

		// +(Mat * _Nonnull)getByteListFromBits:(Mat * _Nonnull)bits __attribute__((swift_name("getByteListFromBits(bits:)")));
		[Static]
		[Export ("getByteListFromBits:")]
		Mat GetByteListFromBits (Mat bits);

		// +(Mat * _Nonnull)getBitsFromByteList:(Mat * _Nonnull)byteList markerSize:(int)markerSize __attribute__((swift_name("getBitsFromByteList(byteList:markerSize:)")));
		[Static]
		[Export ("getBitsFromByteList:markerSize:")]
		Mat GetBitsFromByteList (Mat byteList, int markerSize);

		// @property Mat * _Nonnull bytesList;
		[Export ("bytesList", ArgumentSemantic.Assign)]
		Mat BytesList { get; set; }

		// @property int markerSize;
		[Export ("markerSize")]
		int MarkerSize { get; set; }

		// @property int maxCorrectionBits;
		[Export ("maxCorrectionBits")]
		int MaxCorrectionBits { get; set; }
	}

	// @interface GridBoard : Board
	[BaseType (typeof(Board))]
	interface GridBoard
	{
		// -(instancetype _Nonnull)initWithSize:(Size2i * _Nonnull)size markerLength:(float)markerLength markerSeparation:(float)markerSeparation dictionary:(Dictionary * _Nonnull)dictionary ids:(Mat * _Nonnull)ids;
		[Export ("initWithSize:markerLength:markerSeparation:dictionary:ids:")]
		NativeHandle Constructor (Size2i size, float markerLength, float markerSeparation, Dictionary dictionary, Mat ids);

		// -(instancetype _Nonnull)initWithSize:(Size2i * _Nonnull)size markerLength:(float)markerLength markerSeparation:(float)markerSeparation dictionary:(Dictionary * _Nonnull)dictionary;
		[Export ("initWithSize:markerLength:markerSeparation:dictionary:")]
		NativeHandle Constructor (Size2i size, float markerLength, float markerSeparation, Dictionary dictionary);

		// -(Size2i * _Nonnull)getGridSize __attribute__((swift_name("getGridSize()")));
		[Export ("getGridSize")]
		Size2i GridSize { get; }

		// -(float)getMarkerLength __attribute__((swift_name("getMarkerLength()")));
		[Export ("getMarkerLength")]
		float MarkerLength { get; }

		// -(float)getMarkerSeparation __attribute__((swift_name("getMarkerSeparation()")));
		[Export ("getMarkerSeparation")]
		float MarkerSeparation { get; }
	}

	// @interface RefineParameters : NSObject
	[BaseType (typeof(NSObject))]
	interface RefineParameters
	{
		// -(instancetype _Nonnull)initWithMinRepDistance:(float)minRepDistance errorCorrectionRate:(float)errorCorrectionRate checkAllOrders:(BOOL)checkAllOrders;
		[Export ("initWithMinRepDistance:errorCorrectionRate:checkAllOrders:")]
		NativeHandle Constructor (float minRepDistance, float errorCorrectionRate, bool checkAllOrders);

		// -(instancetype _Nonnull)initWithMinRepDistance:(float)minRepDistance errorCorrectionRate:(float)errorCorrectionRate;
		[Export ("initWithMinRepDistance:errorCorrectionRate:")]
		NativeHandle Constructor (float minRepDistance, float errorCorrectionRate);

		// -(instancetype _Nonnull)initWithMinRepDistance:(float)minRepDistance;
		[Export ("initWithMinRepDistance:")]
		NativeHandle Constructor (float minRepDistance);

		// @property float minRepDistance;
		[Export ("minRepDistance")]
		float MinRepDistance { get; set; }

		// @property float errorCorrectionRate;
		[Export ("errorCorrectionRate")]
		float ErrorCorrectionRate { get; set; }

		// @property BOOL checkAllOrders;
		[Export ("checkAllOrders")]
		bool CheckAllOrders { get; set; }
	}

	// @interface BarcodeDetector : GraphicalCodeDetector
	[BaseType (typeof(GraphicalCodeDetector))]
	interface BarcodeDetector
	{
		// -(instancetype _Nonnull)initWithPrototxt_path:(NSString * _Nonnull)prototxt_path model_path:(NSString * _Nonnull)model_path;
		[Export ("initWithPrototxt_path:model_path:")]
		NativeHandle Constructor (string prototxt_path, string model_path);

		// -(BOOL)decodeWithType:(Mat * _Nonnull)img points:(Mat * _Nonnull)points decoded_info:(NSMutableArray<NSString *> * _Nonnull)decoded_info decoded_type:(NSMutableArray<NSString *> * _Nonnull)decoded_type __attribute__((swift_name("decodeWithType(img:points:decoded_info:decoded_type:)")));
		[Export ("decodeWithType:points:decoded_info:decoded_type:")]
		bool DecodeWithType (Mat img, Mat points, NSMutableArray<NSString> decoded_info, NSMutableArray<NSString> decoded_type);

		// -(BOOL)detectAndDecodeWithType:(Mat * _Nonnull)img decoded_info:(NSMutableArray<NSString *> * _Nonnull)decoded_info decoded_type:(NSMutableArray<NSString *> * _Nonnull)decoded_type points:(Mat * _Nonnull)points __attribute__((swift_name("detectAndDecodeWithType(img:decoded_info:decoded_type:points:)")));
		[Export ("detectAndDecodeWithType:decoded_info:decoded_type:points:")]
		bool DetectAndDecodeWithType (Mat img, NSMutableArray<NSString> decoded_info, NSMutableArray<NSString> decoded_type, Mat points);

		// -(BOOL)detectAndDecodeWithType:(Mat * _Nonnull)img decoded_info:(NSMutableArray<NSString *> * _Nonnull)decoded_info decoded_type:(NSMutableArray<NSString *> * _Nonnull)decoded_type __attribute__((swift_name("detectAndDecodeWithType(img:decoded_info:decoded_type:)")));
		[Export ("detectAndDecodeWithType:decoded_info:decoded_type:")]
		bool DetectAndDecodeWithType (Mat img, NSMutableArray<NSString> decoded_info, NSMutableArray<NSString> decoded_type);

		// -(double)getDownsamplingThreshold __attribute__((swift_name("getDownsamplingThreshold()")));
		[Export ("getDownsamplingThreshold")]
		double DownsamplingThreshold { get; }

		// -(BarcodeDetector * _Nonnull)setDownsamplingThreshold:(double)thresh __attribute__((swift_name("setDownsamplingThreshold(thresh:)")));
		[Export ("setDownsamplingThreshold:")]
		BarcodeDetector SetDownsamplingThreshold (double thresh);

		// -(void)getDetectorScales:(FloatVector * _Nonnull)sizes __attribute__((swift_name("getDetectorScales(sizes:)")));
		[Export ("getDetectorScales:")]
		void GetDetectorScales (FloatVector sizes);

		// -(BarcodeDetector * _Nonnull)setDetectorScales:(FloatVector * _Nonnull)sizes __attribute__((swift_name("setDetectorScales(sizes:)")));
		[Export ("setDetectorScales:")]
		BarcodeDetector SetDetectorScales (FloatVector sizes);

		// -(double)getGradientThreshold __attribute__((swift_name("getGradientThreshold()")));
		[Export ("getGradientThreshold")]
		double GradientThreshold { get; }

		// -(BarcodeDetector * _Nonnull)setGradientThreshold:(double)thresh __attribute__((swift_name("setGradientThreshold(thresh:)")));
		[Export ("setGradientThreshold:")]
		BarcodeDetector SetGradientThreshold (double thresh);
	}

	// @interface Video : NSObject
	[BaseType (typeof(NSObject))]
	interface Video
	{
		// @property (readonly, class) int OPTFLOW_USE_INITIAL_FLOW __attribute__((swift_name("OPTFLOW_USE_INITIAL_FLOW")));
		[Static]
		[Export ("OPTFLOW_USE_INITIAL_FLOW")]
		int OPTFLOW_USE_INITIAL_FLOW { get; }

		// @property (readonly, class) int OPTFLOW_LK_GET_MIN_EIGENVALS __attribute__((swift_name("OPTFLOW_LK_GET_MIN_EIGENVALS")));
		[Static]
		[Export ("OPTFLOW_LK_GET_MIN_EIGENVALS")]
		int OPTFLOW_LK_GET_MIN_EIGENVALS { get; }

		// @property (readonly, class) int OPTFLOW_FARNEBACK_GAUSSIAN __attribute__((swift_name("OPTFLOW_FARNEBACK_GAUSSIAN")));
		[Static]
		[Export ("OPTFLOW_FARNEBACK_GAUSSIAN")]
		int OPTFLOW_FARNEBACK_GAUSSIAN { get; }

		// @property (readonly, class) int MOTION_TRANSLATION __attribute__((swift_name("MOTION_TRANSLATION")));
		[Static]
		[Export ("MOTION_TRANSLATION")]
		int MOTION_TRANSLATION { get; }

		// @property (readonly, class) int MOTION_EUCLIDEAN __attribute__((swift_name("MOTION_EUCLIDEAN")));
		[Static]
		[Export ("MOTION_EUCLIDEAN")]
		int MOTION_EUCLIDEAN { get; }

		// @property (readonly, class) int MOTION_AFFINE __attribute__((swift_name("MOTION_AFFINE")));
		[Static]
		[Export ("MOTION_AFFINE")]
		int MOTION_AFFINE { get; }

		// @property (readonly, class) int MOTION_HOMOGRAPHY __attribute__((swift_name("MOTION_HOMOGRAPHY")));
		[Static]
		[Export ("MOTION_HOMOGRAPHY")]
		int MOTION_HOMOGRAPHY { get; }

		// +(RotatedRect * _Nonnull)CamShift:(Mat * _Nonnull)probImage window:(Rect2i * _Nonnull)window criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("CamShift(probImage:window:criteria:)")));
		[Static]
		[Export ("CamShift:window:criteria:")]
		RotatedRect CamShift (Mat probImage, Rect2i window, TermCriteria criteria);

		// +(int)meanShift:(Mat * _Nonnull)probImage window:(Rect2i * _Nonnull)window criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("meanShift(probImage:window:criteria:)")));
		[Static]
		[Export ("meanShift:window:criteria:")]
		int MeanShift (Mat probImage, Rect2i window, TermCriteria criteria);

		// +(int)buildOpticalFlowPyramid:(Mat * _Nonnull)img pyramid:(NSMutableArray<Mat *> * _Nonnull)pyramid winSize:(Size2i * _Nonnull)winSize maxLevel:(int)maxLevel withDerivatives:(BOOL)withDerivatives pyrBorder:(int)pyrBorder derivBorder:(int)derivBorder tryReuseInputImage:(BOOL)tryReuseInputImage __attribute__((swift_name("buildOpticalFlowPyramid(img:pyramid:winSize:maxLevel:withDerivatives:pyrBorder:derivBorder:tryReuseInputImage:)")));
		[Static]
		[Export ("buildOpticalFlowPyramid:pyramid:winSize:maxLevel:withDerivatives:pyrBorder:derivBorder:tryReuseInputImage:")]
		int BuildOpticalFlowPyramid (Mat img, NSMutableArray<Mat> pyramid, Size2i winSize, int maxLevel, bool withDerivatives, int pyrBorder, int derivBorder, bool tryReuseInputImage);

		// +(int)buildOpticalFlowPyramid:(Mat * _Nonnull)img pyramid:(NSMutableArray<Mat *> * _Nonnull)pyramid winSize:(Size2i * _Nonnull)winSize maxLevel:(int)maxLevel withDerivatives:(BOOL)withDerivatives pyrBorder:(int)pyrBorder derivBorder:(int)derivBorder __attribute__((swift_name("buildOpticalFlowPyramid(img:pyramid:winSize:maxLevel:withDerivatives:pyrBorder:derivBorder:)")));
		[Static]
		[Export ("buildOpticalFlowPyramid:pyramid:winSize:maxLevel:withDerivatives:pyrBorder:derivBorder:")]
		int BuildOpticalFlowPyramid (Mat img, NSMutableArray<Mat> pyramid, Size2i winSize, int maxLevel, bool withDerivatives, int pyrBorder, int derivBorder);

		// +(int)buildOpticalFlowPyramid:(Mat * _Nonnull)img pyramid:(NSMutableArray<Mat *> * _Nonnull)pyramid winSize:(Size2i * _Nonnull)winSize maxLevel:(int)maxLevel withDerivatives:(BOOL)withDerivatives pyrBorder:(int)pyrBorder __attribute__((swift_name("buildOpticalFlowPyramid(img:pyramid:winSize:maxLevel:withDerivatives:pyrBorder:)")));
		[Static]
		[Export ("buildOpticalFlowPyramid:pyramid:winSize:maxLevel:withDerivatives:pyrBorder:")]
		int BuildOpticalFlowPyramid (Mat img, NSMutableArray<Mat> pyramid, Size2i winSize, int maxLevel, bool withDerivatives, int pyrBorder);

		// +(int)buildOpticalFlowPyramid:(Mat * _Nonnull)img pyramid:(NSMutableArray<Mat *> * _Nonnull)pyramid winSize:(Size2i * _Nonnull)winSize maxLevel:(int)maxLevel withDerivatives:(BOOL)withDerivatives __attribute__((swift_name("buildOpticalFlowPyramid(img:pyramid:winSize:maxLevel:withDerivatives:)")));
		[Static]
		[Export ("buildOpticalFlowPyramid:pyramid:winSize:maxLevel:withDerivatives:")]
		int BuildOpticalFlowPyramid (Mat img, NSMutableArray<Mat> pyramid, Size2i winSize, int maxLevel, bool withDerivatives);

		// +(int)buildOpticalFlowPyramid:(Mat * _Nonnull)img pyramid:(NSMutableArray<Mat *> * _Nonnull)pyramid winSize:(Size2i * _Nonnull)winSize maxLevel:(int)maxLevel __attribute__((swift_name("buildOpticalFlowPyramid(img:pyramid:winSize:maxLevel:)")));
		[Static]
		[Export ("buildOpticalFlowPyramid:pyramid:winSize:maxLevel:")]
		int BuildOpticalFlowPyramid (Mat img, NSMutableArray<Mat> pyramid, Size2i winSize, int maxLevel);

		// +(void)calcOpticalFlowPyrLK:(Mat * _Nonnull)prevImg nextImg:(Mat * _Nonnull)nextImg prevPts:(Mat * _Nonnull)prevPts nextPts:(Mat * _Nonnull)nextPts status:(Mat * _Nonnull)status err:(Mat * _Nonnull)err winSize:(Size2i * _Nonnull)winSize maxLevel:(int)maxLevel criteria:(TermCriteria * _Nonnull)criteria flags:(int)flags minEigThreshold:(double)minEigThreshold __attribute__((swift_name("calcOpticalFlowPyrLK(prevImg:nextImg:prevPts:nextPts:status:err:winSize:maxLevel:criteria:flags:minEigThreshold:)")));
		[Static]
		[Export ("calcOpticalFlowPyrLK:nextImg:prevPts:nextPts:status:err:winSize:maxLevel:criteria:flags:minEigThreshold:")]
		void CalcOpticalFlowPyrLK (Mat prevImg, Mat nextImg, Mat prevPts, Mat nextPts, Mat status, Mat err, Size2i winSize, int maxLevel, TermCriteria criteria, int flags, double minEigThreshold);

		// +(void)calcOpticalFlowPyrLK:(Mat * _Nonnull)prevImg nextImg:(Mat * _Nonnull)nextImg prevPts:(Mat * _Nonnull)prevPts nextPts:(Mat * _Nonnull)nextPts status:(Mat * _Nonnull)status err:(Mat * _Nonnull)err winSize:(Size2i * _Nonnull)winSize maxLevel:(int)maxLevel criteria:(TermCriteria * _Nonnull)criteria flags:(int)flags __attribute__((swift_name("calcOpticalFlowPyrLK(prevImg:nextImg:prevPts:nextPts:status:err:winSize:maxLevel:criteria:flags:)")));
		[Static]
		[Export ("calcOpticalFlowPyrLK:nextImg:prevPts:nextPts:status:err:winSize:maxLevel:criteria:flags:")]
		void CalcOpticalFlowPyrLK (Mat prevImg, Mat nextImg, Mat prevPts, Mat nextPts, Mat status, Mat err, Size2i winSize, int maxLevel, TermCriteria criteria, int flags);

		// +(void)calcOpticalFlowPyrLK:(Mat * _Nonnull)prevImg nextImg:(Mat * _Nonnull)nextImg prevPts:(Mat * _Nonnull)prevPts nextPts:(Mat * _Nonnull)nextPts status:(Mat * _Nonnull)status err:(Mat * _Nonnull)err winSize:(Size2i * _Nonnull)winSize maxLevel:(int)maxLevel criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("calcOpticalFlowPyrLK(prevImg:nextImg:prevPts:nextPts:status:err:winSize:maxLevel:criteria:)")));
		[Static]
		[Export ("calcOpticalFlowPyrLK:nextImg:prevPts:nextPts:status:err:winSize:maxLevel:criteria:")]
		void CalcOpticalFlowPyrLK (Mat prevImg, Mat nextImg, Mat prevPts, Mat nextPts, Mat status, Mat err, Size2i winSize, int maxLevel, TermCriteria criteria);

		// +(void)calcOpticalFlowPyrLK:(Mat * _Nonnull)prevImg nextImg:(Mat * _Nonnull)nextImg prevPts:(Mat * _Nonnull)prevPts nextPts:(Mat * _Nonnull)nextPts status:(Mat * _Nonnull)status err:(Mat * _Nonnull)err winSize:(Size2i * _Nonnull)winSize maxLevel:(int)maxLevel __attribute__((swift_name("calcOpticalFlowPyrLK(prevImg:nextImg:prevPts:nextPts:status:err:winSize:maxLevel:)")));
		[Static]
		[Export ("calcOpticalFlowPyrLK:nextImg:prevPts:nextPts:status:err:winSize:maxLevel:")]
		void CalcOpticalFlowPyrLK (Mat prevImg, Mat nextImg, Mat prevPts, Mat nextPts, Mat status, Mat err, Size2i winSize, int maxLevel);

		// +(void)calcOpticalFlowPyrLK:(Mat * _Nonnull)prevImg nextImg:(Mat * _Nonnull)nextImg prevPts:(Mat * _Nonnull)prevPts nextPts:(Mat * _Nonnull)nextPts status:(Mat * _Nonnull)status err:(Mat * _Nonnull)err winSize:(Size2i * _Nonnull)winSize __attribute__((swift_name("calcOpticalFlowPyrLK(prevImg:nextImg:prevPts:nextPts:status:err:winSize:)")));
		[Static]
		[Export ("calcOpticalFlowPyrLK:nextImg:prevPts:nextPts:status:err:winSize:")]
		void CalcOpticalFlowPyrLK (Mat prevImg, Mat nextImg, Mat prevPts, Mat nextPts, Mat status, Mat err, Size2i winSize);

		// +(void)calcOpticalFlowPyrLK:(Mat * _Nonnull)prevImg nextImg:(Mat * _Nonnull)nextImg prevPts:(Mat * _Nonnull)prevPts nextPts:(Mat * _Nonnull)nextPts status:(Mat * _Nonnull)status err:(Mat * _Nonnull)err __attribute__((swift_name("calcOpticalFlowPyrLK(prevImg:nextImg:prevPts:nextPts:status:err:)")));
		[Static]
		[Export ("calcOpticalFlowPyrLK:nextImg:prevPts:nextPts:status:err:")]
		void CalcOpticalFlowPyrLK (Mat prevImg, Mat nextImg, Mat prevPts, Mat nextPts, Mat status, Mat err);

		// +(void)calcOpticalFlowFarneback:(Mat * _Nonnull)prev next:(Mat * _Nonnull)next flow:(Mat * _Nonnull)flow pyr_scale:(double)pyr_scale levels:(int)levels winsize:(int)winsize iterations:(int)iterations poly_n:(int)poly_n poly_sigma:(double)poly_sigma flags:(int)flags __attribute__((swift_name("calcOpticalFlowFarneback(prev:next:flow:pyr_scale:levels:winsize:iterations:poly_n:poly_sigma:flags:)")));
		[Static]
		[Export ("calcOpticalFlowFarneback:next:flow:pyr_scale:levels:winsize:iterations:poly_n:poly_sigma:flags:")]
		void CalcOpticalFlowFarneback (Mat prev, Mat next, Mat flow, double pyr_scale, int levels, int winsize, int iterations, int poly_n, double poly_sigma, int flags);

		// +(double)computeECC:(Mat * _Nonnull)templateImage inputImage:(Mat * _Nonnull)inputImage inputMask:(Mat * _Nonnull)inputMask __attribute__((swift_name("computeECC(templateImage:inputImage:inputMask:)")));
		[Static]
		[Export ("computeECC:inputImage:inputMask:")]
		double ComputeECC (Mat templateImage, Mat inputImage, Mat inputMask);

		// +(double)computeECC:(Mat * _Nonnull)templateImage inputImage:(Mat * _Nonnull)inputImage __attribute__((swift_name("computeECC(templateImage:inputImage:)")));
		[Static]
		[Export ("computeECC:inputImage:")]
		double ComputeECC (Mat templateImage, Mat inputImage);

		// +(double)findTransformECC:(Mat * _Nonnull)templateImage inputImage:(Mat * _Nonnull)inputImage warpMatrix:(Mat * _Nonnull)warpMatrix motionType:(int)motionType criteria:(TermCriteria * _Nonnull)criteria inputMask:(Mat * _Nonnull)inputMask gaussFiltSize:(int)gaussFiltSize __attribute__((swift_name("findTransformECC(templateImage:inputImage:warpMatrix:motionType:criteria:inputMask:gaussFiltSize:)")));
		[Static]
		[Export ("findTransformECC:inputImage:warpMatrix:motionType:criteria:inputMask:gaussFiltSize:")]
		double FindTransformECC (Mat templateImage, Mat inputImage, Mat warpMatrix, int motionType, TermCriteria criteria, Mat inputMask, int gaussFiltSize);

		// +(double)findTransformECC:(Mat * _Nonnull)templateImage inputImage:(Mat * _Nonnull)inputImage warpMatrix:(Mat * _Nonnull)warpMatrix motionType:(int)motionType criteria:(TermCriteria * _Nonnull)criteria inputMask:(Mat * _Nonnull)inputMask __attribute__((swift_name("findTransformECC(templateImage:inputImage:warpMatrix:motionType:criteria:inputMask:)")));
		[Static]
		[Export ("findTransformECC:inputImage:warpMatrix:motionType:criteria:inputMask:")]
		double FindTransformECC (Mat templateImage, Mat inputImage, Mat warpMatrix, int motionType, TermCriteria criteria, Mat inputMask);

		// +(double)findTransformECC:(Mat * _Nonnull)templateImage inputImage:(Mat * _Nonnull)inputImage warpMatrix:(Mat * _Nonnull)warpMatrix motionType:(int)motionType criteria:(TermCriteria * _Nonnull)criteria __attribute__((swift_name("findTransformECC(templateImage:inputImage:warpMatrix:motionType:criteria:)")));
		[Static]
		[Export ("findTransformECC:inputImage:warpMatrix:motionType:criteria:")]
		double FindTransformECC (Mat templateImage, Mat inputImage, Mat warpMatrix, int motionType, TermCriteria criteria);

		// +(double)findTransformECC:(Mat * _Nonnull)templateImage inputImage:(Mat * _Nonnull)inputImage warpMatrix:(Mat * _Nonnull)warpMatrix motionType:(int)motionType __attribute__((swift_name("findTransformECC(templateImage:inputImage:warpMatrix:motionType:)")));
		[Static]
		[Export ("findTransformECC:inputImage:warpMatrix:motionType:")]
		double FindTransformECC (Mat templateImage, Mat inputImage, Mat warpMatrix, int motionType);

		// +(double)findTransformECC:(Mat * _Nonnull)templateImage inputImage:(Mat * _Nonnull)inputImage warpMatrix:(Mat * _Nonnull)warpMatrix __attribute__((swift_name("findTransformECC(templateImage:inputImage:warpMatrix:)")));
		[Static]
		[Export ("findTransformECC:inputImage:warpMatrix:")]
		double FindTransformECC (Mat templateImage, Mat inputImage, Mat warpMatrix);

		// +(Mat * _Nonnull)readOpticalFlow:(NSString * _Nonnull)path __attribute__((swift_name("readOpticalFlow(path:)")));
		[Static]
		[Export ("readOpticalFlow:")]
		Mat ReadOpticalFlow (string path);

		// +(BOOL)writeOpticalFlow:(NSString * _Nonnull)path flow:(Mat * _Nonnull)flow __attribute__((swift_name("writeOpticalFlow(path:flow:)")));
		[Static]
		[Export ("writeOpticalFlow:flow:")]
		bool WriteOpticalFlow (string path, Mat flow);

		// +(BackgroundSubtractorMOG2 * _Nonnull)createBackgroundSubtractorMOG2:(int)history varThreshold:(double)varThreshold detectShadows:(BOOL)detectShadows __attribute__((swift_name("createBackgroundSubtractorMOG2(history:varThreshold:detectShadows:)")));
		[Static]
		[Export ("createBackgroundSubtractorMOG2:varThreshold:detectShadows:")]
		BackgroundSubtractorMOG2 CreateBackgroundSubtractorMOG2 (int history, double varThreshold, bool detectShadows);

		// +(BackgroundSubtractorMOG2 * _Nonnull)createBackgroundSubtractorMOG2:(int)history varThreshold:(double)varThreshold __attribute__((swift_name("createBackgroundSubtractorMOG2(history:varThreshold:)")));
		[Static]
		[Export ("createBackgroundSubtractorMOG2:varThreshold:")]
		BackgroundSubtractorMOG2 CreateBackgroundSubtractorMOG2 (int history, double varThreshold);

		// +(BackgroundSubtractorMOG2 * _Nonnull)createBackgroundSubtractorMOG2:(int)history __attribute__((swift_name("createBackgroundSubtractorMOG2(history:)")));
		[Static]
		[Export ("createBackgroundSubtractorMOG2:")]
		BackgroundSubtractorMOG2 CreateBackgroundSubtractorMOG2 (int history);

		// +(BackgroundSubtractorMOG2 * _Nonnull)createBackgroundSubtractorMOG2 __attribute__((swift_name("createBackgroundSubtractorMOG2()")));
		[Static]
		[Export ("createBackgroundSubtractorMOG2")]
		BackgroundSubtractorMOG2 CreateBackgroundSubtractorMOG2 ();

		// +(BackgroundSubtractorKNN * _Nonnull)createBackgroundSubtractorKNN:(int)history dist2Threshold:(double)dist2Threshold detectShadows:(BOOL)detectShadows __attribute__((swift_name("createBackgroundSubtractorKNN(history:dist2Threshold:detectShadows:)")));
		[Static]
		[Export ("createBackgroundSubtractorKNN:dist2Threshold:detectShadows:")]
		BackgroundSubtractorKNN CreateBackgroundSubtractorKNN (int history, double dist2Threshold, bool detectShadows);

		// +(BackgroundSubtractorKNN * _Nonnull)createBackgroundSubtractorKNN:(int)history dist2Threshold:(double)dist2Threshold __attribute__((swift_name("createBackgroundSubtractorKNN(history:dist2Threshold:)")));
		[Static]
		[Export ("createBackgroundSubtractorKNN:dist2Threshold:")]
		BackgroundSubtractorKNN CreateBackgroundSubtractorKNN (int history, double dist2Threshold);

		// +(BackgroundSubtractorKNN * _Nonnull)createBackgroundSubtractorKNN:(int)history __attribute__((swift_name("createBackgroundSubtractorKNN(history:)")));
		[Static]
		[Export ("createBackgroundSubtractorKNN:")]
		BackgroundSubtractorKNN CreateBackgroundSubtractorKNN (int history);

		// +(BackgroundSubtractorKNN * _Nonnull)createBackgroundSubtractorKNN __attribute__((swift_name("createBackgroundSubtractorKNN()")));
		[Static]
		[Export ("createBackgroundSubtractorKNN")]
		BackgroundSubtractorKNN CreateBackgroundSubtractorKNN ();
	}

	// @interface BackgroundSubtractor : Algorithm
	[BaseType (typeof(Algorithm))]
	interface BackgroundSubtractor
	{
		// -(void)apply:(Mat * _Nonnull)image fgmask:(Mat * _Nonnull)fgmask learningRate:(double)learningRate __attribute__((swift_name("apply(image:fgmask:learningRate:)")));
		[Export ("apply:fgmask:learningRate:")]
		void Apply (Mat image, Mat fgmask, double learningRate);

		// -(void)apply:(Mat * _Nonnull)image fgmask:(Mat * _Nonnull)fgmask __attribute__((swift_name("apply(image:fgmask:)")));
		[Export ("apply:fgmask:")]
		void Apply (Mat image, Mat fgmask);

		// -(void)getBackgroundImage:(Mat * _Nonnull)backgroundImage __attribute__((swift_name("getBackgroundImage(backgroundImage:)")));
		[Export ("getBackgroundImage:")]
		void GetBackgroundImage (Mat backgroundImage);
	}

	// @interface BackgroundSubtractorKNN : BackgroundSubtractor
	[BaseType (typeof(BackgroundSubtractor))]
	interface BackgroundSubtractorKNN
	{
		// -(int)getHistory __attribute__((swift_name("getHistory()")));
		[Export ("getHistory")]
		int History { get; }

		// -(void)setHistory:(int)history __attribute__((swift_name("setHistory(history:)")));
		[Export ("setHistory:")]
		void SetHistory (int history);

		// -(int)getNSamples __attribute__((swift_name("getNSamples()")));
		[Export ("getNSamples")]
		int NSamples { get; }

		// -(void)setNSamples:(int)_nN __attribute__((swift_name("setNSamples(_nN:)")));
		[Export ("setNSamples:")]
		void SetNSamples (int _nN);

		// -(double)getDist2Threshold __attribute__((swift_name("getDist2Threshold()")));
		[Export ("getDist2Threshold")]
		double Dist2Threshold { get; }

		// -(void)setDist2Threshold:(double)_dist2Threshold __attribute__((swift_name("setDist2Threshold(_dist2Threshold:)")));
		[Export ("setDist2Threshold:")]
		void SetDist2Threshold (double _dist2Threshold);

		// -(int)getkNNSamples __attribute__((swift_name("getkNNSamples()")));
		[Export ("getkNNSamples")]
		int GetkNNSamples { get; }

		// -(void)setkNNSamples:(int)_nkNN __attribute__((swift_name("setkNNSamples(_nkNN:)")));
		[Export ("setkNNSamples:")]
		void SetkNNSamples (int _nkNN);

		// -(BOOL)getDetectShadows __attribute__((swift_name("getDetectShadows()")));
		[Export ("getDetectShadows")]
		bool DetectShadows { get; }

		// -(void)setDetectShadows:(BOOL)detectShadows __attribute__((swift_name("setDetectShadows(detectShadows:)")));
		[Export ("setDetectShadows:")]
		void SetDetectShadows (bool detectShadows);

		// -(int)getShadowValue __attribute__((swift_name("getShadowValue()")));
		[Export ("getShadowValue")]
		int ShadowValue { get; }

		// -(void)setShadowValue:(int)value __attribute__((swift_name("setShadowValue(value:)")));
		[Export ("setShadowValue:")]
		void SetShadowValue (int value);

		// -(double)getShadowThreshold __attribute__((swift_name("getShadowThreshold()")));
		[Export ("getShadowThreshold")]
		double ShadowThreshold { get; }

		// -(void)setShadowThreshold:(double)threshold __attribute__((swift_name("setShadowThreshold(threshold:)")));
		[Export ("setShadowThreshold:")]
		void SetShadowThreshold (double threshold);
	}

	// @interface BackgroundSubtractorMOG2 : BackgroundSubtractor
	[BaseType (typeof(BackgroundSubtractor))]
	interface BackgroundSubtractorMOG2
	{
		// -(int)getHistory __attribute__((swift_name("getHistory()")));
		[Export ("getHistory")]
		int History { get; }

		// -(void)setHistory:(int)history __attribute__((swift_name("setHistory(history:)")));
		[Export ("setHistory:")]
		void SetHistory (int history);

		// -(int)getNMixtures __attribute__((swift_name("getNMixtures()")));
		[Export ("getNMixtures")]
		int NMixtures { get; }

		// -(void)setNMixtures:(int)nmixtures __attribute__((swift_name("setNMixtures(nmixtures:)")));
		[Export ("setNMixtures:")]
		void SetNMixtures (int nmixtures);

		// -(double)getBackgroundRatio __attribute__((swift_name("getBackgroundRatio()")));
		[Export ("getBackgroundRatio")]
		double BackgroundRatio { get; }

		// -(void)setBackgroundRatio:(double)ratio __attribute__((swift_name("setBackgroundRatio(ratio:)")));
		[Export ("setBackgroundRatio:")]
		void SetBackgroundRatio (double ratio);

		// -(double)getVarThreshold __attribute__((swift_name("getVarThreshold()")));
		[Export ("getVarThreshold")]
		double VarThreshold { get; }

		// -(void)setVarThreshold:(double)varThreshold __attribute__((swift_name("setVarThreshold(varThreshold:)")));
		[Export ("setVarThreshold:")]
		void SetVarThreshold (double varThreshold);

		// -(double)getVarThresholdGen __attribute__((swift_name("getVarThresholdGen()")));
		[Export ("getVarThresholdGen")]
		double VarThresholdGen { get; }

		// -(void)setVarThresholdGen:(double)varThresholdGen __attribute__((swift_name("setVarThresholdGen(varThresholdGen:)")));
		[Export ("setVarThresholdGen:")]
		void SetVarThresholdGen (double varThresholdGen);

		// -(double)getVarInit __attribute__((swift_name("getVarInit()")));
		[Export ("getVarInit")]
		double VarInit { get; }

		// -(void)setVarInit:(double)varInit __attribute__((swift_name("setVarInit(varInit:)")));
		[Export ("setVarInit:")]
		void SetVarInit (double varInit);

		// -(double)getVarMin __attribute__((swift_name("getVarMin()")));
		[Export ("getVarMin")]
		double VarMin { get; }

		// -(void)setVarMin:(double)varMin __attribute__((swift_name("setVarMin(varMin:)")));
		[Export ("setVarMin:")]
		void SetVarMin (double varMin);

		// -(double)getVarMax __attribute__((swift_name("getVarMax()")));
		[Export ("getVarMax")]
		double VarMax { get; }

		// -(void)setVarMax:(double)varMax __attribute__((swift_name("setVarMax(varMax:)")));
		[Export ("setVarMax:")]
		void SetVarMax (double varMax);

		// -(double)getComplexityReductionThreshold __attribute__((swift_name("getComplexityReductionThreshold()")));
		[Export ("getComplexityReductionThreshold")]
		double ComplexityReductionThreshold { get; }

		// -(void)setComplexityReductionThreshold:(double)ct __attribute__((swift_name("setComplexityReductionThreshold(ct:)")));
		[Export ("setComplexityReductionThreshold:")]
		void SetComplexityReductionThreshold (double ct);

		// -(BOOL)getDetectShadows __attribute__((swift_name("getDetectShadows()")));
		[Export ("getDetectShadows")]
		bool DetectShadows { get; }

		// -(void)setDetectShadows:(BOOL)detectShadows __attribute__((swift_name("setDetectShadows(detectShadows:)")));
		[Export ("setDetectShadows:")]
		void SetDetectShadows (bool detectShadows);

		// -(int)getShadowValue __attribute__((swift_name("getShadowValue()")));
		[Export ("getShadowValue")]
		int ShadowValue { get; }

		// -(void)setShadowValue:(int)value __attribute__((swift_name("setShadowValue(value:)")));
		[Export ("setShadowValue:")]
		void SetShadowValue (int value);

		// -(double)getShadowThreshold __attribute__((swift_name("getShadowThreshold()")));
		[Export ("getShadowThreshold")]
		double ShadowThreshold { get; }

		// -(void)setShadowThreshold:(double)threshold __attribute__((swift_name("setShadowThreshold(threshold:)")));
		[Export ("setShadowThreshold:")]
		void SetShadowThreshold (double threshold);

		// -(void)apply:(Mat * _Nonnull)image fgmask:(Mat * _Nonnull)fgmask learningRate:(double)learningRate __attribute__((swift_name("apply(image:fgmask:learningRate:)")));
		[Export ("apply:fgmask:learningRate:")]
		void Apply (Mat image, Mat fgmask, double learningRate);

		// -(void)apply:(Mat * _Nonnull)image fgmask:(Mat * _Nonnull)fgmask __attribute__((swift_name("apply(image:fgmask:)")));
		[Export ("apply:fgmask:")]
		void Apply (Mat image, Mat fgmask);
	}

	// @interface DenseOpticalFlow : Algorithm
	[BaseType (typeof(Algorithm))]
	interface DenseOpticalFlow
	{
		// -(void)calc:(Mat * _Nonnull)I0 I1:(Mat * _Nonnull)I1 flow:(Mat * _Nonnull)flow __attribute__((swift_name("calc(I0:I1:flow:)")));
		[Export ("calc:I1:flow:")]
		void Calc (Mat I0, Mat I1, Mat flow);

		// -(void)collectGarbage __attribute__((swift_name("collectGarbage()")));
		[Export ("collectGarbage")]
		void CollectGarbage ();
	}

	// @interface DISOpticalFlow : DenseOpticalFlow
	[BaseType (typeof(DenseOpticalFlow))]
	interface DISOpticalFlow
	{
		// @property (readonly, class) int PRESET_ULTRAFAST __attribute__((swift_name("PRESET_ULTRAFAST")));
		[Static]
		[Export ("PRESET_ULTRAFAST")]
		int PRESET_ULTRAFAST { get; }

		// @property (readonly, class) int PRESET_FAST __attribute__((swift_name("PRESET_FAST")));
		[Static]
		[Export ("PRESET_FAST")]
		int PRESET_FAST { get; }

		// @property (readonly, class) int PRESET_MEDIUM __attribute__((swift_name("PRESET_MEDIUM")));
		[Static]
		[Export ("PRESET_MEDIUM")]
		int PRESET_MEDIUM { get; }

		// -(int)getFinestScale __attribute__((swift_name("getFinestScale()")));
		[Export ("getFinestScale")]
		int FinestScale { get; }

		// -(void)setFinestScale:(int)val __attribute__((swift_name("setFinestScale(val:)")));
		[Export ("setFinestScale:")]
		void SetFinestScale (int val);

		// -(int)getPatchSize __attribute__((swift_name("getPatchSize()")));
		[Export ("getPatchSize")]
		int PatchSize { get; }

		// -(void)setPatchSize:(int)val __attribute__((swift_name("setPatchSize(val:)")));
		[Export ("setPatchSize:")]
		void SetPatchSize (int val);

		// -(int)getPatchStride __attribute__((swift_name("getPatchStride()")));
		[Export ("getPatchStride")]
		int PatchStride { get; }

		// -(void)setPatchStride:(int)val __attribute__((swift_name("setPatchStride(val:)")));
		[Export ("setPatchStride:")]
		void SetPatchStride (int val);

		// -(int)getGradientDescentIterations __attribute__((swift_name("getGradientDescentIterations()")));
		[Export ("getGradientDescentIterations")]
		int GradientDescentIterations { get; }

		// -(void)setGradientDescentIterations:(int)val __attribute__((swift_name("setGradientDescentIterations(val:)")));
		[Export ("setGradientDescentIterations:")]
		void SetGradientDescentIterations (int val);

		// -(int)getVariationalRefinementIterations __attribute__((swift_name("getVariationalRefinementIterations()")));
		[Export ("getVariationalRefinementIterations")]
		int VariationalRefinementIterations { get; }

		// -(void)setVariationalRefinementIterations:(int)val __attribute__((swift_name("setVariationalRefinementIterations(val:)")));
		[Export ("setVariationalRefinementIterations:")]
		void SetVariationalRefinementIterations (int val);

		// -(float)getVariationalRefinementAlpha __attribute__((swift_name("getVariationalRefinementAlpha()")));
		[Export ("getVariationalRefinementAlpha")]
		float VariationalRefinementAlpha { get; }

		// -(void)setVariationalRefinementAlpha:(float)val __attribute__((swift_name("setVariationalRefinementAlpha(val:)")));
		[Export ("setVariationalRefinementAlpha:")]
		void SetVariationalRefinementAlpha (float val);

		// -(float)getVariationalRefinementDelta __attribute__((swift_name("getVariationalRefinementDelta()")));
		[Export ("getVariationalRefinementDelta")]
		float VariationalRefinementDelta { get; }

		// -(void)setVariationalRefinementDelta:(float)val __attribute__((swift_name("setVariationalRefinementDelta(val:)")));
		[Export ("setVariationalRefinementDelta:")]
		void SetVariationalRefinementDelta (float val);

		// -(float)getVariationalRefinementGamma __attribute__((swift_name("getVariationalRefinementGamma()")));
		[Export ("getVariationalRefinementGamma")]
		float VariationalRefinementGamma { get; }

		// -(void)setVariationalRefinementGamma:(float)val __attribute__((swift_name("setVariationalRefinementGamma(val:)")));
		[Export ("setVariationalRefinementGamma:")]
		void SetVariationalRefinementGamma (float val);

		// -(float)getVariationalRefinementEpsilon __attribute__((swift_name("getVariationalRefinementEpsilon()")));
		[Export ("getVariationalRefinementEpsilon")]
		float VariationalRefinementEpsilon { get; }

		// -(void)setVariationalRefinementEpsilon:(float)val __attribute__((swift_name("setVariationalRefinementEpsilon(val:)")));
		[Export ("setVariationalRefinementEpsilon:")]
		void SetVariationalRefinementEpsilon (float val);

		// -(BOOL)getUseMeanNormalization __attribute__((swift_name("getUseMeanNormalization()")));
		[Export ("getUseMeanNormalization")]
		bool UseMeanNormalization { get; }

		// -(void)setUseMeanNormalization:(BOOL)val __attribute__((swift_name("setUseMeanNormalization(val:)")));
		[Export ("setUseMeanNormalization:")]
		void SetUseMeanNormalization (bool val);

		// -(BOOL)getUseSpatialPropagation __attribute__((swift_name("getUseSpatialPropagation()")));
		[Export ("getUseSpatialPropagation")]
		bool UseSpatialPropagation { get; }

		// -(void)setUseSpatialPropagation:(BOOL)val __attribute__((swift_name("setUseSpatialPropagation(val:)")));
		[Export ("setUseSpatialPropagation:")]
		void SetUseSpatialPropagation (bool val);

		// +(DISOpticalFlow * _Nonnull)create:(int)preset __attribute__((swift_name("create(preset:)")));
		[Static]
		[Export ("create:")]
		DISOpticalFlow Create (int preset);

		// +(DISOpticalFlow * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		DISOpticalFlow Create ();
	}

	// @interface FarnebackOpticalFlow : DenseOpticalFlow
	[BaseType (typeof(DenseOpticalFlow))]
	interface FarnebackOpticalFlow
	{
		// -(int)getNumLevels __attribute__((swift_name("getNumLevels()")));
		[Export ("getNumLevels")]
		int NumLevels { get; }

		// -(void)setNumLevels:(int)numLevels __attribute__((swift_name("setNumLevels(numLevels:)")));
		[Export ("setNumLevels:")]
		void SetNumLevels (int numLevels);

		// -(double)getPyrScale __attribute__((swift_name("getPyrScale()")));
		[Export ("getPyrScale")]
		double PyrScale { get; }

		// -(void)setPyrScale:(double)pyrScale __attribute__((swift_name("setPyrScale(pyrScale:)")));
		[Export ("setPyrScale:")]
		void SetPyrScale (double pyrScale);

		// -(BOOL)getFastPyramids __attribute__((swift_name("getFastPyramids()")));
		[Export ("getFastPyramids")]
		bool FastPyramids { get; }

		// -(void)setFastPyramids:(BOOL)fastPyramids __attribute__((swift_name("setFastPyramids(fastPyramids:)")));
		[Export ("setFastPyramids:")]
		void SetFastPyramids (bool fastPyramids);

		// -(int)getWinSize __attribute__((swift_name("getWinSize()")));
		[Export ("getWinSize")]
		int WinSize { get; }

		// -(void)setWinSize:(int)winSize __attribute__((swift_name("setWinSize(winSize:)")));
		[Export ("setWinSize:")]
		void SetWinSize (int winSize);

		// -(int)getNumIters __attribute__((swift_name("getNumIters()")));
		[Export ("getNumIters")]
		int NumIters { get; }

		// -(void)setNumIters:(int)numIters __attribute__((swift_name("setNumIters(numIters:)")));
		[Export ("setNumIters:")]
		void SetNumIters (int numIters);

		// -(int)getPolyN __attribute__((swift_name("getPolyN()")));
		[Export ("getPolyN")]
		int PolyN { get; }

		// -(void)setPolyN:(int)polyN __attribute__((swift_name("setPolyN(polyN:)")));
		[Export ("setPolyN:")]
		void SetPolyN (int polyN);

		// -(double)getPolySigma __attribute__((swift_name("getPolySigma()")));
		[Export ("getPolySigma")]
		double PolySigma { get; }

		// -(void)setPolySigma:(double)polySigma __attribute__((swift_name("setPolySigma(polySigma:)")));
		[Export ("setPolySigma:")]
		void SetPolySigma (double polySigma);

		// -(int)getFlags __attribute__((swift_name("getFlags()")));
		[Export ("getFlags")]
		int Flags { get; }

		// -(void)setFlags:(int)flags __attribute__((swift_name("setFlags(flags:)")));
		[Export ("setFlags:")]
		void SetFlags (int flags);

		// +(FarnebackOpticalFlow * _Nonnull)create:(int)numLevels pyrScale:(double)pyrScale fastPyramids:(BOOL)fastPyramids winSize:(int)winSize numIters:(int)numIters polyN:(int)polyN polySigma:(double)polySigma flags:(int)flags __attribute__((swift_name("create(numLevels:pyrScale:fastPyramids:winSize:numIters:polyN:polySigma:flags:)")));
		[Static]
		[Export ("create:pyrScale:fastPyramids:winSize:numIters:polyN:polySigma:flags:")]
		FarnebackOpticalFlow Create (int numLevels, double pyrScale, bool fastPyramids, int winSize, int numIters, int polyN, double polySigma, int flags);

		// +(FarnebackOpticalFlow * _Nonnull)create:(int)numLevels pyrScale:(double)pyrScale fastPyramids:(BOOL)fastPyramids winSize:(int)winSize numIters:(int)numIters polyN:(int)polyN polySigma:(double)polySigma __attribute__((swift_name("create(numLevels:pyrScale:fastPyramids:winSize:numIters:polyN:polySigma:)")));
		[Static]
		[Export ("create:pyrScale:fastPyramids:winSize:numIters:polyN:polySigma:")]
		FarnebackOpticalFlow Create (int numLevels, double pyrScale, bool fastPyramids, int winSize, int numIters, int polyN, double polySigma);

		// +(FarnebackOpticalFlow * _Nonnull)create:(int)numLevels pyrScale:(double)pyrScale fastPyramids:(BOOL)fastPyramids winSize:(int)winSize numIters:(int)numIters polyN:(int)polyN __attribute__((swift_name("create(numLevels:pyrScale:fastPyramids:winSize:numIters:polyN:)")));
		[Static]
		[Export ("create:pyrScale:fastPyramids:winSize:numIters:polyN:")]
		FarnebackOpticalFlow Create (int numLevels, double pyrScale, bool fastPyramids, int winSize, int numIters, int polyN);

		// +(FarnebackOpticalFlow * _Nonnull)create:(int)numLevels pyrScale:(double)pyrScale fastPyramids:(BOOL)fastPyramids winSize:(int)winSize numIters:(int)numIters __attribute__((swift_name("create(numLevels:pyrScale:fastPyramids:winSize:numIters:)")));
		[Static]
		[Export ("create:pyrScale:fastPyramids:winSize:numIters:")]
		FarnebackOpticalFlow Create (int numLevels, double pyrScale, bool fastPyramids, int winSize, int numIters);

		// +(FarnebackOpticalFlow * _Nonnull)create:(int)numLevels pyrScale:(double)pyrScale fastPyramids:(BOOL)fastPyramids winSize:(int)winSize __attribute__((swift_name("create(numLevels:pyrScale:fastPyramids:winSize:)")));
		[Static]
		[Export ("create:pyrScale:fastPyramids:winSize:")]
		FarnebackOpticalFlow Create (int numLevels, double pyrScale, bool fastPyramids, int winSize);

		// +(FarnebackOpticalFlow * _Nonnull)create:(int)numLevels pyrScale:(double)pyrScale fastPyramids:(BOOL)fastPyramids __attribute__((swift_name("create(numLevels:pyrScale:fastPyramids:)")));
		[Static]
		[Export ("create:pyrScale:fastPyramids:")]
		FarnebackOpticalFlow Create (int numLevels, double pyrScale, bool fastPyramids);

		// +(FarnebackOpticalFlow * _Nonnull)create:(int)numLevels pyrScale:(double)pyrScale __attribute__((swift_name("create(numLevels:pyrScale:)")));
		[Static]
		[Export ("create:pyrScale:")]
		FarnebackOpticalFlow Create (int numLevels, double pyrScale);

		// +(FarnebackOpticalFlow * _Nonnull)create:(int)numLevels __attribute__((swift_name("create(numLevels:)")));
		[Static]
		[Export ("create:")]
		FarnebackOpticalFlow Create (int numLevels);

		// +(FarnebackOpticalFlow * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		FarnebackOpticalFlow Create ();
	}

	// @interface KalmanFilter : NSObject
	[BaseType (typeof(NSObject))]
	interface KalmanFilter
	{
		// -(instancetype _Nonnull)initWithDynamParams:(int)dynamParams measureParams:(int)measureParams controlParams:(int)controlParams type:(int)type;
		[Export ("initWithDynamParams:measureParams:controlParams:type:")]
		NativeHandle Constructor (int dynamParams, int measureParams, int controlParams, int type);

		// -(instancetype _Nonnull)initWithDynamParams:(int)dynamParams measureParams:(int)measureParams controlParams:(int)controlParams;
		[Export ("initWithDynamParams:measureParams:controlParams:")]
		NativeHandle Constructor (int dynamParams, int measureParams, int controlParams);

		// -(instancetype _Nonnull)initWithDynamParams:(int)dynamParams measureParams:(int)measureParams;
		[Export ("initWithDynamParams:measureParams:")]
		NativeHandle Constructor (int dynamParams, int measureParams);

		// -(Mat * _Nonnull)predict:(Mat * _Nonnull)control __attribute__((swift_name("predict(control:)")));
		[Export ("predict:")]
		Mat Predict (Mat control);

		// -(Mat * _Nonnull)predict __attribute__((swift_name("predict()")));
		[Export ("predict")]
		Mat Predict ();

		// -(Mat * _Nonnull)correct:(Mat * _Nonnull)measurement __attribute__((swift_name("correct(measurement:)")));
		[Export ("correct:")]
		Mat Correct (Mat measurement);

		// @property Mat * _Nonnull statePre;
		[Export ("statePre", ArgumentSemantic.Assign)]
		Mat StatePre { get; set; }

		// @property Mat * _Nonnull statePost;
		[Export ("statePost", ArgumentSemantic.Assign)]
		Mat StatePost { get; set; }

		// @property Mat * _Nonnull transitionMatrix;
		[Export ("transitionMatrix", ArgumentSemantic.Assign)]
		Mat TransitionMatrix { get; set; }

		// @property Mat * _Nonnull controlMatrix;
		[Export ("controlMatrix", ArgumentSemantic.Assign)]
		Mat ControlMatrix { get; set; }

		// @property Mat * _Nonnull measurementMatrix;
		[Export ("measurementMatrix", ArgumentSemantic.Assign)]
		Mat MeasurementMatrix { get; set; }

		// @property Mat * _Nonnull processNoiseCov;
		[Export ("processNoiseCov", ArgumentSemantic.Assign)]
		Mat ProcessNoiseCov { get; set; }

		// @property Mat * _Nonnull measurementNoiseCov;
		[Export ("measurementNoiseCov", ArgumentSemantic.Assign)]
		Mat MeasurementNoiseCov { get; set; }

		// @property Mat * _Nonnull errorCovPre;
		[Export ("errorCovPre", ArgumentSemantic.Assign)]
		Mat ErrorCovPre { get; set; }

		// @property Mat * _Nonnull gain;
		[Export ("gain", ArgumentSemantic.Assign)]
		Mat Gain { get; set; }

		// @property Mat * _Nonnull errorCovPost;
		[Export ("errorCovPost", ArgumentSemantic.Assign)]
		Mat ErrorCovPost { get; set; }
	}

	// @interface SparseOpticalFlow : Algorithm
	[BaseType (typeof(Algorithm))]
	interface SparseOpticalFlow
	{
		// -(void)calc:(Mat * _Nonnull)prevImg nextImg:(Mat * _Nonnull)nextImg prevPts:(Mat * _Nonnull)prevPts nextPts:(Mat * _Nonnull)nextPts status:(Mat * _Nonnull)status err:(Mat * _Nonnull)err __attribute__((swift_name("calc(prevImg:nextImg:prevPts:nextPts:status:err:)")));
		[Export ("calc:nextImg:prevPts:nextPts:status:err:")]
		void Calc (Mat prevImg, Mat nextImg, Mat prevPts, Mat nextPts, Mat status, Mat err);

		// -(void)calc:(Mat * _Nonnull)prevImg nextImg:(Mat * _Nonnull)nextImg prevPts:(Mat * _Nonnull)prevPts nextPts:(Mat * _Nonnull)nextPts status:(Mat * _Nonnull)status __attribute__((swift_name("calc(prevImg:nextImg:prevPts:nextPts:status:)")));
		[Export ("calc:nextImg:prevPts:nextPts:status:")]
		void Calc (Mat prevImg, Mat nextImg, Mat prevPts, Mat nextPts, Mat status);
	}

	// @interface SparsePyrLKOpticalFlow : SparseOpticalFlow
	[BaseType (typeof(SparseOpticalFlow))]
	interface SparsePyrLKOpticalFlow
	{
		// -(Size2i * _Nonnull)getWinSize __attribute__((swift_name("getWinSize()")));
		[Export ("getWinSize")]
		Size2i WinSize { get; }

		// -(void)setWinSize:(Size2i * _Nonnull)winSize __attribute__((swift_name("setWinSize(winSize:)")));
		[Export ("setWinSize:")]
		void SetWinSize (Size2i winSize);

		// -(int)getMaxLevel __attribute__((swift_name("getMaxLevel()")));
		[Export ("getMaxLevel")]
		int MaxLevel { get; }

		// -(void)setMaxLevel:(int)maxLevel __attribute__((swift_name("setMaxLevel(maxLevel:)")));
		[Export ("setMaxLevel:")]
		void SetMaxLevel (int maxLevel);

		// -(TermCriteria * _Nonnull)getTermCriteria __attribute__((swift_name("getTermCriteria()")));
		[Export ("getTermCriteria")]
		TermCriteria TermCriteria { get; }

		// -(void)setTermCriteria:(TermCriteria * _Nonnull)crit __attribute__((swift_name("setTermCriteria(crit:)")));
		[Export ("setTermCriteria:")]
		void SetTermCriteria (TermCriteria crit);

		// -(int)getFlags __attribute__((swift_name("getFlags()")));
		[Export ("getFlags")]
		int Flags { get; }

		// -(void)setFlags:(int)flags __attribute__((swift_name("setFlags(flags:)")));
		[Export ("setFlags:")]
		void SetFlags (int flags);

		// -(double)getMinEigThreshold __attribute__((swift_name("getMinEigThreshold()")));
		[Export ("getMinEigThreshold")]
		double MinEigThreshold { get; }

		// -(void)setMinEigThreshold:(double)minEigThreshold __attribute__((swift_name("setMinEigThreshold(minEigThreshold:)")));
		[Export ("setMinEigThreshold:")]
		void SetMinEigThreshold (double minEigThreshold);

		// +(SparsePyrLKOpticalFlow * _Nonnull)create:(Size2i * _Nonnull)winSize maxLevel:(int)maxLevel crit:(TermCriteria * _Nonnull)crit flags:(int)flags minEigThreshold:(double)minEigThreshold __attribute__((swift_name("create(winSize:maxLevel:crit:flags:minEigThreshold:)")));
		[Static]
		[Export ("create:maxLevel:crit:flags:minEigThreshold:")]
		SparsePyrLKOpticalFlow Create (Size2i winSize, int maxLevel, TermCriteria crit, int flags, double minEigThreshold);

		// +(SparsePyrLKOpticalFlow * _Nonnull)create:(Size2i * _Nonnull)winSize maxLevel:(int)maxLevel crit:(TermCriteria * _Nonnull)crit flags:(int)flags __attribute__((swift_name("create(winSize:maxLevel:crit:flags:)")));
		[Static]
		[Export ("create:maxLevel:crit:flags:")]
		SparsePyrLKOpticalFlow Create (Size2i winSize, int maxLevel, TermCriteria crit, int flags);

		// +(SparsePyrLKOpticalFlow * _Nonnull)create:(Size2i * _Nonnull)winSize maxLevel:(int)maxLevel crit:(TermCriteria * _Nonnull)crit __attribute__((swift_name("create(winSize:maxLevel:crit:)")));
		[Static]
		[Export ("create:maxLevel:crit:")]
		SparsePyrLKOpticalFlow Create (Size2i winSize, int maxLevel, TermCriteria crit);

		// +(SparsePyrLKOpticalFlow * _Nonnull)create:(Size2i * _Nonnull)winSize maxLevel:(int)maxLevel __attribute__((swift_name("create(winSize:maxLevel:)")));
		[Static]
		[Export ("create:maxLevel:")]
		SparsePyrLKOpticalFlow Create (Size2i winSize, int maxLevel);

		// +(SparsePyrLKOpticalFlow * _Nonnull)create:(Size2i * _Nonnull)winSize __attribute__((swift_name("create(winSize:)")));
		[Static]
		[Export ("create:")]
		SparsePyrLKOpticalFlow Create (Size2i winSize);

		// +(SparsePyrLKOpticalFlow * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		SparsePyrLKOpticalFlow Create ();
	}

	// @interface Tracker : NSObject
	[BaseType (typeof(NSObject))]
	interface Tracker
	{
		// -(void)init:(Mat * _Nonnull)image boundingBox:(Rect2i * _Nonnull)boundingBox __attribute__((swift_name("init(image:boundingBox:)")));
		[Export ("init:boundingBox:")]
		void Init (Mat image, Rect2i boundingBox);

		// -(BOOL)update:(Mat * _Nonnull)image boundingBox:(Rect2i * _Nonnull)boundingBox __attribute__((swift_name("update(image:boundingBox:)")));
		[Export ("update:boundingBox:")]
		bool Update (Mat image, Rect2i boundingBox);
	}

	// @interface TrackerDaSiamRPN : Tracker
	[BaseType (typeof(Tracker))]
	interface TrackerDaSiamRPN
	{
		// +(TrackerDaSiamRPN * _Nonnull)create:(TrackerDaSiamRPNParams * _Nonnull)parameters __attribute__((swift_name("create(parameters:)")));
		[Static]
		[Export ("create:")]
		TrackerDaSiamRPN Create (TrackerDaSiamRPNParams parameters);

		// +(TrackerDaSiamRPN * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		TrackerDaSiamRPN Create ();

		// -(float)getTrackingScore __attribute__((swift_name("getTrackingScore()")));
		[Export ("getTrackingScore")]
		float TrackingScore { get; }
	}

	// @interface TrackerDaSiamRPNParams : NSObject
	[BaseType (typeof(NSObject))]
	interface TrackerDaSiamRPNParams
	{
		// @property NSString * _Nonnull model;
		[Export ("model")]
		string Model { get; set; }

		// @property NSString * _Nonnull kernel_cls1;
		[Export ("kernel_cls1")]
		string Kernel_cls1 { get; set; }

		// @property NSString * _Nonnull kernel_r1;
		[Export ("kernel_r1")]
		string Kernel_r1 { get; set; }

		// @property int backend;
		[Export ("backend")]
		int Backend { get; set; }

		// @property int target;
		[Export ("target")]
		int Target { get; set; }
	}

	// @interface TrackerGOTURN : Tracker
	[BaseType (typeof(Tracker))]
	interface TrackerGOTURN
	{
		// +(TrackerGOTURN * _Nonnull)create:(TrackerGOTURNParams * _Nonnull)parameters __attribute__((swift_name("create(parameters:)")));
		[Static]
		[Export ("create:")]
		TrackerGOTURN Create (TrackerGOTURNParams parameters);

		// +(TrackerGOTURN * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		TrackerGOTURN Create ();
	}

	// @interface TrackerGOTURNParams : NSObject
	[BaseType (typeof(NSObject))]
	interface TrackerGOTURNParams
	{
		// @property NSString * _Nonnull modelTxt;
		[Export ("modelTxt")]
		string ModelTxt { get; set; }

		// @property NSString * _Nonnull modelBin;
		[Export ("modelBin")]
		string ModelBin { get; set; }
	}

	// @interface TrackerMIL : Tracker
	[BaseType (typeof(Tracker))]
	interface TrackerMIL
	{
		// +(TrackerMIL * _Nonnull)create:(TrackerMILParams * _Nonnull)parameters __attribute__((swift_name("create(parameters:)")));
		[Static]
		[Export ("create:")]
		TrackerMIL Create (TrackerMILParams parameters);

		// +(TrackerMIL * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		TrackerMIL Create ();
	}

	// @interface TrackerMILParams : NSObject
	[BaseType (typeof(NSObject))]
	interface TrackerMILParams
	{
		// @property float samplerInitInRadius;
		[Export ("samplerInitInRadius")]
		float SamplerInitInRadius { get; set; }

		// @property int samplerInitMaxNegNum;
		[Export ("samplerInitMaxNegNum")]
		int SamplerInitMaxNegNum { get; set; }

		// @property float samplerSearchWinSize;
		[Export ("samplerSearchWinSize")]
		float SamplerSearchWinSize { get; set; }

		// @property float samplerTrackInRadius;
		[Export ("samplerTrackInRadius")]
		float SamplerTrackInRadius { get; set; }

		// @property int samplerTrackMaxPosNum;
		[Export ("samplerTrackMaxPosNum")]
		int SamplerTrackMaxPosNum { get; set; }

		// @property int samplerTrackMaxNegNum;
		[Export ("samplerTrackMaxNegNum")]
		int SamplerTrackMaxNegNum { get; set; }

		// @property int featureSetNumFeatures;
		[Export ("featureSetNumFeatures")]
		int FeatureSetNumFeatures { get; set; }
	}

	// @interface TrackerNano : Tracker
	[BaseType (typeof(Tracker))]
	interface TrackerNano
	{
		// +(TrackerNano * _Nonnull)create:(TrackerNanoParams * _Nonnull)parameters __attribute__((swift_name("create(parameters:)")));
		[Static]
		[Export ("create:")]
		TrackerNano Create (TrackerNanoParams parameters);

		// +(TrackerNano * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		TrackerNano Create ();

		// -(float)getTrackingScore __attribute__((swift_name("getTrackingScore()")));
		[Export ("getTrackingScore")]
		float TrackingScore { get; }
	}

	// @interface TrackerNanoParams : NSObject
	[BaseType (typeof(NSObject))]
	interface TrackerNanoParams
	{
		// @property NSString * _Nonnull backbone;
		[Export ("backbone")]
		string Backbone { get; set; }

		// @property NSString * _Nonnull neckhead;
		[Export ("neckhead")]
		string Neckhead { get; set; }

		// @property int backend;
		[Export ("backend")]
		int Backend { get; set; }

		// @property int target;
		[Export ("target")]
		int Target { get; set; }
	}

	// @interface TrackerVit : Tracker
	[BaseType (typeof(Tracker))]
	interface TrackerVit
	{
		// +(TrackerVit * _Nonnull)create:(TrackerVitParams * _Nonnull)parameters __attribute__((swift_name("create(parameters:)")));
		[Static]
		[Export ("create:")]
		TrackerVit Create (TrackerVitParams parameters);

		// +(TrackerVit * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		TrackerVit Create ();

		// -(float)getTrackingScore __attribute__((swift_name("getTrackingScore()")));
		[Export ("getTrackingScore")]
		float TrackingScore { get; }
	}

	// @interface TrackerVitParams : NSObject
	[BaseType (typeof(NSObject))]
	interface TrackerVitParams
	{
		// @property NSString * _Nonnull net;
		[Export ("net")]
		string Net { get; set; }

		// @property int backend;
		[Export ("backend")]
		int Backend { get; set; }

		// @property int target;
		[Export ("target")]
		int Target { get; set; }

		// @property Scalar * _Nonnull meanvalue;
		[Export ("meanvalue", ArgumentSemantic.Assign)]
		Scalar Meanvalue { get; set; }

		// @property Scalar * _Nonnull stdvalue;
		[Export ("stdvalue", ArgumentSemantic.Assign)]
		Scalar Stdvalue { get; set; }

		// @property float tracking_score_threshold;
		[Export ("tracking_score_threshold")]
		float Tracking_score_threshold { get; set; }
	}

	// @interface VariationalRefinement : DenseOpticalFlow
	[BaseType (typeof(DenseOpticalFlow))]
	interface VariationalRefinement
	{
		// -(void)calcUV:(Mat * _Nonnull)I0 I1:(Mat * _Nonnull)I1 flow_u:(Mat * _Nonnull)flow_u flow_v:(Mat * _Nonnull)flow_v __attribute__((swift_name("calcUV(I0:I1:flow_u:flow_v:)")));
		[Export ("calcUV:I1:flow_u:flow_v:")]
		void CalcUV (Mat I0, Mat I1, Mat flow_u, Mat flow_v);

		// -(int)getFixedPointIterations __attribute__((swift_name("getFixedPointIterations()")));
		[Export ("getFixedPointIterations")]
		int FixedPointIterations { get; }

		// -(void)setFixedPointIterations:(int)val __attribute__((swift_name("setFixedPointIterations(val:)")));
		[Export ("setFixedPointIterations:")]
		void SetFixedPointIterations (int val);

		// -(int)getSorIterations __attribute__((swift_name("getSorIterations()")));
		[Export ("getSorIterations")]
		int SorIterations { get; }

		// -(void)setSorIterations:(int)val __attribute__((swift_name("setSorIterations(val:)")));
		[Export ("setSorIterations:")]
		void SetSorIterations (int val);

		// -(float)getOmega __attribute__((swift_name("getOmega()")));
		[Export ("getOmega")]
		float Omega { get; }

		// -(void)setOmega:(float)val __attribute__((swift_name("setOmega(val:)")));
		[Export ("setOmega:")]
		void SetOmega (float val);

		// -(float)getAlpha __attribute__((swift_name("getAlpha()")));
		[Export ("getAlpha")]
		float Alpha { get; }

		// -(void)setAlpha:(float)val __attribute__((swift_name("setAlpha(val:)")));
		[Export ("setAlpha:")]
		void SetAlpha (float val);

		// -(float)getDelta __attribute__((swift_name("getDelta()")));
		[Export ("getDelta")]
		float Delta { get; }

		// -(void)setDelta:(float)val __attribute__((swift_name("setDelta(val:)")));
		[Export ("setDelta:")]
		void SetDelta (float val);

		// -(float)getGamma __attribute__((swift_name("getGamma()")));
		[Export ("getGamma")]
		float Gamma { get; }

		// -(void)setGamma:(float)val __attribute__((swift_name("setGamma(val:)")));
		[Export ("setGamma:")]
		void SetGamma (float val);

		// -(float)getEpsilon __attribute__((swift_name("getEpsilon()")));
		[Export ("getEpsilon")]
		float Epsilon { get; }

		// -(void)setEpsilon:(float)val __attribute__((swift_name("setEpsilon(val:)")));
		[Export ("setEpsilon:")]
		void SetEpsilon (float val);

		// +(VariationalRefinement * _Nonnull)create __attribute__((swift_name("create()")));
		[Static]
		[Export ("create")]
		VariationalRefinement Create ();
	}
}
