class PIR
{
  int pin;
  int state;
  int angle;
  
  unsigned long timeMillis = 0;
  
  public: 
    PIR(int PIRpin, int PIRstate, int PIRangle)
    {
      pin = PIRpin;
      state = PIRstate;
      angle = PIRangle;
    }
    void UpdateState()
    {
      int val = digitalRead(pin);
      if (val == HIGH)
      {            
        if (state == LOW) 
        {
          //Serial.print("Motion on Pin: ");
          //Serial.println(pin);
          state = HIGH;
          timeMillis = millis();
        }
      } 
      else 
      {
        if (state == HIGH)
        {
          //Serial.print("Stopped on Pin: ");
          //Serial.println(pin);
          state = LOW;
        }
      }
    }
    int GetPin()
    {
      return pin;
    }
    int GetState()
    {
      return state; 
    }
    int GetAngle()
    {
      return angle;
    }
    unsigned long GetTime()
    {
      return timeMillis;
    }
};

static int ArraySize = 4;
PIR PIR_Array[] = {PIR(2, LOW, 20), PIR(4, LOW, 40), PIR(7, LOW, 60)};

void setup() 
{
  for(int i=0; i<=ArraySize-1; i++)
  {
    pinMode(PIR_Array[i].GetPin(), INPUT);
  }

  Serial.begin(9600);
}

void loop() 
{
  UpdatePIRstate();
  Display();
}

void UpdatePIRstate()
{
  for(int i=0; i<=ArraySize-1; i++)
  {
    PIR_Array[i].UpdateState();
  }
}

void Display()
{
  int index = GetActivePIR_Index();

  if (index != -1)
  {
    Serial.print("Most Recent Pin: ");
    Serial.println(PIR_Array[index].GetPin());
  }
}

int GetActivePIR_Index()
{
  unsigned long greatestTime = 0;
  int greatestIndex = -1;
  for(int i=0; i<=ArraySize-1; i++)
  {
    if(PIR_Array[i].GetState() == HIGH)
    {
      if(PIR_Array[i].GetTime() > greatestTime)
      {
        greatestTime = PIR_Array[i].GetTime();
        greatestIndex = i;
      }
    }
  }

  return greatestIndex;
}
