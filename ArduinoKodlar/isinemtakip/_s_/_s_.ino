#include <dht11.h>
#define DHT11PIN 2 
dht11 DHT11;

void setup()
{
  Serial.begin(9600); 
}


void loop()
{
  int chk = DHT11.read(DHT11PIN);

 // Serial.print("Nem (%): ");
  Serial.print((float)DHT11.humidity, 2);
  Serial.print("*");

  //Serial.print("Temp: ");
  Serial.print((float)DHT11.temperature, 2);
  Serial.print("*");
  
  // Çiğ Oluşma Noktası, Dew Point
  //Serial.print("cig: ");
  Serial.print((float)DHT11.dewPoint(), 2);
  Serial.println();

  delay(2010);

}
