const int LedPin = 3;int ledState = 0;
void setup()
{ 
  pinMode(LedPin, OUTPUT);
  
  Serial.begin(15200);  
}
void loop()
{ 
    char receiveVal;   
   
    if(Serial.available() > 0)
    {        
        receiveVal = Serial.read();
        
       if(receiveVal == '1')    
          ledState = 1;   
       else
          ledState = 0;     
    }   
      
    digitalWrite(LedPin, ledState); 
      
    delay(50);    
}
