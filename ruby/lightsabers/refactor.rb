'polymorphism'

class Lightsaber < ActiveRecord::Base
  def set_color(warrior)
    self.color = pick_color(warrior.class)
  end

  WARRIOR_COLORS = {
    Jedi =>    ['green', 'blue', 'purple'],
    Sith =>    ['red'],
    Kaleesh => ['green', 'blue']
  }

  def pick_color(klass)
    WARRIOR_COLORS[klass].sample
  end
end
