
using System.Collections.Immutable;

namespace UI.Code;
// Midi CC Parameter  
public class  ControlChangeParameter{
    public int? ID { get; set; } = 0;
    public string ParamName{ get; set; } = "";
    public bool IsCommon { get; set; } = false;              // If isCommon=true, the ID is normally associated with that particular parameter

    public override string ToString() {
        if (ID == null)
            return "[select]";
        else
            return $"CC ID: {ID}, {ParamName}";
    }

    public ControlChangeParameter() { }

    public ControlChangeParameter(int? iD, string paramName, bool isCommon = false) {
        ID = iD;
        ParamName = paramName;
        IsCommon = isCommon;
    }

    public static ControlChangeParameter GetById(int ID) {
        var knobs = GetList().Where(i => i.ID == ID).ToList();

        if (knobs.Count == 0)
            return new ControlChangeParameter();
        else
            return knobs[0];
     
    }


    public static List<ControlChangeParameter> GetList() {
        var list = new List<ControlChangeParameter> {
            new ControlChangeParameter(null, ""),
            new ControlChangeParameter(0, "Bank Select"),
            new ControlChangeParameter(1, "Modulation Wheel", true),
            new ControlChangeParameter(2, "Breath Controller", true),
            new ControlChangeParameter(3, "undefined"),
            new ControlChangeParameter(4, "Foot Pedal"),
            new ControlChangeParameter(5, "Portamento Time"),
            new ControlChangeParameter(6, "Data Entry"),
            new ControlChangeParameter(7, "Volume", true),
            new ControlChangeParameter(8, "Balance"),
            new ControlChangeParameter(9, "undefined"),
            new ControlChangeParameter(10, "Pan", true),
            new ControlChangeParameter(11, "Expression", true),
            new ControlChangeParameter(12, "Effect Control 1"),
            new ControlChangeParameter(13, "Effect Control 2"),
            new ControlChangeParameter(14, "undefined"),
            new ControlChangeParameter(15, "undefined"),
            new ControlChangeParameter(16, "General Purpose"),
            new ControlChangeParameter(17, "General Purpose"),
            new ControlChangeParameter(18, "General Purpose"),
            new ControlChangeParameter(19, "General Purpose"),
            new ControlChangeParameter(20, "undefined"),
            new ControlChangeParameter(21, "undefined"),
            new ControlChangeParameter(22, "undefined"),
            new ControlChangeParameter(23, "undefined"),
            new ControlChangeParameter(24, "undefined"),
            new ControlChangeParameter(25, "undefined"),
            new ControlChangeParameter(26, "undefined"),
            new ControlChangeParameter(27, "undefined"),
            new ControlChangeParameter(28, "undefined"),
            new ControlChangeParameter(29, "undefined"),
            new ControlChangeParameter(30, "undefined"),
            new ControlChangeParameter(31, "undefined"),
            new ControlChangeParameter(32, "Controller 0"),
            new ControlChangeParameter(33, "Controller 1"),
            new ControlChangeParameter(34, "Controller 2"),
            new ControlChangeParameter(35, "Controller 3"),
            new ControlChangeParameter(36, "Controller 4"),
            new ControlChangeParameter(37, "Controller 5"),
            new ControlChangeParameter(38, "Controller 6"),
            new ControlChangeParameter(39, "Controller 7"),
            new ControlChangeParameter(40, "Controller 8"),
            new ControlChangeParameter(41, "Controller 9"),
            new ControlChangeParameter(42, "Controller 10"),
            new ControlChangeParameter(43, "Controller 11"),
            new ControlChangeParameter(44, "Controller 12"),
            new ControlChangeParameter(45, "Controller 13"),
            new ControlChangeParameter(46, "Controller 14"),
            new ControlChangeParameter(47, "Controller 15"),
            new ControlChangeParameter(48, "Controller 16"),
            new ControlChangeParameter(49, "Controller 17"),
            new ControlChangeParameter(50, "Controller 18"),
            new ControlChangeParameter(51, "Controller 19"),
            new ControlChangeParameter(52, "Controller 20"),
            new ControlChangeParameter(53, "Controller 21"),
            new ControlChangeParameter(54, "Controller 22"),
            new ControlChangeParameter(55, "Controller 23"),
            new ControlChangeParameter(56, "Controller 24"),
            new ControlChangeParameter(57, "Controller 25"),
            new ControlChangeParameter(58, "Controller 26"),
            new ControlChangeParameter(59, "Controller 27"),
            new ControlChangeParameter(60, "Controller 28"),
            new ControlChangeParameter(61, "Controller 29"),
            new ControlChangeParameter(62, "Controller 30"),
            new ControlChangeParameter(63, "Controller 31"),
            new ControlChangeParameter(64, "Sustain Pedal (on/off)", true),
            new ControlChangeParameter(65, "Portamento (on/off)", true),
            new ControlChangeParameter(66, "Sostenuto Pedal (on/off)"),
            new ControlChangeParameter(67, "Soft Pedal (on/off)"),
            new ControlChangeParameter(68, "Legato Pedal (on/off)"),
            new ControlChangeParameter(69, "Hold 2 Pedal (on/off"),
            new ControlChangeParameter(70, "Sound Variation"),
            new ControlChangeParameter(71, "VCF Resonance", true),
            new ControlChangeParameter(72, "Sound Release Time"),
            new ControlChangeParameter(73, "Sound Attack Time"),
            new ControlChangeParameter(74, "VCF Cutoff Frequency", true),
            new ControlChangeParameter(75, "Sound Control 6"),
            new ControlChangeParameter(76, "Sound Control 7"),
            new ControlChangeParameter(77, "Sound Control 8"),
            new ControlChangeParameter(78, "Sound Control 9"),
            new ControlChangeParameter(79, "Sound Control 10"),
            new ControlChangeParameter(80, "Decay or GP Button 1 (on/off)"),
            new ControlChangeParameter(81, "VCF Hi Pass Frequency or GP Button 3 (on/off)"),
            new ControlChangeParameter(82, "GP Button 3 (on/off"),
            new ControlChangeParameter(83, "GP Button 4 (on/off"),
            new ControlChangeParameter(84, "Portamento Amount"),
            new ControlChangeParameter(85, "Undefined"),
            new ControlChangeParameter(86, "Undefined"),
            new ControlChangeParameter(87, "Undefined"),
            new ControlChangeParameter(88, "Undefined"),
            new ControlChangeParameter(89, "Undefined"),
            new ControlChangeParameter(90, "Undefined"),
            new ControlChangeParameter(91, "Reverb Level"),
            new ControlChangeParameter(92, "Tremolo Level"),
            new ControlChangeParameter(93, "Chorus Level"),
            new ControlChangeParameter(94, "Detune Level"),
            new ControlChangeParameter(95, "Phaser Level"),
            new ControlChangeParameter(96, "Data Button 1 increment"),
            new ControlChangeParameter(97, "Data Button 2 increment"),
            new ControlChangeParameter(98, "Non Registered Parameter (LSB)"),
            new ControlChangeParameter(99, "Non Registered Parameter (MSB)"),
            new ControlChangeParameter(100, "Registered Parameter (LSB)"),
            new ControlChangeParameter(101, "Registered Parameter (MSB)"),
            new ControlChangeParameter(102, "Undefined"),
            new ControlChangeParameter(103, "Undefined"),
            new ControlChangeParameter(104, "Undefined"),
            new ControlChangeParameter(105, "Undefined"),
            new ControlChangeParameter(106, "Undefined"),
            new ControlChangeParameter(107, "Undefined"),
            new ControlChangeParameter(108, "Undefined"),
            new ControlChangeParameter(109, "Undefined"),
            new ControlChangeParameter(110, "Undefined"),
            new ControlChangeParameter(111, "Undefined"),
            new ControlChangeParameter(112, "Undefined"),
            new ControlChangeParameter(113, "Undefined"),
            new ControlChangeParameter(114, "Undefined"),
            new ControlChangeParameter(115, "Undefined"),
            new ControlChangeParameter(116, "Undefined"),
            new ControlChangeParameter(117, "Undefined"),
            new ControlChangeParameter(118, "Undefined"),
            new ControlChangeParameter(119, "Undefined"),
            new ControlChangeParameter(120, "All Sound Off"),
            new ControlChangeParameter(121, "All Controllers Off"),
            new ControlChangeParameter(122, "Local Keyboard (on/off)"),
            new ControlChangeParameter(123, "All Notes Off"),
            new ControlChangeParameter(124, "Omni Mode Off"),
            new ControlChangeParameter(125, "Omni Mode On"),
            new ControlChangeParameter(126, "Mono Operation"),
            new ControlChangeParameter(127, "Poly Mode")
        };


        return list;
    }


}




