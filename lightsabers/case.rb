# General Grevous
class Kaleesh < ActiveRecord::Base
  has_many :lightsabers, as: :warrior
end

class Lightsaber < ActiveRecord::Base
  belongs_to :warrior, polymorphic: true, after_add: :set_color

  def set_color(warrior)
    case warrior.class
    when Jedi
      self.color = ['green', 'blue', 'purple'].sample
    when Sith
      self.color = 'red'
    when Kaleesh
      self.color = ['green', 'blue'].sample
    end
  end
end
