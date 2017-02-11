/*************************************************** 
  This is an example sketch for our optical Fingerprint sensor

  Designed specifically to work with the Adafruit BMP085 Breakout 
  ----> http://www.adafruit.com/products/751

  These displays use TTL Serial to communicate, 2 pins are required to 
  interface
  Adafruit invests time and resources providing this open source code, 
  please support Adafruit and open-source hardware by purchasing 
  products from Adafruit!

  Written by Limor Fried/Ladyada for Adafruit Industries.  
  BSD license, all text above must be included in any redistribution
 ****************************************************/
#include <Adafruit_Fingerprint.h>
#include <SoftwareSerial.h>

int getFingerprintIDez();

// pin #2 is IN from sensor (GREEN wire)
// pin #3 is OUT from arduino  (WHITE wire)
SoftwareSerial mySerial(2, 3);
Adafruit_Fingerprint finger = Adafruit_Fingerprint(&mySerial);

// On Leonardo/Micro or others with hardware serial, use those! #0 is green wire, #1 is white
//Adafruit_Fingerprint finger = Adafruit_Fingerprint(&Serial1);
char dato;   //añadido de otro sketch




void setup()  
{
  while (!Serial);  // For Yun/Leo/Micro/Zero/...
  
  Serial.begin(9600);
  Serial.println("Adafruit finger detect test");

  // set the data rate for the sensor serial port
  finger.begin(57600);
  
  if (finger.verifyPassword()) {
    Serial.println("Found fingerprint sensor!");
  } else {
    Serial.println("Did not find fingerprint sensor :(");
    while (1);
  }
  Serial.println("Waiting for valid finger...");
  pinMode(13, OUTPUT);
}





void loop()                     // run over and over again
{
  getFingerprintIDez();
  delay(50);            //don't ned to run this at full speed.
  digitalWrite(13,LOW);
}

uint8_t getFingerprintID() {
  uint8_t p = finger.getImage();
  switch (p) {
    case FINGERPRINT_OK:
      Serial.println("Image taken");
      break;
    case FINGERPRINT_NOFINGER:
      Serial.println("No finger detected");
      return p;
    case FINGERPRINT_PACKETRECIEVEERR:
      Serial.println("Communication error");
      return p;
    case FINGERPRINT_IMAGEFAIL:
      Serial.println("Imaging error");
      return p;
    default:
      Serial.println("Unknown error");
      return p;
  }

  // OK success!

  p = finger.image2Tz();
  switch (p) {
    case FINGERPRINT_OK:
      Serial.println("Image converted");
      break;
    case FINGERPRINT_IMAGEMESS:
      Serial.println("Image too messy");
      return p;
    case FINGERPRINT_PACKETRECIEVEERR:
      Serial.println("Communication error");
      return p;
    case FINGERPRINT_FEATUREFAIL:
      Serial.println("Could not find fingerprint features");
      return p;
    case FINGERPRINT_INVALIDIMAGE:
      Serial.println("Could not find fingerprint features");
      return p;
    default:
      Serial.println("Unknown error");
      return p;
  }
  
  // OK converted!
  p = finger.fingerFastSearch();
  if (p == FINGERPRINT_OK) {
    Serial.println("Found a print match!");
  } else if (p == FINGERPRINT_PACKETRECIEVEERR) {
    Serial.println("Communication error");
    return p;
  } else if (p == FINGERPRINT_NOTFOUND) {
    Serial.println("Did not find a match");
    return p;
  } else {
    Serial.println("Unknown error");
    return p;
  }   
  
  // found a match!
  //Serial.print("Found ID #"); Serial.print(finger.fingerID);   //ANULADO POR OTRO SKETCH
  //Serial.print(" with confidence of "); Serial.println(finger.confidence);   //ANULADO POR OTRO SKETCH
}

// returns -1 if failed, otherwise returns ID #
int getFingerprintIDez() {
  uint8_t p = finger.getImage();
  if (p != FINGERPRINT_OK)  return -1;

  p = finger.image2Tz();
  if (p != FINGERPRINT_OK)  return -1;

  p = finger.fingerFastSearch();
  if (p != FINGERPRINT_OK)  return -1;
  
  
  
  /////////////////decir de que dedo es la huella.
  if(finger.fingerID==8)
  {
    //Serial.println("es el dedo MENIQUE");   //ANULADO POR OTRO SKETCH
    digitalWrite(13,LOW); 
    dato = Serial.write("DEDOS MEÑIQUES");  //añadido de otro sketch
    Serial.println(dato);                  //añadido de otro sketch
   }
   
   
    if(finger.fingerID==9)
  {
    Serial.println("es el dedo ANULAR");
    digitalWrite(13,HIGH);    
    delay(1000);
   }
  
  
  if(finger.fingerID==10)
  {
   //Serial.println("es el dedo MEDIO");   //ANULADO POR OTRO SKETCH
   //digitalWrite(13,LOW);                   //ANULADO POR OTRO SKETCH
   dato = Serial.write("es el dedo METDIO");  //añadido de otro sketch
   Serial.println(dato);                 //añadido de otro sketch
   delay(1000);               //añadido de otro sketch
   }
  
  
  if(finger.fingerID==11)
  {
    Serial.println("es el dedo INDICE");    
    digitalWrite(13,HIGH);    
    delay(1000);
   }
  
  
  
  if(finger.fingerID==12)
  {
    Serial.println("es el dedo PULGAR");
    digitalWrite(13,LOW);    
   }
  
  
  
  
  
  
  
  // found a match!
  //Serial.print("Found ID #"); Serial.print(finger.fingerID); //ANULADO POR OTRO SKETCH
  //Serial.print(" with confidence of "); Serial.println(finger.confidence);  //ANULADO POR OTRO SKETCH
  return finger.fingerID; 
}
